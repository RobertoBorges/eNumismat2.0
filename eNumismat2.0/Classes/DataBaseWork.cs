using System;
using System.Collections.Generic;
using eNumismat2.Properties;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.SQLite;
using System.Windows.Forms;

namespace eNumismat2.Classes
{
    //=====================================================================================================================================================================
    class DataBaseWork
    {
        private static readonly string BackupPath = Settings.Default["DBBackupPath"].ToString();
        private static readonly string DataBaseFile = Path.Combine(Settings.Default["DBFilePath"].ToString(), Settings.Default["DBFile"].ToString());

        //=====================================================================================================================================================================
        public bool CreateNewDataBase()
        {
            // do not use the default Connection string, because with CreateNewDataBase, we want that the DB file will be created.
            using (SQLiteConnection SQLiteConn = new SQLiteConnection("Datasource=" + DataBaseFile + ";Version=3;"))
            {
                MessageBox.Show("DBWork: " + DataBaseFile);
                try
                {
                    SQLiteConn.Open();

                    string SQL = Resources.Create.ToString();

                    using (SQLiteCommand SQLcmd = new SQLiteCommand(SQL, SQLiteConn))
                    {
                        try
                        {
                            SQLcmd.ExecuteNonQuery();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            return false;
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    return false;
                    throw ex;
                }
            }
        }

        //=====================================================================================================================================================================
        private bool CheckBackupDir()
        {
            if (Directory.Exists(BackupPath))
            {
                return true;
            }
            else
            {
                try
                {
                    Directory.CreateDirectory(BackupPath);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        //=====================================================================================================================================================================
        public bool ExcecuteBackup()
        {
            if (CheckBackupDir())
            {
                string SourceFile = DataBaseFile;
                string DestFile = Path.Combine(BackupPath, DateTime.Now.ToString("yyyy_MM_dd-HHmmss") + ".encBack");

                using (var source = new SQLiteConnection("Datasource=" + DataBaseFile + ";Version=3;FailIfMissing=True;"))
                {
                    using (var destination = new SQLiteConnection("Data Source=" + DestFile))
                    {
                        try
                        {
                            source.Open();

                            if (Settings.Default.CompressDBBeforeBackup == true)
                            {
                                CompactDatabase(source);
                            }

                            destination.Open();

                            source.BackupDatabase(destination, "main", "main", -1, null, 0);

                            return true;
                        }
                        catch (Exception ex)
                        {
                            return false;
                            throw ex;
                        }
                    }
                }
            }
            return false;
        }

        //=====================================================================================================================================================================
        public bool CompactDatabase(SQLiteConnection Database = null)
        {
            if (Database == null)
            {
                Database = new SQLiteConnection("Datasource=" + DataBaseFile + ";Version=3;FailIfMissing=True;");
            }

            using (SQLiteCommand cmd = Database.CreateCommand())
            {
                cmd.CommandText = "vacuum";

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                    throw ex;
                }
            }
        }

        //=====================================================================================================================================================================
        public DataTable GetTagCollection()
        {
            using (SQLiteConnection SQLiteConn = new SQLiteConnection("Datasource=" + DataBaseFile + ";Version=3;FailIfMissing=True;"))
            {
                try
                {
                    SQLiteConn.Open();

                    string SQL = "SELECT [tag] FROM [tags]";

                    using (SQLiteCommand command = new SQLiteCommand(SQL, SQLiteConn))
                    {
                        using (SQLiteDataAdapter da_TagCollection = new SQLiteDataAdapter(command))
                        {
                            DataTable dt_TagCollection = new DataTable();

                            try
                            {
                                da_TagCollection.Fill(dt_TagCollection);

                                return dt_TagCollection;
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void DeleteTagFromTagCollection(List<string>Tags)
        {
            using (SQLiteConnection SQLiteConn = new SQLiteConnection("Datasource=" + DataBaseFile + ";Version=3;FailIfMissing=True;"))
            {
                try
                {
                    SQLiteConn.Open();

                    foreach (string Item in Tags)
                    {
                        string SQL = "DELETE FROM [tags] WHERE [tag] = (@TagItems)";

                        using (SQLiteCommand command = new SQLiteCommand(SQL, SQLiteConn))
                        {
                            command.Parameters.AddWithValue("@TagItems", Item);

                            try
                            {
                                command.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                throw ex;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        //=====================================================================================================================================================================
        public int ContactCounter()
        {
            int _rowCounter = 0;

            using (SQLiteConnection SQLiteConn = new SQLiteConnection("Datasource=" + DataBaseFile + ";Version=3;FailIfMissing=True;"))
            {
                try
                {
                    SQLiteConn.Open();

                    string SQL = "SELECT COUNT (*) FROM `contacts`";

                    using (SQLiteCommand SQLcmd = new SQLiteCommand(SQL, SQLiteConn))
                    {
                        try
                        {
                            _rowCounter = Convert.ToInt32(SQLcmd.ExecuteScalar());

                            return _rowCounter;
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}

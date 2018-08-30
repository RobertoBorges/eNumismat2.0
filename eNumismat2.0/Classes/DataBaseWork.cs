using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;

namespace eNumismat2._0.Classes
{
    class DataBaseWork
    {
        private readonly string BackupPath = Properties.Settings.Default.DBBackupPath;
        private readonly string DataBaseFile = Path.Combine(Properties.Settings.Default.DBFilePath, Properties.Settings.Default.DBFile);

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
                if (!string.IsNullOrEmpty(Properties.Settings.Default.DBFile))
                {
                    string SourceFile = DataBaseFile;
                    string DestFile = Path.Combine(BackupPath, DateTime.Now.ToString("yyyy_MM_dd-HHmmss") + ".encBack");

                    using (var source = new SQLiteConnection("Data Source=" + SourceFile))
                    {
                        using (var destination = new SQLiteConnection("Data Source=" + DestFile))
                        {
                            try
                            {
                                source.Open();

                                if (Properties.Settings.Default.CompressDBBeforeBackup == true)
                                {
                                    CompactDatabase(source);
                                }

                                destination.Open();

                                source.BackupDatabase(destination, "main", "main", -1, null, 0);

                                return true;
                            }
                            catch (Exception ex)
                            {
                                //MessageBox.Show(ex.Message);
                                return false;
                            }
                        }
                    }
                }
                return false;
            }
            return false;
        }

        //=====================================================================================================================================================================
        public bool CompactDatabase(SQLiteConnection Database = null)
        {
            if (Database == null)
            {
                Database = new SQLiteConnection("DataSource=" + DataBaseFile);
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
                }
            }
        }
    }
}

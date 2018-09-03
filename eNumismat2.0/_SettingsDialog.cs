using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;

namespace eNumismat2._0
{
    //=====================================================================================================================================================================
    public partial class _SettingsDialog : Form
    {
        StringCollection DbBackupPathCollection;
        Classes.DataBaseWork DBWorker = new Classes.DataBaseWork();

        //=====================================================================================================================================================================
        public _SettingsDialog()
        {
            InitializeComponent();
        }

        //=====================================================================================================================================================================
        private void _SettingsDialog_Load(object sender, EventArgs e)
        {
            // Set Button state corresponding to the saved settings
            btn_DbBackupOnAppClose.Value = Properties.Settings.Default.BackupDBOnAppClose;
            btn_DbCompressBeforeBackup.Value = Properties.Settings.Default.CompressDBBeforeBackup;
            btn_UseValidation.Value = Properties.Settings.Default.AddressBook_UseValidation;
            btn_MinimizeToTray.Value = Properties.Settings.Default.MinimizeToTray;

            // why is this button always set to false?
            btn_UsePassword.Value = Properties.Settings.Default.UsePasswordProtection;

            // Get Properties for generating the ComboBox (DB Backup Path)
            if (Properties.Settings.Default.DBBackupPath == null)
            {
                DbBackupPathCollection = new StringCollection();
            }
            else
            {
                DbBackupPathCollection = Properties.Settings.Default.DBBackupPathCollection;
                foreach (string Item in DbBackupPathCollection)
                {
                    cb_DbBackupPath.Items.Add(Item);
                }
            }
            cb_DbBackupPath.SelectedItem = Properties.Settings.Default.DBBackupPath;

            FillListBoxTagCollection();
        }

        //=====================================================================================================================================================================
        private void DeleteSelectedTags()
        {
            List<string> TagItems = new List<string>();
            
            foreach (var Tag in ListBox_TagCollection.CheckedItems)
            {
                TagItems.Add(Tag.ToString());

                DBWorker.DeleteTagFromTagCollection(TagItems);
            }
            ListBox_TagCollection.Items.Clear();

            FillListBoxTagCollection();
        }

        //=====================================================================================================================================================================
        private void FillListBoxTagCollection()
        {
            try
            {
                DataTable TagCollection = DBWorker.GetTagCollection();

                foreach (DataRow Tag in TagCollection.Rows)
                {
                    ListBox_TagCollection.Items.Add(Tag[0].ToString());

                    // only for testing --> to use listbox or to use token exitor 
                    tokenEditor1.Tokens.Add(new EditToken(Tag[0].ToString(), Tag[0].ToString()));
                }

                // only for testing --> to use listbox or to use token exitor 
                for (int i = 0; i < tokenEditor1.Tokens.Count(); i++)
                {
                    tokenEditor1.SelectedTokens.Add(tokenEditor1.Tokens[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //=====================================================================================================================================================================
        private void Btn_SelectDbBackupPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog BackupFolder = new FolderBrowserDialog();

            if (BackupFolder.ShowDialog() == DialogResult.OK)
            {
                cb_DbBackupPath.Items.Add(BackupFolder.SelectedPath);
                cb_DbBackupPath.SelectedItem = BackupFolder.SelectedPath;

                DbBackupPathCollection.Add(BackupFolder.SelectedPath);
            }
        }

        //=====================================================================================================================================================================
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            // General Application Settings
            Properties.Settings.Default.MinimizeToTray = btn_MinimizeToTray.Value;

            // Database Settings
            Properties.Settings.Default.BackupDBOnAppClose = btn_DbBackupOnAppClose.Value;
            Properties.Settings.Default.CompressDBBeforeBackup = btn_DbCompressBeforeBackup.Value;
            Properties.Settings.Default.AddressBook_UseValidation = btn_UseValidation.Value;

            Properties.Settings.Default.DBBackupPathCollection = DbBackupPathCollection;
            Properties.Settings.Default.DBBackupPath = cb_DbBackupPath.SelectedItem.ToString();

            // Save all Settings
            Properties.Settings.Default.Save();

            // if Settings are saved, Hide the form
            Hide();
        }

        //=====================================================================================================================================================================
        private void buttonX3_Click(object sender, EventArgs e)
        {
            DeleteSelectedTags();
        }

        //=====================================================================================================================================================================
        private void BtnUsePassword_ValueChanged(object sender, EventArgs e)
        {
            if (SetPasswordProtection())
            {
                Properties.Settings.Default.UsePasswordProtection = btn_UsePassword.Value;
                Properties.Settings.Default.Save();
            }
            else
            {
                btn_UsePassword.Value = false;
            }
        }

        //=====================================================================================================================================================================
        private bool SetPasswordProtection()
        {
            if (btn_UsePassword.Value == true)
            {
                _SettingsDialog_PasswordProtection PWProtect = new _SettingsDialog_PasswordProtection();

                if (PWProtect.ShowDialog() == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

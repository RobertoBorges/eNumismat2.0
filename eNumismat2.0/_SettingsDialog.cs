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

namespace eNumismat2._0
{
    public partial class _SettingsDialog : Form
    {
        StringCollection DbBackupPathCollection;

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
    }
}

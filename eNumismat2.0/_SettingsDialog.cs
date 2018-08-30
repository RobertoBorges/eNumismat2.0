using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eNumismat2._0
{
    public partial class _SettingsDialog : Form
    {
        public _SettingsDialog()
        {
            InitializeComponent();
            btn_DbBackupOnAppClose.Value = Properties.Settings.Default.BackupDBOnAppClose;
            btn_DbCompressBeforeBackup.Value = Properties.Settings.Default.CompressDBBeforeBackup;
            btn_UseValidation.Value = Properties.Settings.Default.AddressBook_UseValidation;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BackupDBOnAppClose = btn_DbBackupOnAppClose.Value;
            Properties.Settings.Default.CompressDBBeforeBackup = btn_DbCompressBeforeBackup.Value;
            Properties.Settings.Default.AddressBook_UseValidation = btn_UseValidation.Value;

            Properties.Settings.Default.Save();

            Hide();
        }

        private void btn_SelectDbBackupPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog BackupFolder = new FolderBrowserDialog();

            if (BackupFolder.ShowDialog() == DialogResult.OK)
            {
                cb_DbBackupPath.Items.Add(BackupFolder.SelectedPath);
                cb_DbBackupPath.SelectedItem = BackupFolder.SelectedPath;
            }
        }
    }
}

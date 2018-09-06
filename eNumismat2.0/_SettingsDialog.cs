using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Specialized;
using DevComponents.DotNetBar.Controls;
using eNumismat2.Properties;
using eNumismat2.Classes;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using DevComponents.DotNetBar;

namespace eNumismat2
{
    //=====================================================================================================================================================================
    public partial class _SettingsDialog : Form
    {
        StringCollection DbBackupPathCollection;

        DataBaseWork DBWorker = new DataBaseWork();

        //=====================================================================================================================================================================
        public _SettingsDialog()
        {
            InitializeComponent();
        }

        //=====================================================================================================================================================================
        private void _SettingsDialog_Load(object sender, EventArgs e)
        {
            // Set Button state corresponding to the saved settings
            btn_DbBackupOnAppClose.Value = Settings.Default.BackupDBOnAppClose;
            btn_DbCompressBeforeBackup.Value = Settings.Default.CompressDBBeforeBackup;
            btn_UseValidation.Value = Settings.Default.AddressBook_UseValidation;
            btn_MinimizeToTray.Value = Settings.Default.MinimizeToTray;

            // why is this button always set to false?
            btn_UsePassword.Value = Settings.Default.UsePasswordProtection;

            // Get Properties for generating the ComboBox (DB Backup Path)
            if (string.IsNullOrEmpty(Settings.Default["DBBackupPath"].ToString()))
            {
                DbBackupPathCollection = new StringCollection();
            }
            else
            {
                DbBackupPathCollection = Settings.Default.DBBackupPathCollection;

                foreach (string Item in DbBackupPathCollection)
                {
                    cb_DbBackupPath.Items.Add(Item);
                }
            }
            cb_DbBackupPath.SelectedItem = Settings.Default["DBBackupPath"].ToString();

            FillListBoxTagCollection();

            if (cb_StyleSelector.Items.Contains(Settings.Default["CurrentColorTheme"].ToString()))
            {
                cb_StyleSelector.SelectedItem = Settings.Default["CurrentColorTheme"].ToString();
            }
            else
            {
                cb_StyleSelector.SelectedItem = StyleRetroBlue;
            }
            //cb_StyleSelector.DataSource = styleManager1.MetroColorParameters.ThemeName;
        }

        //=====================================================================================================================================================================
        private void DeleteSelectedTags()
        {
            List<string> TagItems = new List<string>();
            
            foreach (var Token in ListBox_TagCollection.CheckedItems)
            {
                tokenEditor1.Tokens.Remove(new EditToken(Token.ToString()));

                TagItems.Add(Token.ToString());
                DBWorker.DeleteTagFromTagCollection(TagItems);
            }
            ListBox_TagCollection.Items.Clear();
            tokenEditor1.Tokens.Clear();
            

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
            { }
        }

        //=====================================================================================================================================================================
        private void Btn_SelectDbBackupPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog BackupFolder = new FolderBrowserDialog();

            if (BackupFolder.ShowDialog() == DialogResult.OK)
            {
                if (!DbBackupPathCollection.Contains(BackupFolder.SelectedPath))
                {
                    DbBackupPathCollection.Add(BackupFolder.SelectedPath);
                    cb_DbBackupPath.Items.Add(BackupFolder.SelectedPath);
                }
                cb_DbBackupPath.SelectedItem = BackupFolder.SelectedPath;
            }
        }

        //=====================================================================================================================================================================
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            // General Application Settings
            Settings.Default["MinimizeToTray"] = btn_MinimizeToTray.Value;

            // Database Settings
            Settings.Default["BackupDBOnAppClose"] = btn_DbBackupOnAppClose.Value;
            Settings.Default["CompressDBBeforeBackup"] = btn_DbCompressBeforeBackup.Value;
            Settings.Default["AddressBook_UseValidation"] = btn_UseValidation.Value;

            Settings.Default["DBBackupPathCollection"] = DbBackupPathCollection;

            if (cb_DbBackupPath.SelectedItem != null)
            {
                Settings.Default["DBBackupPath"] = cb_DbBackupPath.SelectedItem.ToString();
            }

            // Save all Settings
            Settings.Default.Save();

            // if Settings are saved, Hide the form
            Hide();
        }

        //=====================================================================================================================================================================
        private void ButtonX3_Click(object sender, EventArgs e)
        {
            DeleteSelectedTags();
        }

        //=====================================================================================================================================================================
        private void BtnUsePassword_ValueChanged(object sender, EventArgs e)
        {
            if (btn_UsePassword.Value == true)
            {
                PWProtectionLogic();
            }

            Settings.Default.UsePasswordProtection = btn_UsePassword.Value;
            Settings.Default.Save();
        }

        //=====================================================================================================================================================================
        private void PWProtectionLogic()
        {
            if (Settings.Default.UsePasswordProtection == true && !string.IsNullOrEmpty(Settings.Default.CurrentUserPassword))
            {
                btn_changePW.Visible = true;
                btn_changePW.Enabled = true;
            }
            else if (Settings.Default.UsePasswordProtection == true && string.IsNullOrEmpty(Settings.Default.CurrentUserPassword))
            {
                btn_UsePassword.Value = false;

                btn_changePW.Visible = false;
                btn_changePW.Enabled = false;
            }
            else if (Settings.Default.UsePasswordProtection == false && !string.IsNullOrEmpty(Settings.Default.CurrentUserPassword))
            {
                btn_changePW.Visible = true;
                btn_changePW.Enabled = true;
            }
            else
            {
                SetPasswordProtection();
            }
        }

        
        //=====================================================================================================================================================================
        private bool SetPasswordProtection()
        {
            _SettingsDialog_PasswordProtection PWProtect = new _SettingsDialog_PasswordProtection();
            if (PWProtect.ShowDialog() == DialogResult.OK)
            {
                btn_changePW.Visible = true;
                btn_changePW.Enabled = true;

                return true;
            }
            else
            {
                btn_changePW.Visible = false;
                btn_changePW.Enabled = false;

                btn_UsePassword.Value = false;

                return false;
            }
        }

        //=====================================================================================================================================================================
        private void Btn_changePW_Click(object sender, EventArgs e)
        {
            _SettingsDialog_PasswordProtection PWProtect = new _SettingsDialog_PasswordProtection();
            PWProtect.ShowDialog();
        }


        private void cb_StyleSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //StyleManager.ChangeStyle(eStyle.VisualStudio2012Light, );
            //styleManager1.MetroColorParameters.ThemeName 

            //Settings.Default.CurrentColorTheme = cb_StyleSelector.SelectedItem.ToString();           
        }
    }
}

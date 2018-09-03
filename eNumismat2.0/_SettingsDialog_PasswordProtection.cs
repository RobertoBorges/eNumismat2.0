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
    //=====================================================================================================================================================================
    public partial class _SettingsDialog_PasswordProtection : Form
    {
        //=====================================================================================================================================================================
        public _SettingsDialog_PasswordProtection()
        {
            InitializeComponent();

            btn_Cancel.DialogResult = DialogResult.Cancel;
            btn_Save.DialogResult = DialogResult.OK;
        }

        //=====================================================================================================================================================================
        private void _SettingsDialog_PasswordProtection_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.CurrentUserPassword))
            {
                tb_CurrentPassword.Enabled = true;
            }
            else
            {
                tb_CurrentPassword.Enabled = false;
            }
        }

        //=====================================================================================================================================================================
        private void BtnSave_Click(object sender, EventArgs e)
        {            
            Classes.GetHash EncryptPW = new Classes.GetHash();
            if (tb_CurrentPassword.Enabled == true)
            {
                if (!string.IsNullOrEmpty(tb_CurrentPassword.Text))
                {
                    
                    if (EncryptPW.Calculate(tb_CurrentPassword.Text) == Properties.Settings.Default.CurrentUserPassword)
                    {
                        MessageBox.Show("Current PW is correct");

                        if (tb_NewPassword.Text.CompareTo(tb_PasswordConfirmation.Text) == 0)
                        {
                            Properties.Settings.Default.CurrentUserPassword = EncryptPW.Calculate(tb_NewPassword.Text);
                            Properties.Settings.Default.Save();

                            Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Current Password isn't correct." + Environment.NewLine + "Please try again!", "Error");

                        tb_CurrentPassword.Text = "";
                        tb_CurrentPassword.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("You need to enter the current Password, before you can change it!", "Error");
                }
            }
            else
            {
                if (tb_NewPassword.Text.CompareTo(tb_PasswordConfirmation.Text) == 0)
                {
                    Properties.Settings.Default.CurrentUserPassword = EncryptPW.Calculate(tb_NewPassword.Text);
                    Properties.Settings.Default.Save();
                }
            }
        }

        //=====================================================================================================================================================================
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            
        }

        //private string EncryptPWString(string input)
        //{
        //    byte[] CurrentPassword = Encoding.Unicode.GetBytes(input);
        //    byte[] encryptedText = ProtectedData.Protect(CurrentPassword, DataProtectionScope.CurrentUser);
        //    return Convert.ToBase64String(encryptedText);
        //}
    }
}

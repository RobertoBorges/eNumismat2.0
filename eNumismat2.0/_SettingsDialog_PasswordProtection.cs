using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eNumismat2.Properties;
using eNumismat2.Classes;

namespace eNumismat2
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
            if (!string.IsNullOrEmpty(Settings.Default.CurrentUserPassword))
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
            GetHash EncryptPW = new GetHash();

            if (tb_CurrentPassword.Enabled == true)
            {
                if (!string.IsNullOrEmpty(tb_CurrentPassword.Text))
                {
                    if (string.Equals(EncryptPW.Calculate(tb_CurrentPassword.Text), Settings.Default.CurrentUserPassword))
                    {
                        if (!string.IsNullOrEmpty(tb_NewPassword.Text))
                        {
                            if (string.Equals(tb_NewPassword.Text, tb_PasswordConfirmation.Text))
                            {
                                Settings.Default.CurrentUserPassword = EncryptPW.Calculate(tb_NewPassword.Text);
                                Settings.Default.Save();
                            }
                        }
                        else
                        {
                            if (MessageBox.Show(GlobalStrings._PWChangeDialog_PasswordEmpty_Text,
                                GlobalStrings._PWChangeDialog_Title,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error) == DialogResult.OK)
                            {
                                DialogResult = DialogResult.None;
                                tb_NewPassword.Text = null;
                                tb_PasswordConfirmation = null;
                                tb_NewPassword.Focus();
                            }
                        }
                    }
                    else
                    {
                        if (MessageBox.Show(GlobalStrings._PWChangeDialog_CurrentPWnotCorrect_Text,
                            GlobalStrings._PWChangeDialog_Title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            tb_CurrentPassword.Text = null;
                            tb_CurrentPassword.Focus();
                            DialogResult = DialogResult.None;
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show(GlobalStrings._PWChangeDialog_CurrentPWEmpty_Text,
                        GlobalStrings._PWChangeDialog_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        DialogResult = DialogResult.None;
                        tb_CurrentPassword.Focus();
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(tb_NewPassword.Text))
                {
                    if (string.Equals(tb_NewPassword.Text, tb_PasswordConfirmation.Text))
                    {
                        Settings.Default.CurrentUserPassword = EncryptPW.Calculate(tb_NewPassword.Text);
                        Settings.Default.Save();
                    }
                }
                else
                {
                    if (MessageBox.Show(GlobalStrings._PWChangeDialog_PasswordEmpty_Text,
                        GlobalStrings._PWChangeDialog_Title,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        DialogResult = DialogResult.None;
                        tb_NewPassword.Text = null;
                        tb_PasswordConfirmation = null;
                        tb_NewPassword.Focus();
                    }
                }
            }

            tb_CurrentPassword.Text = null;
            tb_NewPassword.Text = null;
            tb_PasswordConfirmation = null;
        }

        //=====================================================================================================================================================================
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            
        }

        //=====================================================================================================================================================================
        private void _SettingsDialog_PasswordProtection_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

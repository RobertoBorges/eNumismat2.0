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
                    if (string.Equals(EncryptPW.Calculate(tb_CurrentPassword.Text), Properties.Settings.Default.CurrentUserPassword))
                    {
                        if (!string.IsNullOrEmpty(tb_NewPassword.Text))
                        {
                            if (string.Equals(tb_NewPassword.Text, tb_PasswordConfirmation.Text))
                            {
                                Properties.Settings.Default.CurrentUserPassword = EncryptPW.Calculate(tb_NewPassword.Text);
                                Properties.Settings.Default.Save();
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Password can't be empty!", "Error", MessageBoxButtons.OK) == DialogResult.OK)
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
                        MessageBox.Show("Current Password isn't correct." + Environment.NewLine + "Please try again!", "Error");

                        tb_CurrentPassword.Text = null;
                        tb_CurrentPassword.Focus();
                        DialogResult = DialogResult.None;
                    }
                }
                else
                {
                    if (MessageBox.Show("You need to enter the current Password, before you can change it!", "Error", MessageBoxButtons.OK) == DialogResult.OK)
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
                        Properties.Settings.Default.CurrentUserPassword = EncryptPW.Calculate(tb_NewPassword.Text);
                        Properties.Settings.Default.Save();
                    }
                }
                else
                {
                    if (MessageBox.Show("Password can't be empty!", "Error", MessageBoxButtons.OK) == DialogResult.OK)
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

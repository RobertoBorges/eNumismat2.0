using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace eNumismat2._0
{
    public partial class _SettingsDialog_PasswordProtection : Form
    {
        public _SettingsDialog_PasswordProtection()
        {
            InitializeComponent();
        }

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

        private void buttonX2_Click(object sender, EventArgs e)
        {
            if (tb_CurrentPassword.Enabled == true)
            {
                if (!string.IsNullOrEmpty(tb_CurrentPassword.Text))
                {
                    EncryptPWString(tb_CurrentPassword.Text);

                }
            }
        }

        private string EncryptPWString(string input)
        {
            byte[] CurrentPassword = Encoding.Unicode.GetBytes(input);
            byte[] encryptedText = ProtectedData.Protect(CurrentPassword, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedText);
        }
    }
}

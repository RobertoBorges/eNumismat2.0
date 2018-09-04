using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eNumismat2._0
{
    //=====================================================================================================================================================================
    public partial class _eNumismatMain_PasswordCheck : Form
    {
        //=====================================================================================================================================================================
        public _eNumismatMain_PasswordCheck()
        {
            InitializeComponent();

            btn_Cancel.DialogResult = DialogResult.Cancel;
        }

        //=====================================================================================================================================================================
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Classes.GetHash EncryptPW = new Classes.GetHash();

            if (string.Equals(EncryptPW.Calculate(tb_CurrentPassword.Text), Properties.Settings.Default.CurrentUserPassword))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(GlobalStrings._PWChangeDialog_CurrentPWnotCorrect_Text,
                    GlobalStrings._PWChangeDialog_Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //=====================================================================================================================================================================
        private void _eNumismatMain_PasswordCheck_Load(object sender, EventArgs e)
        {

        }
    }
}

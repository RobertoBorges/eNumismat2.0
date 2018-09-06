using System;
using System.Windows.Forms;
using eNumismat2.Properties;
using eNumismat2.Classes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevComponents.DotNetBar;

namespace eNumismat2
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
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            CheckIfPwIsCorrect();
        }

        //=====================================================================================================================================================================
        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
            //Application.Exit();
        }

        //=====================================================================================================================================================================
        private void _eNumismatMain_PasswordCheck_Load(object sender, EventArgs e)
        {

        }

        //=====================================================================================================================================================================
        private void CheckIfPwIsCorrect()
        {
            
            GetHash EncryptPW = new GetHash();

            if (string.Equals(EncryptPW.Calculate(tb_CurrentPassword.Text), Settings.Default.CurrentUserPassword))
            {
                DialogResult = DialogResult.OK;

                //Application.Run(new _eNumismatMain());
                //_eNumismatMain MainFrm = new _eNumismatMain();
                //MainFrm.Show();
                //Hide();
            }
            else
            {
                MessageBox.Show(GlobalStrings._PWChangeDialog_CurrentPWnotCorrect_Text,
                    GlobalStrings._PWChangeDialog_Title,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

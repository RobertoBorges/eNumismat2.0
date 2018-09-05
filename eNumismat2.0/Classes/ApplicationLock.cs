using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eNumismat2._0.Classes
{
    class ApplicationLock
    {
        public void Lock()
        {
            if (Properties.Settings.Default.UsePasswordProtection == true)
            {
                foreach (Form frm in Application.OpenForms)
                {
                    frm.Hide();
                }

                UnLock();
            }
        }

        //=====================================================================================================================================================================
        public void UnLock()
        { 
            if (OpenForm("_eNumismatMain_PasswordCheck") == false)
            {
                _eNumismatMain_PasswordCheck PwCheck = new _eNumismatMain_PasswordCheck();
                using (PwCheck)
                {

                    DialogResult d_result = PwCheck.ShowDialog();

                    if (d_result == DialogResult.OK)
                    {
                        foreach (Form frm in Application.OpenForms)
                        {
                            frm.Show();
                        }
                    }
                    else if (d_result == DialogResult.Cancel)
                    {
                        //foreach (Form frm in Application.OpenForms)
                        //{
                            Application.Exit();
                            //frm.Close();
                        //}
                    }
                }
            }
        }

        //=====================================================================================================================================================================
        // Check, if form is already open
        private bool OpenForm(string FrmName)
        {
            bool IsOpen = false;

            foreach (Form fx in Application.OpenForms)
            {
                if (fx.Name == FrmName)
                {
                    IsOpen = true;

                    // and bring to Front
                    fx.BringToFront();

                    return IsOpen;
                }
            }
            return IsOpen;
        }
    }
}

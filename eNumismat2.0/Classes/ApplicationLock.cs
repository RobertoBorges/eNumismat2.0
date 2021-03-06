﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eNumismat2.Classes
{
    class ApplicationLock
    {
        public void Lock()
        {
            foreach (Form frm in Application.OpenForms)
            {
                frm.Hide();
            }

            UnLock();
        }

        //=====================================================================================================================================================================
        public bool UnLock()
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
                        return true;
                    }
                    else if (d_result == DialogResult.Cancel)
                    {
                        return false;
                    }
                }
            }
            return true;
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

                    // then bring to Front
                    fx.BringToFront();

                    return IsOpen;
                }
            }
            return IsOpen;
        }
    }
}

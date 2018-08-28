using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using DevComponents.DotNetBar;

namespace eNumismat2._0
{
    public partial class _eNumismatMain : RibbonForm
    {
        public _eNumismatMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Open "child" Forms
            // Exchange Monitor
        private void OpenExchangeMonitorFrm_Click(object sender, EventArgs e)
        {
            if (OpenForm("_ExchangeMonitor") == false)
            {
                _ExchangeMonitor ExchangeMon = new _ExchangeMonitor();
                ExchangeMon.Show();
            }
        }
            // Addressbook
        private void OpenAddrBookFrm_Click(object sender, EventArgs e)
        {
            if (OpenForm("_AddressBook") == false)
            {
                _AddressBook AddrBook = new _AddressBook();
                AddrBook.Show();
            }
        }

        // Check, if form is already open
        private bool OpenForm(string FrmName)
        {
            bool IsOpen = false;

            foreach (Form fx in Application.OpenForms)
            {
                if (fx.Name == FrmName)
                {
                    IsOpen = true;

                    // Check, if Form is Minimized
                    if (fx.WindowState == FormWindowState.Minimized)
                    {
                        // Yes, then resize
                        fx.WindowState = FormWindowState.Normal;
                    }

                    // and bring to Front
                    fx.BringToFront();

                    return IsOpen;
                }
            }
            return IsOpen;
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            // implement DB Backup if enabled in settings
            Close();
        }
    }
}

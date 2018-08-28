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

namespace eNumismat2._0
{
    public partial class _eNumismatMain : KryptonForm
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
        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            if (OpenForm("Form3") == false)
            {
                _ExchangeMonitor ExchangeMon = new _ExchangeMonitor();
                ExchangeMon.Show();
            }
        }

            // Addressbook
        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            if (OpenForm("Form2") == false)
            {
                _AddressBook AddrBook = new _AddressBook();
                AddrBook.Show();
            }
        }
            
            // Settings Dialog (needs to be replaced)
        private void buttonSpecAny3_Click(object sender, EventArgs e)
        {
            if (OpenForm("Form4") == false)
            {
                _SettingsDialog Settings = new _SettingsDialog();
                Settings.Show();
            }
        }

        private void buttonSpecAny4_Click(object sender, EventArgs e)
        {
            if (OpenForm("AboutBox1") == false)
            {
                _AboutBox About = new _AboutBox();
                About.Show();
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

        
    }
}

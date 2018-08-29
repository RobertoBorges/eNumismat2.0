using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar;


namespace eNumismat2._0
{
    public partial class _eNumismatMain : RibbonForm
    {
        string UICulture = Properties.Settings.Default.UICulture;

        //=====================================================================================================================================================================
        public _eNumismatMain()
        {
            InitializeComponent();           
        }

        //=====================================================================================================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayLanguage();
        }

        //=====================================================================================================================================================================
        private void DisplayLanguage(string method = null, string culture = null)
        {
            if (method == "set" && culture != null)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
                Properties.Settings.Default.UICulture = CultureInfo.CurrentUICulture.Name;
                Properties.Settings.Default.Save();
            }
            else
            {
                if (Properties.Settings.Default.UICulture == null)
                {
                    Properties.Settings.Default.UICulture = CultureInfo.CurrentUICulture.Name;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.UICulture);
                }
            }
                
            Controls.Clear();
            InitializeComponent();

            if (CultureInfo.CurrentUICulture.Name == "en-GB")
            {
                LangEN_GB.Checked = true;
                toolStripStatusLabel1.Image = Properties.Resources.GB_United_Kingdom_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.Name == "en-US")
            {
                LangEN_US.Checked = true;
                toolStripStatusLabel1.Image = Properties.Resources.US_United_States_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.Name == "de-DE")
            {
                LangDE.Checked = true;
                toolStripStatusLabel1.Image = Properties.Resources.DE_Germany_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.Name == "fr-FR")
            {
                LangFR.Checked = true;
                toolStripStatusLabel1.Image = Properties.Resources.FR_France_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.Name == "es-ES")
            {
                LangES.Checked = true;
                toolStripStatusLabel1.Image = Properties.Resources.ES_Spain_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.Name == "pt-PT")
            {
                LangPT.Checked = true;
                toolStripStatusLabel1.Image = Properties.Resources.PT_Portugal_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.Name == "ru-RU")
            {
                LangRU.Checked = true;
                toolStripStatusLabel1.Image = Properties.Resources.RU_Russia_Flag_icon;
            }
            else
            {
                LangEN_GB.Checked = false;
                LangEN_US.Checked = false;
                LangDE.Checked = false;
                LangFR.Checked = false;
                LangES.Checked = false;
                LangPT.Checked = false;
                LangRU.Checked = false;

                toolStripStatusLabel1.Image = null;
            }
            toolStripStatusLabel1.Text = CultureInfo.CurrentUICulture.DisplayName;
        }

        // Open "child" Forms
        //=====================================================================================================================================================================
        // Exchange Monitor
        private void OpenExchangeMonitorFrm_Click(object sender, EventArgs e)
        {
            if (OpenForm("_ExchangeMonitor") == false)
            {
                //_ExchangeMonitor ExchangeMon = new _ExchangeMonitor();
                //ExchangeMon.Show();
            }
        }

        //=====================================================================================================================================================================
        // Addressbook
        private void OpenAddrBookFrm_Click(object sender, EventArgs e)
        {
            if (OpenForm("_AddressBook") == false)
            {
                _AddressBook AddrBook = new _AddressBook();
                AddrBook.Show();
            }
        }

        //=====================================================================================================================================================================
        // About Form
        private void BtnAbout_Click(object sender, EventArgs e)
        {
            if (OpenForm("_AboutBox") == false)
            {
                //_AboutBox AboutBox = new _AboutBox();
                //AboutBox.Show();
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

        //=====================================================================================================================================================================
        private void LangEN_GB_Click(object sender, EventArgs e)
        {
            DisplayLanguage("set", "en-GB");
        }

        //=====================================================================================================================================================================
        private void LangEN_US_Click(object sender, EventArgs e)
        {
            DisplayLanguage("set", "en-US");
        }

        //=====================================================================================================================================================================
        private void LangDE_Click(object sender, EventArgs e)
        {
            DisplayLanguage("set", "de-DE");
        }

        //=====================================================================================================================================================================
        private void LangFR_Click(object sender, EventArgs e)
        {
            DisplayLanguage("set", "fr-FR");
        }

        //=====================================================================================================================================================================
        private void LangES_Click(object sender, EventArgs e)
        {
            DisplayLanguage("set", "es-ES");
        }

        //=====================================================================================================================================================================
        private void LangPT_Click(object sender, EventArgs e)
        {
            DisplayLanguage("set", "pt-PT");
        }

        //=====================================================================================================================================================================
        private void LangRU_Click(object sender, EventArgs e)
        {
            DisplayLanguage("set", "ru-RU");
        }

        //=====================================================================================================================================================================
        private void buttonItem5_Click(object sender, EventArgs e)
        {
            // implement DB Backup if enabled in settings
            Close();
        }
    }
}

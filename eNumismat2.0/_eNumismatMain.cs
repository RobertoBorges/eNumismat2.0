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
        string UICulture = null;

        public _eNumismatMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayLanguage();
        }

        //=====================================================================================================================================================================
        private void DisplayLanguage(string method = null, string culture = null)
        {
            LangEN.Checked = false;
            LangDE.Checked = false;
            LangFR.Checked = false;
            LangES.Checked = false;
            LangPT.Checked = false;
            LangRU.Checked = false;

            if (method == "set" && culture != null)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
                Controls.Clear();
                InitializeComponent();

                // Write UICulture to XMLConf
                //Globals.UICulture = culture;
                //CfgHandler.UpdateXmlConf("UICulture", culture);
            }

            // Set Application Language
            if (/*Globals.*/UICulture != null)
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(/*Globals.*/UICulture);
                this.Controls.Clear();
                this.InitializeComponent();
            }

            if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "en")
            {
                LangEN.Checked = true;
                //toolStripStatusLabel2.Image = Properties.Resources.US_United_States_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "de")
            {
                LangDE.Checked = true;
                //toolStripStatusLabel2.Image = Properties.Resources.DE_Germany_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "fr")
            {
                LangFR.Checked = true;
                //toolStripStatusLabel2.Image = Properties.Resources.FR_France_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "es")
            {
                LangES.Checked = true;
                //toolStripStatusLabel2.Image = Properties.Resources.ES_Spain_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "pt")
            {
                LangPT.Checked = true;
                //toolStripStatusLabel2.Image = Properties.Resources.ES_Spain_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.TwoLetterISOLanguageName == "ru")
            {
                LangRU.Checked = true;
                //toolStripStatusLabel2.Image = Properties.Resources.ES_Spain_Flag_icon;
            }
            else
            {
                LangEN.Checked = false;
                LangDE.Checked = false;
                LangFR.Checked = false;
                LangES.Checked = false;
                LangPT.Checked = false;
                LangRU.Checked = false;
                //toolStripStatusLabel2.Image = null;
            }
            //toolStripStatusLabel2.Text = CultureInfo.CurrentUICulture.TwoLetterISOLanguageName;
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

        private void LangEN_Click(object sender, EventArgs e)
        {
            DisplayLanguage("set", "en-EN");
        }

        private void LangDE_Click(object sender, EventArgs e)
        {
            DisplayLanguage("set", "de-DE");
        }

        private void LangFR_Click(object sender, EventArgs e)
        {
            DisplayLanguage("set", "fr-FR");
        }

        private void LangES_Click(object sender, EventArgs e)
        {
            DisplayLanguage("set", "es-ES");
        }

        private void LangPT_Click(object sender, EventArgs e)
        {
            DisplayLanguage("set", "pt-PT");
        }

        private void LangRU_Click(object sender, EventArgs e)
        {
            DisplayLanguage("set", "ru-RU");
        }
    }
}

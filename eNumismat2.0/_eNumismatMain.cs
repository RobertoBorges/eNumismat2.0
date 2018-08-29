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
using Infralution.Localization;

namespace eNumismat2._0
{
    public partial class _eNumismatMain : RibbonForm
    {
        //string UICulture = Properties.Settings.Default.UICulture;
        CultureInfo CurrentUICulture;

        //=====================================================================================================================================================================
        public _eNumismatMain()
        {
            InitializeComponent();

            MessageBox.Show(Properties.Settings.Default.UICulture);

            if (Properties.Settings.Default.UICulture == null)
            {
                CurrentUICulture = CultureInfo.CurrentUICulture;
            }
            //Properties.Settings.Default.UICulture = null;
            //Properties.Settings.Default.Save();
        }

        //=====================================================================================================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayLanguage();
            //MessageBox.Show(UICulture);
            //MessageBox.Show(CultureInfo.CurrentUICulture.Name);
        }

        //=====================================================================================================================================================================
        private void DisplayLanguage()
        {
            CurrentUICulture = CultureManager.ApplicationUICulture;

            

            MessageBox.Show(Properties.Settings.Default.UICulture);

            toolStripStatusLabel1.Text = CultureInfo.CurrentUICulture.DisplayName;
            //if (method == "set" && culture != null)
            //{
            //Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(culture);
            //    Properties.Settings.Default.UICulture = CultureInfo.CurrentUICulture.Name;
            //    Properties.Settings.Default.Save();
            //}
            //else
            //{
            //if (Properties.Settings.Default.UICulture == null)
            //{
            //    Properties.Settings.Default.UICulture = CultureInfo.CurrentUICulture.Name;
            //    Properties.Settings.Default.Save();
            //}
            //else
            //{
            //    Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.UICulture);
            //}
            //}

            //Controls.Clear();
            //InitializeComponent();
            //this.Refresh();
            //this.Invalidate();
            //this.Update();

            if (CultureInfo.CurrentUICulture.Name == "en-GB")
            {
                LangEN_GB.Checked = true;
                LangEN_US.Checked = false;
                LangDE.Checked = false;
                LangFR.Checked = false;
                LangES.Checked = false;
                LangPT.Checked = false;
                LangRU.Checked = false;

                toolStripStatusLabel1.Image = Properties.Resources.GB_United_Kingdom_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.Name == "en-US")
            {
                LangEN_GB.Checked = false;
                LangEN_US.Checked = true;
                LangDE.Checked = false;
                LangFR.Checked = false;
                LangES.Checked = false;
                LangPT.Checked = false;
                LangRU.Checked = false;

                toolStripStatusLabel1.Image = Properties.Resources.US_United_States_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.Name == "de-DE")
            {
                LangEN_GB.Checked = false;
                LangEN_US.Checked = false;
                LangDE.Checked = true;
                LangFR.Checked = false;
                LangES.Checked = false;
                LangPT.Checked = false;
                LangRU.Checked = false;

                toolStripStatusLabel1.Image = Properties.Resources.DE_Germany_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.Name == "fr-FR")
            {
                LangEN_GB.Checked = false;
                LangEN_US.Checked = false;
                LangDE.Checked = false;
                LangFR.Checked = true;
                LangES.Checked = false;
                LangPT.Checked = false;
                LangRU.Checked = false;

                toolStripStatusLabel1.Image = Properties.Resources.FR_France_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.Name == "es-ES")
            {
                LangEN_GB.Checked = false;
                LangEN_US.Checked = false;
                LangDE.Checked = false;
                LangFR.Checked = false;
                LangES.Checked = true;
                LangPT.Checked = false;
                LangRU.Checked = false;

                toolStripStatusLabel1.Image = Properties.Resources.ES_Spain_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.Name == "pt-PT")
            {
                LangEN_GB.Checked = false;
                LangEN_US.Checked = false;
                LangDE.Checked = false;
                LangFR.Checked = false;
                LangES.Checked = false;
                LangPT.Checked = true;
                LangRU.Checked = false;

                toolStripStatusLabel1.Image = Properties.Resources.PT_Portugal_Flag_icon;
            }
            else if (CultureInfo.CurrentUICulture.Name == "ru-RU")
            {
                LangEN_GB.Checked = false;
                LangEN_US.Checked = false;
                LangDE.Checked = false;
                LangFR.Checked = false;
                LangES.Checked = false;
                LangPT.Checked = false;
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

            Properties.Settings.Default.UICulture = CurrentUICulture.ToString();
            Properties.Settings.Default.Save();
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
            CultureManager.ApplicationUICulture = new CultureInfo("en-GB");
            //DisplayLanguage("set", "en-GB");
        }

        //=====================================================================================================================================================================
        private void LangEN_US_Click(object sender, EventArgs e)
        {
            CultureManager.ApplicationUICulture = new CultureInfo("en-US");
           //DisplayLanguage("set", "en-US");
        }

        //=====================================================================================================================================================================
        private void LangDE_Click(object sender, EventArgs e)
        {
            CultureManager.ApplicationUICulture = new CultureInfo("de-DE");
            //DisplayLanguage("set", "de-DE");
        }

        //=====================================================================================================================================================================
        private void LangFR_Click(object sender, EventArgs e)
        {
            CultureManager.ApplicationUICulture = new CultureInfo("fr-FR");
            //DisplayLanguage("set", "fr-FR");
        }

        //=====================================================================================================================================================================
        private void LangES_Click(object sender, EventArgs e)
        {
            CultureManager.ApplicationUICulture = new CultureInfo("es-ES");
            //DisplayLanguage("set", "es-ES");
        }

        //=====================================================================================================================================================================
        private void LangPT_Click(object sender, EventArgs e)
        {
            CultureManager.ApplicationUICulture = new CultureInfo("pt-PT");
            //DisplayLanguage("set", "pt-PT");
        }

        //=====================================================================================================================================================================
        private void LangRU_Click(object sender, EventArgs e)
        {
            CultureManager.ApplicationUICulture = new CultureInfo("ru-RU");
            //DisplayLanguage("set", "ru-RU");
        }

        private void cultureManager_UICultureChanged(CultureInfo newCulture)
        {
            DisplayLanguage();
        }

        //=====================================================================================================================================================================
        private void buttonItem5_Click(object sender, EventArgs e)
        {
            // implement DB Backup if enabled in settings
            Close();
        }
    }
}

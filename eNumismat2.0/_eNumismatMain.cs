﻿using System;
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
        //=====================================================================================================================================================================
        public _eNumismatMain()
        {
            InitializeComponent();

            if (Properties.Settings.Default.MainWindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if(Properties.Settings.Default.MainWindowState == FormWindowState.Normal)
            {
                Size = new Size(Properties.Settings.Default.MainWindowWidth, Properties.Settings.Default.MainWindowHeight);
            }
            else if (Properties.Settings.Default.MainWindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        //=====================================================================================================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayLanguage();
        }

        //=====================================================================================================================================================================
        private void DisplayLanguage(string type = null)
        {
            CultureInfo DisplayCulture;

            if (string.IsNullOrEmpty(Properties.Settings.Default.UICulture))
            {
                DisplayCulture = CultureInfo.CurrentUICulture;
            }
            else
            {
                CultureManager.ApplicationUICulture = new CultureInfo(Properties.Settings.Default.UICulture);
                DisplayCulture = CultureManager.ApplicationUICulture;
            }

            if (DisplayCulture.Name == "en-US")
            {
                LangEN_US.Checked = true;
                LangEN_GB.Checked = false;
                LangDE.Checked = false;
                LangFR.Checked = false;
                LangES.Checked = false;
                LangPT.Checked = false;
                LangRU.Checked = false;

                toolStripStatusLabel1.Image = Properties.Resources.US_United_States_Flag_icon;
            }
            else if (DisplayCulture.Name == "en-GB")
            {
                LangEN_US.Checked = false;
                LangEN_GB.Checked = true;
                LangDE.Checked = false;
                LangFR.Checked = false;
                LangES.Checked = false;
                LangPT.Checked = false;
                LangRU.Checked = false;

                toolStripStatusLabel1.Image = Properties.Resources.GB_United_Kingdom_Flag_icon;
            }
            else if (DisplayCulture.Name == "de-DE")
            {
                LangEN_US.Checked = false;
                LangEN_GB.Checked = false;
                LangDE.Checked = true;
                LangFR.Checked = false;
                LangES.Checked = false;
                LangPT.Checked = false;
                LangRU.Checked = false;

                toolStripStatusLabel1.Image = Properties.Resources.DE_Germany_Flag_icon;
            }
            else if (DisplayCulture.Name == "fr-FR")
            {
                LangEN_US.Checked = false;
                LangEN_GB.Checked = false;
                LangDE.Checked = false;
                LangFR.Checked = true;
                LangES.Checked = false;
                LangPT.Checked = false;
                LangRU.Checked = false;

                toolStripStatusLabel1.Image = Properties.Resources.FR_France_Flag_icon;
            }
            else if (DisplayCulture.Name == "es-ES")
            {
                LangEN_US.Checked = false;
                LangEN_GB.Checked = false;
                LangDE.Checked = false;
                LangFR.Checked = false;
                LangES.Checked = true;
                LangPT.Checked = false;
                LangRU.Checked = false;

                toolStripStatusLabel1.Image = Properties.Resources.ES_Spain_Flag_icon;
            }
            else if (DisplayCulture.Name == "pt-PT")
            {
                LangEN_US.Checked = false;
                LangEN_GB.Checked = false;
                LangDE.Checked = false;
                LangFR.Checked = false;
                LangES.Checked = false;
                LangPT.Checked = true;
                LangRU.Checked = false;

                toolStripStatusLabel1.Image = Properties.Resources.PT_Portugal_Flag_icon;
            }
            else if (DisplayCulture.Name == "ru-RU")
            {
                LangEN_US.Checked = false;
                LangEN_GB.Checked = false;
                LangDE.Checked = false;
                LangFR.Checked = false;
                LangES.Checked = false;
                LangPT.Checked = false;
                LangRU.Checked = true;

                toolStripStatusLabel1.Image = Properties.Resources.RU_Russia_Flag_icon;
            }
            else
            {
                toolStripStatusLabel1.Image = null;
            }
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

        //=====================================================================================================================================================================
        private void cultureManager_UICultureChanged(CultureInfo newCulture)
        {
            Properties.Settings.Default.UICulture = newCulture.Name;
            Properties.Settings.Default.Save();
            DisplayLanguage("SetUiCulture");

        }

        //=====================================================================================================================================================================
        private void buttonItem5_Click(object sender, EventArgs e)
        {
            // implement DB Backup if enabled in settings
            Close();
        }

        //=====================================================================================================================================================================
        private void _eNumismatMain_SizeChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MinimizeToTray == true)
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    Hide();
                    WindowState = FormWindowState.Minimized;
                }
            }

            SaveWindowSizeSettings();
        }

        //=====================================================================================================================================================================
        private void TryIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DoubleClickAction();
        }

        //=====================================================================================================================================================================
        private void DoubleClickAction()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Hide();
                WindowState = FormWindowState.Minimized;
            }

            SaveWindowSizeSettings();
        }

        //=====================================================================================================================================================================
        private void SaveWindowSizeSettings()
        {
            Properties.Settings.Default.MainWindowHeight = Size.Height;
            Properties.Settings.Default.MainWindowWidth = Size.Width;
            Properties.Settings.Default.MainWindowState = WindowState;

            Properties.Settings.Default.Save();
        }
    }
}






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
using System.IO;

namespace eNumismat2._0
{
    //=====================================================================================================================================================================
    public partial class _eNumismatMain : RibbonForm
    {
        Classes.DataBaseWork DBWorker;

        public string[] args = Environment.GetCommandLineArgs();

        //=====================================================================================================================================================================
        public _eNumismatMain()
        {
            InitializeComponent();

            if (args.Count() > 1)
            {
                foreach (string arg in args)
                {
                    if (arg.ToUpper() == "RESETPW")
                    {
                        Properties.Settings.Default.UsePasswordProtection = false;
                        Properties.Settings.Default.CurrentUserPassword = "";
                        Properties.Settings.Default.Save();

                        MessageBox.Show("Passwort zurückgesetzt!");
                    }
                }
            }
        }

        //=====================================================================================================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            _eNumismatMain_PasswordCheck PwCheck = new _eNumismatMain_PasswordCheck();

            if (Properties.Settings.Default.UsePasswordProtection == true)
            {
                if (PwCheck.ShowDialog() != DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                CheckIfDbFileExists();

                if (Properties.Settings.Default.MainWindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Maximized;
                }
                else if (Properties.Settings.Default.MainWindowState == FormWindowState.Normal)
                {
                    Size = new Size(Properties.Settings.Default.MainWindowWidth, Properties.Settings.Default.MainWindowHeight);
                }
                else if (Properties.Settings.Default.MainWindowState == FormWindowState.Minimized)
                {
                    WindowState = FormWindowState.Maximized;
                }

                DisplayLanguage();
            }
        }

        //=====================================================================================================================================================================
        private void DisplayLanguage()
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

                toolStripStatusLabel1.Image = Properties.Resources.us;
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

                toolStripStatusLabel1.Image = Properties.Resources.gb;
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

                toolStripStatusLabel1.Image = Properties.Resources.de;
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

                toolStripStatusLabel1.Image = Properties.Resources.fr;
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

                toolStripStatusLabel1.Image = Properties.Resources.es;
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

                toolStripStatusLabel1.Image = Properties.Resources.pt;
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

                toolStripStatusLabel1.Image = Properties.Resources.ru;
            }
            else
            {
                toolStripStatusLabel1.Image = null;
            }

            toolStripStatusLabel1.Text = CultureManager.ApplicationUICulture.Name;

            // Refresh the Ribbon Control to prevent Design issues when the Language will be changed.
            ribbonControl1.Refresh();


        }

        //=====================================================================================================================================================================
        private bool CheckIfDbFileExists()
        {
            // Check if DB File exists
            if (!string.IsNullOrEmpty(Properties.Settings.Default.DBFilePath) || !string.IsNullOrEmpty(Properties.Settings.Default.DBFile))
            {
                if (!File.Exists(Path.Combine(Properties.Settings.Default.DBFilePath, Properties.Settings.Default.DBFile)))
                {
                    toolStripStatusLabel2.Image = Properties.Resources.disconnect;
                    toolStripStatusLabel2.Text = GlobalStrings._dbConnectionNoDbFile;
                    RefreshDbFileSettings();
                    return false;
                }
                else
                {
                    toolStripStatusLabel2.Image = Properties.Resources.connect;
                    toolStripStatusLabel2.Text = GlobalStrings._dbConnectionDbFile + " " + Properties.Settings.Default.DBFile;
                    return true;
                }
            }
            else
            {
                toolStripStatusLabel2.Image = Properties.Resources.disconnect;
                toolStripStatusLabel2.Text = GlobalStrings._dbConnectionNoDbFile;
                RefreshDbFileSettings();
                return false;
            }
            
        }

        private void RefreshDbFileSettings()
        {
            Properties.Settings.Default.DBFilePath = "";
            Properties.Settings.Default.DBFile = "";

            Properties.Settings.Default.Save();
        }

        // Open "child" Forms
        //=====================================================================================================================================================================
        // Exchange Monitor
        private void OpenExchangeMonitorFrm_Click(object sender, EventArgs e)
        {
            if (OpenForm("_ExchangeMonitor") == false)
            {
                _ExchangeMonitor ExchangeMon = new _ExchangeMonitor();
                ExchangeMon.Show();
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
        private void Btn_SettingsDialog_Click(object sender, EventArgs e)
        {
            if (OpenForm("_SettingsDialog") == false)
            {
                _SettingsDialog Settings = new _SettingsDialog();
                Settings.ShowDialog();
            }
        }

        //=====================================================================================================================================================================
        // About Form
        private void BtnAbout_Click(object sender, EventArgs e)
        {
            if (OpenForm("_AboutBox") == false)
            {
                _AboutBox AboutBox = new _AboutBox();
                AboutBox.Show();
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
        }

        //=====================================================================================================================================================================
        private void LangEN_US_Click(object sender, EventArgs e)
        {
            CultureManager.ApplicationUICulture = new CultureInfo("en-US");
        }

        //=====================================================================================================================================================================
        private void LangDE_Click(object sender, EventArgs e)
        {
            CultureManager.ApplicationUICulture = new CultureInfo("de-DE");
        }

        //=====================================================================================================================================================================
        private void LangFR_Click(object sender, EventArgs e)
        {
            CultureManager.ApplicationUICulture = new CultureInfo("fr-FR");
        }

        //=====================================================================================================================================================================
        private void LangES_Click(object sender, EventArgs e)
        {
            CultureManager.ApplicationUICulture = new CultureInfo("es-ES");
        }

        //=====================================================================================================================================================================
        private void LangPT_Click(object sender, EventArgs e)
        {
            CultureManager.ApplicationUICulture = new CultureInfo("pt-PT");
        }

        //=====================================================================================================================================================================
        private void LangRU_Click(object sender, EventArgs e)
        {
            CultureManager.ApplicationUICulture = new CultureInfo("ru-RU");
        }

        //=====================================================================================================================================================================
        private void CultureManager_UICultureChanged(CultureInfo newCulture)
        {
            Properties.Settings.Default.UICulture = newCulture.Name;
            Properties.Settings.Default.Save();
            DisplayLanguage();
        }

        //=====================================================================================================================================================================
        private void BtnClose_Click(object sender, EventArgs e)
        {
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

        //=====================================================================================================================================================================
        private void Btn_NewDB_Click(object sender, EventArgs e)
        {
            CreateNewDbFile();
        }

        //=====================================================================================================================================================================
        private void Btn_OpenDB_Click(object sender, EventArgs e)
        {
            OpenDbFile();
        }

        //=====================================================================================================================================================================
        private void CreateNewDbFile()
        {
            string InitialDir = null;

            if (string.IsNullOrEmpty(Properties.Settings.Default.DBFilePath))
            {
                InitialDir = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            }
            else
            {
                InitialDir = Properties.Settings.Default.DBFilePath;
            }

            SaveFileDialog SaveFile = new SaveFileDialog()
            {
                DefaultExt = "*.enc",
                Filter = "eNumismat Collection (*.enc) | *.enc",
                AddExtension = true,
                InitialDirectory = InitialDir
            };

            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DBFile = Path.GetFileName(SaveFile.FileName);
                Properties.Settings.Default.DBFilePath = Path.GetDirectoryName(SaveFile.FileName);

                Properties.Settings.Default.Save();

                try
                {
                    DBWorker = new Classes.DataBaseWork();
                    DBWorker.CreateNewDataBase();

                    CheckIfDbFileExists();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //=====================================================================================================================================================================
        private void OpenDbFile()
        {
            string InitialDir = null;

            if (string.IsNullOrEmpty(Properties.Settings.Default.DBFilePath))
            {
                InitialDir = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            }
            else
            {
                InitialDir = Properties.Settings.Default.DBFilePath;
            }

            OpenFileDialog OpenFile = new OpenFileDialog()
            {
                DefaultExt = "*.enc",
                Filter = "eNumismat Collection (*.enc) | *.enc",
                AddExtension = true,
                InitialDirectory = InitialDir
            };

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DBFile = Path.GetFileName(OpenFile.FileName);
                Properties.Settings.Default.DBFilePath = Path.GetDirectoryName(OpenFile.FileName);

                Properties.Settings.Default.Save();

                CheckIfDbFileExists();
            }
        }

        //=====================================================================================================================================================================
        private void Btn_CompressDB_Click(object sender, EventArgs e)
        {
            RunDBCompression();
        }

        //=====================================================================================================================================================================
        private void Btn_BackupDB_Click(object sender, EventArgs e)
        {
            RunDBBackup();
        }

        //=====================================================================================================================================================================
        private void _eNumismatMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.BackupDBOnAppClose == true)
            {
                RunDBBackup();
            }
        }

        //=====================================================================================================================================================================
        private void RunDBCompression()
        {
            try
            {
                DBWorker = new Classes.DataBaseWork();
                if (DBWorker.CompactDatabase())
                {
                    TrayIcon.BalloonTipTitle = GlobalStrings._dbCompress_BalloonTitle;
                    TrayIcon.BalloonTipText = GlobalStrings._dbCompress_BallonText;

                    TrayIcon.ShowBalloonTip(2000);
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //=====================================================================================================================================================================
        private void RunDBBackup()
        {
            try
            {
                DBWorker = new Classes.DataBaseWork();
                if (DBWorker.ExcecuteBackup())
                {
                    TrayIcon.BalloonTipTitle = GlobalStrings._dbBackup_BalloonTitle;
                    TrayIcon.BalloonTipText = GlobalStrings._dbBackup_BallonText;

                    TrayIcon.ShowBalloonTip(2000);
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(GlobalStrings._dbBackupNullReferenceExceptionText
                    + Environment.NewLine
                    + Environment.NewLine
                    + ex.Message
                    + Environment.NewLine
                    + Path.Combine(Properties.Settings.Default.DBFilePath, Properties.Settings.Default.DBFile),
                    GlobalStrings._dbBackupNullReferenceExceptionTitle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}






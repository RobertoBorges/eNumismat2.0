using System;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Infralution.Localization;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Globalization;
using eNumismat2.Properties;
using eNumismat2.Classes;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading;

namespace eNumismat2
{
    //=====================================================================================================================================================================
    public partial class _eNumismatMain : RibbonForm
    {
        //_AboutBox AboutBox = new _AboutBox();

        DataBaseWork DBWorker;
        ConfigReadWrite CFGWriter = new ConfigReadWrite();

        public string[] args = Environment.GetCommandLineArgs();

        //=====================================================================================================================================================================
        public _eNumismatMain()
        {
            InitializeComponent();

            this.Visible = false;

            if (args.Count() > 1)
            {
                foreach (string arg in args)
                {
                    // Hidden: Should be removed 
                    if (arg.ToUpper() == "RESETPW")
                    {
                        Settings.Default["UsePasswordProtection"] = false;
                        Settings.Default["CurrentUserPassword"] = string.Empty;

                        Settings.Default.Save();

                        MessageBox.Show("Passwort zurückgesetzt!");
                    }
                }
            }
        }

        //=====================================================================================================================================================================
        private bool UseLogin()
        {
            if (Settings.Default.UsePasswordProtection == true)
            {
                ApplicationLock AppLock = new ApplicationLock();
                if (AppLock.UnLock())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        //=====================================================================================================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!UseLogin())
            {
                Close();
            }


            if (!string.IsNullOrEmpty(Settings.Default["MainWindowState"].ToString()))
            {
                if (Settings.Default.MainWindowState == FormWindowState.Maximized)
                {
                    WindowState = FormWindowState.Maximized;
                }
                else if (Settings.Default.MainWindowState == FormWindowState.Normal)
                {
                    Size = new Size(Settings.Default.MainWindowWidth, Settings.Default.MainWindowHeight);
                }
                else if (Settings.Default.MainWindowState == FormWindowState.Minimized)
                {
                    WindowState = FormWindowState.Maximized;
                }
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }

            if (Settings.Default.UsePasswordProtection == true)
            {
                btn_AppLock.Visible = true;
            }
            else
            {
                btn_AppLock.Visible = false;
            }

            CheckIfDbFileExists();
            DisplayLanguage();
        }

        //=====================================================================================================================================================================
        private void DisplayLanguage()
        {
            CultureInfo DisplayCulture;

            if (string.IsNullOrEmpty(Settings.Default.UICulture))
            {
                DisplayCulture = CultureInfo.CurrentUICulture;
            }
            else
            {
                CultureManager.ApplicationUICulture = new CultureInfo(Settings.Default.UICulture);
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

                toolStripStatusLabel1.Image = Resources.us;
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

                toolStripStatusLabel1.Image = Resources.gb;
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

                toolStripStatusLabel1.Image = Resources.de;
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

                toolStripStatusLabel1.Image = Resources.fr;
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

                toolStripStatusLabel1.Image = Resources.es;
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

                toolStripStatusLabel1.Image = Resources.pt;
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

                toolStripStatusLabel1.Image = Resources.ru;
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
            if (!string.IsNullOrEmpty(Settings.Default.DBFile) && !string.IsNullOrEmpty(Settings.Default.DBFilePath))
            {
                if (File.Exists(Path.Combine(Settings.Default.DBFilePath, Settings.Default.DBFile)))
                {
                    toolStripStatusLabel2.Image = Resources.connect;
                    toolStripStatusLabel2.Text = GlobalStrings._dbConnectionDbFile + Settings.Default.DBFile;

                    return true;
                }
                else
                {
                    toolStripStatusLabel2.Image = Resources.disconnect;
                    toolStripStatusLabel2.Text = GlobalStrings._dbConnectionNoDbFile;

                    MessageBox.Show("selected DB file does not exist!");
                    RefreshDbFileSettings();

                    return false;
                }
            }
            else
            {
                toolStripStatusLabel2.Image = Resources.disconnect;
                toolStripStatusLabel2.Text = GlobalStrings._dbConnectionNoDbFile;

                return false;
            }
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
            //if (OpenForm("_AboutBox") == false)
            //{

            //    AboutBox.Show();
            //}
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
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //=====================================================================================================================================================================
        private void _eNumismatMain_SizeChanged(object sender, EventArgs e)
        {
            if (Settings.Default.MinimizeToTray == true)
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
                ApplicationLock AppLock = new ApplicationLock();
                AppLock.UnLock();
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Hide();
                WindowState = FormWindowState.Minimized;
            }

            SaveWindowSizeSettings();
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
            if (GetDBConnected("create"))
            {
                DBWorker = new DataBaseWork();
                try
                {
                    DBWorker.CreateNewDataBase();
                    if (CheckIfDbFileExists())
                    { }
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
            if (GetDBConnected("open"))
            {
                if (CheckIfDbFileExists())
                { }
            }
        }

        //=====================================================================================================================================================================
        private bool GetDBConnected(string method)
        {
            string InitialDir = null;
            string FileName = null;
            string FilePath = null;

            if (string.IsNullOrEmpty(Settings.Default.DBFilePath))
            {
                InitialDir = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            }
            else
            {
                InitialDir = Settings.Default.DBFilePath;
            }

            if (method == "open")
            {
                OpenFileDialog FD = new OpenFileDialog()
                {
                    DefaultExt = "*.enc",
                    Filter = "eNumismat Collection (*.enc) | *.enc",
                    AddExtension = true,
                    InitialDirectory = InitialDir,
                };

                DialogResult = FD.ShowDialog();
                FileName = Path.GetFileName(FD.FileName);
                FilePath = Path.GetDirectoryName(FD.FileName);
            }
            else if (method == "create")
            {
                SaveFileDialog FD = new SaveFileDialog()
                {
                    DefaultExt = "*.enc",
                    Filter = "eNumismat Collection (*.enc) | *.enc",
                    AddExtension = true,
                    InitialDirectory = InitialDir,
                };

                DialogResult = FD.ShowDialog();
                FileName = Path.GetFileName(FD.FileName);
                FilePath = Path.GetDirectoryName(FD.FileName);
            }

            if (DialogResult == DialogResult.OK)
            {
                //Settings.Default.DBFile = FileName;
                CFGWriter.WriteConfig(Settings.Default.DBFile, FileName);
                //Settings.Default.DBFilePath = FilePath;
                CFGWriter.WriteConfig(Settings.Default.DBFilePath, FilePath);

                //Settings.Default.Save();

                return true;
            }
            else
            {
                return false;
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
            if (Settings.Default.BackupDBOnAppClose == true)
            {
                RunDBBackup();
            }
            SaveWindowSizeSettings();
        }

        //=====================================================================================================================================================================
        private void RunDBCompression()
        {
            try
            {
                DBWorker = new DataBaseWork();
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
                DBWorker = new DataBaseWork();
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
                    + Path.Combine(Settings.Default.DBFilePath, Settings.Default.DBFile),
                    GlobalStrings._dbBackupNullReferenceExceptionTitle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //=====================================================================================================================================================================
        private void _eNumismatMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (Settings.Default.UsePasswordProtection == true)
            {
                if (e.Control && e.Shift && e.KeyCode == Keys.L)
                {
                    ApplicationLock AppLock = new ApplicationLock();
                    AppLock.Lock();
                }
            }
        }

        //=====================================================================================================================================================================
        private void Btn_AppLock_Click(object sender, EventArgs e)
        {
            ApplicationLock AppLock = new ApplicationLock();
            AppLock.Lock();
        }

        //=====================================================================================================================================================================
        private void CultureManager_UICultureChanged(CultureInfo newCulture)
        {

            //CFGWriter.WriteConfig(newCulture.Name, Settings.Default.UICulture);
            Settings.Default.UICulture = newCulture.Name;
            Settings.Default.Save();
            DisplayLanguage();
        }

        //=====================================================================================================================================================================
        private void SaveWindowSizeSettings()
        {
            Settings.Default.MainWindowHeight = Size.Height;
            //CFGWriter.WriteConfig(Size.Height, Settings.Default.MainWindowHeight);
            Settings.Default.MainWindowWidth = Size.Width;
            //CFGWriter.WriteConfig(Size.Width, Settings.Default.MainWindowWidth);
            Settings.Default.MainWindowState = WindowState;
            //CFGWriter.WriteConfig(WindowState, Settings.Default.MainWindowState);

            Settings.Default.Save();
        }

        //=====================================================================================================================================================================
        private void RefreshDbFileSettings()
        {
            Settings.Default.DBFilePath = "";
            //CFGWriter.WriteConfig(Settings.Default.DBFilePath, string.Empty);
            Settings.Default.DBFile = "";
            //CFGWriter.WriteConfig(Settings.Default.DBFile, string.Empty);

            Settings.Default.Save();
        }
    }
}






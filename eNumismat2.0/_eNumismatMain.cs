using System;
using System.Windows.Forms;
using System.Drawing;
using DevComponents.DotNetBar;
using Infralution.Localization;
using System.IO;
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
        public string[] Args { get; set; } = Environment.GetCommandLineArgs();

        //=====================================================================================================================================================================
        public _eNumismatMain()
        {
            InitializeComponent();

            if (Args.Count() > 1)
            {
                CmdLineArgWorker.CommandWorker(Args);
            }
        }

        //=====================================================================================================================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
            if (Settings.Default.UsePasswordProtection == true)
            {
                if (!UseLogin())
                {
                    Close();
                }
                btn_AppLock.Visible = true;
            }
            else
            {
                btn_AppLock.Visible = false;
            }
            GetLastWindowSize();
            DisplayLanguage();

            CheckIfDbFileExists();
        }

        //=====================================================================================================================================================================
        private bool UseLogin()
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

        //=====================================================================================================================================================================
        private void GetLastWindowSize()
        {
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

            #region Checking the DisplayLanguage in the Selector

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
            #endregion

            toolStripStatusLabel1.Text = CultureManager.ApplicationUICulture.Name;

            // Refresh the Ribbon Control to prevent Design issues when the Language will be changed.
            ribbonControl1.Refresh();
        }

        #region Open ChildForms
        //=====================================================================================================================================================================
        private void OpenExchangeMonitorFrm_Click(object sender, EventArgs e)
        {
            if (OpenForm("_ExchangeMonitor") == false)
            {
                _ExchangeMonitor ExchangeMon = new _ExchangeMonitor();
                ExchangeMon.Show();
            }
        }

        //=====================================================================================================================================================================
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
        #endregion

        #region LanguageSelector "Click"
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
        # endregion

        //=====================================================================================================================================================================
        private void Btn_AppLock_Click(object sender, EventArgs e)
        {
            ApplicationLock AppLock = new ApplicationLock();
            AppLock.Lock();
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
        private void CultureManager_UICultureChanged(CultureInfo newCulture)
        {
            Settings.Default["UICulture"] = newCulture.Name;
            Settings.Default.Save();
            DisplayLanguage();
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

            Settings.Default["MainWindowHeight"] = Size.Height;
            Settings.Default["MainWindowWidth"] = Size.Width;
            Settings.Default["MainWindowState"] = WindowState;

            Settings.Default.Save();
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
        private void RunDBCompression()
        {
            try
            {
                DataBaseWork DBWorker = new DataBaseWork();
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
                DataBaseWork DBWorker = new DataBaseWork();
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
                    + Path.Combine(Settings.Default["DBFilePath"].ToString(), Settings.Default["DBFile"].ToString()),
                    GlobalStrings._dbBackupNullReferenceExceptionTitle);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //=====================================================================================================================================================================
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //=====================================================================================================================================================================
        private void _eNumismatMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Settings.Default.BackupDBOnAppClose == true)
            {
                RunDBBackup();
            }
            Settings.Default.Save();
        }

        //=====================================================================================================================================================================
        private void Btn_NewDB_Click(object sender, EventArgs e)
        {
            FileDialogInit("create");
        }

        //=====================================================================================================================================================================
        private void Btn_OpenDB_Click(object sender, EventArgs e)
        {
            FileDialogInit("open");
        }

        //=====================================================================================================================================================================
        private void FileDialogInit(string method)
        {
            string InitialDir = null;
            
            if (string.IsNullOrEmpty(Settings.Default["DBFilePath"].ToString()))
            {
                InitialDir = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments);
            }
            else
            {
                InitialDir = Settings.Default["DBFilePath"].ToString();
            }

            if (method == "open")
            {
                OpenFileDialog OpenFile = new OpenFileDialog()
                {
                    AddExtension = true,
                    Filter = "eNumismat Collection (*.enc) | *.enc",
                    InitialDirectory = InitialDir,
                };

                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default["DBFile"] = Path.GetFileName(OpenFile.FileName);
                    Settings.Default["DBFilePath"] = Path.GetDirectoryName(OpenFile.FileName);
                }
                else
                {
                    Settings.Default["DBFile"] = string.Empty;
                    Settings.Default["DBFilePath"] = string.Empty;
                }
                Settings.Default.Save();
            }
            else if (method == "create")
            {
                SaveFileDialog SaveFile = new SaveFileDialog()
                {
                    DefaultExt = "*.enc",
                    Filter = "eNumismat Collection (*.enc) | *.enc",
                    AddExtension = true,
                    InitialDirectory = InitialDir,
                };

                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default["DBFile"] = Path.GetFileName(SaveFile.FileName);
                    Settings.Default["DBFilePath"] = Path.GetDirectoryName(SaveFile.FileName);
                }
                else
                {
                    Settings.Default["DBFile"] = string.Empty;
                    Settings.Default["DBFilePath"] = string.Empty;
                }
                Settings.Default.Save();

                MessageBox.Show(Settings.Default["DBFile"].ToString());

                DataBaseWork DBWorker = new DataBaseWork();
                DBWorker.CreateNewDataBase();
            }
            CheckIfDbFileExists();
        }

        //=====================================================================================================================================================================
        private void CheckIfDbFileExists()
        {
            if (string.IsNullOrEmpty(Settings.Default["DBFile"].ToString()) && string.IsNullOrEmpty(Settings.Default["DBFilePath"].ToString()))
            {
                toolStripStatusLabel2.Image = Resources.disconnect;
                toolStripStatusLabel2.Text = GlobalStrings._dbConnectionNoDbFile;

                btn_BackupDB.Enabled = false;
                btn_CompressDB.Enabled = false;
                OpenExchangeMonitorFrm.Enabled = false;
                OpenAddrBookFrm.Enabled = false;
            }
            else
            {
                if (File.Exists(Path.Combine(Settings.Default["DBFilePath"].ToString(), Settings.Default["DBFile"].ToString())))
                {
                    toolStripStatusLabel2.Image = Resources.connect;
                    toolStripStatusLabel2.Text = GlobalStrings._dbConnectionDbFile + Settings.Default.DBFile;

                    btn_BackupDB.Enabled = true;
                    btn_CompressDB.Enabled = true;
                    OpenExchangeMonitorFrm.Enabled = true;
                    OpenAddrBookFrm.Enabled = true;
                }
                else
                {
                    toolStripStatusLabel2.Image = Resources.disconnect;
                    toolStripStatusLabel2.Text = GlobalStrings._dbConnectionNoDbFile;

                    btn_BackupDB.Enabled = false;
                    btn_CompressDB.Enabled = false;
                    OpenExchangeMonitorFrm.Enabled = false;
                    OpenAddrBookFrm.Enabled = false;
                }
            }
        }
    }
}
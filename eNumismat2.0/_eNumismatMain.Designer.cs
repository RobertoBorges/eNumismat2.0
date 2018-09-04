namespace eNumismat2._0
{
    partial class _eNumismatMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_eNumismatMain));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.applicationButton1 = new DevComponents.DotNetBar.ApplicationButton();
            this.btn_NewDB = new DevComponents.DotNetBar.ButtonItem();
            this.btn_OpenDB = new DevComponents.DotNetBar.ButtonItem();
            this.btn_BackupDB = new DevComponents.DotNetBar.ButtonItem();
            this.btn_CompressDB = new DevComponents.DotNetBar.ButtonItem();
            this.btn_AppLock = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem9 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem10 = new DevComponents.DotNetBar.ButtonItem();
            this.LangEN_GB = new DevComponents.DotNetBar.ButtonItem();
            this.LangEN_US = new DevComponents.DotNetBar.ButtonItem();
            this.LangDE = new DevComponents.DotNetBar.ButtonItem();
            this.LangFR = new DevComponents.DotNetBar.ButtonItem();
            this.LangES = new DevComponents.DotNetBar.ButtonItem();
            this.LangPT = new DevComponents.DotNetBar.ButtonItem();
            this.LangRU = new DevComponents.DotNetBar.ButtonItem();
            this.btn_SettingsDialog = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Close = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.OpenExchangeMonitorFrm = new DevComponents.DotNetBar.ButtonItem();
            this.OpenAddrBookFrm = new DevComponents.DotNetBar.ButtonItem();
            this.btnHelp = new DevComponents.DotNetBar.ButtonItem();
            this.btnAbout = new DevComponents.DotNetBar.ButtonItem();
            this.btnHelp2 = new DevComponents.DotNetBar.ButtonItem();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.culture = new Infralution.Localization.CultureManager(this.components);
            this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.ribbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            resources.ApplyResources(this.ribbonControl1, "ribbonControl1");
            this.ribbonControl1.ForeColor = System.Drawing.Color.Black;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.applicationButton1,
            this.ribbonTabItem1,
            this.OpenExchangeMonitorFrm,
            this.OpenAddrBookFrm});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.MdiSystemItemVisible = false;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnHelp});
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl1.SystemText.MaximizeRibbonText = resources.GetString("ribbonControl1.SystemText.MaximizeRibbonText");
            this.ribbonControl1.SystemText.MinimizeRibbonText = resources.GetString("ribbonControl1.SystemText.MinimizeRibbonText");
            this.ribbonControl1.SystemText.QatAddItemText = resources.GetString("ribbonControl1.SystemText.QatAddItemText");
            this.ribbonControl1.SystemText.QatCustomizeMenuLabel = resources.GetString("ribbonControl1.SystemText.QatCustomizeMenuLabel");
            this.ribbonControl1.SystemText.QatCustomizeText = resources.GetString("ribbonControl1.SystemText.QatCustomizeText");
            this.ribbonControl1.SystemText.QatDialogAddButton = resources.GetString("ribbonControl1.SystemText.QatDialogAddButton");
            this.ribbonControl1.SystemText.QatDialogCancelButton = resources.GetString("ribbonControl1.SystemText.QatDialogCancelButton");
            this.ribbonControl1.SystemText.QatDialogCaption = resources.GetString("ribbonControl1.SystemText.QatDialogCaption");
            this.ribbonControl1.SystemText.QatDialogCategoriesLabel = resources.GetString("ribbonControl1.SystemText.QatDialogCategoriesLabel");
            this.ribbonControl1.SystemText.QatDialogOkButton = resources.GetString("ribbonControl1.SystemText.QatDialogOkButton");
            this.ribbonControl1.SystemText.QatDialogPlacementCheckbox = resources.GetString("ribbonControl1.SystemText.QatDialogPlacementCheckbox");
            this.ribbonControl1.SystemText.QatDialogRemoveButton = resources.GetString("ribbonControl1.SystemText.QatDialogRemoveButton");
            this.ribbonControl1.SystemText.QatPlaceAboveRibbonText = resources.GetString("ribbonControl1.SystemText.QatPlaceAboveRibbonText");
            this.ribbonControl1.SystemText.QatPlaceBelowRibbonText = resources.GetString("ribbonControl1.SystemText.QatPlaceBelowRibbonText");
            this.ribbonControl1.SystemText.QatRemoveItemText = resources.GetString("ribbonControl1.SystemText.QatRemoveItemText");
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabGroupsVisible = true;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            resources.ApplyResources(this.ribbonPanel1, "ribbonPanel1");
            this.ribbonPanel1.Name = "ribbonPanel1";
            // 
            // 
            // 
            this.ribbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            resources.ApplyResources(this.ribbonBar1, "ribbonBar1");
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // applicationButton1
            // 
            this.applicationButton1.AutoExpandOnClick = true;
            this.applicationButton1.CanCustomize = false;
            this.applicationButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image;
            this.applicationButton1.Image = ((System.Drawing.Image)(resources.GetObject("applicationButton1.Image")));
            this.applicationButton1.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.applicationButton1.ImagePaddingHorizontal = 0;
            this.applicationButton1.ImagePaddingVertical = 1;
            this.applicationButton1.Name = "applicationButton1";
            this.applicationButton1.ShowSubItems = false;
            this.applicationButton1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_NewDB,
            this.btn_OpenDB,
            this.btn_BackupDB,
            this.btn_CompressDB,
            this.btn_AppLock,
            this.buttonItem9,
            this.btn_Close});
            resources.ApplyResources(this.applicationButton1, "applicationButton1");
            // 
            // btn_NewDB
            // 
            this.btn_NewDB.Image = global::eNumismat2._0.Properties.Resources.database_add;
            this.btn_NewDB.Name = "btn_NewDB";
            resources.ApplyResources(this.btn_NewDB, "btn_NewDB");
            this.btn_NewDB.Click += new System.EventHandler(this.Btn_NewDB_Click);
            // 
            // btn_OpenDB
            // 
            this.btn_OpenDB.Image = global::eNumismat2._0.Properties.Resources.database_connect;
            this.btn_OpenDB.Name = "btn_OpenDB";
            resources.ApplyResources(this.btn_OpenDB, "btn_OpenDB");
            this.btn_OpenDB.Click += new System.EventHandler(this.Btn_OpenDB_Click);
            // 
            // btn_BackupDB
            // 
            this.btn_BackupDB.BeginGroup = true;
            this.btn_BackupDB.Image = global::eNumismat2._0.Properties.Resources.database_save;
            this.btn_BackupDB.Name = "btn_BackupDB";
            resources.ApplyResources(this.btn_BackupDB, "btn_BackupDB");
            this.btn_BackupDB.Click += new System.EventHandler(this.Btn_BackupDB_Click);
            // 
            // btn_CompressDB
            // 
            this.btn_CompressDB.Image = global::eNumismat2._0.Properties.Resources.compress;
            this.btn_CompressDB.Name = "btn_CompressDB";
            resources.ApplyResources(this.btn_CompressDB, "btn_CompressDB");
            this.btn_CompressDB.Click += new System.EventHandler(this.Btn_CompressDB_Click);
            // 
            // btn_AppLock
            // 
            this.btn_AppLock.BeginGroup = true;
            this.btn_AppLock.Name = "btn_AppLock";
            resources.ApplyResources(this.btn_AppLock, "btn_AppLock");
            this.btn_AppLock.Click += new System.EventHandler(this.Btn_AppLock_Click);
            // 
            // buttonItem9
            // 
            this.buttonItem9.BeginGroup = true;
            this.buttonItem9.Image = global::eNumismat2._0.Properties.Resources.wrench;
            this.buttonItem9.Name = "buttonItem9";
            this.buttonItem9.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem10,
            this.btn_SettingsDialog});
            resources.ApplyResources(this.buttonItem9, "buttonItem9");
            // 
            // buttonItem10
            // 
            this.buttonItem10.Name = "buttonItem10";
            this.buttonItem10.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.LangEN_GB,
            this.LangEN_US,
            this.LangDE,
            this.LangFR,
            this.LangES,
            this.LangPT,
            this.LangRU});
            resources.ApplyResources(this.buttonItem10, "buttonItem10");
            // 
            // LangEN_GB
            // 
            this.LangEN_GB.Image = global::eNumismat2._0.Properties.Resources.gb;
            this.LangEN_GB.Name = "LangEN_GB";
            resources.ApplyResources(this.LangEN_GB, "LangEN_GB");
            this.LangEN_GB.Click += new System.EventHandler(this.LangEN_GB_Click);
            // 
            // LangEN_US
            // 
            this.LangEN_US.Image = global::eNumismat2._0.Properties.Resources.us;
            this.LangEN_US.Name = "LangEN_US";
            resources.ApplyResources(this.LangEN_US, "LangEN_US");
            this.LangEN_US.Click += new System.EventHandler(this.LangEN_US_Click);
            // 
            // LangDE
            // 
            this.LangDE.Image = global::eNumismat2._0.Properties.Resources.de;
            this.LangDE.Name = "LangDE";
            resources.ApplyResources(this.LangDE, "LangDE");
            this.LangDE.Click += new System.EventHandler(this.LangDE_Click);
            // 
            // LangFR
            // 
            this.LangFR.Image = global::eNumismat2._0.Properties.Resources.fr;
            this.LangFR.Name = "LangFR";
            resources.ApplyResources(this.LangFR, "LangFR");
            this.LangFR.Click += new System.EventHandler(this.LangFR_Click);
            // 
            // LangES
            // 
            this.LangES.Image = global::eNumismat2._0.Properties.Resources.es;
            this.LangES.Name = "LangES";
            resources.ApplyResources(this.LangES, "LangES");
            this.LangES.Click += new System.EventHandler(this.LangES_Click);
            // 
            // LangPT
            // 
            this.LangPT.Image = global::eNumismat2._0.Properties.Resources.pt;
            this.LangPT.Name = "LangPT";
            resources.ApplyResources(this.LangPT, "LangPT");
            this.LangPT.Click += new System.EventHandler(this.LangPT_Click);
            // 
            // LangRU
            // 
            this.LangRU.Image = global::eNumismat2._0.Properties.Resources.ru;
            this.LangRU.Name = "LangRU";
            resources.ApplyResources(this.LangRU, "LangRU");
            this.LangRU.Click += new System.EventHandler(this.LangRU_Click);
            // 
            // btn_SettingsDialog
            // 
            this.btn_SettingsDialog.Name = "btn_SettingsDialog";
            resources.ApplyResources(this.btn_SettingsDialog, "btn_SettingsDialog");
            this.btn_SettingsDialog.Click += new System.EventHandler(this.Btn_SettingsDialog_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BeginGroup = true;
            this.btn_Close.Image = global::eNumismat2._0.Properties.Resources.door_in;
            this.btn_Close.Name = "btn_Close";
            resources.ApplyResources(this.btn_Close, "btn_Close");
            this.btn_Close.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            resources.ApplyResources(this.ribbonTabItem1, "ribbonTabItem1");
            // 
            // OpenExchangeMonitorFrm
            // 
            this.OpenExchangeMonitorFrm.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.OpenExchangeMonitorFrm.CanCustomize = false;
            this.OpenExchangeMonitorFrm.GlobalItem = false;
            this.OpenExchangeMonitorFrm.Image = global::eNumismat2._0.Properties.Resources.page_refresh;
            this.OpenExchangeMonitorFrm.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.OpenExchangeMonitorFrm.Name = "OpenExchangeMonitorFrm";
            resources.ApplyResources(this.OpenExchangeMonitorFrm, "OpenExchangeMonitorFrm");
            this.OpenExchangeMonitorFrm.ShowSubItems = false;
            this.OpenExchangeMonitorFrm.Click += new System.EventHandler(this.OpenExchangeMonitorFrm_Click);
            // 
            // OpenAddrBookFrm
            // 
            this.OpenAddrBookFrm.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.OpenAddrBookFrm.Image = global::eNumismat2._0.Properties.Resources.book_addresses;
            this.OpenAddrBookFrm.Name = "OpenAddrBookFrm";
            resources.ApplyResources(this.OpenAddrBookFrm, "OpenAddrBookFrm");
            this.OpenAddrBookFrm.Click += new System.EventHandler(this.OpenAddrBookFrm_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::eNumismat2._0.Properties.Resources.help;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAbout,
            this.btnHelp2});
            // 
            // btnAbout
            // 
            this.btnAbout.Image = global::eNumismat2._0.Properties.Resources.information;
            this.btnAbout.Name = "btnAbout";
            resources.ApplyResources(this.btnAbout, "btnAbout");
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // btnHelp2
            // 
            this.btnHelp2.Image = global::eNumismat2._0.Properties.Resources.help;
            this.btnHelp2.Name = "btnHelp2";
            resources.ApplyResources(this.btnHelp2, "btnHelp2");
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2012Light;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254))))), System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(143))))));
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX1, "labelX1");
            this.labelX1.Name = "labelX1";
            // 
            // culture
            // 
            this.culture.ManagedControl = this;
            this.culture.UICultureChanged += new Infralution.Localization.CultureManager.CultureChangedHandler(this.CultureManager_UICultureChanged);
            // 
            // TrayIcon
            // 
            this.TrayIcon.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.TrayIcon, "TrayIcon");
            this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TryIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // _eNumismatMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.KeyPreview = true;
            this.Name = "_eNumismatMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._eNumismatMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this._eNumismatMain_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this._eNumismatMain_KeyDown);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.ApplicationButton applicationButton1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonItem btn_NewDB;
        private DevComponents.DotNetBar.ButtonItem btn_OpenDB;
        private DevComponents.DotNetBar.ButtonItem btn_BackupDB;
        private DevComponents.DotNetBar.ButtonItem btn_Close;
        private DevComponents.DotNetBar.ButtonItem btn_CompressDB;
        private DevComponents.DotNetBar.ButtonItem OpenExchangeMonitorFrm;
        private DevComponents.DotNetBar.ButtonItem OpenAddrBookFrm;
        private DevComponents.DotNetBar.ButtonItem buttonItem9;
        private DevComponents.DotNetBar.ButtonItem buttonItem10;
        private DevComponents.DotNetBar.ButtonItem LangEN_GB;
        private DevComponents.DotNetBar.ButtonItem LangDE;
        private DevComponents.DotNetBar.ButtonItem LangFR;
        private DevComponents.DotNetBar.ButtonItem LangES;
        private DevComponents.DotNetBar.ButtonItem LangPT;
        private DevComponents.DotNetBar.ButtonItem LangRU;
        private DevComponents.DotNetBar.ButtonItem btn_SettingsDialog;
        private DevComponents.DotNetBar.ButtonItem btnHelp;
        private DevComponents.DotNetBar.ButtonItem btnAbout;
        private DevComponents.DotNetBar.ButtonItem btnHelp2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private DevComponents.DotNetBar.ButtonItem LangEN_US;
        private DevComponents.DotNetBar.LabelX labelX1;
        private Infralution.Localization.CultureManager culture;
        private System.Windows.Forms.NotifyIcon TrayIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private DevComponents.DotNetBar.ButtonItem btn_AppLock;
    }
}


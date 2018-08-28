namespace eNumismat2._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonRibbon1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonContextMenuHeading1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.NewDatabase = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.OpenDatabase = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.BackupDatabase = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.CompressDatabase = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuHeading2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.ApplicationSettings = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.UserSettings = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem4 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem5 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem6 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.buttonSpecAppMenu1 = new ComponentFactory.Krypton.Ribbon.ButtonSpecAppMenu();
            this.kryptonDockableWorkspace1 = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.kryptonContextMenuItems2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.AllowFormIntegrate = false;
            this.kryptonRibbon1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1,
            this.buttonSpecAny2,
            this.buttonSpecAny3});
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.RibbonAppButton.AppButtonMenuItems.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuHeading1,
            this.NewDatabase,
            this.OpenDatabase,
            this.kryptonContextMenuSeparator1,
            this.BackupDatabase,
            this.CompressDatabase,
            this.kryptonContextMenuHeading2,
            this.ApplicationSettings,
            this.UserSettings});
            this.kryptonRibbon1.RibbonAppButton.AppButtonSpecs.AddRange(new ComponentFactory.Krypton.Ribbon.ButtonSpecAppMenu[] {
            this.buttonSpecAppMenu1});
            this.kryptonRibbon1.SelectedContext = null;
            this.kryptonRibbon1.SelectedTab = null;
            resources.ApplyResources(this.kryptonRibbon1, "kryptonRibbon1");
            // 
            // buttonSpecAny1
            // 
            resources.ApplyResources(this.buttonSpecAny1, "buttonSpecAny1");
            this.buttonSpecAny1.UniqueName = "059A08130A414D0BAEAF79F2BE00BF44";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // buttonSpecAny2
            // 
            resources.ApplyResources(this.buttonSpecAny2, "buttonSpecAny2");
            this.buttonSpecAny2.UniqueName = "BD2B8B8E96BF4CFECE9A93EE1900D43C";
            this.buttonSpecAny2.Click += new System.EventHandler(this.buttonSpecAny2_Click);
            // 
            // buttonSpecAny3
            // 
            resources.ApplyResources(this.buttonSpecAny3, "buttonSpecAny3");
            this.buttonSpecAny3.UniqueName = "03A428021B5049385B901975512D717F";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click);
            // 
            // kryptonContextMenuHeading1
            // 
            resources.ApplyResources(this.kryptonContextMenuHeading1, "kryptonContextMenuHeading1");
            this.kryptonContextMenuHeading1.Image = global::eNumismat2._0.Properties.Resources.database;
            // 
            // NewDatabase
            // 
            this.NewDatabase.Image = global::eNumismat2._0.Properties.Resources.database_add;
            resources.ApplyResources(this.NewDatabase, "NewDatabase");
            // 
            // OpenDatabase
            // 
            this.OpenDatabase.Image = global::eNumismat2._0.Properties.Resources.database_connect;
            resources.ApplyResources(this.OpenDatabase, "OpenDatabase");
            // 
            // BackupDatabase
            // 
            this.BackupDatabase.Image = global::eNumismat2._0.Properties.Resources.database_save;
            resources.ApplyResources(this.BackupDatabase, "BackupDatabase");
            // 
            // CompressDatabase
            // 
            this.CompressDatabase.Image = global::eNumismat2._0.Properties.Resources.compress;
            resources.ApplyResources(this.CompressDatabase, "CompressDatabase");
            // 
            // kryptonContextMenuHeading2
            // 
            resources.ApplyResources(this.kryptonContextMenuHeading2, "kryptonContextMenuHeading2");
            // 
            // ApplicationSettings
            // 
            resources.ApplyResources(this.ApplicationSettings, "ApplicationSettings");
            // 
            // UserSettings
            // 
            this.UserSettings.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems1});
            resources.ApplyResources(this.UserSettings, "UserSettings");
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem2,
            this.kryptonContextMenuItem3,
            this.kryptonContextMenuItem4,
            this.kryptonContextMenuItem5,
            this.kryptonContextMenuItem6});
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Image = global::eNumismat2._0.Properties.Resources.GB_United_Kingdom_Flag_icon;
            resources.ApplyResources(this.kryptonContextMenuItem2, "kryptonContextMenuItem2");
            // 
            // kryptonContextMenuItem3
            // 
            this.kryptonContextMenuItem3.Image = global::eNumismat2._0.Properties.Resources.DE_Germany_Flag_icon;
            resources.ApplyResources(this.kryptonContextMenuItem3, "kryptonContextMenuItem3");
            // 
            // kryptonContextMenuItem4
            // 
            this.kryptonContextMenuItem4.Image = global::eNumismat2._0.Properties.Resources.FR_France_Flag_icon;
            resources.ApplyResources(this.kryptonContextMenuItem4, "kryptonContextMenuItem4");
            // 
            // kryptonContextMenuItem5
            // 
            this.kryptonContextMenuItem5.Image = global::eNumismat2._0.Properties.Resources.ES_Spain_Flag_icon;
            resources.ApplyResources(this.kryptonContextMenuItem5, "kryptonContextMenuItem5");
            // 
            // kryptonContextMenuItem6
            // 
            this.kryptonContextMenuItem6.Image = global::eNumismat2._0.Properties.Resources.RU_Russia_Flag_icon;
            resources.ApplyResources(this.kryptonContextMenuItem6, "kryptonContextMenuItem6");
            // 
            // buttonSpecAppMenu1
            // 
            resources.ApplyResources(this.buttonSpecAppMenu1, "buttonSpecAppMenu1");
            this.buttonSpecAppMenu1.UniqueName = "7831FBE4D3744A35F2A7DA3803D75167";
            // 
            // kryptonDockableWorkspace1
            // 
            this.kryptonDockableWorkspace1.AutoHiddenHost = false;
            this.kryptonDockableWorkspace1.CompactFlags = ((ComponentFactory.Krypton.Workspace.CompactFlags)(((ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptyCells | ComponentFactory.Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | ComponentFactory.Krypton.Workspace.CompactFlags.PromoteLeafs)));
            resources.ApplyResources(this.kryptonDockableWorkspace1, "kryptonDockableWorkspace1");
            this.kryptonDockableWorkspace1.Name = "kryptonDockableWorkspace1";
            // 
            // 
            // 
            this.kryptonDockableWorkspace1.Root.UniqueName = "701D7622364F4B4E7D91D4DE375C47C5";
            this.kryptonDockableWorkspace1.Root.WorkspaceControl = this.kryptonDockableWorkspace1;
            this.kryptonDockableWorkspace1.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace1.TabStop = true;
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonDockableWorkspace1);
            this.Controls.Add(this.kryptonRibbon1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem NewDatabase;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem OpenDatabase;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator kryptonContextMenuSeparator1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem BackupDatabase;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem CompressDatabase;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem ApplicationSettings;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem UserSettings;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Ribbon.ButtonSpecAppMenu buttonSpecAppMenu1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem3;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem4;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem5;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem6;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems2;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
    }
}


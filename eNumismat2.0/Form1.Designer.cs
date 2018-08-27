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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonRibbon1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.buttonSpecAny2 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonContextMenuHeading1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuItem1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.kryptonContextMenuItem3 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem4 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuHeading2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading();
            this.kryptonContextMenuItem5 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuItem6 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonRibbonTab1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonDockableWorkspace1 = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.AllowFormIntegrate = false;
            this.kryptonRibbon1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1,
            this.buttonSpecAny2});
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.RibbonAppButton.AppButtonMenuItems.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuHeading1,
            this.kryptonContextMenuItem1,
            this.kryptonContextMenuItem2,
            this.kryptonContextMenuSeparator1,
            this.kryptonContextMenuItem3,
            this.kryptonContextMenuItem4,
            this.kryptonContextMenuHeading2,
            this.kryptonContextMenuItem5,
            this.kryptonContextMenuItem6});
            this.kryptonRibbon1.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.kryptonRibbonTab1});
            this.kryptonRibbon1.SelectedTab = this.kryptonRibbonTab1;
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
            // kryptonContextMenuHeading1
            // 
            resources.ApplyResources(this.kryptonContextMenuHeading1, "kryptonContextMenuHeading1");
            this.kryptonContextMenuHeading1.Image = global::eNumismat2._0.Properties.Resources.database;
            // 
            // kryptonContextMenuItem1
            // 
            this.kryptonContextMenuItem1.Image = global::eNumismat2._0.Properties.Resources.database_add;
            resources.ApplyResources(this.kryptonContextMenuItem1, "kryptonContextMenuItem1");
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Image = global::eNumismat2._0.Properties.Resources.database_connect;
            resources.ApplyResources(this.kryptonContextMenuItem2, "kryptonContextMenuItem2");
            // 
            // kryptonContextMenuItem3
            // 
            this.kryptonContextMenuItem3.Image = global::eNumismat2._0.Properties.Resources.database_save;
            resources.ApplyResources(this.kryptonContextMenuItem3, "kryptonContextMenuItem3");
            // 
            // kryptonContextMenuItem4
            // 
            this.kryptonContextMenuItem4.Image = global::eNumismat2._0.Properties.Resources.compress;
            resources.ApplyResources(this.kryptonContextMenuItem4, "kryptonContextMenuItem4");
            // 
            // kryptonContextMenuHeading2
            // 
            resources.ApplyResources(this.kryptonContextMenuHeading2, "kryptonContextMenuHeading2");
            // 
            // kryptonContextMenuItem5
            // 
            resources.ApplyResources(this.kryptonContextMenuItem5, "kryptonContextMenuItem5");
            // 
            // kryptonContextMenuItem6
            // 
            resources.ApplyResources(this.kryptonContextMenuItem6, "kryptonContextMenuItem6");
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
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator kryptonContextMenuSeparator1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem3;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem4;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuHeading kryptonContextMenuHeading2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem5;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem6;
        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
    }
}


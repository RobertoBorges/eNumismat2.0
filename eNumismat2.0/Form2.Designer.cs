namespace eNumismat2._0
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.kryptonDockableWorkspace1 = new ComponentFactory.Krypton.Docking.KryptonDockableWorkspace();
            this.kryptonDockingManager1 = new ComponentFactory.Krypton.Docking.KryptonDockingManager();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            this.SuspendLayout();
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
            this.kryptonDockableWorkspace1.Root.UniqueName = "6A1AC658EB2048B51CABBAB43C23A339";
            this.kryptonDockableWorkspace1.Root.WorkspaceControl = this.kryptonDockableWorkspace1;
            this.kryptonDockableWorkspace1.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace1.TabStop = true;
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kryptonDockableWorkspace1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private ComponentFactory.Krypton.Docking.KryptonDockingManager kryptonDockingManager1;
    }
}
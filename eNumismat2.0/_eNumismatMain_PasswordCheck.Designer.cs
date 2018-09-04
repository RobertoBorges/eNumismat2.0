namespace eNumismat2._0
{
    partial class _eNumismatMain_PasswordCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_eNumismatMain_PasswordCheck));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.btn_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.tb_CurrentPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
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
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Save.Image = global::eNumismat2._0.Properties.Resources.action_check;
            resources.ApplyResources(this.btn_Save, "btn_Save");
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Image = global::eNumismat2._0.Properties.Resources.action_delete;
            resources.ApplyResources(this.btn_Cancel, "btn_Cancel");
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            // 
            // tb_CurrentPassword
            // 
            this.tb_CurrentPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_CurrentPassword.Border.Class = "TextBoxBorder";
            this.tb_CurrentPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_CurrentPassword.DisabledBackColor = System.Drawing.Color.LightGray;
            this.tb_CurrentPassword.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.tb_CurrentPassword, "tb_CurrentPassword");
            this.tb_CurrentPassword.Name = "tb_CurrentPassword";
            this.tb_CurrentPassword.PreventEnterBeep = true;
            this.tb_CurrentPassword.UseSystemPasswordChar = true;
            // 
            // _eNumismatMain_PasswordCheck
            // 
            this.AcceptButton = this.btn_Save;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ControlBox = false;
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.tb_CurrentPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "_eNumismatMain_PasswordCheck";
            this.TopMost = true;
            this.Load += new System.EventHandler(this._eNumismatMain_PasswordCheck_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_Save;
        private DevComponents.DotNetBar.ButtonX btn_Cancel;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_CurrentPassword;
    }
}
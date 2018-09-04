namespace eNumismat2._0
{
    partial class _SettingsDialog_PasswordProtection
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_SettingsDialog_PasswordProtection));
            this.tb_CurrentPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_NewPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tb_PasswordConfirmation = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.btn_Save = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.compareValidator1 = new DevComponents.DotNetBar.Validator.CompareValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            // tb_NewPassword
            // 
            this.tb_NewPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_NewPassword.Border.Class = "TextBoxBorder";
            this.tb_NewPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_NewPassword.DisabledBackColor = System.Drawing.Color.White;
            this.tb_NewPassword.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.tb_NewPassword, "tb_NewPassword");
            this.tb_NewPassword.Name = "tb_NewPassword";
            this.tb_NewPassword.PreventEnterBeep = true;
            this.tb_NewPassword.UseSystemPasswordChar = true;
            // 
            // tb_PasswordConfirmation
            // 
            this.tb_PasswordConfirmation.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.tb_PasswordConfirmation.Border.Class = "TextBoxBorder";
            this.tb_PasswordConfirmation.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tb_PasswordConfirmation.DisabledBackColor = System.Drawing.Color.White;
            this.tb_PasswordConfirmation.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.tb_PasswordConfirmation, "tb_PasswordConfirmation");
            this.tb_PasswordConfirmation.Name = "tb_PasswordConfirmation";
            this.tb_PasswordConfirmation.PreventEnterBeep = true;
            this.tb_PasswordConfirmation.UseSystemPasswordChar = true;
            this.superValidator1.SetValidator1(this.tb_PasswordConfirmation, this.compareValidator1);
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
            this.btn_Cancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Save.Image = global::eNumismat2._0.Properties.Resources.action_check;
            resources.ApplyResources(this.btn_Save, "btn_Save");
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Save.Click += new System.EventHandler(this.BtnSave_Click);
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
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX2, "labelX2");
            this.labelX2.Name = "labelX2";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            resources.ApplyResources(this.labelX3, "labelX3");
            this.labelX3.Name = "labelX3";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // compareValidator1
            // 
            this.compareValidator1.ControlToCompare = this.tb_NewPassword;
            resources.ApplyResources(this.compareValidator1, "compareValidator1");
            this.compareValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            this.highlighter1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            // 
            // _SettingsDialog_PasswordProtection
            // 
            this.AcceptButton = this.btn_Save;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_Cancel;
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.tb_PasswordConfirmation);
            this.Controls.Add(this.tb_NewPassword);
            this.Controls.Add(this.tb_CurrentPassword);
            this.Name = "_SettingsDialog_PasswordProtection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._SettingsDialog_PasswordProtection_FormClosing);
            this.Load += new System.EventHandler(this._SettingsDialog_PasswordProtection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tb_CurrentPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_NewPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_PasswordConfirmation;
        private DevComponents.DotNetBar.ButtonX btn_Cancel;
        private DevComponents.DotNetBar.ButtonX btn_Save;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator1;
    }
}
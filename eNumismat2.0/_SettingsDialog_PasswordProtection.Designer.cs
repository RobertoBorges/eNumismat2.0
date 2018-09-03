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
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.compareValidator1 = new DevComponents.DotNetBar.Validator.CompareValidator();
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
            this.tb_CurrentPassword.Location = new System.Drawing.Point(135, 12);
            this.tb_CurrentPassword.Name = "tb_CurrentPassword";
            this.tb_CurrentPassword.PreventEnterBeep = true;
            this.tb_CurrentPassword.Size = new System.Drawing.Size(156, 20);
            this.tb_CurrentPassword.TabIndex = 0;
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
            this.tb_NewPassword.Location = new System.Drawing.Point(135, 38);
            this.tb_NewPassword.Name = "tb_NewPassword";
            this.tb_NewPassword.PreventEnterBeep = true;
            this.tb_NewPassword.Size = new System.Drawing.Size(156, 20);
            this.tb_NewPassword.TabIndex = 1;
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
            this.tb_PasswordConfirmation.Location = new System.Drawing.Point(135, 64);
            this.tb_PasswordConfirmation.Name = "tb_PasswordConfirmation";
            this.tb_PasswordConfirmation.PreventEnterBeep = true;
            this.tb_PasswordConfirmation.Size = new System.Drawing.Size(156, 20);
            this.tb_PasswordConfirmation.TabIndex = 2;
            this.tb_PasswordConfirmation.UseSystemPasswordChar = true;
            this.superValidator1.SetValidator1(this.tb_PasswordConfirmation, this.compareValidator1);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Image = global::eNumismat2._0.Properties.Resources.action_delete;
            this.buttonX1.Location = new System.Drawing.Point(135, 90);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 3;
            this.buttonX1.Text = "Cancel";
            // 
            // buttonX2
            // 
            this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX2.Image = global::eNumismat2._0.Properties.Resources.action_check;
            this.buttonX2.Location = new System.Drawing.Point(216, 90);
            this.buttonX2.Name = "buttonX2";
            this.buttonX2.Size = new System.Drawing.Size(75, 23);
            this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX2.TabIndex = 4;
            this.buttonX2.Text = "Save";
            this.buttonX2.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(11, 9);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(108, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "Current Password";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(11, 35);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(108, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "New Password";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(11, 61);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(108, 23);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "Confirm Password";
            // 
            // superValidator1
            // 
            this.superValidator1.ContainerControl = this;
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // compareValidator1
            // 
            this.compareValidator1.ControlToCompare = this.tb_NewPassword;
            this.compareValidator1.ErrorMessage = "Your error message here.";
            this.compareValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // _SettingsDialog_PasswordProtection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 136);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.buttonX2);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.tb_PasswordConfirmation);
            this.Controls.Add(this.tb_NewPassword);
            this.Controls.Add(this.tb_CurrentPassword);
            this.Name = "_SettingsDialog_PasswordProtection";
            this.Text = "_SettingsDialog_PasswordProtection";
            this.Load += new System.EventHandler(this._SettingsDialog_PasswordProtection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tb_CurrentPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_NewPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX tb_PasswordConfirmation;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.ButtonX buttonX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.CompareValidator compareValidator1;
    }
}
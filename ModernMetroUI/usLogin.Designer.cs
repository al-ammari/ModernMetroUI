namespace ModernMetroUI
{
    partial class usLogin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usLogin));
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.lblWelcomeMsg = new MetroFramework.Controls.MetroLabel();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.txtDBName = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(414, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.DisplayIcon = true;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.Icon = ((System.Drawing.Image)(resources.GetObject("txtPassword.Icon")));
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(92, 165);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PromptText = "Enter your password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(436, 23);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Enter your password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(414, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.DisplayIcon = true;
            this.txtUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUserName.Icon = ((System.Drawing.Image)(resources.GetObject("txtUserName.Icon")));
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(92, 136);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PromptText = "Enter user name";
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(436, 23);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMark = "Enter user name";
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblWelcomeMsg
            // 
            this.lblWelcomeMsg.AutoSize = true;
            this.lblWelcomeMsg.Location = new System.Drawing.Point(111, 68);
            this.lblWelcomeMsg.Name = "lblWelcomeMsg";
            this.lblWelcomeMsg.Size = new System.Drawing.Size(213, 19);
            this.lblWelcomeMsg.TabIndex = 2;
            this.lblWelcomeMsg.Text = "Welcome to SMART TIME SYSTEM";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(92, 220);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 35);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login ";
            this.btnLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtDBName
            // 
            // 
            // 
            // 
            this.txtDBName.CustomButton.Image = null;
            this.txtDBName.CustomButton.Location = new System.Drawing.Point(414, 1);
            this.txtDBName.CustomButton.Name = "";
            this.txtDBName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDBName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDBName.CustomButton.TabIndex = 1;
            this.txtDBName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDBName.CustomButton.UseSelectable = true;
            this.txtDBName.CustomButton.Visible = false;
            this.txtDBName.DisplayIcon = true;
            this.txtDBName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDBName.Icon = ((System.Drawing.Image)(resources.GetObject("txtDBName.Icon")));
            this.txtDBName.Lines = new string[0];
            this.txtDBName.Location = new System.Drawing.Point(92, 107);
            this.txtDBName.MaxLength = 32767;
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.PasswordChar = '\0';
            this.txtDBName.PromptText = "Enter database server name default name server";
            this.txtDBName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDBName.SelectedText = "";
            this.txtDBName.SelectionLength = 0;
            this.txtDBName.SelectionStart = 0;
            this.txtDBName.ShortcutsEnabled = true;
            this.txtDBName.Size = new System.Drawing.Size(436, 23);
            this.txtDBName.TabIndex = 4;
            this.txtDBName.UseSelectable = true;
            this.txtDBName.WaterMark = "Enter database server name default name server";
            this.txtDBName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDBName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // usLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblWelcomeMsg);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Name = "usLogin";
            this.Size = new System.Drawing.Size(649, 358);
            this.Load += new System.EventHandler(this.usLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel lblWelcomeMsg;
        private MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTextBox txtDBName;
    }
}

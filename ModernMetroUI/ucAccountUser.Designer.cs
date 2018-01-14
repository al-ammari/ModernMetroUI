namespace ModernMetroUI
{
    partial class ucAccountUser
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
            this.btnInsertPic = new MetroFramework.Controls.MetroButton();
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            this.txtOldPassowrd = new MetroFramework.Controls.MetroTextBox();
            this.lblOldPassword = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtDayAlert = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.ckhAlertIsOpen = new MetroFramework.Controls.MetroToggle();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertPic
            // 
            this.btnInsertPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertPic.Location = new System.Drawing.Point(43, 182);
            this.btnInsertPic.Name = "btnInsertPic";
            this.btnInsertPic.Size = new System.Drawing.Size(143, 23);
            this.btnInsertPic.TabIndex = 1;
            this.btnInsertPic.Text = "ادراج صورة المستخدم";
            this.btnInsertPic.UseSelectable = true;
            this.btnInsertPic.Click += new System.EventHandler(this.btnInsertPic_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(553, 42);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(78, 19);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "اسم الـمـستخـدم";
            // 
            // txtOldPassowrd
            // 
            this.txtOldPassowrd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtOldPassowrd.CustomButton.Image = null;
            this.txtOldPassowrd.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txtOldPassowrd.CustomButton.Name = "";
            this.txtOldPassowrd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOldPassowrd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOldPassowrd.CustomButton.TabIndex = 1;
            this.txtOldPassowrd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOldPassowrd.CustomButton.UseSelectable = true;
            this.txtOldPassowrd.CustomButton.Visible = false;
            this.txtOldPassowrd.Lines = new string[] {
        "admin"};
            this.txtOldPassowrd.Location = new System.Drawing.Point(218, 71);
            this.txtOldPassowrd.MaxLength = 32767;
            this.txtOldPassowrd.Name = "txtOldPassowrd";
            this.txtOldPassowrd.PasswordChar = '*';
            this.txtOldPassowrd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOldPassowrd.SelectedText = "";
            this.txtOldPassowrd.SelectionLength = 0;
            this.txtOldPassowrd.SelectionStart = 0;
            this.txtOldPassowrd.ShortcutsEnabled = true;
            this.txtOldPassowrd.Size = new System.Drawing.Size(329, 23);
            this.txtOldPassowrd.TabIndex = 8;
            this.txtOldPassowrd.Text = "admin";
            this.txtOldPassowrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOldPassowrd.UseSelectable = true;
            this.txtOldPassowrd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOldPassowrd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(553, 71);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(67, 19);
            this.lblOldPassword.TabIndex = 7;
            this.lblOldPassword.Text = "كلمة المرور ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(553, 103);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(126, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "ذكرني قبل انتهاء الوثائق بـ";
            // 
            // txtDayAlert
            // 
            this.txtDayAlert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDayAlert.CustomButton.Image = null;
            this.txtDayAlert.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtDayAlert.CustomButton.Name = "";
            this.txtDayAlert.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDayAlert.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDayAlert.CustomButton.TabIndex = 1;
            this.txtDayAlert.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDayAlert.CustomButton.UseSelectable = true;
            this.txtDayAlert.CustomButton.Visible = false;
            this.txtDayAlert.Lines = new string[0];
            this.txtDayAlert.Location = new System.Drawing.Point(472, 100);
            this.txtDayAlert.MaxLength = 32767;
            this.txtDayAlert.Name = "txtDayAlert";
            this.txtDayAlert.PasswordChar = '\0';
            this.txtDayAlert.PromptText = "0";
            this.txtDayAlert.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDayAlert.SelectedText = "";
            this.txtDayAlert.SelectionLength = 0;
            this.txtDayAlert.SelectionStart = 0;
            this.txtDayAlert.ShortcutsEnabled = true;
            this.txtDayAlert.Size = new System.Drawing.Size(75, 23);
            this.txtDayAlert.TabIndex = 13;
            this.txtDayAlert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDayAlert.UseSelectable = true;
            this.txtDayAlert.WaterMark = "0";
            this.txtDayAlert.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDayAlert.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(443, 100);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(23, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "يوم";
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(239, 129);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(227, 19);
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "اظهار التنبيهـات افتراضـيـا عند تـشـغـيل الـنـظـام ";
            // 
            // ckhAlertIsOpen
            // 
            this.ckhAlertIsOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckhAlertIsOpen.AutoSize = true;
            this.ckhAlertIsOpen.Location = new System.Drawing.Point(467, 129);
            this.ckhAlertIsOpen.Name = "ckhAlertIsOpen";
            this.ckhAlertIsOpen.Size = new System.Drawing.Size(80, 17);
            this.ckhAlertIsOpen.TabIndex = 19;
            this.ckhAlertIsOpen.Text = "Off";
            this.ckhAlertIsOpen.UseSelectable = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(384, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(163, 33);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "تـحـديـث الـبيـانـات";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // picUser
            // 
            this.picUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picUser.Image = global::ModernMetroUI.Properties.Resources.PersonalPicture;
            this.picUser.Location = new System.Drawing.Point(43, 35);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(143, 141);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(307, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(218, 42);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(329, 23);
            this.txtUserName.TabIndex = 21;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ofdOpen
            // 
            this.ofdOpen.FileName = "openFileDialog1";
            // 
            // ucAccountUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.ckhAlertIsOpen);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtDayAlert);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtOldPassowrd);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnInsertPic);
            this.Controls.Add(this.picUser);
            this.Name = "ucAccountUser";
            this.Size = new System.Drawing.Size(749, 331);
            this.Load += new System.EventHandler(this.ucAccountUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picUser;
        private MetroFramework.Controls.MetroButton btnInsertPic;
        private MetroFramework.Controls.MetroLabel lblUserName;
        private MetroFramework.Controls.MetroTextBox txtOldPassowrd;
        private MetroFramework.Controls.MetroLabel lblOldPassword;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtDayAlert;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroToggle ckhAlertIsOpen;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
    }
}

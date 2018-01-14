namespace ModernMetroUI
{
    partial class frmRemmber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemmber));
            this.btnRenew = new MetroFramework.Controls.MetroButton();
            this.btnYes = new MetroFramework.Controls.MetroButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtDocName = new MetroFramework.Controls.MetroTextBox();
            this.txtDocNo = new MetroFramework.Controls.MetroTextBox();
            this.dtpDateIssue = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.dtpDateExpire = new MetroFramework.Controls.MetroDateTime();
            this.treeDocExpire = new System.Windows.Forms.TreeView();
            this.imglstDoc = new System.Windows.Forms.ImageList(this.components);
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.picDoc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRenew
            // 
            this.btnRenew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenew.Location = new System.Drawing.Point(365, 305);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(106, 33);
            this.btnRenew.TabIndex = 1;
            this.btnRenew.Text = "تجديد";
            this.btnRenew.UseSelectable = true;
            // 
            // btnYes
            // 
            this.btnYes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYes.Location = new System.Drawing.Point(253, 305);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(106, 33);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "حسنا";
            this.btnYes.UseSelectable = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(476, 106);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(63, 19);
            this.metroLabel7.TabIndex = 3;
            this.metroLabel7.Text = "اسم المستند ";
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(476, 136);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(63, 19);
            this.metroLabel8.TabIndex = 4;
            this.metroLabel8.Text = "رقم المستند ";
            // 
            // txtDocName
            // 
            this.txtDocName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDocName.CustomButton.Image = null;
            this.txtDocName.CustomButton.Location = new System.Drawing.Point(411, 1);
            this.txtDocName.CustomButton.Name = "";
            this.txtDocName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDocName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocName.CustomButton.TabIndex = 1;
            this.txtDocName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocName.CustomButton.UseSelectable = true;
            this.txtDocName.CustomButton.Visible = false;
            this.txtDocName.Lines = new string[0];
            this.txtDocName.Location = new System.Drawing.Point(37, 104);
            this.txtDocName.MaxLength = 32767;
            this.txtDocName.Name = "txtDocName";
            this.txtDocName.PasswordChar = '\0';
            this.txtDocName.ReadOnly = true;
            this.txtDocName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocName.SelectedText = "";
            this.txtDocName.SelectionLength = 0;
            this.txtDocName.SelectionStart = 0;
            this.txtDocName.ShortcutsEnabled = true;
            this.txtDocName.Size = new System.Drawing.Size(433, 23);
            this.txtDocName.TabIndex = 5;
            this.txtDocName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDocName.UseSelectable = true;
            this.txtDocName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDocNo
            // 
            this.txtDocNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDocNo.CustomButton.Image = null;
            this.txtDocNo.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txtDocNo.CustomButton.Name = "";
            this.txtDocNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDocNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocNo.CustomButton.TabIndex = 1;
            this.txtDocNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocNo.CustomButton.UseSelectable = true;
            this.txtDocNo.CustomButton.Visible = false;
            this.txtDocNo.Lines = new string[0];
            this.txtDocNo.Location = new System.Drawing.Point(252, 132);
            this.txtDocNo.MaxLength = 32767;
            this.txtDocNo.Name = "txtDocNo";
            this.txtDocNo.PasswordChar = '\0';
            this.txtDocNo.PromptText = "0";
            this.txtDocNo.ReadOnly = true;
            this.txtDocNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocNo.SelectedText = "";
            this.txtDocNo.SelectionLength = 0;
            this.txtDocNo.SelectionStart = 0;
            this.txtDocNo.ShortcutsEnabled = true;
            this.txtDocNo.Size = new System.Drawing.Size(218, 23);
            this.txtDocNo.TabIndex = 6;
            this.txtDocNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDocNo.UseSelectable = true;
            this.txtDocNo.WaterMark = "0";
            this.txtDocNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtpDateIssue
            // 
            this.dtpDateIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateIssue.Location = new System.Drawing.Point(252, 161);
            this.dtpDateIssue.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDateIssue.Name = "dtpDateIssue";
            this.dtpDateIssue.Size = new System.Drawing.Size(218, 29);
            this.dtpDateIssue.TabIndex = 7;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(476, 168);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(79, 19);
            this.metroLabel9.TabIndex = 8;
            this.metroLabel9.Text = "تاريخ الاصدار ";
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(476, 202);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(72, 19);
            this.metroLabel10.TabIndex = 10;
            this.metroLabel10.Text = "تاريخ الانتهاء ";
            // 
            // dtpDateExpire
            // 
            this.dtpDateExpire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateExpire.Location = new System.Drawing.Point(253, 195);
            this.dtpDateExpire.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpDateExpire.Name = "dtpDateExpire";
            this.dtpDateExpire.Size = new System.Drawing.Size(218, 29);
            this.dtpDateExpire.TabIndex = 9;
            // 
            // treeDocExpire
            // 
            this.treeDocExpire.Dock = System.Windows.Forms.DockStyle.Right;
            this.treeDocExpire.ImageIndex = 0;
            this.treeDocExpire.ImageList = this.imglstDoc;
            this.treeDocExpire.Location = new System.Drawing.Point(561, 98);
            this.treeDocExpire.Name = "treeDocExpire";
            this.treeDocExpire.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeDocExpire.RightToLeftLayout = true;
            this.treeDocExpire.SelectedImageIndex = 0;
            this.treeDocExpire.Size = new System.Drawing.Size(240, 329);
            this.treeDocExpire.TabIndex = 11;
            this.treeDocExpire.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeDocExpire_AfterSelect);
            // 
            // imglstDoc
            // 
            this.imglstDoc.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstDoc.ImageStream")));
            this.imglstDoc.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstDoc.Images.SetKeyName(0, "file(1).png");
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile1.Location = new System.Drawing.Point(20, 60);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(781, 38);
            this.metroTile1.TabIndex = 12;
            this.metroTile1.Text = "تنبيـه انتهاء تاريخ المستندات";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.UseSelectable = true;
            // 
            // picDoc
            // 
            this.picDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDoc.Location = new System.Drawing.Point(37, 136);
            this.picDoc.Name = "picDoc";
            this.picDoc.Size = new System.Drawing.Size(209, 236);
            this.picDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoc.TabIndex = 0;
            this.picDoc.TabStop = false;
            this.picDoc.Click += new System.EventHandler(this.picDoc_Click);
            // 
            // frmRemmber
            // 
            this.ClientSize = new System.Drawing.Size(821, 447);
            this.Controls.Add(this.treeDocExpire);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.dtpDateExpire);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.dtpDateIssue);
            this.Controls.Add(this.txtDocNo);
            this.Controls.Add(this.txtDocName);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.picDoc);
            this.Name = "frmRemmber";
            this.Load += new System.EventHandler(this.frmRemmber_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnOk;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox picDoc;
        private MetroFramework.Controls.MetroButton btnRenew;
        private MetroFramework.Controls.MetroButton btnYes;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtDocName;
        private MetroFramework.Controls.MetroTextBox txtDocNo;
        private MetroFramework.Controls.MetroDateTime dtpDateIssue;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroDateTime dtpDateExpire;
        private System.Windows.Forms.TreeView treeDocExpire;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.ImageList imglstDoc;
    }
}
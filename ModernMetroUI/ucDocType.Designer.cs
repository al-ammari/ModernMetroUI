namespace ModernMetroUI
{
    partial class ucDocType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDocType));
            this.pnlContent = new MetroFramework.Controls.MetroPanel();
            this.pnlMain = new MetroFramework.Controls.MetroPanel();
            this.pnlTop = new MetroFramework.Controls.MetroPanel();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtDocType = new MetroFramework.Controls.MetroTextBox();
            this.opnFleDlg = new System.Windows.Forms.OpenFileDialog();
            this.pnlContent.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlMain);
            this.pnlContent.Controls.Add(this.pnlTop);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.HorizontalScrollbarBarColor = true;
            this.pnlContent.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlContent.HorizontalScrollbarSize = 10;
            this.pnlContent.Location = new System.Drawing.Point(20, 60);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(690, 259);
            this.pnlContent.TabIndex = 5;
            this.pnlContent.VerticalScrollbarBarColor = true;
            this.pnlContent.VerticalScrollbarHighlightOnWheel = false;
            this.pnlContent.VerticalScrollbarSize = 10;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.HorizontalScrollbarBarColor = true;
            this.pnlMain.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMain.HorizontalScrollbarSize = 10;
            this.pnlMain.Location = new System.Drawing.Point(0, 100);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(690, 159);
            this.pnlMain.TabIndex = 3;
            this.pnlMain.VerticalScrollbarBarColor = true;
            this.pnlMain.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMain.VerticalScrollbarSize = 10;
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnNew);
            this.pnlTop.Controls.Add(this.btnDelete);
            this.pnlTop.Controls.Add(this.picIcon);
            this.pnlTop.Controls.Add(this.btnSave);
            this.pnlTop.Controls.Add(this.txtDocType);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.HorizontalScrollbarBarColor = true;
            this.pnlTop.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTop.HorizontalScrollbarSize = 10;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(690, 100);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.VerticalScrollbarBarColor = true;
            this.pnlTop.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTop.VerticalScrollbarSize = 10;
            // 
            // btnNew
            // 
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNew.Location = new System.Drawing.Point(632, 42);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(44, 30);
            this.btnNew.TabIndex = 9;
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(532, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.SystemColors.Info;
            this.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picIcon.Location = new System.Drawing.Point(14, 13);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(79, 75);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 7;
            this.picIcon.TabStop = false;
            this.picIcon.Click += new System.EventHandler(this.picIcon_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Location = new System.Drawing.Point(582, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(44, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDocType
            // 
            // 
            // 
            // 
            this.txtDocType.CustomButton.Image = null;
            this.txtDocType.CustomButton.Location = new System.Drawing.Point(556, 1);
            this.txtDocType.CustomButton.Name = "";
            this.txtDocType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDocType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocType.CustomButton.TabIndex = 1;
            this.txtDocType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocType.CustomButton.UseSelectable = true;
            this.txtDocType.CustomButton.Visible = false;
            this.txtDocType.Lines = new string[0];
            this.txtDocType.Location = new System.Drawing.Point(99, 13);
            this.txtDocType.MaxLength = 32767;
            this.txtDocType.Name = "txtDocType";
            this.txtDocType.PasswordChar = '\0';
            this.txtDocType.PromptText = "اسم نوع الوثائق";
            this.txtDocType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocType.SelectedText = "";
            this.txtDocType.SelectionLength = 0;
            this.txtDocType.SelectionStart = 0;
            this.txtDocType.ShortcutsEnabled = true;
            this.txtDocType.Size = new System.Drawing.Size(578, 23);
            this.txtDocType.TabIndex = 6;
            this.txtDocType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDocType.UseSelectable = true;
            this.txtDocType.WaterMark = "اسم نوع الوثائق";
            this.txtDocType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ucDocType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 339);
            this.Controls.Add(this.pnlContent);
            this.Name = "ucDocType";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "انواع الوثائق ";
            this.Load += new System.EventHandler(this.ucDocType_Load);
            this.pnlContent.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlContent;
       
        private MetroFramework.Controls.MetroPanel pnlTop;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroButton btnDelete;
        private System.Windows.Forms.PictureBox picIcon;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtDocType;
        private MetroFramework.Controls.MetroPanel pnlMain;
        private System.Windows.Forms.OpenFileDialog opnFleDlg;
    }
}

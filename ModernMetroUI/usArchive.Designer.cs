namespace ModernMetroUI
{
    partial class usArchive
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
            this.lblDocType = new MetroFramework.Controls.MetroLabel();
            this.cmbDocType = new MetroFramework.Controls.MetroComboBox();
            this.lblDocName = new MetroFramework.Controls.MetroLabel();
            this.txtDocName = new MetroFramework.Controls.MetroTextBox();
            this.lblDocNo = new MetroFramework.Controls.MetroLabel();
            this.txtDocNo = new MetroFramework.Controls.MetroTextBox();
            this.txtTags = new MetroFramework.Controls.MetroTextBox();
            this.lblTags = new MetroFramework.Controls.MetroLabel();
            this.txtDetails = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblDateIssue = new MetroFramework.Controls.MetroLabel();
            this.dtIssueDate = new MetroFramework.Controls.MetroDateTime();
            this.dtDateExpire = new MetroFramework.Controls.MetroDateTime();
            this.lblDateExpire = new MetroFramework.Controls.MetroLabel();
            this.btnInsertDocPic = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btnUndo = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.txtDayNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tchkRenew = new MetroFramework.Controls.MetroToggle();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.picDoc = new System.Windows.Forms.PictureBox();
            this.btnSavePic = new MetroFramework.Controls.MetroButton();
            this.ofdPic = new System.Windows.Forms.OpenFileDialog();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDocType
            // 
            this.lblDocType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocType.AutoSize = true;
            this.lblDocType.Location = new System.Drawing.Point(604, 38);
            this.lblDocType.Name = "lblDocType";
            this.lblDocType.Size = new System.Drawing.Size(74, 19);
            this.lblDocType.TabIndex = 0;
            this.lblDocType.Text = "نوع الارشيف ";
            // 
            // cmbDocType
            // 
            this.cmbDocType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDocType.FormattingEnabled = true;
            this.cmbDocType.ItemHeight = 23;
            this.cmbDocType.Items.AddRange(new object[] {
            "Passport ",
            "ID Card ",
            "License "});
            this.cmbDocType.Location = new System.Drawing.Point(313, 33);
            this.cmbDocType.Name = "cmbDocType";
            this.cmbDocType.Size = new System.Drawing.Size(285, 29);
            this.cmbDocType.TabIndex = 1;
            this.cmbDocType.UseSelectable = true;
            this.cmbDocType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbCancel_KeyDown);
            // 
            // lblDocName
            // 
            this.lblDocName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocName.AutoSize = true;
            this.lblDocName.Location = new System.Drawing.Point(604, 68);
            this.lblDocName.Name = "lblDocName";
            this.lblDocName.Size = new System.Drawing.Size(62, 19);
            this.lblDocName.TabIndex = 0;
            this.lblDocName.Text = "اسم الوثيـقـة";
            // 
            // txtDocName
            // 
            this.txtDocName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDocName.CustomButton.Image = null;
            this.txtDocName.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtDocName.CustomButton.Name = "";
            this.txtDocName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDocName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocName.CustomButton.TabIndex = 1;
            this.txtDocName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocName.CustomButton.UseSelectable = true;
            this.txtDocName.CustomButton.Visible = false;
            this.txtDocName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDocName.Lines = new string[0];
            this.txtDocName.Location = new System.Drawing.Point(312, 68);
            this.txtDocName.MaxLength = 32767;
            this.txtDocName.Name = "txtDocName";
            this.txtDocName.PasswordChar = '\0';
            this.txtDocName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocName.SelectedText = "";
            this.txtDocName.SelectionLength = 0;
            this.txtDocName.SelectionStart = 0;
            this.txtDocName.ShortcutsEnabled = true;
            this.txtDocName.Size = new System.Drawing.Size(285, 23);
            this.txtDocName.TabIndex = 2;
            this.txtDocName.UseSelectable = true;
            this.txtDocName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDocNo
            // 
            this.lblDocNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDocNo.AutoSize = true;
            this.lblDocNo.Location = new System.Drawing.Point(604, 99);
            this.lblDocNo.Name = "lblDocNo";
            this.lblDocNo.Size = new System.Drawing.Size(68, 19);
            this.lblDocNo.TabIndex = 3;
            this.lblDocNo.Text = "رقـم الـوثيـقـة";
            // 
            // txtDocNo
            // 
            this.txtDocNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDocNo.CustomButton.Image = null;
            this.txtDocNo.CustomButton.Location = new System.Drawing.Point(263, 1);
            this.txtDocNo.CustomButton.Name = "";
            this.txtDocNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDocNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocNo.CustomButton.TabIndex = 1;
            this.txtDocNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocNo.CustomButton.UseSelectable = true;
            this.txtDocNo.CustomButton.Visible = false;
            this.txtDocNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDocNo.Lines = new string[0];
            this.txtDocNo.Location = new System.Drawing.Point(313, 99);
            this.txtDocNo.MaxLength = 32767;
            this.txtDocNo.Name = "txtDocNo";
            this.txtDocNo.PasswordChar = '\0';
            this.txtDocNo.PromptText = "0";
            this.txtDocNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocNo.SelectedText = "";
            this.txtDocNo.SelectionLength = 0;
            this.txtDocNo.SelectionStart = 0;
            this.txtDocNo.ShortcutsEnabled = true;
            this.txtDocNo.Size = new System.Drawing.Size(285, 23);
            this.txtDocNo.TabIndex = 4;
            this.txtDocNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDocNo.UseSelectable = true;
            this.txtDocNo.WaterMark = "0";
            this.txtDocNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDocNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberValidation);
            // 
            // txtTags
            // 
            this.txtTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtTags.CustomButton.Image = null;
            this.txtTags.CustomButton.Location = new System.Drawing.Point(268, 1);
            this.txtTags.CustomButton.Name = "";
            this.txtTags.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTags.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTags.CustomButton.TabIndex = 1;
            this.txtTags.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTags.CustomButton.UseSelectable = true;
            this.txtTags.CustomButton.Visible = false;
            this.txtTags.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTags.Lines = new string[0];
            this.txtTags.Location = new System.Drawing.Point(313, 198);
            this.txtTags.MaxLength = 32767;
            this.txtTags.Name = "txtTags";
            this.txtTags.PasswordChar = '\0';
            this.txtTags.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTags.SelectedText = "";
            this.txtTags.SelectionLength = 0;
            this.txtTags.SelectionStart = 0;
            this.txtTags.ShortcutsEnabled = true;
            this.txtTags.Size = new System.Drawing.Size(290, 23);
            this.txtTags.TabIndex = 6;
            this.txtTags.UseSelectable = true;
            this.txtTags.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTags.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTags
            // 
            this.lblTags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(605, 198);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(38, 19);
            this.lblTags.TabIndex = 5;
            this.lblTags.Text = "الوسم ";
            this.lblTags.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // txtDetails
            // 
            this.txtDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDetails.CustomButton.Image = null;
            this.txtDetails.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.txtDetails.CustomButton.Name = "";
            this.txtDetails.CustomButton.Size = new System.Drawing.Size(67, 67);
            this.txtDetails.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDetails.CustomButton.TabIndex = 1;
            this.txtDetails.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDetails.CustomButton.UseSelectable = true;
            this.txtDetails.CustomButton.Visible = false;
            this.txtDetails.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDetails.Lines = new string[0];
            this.txtDetails.Location = new System.Drawing.Point(312, 227);
            this.txtDetails.MaxLength = 32767;
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.PasswordChar = '\0';
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.SelectedText = "";
            this.txtDetails.SelectionLength = 0;
            this.txtDetails.SelectionStart = 0;
            this.txtDetails.ShortcutsEnabled = true;
            this.txtDetails.Size = new System.Drawing.Size(291, 69);
            this.txtDetails.TabIndex = 8;
            this.txtDetails.UseSelectable = true;
            this.txtDetails.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDetails.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(605, 249);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "تـفـاصـيل ";
            // 
            // lblDateIssue
            // 
            this.lblDateIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateIssue.AutoSize = true;
            this.lblDateIssue.Location = new System.Drawing.Point(605, 133);
            this.lblDateIssue.Name = "lblDateIssue";
            this.lblDateIssue.Size = new System.Drawing.Size(84, 19);
            this.lblDateIssue.TabIndex = 9;
            this.lblDateIssue.Text = "تـاريـخ الاصـدار";
            // 
            // dtIssueDate
            // 
            this.dtIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIssueDate.Location = new System.Drawing.Point(313, 128);
            this.dtIssueDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtIssueDate.Name = "dtIssueDate";
            this.dtIssueDate.Size = new System.Drawing.Size(290, 29);
            this.dtIssueDate.TabIndex = 10;
            // 
            // dtDateExpire
            // 
            this.dtDateExpire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDateExpire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateExpire.Location = new System.Drawing.Point(313, 163);
            this.dtDateExpire.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtDateExpire.Name = "dtDateExpire";
            this.dtDateExpire.Size = new System.Drawing.Size(290, 29);
            this.dtDateExpire.TabIndex = 12;
            // 
            // lblDateExpire
            // 
            this.lblDateExpire.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateExpire.AutoSize = true;
            this.lblDateExpire.Location = new System.Drawing.Point(605, 163);
            this.lblDateExpire.Name = "lblDateExpire";
            this.lblDateExpire.Size = new System.Drawing.Size(80, 19);
            this.lblDateExpire.TabIndex = 11;
            this.lblDateExpire.Text = "تـاريـخ الانتـهـاء";
            // 
            // btnInsertDocPic
            // 
            this.btnInsertDocPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertDocPic.Location = new System.Drawing.Point(146, 361);
            this.btnInsertDocPic.Name = "btnInsertDocPic";
            this.btnInsertDocPic.Size = new System.Drawing.Size(143, 26);
            this.btnInsertDocPic.TabIndex = 2;
            this.btnInsertDocPic.Text = "ادخـال صـورة الـوثيـقـة";
            this.btnInsertDocPic.UseSelectable = true;
            this.btnInsertDocPic.Click += new System.EventHandler(this.btnInsertDocPic_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.metroPanel2.Controls.Add(this.btnUndo);
            this.metroPanel2.Controls.Add(this.btnDelete);
            this.metroPanel2.Controls.Add(this.btnUpdate);
            this.metroPanel2.Controls.Add(this.btnEdit);
            this.metroPanel2.Controls.Add(this.btnSave);
            this.metroPanel2.Controls.Add(this.btnNew);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 394);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(805, 67);
            this.metroPanel2.TabIndex = 14;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseStyleColors = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btnUndo
            // 
            this.btnUndo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUndo.Location = new System.Drawing.Point(195, 24);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(96, 32);
            this.btnUndo.TabIndex = 7;
            this.btnUndo.Text = "تراجـع";
            this.btnUndo.UseSelectable = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(93, 24);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 32);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "حـذف الـوثـيـقـة";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(297, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 32);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "تـحديـث الـوثـيـقـة";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(399, 24);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 32);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "تـعـديـل الـوثـيقـة";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(501, 24);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "حـفـظ الـوثـيـقـة";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(605, 24);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(96, 32);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "وثـيـقـة جـديـدة";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDayNo
            // 
            this.txtDayNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtDayNo.CustomButton.Image = null;
            this.txtDayNo.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.txtDayNo.CustomButton.Name = "";
            this.txtDayNo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDayNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDayNo.CustomButton.TabIndex = 1;
            this.txtDayNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDayNo.CustomButton.UseSelectable = true;
            this.txtDayNo.CustomButton.Visible = false;
            this.txtDayNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDayNo.Lines = new string[0];
            this.txtDayNo.Location = new System.Drawing.Point(439, 302);
            this.txtDayNo.MaxLength = 32767;
            this.txtDayNo.Name = "txtDayNo";
            this.txtDayNo.PasswordChar = '\0';
            this.txtDayNo.PromptText = "0";
            this.txtDayNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDayNo.SelectedText = "";
            this.txtDayNo.SelectionLength = 0;
            this.txtDayNo.SelectionStart = 0;
            this.txtDayNo.ShortcutsEnabled = true;
            this.txtDayNo.Size = new System.Drawing.Size(80, 23);
            this.txtDayNo.TabIndex = 16;
            this.txtDayNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDayNo.UseSelectable = true;
            this.txtDayNo.WaterMark = "0";
            this.txtDayNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDayNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDayNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberValidation);
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(521, 306);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(151, 19);
            this.metroLabel8.TabIndex = 15;
            this.metroLabel8.Text = "ذكـرني قـبـل انـتـهـاء الـوثيـقـة بـ";
            // 
            // tchkRenew
            // 
            this.tchkRenew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tchkRenew.AutoSize = true;
            this.tchkRenew.Location = new System.Drawing.Point(439, 331);
            this.tchkRenew.Name = "tchkRenew";
            this.tchkRenew.Size = new System.Drawing.Size(80, 17);
            this.tchkRenew.TabIndex = 17;
            this.tchkRenew.Text = "Off";
            this.tchkRenew.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(521, 331);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(55, 19);
            this.metroLabel9.TabIndex = 18;
            this.metroLabel9.Text = "تم التجديد ";
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(407, 306);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(26, 19);
            this.metroLabel10.TabIndex = 19;
            this.metroLabel10.Text = "يـوم";
            // 
            // picDoc
            // 
            this.picDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDoc.Location = new System.Drawing.Point(13, 30);
            this.picDoc.Name = "picDoc";
            this.picDoc.Size = new System.Drawing.Size(276, 325);
            this.picDoc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDoc.TabIndex = 20;
            this.picDoc.TabStop = false;
            this.picDoc.Click += new System.EventHandler(this.picDoc_Click);
            // 
            // btnSavePic
            // 
            this.btnSavePic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePic.Location = new System.Drawing.Point(13, 361);
            this.btnSavePic.Name = "btnSavePic";
            this.btnSavePic.Size = new System.Drawing.Size(127, 26);
            this.btnSavePic.TabIndex = 21;
            this.btnSavePic.Text = "حـفـظ صـورة الـوثـيـقـة ";
            this.btnSavePic.UseSelectable = true;
            this.btnSavePic.Click += new System.EventHandler(this.btnSavePic_Click);
            // 
            // ofdPic
            // 
            this.ofdPic.FileName = "openFileDialog1";
            // 
            // usArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSavePic);
            this.Controls.Add(this.picDoc);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.tchkRenew);
            this.Controls.Add(this.btnInsertDocPic);
            this.Controls.Add(this.txtDayNo);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.dtDateExpire);
            this.Controls.Add(this.lblDateExpire);
            this.Controls.Add(this.dtIssueDate);
            this.Controls.Add(this.lblDateIssue);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtTags);
            this.Controls.Add(this.lblTags);
            this.Controls.Add(this.txtDocNo);
            this.Controls.Add(this.lblDocNo);
            this.Controls.Add(this.txtDocName);
            this.Controls.Add(this.cmbDocType);
            this.Controls.Add(this.lblDocName);
            this.Controls.Add(this.lblDocType);
            this.Name = "usArchive";
            this.Size = new System.Drawing.Size(805, 461);
            this.Load += new System.EventHandler(this.usArchive_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.usArchive_Paint);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picDoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblDocType;
        private MetroFramework.Controls.MetroComboBox cmbDocType;
        private MetroFramework.Controls.MetroLabel lblDocName;
        private MetroFramework.Controls.MetroTextBox txtDocName;
        private MetroFramework.Controls.MetroLabel lblDocNo;
        private MetroFramework.Controls.MetroTextBox txtDocNo;
        private MetroFramework.Controls.MetroTextBox txtTags;
        private MetroFramework.Controls.MetroLabel lblTags;
        private MetroFramework.Controls.MetroTextBox txtDetails;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblDateIssue;
        private MetroFramework.Controls.MetroDateTime dtIssueDate;
        private MetroFramework.Controls.MetroDateTime dtDateExpire;
        private MetroFramework.Controls.MetroLabel lblDateExpire;
        private MetroFramework.Controls.MetroButton btnInsertDocPic;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroTextBox txtDayNo;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroToggle tchkRenew;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.PictureBox picDoc;
        private MetroFramework.Controls.MetroButton btnUndo;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroButton btnSavePic;
        private System.Windows.Forms.OpenFileDialog ofdPic;
    }
}

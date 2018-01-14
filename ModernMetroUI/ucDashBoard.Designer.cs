namespace ModernMetroUI
{
    partial class ucDashBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDashBoard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlright = new MetroFramework.Controls.MetroPanel();
            this.pnltopSearch = new MetroFramework.Controls.MetroPanel();
            this.txtSearchDoc = new MetroFramework.Controls.MetroTextBox();
            this.dbc0200101DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbc0200101DataSet = new ModernMetroUI.dbc0200101DataSet();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnDocTypeEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnDocEdit = new MetroFramework.Controls.MetroButton();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.dgvDoc = new MetroFramework.Controls.MetroGrid();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmExpireDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRenew = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnltopSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbc0200101DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbc0200101DataSet)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlright
            // 
            this.pnlright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlright.HorizontalScrollbarBarColor = true;
            this.pnlright.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlright.HorizontalScrollbarSize = 10;
            this.pnlright.Location = new System.Drawing.Point(605, 0);
            this.pnlright.Name = "pnlright";
            this.pnlright.Size = new System.Drawing.Size(200, 482);
            this.pnlright.TabIndex = 2;
            this.pnlright.VerticalScrollbarBarColor = true;
            this.pnlright.VerticalScrollbarHighlightOnWheel = false;
            this.pnlright.VerticalScrollbarSize = 10;
            // 
            // pnltopSearch
            // 
            this.pnltopSearch.Controls.Add(this.txtSearchDoc);
            this.pnltopSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltopSearch.HorizontalScrollbarBarColor = true;
            this.pnltopSearch.HorizontalScrollbarHighlightOnWheel = false;
            this.pnltopSearch.HorizontalScrollbarSize = 10;
            this.pnltopSearch.Location = new System.Drawing.Point(0, 0);
            this.pnltopSearch.Name = "pnltopSearch";
            this.pnltopSearch.Size = new System.Drawing.Size(605, 26);
            this.pnltopSearch.TabIndex = 3;
            this.pnltopSearch.VerticalScrollbarBarColor = true;
            this.pnltopSearch.VerticalScrollbarHighlightOnWheel = false;
            this.pnltopSearch.VerticalScrollbarSize = 10;
            // 
            // txtSearchDoc
            // 
            // 
            // 
            // 
            this.txtSearchDoc.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearchDoc.CustomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resource.BackgroundImage")));
            this.txtSearchDoc.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSearchDoc.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtSearchDoc.CustomButton.Location = new System.Drawing.Point(581, 2);
            this.txtSearchDoc.CustomButton.Name = "";
            this.txtSearchDoc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchDoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchDoc.CustomButton.TabIndex = 1;
            this.txtSearchDoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchDoc.CustomButton.UseSelectable = true;
            this.txtSearchDoc.CustomButton.UseVisualStyleBackColor = false;
            this.txtSearchDoc.DisplayIcon = true;
            this.txtSearchDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchDoc.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearchDoc.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearchDoc.Icon")));
            this.txtSearchDoc.Lines = new string[0];
            this.txtSearchDoc.Location = new System.Drawing.Point(0, 0);
            this.txtSearchDoc.MaxLength = 32767;
            this.txtSearchDoc.Name = "txtSearchDoc";
            this.txtSearchDoc.PasswordChar = '\0';
            this.txtSearchDoc.PromptText = "ابحث بالاسم , الرقم , بالتاق , بالتاريخ";
            this.txtSearchDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearchDoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchDoc.SelectedText = "";
            this.txtSearchDoc.SelectionLength = 0;
            this.txtSearchDoc.SelectionStart = 0;
            this.txtSearchDoc.ShortcutsEnabled = true;
            this.txtSearchDoc.ShowButton = true;
            this.txtSearchDoc.Size = new System.Drawing.Size(605, 26);
            this.txtSearchDoc.TabIndex = 2;
            this.txtSearchDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchDoc.UseSelectable = true;
            this.txtSearchDoc.WaterMark = "ابحث بالاسم , الرقم , بالتاق , بالتاريخ";
            this.txtSearchDoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchDoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearchDoc.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtSearchDoc_ButtonClick);
            this.txtSearchDoc.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // dbc0200101DataSetBindingSource
            // 
            this.dbc0200101DataSetBindingSource.DataSource = this.dbc0200101DataSet;
            this.dbc0200101DataSetBindingSource.Position = 0;
            // 
            // dbc0200101DataSet
            // 
            this.dbc0200101DataSet.DataSetName = "dbc0200101DataSet";
            this.dbc0200101DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.metroPanel1.Controls.Add(this.btnDocTypeEdit);
            this.metroPanel1.Controls.Add(this.btnDelete);
            this.metroPanel1.Controls.Add(this.btnDocEdit);
            this.metroPanel1.Controls.Add(this.btnAdd);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 415);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(605, 67);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnDocTypeEdit
            // 
            this.btnDocTypeEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDocTypeEdit.BackgroundImage")));
            this.btnDocTypeEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDocTypeEdit.Location = new System.Drawing.Point(393, 14);
            this.btnDocTypeEdit.Name = "btnDocTypeEdit";
            this.btnDocTypeEdit.Size = new System.Drawing.Size(58, 41);
            this.btnDocTypeEdit.TabIndex = 7;
            this.btnDocTypeEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDocTypeEdit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDocTypeEdit.UseSelectable = true;
            this.btnDocTypeEdit.Click += new System.EventHandler(this.btnDocTypeEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(312, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 41);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDocEdit
            // 
            this.btnDocEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDocEdit.BackgroundImage")));
            this.btnDocEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDocEdit.Enabled = false;
            this.btnDocEdit.Location = new System.Drawing.Point(231, 14);
            this.btnDocEdit.Name = "btnDocEdit";
            this.btnDocEdit.Size = new System.Drawing.Size(57, 41);
            this.btnDocEdit.TabIndex = 5;
            this.btnDocEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDocEdit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnDocEdit.UseSelectable = true;
            this.btnDocEdit.Click += new System.EventHandler(this.btnDocEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(150, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "clipboard ‫‬.png");
            this.imageList1.Images.SetKeyName(1, "file(1).png");
            this.imageList1.Images.SetKeyName(2, "file(2).png");
            this.imageList1.Images.SetKeyName(3, "file(3).png");
            this.imageList1.Images.SetKeyName(4, "file.png");
            this.imageList1.Images.SetKeyName(5, "mail.png");
            this.imageList1.Images.SetKeyName(6, "notepad(1).png");
            this.imageList1.Images.SetKeyName(7, "notepad(2).png");
            this.imageList1.Images.SetKeyName(8, "notepad.png");
            this.imageList1.Images.SetKeyName(9, "notes(1).png");
            this.imageList1.Images.SetKeyName(10, "notes.png");
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTile1.Location = new System.Drawing.Point(0, 26);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(605, 15);
            this.metroTile1.TabIndex = 7;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // dgvDoc
            // 
            this.dgvDoc.AllowUserToAddRows = false;
            this.dgvDoc.AllowUserToDeleteRows = false;
            this.dgvDoc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmName,
            this.clmNo,
            this.clmIssueDate,
            this.clmExpireDate,
            this.clmRenew});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDoc.EnableHeadersVisualStyles = false;
            this.dgvDoc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDoc.Location = new System.Drawing.Point(0, 41);
            this.dgvDoc.MultiSelect = false;
            this.dgvDoc.Name = "dgvDoc";
            this.dgvDoc.ReadOnly = true;
            this.dgvDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDoc.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoc.Size = new System.Drawing.Size(605, 374);
            this.dgvDoc.TabIndex = 8;
            this.dgvDoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoc_CellContentClick);
            this.dgvDoc.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoc_CellEnter);
            this.dgvDoc.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDoc_RowPostPaint);
            // 
            // clmName
            // 
            this.clmName.HeaderText = "اسم الوثيـقـة ";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmNo
            // 
            this.clmNo.HeaderText = "رقـم الـوثيـقـة ";
            this.clmNo.Name = "clmNo";
            this.clmNo.ReadOnly = true;
            // 
            // clmIssueDate
            // 
            this.clmIssueDate.HeaderText = "تـاريـخ الاصـدار ";
            this.clmIssueDate.Name = "clmIssueDate";
            this.clmIssueDate.ReadOnly = true;
            // 
            // clmExpireDate
            // 
            this.clmExpireDate.HeaderText = "تـاريـخ الانـتـهـاء";
            this.clmExpireDate.Name = "clmExpireDate";
            this.clmExpireDate.ReadOnly = true;
            // 
            // clmRenew
            // 
            this.clmRenew.HeaderText = "تم الـتـجـديـد";
            this.clmRenew.Name = "clmRenew";
            this.clmRenew.ReadOnly = true;
            this.clmRenew.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmRenew.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ucDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDoc);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pnltopSearch);
            this.Controls.Add(this.pnlright);
            this.Name = "ucDashBoard";
            this.Size = new System.Drawing.Size(805, 482);
            this.Load += new System.EventHandler(this.ucDashBoard_Load);
            this.pnltopSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbc0200101DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbc0200101DataSet)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlright;
        private MetroFramework.Controls.MetroPanel pnltopSearch;
        private MetroFramework.Controls.MetroTextBox txtSearchDoc;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnDocEdit;
        private MetroFramework.Controls.MetroButton btnAdd;
        private System.Windows.Forms.BindingSource dbc0200101DataSetBindingSource;
        private dbc0200101DataSet dbc0200101DataSet;
        private System.Windows.Forms.ImageList imageList1;
        private MetroFramework.Controls.MetroButton btnDocTypeEdit;
        private uctypeList uctypeList1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroGrid dgvDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmExpireDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmRenew;
    }
}

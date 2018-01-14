namespace ModernMetroUI
{
    partial class usProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientNameEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientFileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRegPatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressPatientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientAgeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.departIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hosPatientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbc0200101DataSet = new ModernMetroUI.dbc0200101DataSet();
            this.hosPatientsTableAdapter = new ModernMetroUI.dbc0200101DataSetTableAdapters.HosPatientsTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hosPatientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbc0200101DataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIdDataGridViewTextBoxColumn,
            this.patientNameADataGridViewTextBoxColumn,
            this.patientNameEDataGridViewTextBoxColumn,
            this.patientCodeDataGridViewTextBoxColumn,
            this.patientFileNoDataGridViewTextBoxColumn,
            this.dateRegPatientDataGridViewTextBoxColumn,
            this.bloodTypeIdDataGridViewTextBoxColumn,
            this.genderTypeIdDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressPatientDataGridViewTextBoxColumn,
            this.patientAgeDataGridViewTextBoxColumn,
            this.pictDataGridViewImageColumn,
            this.departIdDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.hosPatientsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(0, 0);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(724, 528);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            this.patientIdDataGridViewTextBoxColumn.DataPropertyName = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.HeaderText = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            this.patientIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientNameADataGridViewTextBoxColumn
            // 
            this.patientNameADataGridViewTextBoxColumn.DataPropertyName = "PatientNameA";
            this.patientNameADataGridViewTextBoxColumn.HeaderText = "PatientNameA";
            this.patientNameADataGridViewTextBoxColumn.Name = "patientNameADataGridViewTextBoxColumn";
            // 
            // patientNameEDataGridViewTextBoxColumn
            // 
            this.patientNameEDataGridViewTextBoxColumn.DataPropertyName = "PatientNameE";
            this.patientNameEDataGridViewTextBoxColumn.HeaderText = "PatientNameE";
            this.patientNameEDataGridViewTextBoxColumn.Name = "patientNameEDataGridViewTextBoxColumn";
            // 
            // patientCodeDataGridViewTextBoxColumn
            // 
            this.patientCodeDataGridViewTextBoxColumn.DataPropertyName = "PatientCode";
            this.patientCodeDataGridViewTextBoxColumn.HeaderText = "PatientCode";
            this.patientCodeDataGridViewTextBoxColumn.Name = "patientCodeDataGridViewTextBoxColumn";
            // 
            // patientFileNoDataGridViewTextBoxColumn
            // 
            this.patientFileNoDataGridViewTextBoxColumn.DataPropertyName = "PatientFileNo";
            this.patientFileNoDataGridViewTextBoxColumn.HeaderText = "PatientFileNo";
            this.patientFileNoDataGridViewTextBoxColumn.Name = "patientFileNoDataGridViewTextBoxColumn";
            // 
            // dateRegPatientDataGridViewTextBoxColumn
            // 
            this.dateRegPatientDataGridViewTextBoxColumn.DataPropertyName = "DateRegPatient";
            this.dateRegPatientDataGridViewTextBoxColumn.HeaderText = "DateRegPatient";
            this.dateRegPatientDataGridViewTextBoxColumn.Name = "dateRegPatientDataGridViewTextBoxColumn";
            // 
            // bloodTypeIdDataGridViewTextBoxColumn
            // 
            this.bloodTypeIdDataGridViewTextBoxColumn.DataPropertyName = "BloodTypeId";
            this.bloodTypeIdDataGridViewTextBoxColumn.HeaderText = "BloodTypeId";
            this.bloodTypeIdDataGridViewTextBoxColumn.Name = "bloodTypeIdDataGridViewTextBoxColumn";
            // 
            // genderTypeIdDataGridViewTextBoxColumn
            // 
            this.genderTypeIdDataGridViewTextBoxColumn.DataPropertyName = "GenderTypeId";
            this.genderTypeIdDataGridViewTextBoxColumn.HeaderText = "GenderTypeId";
            this.genderTypeIdDataGridViewTextBoxColumn.Name = "genderTypeIdDataGridViewTextBoxColumn";
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressPatientDataGridViewTextBoxColumn
            // 
            this.addressPatientDataGridViewTextBoxColumn.DataPropertyName = "AddressPatient";
            this.addressPatientDataGridViewTextBoxColumn.HeaderText = "AddressPatient";
            this.addressPatientDataGridViewTextBoxColumn.Name = "addressPatientDataGridViewTextBoxColumn";
            // 
            // patientAgeDataGridViewTextBoxColumn
            // 
            this.patientAgeDataGridViewTextBoxColumn.DataPropertyName = "PatientAge";
            this.patientAgeDataGridViewTextBoxColumn.HeaderText = "PatientAge";
            this.patientAgeDataGridViewTextBoxColumn.Name = "patientAgeDataGridViewTextBoxColumn";
            // 
            // pictDataGridViewImageColumn
            // 
            this.pictDataGridViewImageColumn.DataPropertyName = "Pict";
            this.pictDataGridViewImageColumn.HeaderText = "Pict";
            this.pictDataGridViewImageColumn.Name = "pictDataGridViewImageColumn";
            // 
            // departIdDataGridViewTextBoxColumn
            // 
            this.departIdDataGridViewTextBoxColumn.DataPropertyName = "DepartId";
            this.departIdDataGridViewTextBoxColumn.HeaderText = "DepartId";
            this.departIdDataGridViewTextBoxColumn.Name = "departIdDataGridViewTextBoxColumn";
            // 
            // hosPatientsBindingSource
            // 
            this.hosPatientsBindingSource.DataMember = "HosPatients";
            this.hosPatientsBindingSource.DataSource = this.dbc0200101DataSet;
            // 
            // dbc0200101DataSet
            // 
            this.dbc0200101DataSet.DataSetName = "dbc0200101DataSet";
            this.dbc0200101DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hosPatientsTableAdapter
            // 
            this.hosPatientsTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(724, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // usProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.metroGrid1);
            this.Name = "usProducts";
            this.Size = new System.Drawing.Size(724, 528);
            this.Load += new System.EventHandler(this.usProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hosPatientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbc0200101DataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientNameEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientFileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRegPatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressPatientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientAgeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hosPatientsBindingSource;
        private dbc0200101DataSet dbc0200101DataSet;
        private dbc0200101DataSetTableAdapters.HosPatientsTableAdapter hosPatientsTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}

namespace ModernMetroUI
{
    partial class frmDocViewer
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
            this.picViewer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // picViewer
            // 
            this.picViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picViewer.Location = new System.Drawing.Point(20, 60);
            this.picViewer.Name = "picViewer";
            this.picViewer.Size = new System.Drawing.Size(649, 378);
            this.picViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picViewer.TabIndex = 0;
            this.picViewer.TabStop = false;
            // 
            // frmDocViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 458);
            this.Controls.Add(this.picViewer);
            this.Name = "frmDocViewer";
            this.Text = "Document Viewer";
            this.Load += new System.EventHandler(this.frmDocViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picViewer;
    }
}
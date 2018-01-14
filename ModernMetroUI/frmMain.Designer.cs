namespace ModernMetroUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMetro = new MetroFramework.Controls.MetroPanel();
            this.lnkback = new MetroFramework.Controls.MetroLink();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lnkUser = new MetroFramework.Controls.MetroLink();
            this.lnkLogout = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // pnlMetro
            // 
            this.pnlMetro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMetro.HorizontalScrollbarBarColor = true;
            this.pnlMetro.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMetro.HorizontalScrollbarSize = 10;
            this.pnlMetro.Location = new System.Drawing.Point(23, 63);
            this.pnlMetro.Name = "pnlMetro";
            this.pnlMetro.Size = new System.Drawing.Size(788, 349);
            this.pnlMetro.TabIndex = 0;
            this.pnlMetro.VerticalScrollbarBarColor = true;
            this.pnlMetro.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMetro.VerticalScrollbarSize = 10;
            // 
            // lnkback
            // 
            this.lnkback.Image = global::ModernMetroUI.Properties.Resources._1496345606_back_left_arrow_botton;
            this.lnkback.ImageSize = 32;
            this.lnkback.Location = new System.Drawing.Point(23, 14);
            this.lnkback.Name = "lnkback";
            this.lnkback.Size = new System.Drawing.Size(38, 43);
            this.lnkback.TabIndex = 1;
            this.lnkback.UseSelectable = true;
            this.lnkback.Click += new System.EventHandler(this.lnkback_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(522, 26);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 19);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(394, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(75, 19);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "00/00/0000";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(349, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Date:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(475, 26);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Time:";
            // 
            // lnkUser
            // 
            this.lnkUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkUser.AutoSize = true;
            this.lnkUser.Location = new System.Drawing.Point(652, 14);
            this.lnkUser.Name = "lnkUser";
            this.lnkUser.Size = new System.Drawing.Size(75, 43);
            this.lnkUser.TabIndex = 7;
            this.lnkUser.Text = "Welcome \r\nadmin ";
            this.lnkUser.UseSelectable = true;
            this.lnkUser.Visible = false;
            this.lnkUser.Click += new System.EventHandler(this.lnkUser_Click);
            // 
            // lnkLogout
            // 
            this.lnkLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lnkLogout.BackgroundImage")));
            this.lnkLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lnkLogout.Location = new System.Drawing.Point(733, 14);
            this.lnkLogout.Name = "lnkLogout";
            this.lnkLogout.Size = new System.Drawing.Size(75, 43);
            this.lnkLogout.TabIndex = 8;
            this.lnkLogout.UseSelectable = true;
            this.lnkLogout.Click += new System.EventHandler(this.lnkLogout_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 462);
            this.Controls.Add(this.lnkLogout);
            this.Controls.Add(this.lnkUser);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lnkback);
            this.Controls.Add(this.pnlMetro);
            this.Name = "frmMain";
            this.Text = "          SMART TIME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel pnlMetro;
        private MetroFramework.Controls.MetroLink lnkback;
        private MetroFramework.Controls.MetroLabel lblTime;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLink lnkUser;
        private MetroFramework.Controls.MetroLink lnkLogout;
    }
}


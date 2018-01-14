using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernMetroUI
{
    public partial class frmDocViewer : MetroFramework.Forms.MetroForm
    {
        public string DocTitle { get; set; }
        public PictureBox DocPicBox { get; set; }
        public frmDocViewer()
        {
            InitializeComponent();
        }

        private void frmDocViewer_Load(object sender, EventArgs e)
        {

        }

        public void LoadPic()
        {
            this.Text = DocTitle;
            this.picViewer.Image = DocPicBox.Image;
        }

    }
}

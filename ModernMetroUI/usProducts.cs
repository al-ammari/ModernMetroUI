using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernMetroUI
{
    public partial class usProducts : MetroFramework.Controls.MetroUserControl
    {
        public usProducts()
        {
            InitializeComponent();
        }

        private void usProducts_Load(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.hosPatientsTableAdapter.FillBy(this.dbc0200101DataSet.HosPatients);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

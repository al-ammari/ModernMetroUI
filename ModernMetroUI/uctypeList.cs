using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XLDbLayer;
namespace ModernMetroUI
{
    public partial class uctypeList : MetroFramework.Controls.MetroUserControl
    {
        SessionInfo Cv_Session;

        public int DocTypeId { set; get; }
        public string DocTypeName { set; get; }

        public string DocTypeUrl { set; get; }

        public MetroFramework.Controls.MetroTile docTypeTitle;

        
        public uctypeList(SessionInfo Fp_Session)
        {
            Cv_Session = Fp_Session;
            InitializeComponent();
            LoadList();
        }

        private void uctypeList_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            LoadDocType(false);
        }

        public void LoadDocType(bool IsSearch)
        {
            pnlContent.Controls.Clear();
            string cmd = "SELECT Id,Name,IconUrl FROM DocumentsType";
            if (IsSearch)
            {
                if (!String.IsNullOrEmpty(txtSearch.Text))
                {
                    cmd += " WHERE Name LIKE '%" + txtSearch.Text + "%'";
                    
                }
            }
                DataTable dt = new DataTable();
                if (!Cv_Session.FillDataTable(dt, cmd))
                    return;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    docTypeTitle = new MetroFramework.Controls.MetroTile();
                    docTypeTitle.Dock = System.Windows.Forms.DockStyle.Top;

                    docTypeTitle.Size = new System.Drawing.Size(279, 77);
                    docTypeTitle.Text = dt.Rows[i]["Name"].ToString();
                    cmd = "SELECT COUNT(Id) FROM Documents WHERE DocTypeId=" + dt.Rows[i]["Id"].ToString();
                    docTypeTitle.TileCount = int.Parse(Cv_Session.GetFieldText(cmd));
                    docTypeTitle.TileImage = Image.FromFile(dt.Rows[i]["IconUrl"].ToString());
                    docTypeTitle.TileImage.Tag = dt.Rows[i]["IconUrl"].ToString();
                    docTypeTitle.UseCustomBackColor = true;
                    docTypeTitle.UseCustomForeColor = true;
                    docTypeTitle.Tag = dt.Rows[i]["Id"];
                    docTypeTitle.UseSelectable = true;
                    docTypeTitle.UseTileImage = true;
                    docTypeTitle.Click += new System.EventHandler(this.docTypeSelect_Click);

                    docTypeTitle.Name = "docTypeTitle" + i;

                    this.pnlContent.Controls.Add(docTypeTitle);

               }
            
        }

        public void docTypeSelect_Click(object sender, EventArgs e)
        {
            DocTypeId = 0;
            DocTypeName = "";
            DocTypeUrl = "";
            MetroFramework.Controls.MetroTile title = (MetroFramework.Controls.MetroTile)sender;
            if (title.Tag != null)
            {
                DocTypeId = int.Parse(title.Tag.ToString());
                DocTypeName = title.Text;
                DocTypeUrl = title.TileImage.Tag.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDocType(true);
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

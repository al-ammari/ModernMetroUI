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
    public partial class ucDashBoard : MetroFramework.Controls.MetroUserControl
    {
        SessionInfo Cv_Session;
        public uctypeList list { get; set; }
        int count = 0;
        public int DocTypeId = 0;
        public int DocId { get; set; }

        public ucDashBoard(SessionInfo Fp_Session)
        {
            Cv_Session = Fp_Session;
            InitializeComponent();
            list = new uctypeList(Cv_Session);
            pnlright.Controls.Add(list);

            pnlright.Controls[2].Dock = DockStyle.Fill;
            pnlright.Controls[2].BringToFront();
            SetEventList();
            LoadDocList(false);
        }

        #region DocumentsType List Control 
        public void SetEventList()
        {
            list.txtSearch.TextChanged += new EventHandler(txtSearch_TextChanged);
            SetEventsList();

        }

        private void SetEventsList()
        {
            for (int x = 0; x < (list.Controls[0].Controls.Count); x++)
            {
                list.Controls[0].Controls[x].Click += new System.EventHandler(docTypeSelect_Click);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SetEventsList();
        }


        private void docTypeSelect_Click(object sender, EventArgs e)
        {
            
            DocTypeId = list.DocTypeId;
            LoadDocList(false);

        }

        #endregion
        private void ucLogin_Load(object sender, EventArgs e)
        {
           // frmMain.Instance.ln
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if(frmMain.Instance.MetroController.Controls["usProducts"] == null)
            {
                usProducts products = new usProducts();
                products.Dock = DockStyle.Fill;
                frmMain.Instance.MetroController.Controls.Add(products);

            }
            frmMain.Instance.MetroController.Controls["usProducts"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (frmMain.Instance.MetroController.Controls["usArchive"] == null)
            {
                usArchive archive = new usArchive(Cv_Session);
                archive.Dock = DockStyle.Fill;
               
                frmMain.Instance.MetroController.Controls.Add(archive);

            }
            frmMain.Instance.MetroController.Controls["usArchive"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;

        }





        private void btnDocTypeEdit_Click(object sender, EventArgs e)
        {
            ucDocType docType = new ucDocType(Cv_Session);
            docType.ShowDialog();
 /*
            if (frmMain.Instance.MetroController.Controls["ucDocType"] == null)
            {
                ucDocType docType = new ucDocType();
                docType.Dock = DockStyle.Fill;
                frmMain.Instance.MetroController.Controls.Add(docType);

            }
            frmMain.Instance.MetroController.Controls["ucDocType"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;*/
        }

        private void uctypeList1_Load(object sender, EventArgs e)
        {

        }

        private void ucDashBoard_Load(object sender, EventArgs e)
        {
            frmMain.Instance.WindowState = FormWindowState.Maximized;
            SetEventList();

               
           
           
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }


        #region Load List 

        public void LoadDocList(bool IsSearch)
        {
            dgvDoc.Rows.Clear();
            string cmd = "SELECT Id,DocName,DocNo,IssueDate,ExpireDate,DocRenewComplate FROM Documents WHERE 1=1 ";
            if(DocTypeId != 0)
            {
                cmd += " AND DocTypeId =" + DocTypeId.ToString();
            }
            if(IsSearch)
            {
                cmd += SetCondtionsSQL(); 
            }
            DataTable dt = new DataTable();
            if(Cv_Session.FillDataTable(dt,cmd))
            {
                for (int x = 0; x < dt.Rows.Count; x++)
                {
                    dgvDoc.Rows.Add();
                    dgvDoc.Rows[x].Tag = dt.Rows[x]["Id"].ToString();
                    dgvDoc.Rows[x].Cells["clmName"].Value = dt.Rows[x]["DocName"].ToString();
                    dgvDoc.Rows[x].Cells["clmNo"].Value = dt.Rows[x]["DocNo"].ToString();
                    dgvDoc.Rows[x].Cells["clmIssueDate"].Value = dt.Rows[x]["IssueDate"].ToString();
                    dgvDoc.Rows[x].Cells["clmExpireDate"].Value = dt.Rows[x]["ExpireDate"].ToString();
                    dgvDoc.Rows[x].Cells["clmRenew"].Value = dt.Rows[x]["DocRenewComplate"].ToString();


                }
            }
        }


        #endregion 

        private void txtSearchDoc_ButtonClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearchDoc.Text))
                return;
            LoadDocList(true);

        }

        private string SetCondtionsSQL()
        {
            int fv_docNo = 0;
            DateTime dt;

            string cmd = " AND ( DocName LIKE '%" + txtSearchDoc.Text.Trim() + "%'";
            if(int.TryParse(txtSearchDoc.Text,out fv_docNo))
                cmd += " OR DocNo IN (" + fv_docNo + ")";

            if (DateTime.TryParse(txtSearchDoc.Text, out dt))
            {
                cmd += " OR IssueDate='" + txtSearchDoc.Text.Trim() + "%' ";
                cmd += " OR ExpireDate='" + txtSearchDoc.Text.Trim() + "%'";
            }
            cmd += " OR Tags LIKE '%" + txtSearchDoc.Text.Trim() + "%')";

            return cmd;

        }

        private void dgvDoc_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            Cv_Session.DataGridRowPostPaint(sender, e);
        }

        private void dgvDoc_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDoc.Rows[e.RowIndex].Tag == null)
            {
                btnDelete.Enabled = false;
                btnDocEdit.Enabled = false;
                return;
            }
            DocId = int.Parse(dgvDoc.Rows[e.RowIndex].Tag.ToString());
            btnDocEdit.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDocSelect();

        }

        private void DeleteDocSelect()
        {
            DialogResult rs = MessageBox.Show("هل انت متأكد من عملية الحذف ", "تنبيه حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.No)
                return;

            string cmd = " DELETE FROM Documents WHERE Id=" + DocId;
            if (Cv_Session.ExecuteCommand(cmd))
            {
                DocId = 0;

                LoadDocList(false);

            }
            else
                MessageBox.Show("خطأ!" + Cv_Session.DbErrorMessage);
        }

        private void btnDocEdit_Click(object sender, EventArgs e)
        {
            usArchive archive;
            if(frmMain.Instance.MetroController.Controls["usArchive"] == null)
            {
                archive = new usArchive(Cv_Session);
                archive.Dock = DockStyle.Fill;
                frmMain.Instance.MetroController.Controls.Add(archive);

            }
            frmMain.Instance.MetroController.Controls["usArchive"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
            archive = (usArchive)frmMain.Instance.MetroController.Controls["usArchive"];
            archive.Pv_DocId = DocId;
            archive.GetRecord();

    
        }

        private void dgvDoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            usArchive archive;
            if (frmMain.Instance.MetroController.Controls["usArchive"] == null)
            {
                archive = new usArchive(Cv_Session);
                archive.Dock = DockStyle.Fill;
                frmMain.Instance.MetroController.Controls.Add(archive);

            }
            frmMain.Instance.MetroController.Controls["usArchive"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
            archive = (usArchive)frmMain.Instance.MetroController.Controls["usArchive"];
            archive.Pv_DocId = DocId;
            archive.GetRecord();
        }
    }
}

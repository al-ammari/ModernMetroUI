using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XLDbLayer;

namespace ModernMetroUI
{
    public partial class frmRemmber : MetroFramework.Forms.MetroForm
    {
        SessionInfo Cv_Session;
        bool Cv_Flag = false;
        int Cv_DocId;
        public frmRemmber(SessionInfo Fp_Session)
        {
            Cv_Session = Fp_Session;
            InitializeComponent();
        }

        private void frmRemmber_Load(object sender, EventArgs e)
        {
            CheckDocExpire();
        }

        private void CheckDocExpire()
        {
            throw new NotImplementedException();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRemmber_Load_1(object sender, EventArgs e)
        {
            
            LaodDocExpire();
        }

        private void LaodDocExpire()
        {
            Cv_Flag = false;
            string cmd = " SELECT AlertByDayAfter FROM Users";
            int Fv_DaySetting = 0;
            int.TryParse(Cv_Session.GetFieldText(cmd), out Fv_DaySetting);

            cmd = "SELECT Id,DocName FROM ViewDocuments WHERE  (" + Fv_DaySetting + " >= DATEDIFF(d, GETDATE(), ExpireDate))";

            Cv_Session.FillTreeNode(treeDocExpire, cmd, 0);
            Cv_Flag = true;

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeDocExpire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(Cv_Flag)
            {
                DefaultControl();
                Cv_DocId = int.Parse(e.Node.Tag.ToString());
                DisplayDocument();
                
            }
        }

        private void DisplayDocument()
        {
            string cmd = "SELECT Id,DocName,DocNo,IssueDate,ExpireDate FROM Documents WHERE Id=" + Cv_DocId;
            DataTable dt = new DataTable();
            if(Cv_Session.FillDataTable(dt,cmd))
            {
                if(dt.Rows.Count != 0)
                {
                    txtDocName.Text = dt.Rows[0]["DocName"].ToString();
                    txtDocNo.Text = dt.Rows[0]["DocNo"].ToString();
                    dtpDateIssue.Value = DateTime.Parse(dt.Rows[0]["IssueDate"].ToString());
                    dtpDateExpire.Value = DateTime.Parse(dt.Rows[0]["ExpireDate"].ToString());
                }
            }
            cmd = "SELECT DocPic FROM Documents WHERE Id=" + Cv_DocId;
            Cv_Session.LoadImageFromDb(picDoc, cmd);
        }

        private void DefaultControl()
        {
            Cv_DocId = 0;
            txtDocName.Text = "";
            txtDocNo.Text = "";
            dtpDateIssue.Value = DateTime.Today;
            dtpDateExpire.Value = DateTime.Today;

            picDoc.Image = null;

        }

        private void picDoc_Click(object sender, EventArgs e)
        {
            if (Cv_DocId == 0 && picDoc.Image == null)
                return;

            frmDocViewer viewer = new frmDocViewer();
            viewer.DocTitle = txtDocName.Text;
            viewer.DocPicBox = picDoc;
            viewer.LoadPic();



            viewer.ShowDialog();
        }
    }
}

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
    public partial class ucDocType : MetroFramework.Forms.MetroForm
    {
        SessionInfo Cv_Session;
        public string IconUrlDefault = @"Images\Default.png";
        private bool IsNew = true;
        private int DocTypeId = 0;

        uctypeList list;
        public ucDocType(SessionInfo Fp_Session)
        {
            Cv_Session = Fp_Session;
            InitializeComponent();
            list = new uctypeList(Cv_Session);
            pnlMain.Controls.Add(list);

            pnlMain.Controls[2].Dock = DockStyle.Fill;
            pnlMain.Controls[2].BringToFront();
            SetEventList();
 
        }

        private void SetEventList()
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
            DefaultControls();
            IsNew = false;
            txtDocType.Text = list.DocTypeName;
            
            picIcon.Image = Image.FromFile(list.DocTypeUrl);
            picIcon.Tag = list.DocTypeUrl;
            DocTypeId = list.DocTypeId;

            btnDelete.Enabled = true;

        }

        private void ucDocType_Load(object sender, EventArgs e)
        {
            SetEventList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            DefaultControls();
        }

        private void DefaultControls()
        {
            txtDocType.Text = "";
            picIcon.Image = Image.FromFile(IconUrlDefault);
            IsNew = true;
            DocTypeId = 0;
            btnDelete.Enabled = false;
            


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Update()
        {
            if(String.IsNullOrEmpty(txtDocType.Text.Trim()))
            {
                MessageBox.Show("الرجاء ادخال اسم التصنيف الجديد للوثائق ");
                return;
            }
            string strDocTypeName = txtDocType.Text.Trim(); ;
            string sqlCmd = "select Name from DocumentsType where Name ='" + strDocTypeName + "'";
           if(IsNew)
           {
               if (Cv_Session.HasRows(sqlCmd))
               {
                   MessageBox.Show("لقد ادخلت نفس هذا التصنيف سابقا غير الاسم ثم حاول مرة اخرى ");
                   return;
               }
               SaveDocType();
           }
           else
           {
               UpdateDocType();
           }

        }

        private void SaveDocType()
        {
            string cmd = "INSERT INTO DocumentsType (Name,IconUrl) VALUES ('" + txtDocType.Text.Trim() + @"','" + picIcon.Tag.ToString() + "')";
            if (Cv_Session.ExecuteCommand(cmd))
            {
                cmd = "SELECT MAX(Id) FROM DocumentsType";
                DocTypeId = int.Parse(Cv_Session.GetFieldText(cmd));
                
                MessageBox.Show("تم الحفظ بنجاح ");
                list.LoadDocType(false);
                SetEventList();
                return;
            }
            MessageBox.Show("لم تتم عملية الحفظ هناك خطأ ما تأكد انك مازلت متصل بقاعدة البيانات");
        }

        private void UpdateDocType()
        {
            string strDocTypeName = txtDocType.Text.Trim(); ;
            string sqlCmd = "SELECT Name FROM DocumentsType WHERE Name ='" + strDocTypeName + "'";
            if(txtDocType.Text != list.DocTypeName && picIcon.Tag.ToString() != list.DocTypeUrl)
            {
                

                if (Cv_Session.HasRows(sqlCmd))
                {
                    MessageBox.Show("لقد ادخلت نفس هذا التصنيف سابقا غير الاسم ثم حاول مرة اخرى ");
                    return;
                }
            }
                sqlCmd = "UPDATE DocumentsType Set Name='" + txtDocType.Text + "',IconUrl='" + picIcon.Tag.ToString() + "' WHERE Id=" + DocTypeId;
                if(Cv_Session.ExecuteCommand(sqlCmd))
                {
                    MessageBox.Show("تم تحديث البيانات بنجاح ");
                    list.LoadDocType(false);
                    SetEventList();
                    return;
                }
                
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("هل انت متأكد انك تريد حذف التصنيف ", "تنبيه للحذف ", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(rs == System.Windows.Forms.DialogResult.Yes)
            {
                if (DocTypeId == 0)
                    return;
                string cmd = "DELETE FROM DocumentsType WHERE Id=" + DocTypeId;
                if (Cv_Session.ExecuteCommand(cmd))
                {
                    MessageBox.Show("لقد تم عملية الحذف بنجاح ");
                    list.LoadDocType(false);
                    SetEventList();

                }
                else
                    MessageBox.Show("لم تنجح عملية الحذف قد يكون هناك بيانات مرتبطة بالتصنيف قم بحذف البيانات المرتبطة اولا عند رغبتك في الحذف");


            }

        }

        private void picIcon_Click(object sender, EventArgs e)
        {
            opnFleDlg.CheckFileExists = true;
            opnFleDlg.CheckPathExists = true;
            opnFleDlg.DefaultExt = "*.JPG||*.PNG||*.GIF||*.JPEG";
            DialogResult rs= opnFleDlg.ShowDialog();
            if(rs == System.Windows.Forms.DialogResult.OK)
            {

                if(!String.IsNullOrEmpty(opnFleDlg.FileName))
                {
                    picIcon.Image = Image.FromFile(opnFleDlg.FileName);
                    picIcon.Tag = opnFleDlg.FileName;
                }
            }

        }
    }
}

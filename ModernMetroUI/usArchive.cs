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
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace ModernMetroUI
{
    public partial class usArchive : MetroFramework.Controls.MetroUserControl
    {
        SessionInfo Cv_Session;
        public int Pv_DocId { get; set; }
        private DbObject Cv_Document;
        public usArchive(SessionInfo Fp_Session)
        {
            Cv_Session = Fp_Session;
            InitializeComponent();
            FirstEnter();
            SetTableInfo();
        }
        private void SetTableInfo()
        {
            Cv_Document = new DbObject(Cv_Session.ConnectionString);
            SetIdentityInfo();
            Cv_Document.SetTableInfo();
        }

        private void SetIdentityInfo()
        {
            Cv_Document.TableName = "Documents";
            Cv_Document.IdFieldName = "Id";
            Cv_Document.UnInsertedFields.Add("DocPic");

            Cv_Document.UnUpdatedFields.Add("DocPic");
           
        }
        private void CmbCancel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                ComboBox cmb = (ComboBox)sender;
                cmb.SelectedIndex = -1;
            }
        }
        private string GetCondition()
        {

            return "WHERE Id=" + Pv_DocId;
        }



        #region Form Control Settings duaring database operations

        private void FirstEnter()
        {
            InputCase(false);
            DefaultInput();
            ButtonsCase(true, false, false, false, false, false);
        }

        private void ButtonsCase(bool b1, bool b2, bool b3, bool b4, bool b5, bool b6)
        {
            btnNew.Enabled = b1;
            btnSave.Enabled = b2;
            btnEdit.Enabled = b3;
            btnUpdate.Enabled = b4;
            btnUndo.Enabled = b5;
            btnDelete.Enabled = b6;
            btnInsertDocPic.Enabled = b6;
            btnSavePic.Enabled = b6;
        }

        private void ResetToDisplayCase()
        {
            InputCase(false);
            ButtonsCase(true, false, true, false, false, true);
        }

        private void LoadList()
        {
            Cv_Session.FillList(cmbDocType, "Id", "Name", "DocumentsType");

        }

        private void DefaultInput()
        {
 
            txtDocName.Text = "";
            txtDocNo.Text = "0";
            cmbDocType.SelectedIndex = -1;
            dtIssueDate.Value = DateTime.Today;
            dtDateExpire.Value = DateTime.Today;

            txtTags.Text = "";
            txtDetails.Text = "";

            txtDayNo.Text = "0";
        }

        private void InputCase(bool pCase)
        {
            cmbDocType.Enabled = pCase;
            txtDocName.ReadOnly = !pCase;
            txtDocNo.ReadOnly = !pCase;

            dtIssueDate.Enabled = pCase;
            dtDateExpire.Enabled = pCase;

            txtTags.ReadOnly = !pCase;
            txtDetails.ReadOnly = !pCase;

            txtDayNo.ReadOnly = !pCase;

            
        }

        private bool ReadInput()
        {
            if (cmbDocType.SelectedIndex == -1)
            {
                cmbDocType.Style = MetroFramework.MetroColorStyle.Red;
                MessageBox.Show("الرجاء اختيار نوع الوثيقة ");

                return false;
            }


            if (String.IsNullOrEmpty(txtDocName.Text))
            {
                MessageBox.Show("الرجاء ادخال اسم الوثيقة ");
                return false;
            }


            if (String.IsNullOrEmpty(txtDocNo.Text) || int.Parse(txtDocNo.Text) == 0)
            {
                MessageBox.Show("الرجاء ادخال رقم الوثيقة ");
                return false;
            }

            if (cmbDocType.SelectedIndex != -1)
                Cv_Document.Record["DocTypeId"] = cmbDocType.SelectedValue;
            else
                Cv_Document.Record["DocTypeId"] = DBNull.Value;

            Cv_Document.Record["DocName"] = txtDocName.Text;
            Cv_Document.Record["DocNo"] = txtDocNo.Text;

            
            Cv_Document.Record["IssueDate"] = Cv_Session.GetDateFormatDMY(dtIssueDate.Value);
            Cv_Document.Record["ExpireDate"] = Cv_Session.GetDateFormatDMY(dtDateExpire.Value);

            Cv_Document.Record["Tags"] = txtTags.Text;
            Cv_Document.Record["Detials"] = txtDetails.Text;

            Cv_Document.Record["Tags"] = txtTags.Text;
            Cv_Document.Record["Detials"] = txtDetails.Text;


            Cv_Document.Record["DocAlertBefore"] = txtDayNo.Text;
            Cv_Document.Record["DocRenewComplate"] = tchkRenew.Checked;

            return true;
        }

        public void GetRecord()
        {
            if (Cv_Document.SelectRecord(GetCondition()))
                DisplayRecord();
            else
                MessageBox.Show("خطأ" + Cv_Document.DbErrorMessage);
        }

        public void DisplayRecord()
        {
            DefaultInput();
            Pv_DocId = int.Parse(Cv_Document.Record["Id"].ToString());

            try { cmbDocType.SelectedValue = Cv_Document.Record["DocTypeId"]; }
            catch { cmbDocType.SelectedIndex = -1; }

            txtDocName.Text = Cv_Document.Record["DocName"].ToString();
            txtDocNo.Text = Cv_Document.Record["DocNo"].ToString();

            dtIssueDate.Value = DateTime.Parse(Cv_Document.Record["IssueDate"].ToString());
            dtDateExpire.Value = DateTime.Parse(Cv_Document.Record["ExpireDate"].ToString());


            txtTags.Text = Cv_Document.Record["Tags"].ToString();
            txtDetails.Text = Cv_Document.Record["Detials"].ToString();


            txtDayNo.Text = Cv_Document.Record["DocAlertBefore"].ToString();
            tchkRenew.Checked = bool.Parse(Cv_Document.Record["DocRenewComplate"].ToString());
            string cmd = "SELECT DocPic FROM Documents WHERE Id=" + Pv_DocId;

            Cv_Session.LoadImageFromDb(picDoc, cmd);

            ResetToDisplayCase();
        }

        #endregion

        #region Database Operations

        private void NewRecord()
        {

            Cv_Document.NewRecord();
            InputCase(true);
            DefaultInput();

            ButtonsCase(false, true, false, false, true, false);
   
        }

        private void SaveRecord()
        {
            if (ReadInput())
            {
                SetIdentityInfo();
                if (Cv_Document.InsertRecord())
                {
                    Pv_DocId = Int32.Parse(Cv_Document.IdFieldValue.ToString());

                    MessageBox.Show("تمت عملية حفظ البيانات بنجاح ");
                    GetRecord();
                }
                else
                {
                    MessageBox.Show("خطأ!" + Cv_Document.DbErrorMessage);
                }
            }
        }

        public void EditRecord()
        {

            Cv_Document.EditRecord();
            InputCase(true);
            ButtonsCase(false, false, false, true, true, false);
        }

        private void UpdateRecord()
        {
            if (ReadInput())
            {
                if (Cv_Document.UpdateRecord(GetCondition()))
                {

                    MessageBox.Show("تمت تحديث البيانات بنجاح ");
                    ResetToDisplayCase();
                }
                else
                {
                    if (String.IsNullOrEmpty(Cv_Document.GeneratedCommand))
                        MessageBox.Show("لم يتم تعديل البيانات ");
                    else
                        MessageBox.Show("خطأ!" + Cv_Document.DbErrorMessage);
                }
            }
        }

        private void UndoRecord()
        {
            if (btnSave.Enabled)
            {
                if (Cv_Document.UndoRecord(false))
                    DisplayRecord();
                else
                    FirstEnter();
            }
            else if (btnUpdate.Enabled)
            {
                Cv_Document.UndoRecord(true);
                DisplayRecord();
            }
        }

        public void DeleteRecord()
        {
            DialogResult rs = MessageBox.Show("هل انت متأكد من عملية الحذف ", "تنبيه حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.No)
                return;
            if (Cv_Document.DeleteRecord(GetCondition()))
            {
                Pv_DocId = 0;

                FirstEnter();

            }
            else
                MessageBox.Show("خطأ!" + Cv_Document.DbErrorMessage);
        }

        #endregion


        #region User interactions

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewRecord();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveRecord();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditRecord();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateRecord();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            UndoRecord();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void NumberValidation(object sender, KeyPressEventArgs e)
        {
            Cv_Session.IsIntegerNumber(sender, e, 10);
        }


        #endregion



        private void usArchive_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSavePic_Click(object sender, EventArgs e)
        {
            SaveDocPic();
        }

        private void SaveDocPic()
        {
            if (Pv_DocId == 0)
                return;
            //veImage();
            Bitmap pict = new Bitmap(picDoc.Image);
            string CommandString = " UPDATE Documents SET DocPic=@Picture WHERE Id=" + Pv_DocId;
            if (Cv_Session.SaveImageToDb(pict, CommandString))
                MessageBox.Show("تم تحديث الصورة بنجاح ");
            

        }



        private void btnInsertDocPic_Click(object sender, EventArgs e)
        {
            ofdPic.Multiselect = false;
            //dPic.Filter = " ‎(*.Jpeg)|*.jpeg|(*.JPG)|*.JPG|(*.PNG)|*.PNG|";

            DialogResult rs = ofdPic.ShowDialog();
            if(rs == DialogResult.OK)
            {
                picDoc.Image = Image.FromFile(ofdPic.FileName);
                picDoc.Tag = ofdPic.FileName;

            }
        }

        private void usArchive_Paint(object sender, PaintEventArgs e)
        {
            LoadList();
        }

        private void picDoc_Click(object sender, EventArgs e)
        {
            if (Pv_DocId == 0 && picDoc.Image == null)
                return;

            frmDocViewer viewer = new frmDocViewer();
            viewer.DocTitle = txtDocName.Text;
            viewer.DocPicBox = picDoc;
            viewer.LoadPic();



            viewer.ShowDialog();


        }
    }
}

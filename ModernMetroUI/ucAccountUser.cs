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
    public partial class ucAccountUser : MetroFramework.Controls.MetroUserControl
    {
        SessionInfo Cv_Session;
        public int UserId { get; set; }
        public ucAccountUser(SessionInfo Fp_Session)
        {
            Cv_Session = Fp_Session;
            InitializeComponent();
            DisplayDate();
        }

        private void ucAccountUser_Load(object sender, EventArgs e)
        {
            
        }

        private void DisplayDate()
        {
            string cmd = " SELECT Id,UserName, UserPassword,StartOpenSystem,AlertByDayAfter FROM Users";
            DataTable dt = new DataTable();
            if(Cv_Session.FillDataTable(dt,cmd))
            {
                if(dt.Rows.Count != 0 )
                {
                    txtUserName.Text = dt.Rows[0]["UserName"].ToString();
                    txtOldPassowrd.Text = dt.Rows[0]["UserPassword"].ToString();
                    
                    ckhAlertIsOpen.Checked = bool.Parse(dt.Rows[0]["StartOpenSystem"].ToString());
                    txtDayAlert.Text = dt.Rows[0]["AlertByDayAfter"].ToString();
                    cmd = " SELECT Image FROM Users";
                    Cv_Session.LoadImageFromDb(picUser, cmd);


                }
            }
        }

        private void btnInsertPic_Click(object sender, EventArgs e)
        {
            ofdOpen.Multiselect = false;
            DialogResult dr = ofdOpen.ShowDialog();

            if(dr == DialogResult.OK)
            {
                picUser.Image = Image.FromFile(ofdOpen.FileName);
                picUser.Tag = ofdOpen.FileName;

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!CheckControl())
                return;
            string cmd = " UPDATE Users SET UserName='" + txtUserName.Text + "',";
            cmd += " UserPassword='" + txtOldPassowrd.Text + "',";
            cmd += " AlertByDayAfter=" + txtDayAlert.Text;
            cmd += " , StartOpenSystem='" + ckhAlertIsOpen.Checked.ToString() + "' WHERE Id=1";

            if (Cv_Session.ExecuteCommand(cmd))
                MessageBox.Show("تم تحديث البيانات بنجاح ");

            frmMain.Instance.MetroUser.Text ="Welcome \r\n" + txtUserName.Text;
            if(picUser.Image != null && picUser.Tag != null)
                SaveUserPic();
        }


        private void SaveUserPic()
        {
      
            //veImage();
            Bitmap pict = new Bitmap(picUser.Image);
            string CommandString = " UPDATE Users SET Image=@Picture WHERE Id=1";
            if (Cv_Session.SaveImageToDb(pict, CommandString))
                MessageBox.Show("تم تحديث صورة المستخدم بنجاح ");


        }


        private bool CheckControl()
        {
            if(String.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("الرجاء ادخال اسم المستخدم");
                return false;
            }

            if (String.IsNullOrEmpty(txtOldPassowrd.Text))
            {
                MessageBox.Show("الرجاء ادخال كلمة المرور ");
                return false;
            }

            if (String.IsNullOrEmpty(txtDayAlert.Text) || int.Parse(txtDayAlert.Text) == 0)
            {
                MessageBox.Show("الرجاء ادخال مدة التذكير قبل انتهاء الموعد   ");
                return false;
            }

            return true;
        }
    }
}

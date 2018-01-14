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
    
    public partial class usLogin : MetroFramework.Controls.MetroUserControl
    {
        frmMain formMain = null;
        SessionInfo Cv_Session;

        public usLogin(frmMain Fp_FormMain)
        {
            InitializeComponent();
            formMain = Fp_FormMain;
        }

        private void usLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Text) || String.IsNullOrEmpty(txtDBName.Text))
            {
                MessageBox.Show("الرجاء ادخال  اسم خادم قاعدة البيانات او اسم المستخدم او كلمة المرور  ");
                return;
            }

            ConnectionDatabaseServer();

            string cmd = "SELECT  Id FROM Users WHERE UserName='" + txtUserName.Text.Trim() + "' AND UserPassword='" + txtPassword.Text.Trim() + "'";
            //Checck UserName & Password 
            if(Cv_Session.HasRows(cmd))
            {
                Cv_Session.UserId = int.Parse(Cv_Session.GetFieldText(cmd));
                ucDashBoard uc = new ucDashBoard(Cv_Session);
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroController.Controls.Add(uc);
                //Show user buttons 
                frmMain.Instance.MetroUser.Visible = true;
                frmMain.Instance.MetroLogout.Visible = true;

                frmMain.Instance.MetroController.Controls["ucDashBoard"].BringToFront();
                // formMain.Controls.Add(uc);
                if (frmMain.Instance.MetroController.Controls["ucDashBoard"] == null)
                {

                    frmMain.Instance.MetroController.Controls["ucDashBoard"].BringToFront();
                    frmMain.Instance.MetroBack.Visible = true;



                }

                frmMain.Instance.Cv_Session = Cv_Session;
                frmMain.Instance.MetroUser.Text = "Welcome \r\n" + txtUserName.Text;

                cmd = " SELECT StartOpenSystem FROM Users";
                bool Fv_IsAlertShow;
                Fv_IsAlertShow = Cv_Session.GetFieldBoolean(cmd);
                if (!Fv_IsAlertShow)
                    return;

                

                frmRemmber frmAlert = new frmRemmber(Cv_Session);
                frmAlert.Show();
            }
            else
            {
                string msg= "خطأ! اسم المستخدم او كلمة المرور غير صحيحه "+Cv_Session.DbErrorMessage;

                MessageBox.Show(msg);
                return;
                    
            }

        }

        private void ConnectionDatabaseServer()
        {
            if (String.IsNullOrEmpty(txtDBName.Text))
                return;
            string cmd = "Data Source=" + txtDBName.Text + ";Initial Catalog=dbDocAlerts;Integrated Security=True";
            Cv_Session = new SessionInfo(1, cmd);

        }
    }
}

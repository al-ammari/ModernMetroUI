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
    
    public partial class frmMain : MetroFramework.Forms.MetroForm
    {
        public static frmMain _instance;
        public SessionInfo Cv_Session { get; set; }
        public static frmMain Instance
        {
            get
            {
                if(_instance==null)
                    _instance= new frmMain();
                return _instance;

            }
        }

        public  MetroFramework.Controls.MetroPanel MetroController
        {
            get{return pnlMetro;}
            set{pnlMetro = value;}
        }

        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return lnkback; }
            set { lnkback = value; }
        }

        public  MetroFramework.Controls.MetroLink MetroUser
        {
            get { return lnkUser; }
            set { lnkUser = value; }
        }

        public MetroFramework.Controls.MetroLink MetroLogout
        {
            get { return lnkLogout; }
            set { lnkUser = value; }
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            _instance = this;

            LoadFormScren();

            SetDefaultTimeDate();
        }

        private void LoadFormScren()
        {

            lnkback.Visible = false;
            lnkUser.Visible = false;
            lnkLogout.Visible = false;

            if (pnlMetro.Controls["usLogin"] == null)
            {
                usLogin uc = new usLogin(this);
                uc.Dock = DockStyle.Fill;
                pnlMetro.Controls.Add(uc);
            }
            else
                pnlMetro.Controls["usLogin"].BringToFront();
        }

        private void SetDefaultTimeDate()
        {
            SetDefaultTime();
            lblDate.Text = DateTime.Today.ToShortDateString();
        }

        private void SetDefaultTime()
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        private void lnkback_Click(object sender, EventArgs e)
        {
            ucDashBoard ucdb = (ucDashBoard)frmMain.Instance.MetroController.Controls["ucDashBoard"];
            ucdb.BringToFront();
            ucdb.LoadDocList(false);
            ucdb.list.LoadDocType(false);
            ucdb.SetEventList();

            //frmMain.Instance.MetroController.Controls["ucDashBoard"].BringToFront();
            //frmMain.Instance.MetroController.Controls["ucDashBoard"]();
            lnkback.Visible = false;
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void lnkUser_Click(object sender, EventArgs e)
        {
            if (frmMain.Instance.MetroController.Controls["ucAccountUser"] == null)
            {
                ucAccountUser account = new ucAccountUser(Cv_Session);
                account.Dock = DockStyle.Fill;
                frmMain.Instance.MetroController.Controls.Add(account);

            }
            frmMain.Instance.MetroController.Controls["ucAccountUser"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void lnkLogout_Click(object sender, EventArgs e)
        {
            LoadFormScren();
        }
    }
}

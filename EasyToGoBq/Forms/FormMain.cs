using EasyToGoBq.Classes;
using EasyToGoBq.Forms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyToGoBq.Forms
{
    public partial class FormMain : Form
    {
        private static FormMain main;
        private UserControl uc = null;
        private Form form = null;

        public FormMain()
        {
            InitializeComponent();
        }

        public static FormMain Instance
        {
            get
            {
                if (main == null)
                {
                    main = new FormMain();
                }

                return main;
            }

            set
            {
                value = main;
            }
        }
       
        private void LoadUserControles(UserControl uc)
        {
            Cursor = Cursors.WaitCursor;
            PnlMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            PnlMain.Controls.Add(uc);
            uc.Show();

            if (uc.Visible == true)
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Raffraichit le formulaire après connexion et déconnexion
        /// </summary>
        /// <param name="autologout"></param>
        public void RefreshOnlineStatus(bool autologout = false)
        {
            if (User.Instance.IsAuthenticate() && autologout == false)
            {
                //TblLayoutPanelMenu.Enabled = true;
                LblDashbord.Enabled = true;
                Report.Enabled = true;
                LblRecharge.Enabled = true;
                Settings.Enabled = true;
                LblConnection.Text = "Déconnexion";
                LblStatus.Text = User.Instance.UsernameSession;
            }
            else
            {
                User.Instance = null;

                uc = new UcHome();
                LoadUserControles(uc);
                LblDashbord.Enabled = false;
                Report.Enabled = false;
                LblRecharge.Enabled = false;
                Settings.Enabled = false;
                //TblLayoutPanelMenu.Enabled = false;

                LblStatus.Text = "Invité";
                LblConnection.Text = "Connexion";
               
            }
        }
       

        private void LblDashbord_MouseLeave(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Dashbord":
                    LblDashbord.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                case "Report":
                    LblRecharge.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                case "Settings":
                    LblRecharge.ForeColor = Color.FromArgb(14, 23, 22);
                    break;

                default:
                    break;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Load_1(object sender, EventArgs e)
        {
             
            //LblConnection.Enabled = false;
            //FormLogin re = new FormLogin();
            //re.ShowDialog();
            uc = new UcHome();
            LoadUserControles(uc);
            RefreshOnlineStatus();

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.Substring(3))
            {
                case "Dashbord":
                    LblDashbord.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                case "Report":
                    LblRecharge.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                case "Settings":
                    LblRecharge.ForeColor = Color.FromArgb(85, 183, 20);
                    break;

                default:
                    break;
            }
        }

        private void LblDashbord_Click(object sender, EventArgs e)
        {
            uc = new UcDashbord();
            LoadUserControles(uc);
        }

        private void LblRecharge_Click(object sender, EventArgs e)
        {
            FormRecharges re = new FormRecharges();
            re.ShowDialog();

        }

        private void LblConnection_Click(object sender, EventArgs e)
        {
            if (LblConnection.Text == "Connexion")
            {
                form = new FormLogin(this)
                {
                    Icon = Icon
                };
                form.ShowDialog(this);
            }
            else
            {
                RefreshOnlineStatus(true);
            }
            //this.Hide();
            //FormLogin re = new FormLogin();
            //re.ShowDialog();


        }

        private void Settings_Click(object sender, EventArgs e)
        {
            FormRegister re = new FormRegister();
            re.ShowDialog();

        }

        private void Report_Click(object sender, EventArgs e)
        {
            uc = new UcReport();
            LoadUserControles(uc);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //FormProgress re = new FormProgress();
            //re.ShowDialog();
        }
    }
}

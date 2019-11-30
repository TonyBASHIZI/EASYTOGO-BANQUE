using EasyToGoBq.Classes;
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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private FormMain main = new FormMain();

        public FormLogin(FormMain parent)
        {
            InitializeComponent();
            main = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (TxtUsername.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Remplissez tous les champs");
            }
            else
            {
                User.Instance = Glossaire.Instance.LoginTest(TxtUsername.Text, TxtPassword.Text);

                if (!string.IsNullOrEmpty(User.Instance.UsernameSession))
                {
                    User.Instance.UpdateFormMain();
                    this.main.RefreshOnlineStatus();
                    this.Close();
                }
                else
                {
                    LblError.Text = "Echec de Connexion mot de passe incorrect";

                }

            }
            Cursor = Cursors.Default;
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

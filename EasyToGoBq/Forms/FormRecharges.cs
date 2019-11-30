using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyToGoBq.Classes;



namespace EasyToGoBq.Forms
{
    public partial class FormRecharges : Form
    {
        public FormRecharges()
        {
            InitializeComponent();
        }


        private void initial()
        {
            TxtMatricule.Text = "";
            TxtNom.Text = "";
            TxtPostnom.Text = "";
            TxtPrenom.Text = "";
            TxtRecherche.Text = "";
            TxtSolde.Text = "";
            TxtEmail.Text = "";
            TxtAdresse.Text = "";

        }

        private void FormRecharge_Load(object sender, EventArgs e)
        {
            Glossaire.Instance.GetDatas(GridView, "matricule,nom,postnom,prenom,tel,email,adresse,solde", "agent");

        }
      
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            TxtMatricule.Text = GridView.SelectedRows[0].Cells["matricule"].Value.ToString();
            TxtPostnom.Text = GridView.SelectedRows[0].Cells["postnom"].Value.ToString();
            TxtNom.Text = GridView.SelectedRows[0].Cells["nom"].Value.ToString();
            TxtPrenom.Text = GridView.SelectedRows[0].Cells["prenom"].Value.ToString();
            TxtAdresse.Text = GridView.SelectedRows[0].Cells["adresse"].Value.ToString();
            TxtTel.Text = GridView.SelectedRows[0].Cells["tel"].Value.ToString();
            TxtEmail.Text = GridView.SelectedRows[0].Cells["email"].Value.ToString();
            TxtSolde.Text = GridView.SelectedRows[0].Cells["solde"].Value.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           

                    Glossaire.Instance.Recharge(TxtMatricule.Text, TxtSolde.Text);
                    Glossaire.Instance.GetDatas(GridView, "matricule,nom,postnom,prenom,tel,email,adresse,solde", "agent");
                    initial();
                    TxtMatricule.Text = getMatr();

                    
            
        }

        public string getMatr()
        {
            Random rd = new Random();
            int x = rd.Next(1,500);
            string mat = "14010-01-"+x;
            return mat;
        }

        private void FormRecharges_Load(object sender, EventArgs e)
        {
            TxtMatricule.Text = getMatr();
            Glossaire.Instance.GetDatas(GridView, "matricule,nom,postnom,prenom,tel,email,adresse,solde", "agent");

        }

        private void TxtRecherche_TextChanged(object sender, EventArgs e)
        {
            Glossaire.Instance.Recherche(GridView, TxtRecherche.Text);


        }

        private void TxtSolde_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < TxtSolde.Text.Length; i++)
            {
                if (!char.IsDigit(TxtSolde.Text, i))
                {
                    MessageBox.Show("Donnée incorrecte ce champ ne peut que prendre les numeriques!!");
                    TxtSolde.Text = "";
                }
                else
                {

                }
            }
        }

        private void GridView_DoubleClick_1(object sender, EventArgs e)
        {
            TxtMatricule.Text = GridView.SelectedRows[0].Cells["matricule"].Value.ToString();
            TxtPostnom.Text = GridView.SelectedRows[0].Cells["postnom"].Value.ToString();
            TxtNom.Text = GridView.SelectedRows[0].Cells["nom"].Value.ToString();
            TxtPrenom.Text = GridView.SelectedRows[0].Cells["prenom"].Value.ToString();
            TxtAdresse.Text = GridView.SelectedRows[0].Cells["adresse"].Value.ToString();
            TxtTel.Text = GridView.SelectedRows[0].Cells["tel"].Value.ToString();
            TxtEmail.Text = GridView.SelectedRows[0].Cells["email"].Value.ToString();
            TxtSolde.Text = GridView.SelectedRows[0].Cells["solde"].Value.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyToGoBq.Classes;
using System.Threading;

namespace EasyToGoBq.Forms.Views
{
    public partial class UcDashbord : UserControl
    {
        //int cmt = 0;
        private int seconde = 0;
        public UcDashbord()
        {
            InitializeComponent();
        }

        public void getDashBord()
        {
            int recharge = int.Parse(LblTotalRecharge.Text);
            int opera = int.Parse(LblOperation.Text);
            try
            {
                LblTotalRecharge.Text = Glossaire.Instance.getTotalRecharge();
                LblOperation.Text = Glossaire.Instance.getOperation();
                LblCompte.Text = Glossaire.Instance.getSoldes();
                //LblTranct.Text = Glossaire.Instance.getTransact();
                LblTranct.Text = ""+(recharge - opera); 
                LblCommission.Text = Glossaire.Instance.getCommission();
                LblTransco.Text = Glossaire.Instance.getAgence("TRANSCO");
                LblTranskin.Text = Glossaire.Instance.getAgence("TRANSKIN");
                LblEsprit.Text = Glossaire.Instance.getAgence("ESPRIT DE VIE");
                Glossaire.Instance.GetDatas(dataGridView1, "designation,solde,etat", "compte");

            }
            catch(Exception ex)
            {
                
                timer1.Stop();
                MessageBox.Show(this, "Une erreur s'est produite lors du chargement des données en temps réel. \n\nL'Application va s'arrêter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Une erreur s'est produite lors de l'opération : " + ex.Message);
                Application.Exit();
                // MessageBox.Show(this, "Une erreur s'est produite lors du chargement des données en temps réel. \n\nL'Application va s'arrêter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("Une erreur s'est produite lors du chargement des données en temps réel. \n\nL'Application" + ex.Message);
                //Application.Exit();
            }
            

            

        }

        private void UcDashbord_Load(object sender, EventArgs e)

        {
            timer1.Start();
            getDashBord();
            

            //Thread thr = new Thread(mythread);
            //thr.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconde++;
            if (seconde == 5)
            {
                
                getDashBord();
                seconde = 0;
            }         
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            FormPopUpOperation op = new FormPopUpOperation();
            op.ShowDialog();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            FormPopUpCompte c = new FormPopUpCompte();
            c.ShowDialog();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            FormPopUpTransact c = new FormPopUpTransact();
            c.ShowDialog();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            FormPopUpTransco tr = new FormPopUpTransco("TRANSCO");
            tr.ShowDialog();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            FormPopUpTransco tr = new FormPopUpTransco("TRANSKIN");
            tr.ShowDialog();

        }

        private void panel8_Click(object sender, EventArgs e)
        {
            FormPopUpTransco tr = new FormPopUpTransco("ESPRIT DE VIE");
            tr.ShowDialog();

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
     
    }
}

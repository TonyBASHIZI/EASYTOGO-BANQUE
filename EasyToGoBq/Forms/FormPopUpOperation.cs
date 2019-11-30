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
    public partial class FormPopUpOperation : Form
    {
        public FormPopUpOperation()
        {
            InitializeComponent();
        }

        private void FormPopUpOperation_Load(object sender, EventArgs e)
        {
            Lbl1.Text = Glossaire.Instance.Trajet("1000");
            Lbl2.Text = Glossaire.Instance.Trajet("500");
            int t1 = int.Parse(Lbl1.Text) * 1000;
            int t2 = int.Parse(Lbl2.Text) * 500;

            LblTotal1.Text = ""+t1;
            LblTotal2.Text = "" + t2;

            int totaux = t1 + t2;

            LblTotaux.Text = "" + totaux;


        }
    }
}

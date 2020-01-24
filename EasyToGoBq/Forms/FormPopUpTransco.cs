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
    public partial class FormPopUpTransco : Form
    {
        string comp = "TRANSPORT";
        public FormPopUpTransco(string compagnie)
        {
            InitializeComponent();
            comp = compagnie;
        }
       

        private void FormPopUpTransco_Load(object sender, EventArgs e)
        {
            Glossaire.Instance.DetailTransact(lbOpe, lbBus, lbPaie, comp);
            Glossaire.Instance.GetDataCompagnie(GridView, "*", "filtreTransact",comp);
            LblC.Text = "" + comp;
        }
    }
}

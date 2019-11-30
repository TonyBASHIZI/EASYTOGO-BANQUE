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
    public partial class FormPopUpCompte : Form
    {
        public FormPopUpCompte()
        {
            InitializeComponent();
        }

        private void FormPopUpCompte_Load(object sender, EventArgs e)
        {
            Glossaire.Instance.GetDatas(dataCompte, "designation,solde", "compte");
        }
    }
}

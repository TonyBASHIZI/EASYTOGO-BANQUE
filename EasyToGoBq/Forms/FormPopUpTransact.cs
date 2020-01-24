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
    public partial class FormPopUpTransact : Form
    {
        public FormPopUpTransact()
        {
            InitializeComponent();
        }

        private void FormPopUpTransact_Load(object sender, EventArgs e)
        {
            Glossaire.Instance.GetDatasTransact(dataGridView1, "*", "detailTransact");

        }
    }
}

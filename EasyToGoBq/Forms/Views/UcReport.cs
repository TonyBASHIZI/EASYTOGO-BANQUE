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
using EasyToGoBq.Forms;


namespace EasyToGoBq.Forms.Views
{
    public partial class UcReport : UserControl
    {
        public UcReport()
        {
            InitializeComponent();
        }

        private void PcbCompte_Click(object sender, EventArgs e)
        {
            FormReport re = new FormReport(0);
            re.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UcReport_Load(object sender, EventArgs e)
        {
            Glossaire.Instance.GetDatas(GridView, "*", "transaction");
        }

        private void PcbTransfert_Click(object sender, EventArgs e)
        {
            FormReport re = new FormReport(0);
            re.ShowDialog();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

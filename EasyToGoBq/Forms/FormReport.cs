using EasyToGoBq.Classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyToGoBq.Forms;

namespace EasyToGoBq.Forms
{
    public partial class FormReport : Form
    {
        private MySqlConnection con = null;
        private MySqlCommand cmd = null;
        private Connection cnx;

        public FormReport(int index)
        {
            InitializeComponent();
            LoadReport(index);
        }

        public void InitializeConnection()
        {
            try
            {
                cnx = new Connection(); cnx.Connect();
                con = new MySqlConnection(cnx.path);

                if (!con.State.ToString().ToLower().Equals("open"))
                {
                    con.Open();
                }
            }
            catch (Exception)
            {
                throw new Exception("Erreur de chargement des données");
            }

        }

        private void LoadReport(int index)
        {
            try
            {
                InitializeConnection();

                using (cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT designation,description,ref_compagnie,solde from compte";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter((MySqlCommand)cmd))
                    {
                        using (DataSet ds = new DataSet("DsFicheCompte"))
                        {
                            if (index == 1)
                            {
                                adapter.Fill(ds, "DsFicheCompte");

                                reportViewer1.LocalReport.DataSources.Clear();
                                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DsFicheCompte", ds.Tables[0]));
                                reportViewer1.LocalReport.ReportEmbeddedResource = "EasyToGoBq.Reports.RptFicheTransfert.rdlc";
                                reportViewer1.PrinterSettings.DefaultPageSettings.Landscape = false;
                                reportViewer1.RefreshReport();
                            }
                            else if (index == 2)
                            {
                                adapter.Fill(ds, "DsFicheCompte");

                                reportViewer1.LocalReport.DataSources.Clear();
                                reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DsFicheCompte", ds.Tables[0]));
                                reportViewer1.LocalReport.ReportEmbeddedResource = "EasyToGoBq.Reports.RptFicheCompte.rdlc";
                                reportViewer1.PrinterSettings.DefaultPageSettings.Landscape = false;
                                reportViewer1.RefreshReport();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Une erreur s'est produite lors du chargement du rapport. \n ERROR : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}

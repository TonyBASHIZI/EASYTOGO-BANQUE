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
using EasyToGoBq.Classes;
using System.Threading;

namespace EasyToGoBq.Forms
{
    public partial class FormProgress : Form
    {
        public FormProgress()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        

        private void FormProgress_Load(object sender, EventArgs e)
        {
            //Thread thr = new Thread(mythread);
            //thr.Start();

        }
    }
}

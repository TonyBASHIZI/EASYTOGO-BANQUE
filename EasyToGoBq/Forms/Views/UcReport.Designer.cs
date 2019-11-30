namespace EasyToGoBq.Forms.Views
{
    partial class UcReport
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcReport));
            this.GridView = new System.Windows.Forms.DataGridView();
            this.PnlTransfert = new System.Windows.Forms.Panel();
            this.PcbTransfert = new System.Windows.Forms.PictureBox();
            this.LblTransfert = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PnlCompte = new System.Windows.Forms.Panel();
            this.PcbCompte = new System.Windows.Forms.PictureBox();
            this.LblCompte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.PnlTransfert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbTransfert)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.PnlCompte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbCompte)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.AllowUserToOrderColumns = true;
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(138)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.Location = new System.Drawing.Point(3, 16);
            this.GridView.Name = "GridView";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(138)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(138)))), ((int)(((byte)(85)))));
            this.GridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView.Size = new System.Drawing.Size(982, 479);
            this.GridView.TabIndex = 1;
            this.GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellContentClick);
            // 
            // PnlTransfert
            // 
            this.PnlTransfert.BackColor = System.Drawing.Color.White;
            this.PnlTransfert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlTransfert.Controls.Add(this.PcbTransfert);
            this.PnlTransfert.Controls.Add(this.LblTransfert);
            this.PnlTransfert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlTransfert.Location = new System.Drawing.Point(23, 20);
            this.PnlTransfert.Name = "PnlTransfert";
            this.PnlTransfert.Size = new System.Drawing.Size(149, 48);
            this.PnlTransfert.TabIndex = 2;
            // 
            // PcbTransfert
            // 
            this.PcbTransfert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbTransfert.Image = ((System.Drawing.Image)(resources.GetObject("PcbTransfert.Image")));
            this.PcbTransfert.Location = new System.Drawing.Point(12, 21);
            this.PcbTransfert.Name = "PcbTransfert";
            this.PcbTransfert.Size = new System.Drawing.Size(126, 23);
            this.PcbTransfert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbTransfert.TabIndex = 1;
            this.PcbTransfert.TabStop = false;
            this.PcbTransfert.Click += new System.EventHandler(this.PcbTransfert_Click);
            // 
            // LblTransfert
            // 
            this.LblTransfert.AutoSize = true;
            this.LblTransfert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblTransfert.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTransfert.ForeColor = System.Drawing.Color.Black;
            this.LblTransfert.Location = new System.Drawing.Point(10, 4);
            this.LblTransfert.Name = "LblTransfert";
            this.LblTransfert.Size = new System.Drawing.Size(123, 16);
            this.LblTransfert.TabIndex = 0;
            this.LblTransfert.Text = "FICHE DE TRANFERTS";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.GridView);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(988, 498);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PnlCompte);
            this.groupBox2.Controls.Add(this.PnlTransfert);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(988, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // PnlCompte
            // 
            this.PnlCompte.BackColor = System.Drawing.Color.White;
            this.PnlCompte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlCompte.Controls.Add(this.PcbCompte);
            this.PnlCompte.Controls.Add(this.LblCompte);
            this.PnlCompte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PnlCompte.Location = new System.Drawing.Point(206, 21);
            this.PnlCompte.Name = "PnlCompte";
            this.PnlCompte.Size = new System.Drawing.Size(154, 48);
            this.PnlCompte.TabIndex = 3;
            // 
            // PcbCompte
            // 
            this.PcbCompte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PcbCompte.Image = ((System.Drawing.Image)(resources.GetObject("PcbCompte.Image")));
            this.PcbCompte.Location = new System.Drawing.Point(12, 21);
            this.PcbCompte.Name = "PcbCompte";
            this.PcbCompte.Size = new System.Drawing.Size(126, 23);
            this.PcbCompte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbCompte.TabIndex = 3;
            this.PcbCompte.TabStop = false;
            this.PcbCompte.Click += new System.EventHandler(this.PcbCompte_Click);
            // 
            // LblCompte
            // 
            this.LblCompte.AutoSize = true;
            this.LblCompte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblCompte.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCompte.ForeColor = System.Drawing.Color.Black;
            this.LblCompte.Location = new System.Drawing.Point(15, 4);
            this.LblCompte.Name = "LblCompte";
            this.LblCompte.Size = new System.Drawing.Size(116, 16);
            this.LblCompte.TabIndex = 2;
            this.LblCompte.Text = "FICHE DE COMPTES";
            // 
            // UcReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "UcReport";
            this.Size = new System.Drawing.Size(988, 578);
            this.Load += new System.EventHandler(this.UcReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.PnlTransfert.ResumeLayout(false);
            this.PnlTransfert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbTransfert)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.PnlCompte.ResumeLayout(false);
            this.PnlCompte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PcbCompte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Panel PnlTransfert;
        private System.Windows.Forms.PictureBox PcbTransfert;
        private System.Windows.Forms.Label LblTransfert;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel PnlCompte;
        private System.Windows.Forms.PictureBox PcbCompte;
        private System.Windows.Forms.Label LblCompte;
    }
}

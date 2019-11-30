namespace EasyToGoBq.Forms
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TblLayoutPanelMenu = new System.Windows.Forms.Panel();
            this.LblConnection = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.LblRecharge = new System.Windows.Forms.Button();
            this.Report = new System.Windows.Forms.Button();
            this.LblDashbord = new System.Windows.Forms.Button();
            this.PnlMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.TblLayoutPanelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TblLayoutPanelMenu
            // 
            this.TblLayoutPanelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TblLayoutPanelMenu.Controls.Add(this.LblConnection);
            this.TblLayoutPanelMenu.Controls.Add(this.Settings);
            this.TblLayoutPanelMenu.Controls.Add(this.LblRecharge);
            this.TblLayoutPanelMenu.Controls.Add(this.Report);
            this.TblLayoutPanelMenu.Controls.Add(this.LblDashbord);
            this.TblLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TblLayoutPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.TblLayoutPanelMenu.Name = "TblLayoutPanelMenu";
            this.TblLayoutPanelMenu.Size = new System.Drawing.Size(1354, 56);
            this.TblLayoutPanelMenu.TabIndex = 0;
            this.TblLayoutPanelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LblConnection
            // 
            this.LblConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblConnection.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblConnection.Location = new System.Drawing.Point(1205, 10);
            this.LblConnection.Name = "LblConnection";
            this.LblConnection.Size = new System.Drawing.Size(135, 33);
            this.LblConnection.TabIndex = 4;
            this.LblConnection.Text = "Connexion";
            this.LblConnection.UseVisualStyleBackColor = true;
            this.LblConnection.Click += new System.EventHandler(this.LblConnection_Click);
            // 
            // Settings
            // 
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(629, 4);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(167, 45);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Paramètre";
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            this.Settings.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.Settings.MouseLeave += new System.EventHandler(this.LblDashbord_MouseLeave);
            // 
            // LblRecharge
            // 
            this.LblRecharge.FlatAppearance.BorderSize = 0;
            this.LblRecharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblRecharge.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecharge.Image = ((System.Drawing.Image)(resources.GetObject("LblRecharge.Image")));
            this.LblRecharge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblRecharge.Location = new System.Drawing.Point(425, 13);
            this.LblRecharge.Name = "LblRecharge";
            this.LblRecharge.Size = new System.Drawing.Size(146, 27);
            this.LblRecharge.TabIndex = 2;
            this.LblRecharge.Text = "Recharge";
            this.LblRecharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblRecharge.UseVisualStyleBackColor = true;
            this.LblRecharge.Click += new System.EventHandler(this.LblRecharge_Click);
            this.LblRecharge.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.LblRecharge.MouseLeave += new System.EventHandler(this.LblDashbord_MouseLeave);
            // 
            // Report
            // 
            this.Report.FlatAppearance.BorderSize = 0;
            this.Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Report.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report.Image = ((System.Drawing.Image)(resources.GetObject("Report.Image")));
            this.Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Report.Location = new System.Drawing.Point(230, 6);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(167, 40);
            this.Report.TabIndex = 1;
            this.Report.Text = "Document";
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Click += new System.EventHandler(this.Report_Click);
            this.Report.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.Report.MouseLeave += new System.EventHandler(this.LblDashbord_MouseLeave);
            // 
            // LblDashbord
            // 
            this.LblDashbord.FlatAppearance.BorderSize = 0;
            this.LblDashbord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblDashbord.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDashbord.Image = ((System.Drawing.Image)(resources.GetObject("LblDashbord.Image")));
            this.LblDashbord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblDashbord.Location = new System.Drawing.Point(10, 7);
            this.LblDashbord.Name = "LblDashbord";
            this.LblDashbord.Size = new System.Drawing.Size(178, 40);
            this.LblDashbord.TabIndex = 0;
            this.LblDashbord.Text = "Tableau de bord";
            this.LblDashbord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblDashbord.UseVisualStyleBackColor = true;
            this.LblDashbord.Click += new System.EventHandler(this.LblDashbord_Click);
            this.LblDashbord.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.LblDashbord.MouseLeave += new System.EventHandler(this.LblDashbord_MouseLeave);
            // 
            // PnlMain
            // 
            this.PnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMain.Location = new System.Drawing.Point(0, 56);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(1354, 573);
            this.PnlMain.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.LblStatus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 619);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1354, 22);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenue :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.BackColor = System.Drawing.Color.Transparent;
            this.LblStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.ForeColor = System.Drawing.Color.White;
            this.LblStatus.Location = new System.Drawing.Point(90, 2);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(11, 17);
            this.LblStatus.TabIndex = 0;
            this.LblStatus.Text = ".";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 641);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PnlMain);
            this.Controls.Add(this.TblLayoutPanelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy To Go Banque";
            this.Load += new System.EventHandler(this.FormMain_Load_1);
            this.TblLayoutPanelMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TblLayoutPanelMenu;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Button LblDashbord;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button LblRecharge;
        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button LblConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblStatus;
    }
}
namespace HPress
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.picMain = new System.Windows.Forms.PictureBox();
            this.btnClientsImports = new DevExpress.XtraEditors.SimpleButton();
            this.btnMain = new DevExpress.XtraEditors.SimpleButton();
            this.btnDebits = new DevExpress.XtraEditors.SimpleButton();
            this.btnDollar = new DevExpress.XtraEditors.SimpleButton();
            this.btnExport = new DevExpress.XtraEditors.SimpleButton();
            this.btnReports = new DevExpress.XtraEditors.SimpleButton();
            this.btnClients = new DevExpress.XtraEditors.SimpleButton();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.pnlMain.Controls.Add(this.picMain);
            this.pnlMain.Controls.Add(this.btnClientsImports);
            this.pnlMain.Controls.Add(this.btnMain);
            this.pnlMain.Controls.Add(this.btnDebits);
            this.pnlMain.Controls.Add(this.btnDollar);
            this.pnlMain.Controls.Add(this.btnExport);
            this.pnlMain.Controls.Add(this.btnReports);
            this.pnlMain.Controls.Add(this.btnClients);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(301, 532);
            this.pnlMain.TabIndex = 1;
            // 
            // picMain
            // 
            this.picMain.Location = new System.Drawing.Point(3, 50);
            this.picMain.Name = "picMain";
            this.picMain.Size = new System.Drawing.Size(295, 170);
            this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMain.TabIndex = 9;
            this.picMain.TabStop = false;
            // 
            // btnClientsImports
            // 
            this.btnClientsImports.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.btnClientsImports.Appearance.Options.UseForeColor = true;
            this.btnClientsImports.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClientsImports.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClientsImports.ImageOptions.Image")));
            this.btnClientsImports.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnClientsImports.Location = new System.Drawing.Point(0, 268);
            this.btnClientsImports.Name = "btnClientsImports";
            this.btnClientsImports.Size = new System.Drawing.Size(301, 44);
            this.btnClientsImports.TabIndex = 8;
            this.btnClientsImports.Text = "العملاء و الموردين";
            this.btnClientsImports.Click += new System.EventHandler(this.btnClientsImports_Click);
            // 
            // btnMain
            // 
            this.btnMain.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.btnMain.Appearance.Options.UseForeColor = true;
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMain.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMain.ImageOptions.Image")));
            this.btnMain.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnMain.Location = new System.Drawing.Point(0, 0);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(301, 44);
            this.btnMain.TabIndex = 7;
            this.btnMain.Text = "الرئيسية";
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnDebits
            // 
            this.btnDebits.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.btnDebits.Appearance.Options.UseForeColor = true;
            this.btnDebits.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDebits.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDebits.ImageOptions.Image")));
            this.btnDebits.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnDebits.Location = new System.Drawing.Point(0, 312);
            this.btnDebits.Name = "btnDebits";
            this.btnDebits.Size = new System.Drawing.Size(301, 44);
            this.btnDebits.TabIndex = 6;
            this.btnDebits.Text = "الديون";
            this.btnDebits.Click += new System.EventHandler(this.btnDebits_Click);
            // 
            // btnDollar
            // 
            this.btnDollar.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.btnDollar.Appearance.Options.UseForeColor = true;
            this.btnDollar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDollar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDollar.ImageOptions.Image")));
            this.btnDollar.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnDollar.Location = new System.Drawing.Point(0, 356);
            this.btnDollar.Name = "btnDollar";
            this.btnDollar.Size = new System.Drawing.Size(301, 44);
            this.btnDollar.TabIndex = 5;
            this.btnDollar.Text = "الدولار";
            this.btnDollar.Click += new System.EventHandler(this.btnDollar_Click);
            // 
            // btnExport
            // 
            this.btnExport.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.btnExport.Appearance.Options.UseForeColor = true;
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.ImageOptions.Image")));
            this.btnExport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnExport.Location = new System.Drawing.Point(0, 400);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(301, 44);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "الصادرات";
            this.btnExport.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // btnReports
            // 
            this.btnReports.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.btnReports.Appearance.Options.UseForeColor = true;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReports.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.ImageOptions.Image")));
            this.btnReports.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnReports.Location = new System.Drawing.Point(0, 444);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(301, 44);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "تقارير";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnClients
            // 
            this.btnClients.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.btnClients.Appearance.Options.UseForeColor = true;
            this.btnClients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClients.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClients.ImageOptions.Image")));
            this.btnClients.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnClients.Location = new System.Drawing.Point(0, 488);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(301, 44);
            this.btnClients.TabIndex = 1;
            this.btnClients.Text = "الموارد البشرية";
            this.btnClients.Click += new System.EventHandler(this.btnClientAdd_Click);
            // 
            // Home
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(45)))), ((int)(((byte)(43)))));
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 532);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private DevExpress.XtraEditors.SimpleButton btnClients;
        private DevExpress.XtraEditors.SimpleButton btnReports;
        private DevExpress.XtraEditors.SimpleButton btnExport;
        private DevExpress.XtraEditors.SimpleButton btnDollar;
        private DevExpress.XtraEditors.SimpleButton btnDebits;
        private DevExpress.XtraEditors.SimpleButton btnMain;
        private DevExpress.XtraEditors.SimpleButton btnClientsImports;
        private System.Windows.Forms.PictureBox picMain;
    }
}
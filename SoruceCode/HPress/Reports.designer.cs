namespace HPress
{
    partial class Reports
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.cmbDelegates = new System.Windows.Forms.ComboBox();
            this.grpMain = new DevExpress.XtraEditors.GroupControl();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.grpPayMethod = new DevExpress.XtraEditors.RadioGroup();
            this.grpCurrency = new DevExpress.XtraEditors.RadioGroup();
            this.grpCash = new DevExpress.XtraEditors.RadioGroup();
            this.grpImport = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtNotCash = new System.Windows.Forms.TextBox();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.txtExport = new System.Windows.Forms.TextBox();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.txtRemaining = new System.Windows.Forms.TextBox();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.txtDebit = new System.Windows.Forms.TextBox();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClientPay = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnBillReport = new System.Windows.Forms.Button();
            this.btnDebitsClients = new System.Windows.Forms.Button();
            this.btnDailyReport = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnDebitsSell = new System.Windows.Forms.Button();
            this.btnDelegate = new System.Windows.Forms.Button();
            this.btnEmployeeDebits = new System.Windows.Forms.Button();
            this.btnCaseValue = new System.Windows.Forms.Button();
            this.btnDelegates = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).BeginInit();
            this.grpMain.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpPayMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpImport.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClients
            // 
            this.cmbClients.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbClients.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(3, 71);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(376, 27);
            this.cmbClients.TabIndex = 3;
            this.cmbClients.Text = "الكل";
            this.toolTip1.SetToolTip(this.cmbClients, "العملاء");
            this.cmbClients.Visible = false;
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "dd/MM/yyyy";
            this.dateTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(3, 44);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(376, 27);
            this.dateTo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dateTo, "تاريخ الى");
            this.dateTo.Visible = false;
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "dd/MM/yyyy";
            this.dateFrom.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateFrom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(3, 17);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(376, 27);
            this.dateFrom.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dateFrom, "تاريخ من");
            this.dateFrom.Visible = false;
            // 
            // cmbDelegates
            // 
            this.cmbDelegates.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbDelegates.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDelegates.FormattingEnabled = true;
            this.cmbDelegates.Location = new System.Drawing.Point(3, 218);
            this.cmbDelegates.Name = "cmbDelegates";
            this.cmbDelegates.Size = new System.Drawing.Size(376, 27);
            this.cmbDelegates.TabIndex = 10;
            this.cmbDelegates.Text = "الكل";
            this.toolTip1.SetToolTip(this.cmbDelegates, "المندوب");
            this.cmbDelegates.Visible = false;
            // 
            // grpMain
            // 
            this.grpMain.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grpMain.CaptionImageOptions.Image")));
            this.grpMain.Controls.Add(this.grpInfo);
            this.grpMain.Controls.Add(this.groupControl5);
            this.grpMain.Controls.Add(this.groupControl6);
            this.grpMain.Controls.Add(this.groupControl7);
            this.grpMain.Controls.Add(this.groupControl8);
            this.grpMain.Controls.Add(this.groupControl4);
            this.grpMain.Controls.Add(this.groupControl3);
            this.grpMain.Controls.Add(this.groupControl2);
            this.grpMain.Controls.Add(this.groupControl1);
            this.grpMain.Controls.Add(this.groupBox1);
            this.grpMain.Controls.Add(this.btnSearch);
            this.grpMain.Controls.Add(this.btnPrint);
            this.grpMain.Controls.Add(this.dgvResults);
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMain.Location = new System.Drawing.Point(0, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(1010, 871);
            this.grpMain.TabIndex = 33;
            this.grpMain.Text = "التقارير";
            // 
            // grpInfo
            // 
            this.grpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfo.Controls.Add(this.cmbDelegates);
            this.grpInfo.Controls.Add(this.grpPayMethod);
            this.grpInfo.Controls.Add(this.grpCurrency);
            this.grpInfo.Controls.Add(this.grpCash);
            this.grpInfo.Controls.Add(this.grpImport);
            this.grpInfo.Controls.Add(this.cmbClients);
            this.grpInfo.Controls.Add(this.dateTo);
            this.grpInfo.Controls.Add(this.dateFrom);
            this.grpInfo.ForeColor = System.Drawing.Color.White;
            this.grpInfo.Location = new System.Drawing.Point(609, 549);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(382, 259);
            this.grpInfo.TabIndex = 24;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "المعلومات";
            // 
            // grpPayMethod
            // 
            this.grpPayMethod.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPayMethod.EditValue = 0;
            this.grpPayMethod.Location = new System.Drawing.Point(3, 188);
            this.grpPayMethod.Name = "grpPayMethod";
            this.grpPayMethod.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "قوائم"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "دفعات")});
            this.grpPayMethod.Size = new System.Drawing.Size(376, 30);
            this.grpPayMethod.TabIndex = 9;
            this.grpPayMethod.Visible = false;
            // 
            // grpCurrency
            // 
            this.grpCurrency.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCurrency.EditValue = 2;
            this.grpCurrency.Location = new System.Drawing.Point(3, 158);
            this.grpCurrency.Name = "grpCurrency";
            this.grpCurrency.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "دولار"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "دينار"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "الكل")});
            this.grpCurrency.Size = new System.Drawing.Size(376, 30);
            this.grpCurrency.TabIndex = 8;
            this.grpCurrency.Visible = false;
            // 
            // grpCash
            // 
            this.grpCash.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCash.EditValue = 2;
            this.grpCash.Location = new System.Drawing.Point(3, 128);
            this.grpCash.Name = "grpCash";
            this.grpCash.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "نقد"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "أجل"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "الكل")});
            this.grpCash.Size = new System.Drawing.Size(376, 30);
            this.grpCash.TabIndex = 7;
            this.grpCash.Visible = false;
            // 
            // grpImport
            // 
            this.grpImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpImport.EditValue = 2;
            this.grpImport.Location = new System.Drawing.Point(3, 98);
            this.grpImport.Name = "grpImport";
            this.grpImport.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "صادر"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "وارد"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "الكل")});
            this.grpImport.Size = new System.Drawing.Size(376, 30);
            this.grpImport.TabIndex = 6;
            this.grpImport.Visible = false;
            // 
            // groupControl5
            // 
            this.groupControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl5.Controls.Add(this.txtNotCash);
            this.groupControl5.Location = new System.Drawing.Point(10, 625);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(200, 54);
            this.groupControl5.TabIndex = 23;
            this.groupControl5.Text = "أجل";
            // 
            // txtNotCash
            // 
            this.txtNotCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotCash.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtNotCash.Location = new System.Drawing.Point(2, 21);
            this.txtNotCash.Name = "txtNotCash";
            this.txtNotCash.ReadOnly = true;
            this.txtNotCash.Size = new System.Drawing.Size(196, 30);
            this.txtNotCash.TabIndex = 0;
            this.txtNotCash.Text = "0";
            this.txtNotCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupControl6
            // 
            this.groupControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl6.Controls.Add(this.txtExport);
            this.groupControl6.Location = new System.Drawing.Point(12, 685);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(200, 54);
            this.groupControl6.TabIndex = 22;
            this.groupControl6.Text = "صادر";
            // 
            // txtExport
            // 
            this.txtExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtExport.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtExport.Location = new System.Drawing.Point(2, 21);
            this.txtExport.Name = "txtExport";
            this.txtExport.ReadOnly = true;
            this.txtExport.Size = new System.Drawing.Size(196, 30);
            this.txtExport.TabIndex = 0;
            this.txtExport.Text = "0";
            this.txtExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupControl7
            // 
            this.groupControl7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl7.Controls.Add(this.txtRemaining);
            this.groupControl7.Location = new System.Drawing.Point(12, 805);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(200, 54);
            this.groupControl7.TabIndex = 21;
            this.groupControl7.Text = "متبقي";
            // 
            // txtRemaining
            // 
            this.txtRemaining.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemaining.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemaining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtRemaining.Location = new System.Drawing.Point(2, 21);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.ReadOnly = true;
            this.txtRemaining.Size = new System.Drawing.Size(196, 30);
            this.txtRemaining.TabIndex = 0;
            this.txtRemaining.Text = "0";
            this.txtRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupControl8
            // 
            this.groupControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl8.Controls.Add(this.txtDebit);
            this.groupControl8.Location = new System.Drawing.Point(12, 745);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(200, 54);
            this.groupControl8.TabIndex = 20;
            this.groupControl8.Text = "قرض";
            // 
            // txtDebit
            // 
            this.txtDebit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDebit.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDebit.Location = new System.Drawing.Point(2, 21);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.ReadOnly = true;
            this.txtDebit.Size = new System.Drawing.Size(196, 30);
            this.txtDebit.TabIndex = 0;
            this.txtDebit.Text = "0";
            this.txtDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Controls.Add(this.txtCash);
            this.groupControl4.Location = new System.Drawing.Point(397, 625);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(200, 54);
            this.groupControl4.TabIndex = 19;
            this.groupControl4.Text = "نقد";
            // 
            // txtCash
            // 
            this.txtCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCash.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCash.Location = new System.Drawing.Point(2, 21);
            this.txtCash.Name = "txtCash";
            this.txtCash.ReadOnly = true;
            this.txtCash.Size = new System.Drawing.Size(196, 30);
            this.txtCash.TabIndex = 0;
            this.txtCash.Text = "0";
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.txtBalance);
            this.groupControl3.Location = new System.Drawing.Point(397, 682);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(200, 54);
            this.groupControl3.TabIndex = 18;
            this.groupControl3.Text = "رصيد";
            // 
            // txtBalance
            // 
            this.txtBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBalance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBalance.Location = new System.Drawing.Point(2, 21);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(196, 30);
            this.txtBalance.TabIndex = 0;
            this.txtBalance.Text = "0";
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.txtTotal);
            this.groupControl2.Location = new System.Drawing.Point(397, 802);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(200, 54);
            this.groupControl2.TabIndex = 17;
            this.groupControl2.Text = "محصلة";
            // 
            // txtTotal
            // 
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTotal.Location = new System.Drawing.Point(2, 21);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(196, 30);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.txtPay);
            this.groupControl1.Location = new System.Drawing.Point(397, 742);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 54);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "تسديد";
            // 
            // txtPay
            // 
            this.txtPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPay.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPay.Location = new System.Drawing.Point(2, 21);
            this.txtPay.Name = "txtPay";
            this.txtPay.ReadOnly = true;
            this.txtPay.Size = new System.Drawing.Size(196, 30);
            this.txtPay.TabIndex = 0;
            this.txtPay.Text = "0";
            this.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnClientPay);
            this.groupBox1.Controls.Add(this.btnProducts);
            this.groupBox1.Controls.Add(this.btnBills);
            this.groupBox1.Controls.Add(this.btnDate);
            this.groupBox1.Controls.Add(this.btnBillReport);
            this.groupBox1.Controls.Add(this.btnDebitsClients);
            this.groupBox1.Controls.Add(this.btnDailyReport);
            this.groupBox1.Controls.Add(this.btnClient);
            this.groupBox1.Controls.Add(this.btnDebitsSell);
            this.groupBox1.Controls.Add(this.btnDelegate);
            this.groupBox1.Controls.Add(this.btnEmployeeDebits);
            this.groupBox1.Controls.Add(this.btnCaseValue);
            this.groupBox1.Controls.Add(this.btnDelegates);
            this.groupBox1.Controls.Add(this.btnEmployee);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(611, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 396);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاصناف";
            // 
            // btnClientPay
            // 
            this.btnClientPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientPay.Enabled = false;
            this.btnClientPay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientPay.ForeColor = System.Drawing.Color.Black;
            this.btnClientPay.Location = new System.Drawing.Point(194, 295);
            this.btnClientPay.Name = "btnClientPay";
            this.btnClientPay.Size = new System.Drawing.Size(180, 40);
            this.btnClientPay.TabIndex = 15;
            this.btnClientPay.Text = "تسديد العميل";
            this.btnClientPay.UseVisualStyleBackColor = true;
            this.btnClientPay.Click += new System.EventHandler(this.btnClientPay_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProducts.Enabled = false;
            this.btnProducts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.Black;
            this.btnProducts.Location = new System.Drawing.Point(6, 65);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(180, 40);
            this.btnProducts.TabIndex = 14;
            this.btnProducts.Text = "مواد";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnBills
            // 
            this.btnBills.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBills.Enabled = false;
            this.btnBills.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBills.ForeColor = System.Drawing.Color.Black;
            this.btnBills.Location = new System.Drawing.Point(194, 65);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(180, 40);
            this.btnBills.TabIndex = 13;
            this.btnBills.Text = "قوائم";
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnDate
            // 
            this.btnDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDate.Enabled = false;
            this.btnDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDate.ForeColor = System.Drawing.Color.Black;
            this.btnDate.Location = new System.Drawing.Point(194, 111);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(178, 40);
            this.btnDate.TabIndex = 12;
            this.btnDate.Tag = "if";
            this.btnDate.Text = "التاريخ";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnBillReport
            // 
            this.btnBillReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBillReport.Enabled = false;
            this.btnBillReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillReport.ForeColor = System.Drawing.Color.Black;
            this.btnBillReport.Location = new System.Drawing.Point(6, 19);
            this.btnBillReport.Name = "btnBillReport";
            this.btnBillReport.Size = new System.Drawing.Size(180, 40);
            this.btnBillReport.TabIndex = 11;
            this.btnBillReport.Text = "قوائم بشكل عام";
            this.btnBillReport.UseVisualStyleBackColor = true;
            this.btnBillReport.Click += new System.EventHandler(this.btnBillReport_Click);
            // 
            // btnDebitsClients
            // 
            this.btnDebitsClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDebitsClients.Enabled = false;
            this.btnDebitsClients.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebitsClients.ForeColor = System.Drawing.Color.Black;
            this.btnDebitsClients.Location = new System.Drawing.Point(194, 203);
            this.btnDebitsClients.Name = "btnDebitsClients";
            this.btnDebitsClients.Size = new System.Drawing.Size(180, 40);
            this.btnDebitsClients.TabIndex = 3;
            this.btnDebitsClients.Text = "ديون العملاء";
            this.btnDebitsClients.UseVisualStyleBackColor = true;
            this.btnDebitsClients.Click += new System.EventHandler(this.btnDebitsClients_Click);
            // 
            // btnDailyReport
            // 
            this.btnDailyReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDailyReport.Enabled = false;
            this.btnDailyReport.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyReport.ForeColor = System.Drawing.Color.Black;
            this.btnDailyReport.Location = new System.Drawing.Point(194, 19);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new System.Drawing.Size(180, 40);
            this.btnDailyReport.TabIndex = 1;
            this.btnDailyReport.Text = "الوارد اليومي";
            this.btnDailyReport.UseVisualStyleBackColor = true;
            this.btnDailyReport.Click += new System.EventHandler(this.btnDailyReport_Click);
            // 
            // btnClient
            // 
            this.btnClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClient.Enabled = false;
            this.btnClient.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.Color.Black;
            this.btnClient.Location = new System.Drawing.Point(194, 249);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(180, 40);
            this.btnClient.TabIndex = 6;
            this.btnClient.Text = "العميل";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnDebitsSell
            // 
            this.btnDebitsSell.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDebitsSell.Enabled = false;
            this.btnDebitsSell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebitsSell.ForeColor = System.Drawing.Color.Black;
            this.btnDebitsSell.Location = new System.Drawing.Point(6, 157);
            this.btnDebitsSell.Name = "btnDebitsSell";
            this.btnDebitsSell.Size = new System.Drawing.Size(368, 40);
            this.btnDebitsSell.TabIndex = 2;
            this.btnDebitsSell.Text = "الديون للبيع النقدي";
            this.btnDebitsSell.UseVisualStyleBackColor = true;
            this.btnDebitsSell.Click += new System.EventHandler(this.btnDebitsSell_Click);
            // 
            // btnDelegate
            // 
            this.btnDelegate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelegate.Enabled = false;
            this.btnDelegate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelegate.ForeColor = System.Drawing.Color.Black;
            this.btnDelegate.Location = new System.Drawing.Point(6, 341);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Size = new System.Drawing.Size(180, 40);
            this.btnDelegate.TabIndex = 5;
            this.btnDelegate.Text = "المندوب";
            this.btnDelegate.UseVisualStyleBackColor = true;
            this.btnDelegate.Click += new System.EventHandler(this.btnDelegate_Click);
            // 
            // btnEmployeeDebits
            // 
            this.btnEmployeeDebits.Enabled = false;
            this.btnEmployeeDebits.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeDebits.ForeColor = System.Drawing.Color.Black;
            this.btnEmployeeDebits.Location = new System.Drawing.Point(6, 203);
            this.btnEmployeeDebits.Name = "btnEmployeeDebits";
            this.btnEmployeeDebits.Size = new System.Drawing.Size(180, 40);
            this.btnEmployeeDebits.TabIndex = 7;
            this.btnEmployeeDebits.Text = "دين الموظفين";
            this.btnEmployeeDebits.UseVisualStyleBackColor = true;
            this.btnEmployeeDebits.Click += new System.EventHandler(this.btnEmployeeDebits_Click);
            // 
            // btnCaseValue
            // 
            this.btnCaseValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaseValue.Enabled = false;
            this.btnCaseValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaseValue.ForeColor = System.Drawing.Color.Black;
            this.btnCaseValue.Location = new System.Drawing.Point(6, 111);
            this.btnCaseValue.Name = "btnCaseValue";
            this.btnCaseValue.Size = new System.Drawing.Size(180, 40);
            this.btnCaseValue.TabIndex = 9;
            this.btnCaseValue.Tag = "if";
            this.btnCaseValue.Text = "الصندوق";
            this.btnCaseValue.UseVisualStyleBackColor = true;
            this.btnCaseValue.Click += new System.EventHandler(this.btnCaseValue_Click);
            // 
            // btnDelegates
            // 
            this.btnDelegates.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelegates.Enabled = false;
            this.btnDelegates.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelegates.ForeColor = System.Drawing.Color.Black;
            this.btnDelegates.Location = new System.Drawing.Point(194, 341);
            this.btnDelegates.Name = "btnDelegates";
            this.btnDelegates.Size = new System.Drawing.Size(180, 40);
            this.btnDelegates.TabIndex = 4;
            this.btnDelegates.Text = "المندوبين";
            this.btnDelegates.UseVisualStyleBackColor = true;
            this.btnDelegates.Click += new System.EventHandler(this.btnDelegates_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Enabled = false;
            this.btnEmployee.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnEmployee.Location = new System.Drawing.Point(6, 249);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(180, 40);
            this.btnEmployee.TabIndex = 8;
            this.btnEmployee.Text = "الموظف";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(609, 814);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(382, 45);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrint.Location = new System.Drawing.Point(218, 638);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(171, 218);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(12, 36);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvResults.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.dgvResults.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvResults.RowTemplate.Height = 25;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(585, 583);
            this.dgvResults.TabIndex = 11;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 871);
            this.ControlBox = false;
            this.Controls.Add(this.grpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).EndInit();
            this.grpMain.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpPayMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCash.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpImport.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.groupControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            this.groupControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDailyReport;
        private System.Windows.Forms.Button btnDebitsSell;
        private System.Windows.Forms.Button btnDebitsClients;
        private System.Windows.Forms.Button btnDelegates;
        private System.Windows.Forms.Button btnDelegate;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnEmployeeDebits;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCaseValue;
        private System.Windows.Forms.DataGridView dgvResults;
        private DevExpress.XtraEditors.GroupControl grpMain;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.TextBox txtNotCash;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private System.Windows.Forms.TextBox txtExport;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private System.Windows.Forms.TextBox txtRemaining;
        private DevExpress.XtraEditors.GroupControl groupControl8;
        private System.Windows.Forms.TextBox txtDebit;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.TextBox txtCash;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.TextBox txtBalance;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox txtTotal;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnBillReport;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnBills;
        private DevExpress.XtraEditors.RadioGroup grpCash;
        private DevExpress.XtraEditors.RadioGroup grpImport;
        private System.Windows.Forms.Button btnClientPay;
        private DevExpress.XtraEditors.RadioGroup grpCurrency;
        private DevExpress.XtraEditors.RadioGroup grpPayMethod;
        private System.Windows.Forms.ComboBox cmbDelegates;
    }
}
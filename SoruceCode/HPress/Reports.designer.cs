using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

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
            this.components = new Container();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Reports));
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            this.toolTip1 = new ToolTip(this.components);
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.dateTo = new DateTimePicker();
            this.dateFrom = new DateTimePicker();
            this.cmbDelegates = new System.Windows.Forms.ComboBox();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.grpMain = new GroupControl();
            this.btnPrint = new SimpleButton();
            this.grpInfo = new GroupBox();
            this.grpPayMethod = new RadioGroup();
            this.grpCurrency = new RadioGroup();
            this.grpCash = new RadioGroup();
            this.grpImport = new RadioGroup();
            this.groupBox1 = new GroupBox();
            this.btnClientPay = new Button();
            this.btnProducts = new Button();
            this.btnBills = new Button();
            this.btnDate = new Button();
            this.btnBillReport = new Button();
            this.btnDebitsClients = new Button();
            this.btnDailyReport = new Button();
            this.btnClient = new Button();
            this.btnDebitsSell = new Button();
            this.btnDelegate = new Button();
            this.btnEmployeeDebits = new Button();
            this.btnCaseValue = new Button();
            this.btnDelegates = new Button();
            this.btnEmployee = new Button();
            this.btnSearch = new SimpleButton();
            this.dgvResults = new DataGridView();
            this.groupControl5 = new GroupControl();
            this.txtNotCash = new TextBox();
            this.groupControl6 = new GroupControl();
            this.txtExport = new TextBox();
            this.groupControl7 = new GroupControl();
            this.txtRemaining = new TextBox();
            this.groupControl8 = new GroupControl();
            this.txtDebit = new TextBox();
            this.groupControl4 = new GroupControl();
            this.txtCash = new TextBox();
            this.groupControl3 = new GroupControl();
            this.txtBalance = new TextBox();
            this.groupControl2 = new GroupControl();
            this.txtTotal = new TextBox();
            this.groupControl1 = new GroupControl();
            this.txtPay = new TextBox();
            ((ISupportInitialize)this.grpMain).BeginInit();
            this.grpMain.SuspendLayout();
            this.grpInfo.SuspendLayout();
            ((ISupportInitialize)this.grpPayMethod.Properties).BeginInit();
            ((ISupportInitialize)this.grpCurrency.Properties).BeginInit();
            ((ISupportInitialize)this.grpCash.Properties).BeginInit();
            ((ISupportInitialize)this.grpImport.Properties).BeginInit();
            this.groupBox1.SuspendLayout();
            ((ISupportInitialize)this.dgvResults).BeginInit();
            ((ISupportInitialize)this.groupControl5).BeginInit();
            this.groupControl5.SuspendLayout();
            ((ISupportInitialize)this.groupControl6).BeginInit();
            this.groupControl6.SuspendLayout();
            ((ISupportInitialize)this.groupControl7).BeginInit();
            this.groupControl7.SuspendLayout();
            ((ISupportInitialize)this.groupControl8).BeginInit();
            this.groupControl8.SuspendLayout();
            ((ISupportInitialize)this.groupControl4).BeginInit();
            this.groupControl4.SuspendLayout();
            ((ISupportInitialize)this.groupControl3).BeginInit();
            this.groupControl3.SuspendLayout();
            ((ISupportInitialize)this.groupControl2).BeginInit();
            this.groupControl2.SuspendLayout();
            ((ISupportInitialize)this.groupControl1).BeginInit();
            this.groupControl1.SuspendLayout();
            base.SuspendLayout();
            this.cmbClients.Dock = DockStyle.Top;
            this.cmbClients.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new Point(3, 70);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new Size(376, 27);
            this.cmbClients.TabIndex = 3;
            this.cmbClients.Text = "الكل";
            this.toolTip1.SetToolTip(this.cmbClients, "العملاء");
            this.cmbClients.Visible = false;
            this.dateTo.CustomFormat = "dd/MM/yyyy";
            this.dateTo.Dock = DockStyle.Top;
            this.dateTo.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTo.Format = DateTimePickerFormat.Custom;
            this.dateTo.Location = new Point(3, 43);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new Size(376, 27);
            this.dateTo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dateTo, "تاريخ الى");
            this.dateTo.Visible = false;
            this.dateFrom.CustomFormat = "dd/MM/yyyy";
            this.dateFrom.Dock = DockStyle.Top;
            this.dateFrom.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateFrom.Format = DateTimePickerFormat.Custom;
            this.dateFrom.Location = new Point(3, 16);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new Size(376, 27);
            this.dateFrom.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dateFrom, "تاريخ من");
            this.dateFrom.Visible = false;
            this.cmbDelegates.Dock = DockStyle.Top;
            this.cmbDelegates.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbDelegates.FormattingEnabled = true;
            this.cmbDelegates.Location = new Point(3, 217);
            this.cmbDelegates.Name = "cmbDelegates";
            this.cmbDelegates.Size = new Size(376, 27);
            this.cmbDelegates.TabIndex = 10;
            this.cmbDelegates.Text = "الكل";
            this.toolTip1.SetToolTip(this.cmbDelegates, "المندوب");
            this.cmbDelegates.Visible = false;
            this.cmbUsers.Dock = DockStyle.Top;
            this.cmbUsers.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new Point(3, 244);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new Size(376, 27);
            this.cmbUsers.TabIndex = 11;
            this.cmbUsers.Text = "الكل";
            this.toolTip1.SetToolTip(this.cmbUsers, "المستخدم");
            this.cmbUsers.Visible = false;
            this.grpMain.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpMain.CaptionImageOptions.Image");
            this.grpMain.Controls.Add(this.btnPrint);
            this.grpMain.Controls.Add(this.grpInfo);
            this.grpMain.Controls.Add(this.groupBox1);
            this.grpMain.Controls.Add(this.btnSearch);
            this.grpMain.Controls.Add(this.dgvResults);
            this.grpMain.Controls.Add(this.groupControl5);
            this.grpMain.Controls.Add(this.groupControl6);
            this.grpMain.Controls.Add(this.groupControl7);
            this.grpMain.Controls.Add(this.groupControl8);
            this.grpMain.Controls.Add(this.groupControl4);
            this.grpMain.Controls.Add(this.groupControl3);
            this.grpMain.Controls.Add(this.groupControl2);
            this.grpMain.Controls.Add(this.groupControl1);
            this.grpMain.Dock = DockStyle.Fill;
            this.grpMain.Location = new Point(0, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new Size(1010, 788);
            this.grpMain.TabIndex = 33;
            this.grpMain.Text = "التقارير";
            this.btnPrint.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.btnPrint.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnPrint.ImageOptions.Image");
            this.btnPrint.ImageOptions.Location = ImageLocation.MiddleCenter;
            this.btnPrint.Location = new Point(22, 667);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new Size(104, 98);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Click += this.btnPrint_Click;
            this.grpInfo.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.grpInfo.Controls.Add(this.cmbUsers);
            this.grpInfo.Controls.Add(this.cmbDelegates);
            this.grpInfo.Controls.Add(this.grpPayMethod);
            this.grpInfo.Controls.Add(this.grpCurrency);
            this.grpInfo.Controls.Add(this.grpCash);
            this.grpInfo.Controls.Add(this.grpImport);
            this.grpInfo.Controls.Add(this.cmbClients);
            this.grpInfo.Controls.Add(this.dateTo);
            this.grpInfo.Controls.Add(this.dateFrom);
            this.grpInfo.ForeColor = Color.White;
            this.grpInfo.Location = new Point(609, 445);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new Size(382, 280);
            this.grpInfo.TabIndex = 24;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "المعلومات";
            this.grpPayMethod.Dock = DockStyle.Top;
            this.grpPayMethod.EditValue = 0;
            this.grpPayMethod.Location = new Point(3, 187);
            this.grpPayMethod.Name = "grpPayMethod";
            this.grpPayMethod.Properties.Items.AddRange(new RadioGroupItem[2]
            {
            new RadioGroupItem(1, "قوائم"),
            new RadioGroupItem(0, "دفعات")
            });
            this.grpPayMethod.Size = new Size(376, 30);
            this.grpPayMethod.TabIndex = 9;
            this.grpPayMethod.Visible = false;
            this.grpCurrency.Dock = DockStyle.Top;
            this.grpCurrency.EditValue = 2;
            this.grpCurrency.Location = new Point(3, 157);
            this.grpCurrency.Name = "grpCurrency";
            this.grpCurrency.Properties.Items.AddRange(new RadioGroupItem[3]
            {
            new RadioGroupItem(1, "دولار"),
            new RadioGroupItem(0, "دينار"),
            new RadioGroupItem(2, "الكل")
            });
            this.grpCurrency.Size = new Size(376, 30);
            this.grpCurrency.TabIndex = 8;
            this.grpCurrency.Visible = false;
            this.grpCash.Dock = DockStyle.Top;
            this.grpCash.EditValue = 2;
            this.grpCash.Location = new Point(3, 127);
            this.grpCash.Name = "grpCash";
            this.grpCash.Properties.Items.AddRange(new RadioGroupItem[3]
            {
            new RadioGroupItem(1, "نقد"),
            new RadioGroupItem(0, "أجل"),
            new RadioGroupItem(2, "الكل")
            });
            this.grpCash.Size = new Size(376, 30);
            this.grpCash.TabIndex = 7;
            this.grpCash.Visible = false;
            this.grpImport.Dock = DockStyle.Top;
            this.grpImport.EditValue = 2;
            this.grpImport.Location = new Point(3, 97);
            this.grpImport.Name = "grpImport";
            this.grpImport.Properties.Items.AddRange(new RadioGroupItem[3]
            {
            new RadioGroupItem(0, "صادر"),
            new RadioGroupItem(1, "وارد"),
            new RadioGroupItem(2, "الكل")
            });
            this.grpImport.Size = new Size(376, 30);
            this.grpImport.TabIndex = 6;
            this.grpImport.Visible = false;
            this.grpImport.SelectedIndexChanged += this.grpImport_SelectedIndexChanged;
            this.groupBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
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
            this.groupBox1.ForeColor = Color.White;
            this.groupBox1.Location = new Point(611, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(380, 392);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاصناف";
            this.btnClientPay.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnClientPay.Enabled = false;
            this.btnClientPay.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnClientPay.ForeColor = Color.Black;
            this.btnClientPay.Location = new Point(194, 295);
            this.btnClientPay.Name = "btnClientPay";
            this.btnClientPay.Size = new Size(180, 40);
            this.btnClientPay.TabIndex = 15;
            this.btnClientPay.Text = "تسديد العميل";
            this.btnClientPay.UseVisualStyleBackColor = true;
            this.btnClientPay.Click += this.btnClientPay_Click;
            this.btnProducts.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.btnProducts.Enabled = false;
            this.btnProducts.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnProducts.ForeColor = Color.Black;
            this.btnProducts.Location = new Point(6, 65);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new Size(180, 40);
            this.btnProducts.TabIndex = 14;
            this.btnProducts.Text = "مواد";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += this.btnProducts_Click;
            this.btnBills.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.btnBills.Enabled = false;
            this.btnBills.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnBills.ForeColor = Color.Black;
            this.btnBills.Location = new Point(194, 65);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new Size(180, 40);
            this.btnBills.TabIndex = 13;
            this.btnBills.Text = "قوائم";
            this.btnBills.UseVisualStyleBackColor = true;
            this.btnBills.Click += this.btnBills_Click;
            this.btnDate.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.btnDate.Enabled = false;
            this.btnDate.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnDate.ForeColor = Color.Black;
            this.btnDate.Location = new Point(194, 111);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new Size(178, 40);
            this.btnDate.TabIndex = 12;
            this.btnDate.Tag = "if";
            this.btnDate.Text = "التاريخ";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += this.btnDate_Click;
            this.btnBillReport.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.btnBillReport.Enabled = false;
            this.btnBillReport.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnBillReport.ForeColor = Color.Black;
            this.btnBillReport.Location = new Point(6, 19);
            this.btnBillReport.Name = "btnBillReport";
            this.btnBillReport.Size = new Size(180, 40);
            this.btnBillReport.TabIndex = 11;
            this.btnBillReport.Text = "قوائم بشكل عام";
            this.btnBillReport.UseVisualStyleBackColor = true;
            this.btnBillReport.Click += this.btnBillReport_Click;
            this.btnDebitsClients.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnDebitsClients.Enabled = false;
            this.btnDebitsClients.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnDebitsClients.ForeColor = Color.Black;
            this.btnDebitsClients.Location = new Point(194, 203);
            this.btnDebitsClients.Name = "btnDebitsClients";
            this.btnDebitsClients.Size = new Size(180, 40);
            this.btnDebitsClients.TabIndex = 3;
            this.btnDebitsClients.Text = "ديون العملاء";
            this.btnDebitsClients.UseVisualStyleBackColor = true;
            this.btnDebitsClients.Click += this.btnDebitsClients_Click;
            this.btnDailyReport.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.btnDailyReport.Enabled = false;
            this.btnDailyReport.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnDailyReport.ForeColor = Color.Black;
            this.btnDailyReport.Location = new Point(194, 19);
            this.btnDailyReport.Name = "btnDailyReport";
            this.btnDailyReport.Size = new Size(180, 40);
            this.btnDailyReport.TabIndex = 1;
            this.btnDailyReport.Text = "الوارد اليومي";
            this.btnDailyReport.UseVisualStyleBackColor = true;
            this.btnDailyReport.Click += this.btnDailyReport_Click;
            this.btnClient.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnClient.Enabled = false;
            this.btnClient.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnClient.ForeColor = Color.Black;
            this.btnClient.Location = new Point(194, 249);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new Size(180, 40);
            this.btnClient.TabIndex = 6;
            this.btnClient.Text = "العميل";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += this.btnClient_Click;
            this.btnDebitsSell.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.btnDebitsSell.Enabled = false;
            this.btnDebitsSell.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnDebitsSell.ForeColor = Color.Black;
            this.btnDebitsSell.Location = new Point(6, 157);
            this.btnDebitsSell.Name = "btnDebitsSell";
            this.btnDebitsSell.Size = new Size(368, 40);
            this.btnDebitsSell.TabIndex = 2;
            this.btnDebitsSell.Text = "الديون للبيع النقدي";
            this.btnDebitsSell.UseVisualStyleBackColor = true;
            this.btnDebitsSell.Click += this.btnDebitsSell_Click;
            this.btnDelegate.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.btnDelegate.Enabled = false;
            this.btnDelegate.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnDelegate.ForeColor = Color.Black;
            this.btnDelegate.Location = new Point(6, 341);
            this.btnDelegate.Name = "btnDelegate";
            this.btnDelegate.Size = new Size(180, 40);
            this.btnDelegate.TabIndex = 5;
            this.btnDelegate.Text = "المندوب";
            this.btnDelegate.UseVisualStyleBackColor = true;
            this.btnDelegate.Click += this.btnDelegate_Click;
            this.btnEmployeeDebits.Enabled = false;
            this.btnEmployeeDebits.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnEmployeeDebits.ForeColor = Color.Black;
            this.btnEmployeeDebits.Location = new Point(6, 203);
            this.btnEmployeeDebits.Name = "btnEmployeeDebits";
            this.btnEmployeeDebits.Size = new Size(180, 40);
            this.btnEmployeeDebits.TabIndex = 7;
            this.btnEmployeeDebits.Text = "دين الموظفين";
            this.btnEmployeeDebits.UseVisualStyleBackColor = true;
            this.btnEmployeeDebits.Click += this.btnEmployeeDebits_Click;
            this.btnCaseValue.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.btnCaseValue.Enabled = false;
            this.btnCaseValue.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCaseValue.ForeColor = Color.Black;
            this.btnCaseValue.Location = new Point(6, 111);
            this.btnCaseValue.Name = "btnCaseValue";
            this.btnCaseValue.Size = new Size(180, 40);
            this.btnCaseValue.TabIndex = 9;
            this.btnCaseValue.Tag = "if";
            this.btnCaseValue.Text = "الصندوق";
            this.btnCaseValue.UseVisualStyleBackColor = true;
            this.btnCaseValue.Click += this.btnCaseValue_Click;
            this.btnDelegates.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.btnDelegates.Enabled = false;
            this.btnDelegates.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnDelegates.ForeColor = Color.Black;
            this.btnDelegates.Location = new Point(194, 341);
            this.btnDelegates.Name = "btnDelegates";
            this.btnDelegates.Size = new Size(180, 40);
            this.btnDelegates.TabIndex = 4;
            this.btnDelegates.Text = "المندوبين";
            this.btnDelegates.UseVisualStyleBackColor = true;
            this.btnDelegates.Click += this.btnDelegates_Click;
            this.btnEmployee.Enabled = false;
            this.btnEmployee.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnEmployee.ForeColor = Color.Black;
            this.btnEmployee.Location = new Point(6, 249);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new Size(180, 40);
            this.btnEmployee.TabIndex = 8;
            this.btnEmployee.Text = "الموظف";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += this.btnEmployee_Click;
            this.btnSearch.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.btnSearch.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnSearch.ImageOptions.Image");
            this.btnSearch.ImageOptions.Location = ImageLocation.MiddleCenter;
            this.btnSearch.Location = new Point(609, 731);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(382, 45);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Click += this.btnSearch_Click;
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle.Font = new Font("Tahoma", 8.25f);
            dataGridViewCellStyle.ForeColor = Color.Black;
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
            this.dgvResults.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 8f);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(32, 31, 53);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.Location = new Point(12, 36);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 8.25f);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            this.dgvResults.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResults.RowTemplate.DefaultCellStyle.Font = new Font("Tahoma", 8.25f);
            this.dgvResults.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvResults.RowTemplate.Height = 25;
            this.dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new Size(585, 740);
            this.dgvResults.TabIndex = 11;
            this.groupControl5.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.groupControl5.Controls.Add(this.txtNotCash);
            this.groupControl5.Location = new Point(10, 542);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new Size(200, 54);
            this.groupControl5.TabIndex = 23;
            this.groupControl5.Text = "أجل";
            this.txtNotCash.Dock = DockStyle.Fill;
            this.txtNotCash.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtNotCash.ForeColor = Color.FromArgb(192, 0, 0);
            this.txtNotCash.Location = new Point(2, 20);
            this.txtNotCash.Name = "txtNotCash";
            this.txtNotCash.ReadOnly = true;
            this.txtNotCash.Size = new Size(196, 30);
            this.txtNotCash.TabIndex = 0;
            this.txtNotCash.Text = "0";
            this.txtNotCash.TextAlign = HorizontalAlignment.Center;
            this.groupControl6.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.groupControl6.Controls.Add(this.txtExport);
            this.groupControl6.Location = new Point(12, 602);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new Size(200, 54);
            this.groupControl6.TabIndex = 22;
            this.groupControl6.Text = "صادر";
            this.txtExport.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.txtExport.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtExport.ForeColor = Color.FromArgb(192, 0, 0);
            this.txtExport.Location = new Point(2, 21);
            this.txtExport.Name = "txtExport";
            this.txtExport.ReadOnly = true;
            this.txtExport.Size = new Size(196, 30);
            this.txtExport.TabIndex = 0;
            this.txtExport.Text = "0";
            this.txtExport.TextAlign = HorizontalAlignment.Center;
            this.groupControl7.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.groupControl7.Controls.Add(this.txtRemaining);
            this.groupControl7.Location = new Point(12, 722);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new Size(200, 54);
            this.groupControl7.TabIndex = 21;
            this.groupControl7.Text = "متبقي";
            this.txtRemaining.Dock = DockStyle.Fill;
            this.txtRemaining.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtRemaining.ForeColor = Color.FromArgb(192, 0, 0);
            this.txtRemaining.Location = new Point(2, 20);
            this.txtRemaining.Name = "txtRemaining";
            this.txtRemaining.ReadOnly = true;
            this.txtRemaining.Size = new Size(196, 30);
            this.txtRemaining.TabIndex = 0;
            this.txtRemaining.Text = "0";
            this.txtRemaining.TextAlign = HorizontalAlignment.Center;
            this.groupControl8.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.groupControl8.Controls.Add(this.txtDebit);
            this.groupControl8.Location = new Point(12, 662);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new Size(200, 54);
            this.groupControl8.TabIndex = 20;
            this.groupControl8.Text = "قرض";
            this.txtDebit.Dock = DockStyle.Fill;
            this.txtDebit.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtDebit.ForeColor = Color.FromArgb(192, 0, 0);
            this.txtDebit.Location = new Point(2, 20);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.ReadOnly = true;
            this.txtDebit.Size = new Size(196, 30);
            this.txtDebit.TabIndex = 0;
            this.txtDebit.Text = "0";
            this.txtDebit.TextAlign = HorizontalAlignment.Center;
            this.groupControl4.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.groupControl4.Controls.Add(this.txtCash);
            this.groupControl4.Location = new Point(397, 542);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new Size(200, 54);
            this.groupControl4.TabIndex = 19;
            this.groupControl4.Text = "نقد";
            this.txtCash.Dock = DockStyle.Fill;
            this.txtCash.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtCash.ForeColor = Color.FromArgb(192, 0, 0);
            this.txtCash.Location = new Point(2, 20);
            this.txtCash.Name = "txtCash";
            this.txtCash.ReadOnly = true;
            this.txtCash.Size = new Size(196, 30);
            this.txtCash.TabIndex = 0;
            this.txtCash.Text = "0";
            this.txtCash.TextAlign = HorizontalAlignment.Center;
            this.groupControl3.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.groupControl3.Controls.Add(this.txtBalance);
            this.groupControl3.Location = new Point(397, 599);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new Size(200, 54);
            this.groupControl3.TabIndex = 18;
            this.groupControl3.Text = "رصيد";
            this.txtBalance.Dock = DockStyle.Fill;
            this.txtBalance.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtBalance.ForeColor = Color.FromArgb(192, 0, 0);
            this.txtBalance.Location = new Point(2, 20);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new Size(196, 30);
            this.txtBalance.TabIndex = 0;
            this.txtBalance.Text = "0";
            this.txtBalance.TextAlign = HorizontalAlignment.Center;
            this.groupControl2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.groupControl2.Controls.Add(this.txtTotal);
            this.groupControl2.Location = new Point(397, 719);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new Size(200, 54);
            this.groupControl2.TabIndex = 17;
            this.groupControl2.Text = "محصلة";
            this.txtTotal.Dock = DockStyle.Fill;
            this.txtTotal.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtTotal.ForeColor = Color.FromArgb(192, 0, 0);
            this.txtTotal.Location = new Point(2, 20);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new Size(196, 30);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = HorizontalAlignment.Center;
            this.groupControl1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.groupControl1.Controls.Add(this.txtPay);
            this.groupControl1.Location = new Point(397, 659);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new Size(200, 54);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "تسديد";
            this.txtPay.Dock = DockStyle.Fill;
            this.txtPay.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtPay.ForeColor = Color.FromArgb(192, 0, 0);
            this.txtPay.Location = new Point(2, 20);
            this.txtPay.Name = "txtPay";
            this.txtPay.ReadOnly = true;
            this.txtPay.Size = new Size(196, 30);
            this.txtPay.TabIndex = 0;
            this.txtPay.Text = "0";
            this.txtPay.TextAlign = HorizontalAlignment.Center;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(1010, 788);
            base.ControlBox = false;
            base.Controls.Add(this.grpMain);
            base.FormBorderStyle = FormBorderStyle.None;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Reports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            base.WindowState = FormWindowState.Maximized;
            ((ISupportInitialize)this.grpMain).EndInit();
            this.grpMain.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            ((ISupportInitialize)this.grpPayMethod.Properties).EndInit();
            ((ISupportInitialize)this.grpCurrency.Properties).EndInit();
            ((ISupportInitialize)this.grpCash.Properties).EndInit();
            ((ISupportInitialize)this.grpImport.Properties).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((ISupportInitialize)this.dgvResults).EndInit();
            ((ISupportInitialize)this.groupControl5).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((ISupportInitialize)this.groupControl6).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((ISupportInitialize)this.groupControl7).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.groupControl7.PerformLayout();
            ((ISupportInitialize)this.groupControl8).EndInit();
            this.groupControl8.ResumeLayout(false);
            this.groupControl8.PerformLayout();
            ((ISupportInitialize)this.groupControl4).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((ISupportInitialize)this.groupControl3).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((ISupportInitialize)this.groupControl2).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((ISupportInitialize)this.groupControl1).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            base.ResumeLayout(false);
        }
        #endregion
        private Button btnDailyReport;

        private Button btnDebitsSell;

        private Button btnDebitsClients;

        private Button btnDelegates;

        private Button btnDelegate;

        private Button btnClient;

        private Button btnEmployeeDebits;

        private Button btnEmployee;

        private Button btnCaseValue;

        private DataGridView dgvResults;

        private GroupControl grpMain;

        private SimpleButton btnPrint;

        private SimpleButton btnSearch;

        private GroupBox groupBox1;

        private GroupControl groupControl5;

        private TextBox txtNotCash;

        private GroupControl groupControl6;

        private TextBox txtExport;

        private GroupControl groupControl7;

        private TextBox txtRemaining;

        private GroupControl groupControl8;

        private TextBox txtDebit;

        private GroupControl groupControl4;

        private TextBox txtCash;

        private GroupControl groupControl3;

        private TextBox txtBalance;

        private GroupControl groupControl2;

        private TextBox txtTotal;

        private GroupControl groupControl1;

        private TextBox txtPay;

        private GroupBox grpInfo;

        private DateTimePicker dateTo;

        private DateTimePicker dateFrom;

        private System.Windows.Forms.ComboBox cmbClients;

        private ToolTip toolTip1;

        private Button btnBillReport;

        private Button btnDate;

        private Button btnProducts;

        private Button btnBills;

        private RadioGroup grpCash;

        private RadioGroup grpImport;

        private Button btnClientPay;

        private RadioGroup grpCurrency;

        private RadioGroup grpPayMethod;

        private System.Windows.Forms.ComboBox cmbDelegates;

        private System.Windows.Forms.ComboBox cmbUsers;
    }
}
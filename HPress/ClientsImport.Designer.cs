namespace HPress
{
    partial class ClientsImport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsImport));
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.طباعةوصلاستلامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtBalanceValue = new System.Windows.Forms.TextBox();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.grpClients = new DevExpress.XtraEditors.GroupControl();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.isDollar = new DevExpress.XtraEditors.ToggleSwitch();
            this.grpNote = new DevExpress.XtraEditors.GroupControl();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.grpDollar = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.grpMain = new DevExpress.XtraEditors.GroupControl();
            this.grpDollarDebits = new DevExpress.XtraEditors.GroupControl();
            this.txtDollarDebits = new System.Windows.Forms.TextBox();
            this.grpDinarDebits = new DevExpress.XtraEditors.GroupControl();
            this.txtDinarDebits = new System.Windows.Forms.TextBox();
            this.grpPayMethod = new DevExpress.XtraEditors.RadioGroup();
            this.grpCurrency = new DevExpress.XtraEditors.RadioGroup();
            this.grpTotalDollarDebits = new DevExpress.XtraEditors.GroupControl();
            this.txtTotalDollarDebits = new System.Windows.Forms.TextBox();
            this.grpTotalDinarDebits = new DevExpress.XtraEditors.GroupControl();
            this.txtTotalDinarDebits = new System.Windows.Forms.TextBox();
            this.btnReportClient = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpClients)).BeginInit();
            this.grpClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isDollar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNote)).BeginInit();
            this.grpNote.SuspendLayout();
            this.grpDollar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).BeginInit();
            this.grpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDollarDebits)).BeginInit();
            this.grpDollarDebits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDinarDebits)).BeginInit();
            this.grpDinarDebits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpPayMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCurrency.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTotalDollarDebits)).BeginInit();
            this.grpTotalDollarDebits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTotalDinarDebits)).BeginInit();
            this.grpTotalDinarDebits.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvResults.Location = new System.Drawing.Point(12, 106);
            this.dgvResults.Name = "dgvResults";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResults.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(381, 529);
            this.dgvResults.TabIndex = 28;
            this.dgvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellClick_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.طباعةوصلاستلامToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 26);
            // 
            // طباعةوصلاستلامToolStripMenuItem
            // 
            this.طباعةوصلاستلامToolStripMenuItem.Name = "طباعةوصلاستلامToolStripMenuItem";
            this.طباعةوصلاستلامToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.طباعةوصلاستلامToolStripMenuItem.Text = "طباعة وصل استلام";
            this.طباعةوصلاستلامToolStripMenuItem.Click += new System.EventHandler(this.طباعةوصلاستلامToolStripMenuItem_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrint.Location = new System.Drawing.Point(12, 36);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(44, 57);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(62, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 57);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl4.CaptionImage")));
            this.groupControl4.Controls.Add(this.txtBalanceValue);
            this.groupControl4.Location = new System.Drawing.Point(501, 226);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(275, 57);
            this.groupControl4.TabIndex = 25;
            this.groupControl4.Text = "الرصيد";
            // 
            // txtBalanceValue
            // 
            this.txtBalanceValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBalanceValue.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceValue.Location = new System.Drawing.Point(2, 23);
            this.txtBalanceValue.Name = "txtBalanceValue";
            this.txtBalanceValue.Size = new System.Drawing.Size(271, 36);
            this.txtBalanceValue.TabIndex = 0;
            this.txtBalanceValue.TextChanged += new System.EventHandler(this.txtBalanceValue_TextChanged);
            this.txtBalanceValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBalanceValue_KeyPress);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Appearance.Options.UseFont = true;
            this.btnRemove.Enabled = false;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnRemove.Location = new System.Drawing.Point(399, 577);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(82, 37);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "حذف";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(694, 577);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 37);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(399, 534);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(377, 37);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "أضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpClients
            // 
            this.grpClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpClients.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grpClients.CaptionImage")));
            this.grpClients.Controls.Add(this.cmbClients);
            this.grpClients.Location = new System.Drawing.Point(399, 171);
            this.grpClients.Name = "grpClients";
            this.grpClients.Size = new System.Drawing.Size(377, 46);
            this.grpClients.TabIndex = 21;
            this.grpClients.Text = "العملاء";
            // 
            // cmbClients
            // 
            this.cmbClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbClients.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(2, 23);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(373, 27);
            this.cmbClients.TabIndex = 0;
            this.cmbClients.DropDown += new System.EventHandler(this.cmbClients_DropDown);
            this.cmbClients.SelectedIndexChanged += new System.EventHandler(this.cmbClients_SelectedIndexChanged);
            // 
            // isDollar
            // 
            this.isDollar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isDollar.Location = new System.Drawing.Point(3, 23);
            this.isDollar.Name = "isDollar";
            this.isDollar.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isDollar.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(0)))));
            this.isDollar.Properties.Appearance.Options.UseFont = true;
            this.isDollar.Properties.Appearance.Options.UseForeColor = true;
            this.isDollar.Properties.OffText = "";
            this.isDollar.Properties.OnText = "";
            this.isDollar.Size = new System.Drawing.Size(88, 30);
            this.isDollar.TabIndex = 20;
            this.isDollar.Toggled += new System.EventHandler(this.isDollar_Toggled);
            // 
            // grpNote
            // 
            this.grpNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNote.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grpNote.CaptionImage")));
            this.grpNote.Controls.Add(this.txtNote);
            this.grpNote.Location = new System.Drawing.Point(399, 353);
            this.grpNote.Name = "grpNote";
            this.grpNote.Size = new System.Drawing.Size(377, 175);
            this.grpNote.TabIndex = 32;
            this.grpNote.Text = "ملاحظة";
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(2, 23);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(373, 150);
            this.txtNote.TabIndex = 0;
            // 
            // grpDollar
            // 
            this.grpDollar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDollar.Controls.Add(this.isDollar);
            this.grpDollar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDollar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.grpDollar.Location = new System.Drawing.Point(401, 226);
            this.grpDollar.Name = "grpDollar";
            this.grpDollar.Size = new System.Drawing.Size(94, 58);
            this.grpDollar.TabIndex = 34;
            this.grpDollar.TabStop = false;
            this.grpDollar.Text = "IQD";
            // 
            // date
            // 
            this.date.Cursor = System.Windows.Forms.Cursors.Default;
            this.date.CustomFormat = "dd/MM/yyyy";
            this.date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(3, 23);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(371, 27);
            this.date.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(399, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 58);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تاريخ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateFrom);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(236, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 58);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "من";
            // 
            // dateFrom
            // 
            this.dateFrom.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateFrom.CustomFormat = "dd/MM/yyyy";
            this.dateFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFrom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(3, 23);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(112, 27);
            this.dateFrom.TabIndex = 35;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTo);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.groupBox4.Location = new System.Drawing.Point(112, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(118, 58);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "الى";
            // 
            // dateTo
            // 
            this.dateTo.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTo.CustomFormat = "dd/MM/yyyy";
            this.dateTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(3, 23);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(112, 27);
            this.dateTo.TabIndex = 35;
            // 
            // grpMain
            // 
            this.grpMain.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grpMain.CaptionImage")));
            this.grpMain.Controls.Add(this.grpDollarDebits);
            this.grpMain.Controls.Add(this.grpDinarDebits);
            this.grpMain.Controls.Add(this.grpPayMethod);
            this.grpMain.Controls.Add(this.grpCurrency);
            this.grpMain.Controls.Add(this.grpTotalDollarDebits);
            this.grpMain.Controls.Add(this.grpTotalDinarDebits);
            this.grpMain.Controls.Add(this.btnReportClient);
            this.grpMain.Controls.Add(this.btnPrint);
            this.grpMain.Controls.Add(this.groupBox4);
            this.grpMain.Controls.Add(this.grpClients);
            this.grpMain.Controls.Add(this.btnAdd);
            this.grpMain.Controls.Add(this.groupBox3);
            this.grpMain.Controls.Add(this.btnUpdate);
            this.grpMain.Controls.Add(this.groupBox2);
            this.grpMain.Controls.Add(this.btnRemove);
            this.grpMain.Controls.Add(this.grpDollar);
            this.grpMain.Controls.Add(this.groupControl4);
            this.grpMain.Controls.Add(this.grpNote);
            this.grpMain.Controls.Add(this.btnSearch);
            this.grpMain.Controls.Add(this.dgvResults);
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMain.Location = new System.Drawing.Point(0, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(786, 711);
            this.grpMain.TabIndex = 39;
            this.grpMain.Text = "واردات العملاء";
            this.grpMain.Paint += new System.Windows.Forms.PaintEventHandler(this.grpMain_Paint);
            // 
            // grpDollarDebits
            // 
            this.grpDollarDebits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDollarDebits.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grpDollarDebits.CaptionImage")));
            this.grpDollarDebits.Controls.Add(this.txtDollarDebits);
            this.grpDollarDebits.Location = new System.Drawing.Point(12, 642);
            this.grpDollarDebits.Name = "grpDollarDebits";
            this.grpDollarDebits.Size = new System.Drawing.Size(164, 57);
            this.grpDollarDebits.TabIndex = 45;
            this.grpDollarDebits.Text = "$";
            // 
            // txtDollarDebits
            // 
            this.txtDollarDebits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDollarDebits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDollarDebits.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDollarDebits.Location = new System.Drawing.Point(2, 23);
            this.txtDollarDebits.Name = "txtDollarDebits";
            this.txtDollarDebits.ReadOnly = true;
            this.txtDollarDebits.Size = new System.Drawing.Size(160, 30);
            this.txtDollarDebits.TabIndex = 1;
            this.txtDollarDebits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpDinarDebits
            // 
            this.grpDinarDebits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDinarDebits.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDinarDebits.Appearance.Options.UseFont = true;
            this.grpDinarDebits.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grpDinarDebits.CaptionImage")));
            this.grpDinarDebits.Controls.Add(this.txtDinarDebits);
            this.grpDinarDebits.Location = new System.Drawing.Point(189, 642);
            this.grpDinarDebits.Name = "grpDinarDebits";
            this.grpDinarDebits.Size = new System.Drawing.Size(204, 57);
            this.grpDinarDebits.TabIndex = 44;
            this.grpDinarDebits.Text = "IQD";
            // 
            // txtDinarDebits
            // 
            this.txtDinarDebits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDinarDebits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDinarDebits.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinarDebits.Location = new System.Drawing.Point(2, 23);
            this.txtDinarDebits.Name = "txtDinarDebits";
            this.txtDinarDebits.ReadOnly = true;
            this.txtDinarDebits.Size = new System.Drawing.Size(200, 30);
            this.txtDinarDebits.TabIndex = 0;
            this.txtDinarDebits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpPayMethod
            // 
            this.grpPayMethod.EditValue = 0;
            this.grpPayMethod.Location = new System.Drawing.Point(422, 36);
            this.grpPayMethod.Name = "grpPayMethod";
            this.grpPayMethod.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "قوائم"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "دفعات")});
            this.grpPayMethod.Size = new System.Drawing.Size(59, 57);
            this.grpPayMethod.TabIndex = 43;
            // 
            // grpCurrency
            // 
            this.grpCurrency.EditValue = 2;
            this.grpCurrency.Location = new System.Drawing.Point(360, 36);
            this.grpCurrency.Name = "grpCurrency";
            this.grpCurrency.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "الكل"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "دينار"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "دولار")});
            this.grpCurrency.Size = new System.Drawing.Size(56, 60);
            this.grpCurrency.TabIndex = 42;
            // 
            // grpTotalDollarDebits
            // 
            this.grpTotalDollarDebits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTotalDollarDebits.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grpTotalDollarDebits.CaptionImage")));
            this.grpTotalDollarDebits.Controls.Add(this.txtTotalDollarDebits);
            this.grpTotalDollarDebits.Location = new System.Drawing.Point(404, 106);
            this.grpTotalDollarDebits.Name = "grpTotalDollarDebits";
            this.grpTotalDollarDebits.Size = new System.Drawing.Size(164, 57);
            this.grpTotalDollarDebits.TabIndex = 41;
            this.grpTotalDollarDebits.Text = "$";
            // 
            // txtTotalDollarDebits
            // 
            this.txtTotalDollarDebits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTotalDollarDebits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalDollarDebits.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDollarDebits.Location = new System.Drawing.Point(2, 23);
            this.txtTotalDollarDebits.Name = "txtTotalDollarDebits";
            this.txtTotalDollarDebits.Size = new System.Drawing.Size(160, 30);
            this.txtTotalDollarDebits.TabIndex = 1;
            this.txtTotalDollarDebits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpTotalDinarDebits
            // 
            this.grpTotalDinarDebits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTotalDinarDebits.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTotalDinarDebits.Appearance.Options.UseFont = true;
            this.grpTotalDinarDebits.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grpTotalDinarDebits.CaptionImage")));
            this.grpTotalDinarDebits.Controls.Add(this.txtTotalDinarDebits);
            this.grpTotalDinarDebits.Location = new System.Drawing.Point(572, 106);
            this.grpTotalDinarDebits.Name = "grpTotalDinarDebits";
            this.grpTotalDinarDebits.Size = new System.Drawing.Size(204, 57);
            this.grpTotalDinarDebits.TabIndex = 40;
            this.grpTotalDinarDebits.Text = "IQD";
            // 
            // txtTotalDinarDebits
            // 
            this.txtTotalDinarDebits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalDinarDebits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalDinarDebits.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDinarDebits.Location = new System.Drawing.Point(2, 23);
            this.txtTotalDinarDebits.Name = "txtTotalDinarDebits";
            this.txtTotalDinarDebits.Size = new System.Drawing.Size(200, 30);
            this.txtTotalDinarDebits.TabIndex = 0;
            this.txtTotalDinarDebits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReportClient
            // 
            this.btnReportClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportClient.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportClient.Appearance.Options.UseFont = true;
            this.btnReportClient.Image = ((System.Drawing.Image)(resources.GetObject("btnReportClient.Image")));
            this.btnReportClient.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnReportClient.Location = new System.Drawing.Point(399, 620);
            this.btnReportClient.Name = "btnReportClient";
            this.btnReportClient.Size = new System.Drawing.Size(377, 37);
            this.btnReportClient.TabIndex = 39;
            this.btnReportClient.Text = "تقرير العميل";
            this.btnReportClient.Click += new System.EventHandler(this.btnReportClient_Click);
            // 
            // ClientsImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 711);
            this.Controls.Add(this.grpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientsImport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpClients)).EndInit();
            this.grpClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.isDollar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNote)).EndInit();
            this.grpNote.ResumeLayout(false);
            this.grpNote.PerformLayout();
            this.grpDollar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).EndInit();
            this.grpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpDollarDebits)).EndInit();
            this.grpDollarDebits.ResumeLayout(false);
            this.grpDollarDebits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDinarDebits)).EndInit();
            this.grpDinarDebits.ResumeLayout(false);
            this.grpDinarDebits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpPayMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCurrency.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTotalDollarDebits)).EndInit();
            this.grpTotalDollarDebits.ResumeLayout(false);
            this.grpTotalDollarDebits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTotalDinarDebits)).EndInit();
            this.grpTotalDinarDebits.ResumeLayout(false);
            this.grpTotalDinarDebits.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl grpClients;
        private System.Windows.Forms.ComboBox cmbClients;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.TextBox txtBalanceValue;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.DataGridView dgvResults;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.ToggleSwitch isDollar;
        private DevExpress.XtraEditors.GroupControl grpNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.GroupBox grpDollar;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTo;
        private DevExpress.XtraEditors.GroupControl grpMain;
        private DevExpress.XtraEditors.SimpleButton btnReportClient;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem طباعةوصلاستلامToolStripMenuItem;
        private DevExpress.XtraEditors.GroupControl grpTotalDinarDebits;
        private System.Windows.Forms.TextBox txtTotalDinarDebits;
        private System.Windows.Forms.TextBox txtTotalDollarDebits;
        private DevExpress.XtraEditors.GroupControl grpTotalDollarDebits;
        private DevExpress.XtraEditors.RadioGroup grpCurrency;
        private DevExpress.XtraEditors.RadioGroup grpPayMethod;
        private DevExpress.XtraEditors.GroupControl grpDollarDebits;
        private System.Windows.Forms.TextBox txtDollarDebits;
        private DevExpress.XtraEditors.GroupControl grpDinarDebits;
        private System.Windows.Forms.TextBox txtDinarDebits;
    }
}
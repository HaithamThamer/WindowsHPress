namespace HPress
{
    partial class Debits
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Debits));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.isPay = new DevExpress.XtraEditors.ToggleSwitch();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtDebits = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.grpPay = new System.Windows.Forms.GroupBox();
            this.grpIsDollar = new System.Windows.Forms.GroupBox();
            this.isDollar = new DevExpress.XtraEditors.ToggleSwitch();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.grpMain = new DevExpress.XtraEditors.GroupControl();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isPay.Properties)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.grpPay.SuspendLayout();
            this.grpIsDollar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isDollar.Properties)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).BeginInit();
            this.grpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbClients);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(598, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الموظف";
            // 
            // cmbClients
            // 
            this.cmbClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbClients.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(3, 16);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(175, 27);
            this.cmbClients.TabIndex = 0;
            this.cmbClients.DropDown += new System.EventHandler(this.cmbClient_DropDown);
            this.cmbClients.SelectedIndexChanged += new System.EventHandler(this.cmbClients_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateFrom);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(258, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 45);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "من";
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "dd/MM/yyyy";
            this.dateFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFrom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(3, 16);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(121, 27);
            this.dateFrom.TabIndex = 16;
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResults.Location = new System.Drawing.Point(8, 94);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new System.Drawing.Size(477, 385);
            this.dgvResults.TabIndex = 3;
            this.dgvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtValue);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.groupBox4.Location = new System.Drawing.Point(598, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 56);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "المبلغ";
            // 
            // txtValue
            // 
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.ForeColor = System.Drawing.Color.Maroon;
            this.txtValue.Location = new System.Drawing.Point(3, 16);
            this.txtValue.Name = "txtValue";
            this.txtValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtValue.Size = new System.Drawing.Size(175, 27);
            this.txtValue.TabIndex = 0;
            this.txtValue.Text = "0";
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // isPay
            // 
            this.isPay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isPay.Location = new System.Drawing.Point(3, 22);
            this.isPay.Name = "isPay";
            this.isPay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isPay.Properties.Appearance.Options.UseFont = true;
            this.isPay.Properties.OffText = "";
            this.isPay.Properties.OnText = "";
            this.isPay.Size = new System.Drawing.Size(92, 30);
            this.isPay.TabIndex = 6;
            this.isPay.Toggled += new System.EventHandler(this.isPay_Toggled);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtNote);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.groupBox5.Location = new System.Drawing.Point(494, 210);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(285, 106);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ملاحظة";
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(3, 16);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(279, 87);
            this.txtNote.TabIndex = 0;
            // 
            // txtDebits
            // 
            this.txtDebits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDebits.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebits.Location = new System.Drawing.Point(3, 16);
            this.txtDebits.Name = "txtDebits";
            this.txtDebits.Size = new System.Drawing.Size(152, 30);
            this.txtDebits.TabIndex = 11;
            this.txtDebits.Text = "0";
            this.txtDebits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.txtDebits);
            this.groupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.groupBox6.Location = new System.Drawing.Point(327, 485);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox6.Size = new System.Drawing.Size(158, 53);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "مجموع المقروض";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox7.Controls.Add(this.txtPaid);
            this.groupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.groupBox7.Location = new System.Drawing.Point(13, 485);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(164, 53);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "مجموع المسدد";
            // 
            // txtPaid
            // 
            this.txtPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPaid.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Location = new System.Drawing.Point(3, 16);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(158, 30);
            this.txtPaid.TabIndex = 11;
            this.txtPaid.Text = "0";
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.txtTotal);
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.groupBox8.Location = new System.Drawing.Point(13, 541);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(472, 53);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "المحصلة";
            // 
            // txtTotal
            // 
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(3, 16);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(466, 30);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPrint.Location = new System.Drawing.Point(8, 36);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(50, 46);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click_1);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnSearch.Location = new System.Drawing.Point(64, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 46);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(494, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(285, 38);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "أضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(698, 366);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 38);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dateTo);
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.groupBox9.Location = new System.Drawing.Point(125, 36);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(127, 45);
            this.groupBox9.TabIndex = 18;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "الى";
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "dd/MM/yyyy";
            this.dateTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTo.Location = new System.Drawing.Point(3, 16);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(121, 27);
            this.dateTo.TabIndex = 16;
            // 
            // grpPay
            // 
            this.grpPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPay.Controls.Add(this.isPay);
            this.grpPay.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.grpPay.Location = new System.Drawing.Point(494, 30);
            this.grpPay.Name = "grpPay";
            this.grpPay.Size = new System.Drawing.Size(98, 56);
            this.grpPay.TabIndex = 19;
            this.grpPay.TabStop = false;
            this.grpPay.Text = "قرض";
            // 
            // grpIsDollar
            // 
            this.grpIsDollar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpIsDollar.Controls.Add(this.isDollar);
            this.grpIsDollar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIsDollar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.grpIsDollar.Location = new System.Drawing.Point(494, 94);
            this.grpIsDollar.Name = "grpIsDollar";
            this.grpIsDollar.Size = new System.Drawing.Size(98, 59);
            this.grpIsDollar.TabIndex = 20;
            this.grpIsDollar.TabStop = false;
            this.grpIsDollar.Text = "IQD";
            // 
            // isDollar
            // 
            this.isDollar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isDollar.Location = new System.Drawing.Point(3, 22);
            this.isDollar.Name = "isDollar";
            this.isDollar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isDollar.Properties.Appearance.Options.UseFont = true;
            this.isDollar.Properties.OffText = "";
            this.isDollar.Properties.OnText = "";
            this.isDollar.Size = new System.Drawing.Size(92, 30);
            this.isDollar.TabIndex = 6;
            this.isDollar.Toggled += new System.EventHandler(this.isDollar_Toggled);
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.date);
            this.groupBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.groupBox11.Location = new System.Drawing.Point(494, 159);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(285, 45);
            this.groupBox11.TabIndex = 21;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "التاريخ";
            // 
            // date
            // 
            this.date.CustomFormat = "dd/MM/yyyy";
            this.date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(3, 16);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(279, 27);
            this.date.TabIndex = 16;
            // 
            // grpMain
            // 
            this.grpMain.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grpMain.CaptionImage")));
            this.grpMain.Controls.Add(this.btnRemove);
            this.grpMain.Controls.Add(this.btnSearch);
            this.grpMain.Controls.Add(this.grpPay);
            this.grpMain.Controls.Add(this.groupBox8);
            this.grpMain.Controls.Add(this.groupBox9);
            this.grpMain.Controls.Add(this.groupBox7);
            this.grpMain.Controls.Add(this.groupBox6);
            this.grpMain.Controls.Add(this.groupBox11);
            this.grpMain.Controls.Add(this.btnPrint);
            this.grpMain.Controls.Add(this.dgvResults);
            this.grpMain.Controls.Add(this.groupBox1);
            this.grpMain.Controls.Add(this.grpIsDollar);
            this.grpMain.Controls.Add(this.btnAdd);
            this.grpMain.Controls.Add(this.groupBox4);
            this.grpMain.Controls.Add(this.groupBox5);
            this.grpMain.Controls.Add(this.groupBox2);
            this.grpMain.Controls.Add(this.btnUpdate);
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMain.Location = new System.Drawing.Point(0, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpMain.Size = new System.Drawing.Size(784, 607);
            this.grpMain.TabIndex = 22;
            this.grpMain.Text = "الديون";
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Appearance.Options.UseFont = true;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnRemove.Location = new System.Drawing.Point(494, 366);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(81, 38);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Text = "حذف";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Debits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 607);
            this.ControlBox = false;
            this.Controls.Add(this.grpMain);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Debits";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Debits";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isPay.Properties)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.grpPay.ResumeLayout(false);
            this.grpIsDollar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.isDollar.Properties)).EndInit();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).EndInit();
            this.grpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvResults;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtValue;
        private DevExpress.XtraEditors.ToggleSwitch isPay;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNote;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.TextBox txtDebits;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtTotal;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.GroupBox grpPay;
        private System.Windows.Forms.GroupBox grpIsDollar;
        private DevExpress.XtraEditors.ToggleSwitch isDollar;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DateTimePicker date;
        private DevExpress.XtraEditors.GroupControl grpMain;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
    }
}
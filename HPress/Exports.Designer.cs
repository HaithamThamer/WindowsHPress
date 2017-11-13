namespace HPress
{
    partial class Exports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exports));
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtBalanceValue = new System.Windows.Forms.TextBox();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.grpTypeName = new DevExpress.XtraEditors.GroupControl();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.isDollar = new DevExpress.XtraEditors.ToggleSwitch();
            this.rdoType = new DevExpress.XtraEditors.RadioGroup();
            this.grpNote = new DevExpress.XtraEditors.GroupControl();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.grpDollar = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTypeName)).BeginInit();
            this.grpTypeName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isDollar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNote)).BeginInit();
            this.grpNote.SuspendLayout();
            this.grpDollar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.dgvResults.Size = new System.Drawing.Size(393, 344);
            this.dgvResults.TabIndex = 28;
            this.dgvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellClick_1);
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Enabled = false;
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
            // groupControl5
            // 
            this.groupControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl5.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl5.CaptionImage")));
            this.groupControl5.Controls.Add(this.txtTotal);
            this.groupControl5.Location = new System.Drawing.Point(10, 456);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(395, 58);
            this.groupControl5.TabIndex = 26;
            this.groupControl5.Text = "المجموع";
            // 
            // txtTotal
            // 
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(2, 21);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(391, 33);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl4.CaptionImage")));
            this.groupControl4.Controls.Add(this.txtBalanceValue);
            this.groupControl4.Location = new System.Drawing.Point(511, 131);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(179, 57);
            this.groupControl4.TabIndex = 25;
            this.groupControl4.Text = "الرصيد";
            // 
            // txtBalanceValue
            // 
            this.txtBalanceValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBalanceValue.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceValue.Location = new System.Drawing.Point(2, 21);
            this.txtBalanceValue.Name = "txtBalanceValue";
            this.txtBalanceValue.Size = new System.Drawing.Size(175, 36);
            this.txtBalanceValue.TabIndex = 0;
            this.txtBalanceValue.TextChanged += new System.EventHandler(this.txtBalanceValue_TextChanged);
            this.txtBalanceValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBalanceValue_KeyPress);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Appearance.Options.UseFont = true;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnRemove.Location = new System.Drawing.Point(411, 413);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(82, 37);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "حذف";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(608, 413);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 37);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(411, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(279, 37);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpTypeName
            // 
            this.grpTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTypeName.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grpTypeName.CaptionImage")));
            this.grpTypeName.Controls.Add(this.cmbClients);
            this.grpTypeName.Location = new System.Drawing.Point(409, 76);
            this.grpTypeName.Name = "grpTypeName";
            this.grpTypeName.Size = new System.Drawing.Size(281, 46);
            this.grpTypeName.TabIndex = 21;
            this.grpTypeName.Text = "الموردين";
            // 
            // cmbClients
            // 
            this.cmbClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbClients.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(2, 21);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(277, 27);
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
            // rdoType
            // 
            this.rdoType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoType.EditValue = 1;
            this.rdoType.Location = new System.Drawing.Point(409, 36);
            this.rdoType.Name = "rdoType";
            this.rdoType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(3, "موظف"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "المندوب"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "مورد")});
            this.rdoType.Size = new System.Drawing.Size(281, 34);
            this.rdoType.TabIndex = 30;
            this.rdoType.SelectedIndexChanged += new System.EventHandler(this.rdoType_SelectedIndexChanged);
            // 
            // grpNote
            // 
            this.grpNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNote.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grpNote.CaptionImage")));
            this.grpNote.Controls.Add(this.txtNote);
            this.grpNote.Location = new System.Drawing.Point(409, 262);
            this.grpNote.Name = "grpNote";
            this.grpNote.Size = new System.Drawing.Size(281, 102);
            this.grpNote.TabIndex = 32;
            this.grpNote.Text = "ملاحظة";
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(2, 21);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(277, 79);
            this.txtNote.TabIndex = 0;
            // 
            // grpDollar
            // 
            this.grpDollar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDollar.Controls.Add(this.isDollar);
            this.grpDollar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDollar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.grpDollar.Location = new System.Drawing.Point(411, 130);
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
            this.date.Size = new System.Drawing.Size(273, 27);
            this.date.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(411, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 58);
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
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.btnPrint);
            this.groupControl1.Controls.Add(this.groupBox4);
            this.groupControl1.Controls.Add(this.grpTypeName);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.groupBox3);
            this.groupControl1.Controls.Add(this.btnUpdate);
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.btnRemove);
            this.groupControl1.Controls.Add(this.grpDollar);
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Controls.Add(this.grpNote);
            this.groupControl1.Controls.Add(this.groupControl5);
            this.groupControl1.Controls.Add(this.rdoType);
            this.groupControl1.Controls.Add(this.btnSearch);
            this.groupControl1.Controls.Add(this.dgvResults);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(700, 526);
            this.groupControl1.TabIndex = 39;
            this.groupControl1.Text = "الصادرات";
            // 
            // Exports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 526);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTypeName)).EndInit();
            this.grpTypeName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.isDollar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpNote)).EndInit();
            this.grpNote.ResumeLayout(false);
            this.grpNote.PerformLayout();
            this.grpDollar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl grpTypeName;
        private System.Windows.Forms.ComboBox cmbClients;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private System.Windows.Forms.TextBox txtBalanceValue;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private System.Windows.Forms.TextBox txtTotal;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private System.Windows.Forms.DataGridView dgvResults;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.ToggleSwitch isDollar;
        private DevExpress.XtraEditors.RadioGroup rdoType;
        private DevExpress.XtraEditors.GroupControl grpNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.GroupBox grpDollar;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTo;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ButtonPanel;
using DevExpress.XtraEditors.ButtonsPanelControl;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HPress
{
    partial class Main
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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
            ButtonImageOptions imageOptions = new ButtonImageOptions();
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            this.groupControl1 = new GroupControl();
            this.groupControl3 = new GroupControl();
            this.txtTotalDollarDebitsFinal = new TextBox();
            this.groupControl4 = new GroupControl();
            this.txtTotalDinarDebitsFinal = new TextBox();
            this.grpTotalDollarDebits = new GroupControl();
            this.txtTotalDollarDebits = new TextBox();
            this.grpTotalDinarDebits = new GroupControl();
            this.txtTotalDinarDebits = new TextBox();
            this.groupControl2 = new GroupControl();
            this.txtDelegateTotal = new TextBox();
            this.grpDate = new GroupControl();
            this.dateFrom = new DateTimePicker();
            this.isAccount = new ToggleSwitch();
            this.groupControl8 = new GroupControl();
            this.txtNote = new TextBox();
            this.btnAdd = new SimpleButton();
            this.grpDelegates = new GroupControl();
            this.cmbDelegates = new System.Windows.Forms.ComboBox();
            this.grpInfo = new GroupControl();
            this.btnAddClient = new SimpleButton();
            this.dgvClientsNames = new DataGridView();
            this.label8 = new Label();
            this.txtClientName = new TextBox();
            this.txtClientEmail = new TextBox();
            this.label7 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.txtClientMobile = new TextBox();
            this.txtClientLocation = new TextBox();
            this.grpPaid = new GroupControl();
            this.txtPaid = new TextBox();
            this.groupControl9 = new GroupControl();
            this.contextMenuStripBills = new ContextMenuStrip(this.components);
            this.حذفالقائمةToolStripMenuItem = new ToolStripMenuItem();
            this.cmbBills = new System.Windows.Forms.ComboBox();
            this.isDollar = new ToggleSwitch();
            this.isCash = new ToggleSwitch();
            this.isSell = new ToggleSwitch();
            this.btnClear = new SimpleButton();
            this.grpTotal = new GroupControl();
            this.txtTotal = new TextBox();
            this.groupControl5 = new GroupControl();
            this.txtDiscount = new TextBox();
            this.dgvProducts = new DataGridView();
            this.id = new DataGridViewTextBoxColumn();
            this.description = new DataGridViewTextBoxColumn();
            this.quantity = new DataGridViewTextBoxColumn();
            this.price = new DataGridViewTextBoxColumn();
            this.total = new DataGridViewTextBoxColumn();
            this.note = new DataGridViewTextBoxColumn();
            this.delegate_percentage = new DataGridViewTextBoxColumn();
            this.dgvProductMenu = new ContextMenuStrip(this.components);
            this.تكرارالقيدToolStripMenuItem = new ToolStripMenuItem();
            this.حذفالمحددToolStripMenuItem = new ToolStripMenuItem();
            this.btnSell = new SimpleButton();
            this.contextMenuStripBtnSell = new ContextMenuStrip(this.components);
            this.طباعةوصلقبضToolStripMenuItem = new ToolStripMenuItem();
            this.grpClients = new GroupControl();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            ((ISupportInitialize)this.groupControl1).BeginInit();
            this.groupControl1.SuspendLayout();
            ((ISupportInitialize)this.groupControl3).BeginInit();
            this.groupControl3.SuspendLayout();
            ((ISupportInitialize)this.groupControl4).BeginInit();
            this.groupControl4.SuspendLayout();
            ((ISupportInitialize)this.grpTotalDollarDebits).BeginInit();
            this.grpTotalDollarDebits.SuspendLayout();
            ((ISupportInitialize)this.grpTotalDinarDebits).BeginInit();
            this.grpTotalDinarDebits.SuspendLayout();
            ((ISupportInitialize)this.groupControl2).BeginInit();
            this.groupControl2.SuspendLayout();
            ((ISupportInitialize)this.grpDate).BeginInit();
            this.grpDate.SuspendLayout();
            ((ISupportInitialize)this.isAccount.Properties).BeginInit();
            ((ISupportInitialize)this.groupControl8).BeginInit();
            this.groupControl8.SuspendLayout();
            ((ISupportInitialize)this.grpDelegates).BeginInit();
            this.grpDelegates.SuspendLayout();
            ((ISupportInitialize)this.grpInfo).BeginInit();
            this.grpInfo.SuspendLayout();
            ((ISupportInitialize)this.dgvClientsNames).BeginInit();
            ((ISupportInitialize)this.grpPaid).BeginInit();
            this.grpPaid.SuspendLayout();
            ((ISupportInitialize)this.groupControl9).BeginInit();
            this.groupControl9.SuspendLayout();
            this.contextMenuStripBills.SuspendLayout();
            ((ISupportInitialize)this.isDollar.Properties).BeginInit();
            ((ISupportInitialize)this.isCash.Properties).BeginInit();
            ((ISupportInitialize)this.isSell.Properties).BeginInit();
            ((ISupportInitialize)this.grpTotal).BeginInit();
            this.grpTotal.SuspendLayout();
            ((ISupportInitialize)this.groupControl5).BeginInit();
            this.groupControl5.SuspendLayout();
            ((ISupportInitialize)this.dgvProducts).BeginInit();
            this.dgvProductMenu.SuspendLayout();
            this.contextMenuStripBtnSell.SuspendLayout();
            ((ISupportInitialize)this.grpClients).BeginInit();
            this.grpClients.SuspendLayout();
            base.SuspendLayout();
            this.groupControl1.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("groupControl1.CaptionImageOptions.Image");
            this.groupControl1.Controls.Add(this.groupControl3);
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Controls.Add(this.grpTotalDollarDebits);
            this.groupControl1.Controls.Add(this.grpTotalDinarDebits);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.grpDate);
            this.groupControl1.Controls.Add(this.isAccount);
            this.groupControl1.Controls.Add(this.groupControl8);
            this.groupControl1.Controls.Add(this.btnAdd);
            this.groupControl1.Controls.Add(this.grpDelegates);
            this.groupControl1.Controls.Add(this.grpInfo);
            this.groupControl1.Controls.Add(this.grpPaid);
            this.groupControl1.Controls.Add(this.groupControl9);
            this.groupControl1.Controls.Add(this.isDollar);
            this.groupControl1.Controls.Add(this.isCash);
            this.groupControl1.Controls.Add(this.isSell);
            this.groupControl1.Controls.Add(this.btnClear);
            this.groupControl1.Controls.Add(this.grpTotal);
            this.groupControl1.Controls.Add(this.groupControl5);
            this.groupControl1.Controls.Add(this.dgvProducts);
            this.groupControl1.Controls.Add(this.btnSell);
            this.groupControl1.Controls.Add(this.grpClients);
            this.groupControl1.Dock = DockStyle.Fill;
            this.groupControl1.Location = new Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new Size(1073, 599);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "المعلومات";
            this.groupControl3.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.groupControl3.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("groupControl3.CaptionImageOptions.Image");
            this.groupControl3.Controls.Add(this.txtTotalDollarDebitsFinal);
            this.groupControl3.Location = new Point(726, 152);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new Size(140, 44);
            this.groupControl3.TabIndex = 45;
            this.groupControl3.Text = "المحصلة بالدولار";
            this.txtTotalDollarDebitsFinal.BackColor = Color.FromArgb(255, 192, 192);
            this.txtTotalDollarDebitsFinal.Dock = DockStyle.Fill;
            this.txtTotalDollarDebitsFinal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtTotalDollarDebitsFinal.Location = new Point(2, 23);
            this.txtTotalDollarDebitsFinal.Name = "txtTotalDollarDebitsFinal";
            this.txtTotalDollarDebitsFinal.Size = new Size(136, 23);
            this.txtTotalDollarDebitsFinal.TabIndex = 1;
            this.txtTotalDollarDebitsFinal.Text = "0";
            this.txtTotalDollarDebitsFinal.TextAlign = HorizontalAlignment.Center;
            this.groupControl4.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.groupControl4.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupControl4.Appearance.Options.UseFont = true;
            this.groupControl4.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("groupControl4.CaptionImageOptions.Image");
            this.groupControl4.Controls.Add(this.txtTotalDinarDebitsFinal);
            this.groupControl4.Location = new Point(872, 152);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new Size(189, 44);
            this.groupControl4.TabIndex = 44;
            this.groupControl4.Text = "المحصلة بالدينار";
            this.txtTotalDinarDebitsFinal.BackColor = Color.FromArgb(192, 255, 192);
            this.txtTotalDinarDebitsFinal.Dock = DockStyle.Fill;
            this.txtTotalDinarDebitsFinal.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtTotalDinarDebitsFinal.Location = new Point(2, 23);
            this.txtTotalDinarDebitsFinal.Name = "txtTotalDinarDebitsFinal";
            this.txtTotalDinarDebitsFinal.Size = new Size(185, 23);
            this.txtTotalDinarDebitsFinal.TabIndex = 0;
            this.txtTotalDinarDebitsFinal.Text = "0";
            this.txtTotalDinarDebitsFinal.TextAlign = HorizontalAlignment.Center;
            this.grpTotalDollarDebits.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.grpTotalDollarDebits.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpTotalDollarDebits.CaptionImageOptions.Image");
            this.grpTotalDollarDebits.Controls.Add(this.txtTotalDollarDebits);
            this.grpTotalDollarDebits.Location = new Point(728, 102);
            this.grpTotalDollarDebits.Name = "grpTotalDollarDebits";
            this.grpTotalDollarDebits.Size = new Size(140, 44);
            this.grpTotalDollarDebits.TabIndex = 43;
            this.grpTotalDollarDebits.Text = "المجموع بالدولار";
            this.txtTotalDollarDebits.BackColor = Color.FromArgb(255, 192, 192);
            this.txtTotalDollarDebits.Dock = DockStyle.Fill;
            this.txtTotalDollarDebits.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtTotalDollarDebits.Location = new Point(2, 23);
            this.txtTotalDollarDebits.Name = "txtTotalDollarDebits";
            this.txtTotalDollarDebits.Size = new Size(136, 23);
            this.txtTotalDollarDebits.TabIndex = 1;
            this.txtTotalDollarDebits.Text = "0";
            this.txtTotalDollarDebits.TextAlign = HorizontalAlignment.Center;
            this.grpTotalDinarDebits.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.grpTotalDinarDebits.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.grpTotalDinarDebits.Appearance.Options.UseFont = true;
            this.grpTotalDinarDebits.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpTotalDinarDebits.CaptionImageOptions.Image");
            this.grpTotalDinarDebits.Controls.Add(this.txtTotalDinarDebits);
            this.grpTotalDinarDebits.Location = new Point(872, 102);
            this.grpTotalDinarDebits.Name = "grpTotalDinarDebits";
            this.grpTotalDinarDebits.Size = new Size(189, 44);
            this.grpTotalDinarDebits.TabIndex = 42;
            this.grpTotalDinarDebits.Text = "المجموع بالدينار";
            this.txtTotalDinarDebits.BackColor = Color.FromArgb(192, 255, 192);
            this.txtTotalDinarDebits.Dock = DockStyle.Fill;
            this.txtTotalDinarDebits.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtTotalDinarDebits.Location = new Point(2, 23);
            this.txtTotalDinarDebits.Name = "txtTotalDinarDebits";
            this.txtTotalDinarDebits.Size = new Size(185, 23);
            this.txtTotalDinarDebits.TabIndex = 0;
            this.txtTotalDinarDebits.Text = "0";
            this.txtTotalDinarDebits.TextAlign = HorizontalAlignment.Center;
            this.groupControl2.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.groupControl2.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("groupControl2.CaptionImageOptions.Image");
            this.groupControl2.Controls.Add(this.txtDelegateTotal);
            this.groupControl2.Location = new Point(14, 481);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new Size(130, 58);
            this.groupControl2.TabIndex = 40;
            this.groupControl2.Text = "مجموع المندوب";
            this.txtDelegateTotal.Dock = DockStyle.Fill;
            this.txtDelegateTotal.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtDelegateTotal.Location = new Point(2, 23);
            this.txtDelegateTotal.Name = "txtDelegateTotal";
            this.txtDelegateTotal.ReadOnly = true;
            this.txtDelegateTotal.Size = new Size(126, 30);
            this.txtDelegateTotal.TabIndex = 0;
            this.txtDelegateTotal.Text = "0";
            this.txtDelegateTotal.TextAlign = HorizontalAlignment.Center;
            this.grpDate.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.grpDate.Controls.Add(this.dateFrom);
            this.grpDate.CustomHeaderButtons.AddRange(new IBaseButton[1]
            {
            new GroupBoxButton("تاريخ القائمة", true, imageOptions, ButtonStyle.CheckButton, "", -1, true, null, true, false, true, null, -1)
            });
            this.grpDate.CustomHeaderButtonsLocation = GroupElementLocation.AfterText;
            this.grpDate.Location = new Point(541, 45);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new Size(174, 55);
            this.grpDate.TabIndex = 39;
            this.grpDate.Text = "تاريخ";
            this.dateFrom.CalendarFont = new Font("Tahoma", 8f);
            this.dateFrom.CustomFormat = "dd/MM/yyyy";
            this.dateFrom.Dock = DockStyle.Fill;
            this.dateFrom.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateFrom.Format = DateTimePickerFormat.Custom;
            this.dateFrom.Location = new Point(2, 26);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new Size(170, 27);
            this.dateFrom.TabIndex = 37;
            this.dateFrom.Value = new DateTime(2017, 4, 20, 14, 5, 11, 0);
            this.isAccount.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.isAccount.Location = new Point(404, 64);
            this.isAccount.Name = "isAccount";
            this.isAccount.Properties.Appearance.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.isAccount.Properties.Appearance.ForeColor = Color.FromArgb(255, 187, 0);
            this.isAccount.Properties.Appearance.Options.UseFont = true;
            this.isAccount.Properties.Appearance.Options.UseForeColor = true;
            this.isAccount.Properties.OffText = "عرض";
            this.isAccount.Properties.OnText = "حساب";
            this.isAccount.Size = new Size(131, 30);
            this.isAccount.TabIndex = 0;
            this.groupControl8.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.groupControl8.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("groupControl8.CaptionImageOptions.Image");
            this.groupControl8.Controls.Add(this.txtNote);
            this.groupControl8.Location = new Point(724, 439);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new Size(335, 151);
            this.groupControl8.TabIndex = 26;
            this.groupControl8.Text = "ملاحظة";
            this.txtNote.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.txtNote.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtNote.Location = new Point(2, 23);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new Size(331, 111);
            this.txtNote.TabIndex = 0;
            this.btnAdd.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.btnAdd.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnAdd.ImageOptions.Image");
            this.btnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAdd.Location = new Point(376, 545);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(339, 42);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "أدخال";
            this.btnAdd.Click += this.btnAdd_Click;
            this.grpDelegates.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.grpDelegates.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpDelegates.CaptionImageOptions.Image");
            this.grpDelegates.Controls.Add(this.cmbDelegates);
            this.grpDelegates.Location = new Point(726, 385);
            this.grpDelegates.Name = "grpDelegates";
            this.grpDelegates.Size = new Size(335, 65);
            this.grpDelegates.TabIndex = 35;
            this.grpDelegates.Text = "المندوب";
            this.cmbDelegates.Dock = DockStyle.Fill;
            this.cmbDelegates.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbDelegates.FormattingEnabled = true;
            this.cmbDelegates.Location = new Point(2, 23);
            this.cmbDelegates.Name = "cmbDelegates";
            this.cmbDelegates.Size = new Size(331, 27);
            this.cmbDelegates.TabIndex = 0;
            this.cmbDelegates.DropDown += this.cmbDelegates_DropDown;
            this.cmbDelegates.SelectedIndexChanged += this.cmbDelegates_SelectedIndexChanged;
            this.grpInfo.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.grpInfo.Controls.Add(this.btnAddClient);
            this.grpInfo.Controls.Add(this.dgvClientsNames);
            this.grpInfo.Controls.Add(this.label8);
            this.grpInfo.Controls.Add(this.txtClientName);
            this.grpInfo.Controls.Add(this.txtClientEmail);
            this.grpInfo.Controls.Add(this.label7);
            this.grpInfo.Controls.Add(this.label5);
            this.grpInfo.Controls.Add(this.label6);
            this.grpInfo.Controls.Add(this.txtClientMobile);
            this.grpInfo.Controls.Add(this.txtClientLocation);
            this.grpInfo.CustomHeaderButtonsLocation = GroupElementLocation.AfterText;
            this.grpInfo.Location = new Point(726, 202);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new Size(333, 177);
            this.grpInfo.TabIndex = 29;
            this.grpInfo.Text = "معلومات العميل";
            this.btnAddClient.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnAddClient.ImageOptions.Image");
            this.btnAddClient.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAddClient.Location = new Point(5, 24);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new Size(69, 126);
            this.btnAddClient.TabIndex = 37;
            this.btnAddClient.Text = "جديد";
            this.btnAddClient.Click += this.btnAddClient_Click;
            this.dgvClientsNames.AllowUserToAddRows = false;
            this.dgvClientsNames.AllowUserToDeleteRows = false;
            dataGridViewCellStyle.ForeColor = Color.Black;
            this.dgvClientsNames.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
            this.dgvClientsNames.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.dgvClientsNames.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientsNames.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 8f);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(32, 31, 53);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            this.dgvClientsNames.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientsNames.Location = new Point(80, 57);
            this.dgvClientsNames.Name = "dgvClientsNames";
            this.dgvClientsNames.ReadOnly = true;
            this.dgvClientsNames.RowHeadersVisible = false;
            this.dgvClientsNames.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvClientsNames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientsNames.Size = new Size(206, 93);
            this.dgvClientsNames.TabIndex = 30;
            this.dgvClientsNames.Visible = false;
            this.dgvClientsNames.CellClick += this.dgvClientsNames_CellClick;
            this.label8.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.label8.AutoSize = true;
            this.label8.Location = new Point(289, 130);
            this.label8.Name = "label8";
            this.label8.Size = new Size(39, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "الايميل";
            this.txtClientName.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtClientName.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtClientName.Location = new Point(80, 24);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new Size(206, 27);
            this.txtClientName.TabIndex = 20;
            this.txtClientName.TextChanged += this.txtClientName_TextChanged;
            this.txtClientName.KeyPress += this.txtClientName_KeyPress;
            this.txtClientEmail.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtClientEmail.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtClientEmail.Location = new Point(80, 123);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new Size(206, 27);
            this.txtClientEmail.TabIndex = 23;
            this.label7.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.label7.AutoSize = true;
            this.label7.Location = new Point(297, 97);
            this.label7.Name = "label7";
            this.label7.Size = new Size(31, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "هاتف";
            this.label5.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.label5.AutoSize = true;
            this.label5.Location = new Point(292, 31);
            this.label5.Name = "label5";
            this.label5.Size = new Size(36, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "الأسم";
            this.label6.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.label6.AutoSize = true;
            this.label6.Location = new Point(290, 68);
            this.label6.Name = "label6";
            this.label6.Size = new Size(38, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "العنوان";
            this.txtClientMobile.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtClientMobile.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtClientMobile.Location = new Point(80, 90);
            this.txtClientMobile.Name = "txtClientMobile";
            this.txtClientMobile.Size = new Size(206, 27);
            this.txtClientMobile.TabIndex = 22;
            this.txtClientLocation.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            this.txtClientLocation.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtClientLocation.Location = new Point(80, 57);
            this.txtClientLocation.Name = "txtClientLocation";
            this.txtClientLocation.Size = new Size(206, 27);
            this.txtClientLocation.TabIndex = 21;
            this.grpPaid.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.grpPaid.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpPaid.CaptionImageOptions.Image");
            this.grpPaid.Controls.Add(this.txtPaid);
            this.grpPaid.Enabled = false;
            this.grpPaid.Location = new Point(286, 481);
            this.grpPaid.Name = "grpPaid";
            this.grpPaid.Size = new Size(149, 58);
            this.grpPaid.TabIndex = 34;
            this.grpPaid.Text = "المدفوع";
            this.txtPaid.Dock = DockStyle.Fill;
            this.txtPaid.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtPaid.Location = new Point(2, 23);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new Size(145, 30);
            this.txtPaid.TabIndex = 0;
            this.txtPaid.Text = "0";
            this.txtPaid.TextAlign = HorizontalAlignment.Center;
            this.txtPaid.TextChanged += this.Tb_TextChanged;
            this.txtPaid.KeyPress += this.txtProductPrice_KeyPress;
            this.txtPaid.Leave += this.txtPaid_Leave;
            this.groupControl9.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.groupControl9.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("groupControl9.CaptionImageOptions.Image");
            this.groupControl9.ContextMenuStrip = this.contextMenuStripBills;
            this.groupControl9.Controls.Add(this.cmbBills);
            this.groupControl9.Location = new Point(726, 45);
            this.groupControl9.Name = "groupControl9";
            this.groupControl9.Size = new Size(79, 51);
            this.groupControl9.TabIndex = 27;
            this.groupControl9.Text = "القائمة";
            this.contextMenuStripBills.Items.AddRange(new ToolStripItem[1]
            {
            this.حذفالقائمةToolStripMenuItem
            });
            this.contextMenuStripBills.Name = "contextMenuStripBills";
            this.contextMenuStripBills.Size = new Size(136, 26);
            this.حذفالقائمةToolStripMenuItem.Name = "حذفالقائمةToolStripMenuItem";
            this.حذفالقائمةToolStripMenuItem.Size = new Size(135, 22);
            this.حذفالقائمةToolStripMenuItem.Text = "حذف القائمة";
            this.حذفالقائمةToolStripMenuItem.Click += this.حذفالقائمةToolStripMenuItem_Click;
            this.cmbBills.ContextMenuStrip = this.contextMenuStripBills;
            this.cmbBills.Dock = DockStyle.Fill;
            this.cmbBills.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbBills.FormattingEnabled = true;
            this.cmbBills.Location = new Point(2, 23);
            this.cmbBills.Name = "cmbBills";
            this.cmbBills.Size = new Size(75, 27);
            this.cmbBills.TabIndex = 28;
            this.cmbBills.DropDown += this.cmbBills_DropDown;
            this.cmbBills.KeyPress += this.cmbBills_KeyPress;
            this.isDollar.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.isDollar.Location = new Point(140, 63);
            this.isDollar.Name = "isDollar";
            this.isDollar.Properties.Appearance.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.isDollar.Properties.Appearance.ForeColor = Color.FromArgb(255, 187, 0);
            this.isDollar.Properties.Appearance.Options.UseFont = true;
            this.isDollar.Properties.Appearance.Options.UseForeColor = true;
            this.isDollar.Properties.OffText = "IQD";
            this.isDollar.Properties.OnText = "$";
            this.isDollar.Size = new Size(121, 30);
            this.isDollar.TabIndex = 19;
            this.isDollar.Toggled += this.isDollar_Toggled;
            this.isCash.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.isCash.EditValue = true;
            this.isCash.Location = new Point(12, 63);
            this.isCash.Name = "isCash";
            this.isCash.Properties.Appearance.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.isCash.Properties.Appearance.ForeColor = Color.FromArgb(255, 187, 0);
            this.isCash.Properties.Appearance.Options.UseFont = true;
            this.isCash.Properties.Appearance.Options.UseForeColor = true;
            this.isCash.Properties.OffText = "أجل";
            this.isCash.Properties.OnText = "نقد";
            this.isCash.Size = new Size(122, 30);
            this.isCash.TabIndex = 25;
            this.isCash.Toggled += this.isCash_Toggled;
            this.isSell.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.isSell.EditValue = true;
            this.isSell.Location = new Point(267, 64);
            this.isSell.Name = "isSell";
            this.isSell.Properties.Appearance.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.isSell.Properties.Appearance.ForeColor = Color.FromArgb(255, 187, 0);
            this.isSell.Properties.Appearance.Options.UseFont = true;
            this.isSell.Properties.Appearance.Options.UseForeColor = true;
            this.isSell.Properties.OffText = "صادر";
            this.isSell.Properties.OnText = "وارد";
            this.isSell.Size = new Size(131, 30);
            this.isSell.TabIndex = 28;
            this.isSell.Toggled += this.isSell_Toggled;
            this.btnClear.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.btnClear.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnClear.ImageOptions.Image");
            this.btnClear.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnClear.Location = new Point(14, 545);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(130, 42);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "تصفير";
            this.btnClear.Click += this.btnClear_Click;
            this.grpTotal.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.grpTotal.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpTotal.CaptionImageOptions.Image");
            this.grpTotal.Controls.Add(this.txtTotal);
            this.grpTotal.Location = new Point(441, 481);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new Size(274, 58);
            this.grpTotal.TabIndex = 7;
            this.grpTotal.Text = "المجموع الكلي";
            this.txtTotal.Dock = DockStyle.Fill;
            this.txtTotal.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtTotal.Location = new Point(2, 23);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new Size(270, 30);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = HorizontalAlignment.Center;
            this.groupControl5.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.groupControl5.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("groupControl5.CaptionImageOptions.Image");
            this.groupControl5.Controls.Add(this.txtDiscount);
            this.groupControl5.Location = new Point(150, 481);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new Size(130, 58);
            this.groupControl5.TabIndex = 5;
            this.groupControl5.Text = "خصم";
            this.txtDiscount.Dock = DockStyle.Fill;
            this.txtDiscount.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtDiscount.Location = new Point(2, 23);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new Size(126, 30);
            this.txtDiscount.TabIndex = 0;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = HorizontalAlignment.Center;
            this.txtDiscount.TextChanged += this.txtDiscount_TextChanged;
            this.txtDiscount.KeyPress += this.txtProductPrice_KeyPress;
            this.txtDiscount.Leave += this.txtDiscount_Leave;
            this.dgvProducts.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 200, 100);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.Columns.AddRange(this.id, this.description, this.quantity, this.price, this.total, this.note, this.delegate_percentage);
            this.dgvProducts.ContextMenuStrip = this.dgvProductMenu;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 8.25f);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(32, 31, 53);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 200, 100);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.Location = new Point(14, 100);
            this.dgvProducts.Name = "dgvProducts";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Tahoma", 8.25f);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle6.ForeColor = Color.Black;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProducts.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvProducts.RowTemplate.Height = 30;
            this.dgvProducts.SelectionMode = DataGridViewSelectionMode.CellSelect;
            this.dgvProducts.Size = new Size(701, 375);
            this.dgvProducts.TabIndex = 3;
            this.dgvProducts.CellEndEdit += this.dgvProducts_CellEndEdit;
            this.dgvProducts.CellValueChanged += this.dgvProducts_CellValueChanged;
            this.dgvProducts.EditingControlShowing += this.dgvProducts_EditingControlShowing;
            this.dgvProducts.RowLeave += this.dgvProducts_RowLeave;
            this.dgvProducts.RowsRemoved += this.dgvProducts_RowsRemoved;
            this.id.FillWeight = 9.461685f;
            this.id.HeaderText = "ت";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.description.DividerWidth = 1;
            this.description.FillWeight = 60f;
            this.description.HeaderText = "وصف المادة";
            this.description.Name = "description";
            this.quantity.DividerWidth = 1;
            this.quantity.FillWeight = 10.2869f;
            this.quantity.HeaderText = "عدد";
            this.quantity.Name = "quantity";
            this.price.DividerWidth = 1;
            this.price.FillWeight = 16.45904f;
            this.price.HeaderText = "السعر";
            this.price.Name = "price";
            this.total.DividerWidth = 1;
            this.total.FillWeight = 16.45904f;
            this.total.HeaderText = "المجموع";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.note.DividerWidth = 1;
            this.note.FillWeight = 26.74594f;
            this.note.HeaderText = "ملاحظة";
            this.note.Name = "note";
            this.delegate_percentage.FillWeight = 20f;
            this.delegate_percentage.HeaderText = "نسبة المندوب";
            this.delegate_percentage.MaxInputLength = 11;
            this.delegate_percentage.Name = "delegate_percentage";
            this.delegate_percentage.Resizable = DataGridViewTriState.False;
            this.delegate_percentage.ToolTipText = "نسبة المبدوب للمادة الواحدة. اذا وضعت صفرا\u064b 0 فسوف تكون النسبة الافتراضية هي المحسوبة";
            this.dgvProductMenu.Items.AddRange(new ToolStripItem[2]
            {
            this.تكرارالقيدToolStripMenuItem,
            this.حذفالمحددToolStripMenuItem
            });
            this.dgvProductMenu.Name = "dgvProductMenu";
            this.dgvProductMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvProductMenu.Size = new Size(136, 48);
            this.تكرارالقيدToolStripMenuItem.Name = "تكرارالقيدToolStripMenuItem";
            this.تكرارالقيدToolStripMenuItem.Size = new Size(135, 22);
            this.تكرارالقيدToolStripMenuItem.Text = "تكرار القيد";
            this.تكرارالقيدToolStripMenuItem.Click += this.تكرارالقيدToolStripMenuItem_Click;
            this.حذفالمحددToolStripMenuItem.Name = "حذفالمحددToolStripMenuItem";
            this.حذفالمحددToolStripMenuItem.Size = new Size(135, 22);
            this.حذفالمحددToolStripMenuItem.Text = "حذف المحدد";
            this.حذفالمحددToolStripMenuItem.Click += this.حذفالمحددToolStripMenuItem_Click;
            this.btnSell.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.btnSell.ContextMenuStrip = this.contextMenuStripBtnSell;
            this.btnSell.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnSell.ImageOptions.Image");
            this.btnSell.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnSell.Location = new Point(150, 545);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new Size(220, 42);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "ادخال و طباعة قائمة";
            this.btnSell.Click += this.btnSell_Click;
            this.contextMenuStripBtnSell.Items.AddRange(new ToolStripItem[1]
            {
            this.طباعةوصلقبضToolStripMenuItem
            });
            this.contextMenuStripBtnSell.Name = "contextMenuStripBtnSell";
            this.contextMenuStripBtnSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStripBtnSell.Size = new Size(163, 26);
            this.طباعةوصلقبضToolStripMenuItem.Name = "طباعةوصلقبضToolStripMenuItem";
            this.طباعةوصلقبضToolStripMenuItem.Size = new Size(162, 22);
            this.طباعةوصلقبضToolStripMenuItem.Text = "طباعة وصل قبض";
            this.طباعةوصلقبضToolStripMenuItem.Click += this.طباعةوصلقبضToolStripMenuItem_Click;
            this.grpClients.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.grpClients.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpClients.CaptionImageOptions.Image");
            this.grpClients.Controls.Add(this.cmbClients);
            this.grpClients.Location = new Point(811, 45);
            this.grpClients.Name = "grpClients";
            this.grpClients.Size = new Size(250, 51);
            this.grpClients.TabIndex = 1;
            this.cmbClients.Dock = DockStyle.Fill;
            this.cmbClients.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new Point(2, 23);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new Size(246, 27);
            this.cmbClients.TabIndex = 0;
            this.cmbClients.DropDown += this.cmbClients_DropDown;
            this.cmbClients.SelectedIndexChanged += this.cmbClients_SelectedIndexChanged;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(1073, 599);
            base.ControlBox = false;
            base.Controls.Add(this.groupControl1);
            base.FormBorderStyle = FormBorderStyle.None;
            base.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            base.WindowState = FormWindowState.Maximized;
            ((ISupportInitialize)this.groupControl1).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((ISupportInitialize)this.groupControl3).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((ISupportInitialize)this.groupControl4).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((ISupportInitialize)this.grpTotalDollarDebits).EndInit();
            this.grpTotalDollarDebits.ResumeLayout(false);
            this.grpTotalDollarDebits.PerformLayout();
            ((ISupportInitialize)this.grpTotalDinarDebits).EndInit();
            this.grpTotalDinarDebits.ResumeLayout(false);
            this.grpTotalDinarDebits.PerformLayout();
            ((ISupportInitialize)this.groupControl2).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((ISupportInitialize)this.grpDate).EndInit();
            this.grpDate.ResumeLayout(false);
            ((ISupportInitialize)this.isAccount.Properties).EndInit();
            ((ISupportInitialize)this.groupControl8).EndInit();
            this.groupControl8.ResumeLayout(false);
            this.groupControl8.PerformLayout();
            ((ISupportInitialize)this.grpDelegates).EndInit();
            this.grpDelegates.ResumeLayout(false);
            ((ISupportInitialize)this.grpInfo).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((ISupportInitialize)this.dgvClientsNames).EndInit();
            ((ISupportInitialize)this.grpPaid).EndInit();
            this.grpPaid.ResumeLayout(false);
            this.grpPaid.PerformLayout();
            ((ISupportInitialize)this.groupControl9).EndInit();
            this.groupControl9.ResumeLayout(false);
            this.contextMenuStripBills.ResumeLayout(false);
            ((ISupportInitialize)this.isDollar.Properties).EndInit();
            ((ISupportInitialize)this.isCash.Properties).EndInit();
            ((ISupportInitialize)this.isSell.Properties).EndInit();
            ((ISupportInitialize)this.grpTotal).EndInit();
            this.grpTotal.ResumeLayout(false);
            this.grpTotal.PerformLayout();
            ((ISupportInitialize)this.groupControl5).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((ISupportInitialize)this.dgvProducts).EndInit();
            this.dgvProductMenu.ResumeLayout(false);
            this.contextMenuStripBtnSell.ResumeLayout(false);
            ((ISupportInitialize)this.grpClients).EndInit();
            this.grpClients.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        #endregion

        private GroupControl groupControl1;

        private GroupControl grpDelegates;

        private System.Windows.Forms.ComboBox cmbDelegates;

        private GroupControl grpPaid;

        private TextBox txtPaid;

        private ToggleSwitch isDollar;

        private ToggleSwitch isCash;

        private GroupControl grpInfo;

        private DataGridView dgvClientsNames;

        private Label label8;

        private TextBox txtClientName;

        private Label label7;

        private Label label5;

        private TextBox txtClientEmail;

        private Label label6;

        private TextBox txtClientMobile;

        private TextBox txtClientLocation;

        private ToggleSwitch isSell;

        private GroupControl groupControl9;

        private System.Windows.Forms.ComboBox cmbBills;

        private GroupControl groupControl8;

        private TextBox txtNote;

        private ToggleSwitch isAccount;

        private SimpleButton btnClear;

        private GroupControl grpTotal;

        private TextBox txtTotal;

        private GroupControl groupControl5;

        private TextBox txtDiscount;

        private DataGridView dgvProducts;

        private SimpleButton btnSell;

        private GroupControl grpClients;

        private System.Windows.Forms.ComboBox cmbClients;

        private SimpleButton btnAdd;

        private SimpleButton btnAddClient;

        private ContextMenuStrip dgvProductMenu;

        private ToolStripMenuItem تكرارالقيدToolStripMenuItem;

        private ToolStripMenuItem حذفالمحددToolStripMenuItem;

        private DateTimePicker dateFrom;

        private GroupControl grpDate;

        private ContextMenuStrip contextMenuStripBills;

        private ToolStripMenuItem حذفالقائمةToolStripMenuItem;

        private ContextMenuStrip contextMenuStripBtnSell;

        private ToolStripMenuItem طباعةوصلقبضToolStripMenuItem;

        private DataGridViewTextBoxColumn id;

        private DataGridViewTextBoxColumn description;

        private DataGridViewTextBoxColumn quantity;

        private DataGridViewTextBoxColumn price;

        private DataGridViewTextBoxColumn total;

        private DataGridViewTextBoxColumn note;

        private DataGridViewTextBoxColumn delegate_percentage;

        private GroupControl groupControl2;

        private TextBox txtDelegateTotal;

        private GroupControl groupControl3;

        private TextBox txtTotalDollarDebitsFinal;

        private GroupControl groupControl4;

        private TextBox txtTotalDinarDebitsFinal;

        private GroupControl grpTotalDollarDebits;

        private TextBox txtTotalDollarDebits;

        private GroupControl grpTotalDinarDebits;

        private TextBox txtTotalDinarDebits;
    }
}
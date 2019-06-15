using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using HCashier.Report;
using HDatabaseConnection;
using HPress;
using HPress.Properties;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HPress
{
    public partial class ClientsImport : DevExpress.XtraEditors.XtraForm
    {
        private HMySQLConnection databaseConnection;

        private int id = 0;

        private IContainer components = null;

        private GroupControl grpClients;

        private System.Windows.Forms.ComboBox cmbClients;

        private SimpleButton btnAdd;

        private SimpleButton btnUpdate;

        private SimpleButton btnRemove;

        private GroupControl groupControl4;

        private TextBox txtBalanceValue;

        private SimpleButton btnSearch;

        private DataGridView dgvResults;

        private SimpleButton btnPrint;

        private ToggleSwitch isDollar;

        private GroupControl grpNote;

        private TextBox txtNote;

        private GroupBox grpDollar;

        private DateTimePicker date;

        private GroupBox groupBox2;

        private GroupBox groupBox3;

        private DateTimePicker dateFrom;

        private GroupBox groupBox4;

        private DateTimePicker dateTo;

        private GroupControl grpMain;

        private SimpleButton btnReportClient;

        private ContextMenuStrip contextMenuStrip1;

        private ToolStripMenuItem طباعةوصلاستلامToolStripMenuItem;

        private GroupControl grpTotalDinarDebits;

        private TextBox txtTotalDinarDebits;

        private TextBox txtTotalDollarDebits;

        private GroupControl grpTotalDollarDebits;

        private RadioGroup grpCurrency;

        private RadioGroup grpPayMethod;

        private GroupControl grpDollarDebits;

        private TextBox txtDollarDebits;

        private GroupControl grpDinarDebits;

        private TextBox txtDinarDebits;

        private GroupBox grpIsImpot;

        private ToggleSwitch isImport;
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ClientsImport));
            this.dgvResults = new DataGridView();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.طباعةوصلاستلامToolStripMenuItem = new ToolStripMenuItem();
            this.btnPrint = new SimpleButton();
            this.btnSearch = new SimpleButton();
            this.groupControl4 = new GroupControl();
            this.txtBalanceValue = new TextBox();
            this.btnRemove = new SimpleButton();
            this.btnUpdate = new SimpleButton();
            this.btnAdd = new SimpleButton();
            this.grpClients = new GroupControl();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.isDollar = new ToggleSwitch();
            this.grpNote = new GroupControl();
            this.txtNote = new TextBox();
            this.grpDollar = new GroupBox();
            this.date = new DateTimePicker();
            this.groupBox2 = new GroupBox();
            this.groupBox3 = new GroupBox();
            this.dateFrom = new DateTimePicker();
            this.groupBox4 = new GroupBox();
            this.dateTo = new DateTimePicker();
            this.grpMain = new GroupControl();
            this.grpIsImpot = new GroupBox();
            this.isImport = new ToggleSwitch();
            this.grpDollarDebits = new GroupControl();
            this.txtDollarDebits = new TextBox();
            this.grpDinarDebits = new GroupControl();
            this.txtDinarDebits = new TextBox();
            this.grpPayMethod = new RadioGroup();
            this.grpCurrency = new RadioGroup();
            this.grpTotalDollarDebits = new GroupControl();
            this.txtTotalDollarDebits = new TextBox();
            this.grpTotalDinarDebits = new GroupControl();
            this.txtTotalDinarDebits = new TextBox();
            this.btnReportClient = new SimpleButton();
            ((ISupportInitialize)this.dgvResults).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((ISupportInitialize)this.groupControl4).BeginInit();
            this.groupControl4.SuspendLayout();
            ((ISupportInitialize)this.grpClients).BeginInit();
            this.grpClients.SuspendLayout();
            ((ISupportInitialize)this.isDollar.Properties).BeginInit();
            ((ISupportInitialize)this.grpNote).BeginInit();
            this.grpNote.SuspendLayout();
            this.grpDollar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((ISupportInitialize)this.grpMain).BeginInit();
            this.grpMain.SuspendLayout();
            this.grpIsImpot.SuspendLayout();
            ((ISupportInitialize)this.isImport.Properties).BeginInit();
            ((ISupportInitialize)this.grpDollarDebits).BeginInit();
            this.grpDollarDebits.SuspendLayout();
            ((ISupportInitialize)this.grpDinarDebits).BeginInit();
            this.grpDinarDebits.SuspendLayout();
            ((ISupportInitialize)this.grpPayMethod.Properties).BeginInit();
            ((ISupportInitialize)this.grpCurrency.Properties).BeginInit();
            ((ISupportInitialize)this.grpTotalDollarDebits).BeginInit();
            this.grpTotalDollarDebits.SuspendLayout();
            ((ISupportInitialize)this.grpTotalDinarDebits).BeginInit();
            this.grpTotalDinarDebits.SuspendLayout();
            base.SuspendLayout();
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle.BackColor = Color.White;
            dataGridViewCellStyle.ForeColor = Color.Black;
            this.dgvResults.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
            this.dgvResults.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 8.25f);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 8f);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            this.dgvResults.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResults.Location = new Point(12, 106);
            this.dgvResults.Name = "dgvResults";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 8.25f);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            this.dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvResults.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new Size(381, 529);
            this.dgvResults.TabIndex = 28;
            this.dgvResults.CellClick += this.dgvResults_CellClick_1;
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[1]
            {
            this.طباعةوصلاستلامToolStripMenuItem
            });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new Size(168, 26);
            this.طباعةوصلاستلامToolStripMenuItem.Name = "طباعةوصلاستلامToolStripMenuItem";
            this.طباعةوصلاستلامToolStripMenuItem.Size = new Size(167, 22);
            this.طباعةوصلاستلامToolStripMenuItem.Text = "طباعة وصل استلام";
            this.طباعةوصلاستلامToolStripMenuItem.Click += this.طباعةوصلاستلامToolStripMenuItem_Click;
            this.btnPrint.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnPrint.ImageOptions.Image");
            this.btnPrint.ImageOptions.Location = ImageLocation.MiddleCenter;
            this.btnPrint.Location = new Point(12, 36);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new Size(44, 57);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Click += this.btnPrint_Click;
            this.btnSearch.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnSearch.ImageOptions.Image");
            this.btnSearch.ImageOptions.Location = ImageLocation.MiddleCenter;
            this.btnSearch.Location = new Point(62, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new Size(44, 57);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Click += this.btnSearch_Click;
            this.groupControl4.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.groupControl4.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("groupControl4.CaptionImageOptions.Image");
            this.groupControl4.Controls.Add(this.txtBalanceValue);
            this.groupControl4.Location = new Point(601, 245);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new Size(175, 57);
            this.groupControl4.TabIndex = 25;
            this.groupControl4.Text = "الرصيد";
            this.txtBalanceValue.Dock = DockStyle.Fill;
            this.txtBalanceValue.Font = new Font("Tahoma", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtBalanceValue.Location = new Point(2, 21);
            this.txtBalanceValue.Name = "txtBalanceValue";
            this.txtBalanceValue.Size = new Size(171, 36);
            this.txtBalanceValue.TabIndex = 0;
            this.txtBalanceValue.TextChanged += this.txtBalanceValue_TextChanged;
            this.txtBalanceValue.KeyPress += this.txtBalanceValue_KeyPress;
            this.btnRemove.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnRemove.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnRemove.Appearance.Options.UseFont = true;
            this.btnRemove.Enabled = false;
            this.btnRemove.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnRemove.ImageOptions.Image");
            this.btnRemove.ImageOptions.Location = ImageLocation.MiddleRight;
            this.btnRemove.Location = new Point(399, 577);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new Size(82, 37);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "حذف";
            this.btnRemove.Click += this.btnRemove_Click;
            this.btnUpdate.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnUpdate.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnUpdate.ImageOptions.Image");
            this.btnUpdate.ImageOptions.Location = ImageLocation.MiddleRight;
            this.btnUpdate.Location = new Point(694, 577);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(82, 37);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.Click += this.btnUpdate_Click;
            this.btnAdd.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnAdd.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnAdd.ImageOptions.Image");
            this.btnAdd.ImageOptions.Location = ImageLocation.MiddleRight;
            this.btnAdd.Location = new Point(399, 534);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(377, 37);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "أضافة";
            this.btnAdd.Click += this.btnAdd_Click;
            this.grpClients.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.grpClients.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpClients.CaptionImageOptions.Image");
            this.grpClients.Controls.Add(this.cmbClients);
            this.grpClients.Location = new Point(399, 171);
            this.grpClients.Name = "grpClients";
            this.grpClients.Size = new Size(377, 56);
            this.grpClients.TabIndex = 21;
            this.grpClients.Text = "العملاء";
            this.cmbClients.Dock = DockStyle.Fill;
            this.cmbClients.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new Point(2, 21);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new Size(373, 27);
            this.cmbClients.TabIndex = 0;
            this.cmbClients.SelectedIndexChanged += this.cmbClients_SelectedIndexChanged;
            this.isDollar.Dock = DockStyle.Fill;
            this.isDollar.Location = new Point(3, 23);
            this.isDollar.Name = "isDollar";
            this.isDollar.Properties.Appearance.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.isDollar.Properties.Appearance.ForeColor = Color.FromArgb(255, 183, 0);
            this.isDollar.Properties.Appearance.Options.UseFont = true;
            this.isDollar.Properties.Appearance.Options.UseForeColor = true;
            this.isDollar.Properties.OffText = "";
            this.isDollar.Properties.OnText = "";
            this.isDollar.Size = new Size(88, 32);
            this.isDollar.TabIndex = 20;
            this.isDollar.Toggled += this.isDollar_Toggled;
            this.grpNote.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.grpNote.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpNote.CaptionImageOptions.Image");
            this.grpNote.Controls.Add(this.txtNote);
            this.grpNote.Location = new Point(399, 372);
            this.grpNote.Name = "grpNote";
            this.grpNote.Size = new Size(377, 156);
            this.grpNote.TabIndex = 32;
            this.grpNote.Text = "ملاحظة";
            this.txtNote.Dock = DockStyle.Fill;
            this.txtNote.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtNote.Location = new Point(2, 21);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new Size(373, 133);
            this.txtNote.TabIndex = 0;
            this.grpDollar.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.grpDollar.Controls.Add(this.isDollar);
            this.grpDollar.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.grpDollar.ForeColor = Color.FromArgb(255, 185, 0);
            this.grpDollar.Location = new Point(401, 244);
            this.grpDollar.Name = "grpDollar";
            this.grpDollar.Size = new Size(94, 58);
            this.grpDollar.TabIndex = 34;
            this.grpDollar.TabStop = false;
            this.grpDollar.Text = "IQD";
            this.date.Cursor = Cursors.Default;
            this.date.CustomFormat = "dd/MM/yyyy";
            this.date.Dock = DockStyle.Fill;
            this.date.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.date.Format = DateTimePickerFormat.Custom;
            this.date.Location = new Point(3, 23);
            this.date.Name = "date";
            this.date.Size = new Size(371, 27);
            this.date.TabIndex = 35;
            this.groupBox2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox2.ForeColor = Color.FromArgb(255, 185, 0);
            this.groupBox2.Location = new Point(399, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(377, 58);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تاريخ";
            this.groupBox3.Controls.Add(this.dateFrom);
            this.groupBox3.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox3.ForeColor = Color.FromArgb(255, 185, 0);
            this.groupBox3.Location = new Point(236, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new Size(118, 58);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "من";
            this.dateFrom.Cursor = Cursors.Default;
            this.dateFrom.CustomFormat = "dd/MM/yyyy";
            this.dateFrom.Dock = DockStyle.Fill;
            this.dateFrom.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateFrom.Format = DateTimePickerFormat.Custom;
            this.dateFrom.Location = new Point(3, 23);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new Size(112, 27);
            this.dateFrom.TabIndex = 35;
            this.groupBox4.Controls.Add(this.dateTo);
            this.groupBox4.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox4.ForeColor = Color.FromArgb(255, 185, 0);
            this.groupBox4.Location = new Point(112, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new Size(118, 58);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "الى";
            this.dateTo.Cursor = Cursors.Default;
            this.dateTo.CustomFormat = "dd/MM/yyyy";
            this.dateTo.Dock = DockStyle.Fill;
            this.dateTo.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.dateTo.Format = DateTimePickerFormat.Custom;
            this.dateTo.Location = new Point(3, 23);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new Size(112, 27);
            this.dateTo.TabIndex = 35;
            this.grpMain.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpMain.CaptionImageOptions.Image");
            this.grpMain.Controls.Add(this.grpIsImpot);
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
            this.grpMain.Dock = DockStyle.Fill;
            this.grpMain.Location = new Point(0, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new Size(786, 711);
            this.grpMain.TabIndex = 39;
            this.grpMain.Text = "واردات العملاء";
            this.grpIsImpot.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.grpIsImpot.Controls.Add(this.isImport);
            this.grpIsImpot.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.grpIsImpot.ForeColor = Color.FromArgb(255, 185, 0);
            this.grpIsImpot.Location = new Point(501, 246);
            this.grpIsImpot.Name = "grpIsImpot";
            this.grpIsImpot.Size = new Size(94, 58);
            this.grpIsImpot.TabIndex = 46;
            this.grpIsImpot.TabStop = false;
            this.grpIsImpot.Text = "وارد";
            this.isImport.Dock = DockStyle.Fill;
            this.isImport.EditValue = true;
            this.isImport.Location = new Point(3, 23);
            this.isImport.Name = "isImport";
            this.isImport.Properties.Appearance.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.isImport.Properties.Appearance.ForeColor = Color.FromArgb(255, 183, 0);
            this.isImport.Properties.Appearance.Options.UseFont = true;
            this.isImport.Properties.Appearance.Options.UseForeColor = true;
            this.isImport.Properties.OffText = "";
            this.isImport.Properties.OnText = "";
            this.isImport.Size = new Size(88, 32);
            this.isImport.TabIndex = 20;
            this.isImport.Toggled += this.isImport_Toggled;
            this.grpDollarDebits.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left);
            this.grpDollarDebits.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpDollarDebits.CaptionImageOptions.Image");
            this.grpDollarDebits.Controls.Add(this.txtDollarDebits);
            this.grpDollarDebits.Location = new Point(12, 642);
            this.grpDollarDebits.Name = "grpDollarDebits";
            this.grpDollarDebits.Size = new Size(164, 57);
            this.grpDollarDebits.TabIndex = 45;
            this.grpDollarDebits.Text = "$";
            this.txtDollarDebits.BackColor = Color.FromArgb(255, 192, 192);
            this.txtDollarDebits.Dock = DockStyle.Fill;
            this.txtDollarDebits.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtDollarDebits.Location = new Point(2, 21);
            this.txtDollarDebits.Name = "txtDollarDebits";
            this.txtDollarDebits.ReadOnly = true;
            this.txtDollarDebits.Size = new Size(160, 30);
            this.txtDollarDebits.TabIndex = 1;
            this.txtDollarDebits.TextAlign = HorizontalAlignment.Center;
            this.grpDinarDebits.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.grpDinarDebits.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.grpDinarDebits.Appearance.Options.UseFont = true;
            this.grpDinarDebits.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpDinarDebits.CaptionImageOptions.Image");
            this.grpDinarDebits.Controls.Add(this.txtDinarDebits);
            this.grpDinarDebits.Location = new Point(189, 642);
            this.grpDinarDebits.Name = "grpDinarDebits";
            this.grpDinarDebits.Size = new Size(204, 57);
            this.grpDinarDebits.TabIndex = 44;
            this.grpDinarDebits.Text = "IQD";
            this.txtDinarDebits.BackColor = Color.FromArgb(192, 255, 192);
            this.txtDinarDebits.Dock = DockStyle.Fill;
            this.txtDinarDebits.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtDinarDebits.Location = new Point(2, 21);
            this.txtDinarDebits.Name = "txtDinarDebits";
            this.txtDinarDebits.ReadOnly = true;
            this.txtDinarDebits.Size = new Size(200, 30);
            this.txtDinarDebits.TabIndex = 0;
            this.txtDinarDebits.TextAlign = HorizontalAlignment.Center;
            this.grpPayMethod.EditValue = 0;
            this.grpPayMethod.Location = new Point(422, 36);
            this.grpPayMethod.Name = "grpPayMethod";
            this.grpPayMethod.Properties.Items.AddRange(new RadioGroupItem[2]
            {
            new RadioGroupItem(1, "قوائم"),
            new RadioGroupItem(0, "دفعات")
            });
            this.grpPayMethod.Size = new Size(59, 57);
            this.grpPayMethod.TabIndex = 43;
            this.grpCurrency.EditValue = 2;
            this.grpCurrency.Location = new Point(360, 36);
            this.grpCurrency.Name = "grpCurrency";
            this.grpCurrency.Properties.Items.AddRange(new RadioGroupItem[3]
            {
            new RadioGroupItem(2, "الكل"),
            new RadioGroupItem(0, "دينار"),
            new RadioGroupItem(1, "دولار")
            });
            this.grpCurrency.Size = new Size(56, 60);
            this.grpCurrency.TabIndex = 42;
            this.grpTotalDollarDebits.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.grpTotalDollarDebits.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpTotalDollarDebits.CaptionImageOptions.Image");
            this.grpTotalDollarDebits.Controls.Add(this.txtTotalDollarDebits);
            this.grpTotalDollarDebits.Location = new Point(404, 106);
            this.grpTotalDollarDebits.Name = "grpTotalDollarDebits";
            this.grpTotalDollarDebits.Size = new Size(164, 57);
            this.grpTotalDollarDebits.TabIndex = 41;
            this.grpTotalDollarDebits.Text = "$";
            this.txtTotalDollarDebits.BackColor = Color.FromArgb(255, 192, 192);
            this.txtTotalDollarDebits.Dock = DockStyle.Fill;
            this.txtTotalDollarDebits.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtTotalDollarDebits.Location = new Point(2, 21);
            this.txtTotalDollarDebits.Name = "txtTotalDollarDebits";
            this.txtTotalDollarDebits.Size = new Size(160, 30);
            this.txtTotalDollarDebits.TabIndex = 1;
            this.txtTotalDollarDebits.TextAlign = HorizontalAlignment.Center;
            this.grpTotalDinarDebits.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.grpTotalDinarDebits.Appearance.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.grpTotalDinarDebits.Appearance.Options.UseFont = true;
            this.grpTotalDinarDebits.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpTotalDinarDebits.CaptionImageOptions.Image");
            this.grpTotalDinarDebits.Controls.Add(this.txtTotalDinarDebits);
            this.grpTotalDinarDebits.Location = new Point(572, 106);
            this.grpTotalDinarDebits.Name = "grpTotalDinarDebits";
            this.grpTotalDinarDebits.Size = new Size(204, 57);
            this.grpTotalDinarDebits.TabIndex = 40;
            this.grpTotalDinarDebits.Text = "IQD";
            this.txtTotalDinarDebits.BackColor = Color.FromArgb(192, 255, 192);
            this.txtTotalDinarDebits.Dock = DockStyle.Fill;
            this.txtTotalDinarDebits.Font = new Font("Tahoma", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtTotalDinarDebits.Location = new Point(2, 21);
            this.txtTotalDinarDebits.Name = "txtTotalDinarDebits";
            this.txtTotalDinarDebits.Size = new Size(200, 30);
            this.txtTotalDinarDebits.TabIndex = 0;
            this.txtTotalDinarDebits.TextAlign = HorizontalAlignment.Center;
            this.btnReportClient.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnReportClient.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnReportClient.Appearance.Options.UseFont = true;
            this.btnReportClient.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnReportClient.ImageOptions.Image");
            this.btnReportClient.ImageOptions.Location = ImageLocation.MiddleRight;
            this.btnReportClient.Location = new Point(399, 620);
            this.btnReportClient.Name = "btnReportClient";
            this.btnReportClient.Size = new Size(377, 37);
            this.btnReportClient.TabIndex = 39;
            this.btnReportClient.Text = "تقرير العميل";
            this.btnReportClient.Click += this.btnReportClient_Click;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(786, 711);
            base.Controls.Add(this.grpMain);
            base.FormBorderStyle = FormBorderStyle.None;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "ClientsImport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            ((ISupportInitialize)this.dgvResults).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((ISupportInitialize)this.groupControl4).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((ISupportInitialize)this.grpClients).EndInit();
            this.grpClients.ResumeLayout(false);
            ((ISupportInitialize)this.isDollar.Properties).EndInit();
            ((ISupportInitialize)this.grpNote).EndInit();
            this.grpNote.ResumeLayout(false);
            this.grpNote.PerformLayout();
            this.grpDollar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((ISupportInitialize)this.grpMain).EndInit();
            this.grpMain.ResumeLayout(false);
            this.grpIsImpot.ResumeLayout(false);
            ((ISupportInitialize)this.isImport.Properties).EndInit();
            ((ISupportInitialize)this.grpDollarDebits).EndInit();
            this.grpDollarDebits.ResumeLayout(false);
            this.grpDollarDebits.PerformLayout();
            ((ISupportInitialize)this.grpDinarDebits).EndInit();
            this.grpDinarDebits.ResumeLayout(false);
            this.grpDinarDebits.PerformLayout();
            ((ISupportInitialize)this.grpPayMethod.Properties).EndInit();
            ((ISupportInitialize)this.grpCurrency.Properties).EndInit();
            ((ISupportInitialize)this.grpTotalDollarDebits).EndInit();
            this.grpTotalDollarDebits.ResumeLayout(false);
            this.grpTotalDollarDebits.PerformLayout();
            ((ISupportInitialize)this.grpTotalDinarDebits).EndInit();
            this.grpTotalDinarDebits.ResumeLayout(false);
            this.grpTotalDinarDebits.PerformLayout();
            base.ResumeLayout(false);
        }
        public ClientsImport(HMySQLConnection databaseConnection)
        {
            this.InitializeComponent();
            this.databaseConnection = databaseConnection;
            this.grpClientType_SelectedIndexChanged(null, null);
        }

        private void txtBalanceValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.');
        }

        private void reloadData()
        {
            this.dgvResults.Columns.Clear();
            DataGridView dataGridView = this.dgvResults;
            HMySQLConnection hMySQLConnection = this.databaseConnection;
            object[] obj = new object[5]
            {
            (this.cmbClients.Text == "الكل") ? "" : (" and tbl_clients.name = '" + this.cmbClients.Text + "' "),
            null,
            null,
            null,
            null
            };
            DateTime value = this.dateFrom.Value;
            obj[1] = value.ToString("yyyy-MM-dd 00:00:00");
            value = this.dateTo.Value;
            obj[2] = value.ToString("yyyy-MM-dd 23:59:59");
            obj[3] = (((int)this.grpPayMethod.EditValue == 1) ? "id" : "balance_pay_id");
            obj[4] = (this.isImport.IsOn ? "1" : "0");
            dataGridView.DataSource = hMySQLConnection.query(string.Format("select tbl_balance.id,tbl_clients.name,tbl_balance.bill_id,if(tbl_balance.is_import = 1,'وارد','صادر') as `is_import`,DATE_FORMAT(tbl_balance.creation,'%Y-%m-%d') as `creation`,if(tbl_balance.is_dollar = 1,CONCAT('$ ',getDollar(tbl_balance.creation)),'IQD') as `is_dollar`,sum(tbl_balance.value) as `value`,tbl_balance.note from tbl_balance,tbl_clients where tbl_clients.id = tbl_balance.client_id and tbl_clients.type = 0 {0} and tbl_balance.creation between '{1}' and '{2}' and tbl_balance.is_import = '{4}' group by tbl_balance.{3} order by type asc", obj));
            this.dgvResults.Columns["id"].Visible = false;
            this.dgvResults.Columns["bill_id"].HeaderText = "القائمة";
            this.dgvResults.Columns["is_import"].HeaderText = "العملية";
            this.dgvResults.Columns["name"].HeaderText = "العميل";
            this.dgvResults.Columns["is_dollar"].HeaderText = "العملة";
            this.dgvResults.Columns["value"].HeaderText = "القيمة";
            this.dgvResults.Columns["creation"].HeaderText = "التاريخ";
            this.dgvResults.Columns["note"].HeaderText = "ملاحظة";
            TextBox textBox = this.txtBalanceValue;
            TextBox textBox2 = this.txtNote;
            string text3 = textBox.Text = (textBox2.Text = "");
            double num = 0.0;
            double num2 = 0.0;
            foreach (DataGridViewRow item in (IEnumerable)this.dgvResults.Rows)
            {
                num += double.Parse(item.Cells["value"].Value.ToString()) * (double)(item.Cells["is_dollar"].Value.ToString().Contains("IQD") ? 1 : 0);
                num2 += double.Parse(item.Cells["value"].Value.ToString()) * (double)(item.Cells["is_dollar"].Value.ToString().Contains("$") ? 1 : 0);
            }
            this.txtDinarDebits.Text = ((num == 0.0) ? "0" : num.ToString("#,###"));
            this.txtDollarDebits.Text = ((num2 == 0.0) ? "0" : num2.ToString("#.##"));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtBalanceValue.Text != string.Empty && this.cmbClients.Text != string.Empty && this.cmbClients.Text != "الكل")
            {
                if ((this.isDollar.IsOn && (this.txtTotalDollarDebits.Text == "0" || this.txtTotalDollarDebits.Text == "")) || (!this.isDollar.IsOn && (this.txtTotalDinarDebits.Text == "0" || this.txtTotalDinarDebits.Text == "")))
                {
                    MessageBox.Show("لم يتم الادخال. لان المبلغ المطلوب صفرا");
                }
                else
                {
                    DataTable dataTable = this.databaseConnection.query(string.Format("select getDollar(tbl_bills.datetime) as `dollarValue`,tbl_bills.is_dollar,tbl_bills.id,ifnull(((((select sum(tbl_products.count * tbl_products.price) from tbl_products where tbl_products.bill_id = tbl_bills.id) -(tbl_bills.discount))) -  ifnull(( select sum(tbl_balance.value)  from tbl_balance where tbl_balance.bill_id = tbl_bills.id),0)) ,0) as `remaining` from tbl_bills, tbl_clients where tbl_bills.id > 0 and tbl_bills.is_cash = 0 and tbl_bills.is_sell = '{1}' and tbl_clients.id > 1 and tbl_clients.id = tbl_bills.client_id and tbl_clients.name = '{0}' and ifnull(((((select sum(tbl_products.count * tbl_products.price) from tbl_products where tbl_products.bill_id = tbl_bills.id) -(tbl_bills.discount))) -  ifnull(( select sum(tbl_balance.value)  from tbl_balance where tbl_balance.bill_id = tbl_bills.id),0)) ,0)  > 0 order by tbl_bills.datetime", this.cmbClients.Text, this.isImport.IsOn ? "1" : "0"));
                    double num = double.Parse(this.txtBalanceValue.Text.Replace(",", ""));
                    double num2 = 0.0;
                    double num3 = 0.0;
                    bool flag = false;
                    double dollarValue = Settings.Default.dollarValue;
                    int num4 = 0;
                    int num5 = 0;
                    bool flag2 = false;
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        flag = bool.Parse(dataTable.Rows[i]["is_dollar"].ToString());
                        if (flag == this.isDollar.IsOn)
                        {
                            num2 = double.Parse(dataTable.Rows[i]["remaining"].ToString());
                            dollarValue = double.Parse(dataTable.Rows[i]["dollarValue"].ToString());
                            num = ((flag == this.isDollar.IsOn) ? num : ((flag && !this.isDollar.IsOn) ? (num * Settings.Default.dollarValue) : (num / Settings.Default.dollarValue)));
                            num4 = int.Parse(dataTable.Rows[i]["id"].ToString());
                            if (!flag2)
                            {
                                num5 = int.Parse(this.databaseConnection.query("insert into tbl_balance_pay () values (); select id from tbl_balance_pay order by id desc limit 0,1 ").Rows[0][0].ToString());
                            }
                            if (!(num <= 0.0))
                            {
                                if (num <= num2 && num > 0.0)
                                {
                                    num3 = num;
                                    dataTable.Rows[i]["remaining"] = num2 - num;
                                    num = 0.0;
                                    i--;
                                }
                                else if (num > num2)
                                {
                                    num3 = num2;
                                    num -= num2;
                                    flag2 = true;
                                }
                                this.databaseConnection.queryNonReader(string.Format("insert into tbl_balance (client_id,value,is_dollar,is_import,bill_id,creation,note,balance_pay_id) values ((select id from tbl_clients where name = '{0}' and type = '0'),'{1}','{2}','{8}','{6}','{4}','{5}','{7}');", this.cmbClients.Text, num3, this.isDollar.IsOn ? "1" : "0", "0", this.date.Value.ToString("yyyy-MM-dd 00:00:00"), this.txtNote.Text, num4, num5, this.isImport.IsOn ? "1" : "0"));
                                continue;
                            }
                            break;
                        }
                    }
                    this.reloadData();
                    this.cmbClients_SelectedIndexChanged(null, null);
                }
            }
        }

        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = int.Parse(this.dgvResults.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.databaseConnection.queryNonReader(string.Format("update tbl_balance set tbl_balance.client_id = (select id from tbl_clients where name = '{0}'  and type = 0),tbl_balance.is_dollar = '{1}',tbl_balance.value = '{2}',tbl_balance.is_import = '{3}' ,tbl_balance.note = '{4}',tbl_balance.creation = '{5}' where tbl_balance.id = '{6}';", this.cmbClients.Text, this.isDollar.IsOn ? "1" : "0", this.txtBalanceValue.Text.Replace(",", ""), this.isImport.IsOn ? "1" : "0", this.txtNote.Text, this.date.Value.ToString("yyyy-MM-dd 00:00:00"), this.id));
            this.reloadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.reloadData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.databaseConnection.queryNonReader(string.Format("delete from tbl_balance where id = '{0}'", this.id));
            this.reloadData();
        }

        private void dgvResults_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.id = int.Parse(this.dgvResults.Rows[e.RowIndex].Cells["id"].Value.ToString());
                this.cmbClients.Text = this.dgvResults.Rows[e.RowIndex].Cells["name"].Value.ToString();
                this.isDollar.IsOn = ((byte)((this.dgvResults.Rows[e.RowIndex].Cells["is_dollar"].Value.ToString() == "True") ? 1 : 0) != 0);
                this.txtBalanceValue.Text = this.dgvResults.Rows[e.RowIndex].Cells["value"].Value.ToString();
                this.date.Value = DateTime.Parse(this.dgvResults.Rows[e.RowIndex].Cells["creation"].Value.ToString());
                this.txtNote.Text = this.dgvResults.Rows[e.RowIndex].Cells["note"].Value.ToString();
                SimpleButton simpleButton = this.btnUpdate;
                SimpleButton simpleButton2 = this.btnRemove;
                bool enabled = simpleButton2.Enabled = true;
                simpleButton.Enabled = enabled;
            }
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnAdd.Enabled = (this.cmbClients.SelectedIndex != 0);
            DataTable dataTable = this.databaseConnection.query(string.Format("select ifnull(sum(ifnull( ( ifnull((select SUM(IF(tbl_balance.is_dollar = 1 ,tbl_balance.value * getDollar(tbl_balance.creation),tbl_balance.value)) from tbl_balance,tbl_bills where tbl_balance.client_id = tbl_clients.id and tbl_bills.id = tbl_balance.bill_id and tbl_bills.is_sell = '{1}' and tbl_balance.is_import = '{1}'),0)- ifnull((select sum(if(tbl_bills.is_dollar = 0,tbl_products.price  * tbl_products.count,tbl_products.price*getDollar(tbl_bills.datetime)  * tbl_products.count)) from tbl_products,tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = '{1}'),0)+ ifnull((select sum(ifnull(if(tbl_bills.is_dollar = 1,tbl_bills.discount * getDollar(tbl_bills.`datetime`),tbl_bills.discount),0)) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = '{1}'),0)),0)),0) as remaining, ifnull(abs(sum(ifnull( ( /*Balances*/ ifnull( ( select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 1 and tbl_balance.is_import = '{1}' ) ,0) - ( /*Bills*/ ifnull( ( select sum( ( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ) ) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1 and tbl_bills.is_cash = 0 and tbl_bills.is_sell = '{1}') ,0) - /*Discounts*/ ifnull( ( select sum(tbl_bills.discount) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1 and tbl_bills.is_cash = 0 and tbl_bills.is_sell = '{1}') ,0) ) ) ,0))),0) as `remaining_dollar`, ifnull(abs(sum(ifnull( ( /*Balances*/ ifnull( ( select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 0 and tbl_balance.is_import = '{1}') ,0) - ( \t/*Bills*/ ifnull( ( select sum( ( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ) ) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0 and tbl_bills.is_cash = 0 and tbl_bills.is_cash = 0 and tbl_bills.is_sell = '{1}'),0)-/*Discounts*/ifnull(( select sum(tbl_bills.discount) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0 and tbl_bills.is_cash = 0 and tbl_bills.is_sell = '{1}' ) ,0) ) ) ,0))),0) as `remaining_dinar` from  tbl_clients where tbl_clients.type = 0 {0}", (this.cmbClients.Text == "الكل") ? "" : (" and tbl_clients.name = '" + this.cmbClients.Text + "' "), this.isImport.IsOn ? "1" : "0"));
            TextBox textBox = this.txtTotalDollarDebits;
            double num = double.Parse(dataTable.Rows[0][1].ToString());
            textBox.Text = string.Format("{0}", num.ToString("#.##"));
            this.txtTotalDollarDebits.Text = ((this.txtTotalDollarDebits.Text == "") ? "0" : this.txtTotalDollarDebits.Text);
            TextBox textBox2 = this.txtTotalDinarDebits;
            num = double.Parse(dataTable.Rows[0][2].ToString());
            textBox2.Text = string.Format("{0}", num.ToString("#,###"));
            this.txtTotalDinarDebits.Text = ((this.txtTotalDinarDebits.Text == "") ? "0" : this.txtTotalDinarDebits.Text);
            GroupControl groupControl = this.grpClients;
            num = double.Parse(dataTable.Rows[0]["remaining"].ToString());
            string arg = num.ToString("#,###");
            num = double.Parse(dataTable.Rows[0]["remaining"].ToString()) / Settings.Default.dollarValue;
            groupControl.Text = string.Format("({0} IQD : {1} $)", arg, num.ToString("#.##"));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            HMySQLConnection hMySQLConnection = this.databaseConnection;
            string[] obj = new string[3]
            {
            this.cmbClients.Text,
            null,
            null
            };
            DateTime value = this.dateFrom.Value;
            obj[1] = value.ToString("yyyy-MM-dd 00:00:00");
            value = this.dateTo.Value;
            obj[2] = value.ToString("yyyy-MM-dd 23:59:59");
            Reports reports = new Reports(hMySQLConnection, Enumerators.ReportsName.ClientPay, obj);
            reports.Hide();
        }

        private void rdoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.grpClients.Text = "العملاء";
        }

        private void txtBalanceValue_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0 && !(sender as TextBox).Text.Contains("."))
            {
                (sender as TextBox).Text = double.Parse((sender as TextBox).Text).ToString("#,###");
                (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
            }
        }

        private void isDollar_Toggled(object sender, EventArgs e)
        {
            this.grpDollar.Text = (this.isDollar.IsOn ? "$" : "IQD");
        }

        private void btnReportClient_Click(object sender, EventArgs e)
        {
            HMySQLConnection hMySQLConnection = this.databaseConnection;
            string[] obj = new string[3]
            {
            this.cmbClients.Text,
            null,
            null
            };
            DateTime value = this.dateFrom.Value;
            obj[1] = value.ToString("yyyy-MM-dd 00:00:00");
            value = this.dateTo.Value;
            obj[2] = value.ToString("yyyy-MM-dd 23:59:59");
            Reports reports = new Reports(hMySQLConnection, Enumerators.ReportsName.Client, obj);
            reports.Hide();
        }

        private void طباعةوصلاستلامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = this.dgvResults.CurrentRow;
            DataTable dataTable = this.databaseConnection.query(string.Format("select sum(ifnull( ( ifnull( ( select  SUM(tbl_balance.value * IF(tbl_balance.is_dollar = 1 ,getDollar(null),1))  from tbl_balance, tbl_bills where tbl_balance.client_id = tbl_clients.id and tbl_bills.id = tbl_balance.bill_id and tbl_bills.is_sell = 1 and tbl_balance.is_import = '{1}' ) ,0) - ifnull( ( select sum((tbl_products.price  * tbl_products.count) * if(tbl_bills.is_dollar = 1,getDollar(null),1)) from tbl_products,tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 ) ,0) + ifnull( ( select sum(tbl_bills.discount * if(tbl_bills.is_dollar = 1,getDollar(null),1)) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 ) ,0) ) ,0)) as `remaining`, abs(sum(ifnull( ( /*Balances*/ ifnull( ( select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 1 and tbl_balance.creation between '{0}' and '{1}') ,0) - ( /*Bills*/ ifnull( ( select sum( ( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ) ) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1 and tbl_bills.datetime between '{0}' and '{1}' and tbl_bills.is_cash = 0) ,0) - /*Discounts*/ ifnull( ( select sum(tbl_bills.discount) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1 and tbl_bills.datetime between '{0}' and '{1}') ,0) ) ) ,0))) as `remaining_dollar`,abs(sum(ifnull((/*Balances*/ ifnull( ( select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 0 and tbl_balance.creation between '{0}' and '{1}' ) ,0) - ( /*Bills*/  ifnull( ( select sum( ( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ) ) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0 and tbl_bills.datetime between '{0}' and '{1}' and tbl_bills.is_cash = 0),0) - /*Discounts*/ ifnull(( select sum(tbl_bills.discount) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0 and tbl_bills.datetime between '{0}' and '{1}' ),0) )),0))) as `remaining_dinar` from  tbl_clients where tbl_clients.type = 0 and tbl_clients.name = '{0}'", currentRow.Cells["name"].Value.ToString(), currentRow.Cells["creation"].Value.ToString()));
            ReportPrintTool reportPrintTool = new ReportPrintTool(new ArrivedCatch(this.id, this.cmbClients.Text, double.Parse(this.txtBalanceValue.Text), this.dateFrom.Value, currentRow.Cells["is_dollar"].Value.ToString().Contains("$") ? double.Parse(dataTable.Rows[0][1].ToString()) : double.Parse(dataTable.Rows[0][2].ToString()), !currentRow.Cells["is_dollar"].Value.ToString().Contains("$"), this.txtNote.Text, this.isImport.IsOn));
            reportPrintTool.PrintDialog();
        }

        private void grpClientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbClients.Items.Clear();
            this.cmbClients.Items.Add("الكل");
            DataTable dataTable = this.databaseConnection.query(string.Format("select name from tbl_clients where tbl_clients.type = 0 and {0};", this.isImport.IsOn ? " is_import = '1'" : " is_export = '1'"));
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    this.cmbClients.Items.Add(dataTable.Rows[i][0].ToString());
                }
            }
            this.cmbClients.Text = this.cmbClients.Items[0].ToString();
            this.cmbClients_SelectedIndexChanged(null, null);
        }

        private void isImport_Toggled(object sender, EventArgs e)
        {
            this.grpIsImpot.Text = (this.isImport.IsOn ? "وارد" : "صادر");
            this.cmbClients_SelectedIndexChanged(null, null);
            this.grpClientType_SelectedIndexChanged(null, null);
        }
    }
}
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.txtTotalDollarDebitsFinal = new System.Windows.Forms.TextBox();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtTotalDinarDebitsFinal = new System.Windows.Forms.TextBox();
            this.grpTotalDollarDebits = new DevExpress.XtraEditors.GroupControl();
            this.txtTotalDollarDebits = new System.Windows.Forms.TextBox();
            this.grpTotalDinarDebits = new DevExpress.XtraEditors.GroupControl();
            this.txtTotalDinarDebits = new System.Windows.Forms.TextBox();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtDelegateTotal = new System.Windows.Forms.TextBox();
            this.grpDate = new DevExpress.XtraEditors.GroupControl();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.isAccount = new DevExpress.XtraEditors.ToggleSwitch();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.grpDelegates = new DevExpress.XtraEditors.GroupControl();
            this.cmbDelegates = new System.Windows.Forms.ComboBox();
            this.grpInfo = new DevExpress.XtraEditors.GroupControl();
            this.btnAddClient = new DevExpress.XtraEditors.SimpleButton();
            this.dgvClientsNames = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClientMobile = new System.Windows.Forms.TextBox();
            this.txtClientLocation = new System.Windows.Forms.TextBox();
            this.grpPaid = new DevExpress.XtraEditors.GroupControl();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.groupControl9 = new DevExpress.XtraEditors.GroupControl();
            this.contextMenuStripBills = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.حذفالقائمةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbBills = new System.Windows.Forms.ComboBox();
            this.isDollar = new DevExpress.XtraEditors.ToggleSwitch();
            this.isCash = new DevExpress.XtraEditors.ToggleSwitch();
            this.isSell = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.grpTotal = new DevExpress.XtraEditors.GroupControl();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delegate_percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.تكرارالقيدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفالمحددToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSell = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStripBtnSell = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.طباعةوصلقبضToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpClients = new DevExpress.XtraEditors.GroupControl();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTotalDollarDebits)).BeginInit();
            this.grpTotalDollarDebits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTotalDinarDebits)).BeginInit();
            this.grpTotalDinarDebits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).BeginInit();
            this.grpDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDelegates)).BeginInit();
            this.grpDelegates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpInfo)).BeginInit();
            this.grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPaid)).BeginInit();
            this.grpPaid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).BeginInit();
            this.groupControl9.SuspendLayout();
            this.contextMenuStripBills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.isDollar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isCash.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isSell.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTotal)).BeginInit();
            this.grpTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.dgvProductMenu.SuspendLayout();
            this.contextMenuStripBtnSell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpClients)).BeginInit();
            this.grpClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
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
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1073, 599);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "المعلومات";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.txtTotalDollarDebitsFinal);
            this.groupControl3.Location = new System.Drawing.Point(726, 152);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(140, 44);
            this.groupControl3.TabIndex = 45;
            this.groupControl3.Text = "المحصلة بالدولار";
            // 
            // txtTotalDollarDebitsFinal
            // 
            this.txtTotalDollarDebitsFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTotalDollarDebitsFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalDollarDebitsFinal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDollarDebitsFinal.Location = new System.Drawing.Point(2, 20);
            this.txtTotalDollarDebitsFinal.Name = "txtTotalDollarDebitsFinal";
            this.txtTotalDollarDebitsFinal.Size = new System.Drawing.Size(136, 23);
            this.txtTotalDollarDebitsFinal.TabIndex = 1;
            this.txtTotalDollarDebitsFinal.Text = "0";
            this.txtTotalDollarDebitsFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl4.Appearance.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.txtTotalDinarDebitsFinal);
            this.groupControl4.Location = new System.Drawing.Point(872, 152);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(189, 44);
            this.groupControl4.TabIndex = 44;
            this.groupControl4.Text = "المحصلة بالدينار";
            // 
            // txtTotalDinarDebitsFinal
            // 
            this.txtTotalDinarDebitsFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalDinarDebitsFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalDinarDebitsFinal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDinarDebitsFinal.Location = new System.Drawing.Point(2, 20);
            this.txtTotalDinarDebitsFinal.Name = "txtTotalDinarDebitsFinal";
            this.txtTotalDinarDebitsFinal.Size = new System.Drawing.Size(185, 23);
            this.txtTotalDinarDebitsFinal.TabIndex = 0;
            this.txtTotalDinarDebitsFinal.Text = "0";
            this.txtTotalDinarDebitsFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpTotalDollarDebits
            // 
            this.grpTotalDollarDebits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTotalDollarDebits.Controls.Add(this.txtTotalDollarDebits);
            this.grpTotalDollarDebits.Location = new System.Drawing.Point(728, 102);
            this.grpTotalDollarDebits.Name = "grpTotalDollarDebits";
            this.grpTotalDollarDebits.Size = new System.Drawing.Size(140, 44);
            this.grpTotalDollarDebits.TabIndex = 43;
            this.grpTotalDollarDebits.Text = "المجموع بالدولار";
            // 
            // txtTotalDollarDebits
            // 
            this.txtTotalDollarDebits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtTotalDollarDebits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalDollarDebits.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDollarDebits.Location = new System.Drawing.Point(2, 20);
            this.txtTotalDollarDebits.Name = "txtTotalDollarDebits";
            this.txtTotalDollarDebits.Size = new System.Drawing.Size(136, 23);
            this.txtTotalDollarDebits.TabIndex = 1;
            this.txtTotalDollarDebits.Text = "0";
            this.txtTotalDollarDebits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpTotalDinarDebits
            // 
            this.grpTotalDinarDebits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTotalDinarDebits.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTotalDinarDebits.Appearance.Options.UseFont = true;
            this.grpTotalDinarDebits.Controls.Add(this.txtTotalDinarDebits);
            this.grpTotalDinarDebits.Location = new System.Drawing.Point(872, 102);
            this.grpTotalDinarDebits.Name = "grpTotalDinarDebits";
            this.grpTotalDinarDebits.Size = new System.Drawing.Size(189, 44);
            this.grpTotalDinarDebits.TabIndex = 42;
            this.grpTotalDinarDebits.Text = "المجموع بالدينار";
            // 
            // txtTotalDinarDebits
            // 
            this.txtTotalDinarDebits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalDinarDebits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalDinarDebits.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDinarDebits.Location = new System.Drawing.Point(2, 20);
            this.txtTotalDinarDebits.Name = "txtTotalDinarDebits";
            this.txtTotalDinarDebits.Size = new System.Drawing.Size(185, 23);
            this.txtTotalDinarDebits.TabIndex = 0;
            this.txtTotalDinarDebits.Text = "0";
            this.txtTotalDinarDebits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl2.Controls.Add(this.txtDelegateTotal);
            this.groupControl2.Location = new System.Drawing.Point(14, 481);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(130, 58);
            this.groupControl2.TabIndex = 40;
            this.groupControl2.Text = "مجموع المندوب";
            // 
            // txtDelegateTotal
            // 
            this.txtDelegateTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDelegateTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelegateTotal.Location = new System.Drawing.Point(2, 20);
            this.txtDelegateTotal.Name = "txtDelegateTotal";
            this.txtDelegateTotal.ReadOnly = true;
            this.txtDelegateTotal.Size = new System.Drawing.Size(126, 30);
            this.txtDelegateTotal.TabIndex = 0;
            this.txtDelegateTotal.Text = "0";
            this.txtDelegateTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpDate
            // 
            this.grpDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDate.Controls.Add(this.dateFrom);
            this.grpDate.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("تاريخ القائمة", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", -1, true, null, true, false, true, null, -1)});
            this.grpDate.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.grpDate.Location = new System.Drawing.Point(541, 45);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(174, 55);
            this.grpDate.TabIndex = 39;
            this.grpDate.Text = "تاريخ";
            // 
            // dateFrom
            // 
            this.dateFrom.CalendarFont = new System.Drawing.Font("Tahoma", 8F);
            this.dateFrom.CustomFormat = "dd/MM/yyyy";
            this.dateFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFrom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFrom.Location = new System.Drawing.Point(2, 26);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(170, 27);
            this.dateFrom.TabIndex = 37;
            this.dateFrom.Value = new System.DateTime(2017, 4, 20, 14, 5, 11, 0);
            // 
            // isAccount
            // 
            this.isAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isAccount.Location = new System.Drawing.Point(404, 64);
            this.isAccount.Name = "isAccount";
            this.isAccount.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAccount.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.isAccount.Properties.Appearance.Options.UseFont = true;
            this.isAccount.Properties.Appearance.Options.UseForeColor = true;
            this.isAccount.Properties.OffText = "عرض";
            this.isAccount.Properties.OnText = "حساب";
            this.isAccount.Size = new System.Drawing.Size(131, 30);
            this.isAccount.TabIndex = 0;
            // 
            // groupControl8
            // 
            this.groupControl8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl8.Controls.Add(this.txtNote);
            this.groupControl8.Location = new System.Drawing.Point(724, 439);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(335, 151);
            this.groupControl8.TabIndex = 26;
            this.groupControl8.Text = "ملاحظة";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(2, 23);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(331, 111);
            this.txtNote.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAdd.Location = new System.Drawing.Point(376, 545);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(339, 42);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "أدخال";
            // 
            // grpDelegates
            // 
            this.grpDelegates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDelegates.Controls.Add(this.cmbDelegates);
            this.grpDelegates.Location = new System.Drawing.Point(726, 385);
            this.grpDelegates.Name = "grpDelegates";
            this.grpDelegates.Size = new System.Drawing.Size(335, 65);
            this.grpDelegates.TabIndex = 35;
            this.grpDelegates.Text = "المندوب";
            // 
            // cmbDelegates
            // 
            this.cmbDelegates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbDelegates.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDelegates.FormattingEnabled = true;
            this.cmbDelegates.Location = new System.Drawing.Point(2, 20);
            this.cmbDelegates.Name = "cmbDelegates";
            this.cmbDelegates.Size = new System.Drawing.Size(331, 27);
            this.cmbDelegates.TabIndex = 0;
            // 
            // grpInfo
            // 
            this.grpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.grpInfo.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.grpInfo.Location = new System.Drawing.Point(726, 202);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(333, 177);
            this.grpInfo.TabIndex = 29;
            this.grpInfo.Text = "معلومات العميل";
            // 
            // btnAddClient
            // 
            this.btnAddClient.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnAddClient.Location = new System.Drawing.Point(5, 24);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(69, 126);
            this.btnAddClient.TabIndex = 37;
            this.btnAddClient.Text = "جديد";
            // 
            // dgvClientsNames
            // 
            this.dgvClientsNames.AllowUserToAddRows = false;
            this.dgvClientsNames.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvClientsNames.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientsNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientsNames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientsNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientsNames.Location = new System.Drawing.Point(80, 57);
            this.dgvClientsNames.Name = "dgvClientsNames";
            this.dgvClientsNames.ReadOnly = true;
            this.dgvClientsNames.RowHeadersVisible = false;
            this.dgvClientsNames.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvClientsNames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientsNames.Size = new System.Drawing.Size(206, 93);
            this.dgvClientsNames.TabIndex = 30;
            this.dgvClientsNames.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "الايميل";
            // 
            // txtClientName
            // 
            this.txtClientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientName.Location = new System.Drawing.Point(80, 24);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(206, 27);
            this.txtClientName.TabIndex = 20;
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientEmail.Location = new System.Drawing.Point(80, 123);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(206, 27);
            this.txtClientEmail.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "هاتف";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "الأسم";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "العنوان";
            // 
            // txtClientMobile
            // 
            this.txtClientMobile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientMobile.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientMobile.Location = new System.Drawing.Point(80, 90);
            this.txtClientMobile.Name = "txtClientMobile";
            this.txtClientMobile.Size = new System.Drawing.Size(206, 27);
            this.txtClientMobile.TabIndex = 22;
            // 
            // txtClientLocation
            // 
            this.txtClientLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClientLocation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientLocation.Location = new System.Drawing.Point(80, 57);
            this.txtClientLocation.Name = "txtClientLocation";
            this.txtClientLocation.Size = new System.Drawing.Size(206, 27);
            this.txtClientLocation.TabIndex = 21;
            // 
            // grpPaid
            // 
            this.grpPaid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpPaid.Controls.Add(this.txtPaid);
            this.grpPaid.Enabled = false;
            this.grpPaid.Location = new System.Drawing.Point(286, 481);
            this.grpPaid.Name = "grpPaid";
            this.grpPaid.Size = new System.Drawing.Size(149, 58);
            this.grpPaid.TabIndex = 34;
            this.grpPaid.Text = "المدفوع";
            // 
            // txtPaid
            // 
            this.txtPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPaid.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaid.Location = new System.Drawing.Point(2, 20);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(145, 30);
            this.txtPaid.TabIndex = 0;
            this.txtPaid.Text = "0";
            this.txtPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupControl9
            // 
            this.groupControl9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl9.ContextMenuStrip = this.contextMenuStripBills;
            this.groupControl9.Controls.Add(this.cmbBills);
            this.groupControl9.Location = new System.Drawing.Point(726, 45);
            this.groupControl9.Name = "groupControl9";
            this.groupControl9.Size = new System.Drawing.Size(79, 51);
            this.groupControl9.TabIndex = 27;
            this.groupControl9.Text = "القائمة";
            // 
            // contextMenuStripBills
            // 
            this.contextMenuStripBills.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.حذفالقائمةToolStripMenuItem});
            this.contextMenuStripBills.Name = "contextMenuStripBills";
            this.contextMenuStripBills.Size = new System.Drawing.Size(136, 26);
            // 
            // حذفالقائمةToolStripMenuItem
            // 
            this.حذفالقائمةToolStripMenuItem.Name = "حذفالقائمةToolStripMenuItem";
            this.حذفالقائمةToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.حذفالقائمةToolStripMenuItem.Text = "حذف القائمة";
            // 
            // cmbBills
            // 
            this.cmbBills.ContextMenuStrip = this.contextMenuStripBills;
            this.cmbBills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbBills.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBills.FormattingEnabled = true;
            this.cmbBills.Location = new System.Drawing.Point(2, 20);
            this.cmbBills.Name = "cmbBills";
            this.cmbBills.Size = new System.Drawing.Size(75, 27);
            this.cmbBills.TabIndex = 28;
            // 
            // isDollar
            // 
            this.isDollar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isDollar.Location = new System.Drawing.Point(140, 63);
            this.isDollar.Name = "isDollar";
            this.isDollar.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isDollar.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.isDollar.Properties.Appearance.Options.UseFont = true;
            this.isDollar.Properties.Appearance.Options.UseForeColor = true;
            this.isDollar.Properties.OffText = "IQD";
            this.isDollar.Properties.OnText = "$";
            this.isDollar.Size = new System.Drawing.Size(121, 30);
            this.isDollar.TabIndex = 19;
            // 
            // isCash
            // 
            this.isCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isCash.EditValue = true;
            this.isCash.Location = new System.Drawing.Point(12, 63);
            this.isCash.Name = "isCash";
            this.isCash.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isCash.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.isCash.Properties.Appearance.Options.UseFont = true;
            this.isCash.Properties.Appearance.Options.UseForeColor = true;
            this.isCash.Properties.OffText = "أجل";
            this.isCash.Properties.OnText = "نقد";
            this.isCash.Size = new System.Drawing.Size(122, 30);
            this.isCash.TabIndex = 25;
            // 
            // isSell
            // 
            this.isSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.isSell.EditValue = true;
            this.isSell.Location = new System.Drawing.Point(267, 64);
            this.isSell.Name = "isSell";
            this.isSell.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isSell.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(187)))), ((int)(((byte)(0)))));
            this.isSell.Properties.Appearance.Options.UseFont = true;
            this.isSell.Properties.Appearance.Options.UseForeColor = true;
            this.isSell.Properties.OffText = "صادر";
            this.isSell.Properties.OnText = "وارد";
            this.isSell.Size = new System.Drawing.Size(131, 30);
            this.isSell.TabIndex = 28;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnClear.Location = new System.Drawing.Point(14, 545);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 42);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "تصفير";
            // 
            // grpTotal
            // 
            this.grpTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTotal.Controls.Add(this.txtTotal);
            this.grpTotal.Location = new System.Drawing.Point(441, 481);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new System.Drawing.Size(274, 58);
            this.grpTotal.TabIndex = 7;
            this.grpTotal.Text = "المجموع الكلي";
            // 
            // txtTotal
            // 
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(2, 20);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(270, 30);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupControl5
            // 
            this.groupControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl5.Controls.Add(this.txtDiscount);
            this.groupControl5.Location = new System.Drawing.Point(150, 481);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(130, 58);
            this.groupControl5.TabIndex = 5;
            this.groupControl5.Text = "خصم";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiscount.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(2, 20);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(126, 30);
            this.txtDiscount.TabIndex = 0;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.description,
            this.quantity,
            this.price,
            this.total,
            this.note,
            this.delegate_percentage});
            this.dgvProducts.ContextMenuStrip = this.dgvProductMenu;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.Location = new System.Drawing.Point(14, 100);
            this.dgvProducts.Name = "dgvProducts";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProducts.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProducts.RowTemplate.Height = 30;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProducts.Size = new System.Drawing.Size(701, 375);
            this.dgvProducts.TabIndex = 3;
            // 
            // id
            // 
            this.id.FillWeight = 9.461685F;
            this.id.HeaderText = "ت";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // description
            // 
            this.description.DividerWidth = 1;
            this.description.FillWeight = 60F;
            this.description.HeaderText = "وصف المادة";
            this.description.Name = "description";
            // 
            // quantity
            // 
            this.quantity.DividerWidth = 1;
            this.quantity.FillWeight = 10.2869F;
            this.quantity.HeaderText = "عدد";
            this.quantity.Name = "quantity";
            // 
            // price
            // 
            this.price.DividerWidth = 1;
            this.price.FillWeight = 16.45904F;
            this.price.HeaderText = "السعر";
            this.price.Name = "price";
            // 
            // total
            // 
            this.total.DividerWidth = 1;
            this.total.FillWeight = 16.45904F;
            this.total.HeaderText = "المجموع";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // note
            // 
            this.note.DividerWidth = 1;
            this.note.FillWeight = 26.74594F;
            this.note.HeaderText = "ملاحظة";
            this.note.Name = "note";
            // 
            // delegate_percentage
            // 
            this.delegate_percentage.FillWeight = 20F;
            this.delegate_percentage.HeaderText = "نسبة المندوب";
            this.delegate_percentage.MaxInputLength = 11;
            this.delegate_percentage.Name = "delegate_percentage";
            this.delegate_percentage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delegate_percentage.ToolTipText = "نسبة المبدوب للمادة الواحدة. اذا وضعت صفراً 0 فسوف تكون النسبة الافتراضية هي المح" +
    "سوبة";
            // 
            // dgvProductMenu
            // 
            this.dgvProductMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تكرارالقيدToolStripMenuItem,
            this.حذفالمحددToolStripMenuItem});
            this.dgvProductMenu.Name = "dgvProductMenu";
            this.dgvProductMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvProductMenu.Size = new System.Drawing.Size(136, 48);
            // 
            // تكرارالقيدToolStripMenuItem
            // 
            this.تكرارالقيدToolStripMenuItem.Name = "تكرارالقيدToolStripMenuItem";
            this.تكرارالقيدToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.تكرارالقيدToolStripMenuItem.Text = "تكرار القيد";
            // 
            // حذفالمحددToolStripMenuItem
            // 
            this.حذفالمحددToolStripMenuItem.Name = "حذفالمحددToolStripMenuItem";
            this.حذفالمحددToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.حذفالمحددToolStripMenuItem.Text = "حذف المحدد";
            // 
            // btnSell
            // 
            this.btnSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSell.ContextMenuStrip = this.contextMenuStripBtnSell;
            this.btnSell.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnSell.Location = new System.Drawing.Point(150, 545);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(220, 42);
            this.btnSell.TabIndex = 2;
            this.btnSell.Text = "ادخال و طباعة قائمة";
            // 
            // contextMenuStripBtnSell
            // 
            this.contextMenuStripBtnSell.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.طباعةوصلقبضToolStripMenuItem});
            this.contextMenuStripBtnSell.Name = "contextMenuStripBtnSell";
            this.contextMenuStripBtnSell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStripBtnSell.Size = new System.Drawing.Size(163, 26);
            // 
            // طباعةوصلقبضToolStripMenuItem
            // 
            this.طباعةوصلقبضToolStripMenuItem.Name = "طباعةوصلقبضToolStripMenuItem";
            this.طباعةوصلقبضToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.طباعةوصلقبضToolStripMenuItem.Text = "طباعة وصل قبض";
            // 
            // grpClients
            // 
            this.grpClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpClients.Controls.Add(this.cmbClients);
            this.grpClients.Location = new System.Drawing.Point(811, 45);
            this.grpClients.Name = "grpClients";
            this.grpClients.Size = new System.Drawing.Size(250, 51);
            this.grpClients.TabIndex = 1;
            // 
            // cmbClients
            // 
            this.cmbClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbClients.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(2, 20);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(246, 27);
            this.cmbClients.TabIndex = 0;
            this.cmbClients.SelectedIndexChanged += new System.EventHandler(this.cmbClients_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 599);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTotalDollarDebits)).EndInit();
            this.grpTotalDollarDebits.ResumeLayout(false);
            this.grpTotalDollarDebits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpTotalDinarDebits)).EndInit();
            this.grpTotalDinarDebits.ResumeLayout(false);
            this.grpTotalDinarDebits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDate)).EndInit();
            this.grpDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.isAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            this.groupControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDelegates)).EndInit();
            this.grpDelegates.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpInfo)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientsNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpPaid)).EndInit();
            this.grpPaid.ResumeLayout(false);
            this.grpPaid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).EndInit();
            this.groupControl9.ResumeLayout(false);
            this.contextMenuStripBills.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.isDollar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isCash.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isSell.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpTotal)).EndInit();
            this.grpTotal.ResumeLayout(false);
            this.grpTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.dgvProductMenu.ResumeLayout(false);
            this.contextMenuStripBtnSell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpClients)).EndInit();
            this.grpClients.ResumeLayout(false);
            this.ResumeLayout(false);

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
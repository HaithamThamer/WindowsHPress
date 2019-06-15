using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

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
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Exports));
            this.dgvResults = new DataGridView();
            this.btnPrint = new SimpleButton();
            this.btnSearch = new SimpleButton();
            this.groupControl5 = new GroupControl();
            this.txtTotal = new TextBox();
            this.groupControl4 = new GroupControl();
            this.txtBalanceValue = new TextBox();
            this.btnRemove = new SimpleButton();
            this.btnUpdate = new SimpleButton();
            this.btnAdd = new SimpleButton();
            this.grpTypeName = new GroupControl();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.isDollar = new ToggleSwitch();
            this.rdoType = new RadioGroup();
            this.grpNote = new GroupControl();
            this.txtNote = new TextBox();
            this.grpDollar = new GroupBox();
            this.date = new DateTimePicker();
            this.groupBox2 = new GroupBox();
            this.groupBox3 = new GroupBox();
            this.dateFrom = new DateTimePicker();
            this.groupBox4 = new GroupBox();
            this.dateTo = new DateTimePicker();
            this.groupControl1 = new GroupControl();
            ((ISupportInitialize)this.dgvResults).BeginInit();
            ((ISupportInitialize)this.groupControl5).BeginInit();
            this.groupControl5.SuspendLayout();
            ((ISupportInitialize)this.groupControl4).BeginInit();
            this.groupControl4.SuspendLayout();
            ((ISupportInitialize)this.grpTypeName).BeginInit();
            this.grpTypeName.SuspendLayout();
            ((ISupportInitialize)this.isDollar.Properties).BeginInit();
            ((ISupportInitialize)this.rdoType.Properties).BeginInit();
            ((ISupportInitialize)this.grpNote).BeginInit();
            this.grpNote.SuspendLayout();
            this.grpDollar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((ISupportInitialize)this.groupControl1).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.dgvResults.Location = new Point(12, 106);
            this.dgvResults.Name = "dgvResults";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 8.25f);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            this.dgvResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvResults.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvResults.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvResults.Size = new Size(393, 344);
            this.dgvResults.TabIndex = 28;
            this.dgvResults.CellClick += this.dgvResults_CellClick_1;
            this.btnPrint.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Enabled = false;
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
            this.groupControl5.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.groupControl5.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("groupControl5.CaptionImageOptions.Image");
            this.groupControl5.Controls.Add(this.txtTotal);
            this.groupControl5.Location = new Point(10, 456);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new Size(395, 58);
            this.groupControl5.TabIndex = 26;
            this.groupControl5.Text = "المجموع";
            this.txtTotal.Dock = DockStyle.Fill;
            this.txtTotal.Font = new Font("Tahoma", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.txtTotal.Location = new Point(2, 21);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new Size(391, 33);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TextAlign = HorizontalAlignment.Center;
            this.groupControl4.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.groupControl4.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("groupControl4.CaptionImageOptions.Image");
            this.groupControl4.Controls.Add(this.txtBalanceValue);
            this.groupControl4.Location = new Point(511, 131);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new Size(179, 57);
            this.groupControl4.TabIndex = 25;
            this.groupControl4.Text = "الرصيد";
            this.txtBalanceValue.Dock = DockStyle.Fill;
            this.txtBalanceValue.Font = new Font("Tahoma", 18f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtBalanceValue.Location = new Point(2, 21);
            this.txtBalanceValue.Name = "txtBalanceValue";
            this.txtBalanceValue.Size = new Size(175, 36);
            this.txtBalanceValue.TabIndex = 0;
            this.txtBalanceValue.TextChanged += this.txtBalanceValue_TextChanged;
            this.txtBalanceValue.KeyPress += this.txtBalanceValue_KeyPress;
            this.btnRemove.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.btnRemove.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnRemove.Appearance.Options.UseFont = true;
            this.btnRemove.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnRemove.ImageOptions.Image");
            this.btnRemove.ImageOptions.Location = ImageLocation.MiddleRight;
            this.btnRemove.Location = new Point(411, 413);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new Size(82, 37);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "حذف";
            this.btnRemove.Click += this.btnRemove_Click;
            this.btnUpdate.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.btnUpdate.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnUpdate.ImageOptions.Image");
            this.btnUpdate.ImageOptions.Location = ImageLocation.MiddleRight;
            this.btnUpdate.Location = new Point(608, 413);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(82, 37);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.Click += this.btnUpdate_Click;
            this.btnAdd.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.btnAdd.Appearance.Font = new Font("Tahoma", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnAdd.ImageOptions.Image");
            this.btnAdd.ImageOptions.Location = ImageLocation.MiddleRight;
            this.btnAdd.Location = new Point(411, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(279, 37);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.Click += this.btnAdd_Click;
            this.grpTypeName.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.grpTypeName.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpTypeName.CaptionImageOptions.Image");
            this.grpTypeName.Controls.Add(this.cmbClients);
            this.grpTypeName.Location = new Point(409, 76);
            this.grpTypeName.Name = "grpTypeName";
            this.grpTypeName.Size = new Size(281, 46);
            this.grpTypeName.TabIndex = 21;
            this.grpTypeName.Text = "الموردين";
            this.cmbClients.Dock = DockStyle.Fill;
            this.cmbClients.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new Point(2, 21);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new Size(277, 27);
            this.cmbClients.TabIndex = 0;
            this.cmbClients.DropDown += this.cmbClients_DropDown;
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
            this.rdoType.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.rdoType.EditValue = 1;
            this.rdoType.Location = new Point(409, 36);
            this.rdoType.Name = "rdoType";
            this.rdoType.Properties.Items.AddRange(new RadioGroupItem[3]
            {
            new RadioGroupItem(3, "موظف"),
            new RadioGroupItem(2, "المندوب"),
            new RadioGroupItem(1, "مورد")
            });
            this.rdoType.Size = new Size(281, 34);
            this.rdoType.TabIndex = 30;
            this.rdoType.SelectedIndexChanged += this.rdoType_SelectedIndexChanged;
            this.grpNote.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right);
            this.grpNote.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpNote.CaptionImageOptions.Image");
            this.grpNote.Controls.Add(this.txtNote);
            this.grpNote.Location = new Point(409, 262);
            this.grpNote.Name = "grpNote";
            this.grpNote.Size = new Size(281, 102);
            this.grpNote.TabIndex = 32;
            this.grpNote.Text = "ملاحظة";
            this.txtNote.Dock = DockStyle.Fill;
            this.txtNote.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtNote.Location = new Point(2, 21);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new Size(277, 79);
            this.txtNote.TabIndex = 0;
            this.grpDollar.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.grpDollar.Controls.Add(this.isDollar);
            this.grpDollar.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.grpDollar.ForeColor = Color.FromArgb(255, 185, 0);
            this.grpDollar.Location = new Point(411, 130);
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
            this.date.Size = new Size(273, 27);
            this.date.TabIndex = 35;
            this.groupBox2.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.groupBox2.Controls.Add(this.date);
            this.groupBox2.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.groupBox2.ForeColor = Color.FromArgb(255, 185, 0);
            this.groupBox2.Location = new Point(411, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new Size(279, 58);
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
            this.groupControl1.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("groupControl1.CaptionImageOptions.Image");
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
            this.groupControl1.Dock = DockStyle.Fill;
            this.groupControl1.Location = new Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new Size(700, 526);
            this.groupControl1.TabIndex = 39;
            this.groupControl1.Text = "الصادرات";
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(700, 526);
            base.Controls.Add(this.groupControl1);
            base.FormBorderStyle = FormBorderStyle.None;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Exports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.ShowIcon = false;
            base.ShowInTaskbar = false;
            base.StartPosition = FormStartPosition.CenterScreen;
            ((ISupportInitialize)this.dgvResults).EndInit();
            ((ISupportInitialize)this.groupControl5).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((ISupportInitialize)this.groupControl4).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((ISupportInitialize)this.grpTypeName).EndInit();
            this.grpTypeName.ResumeLayout(false);
            ((ISupportInitialize)this.isDollar.Properties).EndInit();
            ((ISupportInitialize)this.rdoType.Properties).EndInit();
            ((ISupportInitialize)this.grpNote).EndInit();
            this.grpNote.ResumeLayout(false);
            this.grpNote.PerformLayout();
            this.grpDollar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((ISupportInitialize)this.groupControl1).EndInit();
            this.groupControl1.ResumeLayout(false);
            base.ResumeLayout(false);
        }

        #endregion
        private GroupControl grpTypeName;

        private System.Windows.Forms.ComboBox cmbClients;

        private SimpleButton btnAdd;

        private SimpleButton btnUpdate;

        private SimpleButton btnRemove;

        private GroupControl groupControl4;

        private TextBox txtBalanceValue;

        private GroupControl groupControl5;

        private TextBox txtTotal;

        private SimpleButton btnSearch;

        private DataGridView dgvResults;

        private SimpleButton btnPrint;

        private ToggleSwitch isDollar;

        private RadioGroup rdoType;

        private GroupControl grpNote;

        private TextBox txtNote;

        private GroupBox grpDollar;

        private DateTimePicker date;

        private GroupBox groupBox2;

        private GroupBox groupBox3;

        private DateTimePicker dateFrom;

        private GroupBox groupBox4;

        private DateTimePicker dateTo;

        private GroupControl groupControl1;
    }
}
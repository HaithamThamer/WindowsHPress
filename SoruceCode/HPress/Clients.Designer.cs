using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;
using HDatabaseConnection;
using HPress;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HPress
{
    partial class Clients
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Clients));
            this.dgvClients = new DataGridView();
            this.txtClientName = new TextBox();
            this.txtClientMobile = new TextBox();
            this.txtClientLocation = new TextBox();
            this.txtEmail = new TextBox();
            this.lblName = new Label();
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.rdoType = new RadioGroup();
            this.btnRemove = new SimpleButton();
            this.btnUpdate = new SimpleButton();
            this.addClient = new SimpleButton();
            this.btnUsers = new SimpleButton();
            ((ISupportInitialize)this.dgvClients).BeginInit();
            ((ISupportInitialize)this.rdoType.Properties).BeginInit();
            base.SuspendLayout();
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle.ForeColor = Color.Black;
            this.dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle;
            this.dgvClients.Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
            this.dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 8f);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Tahoma", 8f);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClients.Location = new Point(12, 73);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Tahoma", 8f);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvClients.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            this.dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClients.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            this.dgvClients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new Size(495, 351);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.CellClick += this.dgvClients_CellClick;
            this.dgvClients.CellContentClick += this.dgvClients_CellContentClick;
            this.dgvClients.CellValueChanged += this.dgvClients_CellValueChanged;
            this.txtClientName.Location = new Point(12, 47);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new Size(92, 20);
            this.txtClientName.TabIndex = 2;
            this.txtClientMobile.Location = new Point(188, 48);
            this.txtClientMobile.Name = "txtClientMobile";
            this.txtClientMobile.Size = new Size(105, 20);
            this.txtClientMobile.TabIndex = 3;
            this.txtClientLocation.Location = new Point(110, 47);
            this.txtClientLocation.Name = "txtClientLocation";
            this.txtClientLocation.Size = new Size(72, 20);
            this.txtClientLocation.TabIndex = 4;
            this.txtEmail.Location = new Point(299, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new Size(101, 20);
            this.txtEmail.TabIndex = 5;
            this.lblName.AutoSize = true;
            this.lblName.Location = new Point(13, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new Size(36, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "ألاسم";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(107, 28);
            this.label1.Name = "label1";
            this.label1.Size = new Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "الموقع";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(185, 28);
            this.label2.Name = "label2";
            this.label2.Size = new Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "هاتف";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(296, 28);
            this.label3.Name = "label3";
            this.label3.Size = new Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "البريد الالكتروني";
            this.rdoType.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.rdoType.Location = new Point(513, 73);
            this.rdoType.Name = "rdoType";
            this.rdoType.Properties.Items.AddRange(new RadioGroupItem[4]
            {
            new RadioGroupItem(null, "عميل"),
            new RadioGroupItem(null, "مورد"),
            new RadioGroupItem(null, "مندوب"),
            new RadioGroupItem(null, "موظف")
            });
            this.rdoType.Size = new Size(142, 46);
            this.rdoType.TabIndex = 12;
            this.btnRemove.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnRemove.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnRemove.ImageOptions.Image");
            this.btnRemove.ImageOptions.Location = ImageLocation.MiddleRight;
            this.btnRemove.Location = new Point(513, 247);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new Size(142, 55);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "حذف";
            this.btnRemove.Click += this.btnRemove_Click;
            this.btnUpdate.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.btnUpdate.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnUpdate.ImageOptions.Image");
            this.btnUpdate.ImageOptions.Location = ImageLocation.MiddleRight;
            this.btnUpdate.Location = new Point(513, 186);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(142, 55);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.Click += this.btnUpdate_Click;
            this.addClient.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            this.addClient.ImageOptions.Image = (Image)componentResourceManager.GetObject("addClient.ImageOptions.Image");
            this.addClient.ImageOptions.Location = ImageLocation.MiddleRight;
            this.addClient.Location = new Point(513, 125);
            this.addClient.Name = "addClient";
            this.addClient.Size = new Size(142, 55);
            this.addClient.TabIndex = 1;
            this.addClient.Text = "اضافة";
            this.addClient.Click += this.addClient_Click;
            this.btnUsers.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            this.btnUsers.ImageOptions.Image = (Image)componentResourceManager.GetObject("btnUsers.ImageOptions.Image");
            this.btnUsers.ImageOptions.Location = ImageLocation.MiddleRight;
            this.btnUsers.Location = new Point(513, 369);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new Size(142, 55);
            this.btnUsers.TabIndex = 16;
            this.btnUsers.Text = "المستخدمبن";
            this.btnUsers.Click += this.btnUsers_Click;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(667, 436);
            base.Controls.Add(this.btnUsers);
            base.Controls.Add(this.rdoType);
            base.Controls.Add(this.btnRemove);
            base.Controls.Add(this.btnUpdate);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.lblName);
            base.Controls.Add(this.txtEmail);
            base.Controls.Add(this.txtClientLocation);
            base.Controls.Add(this.txtClientMobile);
            base.Controls.Add(this.txtClientName);
            base.Controls.Add(this.addClient);
            base.Controls.Add(this.dgvClients);
            base.Name = "Clients";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Clients";
            ((ISupportInitialize)this.dgvClients).EndInit();
            ((ISupportInitialize)this.rdoType.Properties).EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        #endregion
        private DataGridView dgvClients;

        private SimpleButton addClient;

        private TextBox txtClientName;

        private TextBox txtClientMobile;

        private TextBox txtClientLocation;

        private TextBox txtEmail;

        private Label lblName;

        private Label label1;

        private Label label2;

        private Label label3;

        private SimpleButton btnUpdate;

        private SimpleButton btnRemove;

        private RadioGroup rdoType;

        private SimpleButton btnUsers;
    }
}
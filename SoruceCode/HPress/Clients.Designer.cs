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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientMobile = new System.Windows.Forms.TextBox();
            this.txtClientLocation = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoType = new DevExpress.XtraEditors.RadioGroup();
            this.isActive = new DevExpress.XtraEditors.ToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.addClient = new DevExpress.XtraEditors.SimpleButton();
            this.btnUsers = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActive.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClients.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvClients.Location = new System.Drawing.Point(12, 73);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.ReadOnly = true;
            this.dgvClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClients.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvClients.RowHeadersVisible = false;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dgvClients.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvClients.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClients.Size = new System.Drawing.Size(495, 351);
            this.dgvClients.TabIndex = 0;
            this.dgvClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClients_CellClick);
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(12, 47);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(92, 20);
            this.txtClientName.TabIndex = 2;
            // 
            // txtClientMobile
            // 
            this.txtClientMobile.Location = new System.Drawing.Point(188, 48);
            this.txtClientMobile.Name = "txtClientMobile";
            this.txtClientMobile.Size = new System.Drawing.Size(105, 20);
            this.txtClientMobile.TabIndex = 3;
            // 
            // txtClientLocation
            // 
            this.txtClientLocation.Location = new System.Drawing.Point(110, 47);
            this.txtClientLocation.Name = "txtClientLocation";
            this.txtClientLocation.Size = new System.Drawing.Size(72, 20);
            this.txtClientLocation.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(299, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(101, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(36, 13);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "ألاسم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "الموقع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "هاتف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "البريد الالكتروني";
            // 
            // rdoType
            // 
            this.rdoType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoType.Location = new System.Drawing.Point(513, 73);
            this.rdoType.Name = "rdoType";
            this.rdoType.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "عميل"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "مورد"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "مندوب"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "موظف")});
            this.rdoType.Size = new System.Drawing.Size(142, 80);
            this.rdoType.TabIndex = 12;
            this.rdoType.SelectedIndexChanged += new System.EventHandler(this.rdoType_SelectedIndexChanged);
            // 
            // isActive
            // 
            this.isActive.EditValue = true;
            this.isActive.Location = new System.Drawing.Point(513, 46);
            this.isActive.Name = "isActive";
            this.isActive.Properties.OffText = "غير فعال";
            this.isActive.Properties.OnText = "فعال";
            this.isActive.Size = new System.Drawing.Size(142, 23);
            this.isActive.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "النسبة";
            // 
            // txtPercent
            // 
            this.txtPercent.Enabled = false;
            this.txtPercent.Location = new System.Drawing.Point(406, 47);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(101, 20);
            this.txtPercent.TabIndex = 14;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.ImageOptions.Image")));
            this.btnRemove.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnRemove.Location = new System.Drawing.Point(513, 281);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(142, 55);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "حذف";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(513, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(142, 55);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // addClient
            // 
            this.addClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addClient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addClient.ImageOptions.Image")));
            this.addClient.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.addClient.Location = new System.Drawing.Point(513, 159);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(142, 55);
            this.addClient.TabIndex = 1;
            this.addClient.Text = "اضافة";
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsers.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnUsers.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight;
            this.btnUsers.Location = new System.Drawing.Point(513, 369);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(142, 55);
            this.btnUsers.TabIndex = 16;
            this.btnUsers.Text = "المستخدمبن";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 436);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.isActive);
            this.Controls.Add(this.rdoType);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtClientLocation);
            this.Controls.Add(this.txtClientMobile);
            this.Controls.Add(this.txtClientName);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.dgvClients);
            this.Name = "Clients";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdoType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isActive.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private DevExpress.XtraEditors.SimpleButton addClient;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientMobile;
        private System.Windows.Forms.TextBox txtClientLocation;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.RadioGroup rdoType;
        private DevExpress.XtraEditors.ToggleSwitch isActive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPercent;
        private DevExpress.XtraEditors.SimpleButton btnUsers;
    }
}
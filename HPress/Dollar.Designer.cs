namespace HPress
{
    partial class Dollar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dollar));
            this.grpMain = new DevExpress.XtraEditors.GroupControl();
            this.txtValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).BeginInit();
            this.grpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMain
            // 
            this.grpMain.Appearance.ForeColor = System.Drawing.Color.White;
            this.grpMain.Appearance.Options.UseForeColor = true;
            this.grpMain.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grpMain.CaptionImage")));
            this.grpMain.Controls.Add(this.txtValue);
            this.grpMain.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("تجديد", ((System.Drawing.Image)(resources.GetObject("grpMain.CustomHeaderButtons"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.AfterText, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, null, true, false, true, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("أغلاق", ((System.Drawing.Image)(resources.GetObject("grpMain.CustomHeaderButtons1"))), -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.AfterText, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", true, -1, true, null, true, false, true, null, null, -1)});
            this.grpMain.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.grpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMain.Location = new System.Drawing.Point(0, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new System.Drawing.Size(265, 84);
            this.grpMain.TabIndex = 0;
            this.grpMain.Text = "الدولار";
            // 
            // txtValue
            // 
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValue.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(2, 33);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(261, 40);
            this.txtValue.TabIndex = 0;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValue_KeyPress);
            // 
            // Dollar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 84);
            this.Controls.Add(this.grpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dollar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dollar";
            ((System.ComponentModel.ISupportInitialize)(this.grpMain)).EndInit();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpMain;
        private System.Windows.Forms.TextBox txtValue;
    }
}
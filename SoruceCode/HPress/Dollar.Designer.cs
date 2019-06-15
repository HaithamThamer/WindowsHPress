using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ButtonPanel;
using DevExpress.XtraEditors.ButtonsPanelControl;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

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
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Dollar));
            ButtonImageOptions buttonImageOptions = new ButtonImageOptions();
            ButtonImageOptions buttonImageOptions2 = new ButtonImageOptions();
            this.grpMain = new GroupControl();
            this.txtValue = new TextBox();
            ((ISupportInitialize)this.grpMain).BeginInit();
            this.grpMain.SuspendLayout();
            base.SuspendLayout();
            this.grpMain.Appearance.ForeColor = Color.White;
            this.grpMain.Appearance.Options.UseForeColor = true;
            this.grpMain.CaptionImageOptions.Image = (Image)componentResourceManager.GetObject("grpMain.CaptionImageOptions.Image");
            this.grpMain.Controls.Add(this.txtValue);
            buttonImageOptions.Image = (Image)componentResourceManager.GetObject("buttonImageOptions1.Image");
            buttonImageOptions.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.AfterText;
            buttonImageOptions2.Image = (Image)componentResourceManager.GetObject("buttonImageOptions2.Image");
            buttonImageOptions2.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.AfterText;
            this.grpMain.CustomHeaderButtons.AddRange(new IBaseButton[2]
            {
            new GroupBoxButton("تجديد", true, buttonImageOptions, ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new GroupBoxButton("أغلاق", true, buttonImageOptions2, ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)
            });
            this.grpMain.CustomHeaderButtonsLocation = GroupElementLocation.AfterText;
            this.grpMain.Dock = DockStyle.Fill;
            this.grpMain.Location = new Point(0, 0);
            this.grpMain.Name = "grpMain";
            this.grpMain.Size = new Size(265, 84);
            this.grpMain.TabIndex = 0;
            this.grpMain.Text = "الدولار";
            this.txtValue.Dock = DockStyle.Fill;
            this.txtValue.Font = new Font("Tahoma", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.txtValue.Location = new Point(2, 33);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new Size(261, 40);
            this.txtValue.TabIndex = 0;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = HorizontalAlignment.Center;
            this.txtValue.TextChanged += this.txtValue_TextChanged;
            this.txtValue.KeyPress += this.txtValue_KeyPress;
            base.AutoScaleDimensions = new SizeF(6f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(265, 84);
            base.Controls.Add(this.grpMain);
            base.FormBorderStyle = FormBorderStyle.None;
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Name = "Dollar";
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            base.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Dollar";
            ((ISupportInitialize)this.grpMain).EndInit();
            this.grpMain.ResumeLayout(false);
            this.grpMain.PerformLayout();
            base.ResumeLayout(false);
        }

        #endregion

        private GroupControl grpMain;

        private TextBox txtValue;
    }
}
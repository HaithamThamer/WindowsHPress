using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using HDatabaseConnection;
using DevExpress.XtraBars.Docking2010;

namespace HPress
{
    public partial class Dollar : DevExpress.XtraEditors.XtraForm
    {
        HDatabaseConnection.HMySQLConnection databaseConnection;
        public Dollar(HMySQLConnection databaseConnection, double value)
        {
            this.InitializeComponent();
            this.databaseConnection = databaseConnection;
            grpMain.CustomButtonClick += this.GrpMain_CustomButtonClick;
            this.txtValue.Text = value.ToString();
            this.txtValue.Focus();
        }

        private void GrpMain_CustomButtonClick(object sender, BaseButtonEventArgs e)
        {
            string caption = e.Button.Properties.Caption;
            if (!(caption == "تجديد"))
            {
                if (caption == "أغلاق")
                {
                    base.Close();
                }
            }
            else
            {
                this.renew();
                base.Close();
            }
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '\r':
                    this.renew();
                    base.Close();
                    break;
                case '\u001b':
                    base.Close();
                    break;
            }
        }

        public void renew()
        {
            this.databaseConnection.queryNonReader(string.Format("insert into tbl_dollar (value) values ('{0}');", this.txtValue.Text));
            HPress.Properties.Settings.Default.dollarValue = double.Parse(this.txtValue.Text);
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            if (this.txtValue.Text == string.Empty)
            {
                this.txtValue.Text = "0";
                this.txtValue.Focus();
            }
        }
    }
}
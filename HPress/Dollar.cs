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

namespace HPress
{
    public partial class Dollar : DevExpress.XtraEditors.XtraForm
    {
        HDatabaseConnection.HMySQLConnection databaseConnection;
        public Dollar(HDatabaseConnection.HMySQLConnection databaseConnection,double value)
        {
            InitializeComponent();
            this.databaseConnection = databaseConnection;
            grpMain.CustomButtonClick += GrpMain_CustomButtonClick;
            txtValue.Text = value.ToString();
            txtValue.Focus();
        }

        private void GrpMain_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
                case "تجديد":
                    renew();
                    this.Close();
                    break;
                case "أغلاق":
                    this.Close();
                    break;
                default: break;
            }
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Enter:
                    renew();
                    this.Close();
                    break;
                case (char)Keys.Escape:
                    this.Close();
                    break;
                default:
                    break;
            }
        }
        public void renew()
        {
            databaseConnection.queryNonReader(string.Format("insert into tbl_dollar (value) values ('{0}');", txtValue.Text));
            Properties.Settings.Default.dollarValue = double.Parse(txtValue.Text);
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            if (txtValue.Text == string.Empty)
            {
                txtValue.Text = "0";
                txtValue.Focus();
            }
        }
    }
}
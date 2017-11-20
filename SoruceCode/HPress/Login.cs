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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        HDatabaseConnection.HMySQLConnection databaseConnection;
        public Login(HDatabaseConnection.HMySQLConnection databaseConnection)
        {
            this.databaseConnection = databaseConnection;
            InitializeComponent();
            this.DialogResult = DialogResult.No;
            picMain.Image = Image.FromFile(Properties.Settings.Default.imageLogo1);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.Yes)
            {
                this.DialogResult = DialogResult.No;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                return;
            }
            System.Data.DataTable dt = databaseConnection.query(string.Format("select count(name),type from tbl_users where name = '{0}' and password = '{1}'",txtUsername.Text,txtPassword.Text));
            string r = dt.Rows[0][0].ToString();
            if (r != "0")
            {
                this.DialogResult = DialogResult.Yes;
                Properties.Settings.Default.userType = int.Parse(dt.Rows[0][1].ToString());
                this.Close();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}
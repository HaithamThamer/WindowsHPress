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
    public partial class Home : DevExpress.XtraEditors.XtraForm
    {
        HDatabaseConnection.HMySQLConnection databaseConnection;
        HRegsiter.Product product;
        Main main;
        Debits debits;
        Exports exports;
        ClientsImport clientImport;
        Reports reports;
        public Home()
        {
            product = new HRegsiter.Product(Application.ExecutablePath.ToString());
            databaseConnection = new HDatabaseConnection.HMySQLConnection(product.getValue((int)Enumerators.Settings.ServerIP), product.getValue((int)Enumerators.Settings.DatabaseUsername), product.getValue((int)Enumerators.Settings.DatabasePassword), product.getValue((int)Enumerators.Settings.DatabaseName));

            Properties.Settings.Default.imageLogo1 = product.getValue((int)Enumerators.Settings.logo1);
            Properties.Settings.Default.address = product.getValue((int)Enumerators.Settings.address);

            Properties.Settings.Default.facebook = product.getValue((int)Enumerators.Settings.facebook);
            Properties.Settings.Default.phone = product.getValue((int)Enumerators.Settings.phone);
            Properties.Settings.Default.email = product.getValue((int)Enumerators.Settings.email);
            Properties.Settings.Default.color = product.getValue((int)Enumerators.Settings.color);
            Properties.Settings.Default.imageLogoPrint = product.getValue((int)Enumerators.Settings.logoPrint);
            if (new Login(databaseConnection).ShowDialog() == DialogResult.No)
            {
                Environment.Exit(0);
            }



            InitializeComponent();

            main = new Main(databaseConnection);
            main.MdiParent = this;
            main.Dock = DockStyle.Fill;
            main.Show();


            //User
            if (Properties.Settings.Default.userType == (int)Enumerators.UserType.User)
            {

                btnClientsImports.Enabled = false;
                btnDebits.Enabled = false;
                btnExport.Enabled = false;
                btnClients.Enabled = false;

                //btnBalance.Enabled = false;
            }
            btnDollar.Text = Properties.Settings.Default.dollarValue.ToString();

            this.Text = Application.ProductName;
            picMain.Image = Image.FromFile(Properties.Settings.Default.imageLogo1);
            pnlMain.BackColor = System.Drawing.ColorTranslator.FromHtml(Properties.Settings.Default.color);

        }


        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            new Clients(databaseConnection).ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (reports == null)
            {
                reports = new Reports(databaseConnection);
                reports.MdiParent = this;
                reports.Show();
            }else
            {
                reports.Activate();
            }
            
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            if (exports == null)
            {
                exports = new Exports(databaseConnection);
                exports.MdiParent = this;
                exports.Show();
            }else
            {
                exports.Activate();
            }
        }

        private void btnDollar_Click(object sender, EventArgs e)
        {
            new Dollar(databaseConnection, double.Parse(btnDollar.Text)).ShowDialog();
            btnDollar.Text = Properties.Settings.Default.dollarValue.ToString();
        }

        private void btnDebits_Click(object sender, EventArgs e)
        {
            if (debits == null)
            {
                debits = new Debits(databaseConnection);
                debits.MdiParent = this;
                debits.Show();
            }
            else
            {
                debits.Activate();
            }
            
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            if (main != null)
            {

                main.Activate();
            }
        }

        private void btnClientsImports_Click(object sender, EventArgs e)
        {
            if (clientImport == null)
            {
                clientImport = new ClientsImport(databaseConnection);
                clientImport.MdiParent = this;
                clientImport.Show();
            }
            else
            {
                clientImport.Activate();
            }
        }
    }
}
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
using HRegsiter;
using HDatabaseConnection;

namespace HPress
{
    public partial class Home : DevExpress.XtraEditors.XtraForm
    {
        private HMySQLConnection databaseConnection;

        private Product product;

        private Main main;

        private Debits debits;

        private Exports exports;

        private ClientsImport clientImport;

        private Reports reports;
        public Home()
        {
            this.product = new Product(Application.ExecutablePath.ToString());
            this.databaseConnection = new HMySQLConnection(this.product.getValue(0), this.product.getValue(1), this.product.getValue(2), this.product.getValue(3));
            HPress.Properties.Settings.Default.imageLogo1 = this.product.getValue(4);
            HPress.Properties.Settings.Default.address = this.product.getValue(5);
            HPress.Properties.Settings.Default.facebook = this.product.getValue(6);
            HPress.Properties.Settings.Default.phone = this.product.getValue(7);
            HPress.Properties.Settings.Default.email = this.product.getValue(8);
            HPress.Properties.Settings.Default.color = this.product.getValue(9);
            HPress.Properties.Settings.Default.imageLogoPrint = this.product.getValue(10);
            if (new Login(this.databaseConnection).ShowDialog() == DialogResult.No)
            {
                Environment.Exit(0);
            }
            this.InitializeComponent();
            this.main = new Main(this.databaseConnection);
            this.main.MdiParent = this;
            this.main.Dock = DockStyle.Fill;
            this.main.Show();
            if (HPress.Properties.Settings.Default.userType == 1)
            {
                this.btnClientsImports.Enabled = false;
                this.btnDebits.Enabled = false;
                this.btnExport.Enabled = false;
                this.btnClients.Enabled = false;
            }
            this.btnDollar.Text = HPress.Properties.Settings.Default.dollarValue.ToString();
            this.Text = "HPRESS";
            this.picMain.Image = Image.FromFile(HPress.Properties.Settings.Default.imageLogo1);
            this.pnlMain.BackColor = ColorTranslator.FromHtml(HPress.Properties.Settings.Default.color);
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            new Clients(this.databaseConnection).ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (this.reports == null)
            {
                this.reports = new Reports(this.databaseConnection, Enumerators.ReportsName.none);
                this.reports.MdiParent = this;
                this.reports.Show();
            }
            else
            {
                this.reports.Activate();
            }
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            if (this.exports == null)
            {
                this.exports = new Exports(this.databaseConnection);
                this.exports.MdiParent = this;
                this.exports.Show();
            }
            else
            {
                this.exports.Activate();
            }
        }

        private void btnDollar_Click(object sender, EventArgs e)
        {
            new Dollar(this.databaseConnection, double.Parse(this.btnDollar.Text)).ShowDialog();
            this.btnDollar.Text = HPress.Properties.Settings.Default.dollarValue.ToString();
        }

        private void btnDebits_Click(object sender, EventArgs e)
        {
            if (this.debits == null)
            {
                this.debits = new Debits(this.databaseConnection);
                this.debits.MdiParent = this;
                this.debits.Show();
            }
            else
            {
                this.debits.Activate();
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            if (this.main != null)
            {
                this.main.Activate();
            }
        }

        private void btnClientsImports_Click(object sender, EventArgs e)
        {
            if (this.clientImport == null)
            {
                this.clientImport = new ClientsImport(this.databaseConnection);
                this.clientImport.MdiParent = this;
                this.clientImport.Show();
            }
            else
            {
                this.clientImport.Activate();
            }
        }
    }
}
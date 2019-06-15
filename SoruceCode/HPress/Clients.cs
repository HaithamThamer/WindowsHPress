using DevExpress.XtraEditors;
using HDatabaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPress
{
    public partial class Clients :  XtraForm
    {
        private HMySQLConnection databaseConnection;

        private int clientId = 0;
        public Clients()
        {
            InitializeComponent();
        }
        public Clients(HMySQLConnection databaseConnection)
        {
            this.databaseConnection = databaseConnection;
            this.InitializeComponent();
            this.reloadData();
        }

        private void reloadData()
        {
            this.dgvClients.DataSource = this.databaseConnection.query("select id,type,if(type = 0,'عميل',if(type = 1,'مورد',if(type = 2,'مندوب',if(type = 3,'موظف','اخرى')))) as `typeName`,name,location,mobile,email,is_import,is_export from tbl_clients order by type;");
            DataGridViewColumn dataGridViewColumn = this.dgvClients.Columns["id"];
            DataGridViewColumn dataGridViewColumn2 = this.dgvClients.Columns["type"];
            bool visible = dataGridViewColumn2.Visible = false;
            dataGridViewColumn.Visible = visible;
            this.dgvClients.Columns["name"].HeaderText = "الأسم";
            this.dgvClients.Columns["location"].HeaderText = "العنوان";
            this.dgvClients.Columns["mobile"].HeaderText = "موبايل";
            this.dgvClients.Columns["email"].HeaderText = "ايميل";
            this.dgvClients.Columns["typeName"].HeaderText = "النوع";
            this.dgvClients.Columns["is_import"].HeaderText = "للوارد";
            this.dgvClients.Columns["is_export"].HeaderText = "للصادر";
            TextBox textBox = this.txtEmail;
            TextBox textBox2 = this.txtClientName;
            TextBox textBox3 = this.txtClientMobile;
            TextBox textBox4 = this.txtClientLocation;
            string text2 = textBox4.Text = "";
            string text4 = textBox3.Text = text2;
            string text7 = textBox.Text = (textBox2.Text = text4);
            this.txtClientName.Focus();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            if (this.txtClientName.Text != string.Empty)
            {
                this.databaseConnection.queryNonReader(string.Format("insert into tbl_clients (name,location,mobile,email,type) values ('{0}','{1}','{2}','{3}','{4}');", this.txtClientName.Text, this.txtClientLocation.Text, this.txtClientMobile.Text, this.txtEmail.Text, (this.rdoType.SelectedIndex != 1) ? this.rdoType.SelectedIndex : 0));
                this.reloadData();
            }
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.clientId = int.Parse(this.dgvClients.Rows[e.RowIndex].Cells["id"].Value.ToString());
                this.txtClientName.Text = this.dgvClients.Rows[e.RowIndex].Cells["name"].Value.ToString();
                this.txtClientLocation.Text = this.dgvClients.Rows[e.RowIndex].Cells["location"].Value.ToString();
                this.txtClientMobile.Text = this.dgvClients.Rows[e.RowIndex].Cells["mobile"].Value.ToString();
                this.txtEmail.Text = this.dgvClients.Rows[e.RowIndex].Cells["email"].Value.ToString();
                this.rdoType.SelectedIndex = int.Parse(this.dgvClients.Rows[e.RowIndex].Cells["type"].Value.ToString());
                if (e.ColumnIndex >= this.dgvClients.Columns.Count - 2)
                {
                    this.dgvClients.ReadOnly = false;
                }
                else
                {
                    this.dgvClients.ReadOnly = true;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.clientId != 0)
            {
                this.databaseConnection.queryNonReader(string.Format("update tbl_clients set name = '{1}',location = '{2}',mobile = '{3}',email = '{4}',type = '{5}' where tbl_clients.id = '{0}';", this.clientId, this.txtClientName.Text, this.txtClientLocation.Text, this.txtClientMobile.Text, this.txtEmail.Text, (this.rdoType.SelectedIndex != 1) ? this.rdoType.SelectedIndex : 0));
                this.reloadData();
                this.clientId = 0;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.clientId != 0)
            {
                this.databaseConnection.queryNonReader(string.Format("delete from tbl_clients where id = '{0}';", this.clientId));
                this.reloadData();
                this.clientId = 0;
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new Users(this.databaseConnection).ShowDialog();
        }

        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvClients.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dgvClients_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= this.dgvClients.Columns.Count - 2)
            {
                this.databaseConnection.queryNonReader(string.Format("update tbl_clients set is_import = '{0}',is_export = '{1}' where tbl_clients.id = '{2}';", bool.Parse(this.dgvClients.Rows[e.RowIndex].Cells["is_import"].Value.ToString()) ? "1" : "0", bool.Parse(this.dgvClients.Rows[e.RowIndex].Cells["is_export"].Value.ToString()) ? "1" : "0", this.dgvClients.Rows[e.RowIndex].Cells["id"].Value.ToString()));
            }
        }

    }
}

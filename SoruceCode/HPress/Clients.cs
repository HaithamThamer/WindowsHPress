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
    public partial class Clients : DevExpress.XtraEditors.XtraForm
    {
        HDatabaseConnection.HMySQLConnection databaseConnection;
        int clientId = 0;
        public Clients(HDatabaseConnection.HMySQLConnection databaseConnection)
        {
            this.databaseConnection = databaseConnection;
            InitializeComponent();
            reloadData();
        }
        void reloadData()
        {
            dgvClients.DataSource = databaseConnection.query("select id,type,if(type = 0,'عميل',if(type = 1,'مورد',if(type = 2,'مندوب',if(type = 3,'موظف','اخرى')))) as `typeName`,name,location,mobile,email,is_active,percent from tbl_clients order by type;");
            dgvClients.Columns["id"].Visible = dgvClients.Columns["type"].Visible = false;
            dgvClients.Columns["name"].HeaderText = "الأسم";
            dgvClients.Columns["location"].HeaderText = "العنوان";
            dgvClients.Columns["mobile"].HeaderText = "موبايل";
            dgvClients.Columns["email"].HeaderText = "ايميل";
            dgvClients.Columns["typeName"].HeaderText = "النوع";
            dgvClients.Columns["is_active"].HeaderText = "فعالية";
            dgvClients.Columns["percent"].HeaderText = "النسبة";
            txtEmail.Text = txtClientName.Text = txtClientMobile.Text = txtClientLocation.Text = txtPercent.Text = "";
            txtClientName.Focus();
        }
        private void addClient_Click(object sender, EventArgs e)
        {
            if (txtClientName.Text != string.Empty)
            {
                databaseConnection.queryNonReader(string.Format("insert into tbl_clients (name,location,mobile,email,is_active,type,percent) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');", txtClientName.Text, txtClientLocation.Text, txtClientMobile.Text, txtEmail.Text, isActive.IsOn ? "1" : "0", rdoType.SelectedIndex == 1 ? 0 : rdoType.SelectedIndex, txtPercent.Text == "" ? "0" : txtPercent.Text));
                reloadData();
            }
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            clientId = int.Parse(dgvClients.Rows[e.RowIndex].Cells["id"].Value.ToString());
            txtClientName.Text = dgvClients.Rows[e.RowIndex].Cells["name"].Value.ToString();
            txtClientLocation.Text = dgvClients.Rows[e.RowIndex].Cells["location"].Value.ToString();
            txtClientMobile.Text = dgvClients.Rows[e.RowIndex].Cells["mobile"].Value.ToString();
            txtEmail.Text = dgvClients.Rows[e.RowIndex].Cells["email"].Value.ToString();
            rdoType.SelectedIndex = int.Parse(dgvClients.Rows[e.RowIndex].Cells["type"].Value.ToString());
            txtPercent.Text = dgvClients.Rows[e.RowIndex].Cells["percent"].Value.ToString();
            isActive.IsOn = bool.Parse(dgvClients.Rows[e.RowIndex].Cells["is_active"].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (clientId != 0)
            {
                databaseConnection.queryNonReader(string.Format("update tbl_clients set name = '{1}',location = '{2}',mobile = '{3}',email = '{4}',type = '{5}',is_active = '{6}',percent = '{7}' where tbl_clients.id = '{0}';", clientId, txtClientName.Text, txtClientLocation.Text, txtClientMobile.Text, txtEmail.Text, rdoType.SelectedIndex == 1 ? 0 : rdoType.SelectedIndex, isActive.IsOn ? "1" : "0",txtPercent.Text));
                reloadData();
                clientId = 0;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (clientId != 0)
            {
                databaseConnection.queryNonReader(string.Format("delete from tbl_clients where id = '{0}';", clientId));
                reloadData();
                clientId = 0;
            }
        }

        private void rdoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPercent.Enabled = rdoType.SelectedIndex == (int)Enumerators.clientType.Delegate;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new Users(databaseConnection).ShowDialog();
        }
    }
}
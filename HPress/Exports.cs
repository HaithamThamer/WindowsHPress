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
    public partial class Exports : DevExpress.XtraEditors.XtraForm
    {
        HDatabaseConnection.HMySQLConnection databaseConnection;
        int id = 0;
        public Exports(HDatabaseConnection.HMySQLConnection databaseConnection)
        {
            InitializeComponent();
            this.databaseConnection = databaseConnection;
            cmbClients_DropDown(null, null);
            if (cmbClients.Items.Count > 0)
                cmbClients.Text = cmbClients.Items[0].ToString();
            dateFrom.Value = dateTo.Value = DateTime.Now;
        }

        private void cmbClients_DropDown(object sender, EventArgs e)
        {
            cmbClients.Items.Clear();
            System.Data.DataTable dt = databaseConnection.query(string.Format("select name from tbl_clients where type = '{0}'", int.Parse(rdoType.EditValue.ToString())));
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbClients.Items.Add(dt.Rows[i][0].ToString());
                }
                cmbClients.Text = cmbClients.Items[0].ToString();
            }
            
        }

        private void txtBalanceValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && (char)Keys.OemPeriod == e.KeyChar;
        }
        void reloadData()
        {
            dgvResults.DataSource = databaseConnection.query(string.Format("select tbl_balance.id,type,if(type = 0,'عميل',if(type = 1,'مورد',if(type = 2,'مندوب',if(type = 3,'موظف','اخرى')))) as `typeName`,tbl_clients.name,tbl_balance.is_dollar,tbl_balance.is_import,tbl_balance.value,tbl_balance.creation,tbl_balance.note from tbl_balance,tbl_clients where tbl_clients.id = tbl_balance.client_id and tbl_clients.name = '{0}' and tbl_balance.creation between '{1}' and '{2}' order by type asc", cmbClients.Text, dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59")));
            dgvResults.Columns["id"].Visible = dgvResults.Columns["type"].Visible = false;
            dgvResults.Columns["name"].HeaderText = "العميل"; 
            dgvResults.Columns["is_dollar"].HeaderText = "دوالار؟";
            dgvResults.Columns["is_import"].HeaderText = "وارد؟";
            dgvResults.Columns["value"].HeaderText = "القيمة";
            dgvResults.Columns["creation"].HeaderText = "التاريخ";
            dgvResults.Columns["typeName"].HeaderText = "النوع";
            dgvResults.Columns["note"].HeaderText = "ملاحظة";
            
            txtBalanceValue.Text = txtNote.Text = "";
            double sum = 0;
            foreach (DataGridViewRow row in dgvResults.Rows)
            {
                sum += double.Parse(row.Cells["value"].Value.ToString()) * (bool.Parse(row.Cells["is_dollar"].Value.ToString()) ? Properties.Settings.Default.dollarValue : 1);
            }
            txtTotal.Text = sum.ToString("#,###");
            btnPrint.Enabled = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBalanceValue.Text != string.Empty && cmbClients.Text != string.Empty && cmbClients.Text != "الكل")
            {
                databaseConnection.queryNonReader(string.Format("insert into tbl_balance (client_id,value,is_dollar,is_import,bill_id,creation,note) values ((select id from tbl_clients where name = '{0}'),'{1}','{2}','{3}','0','{4}','{5}');", cmbClients.Text, txtBalanceValue.Text.Replace(",",""), isDollar.IsOn ? "1" : "0",  "0", date.Value.ToString("yyyy-MM-dd 00:00:00"), txtNote.Text));
                reloadData();
            }
        }
        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvResults.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            databaseConnection.queryNonReader(string.Format("update tbl_balance set tbl_balance.client_id = (select id from tbl_clients where name = '{0}'),tbl_balance.is_dollar = '{1}',tbl_balance.value = '{2}',tbl_balance.is_import = '{3}' , tbl_balance.note = '{4}', tbl_balance.creation = '{5}' where tbl_balance.id = '{6}';", cmbClients.Text, isDollar.IsOn ? "1" : "0", txtBalanceValue.Text.Replace(",",""), "0",txtNote.Text, date.Value.ToString("yyyy-MM-dd 00:00:00"), id));
            reloadData();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            reloadData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            databaseConnection.queryNonReader(string.Format("delete from tbl_balance where id = '{0}'", id));
            reloadData();
        }

        private void dgvResults_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvResults.Rows[e.RowIndex].Cells["id"].Value.ToString());
            rdoType.SelectedIndex = int.Parse(dgvResults.Rows[e.RowIndex].Cells["type"].Value.ToString());
            cmbClients.Text = dgvResults.Rows[e.RowIndex].Cells["name"].Value.ToString();
            isDollar.IsOn = dgvResults.Rows[e.RowIndex].Cells["is_dollar"].Value.ToString() == "True" ? true : false;
            txtBalanceValue.Text = dgvResults.Rows[e.RowIndex].Cells["value"].Value.ToString();
            date.Value = DateTime.Parse(dgvResults.Rows[e.RowIndex].Cells["creation"].Value.ToString());
            txtNote.Text = dgvResults.Rows[e.RowIndex].Cells["note"].Value.ToString();
            btnPrint.Enabled = true;
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = databaseConnection.query("select id,name,location, mobile, email,ifnull((ifnull((select SUM(IF(tbl_bills.is_dollar = 1 ,tbl_balance.value * " + Properties.Settings.Default.dollarValue + ",tbl_balance.value)) from tbl_balance,tbl_bills where tbl_balance.client_id = tbl_clients.id and tbl_bills.id = tbl_balance.bill_id and tbl_bills.is_sell = 1),0) - ifnull((select sum(if(tbl_bills.is_dollar = 0,tbl_products.price  * tbl_products.count,tbl_products.price*" + Properties.Settings.Default.dollarValue + "  * tbl_products.count)) from tbl_products,tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1),0) + (select sum(ifnull(if(tbl_bills.is_dollar = 1,tbl_bills.discount * 1300,tbl_bills.discount),0)) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1)),0) as `remaining`from tbl_clients where name = '" + cmbClients.Text + "'");
            DevExpress.XtraReports.UI.ReportPrintTool rpt = new DevExpress.XtraReports.UI.ReportPrintTool(new HCashier.Report.ArrivedCatch(id, cmbClients.Text, double.Parse(txtBalanceValue.Text), dateFrom.Value, isDollar.IsOn ? double.Parse(dt.Rows[0][5].ToString()) / Properties.Settings.Default.dollarValue : double.Parse(dt.Rows[0][5].ToString()), !isDollar.IsOn, ""));
            rpt.PrintDialog();
        }

        private void rdoType_SelectedIndexChanged(object sender, EventArgs e)
        {

            grpTypeName.Text = int.Parse(rdoType.EditValue.ToString()) == 0 ? "العملاء" : int.Parse(rdoType.EditValue.ToString()) == 1 ? "المودرين" : int.Parse(rdoType.EditValue.ToString()) == 2 ? "المندوبين" : "الموظفين";
            cmbClients_DropDown(null, null);
        }

        private void txtBalanceValue_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0 && !(sender as TextBox).Text.Contains(".") && !(sender as TextBox).Text.Contains("-"))
            {
                (sender as TextBox).Text = double.Parse((sender as TextBox).Text).ToString("#,###");
                (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
            }

        }

        private void isDollar_Toggled(object sender, EventArgs e)
        {
            grpDollar.Text = isDollar.IsOn ? "$" : "IQD";
        }
    }
}
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
    public partial class ClientsImport : DevExpress.XtraEditors.XtraForm
    {
        HDatabaseConnection.HMySQLConnection databaseConnection;
        int id = 0;
        public ClientsImport(HDatabaseConnection.HMySQLConnection databaseConnection)
        {
            InitializeComponent();
            this.databaseConnection = databaseConnection;
            cmbClients_DropDown(null, null);
            if (cmbClients.Items.Count > 0)
                cmbClients.Text = cmbClients.Items[0].ToString();
            dateFrom.Value = dateTo.Value = DateTime.Now;
            cmbClients.SelectedIndex = 0;
        }

        private void cmbClients_DropDown(object sender, EventArgs e)
        {
            cmbClients.Items.Clear();
            cmbClients.Items.Add("الكل");
            System.Data.DataTable dt = databaseConnection.query(string.Format("select name from tbl_clients where type = '{0}'", 0));
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbClients.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            cmbClients.Text = cmbClients.Items[0].ToString();
        }

        private void txtBalanceValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 46;
        }
        void reloadData()
        {
            dgvResults.Columns.Clear();
            dgvResults.DataSource = databaseConnection.query(string.Format("select tbl_balance.id,tbl_clients.name,tbl_balance.bill_id,DATE_FORMAT(tbl_balance.creation,'%Y-%m-%d') as `creation`,if(tbl_balance.is_dollar = 1,CONCAT('$ ',getDollar(tbl_balance.creation)),'IQD') as `is_dollar`,sum(tbl_balance.value) as `value`,tbl_balance.note from tbl_balance,tbl_clients where tbl_clients.id = tbl_balance.client_id and tbl_clients.type = 0 {0} and tbl_balance.creation between '{1}' and '{2}' group by tbl_balance.{3} order by type asc", cmbClients.Text == "الكل" ? "" : " and tbl_clients.name = '" + cmbClients.Text + "' ", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59"), (int)grpPayMethod.EditValue == 1 ? "id" : "balance_pay_id"));
            dgvResults.Columns["id"].Visible = false;
            dgvResults.Columns["bill_id"].HeaderText = "القائمة";
            dgvResults.Columns["name"].HeaderText = "العميل";
            dgvResults.Columns["is_dollar"].HeaderText = "العملة";
            dgvResults.Columns["value"].HeaderText = "القيمة";
            dgvResults.Columns["creation"].HeaderText = "التاريخ";
            dgvResults.Columns["note"].HeaderText = "ملاحظة";
            txtBalanceValue.Text = txtNote.Text = "";
            double sumDinar = 0;
            double sumDollar = 0;
            foreach (DataGridViewRow row in dgvResults.Rows)
            {
                sumDinar += double.Parse(row.Cells["value"].Value.ToString()) * (row.Cells["is_dollar"].Value.ToString().Contains("IQD") ? 1 : 0);
                sumDollar += double.Parse(row.Cells["value"].Value.ToString()) * (row.Cells["is_dollar"].Value.ToString().Contains("$") ? 1 : 0);
            }
            txtDinarDebits.Text = sumDinar == 0 ? "0" : sumDinar.ToString("#,###");
            txtDollarDebits.Text = sumDollar == 0 ? "0" : sumDollar.ToString("#.##");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBalanceValue.Text != string.Empty && cmbClients.Text != string.Empty && cmbClients.Text != "الكل")
            {
                DataTable dt = databaseConnection.query(string.Format("select getDollar(tbl_bills.datetime) as `dollarValue`,tbl_bills.is_dollar,tbl_bills.id,ifnull(((((select sum(tbl_products.count * tbl_products.price) from tbl_products where tbl_products.bill_id = tbl_bills.id) -(tbl_bills.discount))) -  ifnull(( select sum(tbl_balance.value)  from tbl_balance where tbl_balance.bill_id = tbl_bills.id),0)) ,0) as `remaining` from tbl_bills, tbl_clients where tbl_bills.id > 0 and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 and tbl_clients.id > 1 and tbl_clients.id = tbl_bills.client_id and tbl_clients.name = '{0}' and ifnull(((((select sum(tbl_products.count * tbl_products.price) from tbl_products where tbl_products.bill_id = tbl_bills.id) -(tbl_bills.discount))) -  ifnull(( select sum(tbl_balance.value)  from tbl_balance where tbl_balance.bill_id = tbl_bills.id),0)) ,0)  > 0 order by tbl_bills.datetime", cmbClients.Text));
                double pay = double.Parse(txtBalanceValue.Text.Replace(",", ""));
                //double payDollar = double.Parse(txtBalanceValue.Text.Replace(",", "")) / (isDollar.IsOn ? Properties.Settings.Default.dollarValue : 1);
                double billSum = 0;
                double value = 0;
                bool isDollarFromDatabase = false;
                double dollarValueFromDatabase = Properties.Settings.Default.dollarValue;
                int billId = 0;
                int balancePayId = 0;
                bool isSamePay = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    isDollarFromDatabase = bool.Parse(dt.Rows[i]["is_dollar"].ToString());
                    if (isDollarFromDatabase != isDollar.IsOn)
                        continue;

                    billSum = double.Parse(dt.Rows[i]["remaining"].ToString());
                    dollarValueFromDatabase = double.Parse(dt.Rows[i]["dollarValue"].ToString());
                    pay = isDollarFromDatabase == isDollar.IsOn  ? pay : isDollarFromDatabase && !isDollar.IsOn ? pay * Properties.Settings.Default.dollarValue : pay / Properties.Settings.Default.dollarValue;
                    billId = int.Parse(dt.Rows[i]["id"].ToString());
                    if (!isSamePay)
                    {
                        balancePayId = int.Parse(databaseConnection.query("insert into tbl_balance_pay () values (); select id from tbl_balance_pay order by id desc limit 0,1 ").Rows[0][0].ToString());
                    }
                    if (pay <= 0)
                    {
                        break;
                    }else if (pay <= billSum && pay > 0)
                    {
                        value = pay;
                        dt.Rows[i]["remaining"] = billSum - pay;
                        pay = 0;
                        i -= 1;
                    }
                    else if(pay > billSum)
                    {
                        value = billSum;
                        pay -= billSum;
                        isSamePay = true;
                        //pay = isDollarFromDatabase || isDollar.IsOn ? pay / dollarValueFromDatabase : pay;
                    }
                    databaseConnection.queryNonReader(string.Format("insert into tbl_balance (client_id,value,is_dollar,is_import,bill_id,creation,note,balance_pay_id) values ((select id from tbl_clients where name = '{0}'),'{1}','{2}','1','{6}','{4}','{5}','{7}');", cmbClients.Text, value, isDollar.IsOn ? "1" : "0", "0", date.Value.ToString("yyyy-MM-dd 00:00:00"), txtNote.Text, billId, balancePayId));
                }
                reloadData();
            }
        }
        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dgvResults.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            databaseConnection.queryNonReader(string.Format("update tbl_balance set tbl_balance.client_id = (select id from tbl_clients where name = '{0}'  and type = 0),tbl_balance.is_dollar = '{1}',tbl_balance.value = '{2}',tbl_balance.is_import = '{3}' , tbl_balance.note = '{4}', tbl_balance.creation = '{5}' where tbl_balance.id = '{6}';", cmbClients.Text, isDollar.IsOn ? "1" : "0", txtBalanceValue.Text.Replace(",",""), "0",txtNote.Text, date.Value.ToString("yyyy-MM-dd 00:00:00"), id));
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
            if (e.RowIndex == -1)
            {
                return;
            }
            id = int.Parse(dgvResults.Rows[e.RowIndex].Cells["id"].Value.ToString());
            cmbClients.Text = dgvResults.Rows[e.RowIndex].Cells["name"].Value.ToString();
            isDollar.IsOn = dgvResults.Rows[e.RowIndex].Cells["is_dollar"].Value.ToString() == "True" ? true : false;
            txtBalanceValue.Text = dgvResults.Rows[e.RowIndex].Cells["value"].Value.ToString();
            date.Value = DateTime.Parse(dgvResults.Rows[e.RowIndex].Cells["creation"].Value.ToString());
            txtNote.Text = dgvResults.Rows[e.RowIndex].Cells["note"].Value.ToString();
            btnUpdate.Enabled = btnRemove.Enabled = true;
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnAdd.Enabled = cmbClients.SelectedIndex != 0;
            //System.Data.DataTable dt = databaseConnection.query(string.Format("select sum(ifnull( ( ifnull( ( select  SUM(tbl_balance.value * IF(tbl_balance.is_dollar = 1 ,getDollar(null),1))  from tbl_balance, tbl_bills where tbl_balance.client_id = tbl_clients.id and tbl_bills.id = tbl_balance.bill_id and tbl_bills.is_sell = 1 and tbl_balance.is_import = 1 ) ,0) - ifnull( ( select sum((tbl_products.price  * tbl_products.count) * if(tbl_bills.is_dollar = 1,getDollar(null),1)) from tbl_products,tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 ) ,0) + ifnull( ( select sum(tbl_bills.discount * if(tbl_bills.is_dollar = 1,getDollar(null),1)) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 ) ,0) ) ,0)) as `remaining`, abs(sum(ifnull( ( /*Balances*/ ifnull( ( select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 1 ) ,0) - ( /*Bills*/ ifnull( ( select sum( ( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ) ) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1 ) ,0) - /*Discounts*/ ifnull( ( select sum(tbl_bills.discount) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1 ) ,0) ) ) ,0))) as `remaining_dollar`, abs(sum(ifnull( ( /*Balances*/ ifnull( ( select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 0 	) ,0) - ( 	/*Bills*/ ifnull( ( select sum( ( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ) ) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0 ),0)-/*Discounts*/ifnull(( select sum(tbl_bills.discount) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0 ) ,0) ) ) ,0))) as `remaining_dinar` from  tbl_clients where tbl_clients.type = 0 {0}", cmbClients.Text == "الكل" ? "" : " and tbl_clients.name = '" + "فندق دلشاد بلص" + "' "));
            System.Data.DataTable dt = databaseConnection.query(string.Format("select sum(ifnull( ( ifnull( ( select  SUM(tbl_balance.value * IF(tbl_balance.is_dollar = 1 ,getDollar(null),1))  from tbl_balance, tbl_bills where tbl_balance.client_id = tbl_clients.id and tbl_bills.id = tbl_balance.bill_id and tbl_bills.is_sell = 1 and tbl_balance.is_import = 1 ) ,0) - ifnull( ( select sum((tbl_products.price  * tbl_products.count) * if(tbl_bills.is_dollar = 1 and tbl_bills.is_cash = 0,getDollar(null),1)) from tbl_products,tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 ) ,0) + ifnull( ( select sum(tbl_bills.discount * if(tbl_bills.is_dollar = 1 and tbl_bills.is_cash = 0,getDollar(null),1)) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 ) ,0) ) ,0)) as `remaining`, abs(sum(ifnull( ( /*Balances*/ ifnull( ( select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 1 ) ,0) - ( /*Bills*/ ifnull( ( select sum( ( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ) ) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1 and tbl_bills.is_cash = 0 ) ,0) - /*Discounts*/ ifnull( ( select sum(tbl_bills.discount) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1 and tbl_bills.is_cash = 0 ) ,0) ) ) ,0))) as `remaining_dollar`, abs(sum(ifnull( ( /*Balances*/ ifnull( ( select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 0 	) ,0) - ( 	/*Bills*/ ifnull( ( select sum( ( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ) ) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0 and tbl_bills.is_cash = 0 and tbl_bills.is_cash = 0),0)-/*Discounts*/ifnull(( select sum(tbl_bills.discount) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0 and tbl_bills.is_cash = 0 ) ,0) ) ) ,0))) as `remaining_dinar` from  tbl_clients where tbl_clients.type = 0 {0}", cmbClients.Text == "الكل" ? "" : " and tbl_clients.name = '" + cmbClients.Text + "' "));
            Clipboard.SetText(string.Format("select sum(ifnull( ( ifnull( ( select  SUM(tbl_balance.value * IF(tbl_balance.is_dollar = 1 ,getDollar(null),1))  from tbl_balance, tbl_bills where tbl_balance.client_id = tbl_clients.id and tbl_bills.id = tbl_balance.bill_id and tbl_bills.is_sell = 1 and tbl_balance.is_import = 1 ) ,0) - ifnull( ( select sum((tbl_products.price  * tbl_products.count) * if(tbl_bills.is_dollar = 1 and tbl_bills.is_cash = 0,getDollar(null),1)) from tbl_products,tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 ) ,0) + ifnull( ( select sum(tbl_bills.discount * if(tbl_bills.is_dollar = 1 and tbl_bills.is_cash = 0,getDollar(null),1)) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 ) ,0) ) ,0)) as `remaining`, abs(sum(ifnull( ( /*Balances*/ ifnull( ( select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 1 ) ,0) - ( /*Bills*/ ifnull( ( select sum( ( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ) ) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1 and tbl_bills.is_cash = 0 ) ,0) - /*Discounts*/ ifnull( ( select sum(tbl_bills.discount) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1 and tbl_bills.is_cash = 0 ) ,0) ) ) ,0))) as `remaining_dollar`, abs(sum(ifnull( ( /*Balances*/ ifnull( ( select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 0 	) ,0) - ( 	/*Bills*/ ifnull( ( select sum( ( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ) ) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0 and tbl_bills.is_cash = 0 and tbl_bills.is_cash = 0),0)-/*Discounts*/ifnull(( select sum(tbl_bills.discount) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0 and tbl_bills.is_cash = 0 ) ,0) ) ) ,0))) as `remaining_dinar` from  tbl_clients where tbl_clients.type = 0 {0}", cmbClients.Text == "الكل" ? "" : " and tbl_clients.name = '" + cmbClients.Text + "' "));
            grpClients.Text = string.Format("({1} $ : {0} IQD)", double.Parse(dt.Rows[0][0].ToString()).ToString("#,###"), (double.Parse(dt.Rows[0][0].ToString()) / Properties.Settings.Default.dollarValue).ToString("#.##"));
            txtTotalDollarDebits.Text = string.Format("{0}", double.Parse(dt.Rows[0][1].ToString()).ToString("#.##"));
            txtTotalDollarDebits.Text = txtTotalDollarDebits.Text == "" ? "0" : txtTotalDollarDebits.Text;
            txtTotalDinarDebits.Text = string.Format("{0}", double.Parse(dt.Rows[0][2].ToString()).ToString("#,###"));
            txtTotalDinarDebits.Text = txtTotalDinarDebits.Text == "" ? "0" : txtTotalDinarDebits.Text;


        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Reports r = new Reports(databaseConnection, Enumerators.ReportsName.ClientPay, cmbClients.Text, dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59"));
            r.Hide();
        }

        private void rdoType_SelectedIndexChanged(object sender, EventArgs e)
        {

            grpClients.Text = "العملاء";
            cmbClients_DropDown(null, null);
        }

        private void txtBalanceValue_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0 && !(sender as TextBox).Text.Contains("."))
            {
                (sender as TextBox).Text = double.Parse((sender as TextBox).Text).ToString("#,###");
                (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
            }
            
        }

        private void isDollar_Toggled(object sender, EventArgs e)
        {
            grpDollar.Text = isDollar.IsOn ? "$" : "IQD";
        }

        private void btnReportClient_Click(object sender, EventArgs e)
        {
            Reports r = new Reports(databaseConnection, Enumerators.ReportsName.Client, cmbClients.Text, dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59"));
            r.Hide();
        }

        private void grpMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void طباعةوصلاستلامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvResults.CurrentRow;
            System.Data.DataTable dt = databaseConnection.query(string.Format("select sum(ifnull( ( ifnull( ( select  SUM(tbl_balance.value * IF(tbl_balance.is_dollar = 1 ,getDollar(null),1))  from tbl_balance, tbl_bills where tbl_balance.client_id = tbl_clients.id and tbl_bills.id = tbl_balance.bill_id and tbl_bills.is_sell = 1 and tbl_balance.is_import = 1 ) ,0) - ifnull( ( select sum((tbl_products.price  * tbl_products.count) * if(tbl_bills.is_dollar = 1,getDollar(null),1)) from tbl_products,tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 ) ,0) + ifnull( ( select sum(tbl_bills.discount * if(tbl_bills.is_dollar = 1,getDollar(null),1)) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 ) ,0) ) ,0)) as `remaining`, abs(sum(ifnull( ( /*Balances*/ ifnull( ( select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 1 and tbl_balance.creation between '2015-04-01 00:00:00' and '{1}') ,0) - ( /*Bills*/ ifnull( ( select sum( ( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ) ) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1 and tbl_bills.datetime between '2015-04-01 00:00:00' and '{1}') ,0) - /*Discounts*/ ifnull( ( select sum(tbl_bills.discount) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1 and tbl_bills.datetime between '2015-04-01 00:00:00' and '{1}') ,0) ) ) ,0))) as `remaining_dollar`,abs(sum(ifnull((/*Balances*/ ifnull( ( select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 0 and tbl_balance.creation between '2015-04-01 00:00:00' and '{1}' ) ,0) - ( /*Bills*/  ifnull( ( select sum( ( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ) ) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0 and tbl_bills.datetime between '2015-04-01 00:00:00' and '{1}' ),0) - /*Discounts*/ ifnull(( select sum(tbl_bills.discount) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0 and tbl_bills.datetime between '2015-04-01 00:00:00' and '{1}' ),0) )),0))) as `remaining_dinar` from  tbl_clients where tbl_clients.type = 0 and tbl_clients.name = '{0}'", row.Cells["name"].Value.ToString(), row.Cells["creation"].Value.ToString()));

            DevExpress.XtraReports.UI.ReportPrintTool rpt = new DevExpress.XtraReports.UI.ReportPrintTool(new HCashier.Report.ArrivedCatch(id, cmbClients.Text, double.Parse(txtBalanceValue.Text), dateFrom.Value, row.Cells["is_dollar"].Value.ToString().Contains("$") ? double.Parse(dt.Rows[0][1].ToString()) : double.Parse(dt.Rows[0][2].ToString()), !row.Cells["is_dollar"].Value.ToString().Contains("$"), txtNote.Text));
            rpt.PrintDialog();
        }
    }
}
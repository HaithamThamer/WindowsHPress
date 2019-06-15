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
using System.Collections;
using DevExpress.XtraReports.UI;
using HCashier.Report;

namespace HPress
{
    public partial class Exports : DevExpress.XtraEditors.XtraForm
    {
        HDatabaseConnection.HMySQLConnection databaseConnection;
        int id = 0;
        public Exports(HMySQLConnection databaseConnection)
        {
            this.InitializeComponent();
            this.databaseConnection = databaseConnection;
            this.cmbClients_DropDown(null, null);
            if (this.cmbClients.Items.Count > 0)
            {
                this.cmbClients.Text = this.cmbClients.Items[0].ToString();
            }
            DateTimePicker dateTimePicker = this.dateFrom;
            DateTimePicker dateTimePicker2 = this.dateTo;
            DateTime dateTime2 = dateTimePicker.Value = (dateTimePicker2.Value = DateTime.Now);
        }

        private void cmbClients_DropDown(object sender, EventArgs e)
        {
            this.cmbClients.Items.Clear();
            DataTable dataTable = this.databaseConnection.query(string.Format("select name from tbl_clients where type = '{0}'", int.Parse(this.rdoType.EditValue.ToString())));
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    this.cmbClients.Items.Add(dataTable.Rows[i][0].ToString());
                }
                this.cmbClients.Text = this.cmbClients.Items[0].ToString();
            }
        }

        private void txtBalanceValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && '¾' == e.KeyChar);
        }

        private void reloadData()
        {
            DataGridView dataGridView = this.dgvResults;
            HMySQLConnection hMySQLConnection = this.databaseConnection;
            string text = this.cmbClients.Text;
            DateTime value = this.dateFrom.Value;
            string arg = value.ToString("yyyy-MM-dd 00:00:00");
            value = this.dateTo.Value;
            dataGridView.DataSource = hMySQLConnection.query(string.Format("select tbl_balance.id,type,if(type = 0,'عميل',if(type = 1,'مورد',if(type = 2,'مندوب',if(type = 3,'موظف','اخرى')))) as `typeName`,tbl_clients.name,tbl_balance.is_dollar,tbl_balance.is_import,tbl_balance.value,tbl_balance.creation,tbl_balance.note from tbl_balance,tbl_clients where tbl_clients.id = tbl_balance.client_id and tbl_clients.name = '{0}' and tbl_balance.creation between '{1}' and '{2}' order by type asc", text, arg, value.ToString("yyyy-MM-dd 23:59:59")));
            DataGridViewColumn dataGridViewColumn = this.dgvResults.Columns["id"];
            DataGridViewColumn dataGridViewColumn2 = this.dgvResults.Columns["type"];
            bool visible = dataGridViewColumn2.Visible = false;
            dataGridViewColumn.Visible = visible;
            this.dgvResults.Columns["name"].HeaderText = "العميل";
            this.dgvResults.Columns["is_dollar"].HeaderText = "دوالار؟";
            this.dgvResults.Columns["is_import"].HeaderText = "وارد؟";
            this.dgvResults.Columns["value"].HeaderText = "القيمة";
            this.dgvResults.Columns["creation"].HeaderText = "التاريخ";
            this.dgvResults.Columns["typeName"].HeaderText = "النوع";
            this.dgvResults.Columns["note"].HeaderText = "ملاحظة";
            TextBox textBox = this.txtBalanceValue;
            TextBox textBox2 = this.txtNote;
            string text4 = textBox.Text = (textBox2.Text = "");
            double num = 0.0;
            foreach (DataGridViewRow item in (IEnumerable)this.dgvResults.Rows)
            {
                num += double.Parse(item.Cells["value"].Value.ToString()) * (bool.Parse(item.Cells["is_dollar"].Value.ToString()) ? Properties.Settings.Default.dollarValue : 1.0);
            }
            this.txtTotal.Text = num.ToString("#,###");
            this.btnPrint.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtBalanceValue.Text != string.Empty && this.cmbClients.Text != string.Empty && this.cmbClients.Text != "الكل")
            {
                this.databaseConnection.queryNonReader(string.Format("insert into tbl_balance (client_id,value,is_dollar,is_import,bill_id,creation,note) values ((select id from tbl_clients where name = '{0}'),'{1}','{2}','{3}','0','{4}','{5}');", this.cmbClients.Text, this.txtBalanceValue.Text.Replace(",", ""), this.isDollar.IsOn ? "1" : "0", "0", this.date.Value.ToString("yyyy-MM-dd 00:00:00"), this.txtNote.Text));
                this.reloadData();
            }
        }

        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = int.Parse(this.dgvResults.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.databaseConnection.queryNonReader(string.Format("update tbl_balance set tbl_balance.client_id = (select id from tbl_clients where name = '{0}'),tbl_balance.is_dollar = '{1}',tbl_balance.value = '{2}',tbl_balance.is_import = '{3}' , tbl_balance.note = '{4}', tbl_balance.creation = '{5}' where tbl_balance.id = '{6}';", this.cmbClients.Text, this.isDollar.IsOn ? "1" : "0", this.txtBalanceValue.Text.Replace(",", ""), "0", this.txtNote.Text, this.date.Value.ToString("yyyy-MM-dd 00:00:00"), this.id));
            this.reloadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.reloadData();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.databaseConnection.queryNonReader(string.Format("delete from tbl_balance where id = '{0}'", this.id));
            this.reloadData();
        }

        private void dgvResults_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.id = int.Parse(this.dgvResults.Rows[e.RowIndex].Cells["id"].Value.ToString());
            this.rdoType.SelectedIndex = int.Parse(this.dgvResults.Rows[e.RowIndex].Cells["type"].Value.ToString());
            this.cmbClients.Text = this.dgvResults.Rows[e.RowIndex].Cells["name"].Value.ToString();
            this.isDollar.IsOn = ((byte)((this.dgvResults.Rows[e.RowIndex].Cells["is_dollar"].Value.ToString() == "True") ? 1 : 0) != 0);
            this.txtBalanceValue.Text = this.dgvResults.Rows[e.RowIndex].Cells["value"].Value.ToString();
            this.date.Value = DateTime.Parse(this.dgvResults.Rows[e.RowIndex].Cells["creation"].Value.ToString());
            this.txtNote.Text = this.dgvResults.Rows[e.RowIndex].Cells["note"].Value.ToString();
            this.btnPrint.Enabled = true;
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dataTable = this.databaseConnection.query("select id,name,location, mobile, email,ifnull((ifnull((select SUM(IF(tbl_bills.is_dollar = 1 ,tbl_balance.value * " + Properties.Settings.Default.dollarValue + ",tbl_balance.value)) from tbl_balance,tbl_bills where tbl_balance.client_id = tbl_clients.id and tbl_bills.id = tbl_balance.bill_id and tbl_bills.is_sell = 1),0) - ifnull((select sum(if(tbl_bills.is_dollar = 0,tbl_products.price  * tbl_products.count,tbl_products.price*" + Properties.Settings.Default.dollarValue + "  * tbl_products.count)) from tbl_products,tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1),0) + (select sum(ifnull(if(tbl_bills.is_dollar = 1,tbl_bills.discount * 1300,tbl_bills.discount),0)) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1)),0) as `remaining`from tbl_clients where name = '" + this.cmbClients.Text + "'");
            ReportPrintTool reportPrintTool = new ReportPrintTool(new ArrivedCatch(this.id, this.cmbClients.Text, double.Parse(this.txtBalanceValue.Text), this.dateFrom.Value, this.isDollar.IsOn ? (double.Parse(dataTable.Rows[0][5].ToString()) / Properties.Settings.Default.dollarValue) : double.Parse(dataTable.Rows[0][5].ToString()), !this.isDollar.IsOn, "", true));
            reportPrintTool.PrintDialog();
        }

        private void rdoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.grpTypeName.Text = ((int.Parse(this.rdoType.EditValue.ToString()) == 0) ? "العملاء" : ((int.Parse(this.rdoType.EditValue.ToString()) == 1) ? "المودرين" : ((int.Parse(this.rdoType.EditValue.ToString()) == 2) ? "المندوبين" : "الموظفين")));
            this.cmbClients_DropDown(null, null);
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
            this.grpDollar.Text = (this.isDollar.IsOn ? "$" : "IQD");
        }
    }
}
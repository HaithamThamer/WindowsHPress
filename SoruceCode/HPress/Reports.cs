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
using HCashier.Report;
using DevExpress.XtraReports.UI;

namespace HPress
{
    public partial class Reports : DevExpress.XtraEditors.XtraForm
    {
        private HMySQLConnection databaseConnection;

        private Enumerators.ReportForm reportForm;

        private Enumerators.ReportsName reportName;

        private double cash = 0.0;

        private double debet = 0.0;

        private double balanceImport = 0.0;

        private double balanceExport = 0.0;

        private double export = 0.0;

        private double payDebit = 0.0;

        private double debit = 0.0;

        public Reports(HMySQLConnection databaseConnection, Enumerators.ReportsName reportName = Enumerators.ReportsName.none, params string[] args)
        {
            this.InitializeComponent();
            this.reportForm = Enumerators.ReportForm.none;
            DateTimePicker dateTimePicker = this.dateFrom;
            DateTimePicker dateTimePicker2 = this.dateTo;
            DateTime dateTime2 = dateTimePicker.Value = (dateTimePicker2.Value = DateTime.Now);
            this.databaseConnection = databaseConnection;
            switch (Properties.Settings.Default.userType)
            {
                case 0:
                    this.btnDailyReport.Enabled = true;
                    this.btnProducts.Enabled = true;
                    this.btnEmployeeDebits.Enabled = true;
                    this.btnEmployee.Enabled = true;
                    this.btnDelegates.Enabled = true;
                    this.btnDelegate.Enabled = true;
                    this.btnDebitsSell.Enabled = true;
                    this.btnDebitsClients.Enabled = true;
                    this.btnDate.Enabled = true;
                    this.btnDailyReport.Enabled = true;
                    this.btnClient.Enabled = true;
                    this.btnCaseValue.Enabled = true;
                    this.btnBills.Enabled = true;
                    this.btnBillReport.Enabled = true;
                    this.btnClientPay.Enabled = true;
                    break;
                case 1:
                    this.btnDailyReport.Enabled = true;
                    break;
            }
            switch (reportName)
            {
                case Enumerators.ReportsName.Client:
                    this.btnClient_Click(null, null);
                    this.cmbClients.Text = args[0];
                    this.dateFrom.Value = DateTime.Parse(args[1]);
                    this.dateTo.Value = DateTime.Parse(args[2]);
                    break;
                case Enumerators.ReportsName.ClientPay:
                    this.btnClientPay_Click(null, null);
                    this.cmbClients.Text = args[0];
                    this.dateFrom.Value = DateTime.Parse(args[1]);
                    this.dateTo.Value = DateTime.Parse(args[2]);
                    break;
            }
            if (reportName != 0)
            {
                this.btnSearch_Click(null, null);
                this.btnPrint_Click(null, null);
            }
            this.cmbUsers.Items.Add("الكل");
            DataTable dataTable = databaseConnection.query("select * from tbl_users");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                this.cmbUsers.Items.Add(dataTable.Rows[i]["name"].ToString());
            }
            if (Properties.Settings.Default.userType == 1)
            {
                this.cmbUsers.Text = Properties.Settings.Default.userName;
                this.cmbUsers.Enabled = false;
            }
            else
            {
                this.cmbUsers.Text = this.cmbUsers.Items[0].ToString();
            }
        }

        private void reportDaily()
        {
            HMySQLConnection hMySQLConnection = this.databaseConnection;
            string format = ("select if(tbl_bills.is_sell = 1,'وارد','صادر') as `is_sell`, tbl_bills.id, if(tbl_bills.name = tbl_clients.name,tbl_bills.name,CONCAT(tbl_clients.name,':',tbl_bills.name)) as `name`, if(tbl_bills.is_cash = 1,'نقد','أجل') as `is_cash`, if(tbl_bills.is_dollar = 1,CONCAT('$ ',getDollar(tbl_bills.datetime)),'IQD') as `is_dollar`,  tbl_bills.discount, ifnull(( select (sum(tbl_products.price * tbl_products.count) - tbl_bills.discount) from tbl_products where tbl_products.bill_id = tbl_bills.id ),0) as `total` from tbl_bills, tbl_clients where tbl_bills.id > 0 and tbl_bills.client_id = tbl_clients.id and tbl_bills.datetime between '{0}' and '{1}' " + ((this.cmbUsers.Text == "الكل") ? "" : (" and (select id from tbl_users where tbl_users.name = '" + this.cmbUsers.Text + "') = tbl_bills.user_id ")) + " union select 'رصيد', tbl_balance.bill_id, if(tbl_bills.name = tbl_clients.name,tbl_bills.name,CONCAT(tbl_clients.name,':',tbl_bills.name)) as `name`, if(tbl_balance.is_import = 1,'وارد','صادر') as `is_import`, if(tbl_balance.is_dollar = 1,CONCAT('$ ',getDollar(tbl_balance.creation)),'IQD') as `is_dollar`, 0, tbl_balance.value from tbl_balance, tbl_clients, tbl_bills where tbl_balance.client_id = tbl_clients.id and tbl_balance.bill_id = tbl_bills.id and tbl_balance.creation between '{0}' and '{1}' " + ((this.cmbUsers.Text == "الكل") ? "" : (" and (select id from tbl_users where tbl_users.name = '" + this.cmbUsers.Text + "') = tbl_balance.user_id ")) + " union select if(tbl_debits.is_pay = 1,'تسديد','قرض') as `is_pay`, tbl_debits.id, tbl_clients.name, 'نقد', if(tbl_debits.is_dollar = 1,CONCAT('$ ',getDollar(tbl_debits.datetime)),'IQD') as `is_dollar`, '0', tbl_debits.value from tbl_debits, tbl_clients where tbl_debits.employee_id = tbl_clients.id and tbl_debits.datetime between '{0}' and '{1}' " + ((this.cmbUsers.Text == "الكل") ? "" : (" and (select id from tbl_users where tbl_users.name = '" + this.cmbUsers.Text + "') = tbl_debits.user_id "))) ?? "";
            DateTime value = this.dateFrom.Value;
            string arg = value.ToString("yyyy-MM-dd 00:00:00");
            value = this.dateTo.Value;
            DataTable dataSource = hMySQLConnection.query(string.Format(format, arg, value.ToString("yyyy-MM-dd 23:59:59")));
            this.dgvResults.DataSource = dataSource;
            this.dgvResults.Columns[0].HeaderText = "العملية";
            this.dgvResults.Columns[1].HeaderText = "القائمة";
            this.dgvResults.Columns[2].HeaderText = "اسم العميل";
            this.dgvResults.Columns[3].HeaderText = "التعامل";
            this.dgvResults.Columns[4].HeaderText = "العملة";
            this.dgvResults.Columns[5].HeaderText = "الخصم";
            this.dgvResults.Columns[6].HeaderText = "المجموع";
            this.dgvResults.Columns[0].Width = 70;
            this.dgvResults.Columns[1].Width = 90;
            this.dgvResults.Columns[2].Width = 170;
            this.dgvResults.Columns[3].Width = 50;
            this.dgvResults.Columns[4].Width = 50;
            this.dgvResults.Columns[5].Width = 90;
        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            this.reset();
            this.reportForm = Enumerators.ReportForm.ReportGeneral;
            this.reportName = Enumerators.ReportsName.Daily;
            this.dateFrom.Show();
            this.dateTo.Show();
            this.cmbUsers.Show();
        }

        private void reportDebitsSell()
        {
            DataGridView dataGridView = this.dgvResults;
            HMySQLConnection hMySQLConnection = this.databaseConnection;
            DateTime value = this.dateFrom.Value;
            string arg = value.ToString("yyyy -MM-dd 00:00:00");
            value = this.dateTo.Value;
            dataGridView.DataSource = hMySQLConnection.query(string.Format("select tbl_bills.id, tbl_bills.name, DATE_FORMAT(tbl_bills.datetime,'%y-%m-%d') as `datetime`, tbl_bills.phone, (select tbl_clients.name from tbl_clients where tbl_clients.id = tbl_bills.delegate_id) as `delegate_name`, FORMAT((( (ifnull(( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ),0) - tbl_bills.discount) * if(tbl_bills.is_dollar = 0,1,0) - ifnull((select sum(tbl_balance.value) from tbl_balance where tbl_balance.bill_id = tbl_bills.id and tbl_balance.is_dollar = 0),0) )) ,0) as `remaining_dinar`, ( (ifnull(( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ),0) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,1,0) - ifnull((select sum(tbl_balance.value) from tbl_balance where tbl_balance.bill_id = tbl_bills.id and tbl_balance.is_dollar = 1),0) ) as `remaining_dollar`, tbl_bills.note from tbl_bills, tbl_clients where tbl_clients.id = tbl_bills.client_id and tbl_clients.id = 1 and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 and  tbl_bills.datetime between '{0}' and '{1}' having remaining_dinar != 0 OR remaining_dollar != 0", arg, value.ToString("yyyy-MM-dd 23:59:59")));
            this.dgvResults.Columns["id"].HeaderText = "القائمة";
            this.dgvResults.Columns["name"].HeaderText = "العميل";
            this.dgvResults.Columns["phone"].HeaderText = "الهاتف";
            this.dgvResults.Columns["note"].HeaderText = "ملاحظة";
            this.dgvResults.Columns["datetime"].HeaderText = "التاريخ";
            this.dgvResults.Columns["delegate_name"].HeaderText = "المندوب";
            this.dgvResults.Columns["remaining_dinar"].HeaderText = "IQD المتبقي";
            this.dgvResults.Columns["remaining_dollar"].HeaderText = "$ المتبقي";
        }

        private void btnDebitsSell_Click(object sender, EventArgs e)
        {
            this.reset();
            this.reportName = Enumerators.ReportsName.DebitsSell;
            this.reportForm = Enumerators.ReportForm.ReportGeneral;
            this.dateFrom.Show();
            this.dateTo.Show();
        }

        private void reportDebitsClients()
        {
            this.dgvResults.DataSource = this.databaseConnection.query(string.Format("select tbl_clients.name, tbl_clients.mobile, CAST( (((ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products, tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0) - (select sum(tbl_bills.discount) from tbl_bills where tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0)),0))  - (ifnull((select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 0),0)))) AS decimal(10,0)) as `remaining_dinar`, CAST( ( ((ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products, tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1) - (select sum(tbl_bills.discount) from tbl_bills where tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1)),0))  - (ifnull((select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 1),0)))) AS decimal(10,2)) as `remaining_dollar` from tbl_clients where tbl_clients.id > 1 having `remaining_dollar` > 0 OR remaining_dinar > 0"));
            this.dgvResults.Columns["name"].HeaderText = "الاسم";
            this.dgvResults.Columns["mobile"].HeaderText = "الموبايل";
            this.dgvResults.Columns["remaining_dinar"].HeaderText = "المتبقي IQD";
            this.dgvResults.Columns["remaining_dollar"].HeaderText = "المتبقي $";
        }

        private void btnDebitsClients_Click(object sender, EventArgs e)
        {
            this.reset();
            this.reportForm = Enumerators.ReportForm.ReportGeneral;
            this.reportName = Enumerators.ReportsName.DebitsClients;
            this.btnSearch_Click(null, null);
        }

        private void reportDelegates()
        {
            this.dgvResults.DataSource = this.databaseConnection.query(string.Format("call reportDelegates('{0}');", this.dateTo.Value.ToString("yyyy-MM-dd 23:59:59")));
            this.dgvResults.Columns["name"].HeaderText = "المندوب";
            this.dgvResults.Columns["received"].HeaderText = "المستلم من عندنا";
            this.dgvResults.Columns["remaining"].HeaderText = "نسبته المتبقية عند العميل";
            this.dgvResults.Columns["receivables"].HeaderText = "مستحقاته من نسبته";
            this.dgvResults.Columns["total"].HeaderText = "المجموع";
        }

        private void btnDelegates_Click(object sender, EventArgs e)
        {
            this.reset();
            this.reportForm = Enumerators.ReportForm.ReportGeneral;
            this.reportName = Enumerators.ReportsName.Delegates;
            this.dateTo.Show();
        }

        private void reportDelegate()
        {
            DataGridView dataGridView = this.dgvResults;
            HMySQLConnection hMySQLConnection = this.databaseConnection;
            string text = this.cmbClients.Text;
            DateTime value = this.dateFrom.Value;
            string arg = value.ToString("yyyy-MM-dd 00:00:00");
            value = this.dateTo.Value;
            dataGridView.DataSource = hMySQLConnection.query(string.Format("select tbl_bills.id, tbl_bills.name, (DATE_FORMAT(tbl_bills.datetime,'%y.%m.%d')) as `datetime`, (if(tbl_bills.is_cash = 1,'نقد','أجل')) as `is_cash`, (if(tbl_bills.is_dollar = 1,CONCAT('$ ',getDollar(tbl_bills.datetime)),'IQD')) as `is_dollar`, FORMAT(((ifnull(( select (sum(tbl_products.count * tbl_products.price) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id ),0))),2) as `total`, FORMAT(((ifnull((if(tbl_bills.is_cash = 0,(select sum(tbl_balance.value) * if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1) from tbl_balance where tbl_balance.bill_id = tbl_bills.id),(ifnull(( select (sum(tbl_products.count * tbl_products.price) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id),0))) ),0))),2) as `receiving`, FORMAT(((ifnull((((ifnull((select(sum(tbl_products.count * tbl_products.price) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id),0)) - (ifnull(( select sum(tbl_balance.value) * if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1) from tbl_balance where tbl_balance.bill_id = tbl_bills.id ),0))) * if(tbl_bills.is_cash = 1,0,1) ),0))),2) as `remaining`, FORMAT(( select sum(tbl_products.delegate_percentage * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1)) from tbl_products where tbl_products.bill_id = tbl_bills.id ),2) as `delegate_percent` from tbl_bills, tbl_clients where tbl_bills.id > 0 and tbl_clients.`type` = 2 and tbl_bills.delegate_id = tbl_clients.id and tbl_clients.id = (select id from tbl_clients where tbl_clients.name = '{0}' and tbl_clients.`type` = 2) and tbl_bills.datetime between'{1}' and '{2}'", text, arg, value.ToString("yyyy-MM-dd 23:59:59")));
            this.dgvResults.Columns["id"].HeaderText = "رقم القائمة";
            this.dgvResults.Columns["name"].HeaderText = "اسم العميل";
            this.dgvResults.Columns["datetime"].HeaderText = "تاريخ";
            this.dgvResults.Columns["is_cash"].HeaderText = "التعامل";
            this.dgvResults.Columns["is_dollar"].HeaderText = "العملة";
            this.dgvResults.Columns["total"].HeaderText = "المجموع";
            this.dgvResults.Columns["receiving"].HeaderText = "المستلم";
            this.dgvResults.Columns["remaining"].HeaderText = "المتبقي";
            this.dgvResults.Columns["delegate_percent"].HeaderText = "نسبة المندوب";
        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            this.reset();
            this.reportName = Enumerators.ReportsName.Delegate;
            this.reportForm = Enumerators.ReportForm.DelegateReport;
            this.dateFrom.Show();
            this.dateTo.Show();
            this.cmbClients.Show();
            this.cmbClients.Items.AddRange(this.getClients(this.cmbClients, Enumerators.ClientTypes.Delegate));
        }

        private void reportClient()
        {
            DataGridView dataGridView = this.dgvResults;
            HMySQLConnection hMySQLConnection = this.databaseConnection;
            string text = this.cmbClients.Text;
            DateTime value = this.dateFrom.Value;
            string arg = value.ToString("yyyy-MM-dd 00:00:00");
            value = this.dateTo.Value;
            dataGridView.DataSource = hMySQLConnection.query(string.Format("select tbl_bills.id,tbl_bills.name,if(tbl_bills.is_cash = 1,'نقد','أجل') as `is_cash`,DATE_FORMAT(tbl_bills.datetime,'%y-%m-%d') as `datetime`,if(tbl_bills.is_dollar = 1,CONCAT('$ ',getDollar(tbl_bills.datetime)),'IQD') as `is_dollar`,(ifnull((select sum(if(tbl_bills.is_dollar = 1,tbl_products.price * tbl_products.count * getDollar(tbl_bills.datetime),tbl_products.price * tbl_products.count)) from tbl_products where tbl_products.bill_id = tbl_bills.id),0) - tbl_bills.discount) as `total`,((ifnull((select sum(if(tbl_bills.is_dollar = 1,tbl_products.price * tbl_products.count * getDollar(tbl_bills.datetime),tbl_products.price * tbl_products.count)) from tbl_products where tbl_products.bill_id = tbl_bills.id),0) - tbl_bills.discount) - (ifnull((select sum(if(tbl_balance.is_dollar = 1,tbl_balance.value * getDollar(tbl_bills.datetime),tbl_balance.value)) from tbl_balance where tbl_balance.bill_id = tbl_bills.id),0))) * if(tbl_bills.is_cash = 1,0,1) as `remaining`,(ifnull((select sum(if(tbl_balance.is_dollar = 1,tbl_balance.value * getDollar(tbl_bills.datetime),tbl_balance.value)) from tbl_balance where tbl_balance.bill_id = tbl_bills.id),0)) * if(tbl_bills.is_cash = 1,0,1) as `receiving`from tbl_bills where tbl_bills.id > 0 and tbl_bills.client_id = (select id from tbl_clients where tbl_clients.name = '{0}') and tbl_bills.datetime between '{1}' and '{2}';", text, arg, value.ToString("yyyy-MM-dd 23:59:59")));
            this.dgvResults.Columns["id"].HeaderText = "رقم القائمة";
            this.dgvResults.Columns["name"].HeaderText = "اسم";
            this.dgvResults.Columns["datetime"].HeaderText = "تاريخ";
            this.dgvResults.Columns["is_cash"].HeaderText = "التعامل";
            this.dgvResults.Columns["is_dollar"].HeaderText = "العملة";
            this.dgvResults.Columns["total"].HeaderText = "المجموع";
            this.dgvResults.Columns["receiving"].HeaderText = "المستلم";
            this.dgvResults.Columns["remaining"].HeaderText = "المتبقي";
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            this.reset();
            this.reportName = Enumerators.ReportsName.Client;
            this.reportForm = Enumerators.ReportForm.ReportGeneral;
            this.dateFrom.Show();
            this.dateTo.Show();
            this.cmbClients.Show();
            this.cmbClients.Items.AddRange(this.getClients(this.cmbClients, Enumerators.ClientTypes.ClientSupplier));
        }

        private object[] getClients(System.Windows.Forms.ComboBox cmb, Enumerators.ClientTypes clientType)
        {
            cmb.Items.Clear();
            List<string> list = new List<string>();
            DataTable dataTable = this.databaseConnection.query(string.Format("SELECT name FROM tbl_clients {0};", (clientType == Enumerators.ClientTypes.ClientSupplier) ? " where type = '0' OR '1'" : string.Format("where type = '{0}'", (int)clientType)));
            cmb.Items.Add("الكل");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                list.Add(dataTable.Rows[i][0].ToString());
            }
            return list.ToArray();
        }

        private void reportEmployeeDebits()
        {
            DataGridView dataGridView = this.dgvResults;
            HMySQLConnection hMySQLConnection = this.databaseConnection;
            DateTime value = this.dateFrom.Value;
            string arg = value.ToString("yyyy-MM-dd 00:00:00");
            value = this.dateTo.Value;
            dataGridView.DataSource = hMySQLConnection.query(string.Format("select tbl_clients.name,(ifnull((select sum(if(tbl_debits.is_dollar = 1,tbl_debits.value * getDollar(tbl_debits.datetime),tbl_debits.value )) from tbl_debits where tbl_debits.employee_id = tbl_clients.id and tbl_debits.is_pay = 0 and tbl_debits.datetime between '{0}' and '{1}'),0)) as `debits`,(ifnull((select sum(if(tbl_debits.is_dollar = 1,tbl_debits.value * getDollar(tbl_debits.datetime),tbl_debits.value )) from tbl_debits where tbl_debits.employee_id = tbl_clients.id and tbl_debits.is_pay = 1 and tbl_debits.datetime between '{0}' and '{1}'),0)) as `paid`, ((ifnull(( select sum(if(tbl_debits.is_dollar = 1,tbl_debits.value * getDollar(tbl_debits.datetime),tbl_debits.value )) from tbl_debits where tbl_debits.employee_id = tbl_clients.id and tbl_debits.is_pay = 0 and tbl_debits.datetime between '{0}' and '{1}' ),0)) - (ifnull((select sum(if(tbl_debits.is_dollar = 1,tbl_debits.value * getDollar(tbl_debits.datetime),tbl_debits.value )) from tbl_debits where tbl_debits.employee_id = tbl_clients.id and tbl_debits.is_pay = 1 and tbl_debits.datetime between '{0}' and '{1}' ),0))) as `remaining` from tbl_clients where tbl_clients.`type` = 3", arg, value.ToString("yyyy-MM-dd 23:59:59")));
            this.dgvResults.Columns["name"].HeaderText = "الموظف";
            this.dgvResults.Columns["debits"].HeaderText = "المقروض";
            this.dgvResults.Columns["paid"].HeaderText = "المسدد";
            this.dgvResults.Columns["remaining"].HeaderText = "المتبقي";
        }

        private void btnEmployeeDebits_Click(object sender, EventArgs e)
        {
            this.reset();
            this.reportName = Enumerators.ReportsName.EmployeeDebits;
            this.reportForm = Enumerators.ReportForm.ReportGeneral;
            this.dateFrom.Show();
            this.dateTo.Show();
        }

        private void reportEmployee()
        {
            DataGridView dataGridView = this.dgvResults;
            HMySQLConnection hMySQLConnection = this.databaseConnection;
            string text = this.cmbClients.Text;
            DateTime value = this.dateFrom.Value;
            string arg = value.ToString("yyyy-MM-dd 00:00:00");
            value = this.dateTo.Value;
            dataGridView.DataSource = hMySQLConnection.query(string.Format("select date_format(tbl_debits.datetime,'%Y-%m-%d') as `datetime`,if(tbl_debits.is_pay = 1,'تسديد','قرض') as `is_pay`,if(tbl_debits.is_dollar = 1,CONCAT('$ ',getDollar(tbl_bills.datetime)),'IQD') as `is_dollar`,if(tbl_debits.is_dollar = 1,tbl_debits.value * getDollar(tbl_debits.datetime),tbl_debits.value) as `value` from tbl_debits, tbl_clients where tbl_debits.employee_id = tbl_clients.id and tbl_clients.name = '{0}' and tbl_debits.datetime between '{1}' and '{2}'", text, arg, value.ToString("yyyy-MM-dd 23:59:59")));
            this.dgvResults.Columns["datetime"].HeaderText = "التاريخ";
            this.dgvResults.Columns["is_pay"].HeaderText = "التعامل";
            this.dgvResults.Columns["is_dollar"].HeaderText = "العملة";
            this.dgvResults.Columns["value"].HeaderText = "القيمة";
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.reset();
            this.reportForm = Enumerators.ReportForm.EmpReport;
            this.reportName = Enumerators.ReportsName.Employee;
            this.dateFrom.Show();
            this.dateTo.Show();
            this.cmbClients.Show();
            this.cmbClients.Items.AddRange(this.getClients(this.cmbClients, Enumerators.ClientTypes.Employer));
        }

        private void btnCaseValue_Click(object sender, EventArgs e)
        {
            this.reset();
            this.reportName = Enumerators.ReportsName.CaseValue;
            this.reportForm = Enumerators.ReportForm.caseValue;
            this.dateFrom.Show();
            this.dateTo.Show();
        }

        private void reportCaseValue()
        {
            DataGridView dataGridView = this.dgvResults;
            HMySQLConnection hMySQLConnection = this.databaseConnection;
            DateTime value = this.dateFrom.Value;
            string arg = value.ToString("yyyy-MM-dd 00:00:00");
            value = this.dateTo.Value;
            dataGridView.DataSource = hMySQLConnection.query(string.Format("call getCaseValue('{0}','{1}')", arg, value.ToString("yyyy-MM-dd 23:59:59")));
            caseValue report = new caseValue(this.databaseConnection, this.dgvResults, "الصندوق", true, true, this.dateFrom.Value, this.dateTo.Value,Properties.Settings.Default.dollarValue, "");
            new ReportPrintTool(report).ShowRibbonPreview();
            this.reset();
        }

        private void reportBill()
        {
            DataGridView dataGridView = this.dgvResults;
            HMySQLConnection hMySQLConnection = this.databaseConnection;
            DateTime value = this.dateFrom.Value;
            string arg = value.ToString("yyyy-MM-dd 00:00:00");
            value = this.dateTo.Value;
            dataGridView.DataSource = hMySQLConnection.query(string.Format("select tbl_bills.name,tbl_products.bill_id,date_format(tbl_bills.datetime,'%Y-%m-%d') as `datetime`,tbl_products.description,if(tbl_bills.is_dollar = 1,CONCAT('$ ',getDollar(tbl_bills.datetime)),'IQD') as `is_dollar`,(tbl_products.count * tbl_products.price) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) as `total` from tbl_products,tbl_bills,tbl_clients where tbl_products.bill_id = tbl_bills.id and tbl_bills.client_id = tbl_clients.id and tbl_bills.datetime between '{0}' and '{1}' and tbl_bills.is_account = 1 {2}", arg, value.ToString("yyyy-MM-dd 23:59:59"), ((int)this.grpImport.EditValue == 2) ? "" : (" and tbl_bills.is_sell = '" + (int)this.grpImport.EditValue + "' ")));
            this.dgvResults.Columns["name"].HeaderText = "العميل";
            this.dgvResults.Columns["bill_id"].HeaderText = "القائمة";
            this.dgvResults.Columns["description"].HeaderText = "المادة";
            this.dgvResults.Columns["is_dollar"].HeaderText = "العملة";
            this.dgvResults.Columns["total"].HeaderText = "القيمة";
            this.dgvResults.Columns["datetime"].HeaderText = "تاريخ";
            this.dgvResults.Columns["receiving"].HeaderText = "المستلم";
            this.dgvResults.Columns["remaining"].HeaderText = "المتبقي";
        }

        private void reportDate()
        {
            DataGridView dataGridView = this.dgvResults;
            HMySQLConnection hMySQLConnection = this.databaseConnection;
            string format = "select selected_date,ifnull((( select sum(( select (sum(tbl_products.price * tbL_products.count) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id )) from  tbl_bills where  tbl_bills.datetime = selected_date and tbl_bills.is_cash = 1 and tbl_bills.is_sell = 1 and tbl_bills.is_account = 1 " + ((this.cmbUsers.Text == "الكل") ? "" : (" and tbl_bills.user_id = (select id from tbl_users where tbl_users.name = '" + this.cmbUsers.Text + "') ")) + " ) ),0) as `cash`, ifnull(( ( select sum(tbl_balance.value * if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1)) from tbl_balance where tbl_balance.creation = selected_date " + ((this.cmbUsers.Text == "الكل") ? "" : (" and tbl_balance.user_id = (select id from tbl_users where tbl_users.name = '" + this.cmbUsers.Text + "') ")) + " ) ),0) as `balance`, ifnull(( ( select sum(tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1)) from tbl_debits where tbl_debits.datetime = selected_date and tbl_debits.is_pay = 1 " + ((this.cmbUsers.Text == "الكل") ? "" : (" and tbl_debits.user_id = (select id from tbl_users where tbl_users.name = '" + this.cmbUsers.Text + "') ")) + " ) ),0) as `pay`, ifnull(( ( select sum(tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1)) from tbl_debits where tbl_debits.datetime = selected_date and tbl_debits.is_pay = 0 ) ),0) as `debit`, ifnull(( ( select sum(( select (sum(tbl_products.price * tbL_products.count) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id )) from  tbl_bills where  tbl_bills.datetime = selected_date and tbl_bills.is_sell = 0 and tbl_bills.is_account = 1 ) ),0) as `export`, ifnull(( ( select sum(( select (sum(tbl_products.price * tbL_products.count) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id )) \tfrom  tbl_bills \twhere  tbl_bills.datetime = selected_date and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 and tbl_bills.is_account = 1 ) ),0) as `not_cash`, ifnull(( (ifnull((( select sum(( select \t(sum(tbl_products.price * tbL_products.count) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id)) from  tbl_bills where  tbl_bills.datetime = selected_date and tbl_bills.is_cash = 1 and tbl_bills.is_sell = 1 and tbl_bills.is_account = 1)),0)) +(ifnull((( select sum(tbl_balance.value * if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1)) from tbl_balance where tbl_balance.creation = selected_date ) ),0)) + (ifnull(( ( select sum(tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1)) from tbl_debits where tbl_debits.datetime = selected_date and tbl_debits.is_pay = 1 )),0)) - (ifnull(( ( select sum(tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1)) from tbl_debits where tbl_debits.datetime = selected_date and tbl_debits.is_pay = 0)),0)) - (ifnull(( ( select  sum(( select (sum(tbl_products.price * tbL_products.count) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id )) from  tbl_bills where  tbl_bills.datetime = selected_date and tbl_bills.is_sell = 0 and tbl_bills.is_account = 1)),0)) ),0) as `remaining`,ifnull(( (ifnull(( (select sum(( select (sum(tbl_products.price * tbL_products.count) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id ))from  tbl_bills where  tbl_bills.datetime = selected_date and tbl_bills.is_cash = 1 and tbl_bills.is_sell = 1 and tbl_bills.is_account = 1)),0)) +(ifnull(((select sum(tbl_balance.value * if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1)) from tbl_balance where tbl_balance.creation = selected_date )),0)) -  (ifnull(( (select sum((select (sum(tbl_products.price * tbL_products.count) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id )) from  tbl_bills where  tbl_bills.datetime = selected_date and tbl_bills.is_sell = 0 and tbl_bills.is_account = 1 ) ),0)) ),0) as `total` from (select adddate('1970-01-01',t4.i*10000 + t3.i*1000 + t2.i*100 + t1.i*10 + t0.i) selected_date from (select 0 i union select 1 union select 2 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9) t0,(select 0 i union select 1 union select 2 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9) t1,(select 0 i union select 1 union select 2 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9) t2,(select 0 i union select 1 union select 2 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9) t3, (select 0 i union select 1 union select 2 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9) t4) as v where selected_date between '{0}' and '{1}'";
            DateTime dateTime = this.dateFrom.Value;
            dateTime = dateTime.AddDays(-1.0);
            string arg = dateTime.ToString("yyyy-MM-dd 00:00:00");
            dateTime = this.dateTo.Value;
            dataGridView.DataSource = hMySQLConnection.query(string.Format(format, arg, dateTime.ToString("yyyy-MM-dd 23:59:59")));
            this.dgvResults.Columns["selected_date"].HeaderText = "التاريخ";
            this.dgvResults.Columns["cash"].HeaderText = "نقد";
            this.dgvResults.Columns["balance"].HeaderText = "رصيد";
            this.dgvResults.Columns["pay"].HeaderText = "تسديد";
            this.dgvResults.Columns["debit"].HeaderText = "قرض";
            this.dgvResults.Columns["export"].HeaderText = "صادر";
            this.dgvResults.Columns["not_cash"].HeaderText = "أجل";
            this.dgvResults.Columns["remaining"].HeaderText = "متبقي";
            this.dgvResults.Columns["total"].HeaderText = "محصلة";
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            this.reset();
            this.reportName = Enumerators.ReportsName.ReportDate;
            this.reportForm = Enumerators.ReportForm.ReportGeneral;
            this.dateFrom.Show();
            this.dateTo.Show();
            this.cmbUsers.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            switch (this.reportForm)
            {
                case Enumerators.ReportForm.ReportGeneral:
                    new ReportPrintTool(new ReportGeneral(this.databaseConnection, this.dgvResults, "الوارد اليومي", true, true, this.dateFrom.Value, this.dateTo.Value, Properties.Settings.Default.dollarValue, this.reportName, (int)this.grpImport.EditValue, (int)this.grpCash.EditValue, this.cmbClients.Text)).ShowRibbonPreview();
                    break;
                case Enumerators.ReportForm.BillWithReport:
                    new ReportPrintTool(new billsWithProducts(this.databaseConnection, this.dgvResults, "قوائم:" + (((int)this.grpImport.EditValue == 2) ? "الكل" : "صادر"), true, true, this.dateFrom.Value, this.dateTo.Value, Properties.Settings.Default.dollarValue, "")).ShowRibbonPreview();
                    break;
                case Enumerators.ReportForm.EmpReport:
                    new ReportPrintTool(new EmpReport(this.databaseConnection, this.dgvResults, "الموظف:" + this.cmbClients.Text, true, true, this.dateFrom.Value, this.dateTo.Value, Properties.Settings.Default.dollarValue, this.cmbClients.Text)).ShowRibbonPreview();
                    break;
                case Enumerators.ReportForm.DelegateReport:
                    new ReportPrintTool(new DelegateReport(this.databaseConnection, this.dgvResults, "المندوب:" + this.cmbClients.Text, true, true, this.dateFrom.Value, this.dateTo.Value, Properties.Settings.Default.dollarValue, this.cmbClients.Text)).ShowRibbonPreview();
                    break;
            }
            this.reset();
        }

        private void reset()
        {
            this.dateFrom.Hide();
            this.dateTo.Hide();
            this.grpImport.Hide();
            this.grpCash.Hide();
            this.cmbClients.Hide();
            this.cmbDelegates.Hide();
            this.grpCurrency.Hide();
            this.grpPayMethod.Hide();
            this.cmbUsers.Hide();
            this.cmbDelegates.Items.Clear();
            this.cmbClients.Items.Clear();
            this.dgvResults.Columns.Clear();
            TextBox textBox = this.txtCash;
            TextBox textBox2 = this.txtBalance;
            TextBox textBox3 = this.txtDebit;
            TextBox textBox4 = this.txtExport;
            TextBox textBox5 = this.txtNotCash;
            TextBox textBox6 = this.txtPay;
            TextBox textBox7 = this.txtRemaining;
            TextBox textBox8 = this.txtTotal;
            string text2 = textBox8.Text = "0";
            string text4 = textBox7.Text = text2;
            string text6 = textBox6.Text = text4;
            string text8 = textBox5.Text = text6;
            string text10 = textBox4.Text = text8;
            string text12 = textBox3.Text = text10;
            string text15 = textBox.Text = (textBox2.Text = text12);
            this.cash = 0.0;
            this.debet = 0.0;
            this.balanceImport = 0.0;
            this.balanceExport = 0.0;
            this.export = 0.0;
            this.payDebit = 0.0;
            this.debit = 0.0;
            this.grpImport.SelectedIndex = 2;
            this.grpCash.SelectedIndex = 2;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (this.reportName)
            {
                case Enumerators.ReportsName.none:
                    break;
                case Enumerators.ReportsName.Employee:
                    break;
                case Enumerators.ReportsName.Daily:
                    this.reportDaily();
                    break;
                case Enumerators.ReportsName.BillsProducts:
                    new ReportPrintTool(new ReportSequance(this.databaseConnection, "القوائم", this.dateFrom.Value, this.dateTo.Value, Properties.Settings.Default.dollarValue, (int)this.grpCash.EditValue, (int)this.grpCurrency.EditValue, (int)this.grpImport.EditValue, this.cmbClients.Text, this.cmbUsers.Text)).ShowRibbonPreview();
                    this.reset();
                    break;
                case Enumerators.ReportsName.BillReport:
                    this.reportBill();
                    break;
                case Enumerators.ReportsName.DebitsClients:
                    this.reportDebitsClients();
                    break;
                case Enumerators.ReportsName.CaseValue:
                    this.reportCaseValue();
                    break;
                case Enumerators.ReportsName.DebitsSell:
                    this.reportDebitsSell();
                    break;
                case Enumerators.ReportsName.EmployeeDebits:
                    this.reportEmployeeDebits();
                    break;
                case Enumerators.ReportsName.Delegates:
                    this.reportDelegates();
                    break;
                case Enumerators.ReportsName.Delegate:
                    this.reportDelegate();
                    break;
                case Enumerators.ReportsName.ReportDate:
                    this.reportDate();
                    break;
                case Enumerators.ReportsName.Bills:
                    this.billsReport();
                    break;
                case Enumerators.ReportsName.Products:
                    this.productsReport();
                    break;
                case Enumerators.ReportsName.Client:
                    this.reportClient();
                    break;
                case Enumerators.ReportsName.ClientPay:
                    this.reportClientPay();
                    break;
            }
        }

        private void btnBillReport_Click(object sender, EventArgs e)
        {
            this.reset();
            this.reportName = Enumerators.ReportsName.BillsProducts;
            this.reportForm = Enumerators.ReportForm.ReportSequance;
            this.dateFrom.Show();
            this.dateTo.Show();
            this.grpCash.Show();
            this.grpImport.Show();
            this.grpCurrency.Show();
            this.cmbClients.Show();
            this.cmbUsers.Show();
            this.cmbClients.Items.AddRange(this.getClients(this.cmbClients, Enumerators.ClientTypes.ClientSupplier));
        }

        private void billsReport()
        {
            DataGridView dataGridView = this.dgvResults;
            HMySQLConnection hMySQLConnection = this.databaseConnection;
            object[] obj = new object[7];
            DateTime value = this.dateFrom.Value;
            obj[0] = value.ToString("yyyy-MM-dd 00:00:00");
            value = this.dateTo.Value;
            obj[1] = value.ToString("yyyy-MM-dd 23:59:59");
            obj[2] = (((int)this.grpImport.EditValue == 2) ? "" : (" and tbl_bills.is_sell = '" + (int)this.grpImport.EditValue + "' "));
            obj[3] = (((int)this.grpCash.EditValue == 1) ? " and ifnull(if (tbl_bills.is_cash = 1,0,ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id) - tbl_bills.discount),0)-ifnull(((select sum(tbl_balance.value) from tbl_balance where tbl_balance.bill_id = tbl_bills.id)),0)),0) = 0" : (((int)this.grpCash.EditValue == 0) ? " and tbl_bills.is_cash = 0 and ifnull(if (tbl_bills.is_cash = 1,0,ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id) - tbl_bills.discount),0)-ifnull(((select sum(tbl_balance.value) from tbl_balance where tbl_balance.bill_id = tbl_bills.id)),0)),0) > 0" : ""));
            obj[4] = ((this.cmbClients.Text == "الكل") ? "" : ("and tbl_clients.name = '" + this.cmbClients.Text + "'"));
            obj[5] = (((int)this.grpCurrency.EditValue == 2) ? "" : (" and tbl_bills.is_dollar = '" + (int)this.grpCurrency.EditValue + "' "));
            obj[6] = ((this.cmbDelegates.Text == "الكل") ? "" : (" and tbl_bills.delegate_id = (select id from tbl_clients where tbl_clients.type = '2' and tbl_clients.name = '" + this.cmbDelegates.Text + "' ) " + ((this.cmbUsers.Text == "الكل") ? "" : (" and tbl_bills.user_id = (select id from tbl_users where tbl_users.name = '" + this.cmbUsers.Text + "') "))));
            dataGridView.DataSource = hMySQLConnection.query(string.Format("select if(tbl_clients.name = tbl_bills.name,tbl_bills.name,CONCAT(tbl_clients.name,' - ',tbl_bills.name)) as `name` , tbl_bills.id, (DATE_FORMAT(tbl_bills.datetime,'%Y-%m-%d')) as `datetime`,  if(tbl_bills.is_dollar = 1,concat('$ ',getDollar(tbl_bills.datetime)),'IQD') as `is_dollar`, format(ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id) - tbl_bills.discount),0),2) as `total`,format(ifnull(if(tbl_bills.is_cash = 1,ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id) - tbl_bills.discount),0),(select sum(tbl_balance.value)  from tbl_balance where tbl_balance.bill_id = tbl_bills.id)),0),2) as `receiving`,format(ifnull(if(tbl_bills.is_cash = 1,0,ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id) - tbl_bills.discount),0)-ifnull(((select sum(tbl_balance.value) from tbl_balance where tbl_balance.bill_id = tbl_bills.id)),0)),0),2) as `remaining`, tbl_bills.note from tbl_clients, tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.id > 0 and tbl_bills.is_account = 1 {2} {3} and tbl_bills.datetime between '{0}' and '{1}' {4} {5} {6}", obj));
            this.dgvResults.Columns["name"].HeaderText = "العميل";
            this.dgvResults.Columns["id"].HeaderText = "قائمة";
            this.dgvResults.Columns["datetime"].HeaderText = "التاريخ";
            this.dgvResults.Columns["note"].HeaderText = "ملاحظة";
            this.dgvResults.Columns["is_dollar"].HeaderText = "العملة";
            this.dgvResults.Columns["total"].HeaderText = "المجموع";
            this.dgvResults.Columns["receiving"].HeaderText = "المستلم";
            this.dgvResults.Columns["remaining"].HeaderText = "المتبقي";
            this.dgvResults.Columns["id"].Width = 50;
            this.dgvResults.Columns["name"].Width = 150;
            this.dgvResults.Columns["datetime"].Width = 70;
            this.dgvResults.Columns["is_dollar"].Width = 50;
            this.dgvResults.Columns["total"].Width = 70;
            this.dgvResults.Columns["receiving"].Width = 70;
            this.dgvResults.Columns["remaining"].Width = 70;
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            this.reset();
            this.reportName = Enumerators.ReportsName.Bills;
            this.reportForm = Enumerators.ReportForm.ReportGeneral;
            this.dateFrom.Show();
            this.dateTo.Show();
            this.grpImport.Show();
            this.grpCash.Show();
            this.grpCurrency.Show();
            this.cmbClients.Show();
            this.cmbDelegates.Show();
            this.cmbUsers.Show();
            this.cmbDelegates.Items.AddRange(this.getClients(this.cmbDelegates, Enumerators.ClientTypes.Delegate));
            this.cmbDelegates.Text = this.cmbDelegates.Items[0].ToString();
            this.cmbClients.Items.AddRange(this.getClients(this.cmbClients, Enumerators.ClientTypes.ClientSupplier));
            this.cmbClients.Text = this.cmbClients.Items[0].ToString();
        }

        private void productsReport()
        {
            DataGridView dataGridView = this.dgvResults;
            HMySQLConnection hMySQLConnection = this.databaseConnection;
            object[] obj = new object[5];
            DateTime value = this.dateFrom.Value;
            obj[0] = value.ToString("yyyy-MM-dd 00:00:00");
            value = this.dateTo.Value;
            obj[1] = value.ToString("yyyy-MM-dd 23:59:59");
            obj[2] = (((int)this.grpImport.EditValue == 2) ? "" : (" and tbl_bills.is_sell = '" + (int)this.grpImport.EditValue + "' "));
            obj[3] = (((int)this.grpCash.EditValue == 2) ? "" : (" and tbl_bills.is_cash = '" + (int)this.grpCash.EditValue + "' "));
            obj[4] = ((this.cmbClients.Text == "الكل") ? "" : (" and tbl_clients.name = '" + this.cmbClients.Text + "' " + ((this.cmbUsers.Text == "الكل") ? "" : (" and tbl_bills.user_id = (select id from tbl_users where tbl_users.name = '" + this.cmbUsers.Text + "') "))));
            dataGridView.DataSource = hMySQLConnection.query(string.Format("select tbl_clients.name, tbl_bills.id, DATE_FORMAT(tbl_bills.datetime,'%Y-%m-%d') `datetime`, tbl_products.description, FORMAT(tbl_products.price,0) as `price`, FORMAT(tbl_products.count,0) as `count`,FORMAT(((tbl_products.price * tbl_products.count) * if(tbl_bills.is_dollar = 1,0,1)),0) `total_dinar`, ((tbl_products.price * tbl_products.count) * if(tbl_bills.is_dollar = 1,1,0)) `total_dollar`, tbl_products.note from tbl_bills, tbl_products, tbl_clients where tbl_bills.client_id = tbl_clients.id and tbl_bills.id = tbl_products.bill_id {2} {3} and tbl_bills.is_account = 1 and tbl_bills.datetime between '{0}' and '{1}' {4} group by tbl_products.id order by tbl_bills.id", obj));
            this.dgvResults.Columns["name"].HeaderText = "العميل";
            this.dgvResults.Columns["id"].HeaderText = "قائمة";
            this.dgvResults.Columns["note"].HeaderText = "ملاحظة";
            this.dgvResults.Columns["datetime"].HeaderText = "التاريخ";
            this.dgvResults.Columns["total_dinar"].HeaderText = "دينار";
            this.dgvResults.Columns["price"].HeaderText = "سعر";
            this.dgvResults.Columns["count"].HeaderText = "عدد";
            this.dgvResults.Columns["description"].HeaderText = "المادة";
            this.dgvResults.Columns["total_dollar"].HeaderText = "دولار";
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.reset();
            this.reportName = Enumerators.ReportsName.Products;
            this.reportForm = Enumerators.ReportForm.ReportGeneral;
            this.dateFrom.Show();
            this.dateTo.Show();
            this.grpImport.Show();
            this.grpCash.Show();
            this.cmbClients.Show();
            this.cmbUsers.Show();
            this.cmbClients.Items.AddRange(this.getClients(this.cmbClients, Enumerators.ClientTypes.ClientSupplier));
            this.cmbClients.Text = this.cmbClients.Items[0].ToString();
        }

        private void reportClientPay()
        {
            DataGridView dataGridView = this.dgvResults;
            HMySQLConnection hMySQLConnection = this.databaseConnection;
            object[] obj = new object[4]
            {
            (this.cmbClients.Text == "الكل") ? "" : (" and tbl_clients.name = '" + this.cmbClients.Text + "' "),
            null,
            null,
            null
            };
            DateTime value = this.dateFrom.Value;
            obj[1] = value.ToString("yyyy-MM-dd 00:00:00");
            value = this.dateTo.Value;
            obj[2] = value.ToString("yyyy-MM-dd 23:59:59");
            obj[3] = (((int)this.grpPayMethod.EditValue == 1) ? "id" : "balance_pay_id");
            dataGridView.DataSource = hMySQLConnection.query(string.Format("select tbl_balance.id,tbl_clients.name,tbl_balance.bill_id,DATE_FORMAT(tbl_balance.creation,'%Y-%m-%d') as `creation`,if(tbl_balance.is_dollar = 1,CONCAT('$ ',getDollar(tbl_balance.creation)),'IQD') as `is_dollar`,sum(tbl_balance.value) as `value`,tbl_balance.note from tbl_balance,tbl_clients where tbl_clients.id = tbl_balance.client_id and tbl_clients.type = 0 {0} and tbl_balance.creation between '{1}' and '{2}' group by tbl_balance.{3} order by type asc", obj));
            this.dgvResults.Columns["id"].Visible = false;
            this.dgvResults.Columns["bill_id"].HeaderText = "القائمة";
            this.dgvResults.Columns["bill_id"].Visible = ((int)this.grpPayMethod.EditValue == 1);
            this.dgvResults.Columns["name"].HeaderText = "العميل";
            this.dgvResults.Columns["is_dollar"].HeaderText = "العملة";
            this.dgvResults.Columns["value"].HeaderText = "القيمة";
            this.dgvResults.Columns["creation"].HeaderText = "التاريخ";
            this.dgvResults.Columns["note"].HeaderText = "ملاحظة";
        }

        private void btnClientPay_Click(object sender, EventArgs e)
        {
            this.reportName = Enumerators.ReportsName.ClientPay;
            this.reportForm = Enumerators.ReportForm.ReportGeneral;
            this.dateFrom.Show();
            this.dateTo.Show();
            this.grpPayMethod.Show();
            this.cmbClients.Show();
            this.cmbClients.Items.AddRange(this.getClients(this.cmbClients, Enumerators.ClientTypes.ClientSupplier));
        }

        private void grpImport_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbClients.Items.AddRange(this.getClients(this.cmbClients, Enumerators.ClientTypes.Client));
        }
    }
}
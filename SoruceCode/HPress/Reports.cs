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
    public partial class Reports : DevExpress.XtraEditors.XtraForm
    {
        HDatabaseConnection.HMySQLConnection databaseConnection;
        int reportId = 0;
        
        Enumerators.ReportForm reportForm;
        Enumerators.ReportsName reportName;
        double cash = 0;
        double debet = 0;
        double balanceImport = 0;
        double balanceExport = 0;
        double export = 0;
        double payDebit = 0;
        double debit = 0;
        public Reports(HDatabaseConnection.HMySQLConnection databaseConnection,Enumerators.ReportsName reportName = Enumerators.ReportsName.none,params string[] args)
        {
            InitializeComponent();
            reportForm = Enumerators.ReportForm.none;
            dateFrom.Value = dateTo.Value = DateTime.Now;
            this.databaseConnection = databaseConnection;

            switch (Properties.Settings.Default.userType)
            {
                case (int)Enumerators.UserType.Admin:
                    btnDailyReport.Enabled = true;
                    btnProducts.Enabled = true;
                    btnEmployeeDebits.Enabled = true;
                    btnEmployee.Enabled = true;
                    btnDelegates.Enabled = true;
                    btnDelegate.Enabled = true;
                    btnDebitsSell.Enabled = true;
                    btnDebitsClients.Enabled = true;
                    btnDate.Enabled = true;
                    btnDailyReport.Enabled = true;
                    btnClient.Enabled = true;
                    btnCaseValue.Enabled = true;
                    btnBills.Enabled = true;
                    btnBillReport.Enabled = true;
                    btnClientPay.Enabled = true;
                    break;
                case (int)Enumerators.UserType.User:
                    btnDailyReport.Enabled = true;
                    break;
                default:
                    break;
            }
            switch (reportName)
            {
                case Enumerators.ReportsName.none:
                    break;
                case Enumerators.ReportsName.Daily:
                    break;
                case Enumerators.ReportsName.BillsProducts:
                    break;
                case Enumerators.ReportsName.BillReport:
                    break;
                case Enumerators.ReportsName.DebitsClients:
                    break;
                case Enumerators.ReportsName.CaseValue:
                    break;
                case Enumerators.ReportsName.DebitsSell:
                    break;
                case Enumerators.ReportsName.EmployeeDebits:
                    break;
                case Enumerators.ReportsName.Client:
                    btnClient_Click(null, null);
                    cmbClients.Text = args[0];
                    dateFrom.Value = DateTime.Parse(args[1]);
                    dateTo.Value = DateTime.Parse(args[2]);
                    break;
                case Enumerators.ReportsName.Employee:
                    break;
                case Enumerators.ReportsName.Delegates:
                    break;
                case Enumerators.ReportsName.Delegate:
                    break;
                case Enumerators.ReportsName.ReportDate:
                    break;
                case Enumerators.ReportsName.Bills:
                    break;
                case Enumerators.ReportsName.Products:
                    break;
                case Enumerators.ReportsName.ClientPay:
                    btnClientPay_Click(null, null);
                    cmbClients.Text = args[0];
                    dateFrom.Value = DateTime.Parse(args[1]);
                    dateTo.Value = DateTime.Parse(args[2]);
                    break;
                default:
                    break;
            }
            if (reportName != Enumerators.ReportsName.none)
            {
                btnSearch_Click(null, null);
                btnPrint_Click(null, null);
            }
        }
        void reportDaily()
        {
            //dgvResults.Columns.Clear();
            //dgvResults.DataSource = null;

            //DataTable d1 = databaseConnection.query(string.Format("select if(tbl_bills.is_sell = 1,'وارد','صادر') as `is_sell`, tbl_bills.id, if(tbl_clients.name = tbl_bills.name,tbl_clients.name,CONCAT(tbl_clients.name,' : ',tbl_bills.name)), if(tbl_bills.is_cash = 1,'نقد','أجل') as `is_cash`, if(tbl_bills.is_dollar = 1,CONCAT('$ ',getDollar(tbl_bills.datetime)),'IQD') as `is_dollar`, tbl_bills.discount,((select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id) - tbl_bills.discount ) as `total` from tbl_bills,tbl_clients where tbl_bills.`datetime` between '{0}' and '{1}' and tbl_bills.is_account = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.id > 0 order by tbl_bills.is_sell desc;", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59")));
            //DataTable d2 = databaseConnection.query(string.Format("select'رصيد',tbl_balance.bill_id,(select if(tbl_bills.name = tbl_clients.name,tbl_clients.name,CONCAT(tbl_clients.name,':',tbl_clients.name)) from tbl_bills where tbl_bills.id = tbl_balance.bill_id),'نقد',if(tbl_balance.is_dollar = 1,CONCAT('$ ',getDollar(tbl_balance.creation)),'IQD'),0,tbl_balance.value from tbl_balance,tbl_clients where tbl_balance.creation between '{0}' and '{1}' and tbl_clients.id = tbl_balance.client_id", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59")));
            //DataTable d3 = databaseConnection.query(string.Format("select if(tbl_debits.is_pay = 1, 'تسديد','قرض') as `is_pay`, tbl_debits.id,tbl_clients.name, '--', if(tbl_debits.is_dollar = 1,CONCAT('$ ',getDollar(tbl_debits.datetime)),'IQD') as `is_dollar`, 0,tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1)  as `value` from tbl_debits, tbl_clients where tbl_clients.`type` = 3 and tbl_debits.employee_id = tbl_clients.id and tbl_debits.datetime between '{0}' and '{1}'", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59")));
            DataTable d1 = databaseConnection.query(string.Format("select if(tbl_bills.is_sell = 1,'وارد','صادر') as `is_sell`, tbl_bills.id, if(tbl_bills.name = tbl_clients.name,tbl_bills.name,CONCAT(tbl_clients.name,':',tbl_bills.name)) as `name`, if(tbl_bills.is_cash = 1,'نقد','أجل') as `is_cash`, if(tbl_bills.is_dollar = 1,CONCAT('$ ',getDollar(tbl_bills.datetime)),'IQD') as `is_dollar`,  tbl_bills.discount, ifnull(( select (sum(tbl_products.price * tbl_products.count) - tbl_bills.discount) from tbl_products where tbl_products.bill_id = tbl_bills.id ),0) as `total` from tbl_bills, tbl_clients where tbl_bills.id > 0 and tbl_bills.client_id = tbl_clients.id and tbl_bills.datetime between '{0}' and '{1}'  union select 'رصيد', tbl_balance.bill_id, if(tbl_bills.name = tbl_clients.name,tbl_bills.name,CONCAT(tbl_clients.name,':',tbl_bills.name)) as `name`, if(tbl_balance.is_import = 1,'وارد','صادر') as `is_import`, if(tbl_balance.is_dollar = 1,CONCAT('$ ',getDollar(tbl_balance.creation)),'IQD') as `is_dollar`, 0, tbl_balance.value from tbl_balance, tbl_clients, tbl_bills where tbl_balance.client_id = tbl_clients.id and tbl_balance.bill_id = tbl_bills.id and tbl_balance.creation between '{0}' and '{1}' union select if(tbl_debits.is_pay = 1,'تسديد','قرض') as `is_pay`, tbl_debits.id, tbl_clients.name, 'نقد', if(tbl_debits.is_dollar = 1,CONCAT('$ ',getDollar(tbl_debits.datetime)),'IQD') as `is_dollar`, '0', tbl_debits.value from tbl_debits, tbl_clients where tbl_debits.employee_id = tbl_clients.id and tbl_debits.datetime between '{0}' and '{1}'", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59")));


            dgvResults.DataSource = d1;
            dgvResults.Columns[0].HeaderText = "العملية";
            dgvResults.Columns[1].HeaderText = "القائمة";
            dgvResults.Columns[2].HeaderText = "اسم العميل";
            dgvResults.Columns[3].HeaderText = "التعامل";
            dgvResults.Columns[4].HeaderText = "العملة";
            dgvResults.Columns[5].HeaderText = "الخصم";
            dgvResults.Columns[6].HeaderText = "المجموع";
            //for (int i = 0; i < d1.Rows.Count; i++)
            //{
            //    dgvResults.Rows.Add(d1.Rows[i][0].ToString(), d1.Rows[i][1].ToString(), d1.Rows[i][2].ToString(), d1.Rows[i][3].ToString(), d1.Rows[i][4].ToString(), d1.Rows[i][5].ToString(), d1.Rows[i][6].ToString());
            //}
            //if (d2.Rows.Count > 0)
            //{

            //    for (int i = 0; i < d2.Rows.Count; i++)
            //    {
            //        dgvResults.Rows.Add(d2.Rows[i][0].ToString(), d2.Rows[i][1].ToString(), d2.Rows[i][2].ToString(), d2.Rows[i][3].ToString(), d2.Rows[i][4].ToString(), d2.Rows[i][5].ToString(), d2.Rows[i][6].ToString());
            //    }
            //}
            //if (d3.Rows.Count > 0)
            //{

            //    for (int i = 0; i < d3.Rows.Count; i++)
            //    {
            //        dgvResults.Rows.Add(d3.Rows[i][0].ToString(), d3.Rows[i][1].ToString(), d3.Rows[i][2].ToString(), d3.Rows[i][3].ToString(), d3.Rows[i][4].ToString(), d3.Rows[i][5].ToString(), d3.Rows[i][6].ToString());
            //    }
            //}
            dgvResults.Columns[0].Width = 70;
            dgvResults.Columns[1].Width = 90;
            dgvResults.Columns[2].Width = 170;
            dgvResults.Columns[3].Width = 50;
            dgvResults.Columns[4].Width = 50;
            dgvResults.Columns[5].Width = 90;
        }
        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            reset();
            reportForm = Enumerators.ReportForm.ReportGeneral;
            reportName = Enumerators.ReportsName.Daily;
            
            dateFrom.Show();
            dateTo.Show();
        }

        void reportDebitsSell()
        {
            dgvResults.DataSource = databaseConnection.query(string.Format("select tbl_bills.id, tbl_bills.name, DATE_FORMAT(tbl_bills.datetime,'%y-%m-%d') as `datetime`, tbl_bills.phone, (select tbl_clients.name from tbl_clients where tbl_clients.id = tbl_bills.delegate_id) as `delegate_name`, FORMAT((( (ifnull(( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ),0) - tbl_bills.discount) * if(tbl_bills.is_dollar = 0,1,0) - ifnull((select sum(tbl_balance.value) from tbl_balance where tbl_balance.bill_id = tbl_bills.id and tbl_balance.is_dollar = 0),0) )) ,0) as `remaining_dinar`, ( (ifnull(( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ),0) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,1,0) - ifnull((select sum(tbl_balance.value) from tbl_balance where tbl_balance.bill_id = tbl_bills.id and tbl_balance.is_dollar = 1),0) ) as `remaining_dollar`, tbl_bills.note from tbl_bills, tbl_clients where tbl_clients.id = tbl_bills.client_id and tbl_clients.id = 1 and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 and (((select sum(tbl_products.price * tbl_products.count) from tbL_products where tbl_products.bill_id = tbl_bills.id) - tbl_bills.discount) - ifnull((select sum(tbl_balance.value) from tbl_balance where tbl_balance.bill_id = tbl_bills.id),0)) > 0 and tbl_bills.datetime between '{0}' and '{1}'", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59")));

            dgvResults.Columns["id"].HeaderText = "القائمة";
            dgvResults.Columns["name"].HeaderText = "العميل";
            dgvResults.Columns["phone"].HeaderText = "الهاتف";
            dgvResults.Columns["note"].HeaderText = "ملاحظة";
            dgvResults.Columns["datetime"].HeaderText = "التاريخ";
            dgvResults.Columns["delegate_name"].HeaderText = "المندوب";
            dgvResults.Columns["remaining_dinar"].HeaderText = "IQD المتبقي";
            dgvResults.Columns["remaining_dollar"].HeaderText = "$ المتبقي";

        }

        private void btnDebitsSell_Click(object sender, EventArgs e)
        {
            reset();
            reportName = Enumerators.ReportsName.DebitsSell;
            reportForm = Enumerators.ReportForm.ReportGeneral;
            dateFrom.Show();
            dateTo.Show();
        }
        void reportDebitsClients()
        {
            dgvResults.DataSource = databaseConnection.query(string.Format("select tbl_clients.name, tbl_clients.mobile,FORMAT(((ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products, tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0) - (select sum(tbl_bills.discount) from tbl_bills where tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0)),0))  - (ifnull((select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 0),0))),0) as `remaining_dinar`, FORMAT(((ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products, tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1) - (select sum(tbl_bills.discount) from tbl_bills where tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1)),0))  - (ifnull((select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 1),0))),2)  as `remaining_dollar` from tbl_clients where tbl_clients.id > 1 and ( ((ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products, tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1) - (select sum(tbl_bills.discount) from tbl_bills where tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1)),0))  - (ifnull((select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 1),0))) > 0 OR ((ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products, tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0) - (select sum(tbl_bills.discount) from tbl_bills where tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0)),0))  - (ifnull((select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 0),0))) > 0)"));
            dgvResults.Columns["name"].HeaderText = "الاسم";
            dgvResults.Columns["mobile"].HeaderText = "الموبايل";
            dgvResults.Columns["remaining_dinar"].HeaderText = "المتبقي IQD";
            dgvResults.Columns["remaining_dollar"].HeaderText = "المتبقي $";
        }
        private void btnDebitsClients_Click(object sender, EventArgs e)
        {
            reset();
            reportForm = Enumerators.ReportForm.ReportGeneral;
            reportName = Enumerators.ReportsName.DebitsClients;

            dateFrom.Show();
            dateTo.Show();

            
        }
        void reportDelegates()
        {
            dgvResults.DataSource = databaseConnection.query(string.Format("select tbl_clients.name,(FORMAT(((ifnull((select sum(if(tbl_bills.is_cash = 1,if(tbl_bills.is_dollar = 1,tbl_products.price * tbl_products.count * getDollar(tbl_bills.datetime),tbl_products.price * tbl_products.count),(select sum(if(tbl_balance.is_dollar = 1,tbl_balance.value * getDollar(tbl_balance.creation),tbl_balance.value)) from tbl_balance where tbl_balance.bill_id = tbl_bills.id)) )from tbl_bills,tbl_products where tbl_bills.id = tbl_products.bill_id and tbl_bills.delegate_id = tbl_clients.id and tbl_bills.datetime between '{0}' and '{1}' ),0))) ,2)) as `receiving`,(FORMAT((((ifnull((select sum(if(tbl_bills.is_dollar = 1,tbl_products.price * tbl_products.count * getDollar(tbl_bills.datetime),tbl_products.price * tbl_products.count)) - tbl_bills.discount from tbl_bills, tbl_products where tbl_bills.delegate_id = tbl_clients.id and tbl_products.bill_id = tbl_bills.id and tbl_bills.datetime between '{0}' and '{1}'),0))) )-(((ifnull((select sum(if(tbl_bills.is_cash = 1,if(tbl_bills.is_dollar = 1,tbl_products.price * tbl_products.count * getDollar(tbl_bills.datetime),tbl_products.price * tbl_products.count),(select sum(if(tbl_balance.is_dollar = 1,tbl_balance.value * getDollar(tbl_balance.creation),tbl_balance.value)) from tbl_balance where tbl_balance.bill_id = tbl_bills.id)) )from tbl_bills,tbl_products where tbl_bills.id = tbl_products.bill_id and tbl_bills.delegate_id = tbl_clients.id and tbl_bills.datetime between '{0}' and '{1}' ),0))) ),2)) as `remaining`,(FORMAT(((ifnull((select sum(if(tbl_bills.is_dollar = 1,tbl_products.price * tbl_products.count * getDollar(tbl_bills.datetime),tbl_products.price * tbl_products.count)) - tbl_bills.discount from tbl_bills, tbl_products where tbl_bills.delegate_id = tbl_clients.id and tbl_products.bill_id = tbl_bills.id and tbl_bills.datetime between '{0}' and '{1}'),0))) ,2)) as `total`,(FORMAT(((ifnull((select sum(if(tbl_bills.is_cash = 1,if(tbl_bills.is_dollar = 1,tbl_products.price * tbl_products.count * getDollar(tbl_bills.datetime),tbl_products.price * tbl_products.count),(select sum(if(tbl_balance.is_dollar = 1,tbl_balance.value * getDollar(tbl_balance.creation),tbl_balance.value)) from tbl_balance where tbl_balance.bill_id = tbl_bills.id)) ) * (tbl_bills.delegate_percent/100) from tbl_bills,tbl_products where tbl_bills.id = tbl_products.bill_id and tbl_bills.delegate_id = tbl_clients.id and tbl_bills.datetime between '{0}' and '{1}' ),0))) ,2)) as `receiving_percent`,(FORMAT((((ifnull((select (sum(if(tbl_bills.is_dollar = 1,tbl_products.price * tbl_products.count * getDollar(tbl_bills.datetime) ,tbl_products.price * tbl_products.count ) ) - tbl_bills.discount)* (tbl_bills.delegate_percent/100) from tbl_bills, tbl_products where tbl_bills.delegate_id = tbl_clients.id and tbl_products.bill_id = tbl_bills.id and tbl_bills.datetime between '{0}' and '{1}'),0))))-(((ifnull((select sum(if(tbl_bills.is_cash = 1,if(tbl_bills.is_dollar = 1,tbl_products.price * tbl_products.count * getDollar(tbl_bills.datetime),tbl_products.price * tbl_products.count),(select sum(if(tbl_balance.is_dollar = 1,tbl_balance.value * getDollar(tbl_balance.creation),tbl_balance.value)) from tbl_balance where tbl_balance.bill_id = tbl_bills.id)) ) * (tbl_bills.delegate_percent/100) from tbl_bills,tbl_products where tbl_bills.id = tbl_products.bill_id and tbl_bills.delegate_id = tbl_clients.id and tbl_bills.datetime between '{0}' and '{1}' ),0)))),2)) as `remaining_percent`, (FORMAT(((ifnull((select (sum(if(tbl_bills.is_dollar = 1,tbl_products.price * tbl_products.count * getDollar(tbl_bills.datetime) ,tbl_products.price * tbl_products.count ) ) - tbl_bills.discount)* (tbl_bills.delegate_percent/100) from tbl_bills, tbl_products where tbl_bills.delegate_id = tbl_clients.id and tbl_products.bill_id = tbl_bills.id and tbl_bills.datetime between '{0}' and '{1}'),0))),2)	) as `total_percent`, (FORMAT(((ifnull((select sum(if(tbl_balance.is_dollar = 1,tbl_balance.value * getDollar(tbl_balance.creation),tbl_balance.value)) from  tbl_balance where tbl_balance.client_id = tbl_clients.id and  tbl_balance.creation between '{0}' and '{1}'),0))) ,2)) as `balance`  from tbl_clients where tbl_clients.`type` = 2;", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59")));
            dgvResults.Columns["name"].HeaderText = "المندوب";
            dgvResults.Columns["receiving"].HeaderText = "المستلم";
            dgvResults.Columns["remaining"].HeaderText = "المتبقي";
            dgvResults.Columns["total"].HeaderText = "المجموع";
            dgvResults.Columns["receiving_percent"].HeaderText = "نسبة المستلم";
            dgvResults.Columns["remaining_percent"].HeaderText = "نسبة المتبقي";
            dgvResults.Columns["total_percent"].HeaderText = "نسبة المجموع";
            dgvResults.Columns["balance"].HeaderText = "نسبة المجموع";

        }
        private void btnDelegates_Click(object sender, EventArgs e)
        {
            reset();
            reportForm = Enumerators.ReportForm.ReportGeneral;
            reportName = Enumerators.ReportsName.Delegates;
            dateFrom.Show();
            dateTo.Show();
            
        }


        void reportDelegate()
        {
            dgvResults.DataSource = databaseConnection.query(string.Format("select tbl_bills.id,tbl_bills.name,(DATE_FORMAT(tbl_bills.datetime,'%y-%m-%d')) as `datetime`,(if(tbl_bills.is_cash = 1,'نقد','أجل')) as `is_cash`,(if(tbl_bills.is_dollar = 1,CONCAT('$ ',getDollar(tbl_bills.datetime)),'IQD')) as `is_dollar`, (ifnull(( select (sum(tbl_products.count * tbl_products.price) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id ),0)) as `total`, (ifnull((if(tbl_bills.is_cash = 0,(select sum(tbl_balance.value) * if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1) from tbl_balance where tbl_balance.bill_id = tbl_bills.id),(ifnull(( select (sum(tbl_products.count * tbl_products.price) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id),0))) ),0)) as `receiving`, (ifnull((((ifnull((select(sum(tbl_products.count * tbl_products.price) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id),0)) - (ifnull(( select sum(tbl_balance.value) * if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1) from tbl_balance where tbl_balance.bill_id = tbl_bills.id ),0))) * if(tbl_bills.is_cash = 1,0,1) ),0)) as `remaining`, (CAST((ifnull((select (sum(tbl_products.count * tbl_products.price) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) * (tbl_bills.delegate_percent/100)from tbl_products where tbl_products.bill_id = tbl_bills.id ),0)) as DECIMAL(12,2))) as `total_percent`, (CAST((ifnull(( if(tbl_bills.is_cash = 0,(select sum(tbl_balance.value) * if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1) * (tbl_bills.delegate_percent/100) from tbl_balance where tbl_balance.bill_id = tbl_bills.id),( select (sum(tbl_products.count * tbl_products.price) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) * (tbl_bills.delegate_percent/100) from tbl_products where tbl_products.bill_id = tbl_bills.id))),0)) as DECIMAL(12,2))) as `receiving_percent`,(CAST((ifnull((	((ifnull((select(sum(tbl_products.count * tbl_products.price) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1)	from tbl_products where tbl_products.bill_id = tbl_bills.id),0))-(ifnull((select sum(tbl_balance.value) * if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1) from tbl_balance where tbl_balance.bill_id = tbl_bills.id),0))) * if(tbl_bills.is_cash = 1,0,1) * (tbl_bills.delegate_percent/100)),0)) as DECIMAL(12,2))) as `remaining_percent` from tbl_bills, tbl_clients where tbl_bills.id > 0 and tbl_clients.`type` = 2 and tbl_bills.delegate_id = tbl_clients.id and tbl_clients.id = (select id from tbl_clients where tbl_clients.name = '{0}' and tbl_clients.`type` = 2) and  tbl_bills.datetime between'{1}' and '{2}'", cmbClients.Text, dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59")));
            dgvResults.Columns["id"].HeaderText = "رقم القائمة";
            dgvResults.Columns["name"].HeaderText = "اسم العميل";
            dgvResults.Columns["datetime"].HeaderText = "تاريخ";
            dgvResults.Columns["is_cash"].HeaderText = "التعامل";
            dgvResults.Columns["is_dollar"].HeaderText = "العملة";
            dgvResults.Columns["total"].HeaderText = "المجموع";
            dgvResults.Columns["receiving"].HeaderText = "المستلم";
            dgvResults.Columns["remaining"].HeaderText = "المتبقي";
            dgvResults.Columns["total_percent"].HeaderText = "المجموع نسبة";
            dgvResults.Columns["receiving_percent"].HeaderText = "المستلم نسبة";
            dgvResults.Columns["remaining_percent"].HeaderText = "المتبقي نسبة";

        }
        private void btnDelegate_Click(object sender, EventArgs e)
        {
            reset();
            reportName = Enumerators.ReportsName.Delegate;
            reportForm = Enumerators.ReportForm.DelegateReport;
            dateFrom.Show();
            dateTo.Show();
            cmbClients.Show();
            cmbClients.Items.AddRange(getClients(cmbClients,Enumerators.clientType.Delegate));
        }
        void reportClient()
        {
            dgvResults.DataSource = databaseConnection.query(string.Format("select tbl_bills.id,tbl_bills.name,if(tbl_bills.is_cash = 1,'نقد','أجل') as `is_cash`,DATE_FORMAT(tbl_bills.datetime,'%y-%m-%d') as `datetime`,if(tbl_bills.is_dollar = 1,CONCAT('$ ',getDollar(tbl_bills.datetime)),'IQD') as `is_dollar`,(ifnull((select sum(if(tbl_bills.is_dollar = 1,tbl_products.price * tbl_products.count * getDollar(tbl_bills.datetime),tbl_products.price * tbl_products.count)) from tbl_products where tbl_products.bill_id = tbl_bills.id),0) - tbl_bills.discount) as `total`,((ifnull((select sum(if(tbl_bills.is_dollar = 1,tbl_products.price * tbl_products.count * getDollar(tbl_bills.datetime),tbl_products.price * tbl_products.count)) from tbl_products where tbl_products.bill_id = tbl_bills.id),0) - tbl_bills.discount) - (ifnull((select sum(if(tbl_balance.is_dollar = 1,tbl_balance.value * getDollar(tbl_bills.datetime),tbl_balance.value)) from tbl_balance where tbl_balance.bill_id = tbl_bills.id),0))) as `remaining`,(ifnull((select sum(if(tbl_balance.is_dollar = 1,tbl_balance.value * getDollar(tbl_bills.datetime),tbl_balance.value)) from tbl_balance where tbl_balance.bill_id = tbl_bills.id),0)) as `receiving`from tbl_bills where tbl_bills.id > 0 and tbl_bills.client_id = (select id from tbl_clients where tbl_clients.name = '{0}') and tbl_bills.datetime between '{1}' and '{2}';", cmbClients.Text, dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59")));
            dgvResults.Columns["id"].HeaderText = "رقم القائمة";
            dgvResults.Columns["name"].HeaderText = "اسم";
            dgvResults.Columns["datetime"].HeaderText = "تاريخ";
            dgvResults.Columns["is_cash"].HeaderText = "التعامل";
            dgvResults.Columns["is_dollar"].HeaderText = "العملة";
            dgvResults.Columns["total"].HeaderText = "المجموع";
            dgvResults.Columns["receiving"].HeaderText = "المستلم";
            dgvResults.Columns["remaining"].HeaderText = "المتبقي";
        }
        private void btnClient_Click(object sender, EventArgs e)
        {
            reset();
            reportName = Enumerators.ReportsName.Client;
            reportForm = Enumerators.ReportForm.ReportGeneral;
            dateFrom.Show();
            dateTo.Show();
            cmbClients.Show();
            cmbClients.Items.AddRange(getClients(cmbClients,Enumerators.clientType.ClientSupplier));
        }
        object[] getClients(System.Windows.Forms.ComboBox cmb,Enumerators.clientType clientType)
        {
            cmb.Items.Clear();
            List<string> clients = new List<string>();
            System.Data.DataTable dt = databaseConnection.query(string.Format("SELECT name FROM tbl_clients {0};",clientType == Enumerators.clientType.ClientSupplier ? " where type = '0' OR '1'" : $"where type = '{(int)clientType}'"));
            cmb.Items.Add("الكل");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                clients.Add(dt.Rows[i][0].ToString());
            }
            return clients.ToArray();
        }
        void reportEmployeeDebits()
        {
            dgvResults.DataSource = databaseConnection.query(string.Format("select tbl_clients.name,(ifnull((select sum(if(tbl_debits.is_dollar = 1,tbl_debits.value * getDollar(tbl_debits.datetime),tbl_debits.value )) from tbl_debits where tbl_debits.employee_id = tbl_clients.id and tbl_debits.is_pay = 0 and tbl_debits.datetime between '{0}' and '{1}'),0)) as `debits`,(ifnull((select sum(if(tbl_debits.is_dollar = 1,tbl_debits.value * getDollar(tbl_debits.datetime),tbl_debits.value )) from tbl_debits where tbl_debits.employee_id = tbl_clients.id and tbl_debits.is_pay = 1 and tbl_debits.datetime between '{0}' and '{1}'),0)) as `paid`, ((ifnull(( select sum(if(tbl_debits.is_dollar = 1,tbl_debits.value * getDollar(tbl_debits.datetime),tbl_debits.value )) from tbl_debits where tbl_debits.employee_id = tbl_clients.id and tbl_debits.is_pay = 0 and tbl_debits.datetime between '{0}' and '{1}' ),0)) - (ifnull((select sum(if(tbl_debits.is_dollar = 1,tbl_debits.value * getDollar(tbl_debits.datetime),tbl_debits.value )) from tbl_debits where tbl_debits.employee_id = tbl_clients.id and tbl_debits.is_pay = 1 and tbl_debits.datetime between '{0}' and '{1}' ),0))) as `remaining` from tbl_clients where tbl_clients.`type` = 3", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59")));
            dgvResults.Columns["name"].HeaderText = "الموظف";
            dgvResults.Columns["debits"].HeaderText = "المقروض";
            dgvResults.Columns["paid"].HeaderText = "المسدد";
            dgvResults.Columns["remaining"].HeaderText = "المتبقي";
        }
        private void btnEmployeeDebits_Click(object sender, EventArgs e)
        {
            reset();
            reportName = Enumerators.ReportsName.EmployeeDebits;
            reportForm = Enumerators.ReportForm.ReportGeneral;
            dateFrom.Show();
            dateTo.Show();
            
        }
       void reportEmployee()
        {
            dgvResults.DataSource = databaseConnection.query(string.Format("select date_format(tbl_debits.datetime,'%Y-%m-%d') as `datetime`,if(tbl_debits.is_pay = 1,'تسديد','قرض') as `is_pay`,if(tbl_debits.is_dollar = 1,CONCAT('$ ',getDollar(tbl_bills.datetime)),'IQD') as `is_dollar`,if(tbl_debits.is_dollar = 1,tbl_debits.value * getDollar(tbl_debits.datetime),tbl_debits.value) as `value` from tbl_debits, tbl_clients where tbl_debits.employee_id = tbl_clients.id and tbl_clients.name = '{0}' and tbl_debits.datetime between '{1}' and '{2}'", cmbClients.Text, dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59")));
            dgvResults.Columns["datetime"].HeaderText = "التاريخ";
            dgvResults.Columns["is_pay"].HeaderText = "التعامل";
            dgvResults.Columns["is_dollar"].HeaderText = "العملة";
            dgvResults.Columns["value"].HeaderText = "القيمة";
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            reset();
            reportForm = Enumerators.ReportForm.EmpReport;
            reportName = Enumerators.ReportsName.Employee;
            dateFrom.Show();
            dateTo.Show();
            cmbClients.Show();
            cmbClients.Items.AddRange(getClients(cmbClients,Enumerators.clientType.Employer));
        }

        private void btnCaseValue_Click(object sender, EventArgs e)
        {
            reset();
            reportName = Enumerators.ReportsName.CaseValue;
            reportForm = Enumerators.ReportForm.caseValue;
            dateFrom.Show();
            dateTo.Show();
        }
        void reportCaseValue()
        {
            dgvResults.DataSource = databaseConnection.query(string.Format("call getCaseValue('{0}','{1}')", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59")));
            HCashier.Report.caseValue r = new HCashier.Report.caseValue(databaseConnection, dgvResults, "الصندوق" + "", true, true, dateFrom.Value, dateTo.Value, Properties.Settings.Default.dollarValue, "");
            new DevExpress.XtraReports.UI.ReportPrintTool(r).ShowRibbonPreview();
            reset();
        }
        void reportBill()
        {
            dgvResults.DataSource = databaseConnection.query(string.Format("select tbl_bills.name,tbl_products.bill_id,date_format(tbl_bills.datetime,'%Y-%m-%d') as `datetime`,tbl_products.description,if(tbl_bills.is_dollar = 1,CONCAT('$ ',getDollar(tbl_bills.datetime)),'IQD') as `is_dollar`,(tbl_products.count * tbl_products.price) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) as `total` from tbl_products,tbl_bills,tbl_clients where tbl_products.bill_id = tbl_bills.id and tbl_bills.client_id = tbl_clients.id and tbl_bills.datetime between '{0}' and '{1}' and tbl_bills.is_account = 1 {2}", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59"), (int)grpImport.EditValue == 2 ? "" : " and tbl_bills.is_sell = '" + (int)grpImport.EditValue + "' "));
            dgvResults.Columns["name"].HeaderText = "العميل";
            dgvResults.Columns["bill_id"].HeaderText = "القائمة";
            dgvResults.Columns["description"].HeaderText = "المادة";
            dgvResults.Columns["is_dollar"].HeaderText = "العملة";
            dgvResults.Columns["total"].HeaderText = "القيمة";
            dgvResults.Columns["datetime"].HeaderText = "تاريخ";
            dgvResults.Columns["receiving"].HeaderText = "المستلم";
            dgvResults.Columns["remaining"].HeaderText = "المتبقي";
        }
        
        void reportDate()
        {
            dgvResults.DataSource = databaseConnection.query(string.Format("select selected_date,ifnull((( select sum(( select (sum(tbl_products.price * tbL_products.count) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id )) from  tbl_bills where  tbl_bills.datetime = selected_date and tbl_bills.is_cash = 1 and tbl_bills.is_sell = 1 and tbl_bills.is_account = 1 ) ),0) as `cash`, ifnull(( ( select sum(tbl_balance.value * if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1)) from tbl_balance where tbl_balance.creation = selected_date ) ),0) as `balance`, ifnull(( ( select sum(tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1)) from tbl_debits where tbl_debits.datetime = selected_date and tbl_debits.is_pay = 1 ) ),0) as `pay`, ifnull(( ( select sum(tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1)) from tbl_debits where tbl_debits.datetime = selected_date and tbl_debits.is_pay = 0 ) ),0) as `debit`, ifnull(( ( select sum(( select (sum(tbl_products.price * tbL_products.count) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id )) from  tbl_bills where  tbl_bills.datetime = selected_date and tbl_bills.is_sell = 0 and tbl_bills.is_account = 1 ) ),0) as `export`, ifnull(( ( select sum(( select (sum(tbl_products.price * tbL_products.count) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id )) 	from  tbl_bills 	where  tbl_bills.datetime = selected_date and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 and tbl_bills.is_account = 1 ) ),0) as `not_cash`, ifnull(( (ifnull((( select sum(( select 	(sum(tbl_products.price * tbL_products.count) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id)) from  tbl_bills where  tbl_bills.datetime = selected_date and tbl_bills.is_cash = 1 and tbl_bills.is_sell = 1 and tbl_bills.is_account = 1)),0)) +(ifnull((( select sum(tbl_balance.value * if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1)) from tbl_balance where tbl_balance.creation = selected_date ) ),0)) + (ifnull(( ( select sum(tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1)) from tbl_debits where tbl_debits.datetime = selected_date and tbl_debits.is_pay = 1 )),0)) - (ifnull(( ( select sum(tbl_debits.value * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1)) from tbl_debits where tbl_debits.datetime = selected_date and tbl_debits.is_pay = 0)),0)) - (ifnull(( ( select  sum(( select (sum(tbl_products.price * tbL_products.count) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id )) from  tbl_bills where  tbl_bills.datetime = selected_date and tbl_bills.is_sell = 0 and tbl_bills.is_account = 1)),0)) ),0) as `remaining`,ifnull(( (ifnull(( (select sum(( select (sum(tbl_products.price * tbL_products.count) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id ))from  tbl_bills where  tbl_bills.datetime = selected_date and tbl_bills.is_cash = 1 and tbl_bills.is_sell = 1 and tbl_bills.is_account = 1)),0)) +(ifnull(((select sum(tbl_balance.value * if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1)) from tbl_balance where tbl_balance.creation = selected_date )),0)) -  (ifnull(( (select sum((select (sum(tbl_products.price * tbL_products.count) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) from tbl_products where tbl_products.bill_id = tbl_bills.id )) from  tbl_bills where  tbl_bills.datetime = selected_date and tbl_bills.is_sell = 0 and tbl_bills.is_account = 1 ) ),0)) ),0) as `total` from (select adddate('1970-01-01',t4.i*10000 + t3.i*1000 + t2.i*100 + t1.i*10 + t0.i) selected_date from (select 0 i union select 1 union select 2 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9) t0,(select 0 i union select 1 union select 2 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9) t1,(select 0 i union select 1 union select 2 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9) t2,(select 0 i union select 1 union select 2 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9) t3, (select 0 i union select 1 union select 2 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9) t4) as v where selected_date between '{0}' and '{1}'", dateFrom.Value.AddDays(-1).ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59")));
            dgvResults.Columns["selected_date"].HeaderText = "التاريخ";
            dgvResults.Columns["cash"].HeaderText = "نقد";
            dgvResults.Columns["balance"].HeaderText = "رصيد";
            dgvResults.Columns["pay"].HeaderText = "تسديد";
            dgvResults.Columns["debit"].HeaderText = "قرض";
            dgvResults.Columns["export"].HeaderText = "صادر";
            dgvResults.Columns["not_cash"].HeaderText = "أجل";
            dgvResults.Columns["remaining"].HeaderText = "متبقي";
            dgvResults.Columns["total"].HeaderText = "محصلة";
        }
        private void btnDate_Click(object sender, EventArgs e)
        {
            reset();
            reportName = Enumerators.ReportsName.ReportDate;
            reportForm = Enumerators.ReportForm.ReportGeneral;
            dateFrom.Show();
            dateTo.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            switch (reportForm)
            {
                case Enumerators.ReportForm.ReportGeneral:
                    new DevExpress.XtraReports.UI.ReportPrintTool(new HCashier.Report.ReportGeneral(databaseConnection, dgvResults, "الوارد اليومي", true, true, dateFrom.Value, dateTo.Value, Properties.Settings.Default.dollarValue,reportName,(int)grpImport.EditValue,(int)grpCash.EditValue,cmbClients.Text)).ShowRibbonPreview();
                    break;
                case Enumerators.ReportForm.BillWithReport:
                    new DevExpress.XtraReports.UI.ReportPrintTool(new HCashier.Report.billsWithProducts(databaseConnection, dgvResults, "قوائم:" + ((int)grpImport.EditValue == 2 ? "الكل" : "صادر"), true, true, dateFrom.Value, dateTo.Value, Properties.Settings.Default.dollarValue, "")).ShowRibbonPreview();
                    break;
                case Enumerators.ReportForm.EmpReport:
                    new DevExpress.XtraReports.UI.ReportPrintTool(new HCashier.Report.EmpReport(databaseConnection, dgvResults, "الموظف:" + cmbClients.Text, true, true, dateFrom.Value, dateTo.Value, Properties.Settings.Default.dollarValue, cmbClients.Text)).ShowRibbonPreview();
                    break;
                case Enumerators.ReportForm.DelegateReport:
                    new DevExpress.XtraReports.UI.ReportPrintTool(new HCashier.Report.DelegateReport(databaseConnection, dgvResults, "المندوب:" + cmbClients.Text, true, true, dateFrom.Value, dateTo.Value, Properties.Settings.Default.dollarValue, cmbClients.Text)).ShowRibbonPreview();
                    break;
                default:
                    break;
            }
            reset();
        }
        void reset()
        {

            dateFrom.Hide();
            dateTo.Hide();
            grpImport.Hide();
            grpCash.Hide();
            cmbClients.Hide();
            cmbDelegates.Hide();
            grpCurrency.Hide();
            grpPayMethod.Hide();

            cmbDelegates.Items.Clear();
            cmbClients.Items.Clear();
            dgvResults.Columns.Clear();
            txtCash.Text = txtBalance.Text = txtDebit.Text = txtExport.Text = txtNotCash.Text = txtPay.Text = txtRemaining.Text = txtTotal.Text = "0";
            cash = 0;
            debet = 0;
            balanceImport = 0;
            balanceExport = 0;
            export = 0;
            payDebit = 0;
            debit = 0;
            grpImport.SelectedIndex = 2;
            grpCash.SelectedIndex = 2;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (reportName)
            {
                case Enumerators.ReportsName.none:
                    break;
                case Enumerators.ReportsName.Daily:
                    reportDaily();
                    break;
                case Enumerators.ReportsName.BillsProducts:
                    new DevExpress.XtraReports.UI.ReportPrintTool(new HCashier.Report.ReportSequance(databaseConnection, "القوائم", dateFrom.Value, dateTo.Value, Properties.Settings.Default.dollarValue, (int)grpCash.EditValue, (int)grpCurrency.EditValue, (int)grpImport.EditValue,cmbClients.Text)).ShowRibbonPreview();
                    reset();
                    break;
                case Enumerators.ReportsName.BillReport:
                    reportBill();
                    break;
                case Enumerators.ReportsName.DebitsClients:
                    reportDebitsClients();
                    break;
                case Enumerators.ReportsName.CaseValue:
                    reportCaseValue();
                    break;
                case Enumerators.ReportsName.DebitsSell:
                    reportDebitsSell();
                    break;
                case Enumerators.ReportsName.EmployeeDebits:
                    reportEmployeeDebits();
                    break;
                case Enumerators.ReportsName.Delegates:
                    reportDelegates();
                    break;
                case Enumerators.ReportsName.ReportDate:
                    reportDate();
                    break;
                case Enumerators.ReportsName.Bills:
                    billsReport();
                    break;
                case Enumerators.ReportsName.Products:
                    productsReport();
                    break;
                case Enumerators.ReportsName.Client:
                    reportClient();
                    break;
                case Enumerators.ReportsName.ClientPay:
                    reportClientPay();
                    break;
                default:
                    break;
            }
            if (reportName == Enumerators.ReportsName.Daily)
            {
                cash = double.Parse(databaseConnection.query(string.Format("select ifnull(sum(((select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,getDollar(tbl_bills.datetime),1) ),0)  as `cash` from tbl_bills where tbl_bills.is_cash = 1 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.datetime between '{0}' and '{1}';", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59"))).Rows[0][0].ToString());
            }
            if (reportName == Enumerators.ReportsName.Daily)
            {
                debet = double.Parse(databaseConnection.query(string.Format("select ifnull(sum(tbl_products.count * tbl_products.price * if(tbl_bills.is_dollar = 1,  getDollar(tbl_bills.datetime),1)),0) - (select ifnull(sum(tbl_bills.discount),0) from tbl_bills where tbl_bills.`datetime` between '{0}' and '{1}' and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1) from  tbl_products,tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.`datetime` between '{0}' and '{1}' and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1;", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59"))).Rows[0][0].ToString());
            }

            if (reportName == Enumerators.ReportsName.Daily)
            {
                payDebit = double.Parse(databaseConnection.query(string.Format("select ifnull(sum(if(tbl_debits.is_dollar = 1, tbl_debits.value * getDollar(tbl_debits.datetime) , tbl_debits.value)),0) from tbl_debits where  tbl_debits.is_pay = 1 and tbl_debits.datetime between '{0}' and '{1}';", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59"))).Rows[0][0].ToString());
            }
            if (reportName == Enumerators.ReportsName.Daily)
            {
                debit = double.Parse(databaseConnection.query(string.Format("select ifnull(sum(if(tbl_debits.is_dollar = 1, tbl_debits.value * getDollar(tbl_debits.datetime) , tbl_debits.value)),0) from tbl_debits where  tbl_debits.is_pay = 0 and  tbl_debits.employee_id = (select id from tbl_clients where tbl_clients.name = '{2}' and `type` = 3) and tbl_debits.datetime between '{0}' and '{1}';", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59"), reportName)).Rows[0][0].ToString());
            }

            if (reportName == Enumerators.ReportsName.Daily)
            {
                export = double.Parse(databaseConnection.query(string.Format("select ifnull(sum(tbl_products.count * tbl_products.price * if(tbl_bills.is_dollar = 1,  getDollar(tbl_bills.datetime),1)),0) - ifnull(if(tbl_bills.is_dollar = 1,tbl_bills.discount * 1300,tbl_bills.discount),0) from tbl_products,tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.`datetime` between '{0}' and '{1}' and tbl_bills.is_sell = 0;", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59"))).Rows[0][0].ToString());
            }
            if (reportName == Enumerators.ReportsName.Daily)
            {
                balanceImport = double.Parse(databaseConnection.query(string.Format("select ifnull(sum(if(tbl_balance.is_dollar = 1, getDollar(tbl_balance.creation),1) * tbl_balance.value),0) from tbl_balance where tbl_balance.creation between '{1}' and '{2}' and is_import = 1;", "", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59"))).Rows[0][0].ToString());
            }

            txtTotal.Text = (cash + balanceImport - balanceExport - export).ToString("#,###");
            txtRemaining.Text = (cash + balanceImport - balanceExport - export - debit + payDebit).ToString("#,###");
            txtCash.Text = cash.ToString("#,###");
            txtExport.Text = export.ToString("#,###");
            txtPay.Text = payDebit.ToString("#,###");
            txtNotCash.Text = debet.ToString("#,###");
            txtBalance.Text = balanceImport.ToString("#,###");
            txtDebit.Text = debit.ToString("#,###");

        }
        private void btnBillReport_Click(object sender, EventArgs e)
        {
            reset();
            reportName = Enumerators.ReportsName.BillsProducts;
            reportForm = Enumerators.ReportForm.ReportSequance;
            dateFrom.Show();
            dateTo.Show();
            grpCash.Show();
            grpImport.Show();
            grpCurrency.Show();
            cmbClients.Show();
            cmbClients.Items.AddRange(getClients(cmbClients,Enumerators.clientType.ClientSupplier));
        }
        void billsReport()
        {
            dgvResults.DataSource = databaseConnection.query(string.Format("select if(tbl_clients.name = tbl_bills.name,tbl_bills.name,CONCAT(tbl_clients.name,' - ',tbl_bills.name)) as `name` , tbl_bills.id, (DATE_FORMAT(tbl_bills.datetime,'%Y-%m-%d')) as `datetime`,  if(tbl_bills.is_dollar = 1,concat('$ ',getDollar(tbl_bills.datetime)),'IQD') as `is_dollar`, ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id) - tbl_bills.discount),0) as `total`,ifnull(if(tbl_bills.is_cash = 1,ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id) - tbl_bills.discount),0),(select sum(tbl_balance.value)  from tbl_balance where tbl_balance.bill_id = tbl_bills.id)),0) as `receiving`,ifnull(if(tbl_bills.is_cash = 1,0,ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id) - tbl_bills.discount),0)-ifnull(((select sum(tbl_balance.value) from tbl_balance where tbl_balance.bill_id = tbl_bills.id)),0)),0) as `remaining`, tbl_bills.note from tbl_clients, tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.id > 0 and tbl_bills.is_account = 1 {2} {3} and tbl_bills.datetime between '{0}' and '{1}' {4} {5} {6}", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59"), (int)grpImport.EditValue == 2 ? "" : " and tbl_bills.is_sell = '" + (int)grpImport.EditValue + "' ", (int)grpCash.EditValue == 1 ? " and ifnull(if (tbl_bills.is_cash = 1,0,ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id) - tbl_bills.discount),0)-ifnull(((select sum(tbl_balance.value) from tbl_balance where tbl_balance.bill_id = tbl_bills.id)),0)),0) = 0"  : (int)grpCash.EditValue == 0 ? " and tbl_bills.is_cash = 0 and ifnull(if (tbl_bills.is_cash = 1,0,ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id) - tbl_bills.discount),0)-ifnull(((select sum(tbl_balance.value) from tbl_balance where tbl_balance.bill_id = tbl_bills.id)),0)),0) > 0" : "", cmbClients.Text == "الكل" ? "" : "and tbl_clients.name = '" + cmbClients.Text + "'", (int)grpCurrency.EditValue == 2 ? "" : " and tbl_bills.is_dollar = '" + (int)grpCurrency.EditValue + "' ", cmbDelegates.Text == "الكل" ? "" : " and tbl_bills.delegate_id = (select id from tbl_clients where tbl_clients.type = '2' and tbl_clients.name = '" + cmbDelegates.Text + "' ) "));
            dgvResults.Columns["name"].HeaderText = "العميل";
            dgvResults.Columns["id"].HeaderText = "قائمة";
            dgvResults.Columns["datetime"].HeaderText = "التاريخ";
            dgvResults.Columns["note"].HeaderText = "ملاحظة";
            dgvResults.Columns["is_dollar"].HeaderText = "العملة";
            dgvResults.Columns["total"].HeaderText = "المجموع";
            dgvResults.Columns["receiving"].HeaderText = "المستلم";
            dgvResults.Columns["remaining"].HeaderText = "المتبقي";

            dgvResults.Columns["id"].Width = 50;
            dgvResults.Columns["name"].Width = 150;
            dgvResults.Columns["datetime"].Width = 70;
            dgvResults.Columns["is_dollar"].Width = 50;
            dgvResults.Columns["total"].Width = 70;
            dgvResults.Columns["receiving"].Width = 70;
            dgvResults.Columns["remaining"].Width = 70;
            //dgvResults.Columns["note"].Width = 1;

        }
        private void btnBills_Click(object sender, EventArgs e)
        {
            reset();

            reportName = Enumerators.ReportsName.Bills;
            reportForm = Enumerators.ReportForm.ReportGeneral;

            dateFrom.Show();
            dateTo.Show();
            grpImport.Show();
            grpCash.Show();
            grpCurrency.Show();
            cmbClients.Show();
            cmbDelegates.Show();
            cmbDelegates.Items.AddRange(getClients(cmbDelegates,Enumerators.clientType.Delegate));
            cmbDelegates.Text = cmbDelegates.Items[0].ToString();
            cmbClients.Items.AddRange(getClients(cmbClients,Enumerators.clientType.ClientSupplier));
            cmbClients.Text = cmbClients.Items[0].ToString();
            
        }
        void productsReport()
        {
            dgvResults.DataSource = databaseConnection.query(string.Format("select tbl_clients.name, tbl_bills.id, DATE_FORMAT(tbl_bills.datetime,'%Y-%m-%d') `datetime`, tbl_products.description, FORMAT(tbl_products.price,0) as `price`, FORMAT(tbl_products.count,0) as `count`,FORMAT(((tbl_products.price * tbl_products.count) * if(tbl_bills.is_dollar = 1,0,1)),0) `total_dinar`, ((tbl_products.price * tbl_products.count) * if(tbl_bills.is_dollar = 1,1,0)) `total_dollar`, tbl_products.note from tbl_bills, tbl_products, tbl_clients where tbl_bills.client_id = tbl_clients.id and tbl_bills.id = tbl_products.bill_id {2} {3} and tbl_bills.is_account = 1 and tbl_bills.datetime between '{0}' and '{1}' {4} group by tbl_products.id order by tbl_bills.id", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59"), (int)grpImport.EditValue == 2 ? "" : " and tbl_bills.is_sell = '"+(int)grpImport.EditValue+"' ", (int)grpCash.EditValue == 2 ? "" : " and tbl_bills.is_cash = '"+(int)grpCash.EditValue+"' ", cmbClients.Text == "الكل" ? "" : " and tbl_clients.name = '" + cmbClients.Text + "' "));
            dgvResults.Columns["name"].HeaderText = "العميل";
            dgvResults.Columns["id"].HeaderText = "قائمة";
            dgvResults.Columns["note"].HeaderText = "ملاحظة";
            dgvResults.Columns["datetime"].HeaderText = "التاريخ";
            dgvResults.Columns["total_dinar"].HeaderText = "دينار";
            dgvResults.Columns["price"].HeaderText = "سعر";
            dgvResults.Columns["count"].HeaderText = "عدد";
            dgvResults.Columns["description"].HeaderText = "المادة";
            dgvResults.Columns["total_dollar"].HeaderText = "دولار";
        }
        private void btnProducts_Click(object sender, EventArgs e)
        {
            reset();
            reportName = Enumerators.ReportsName.Products;
            reportForm = Enumerators.ReportForm.ReportGeneral;
            dateFrom.Show();
            dateTo.Show();
            grpImport.Show();
            grpCash.Show();
            cmbClients.Show();
            cmbClients.Items.AddRange(getClients(cmbClients,Enumerators.clientType.ClientSupplier));
            cmbClients.Text = cmbClients.Items[0].ToString();
        }
        void reportClientPay()
        {
            dgvResults.DataSource = databaseConnection.query(string.Format("select tbl_balance.id,tbl_clients.name,tbl_balance.bill_id,DATE_FORMAT(tbl_balance.creation,'%Y-%m-%d') as `creation`,if(tbl_balance.is_dollar = 1,CONCAT('$ ',getDollar(tbl_balance.creation)),'IQD') as `is_dollar`,sum(tbl_balance.value) as `value`,tbl_balance.note from tbl_balance,tbl_clients where tbl_clients.id = tbl_balance.client_id and tbl_clients.type = 0 {0} and tbl_balance.creation between '{1}' and '{2}' group by tbl_balance.{3} order by type asc", cmbClients.Text == "الكل" ? "" : " and tbl_clients.name = '"+cmbClients.Text+"' ", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59"),(int)grpPayMethod.EditValue == 1 ? "id" : "balance_pay_id"));
            dgvResults.Columns["id"].Visible = false;
            dgvResults.Columns["bill_id"].HeaderText = "القائمة";
            dgvResults.Columns["bill_id"].Visible = (int)grpPayMethod.EditValue == 1 ;
            dgvResults.Columns["name"].HeaderText = "العميل";
            dgvResults.Columns["is_dollar"].HeaderText = "العملة";
            dgvResults.Columns["value"].HeaderText = "القيمة";
            dgvResults.Columns["creation"].HeaderText = "التاريخ";
            dgvResults.Columns["note"].HeaderText = "ملاحظة";
        }
        private void btnClientPay_Click(object sender, EventArgs e)
        {
            reportName = Enumerators.ReportsName.ClientPay;
            reportForm = Enumerators.ReportForm.ReportGeneral;
            dateFrom.Show();
            dateTo.Show();
            grpPayMethod.Show();
            cmbClients.Show();
            cmbClients.Items.AddRange(getClients(cmbClients,Enumerators.clientType.ClientSupplier));
        }

        private void grpImport_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbClients.Items.AddRange(getClients(cmbClients, grpImport.SelectedIndex == 2 ? Enumerators.clientType.ClientSupplier : grpImport.SelectedIndex == 1 ? Enumerators.clientType.Client : Enumerators.clientType.Supplier));
        }
    }
}
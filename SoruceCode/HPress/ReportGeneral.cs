using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using HPress;
namespace HCashier.Report
{
    public partial class ReportGeneral : DevExpress.XtraReports.UI.XtraReport
    {
        bool isDinar = true;
        HDatabaseConnection.HMySQLConnection databaseConnection;
        double dollarValue = 1300;

        double exportDinar = 0;
        double exportDollar = 0;
        
        double cashDinar = 0;
        double cashDollar = 0;

        double notCashDinar = 0;
        double notCashDollar = 0;

        double balanceImportDinar = 0;
        double balanceImportDollar = 0;

        double payDebitDinar = 0;
        double payDebitDollar = 0;

        double debitDinar = 0;
        double debitDollar = 0;


        double balanceExport = 0;
        
        string sum = "";
        XRTable t;
        Enumerators.ReportsName reportName;
        System.Windows.Forms.DataGridView result;
        DateTime from, to;
        int isImportReport;
        int isCashReport;
        string clientNameReport;
        public ReportGeneral(HDatabaseConnection.HMySQLConnection databaseConnection, System.Windows.Forms.DataGridView result,string reportTitle,bool isDinar,bool isCash,DateTime from,DateTime to,double dollarValue, Enumerators.ReportsName reportName,int isImportReport = 2,int isCashReport = 2,string clientNameReport = "الكل")
        {
            InitializeComponent();
            this.isImportReport = isImportReport;
            this.isCashReport = isCashReport;
            this.clientNameReport = clientNameReport;
            this.from = from;
            this.to = to;
            this.reportName = reportName;
            this.databaseConnection = databaseConnection;
            this.result = result;
            for (int i = 0; i < result.Columns.Count; i++)
            {
                if (result.Columns[i].Visible == false)
                {
                    result.Columns.RemoveAt(i);
                }
            }
            
            this.lblReportName.Text = reportTitle;
            this.isDinar = isDinar;
            //lblIsDinar.Text = isDinar ? "IQD" : "$";
            lblDollar.Text = isCash ? "نقد" : "أجل";
            lblDatetimeFrom.Text = from.ToString("yyyy-MM-dd");
            lblDatetimeTo.Text = to.ToString("yyyy-MM-dd");
            this.dollarValue = dollarValue;
            lblDollar.Text = dollarValue.ToString();
            switch (reportName)
            {
                case Enumerators.ReportsName.none:
                    break;
                case Enumerators.ReportsName.Daily:
                    
                case Enumerators.ReportsName.ReportDate:
                    this.Landscape = true;
                    break;
                case Enumerators.ReportsName.BillsProducts:
                    break;
                case Enumerators.ReportsName.BillReport:
                    break;
                case Enumerators.ReportsName.DebitsClients:
                    lblReportName.Text = "ديون العملاء";
                    break;
                case Enumerators.ReportsName.CaseValue:
                    break;
                case Enumerators.ReportsName.DebitsSell:
                    lblReportName.Text = "ديون البيع النقدي";
                    this.Landscape = true;
                    break;
                case Enumerators.ReportsName.EmployeeDebits:
                    break;
                case Enumerators.ReportsName.Client:
                    break;
                case Enumerators.ReportsName.Employee:
                    break;
                case Enumerators.ReportsName.Delegates:
                    Landscape = true;
                    break;
                case Enumerators.ReportsName.Delegate:
                    break;
                
                case Enumerators.ReportsName.Bills:
                    System.Data.DataTable dt = databaseConnection.query(string.Format("select ifnull(sum(if(tbl_debits.is_pay = 0,tbl_debits.value,0) * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1)),0) as `debit`, ifnull(sum(if(tbl_debits.is_pay = 1,tbl_debits.value,0)* if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1)),0) as `pay`  from tbl_debits, tbl_clients where tbl_debits.employee_id = tbl_clients.id and tbl_clients.`type` = 3 and tbl_debits.datetime between '{1}' and '{2}';", reportTitle == "الكل" ? "" : " and tbl_clients.name = '" + reportName + "' ", from.ToString("yyyy-MM-dd 00:00:00"), to.ToString("yyyy-MM-dd 23:59:59")));
                    double sumDebit = double.Parse(dt.Rows[0][0].ToString());
                    double sumPaid = double.Parse(dt.Rows[0][1].ToString());
                    //payDebit = sumDebit;
                    //debit = sumPaid;
                    lblReportName.Text = "ديون : " + reportName;
                    this.Landscape = true;
                    break;
                case Enumerators.ReportsName.Products:
                    this.Landscape = true;

                    break;
                default:
                    break;
            }
            t = table(result);
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
                    for (int i = 0; i < t.Rows.Count; i++)
                    {
                        //t.Rows[i].Cells["note"].WidthF += 170;
                        //t.Rows[i].Cells["id"].WidthF = 70;
                        //t.Rows[i].Cells["remaining_dollar"].WidthF = 100;
                        //t.Rows[i].Cells["remaining_dinar"].WidthF = 100;
                        t.Rows[i].Cells["remaining_dinar"].TextAlignment = t.Rows[i].Cells["remaining_dollar"].TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
                        //t.Rows[i].Cells["delegate_name"].WidthF = 100;
                        //t.Rows[i].Cells["phone"].WidthF = 100;
                        //t.Rows[i].Cells["datetime"].WidthF = 80;
                        //t.Rows[i].Cells["name"].WidthF = 130;
                        t.Rows[i].Cells["id"].Borders =
                            t.Rows[i].Cells["note"].Borders =
                            t.Rows[i].Cells["remaining_dollar"].Borders =
                            t.Rows[i].Cells["remaining_dinar"].Borders =
                            t.Rows[i].Cells["delegate_name"].Borders =
                            t.Rows[i].Cells["phone"].Borders =
                            t.Rows[i].Cells["datetime"].Borders =
                            t.Rows[i].Cells["name"].Borders = DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom;

                    }
                    break;
                case Enumerators.ReportsName.EmployeeDebits:
                    break;
                case Enumerators.ReportsName.Client:
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
                    for (int i = 0; i < t.Rows.Count; i++)
                    {
                        t.Rows[i].Cells["note"].WidthF = 350;
                        t.Rows[i].Cells["remaining"].WidthF = 150;
                        t.Rows[i].Cells["receiving"].WidthF = 150;
                        t.Rows[i].Cells["total"].WidthF = 150;
                        t.Rows[i].Cells["is_dollar"].WidthF = 70;
                        t.Rows[i].Cells["datetime"].WidthF = 100;
                        t.Rows[i].Cells["id"].WidthF = 70;
                        t.Rows[i].Cells["name"].WidthF = 150;
                    }
                    break;
                case Enumerators.ReportsName.Products:
                    for (int i = 0; i < t.Rows.Count; i++)
                    {
                        t.Rows[i].Cells["note"].WidthF = 150;
                        t.Rows[i].Cells["total_dollar"].WidthF = 100;
                        t.Rows[i].Cells["total_dinar"].WidthF = 100;
                        t.Rows[i].Cells["count"].WidthF = 60;
                        t.Rows[i].Cells["price"].WidthF = 100;
                        t.Rows[i].Cells["description"].WidthF = 300;
                        t.Rows[i].Cells["datetime"].WidthF = 100;
                        t.Rows[i].Cells["id"].WidthF = 70;
                        t.Rows[i].Cells["name"].WidthF = 100;
                        t.Rows[i].Cells["total_dinar"].TextAlignment = t.Rows[i].Cells["total_dollar"].TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                        t.Rows[i].Cells["total_dinar"].ForeColor = Color.FromArgb(112, 150, 112);
                        t.Rows[i].Cells["total_dollar"].ForeColor = Color.FromArgb(140, 102, 102);
                        t.Rows[i].Cells["total_dinar"].Font = t.Rows[i].Cells["total_dollar"].Font = new Font("Calibri", 13, FontStyle.Bold);
                    }
                    break;
                case Enumerators.ReportsName.ClientPay:
                    break;
                default:
                    break;
            }

            this.Detail.Controls.Add(t);
            summaryReport();
        }
        void summaryReport()
        {
            XRTable summary = new XRTable();
            summary.BeginInit();
            
            summary.SizeF = new SizeF(this.PageSize.Width - this.Margins.Left * 2, 30);
            summary.LocationF = new PointF(0, t.HeightF + 30);
            summary.Font = new Font("Calibri", 14);
            summary.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            List<string> data = new List<string>();
            data.Add("");
            data.Add("IQD");
            data.Add("$");
            data.Add("");
            data.Add("IQD");
            data.Add("$");
            if (
                reportName == Enumerators.ReportsName.Daily ||
                reportName == Enumerators.ReportsName.ReportDate
                )
            {
                System.Data.DataTable dt = databaseConnection.query(string.Format("select ifnull(sum(tbl_products.count * tbl_products.price * if(tbl_bills.is_dollar = 1, 0,1)),0) - ifnull(tbl_bills.discount * if(tbl_bills.is_dollar = 1,0,1),0) as `dinar`, ifnull(sum(tbl_products.count * tbl_products.price * if(tbl_bills.is_dollar = 0, 0,1)),0) - ifnull(tbl_bills.discount * if(tbl_bills.is_dollar = 0,0,1),0) as `dollar` from tbl_products,tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.`datetime` between '{0}' and '{1}' and tbl_bills.is_sell = 0 and tbl_bills.is_cash = 1;", from.ToString("yyyy-MM-dd 00:00:00"), to.ToString("yyyy-MM-dd 23:59:59")));
                data.Add("صادر نقد");
                exportDinar = double.Parse(dt.Rows[0]["dinar"].ToString());
                exportDollar = double.Parse(dt.Rows[0]["dollar"].ToString());
                data.Add(exportDinar.ToString("#,###"));
                data.Add(exportDollar.ToString("#.##"));
                
            }
            
            if (
                reportName == Enumerators.ReportsName.Daily ||
                reportName == Enumerators.ReportsName.ReportDate
                )
            {
                System.Data.DataTable dt = databaseConnection.query(string.Format("select ifnull(sum(((select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,0,1) ),0) as `dinar`, ifnull(sum(((select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id) - tbl_bills.discount) * if(tbl_bills.is_dollar = 0,0,1) ),0) as `dollar` from tbl_bills where tbl_bills.is_cash = 1 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.datetime between '{0}' and '{1}';", from.ToString("yyyy-MM-dd 00:00:00"), to.ToString("yyyy-MM-dd 23:59:59")));
                data.Add("وارد نقد");
                cashDinar = double.Parse(dt.Rows[0]["dinar"].ToString());
                cashDollar = double.Parse(dt.Rows[0]["dollar"].ToString());
                data.Add(cashDinar.ToString("#,###"));
                data.Add(cashDollar.ToString("#.##"));

            }
            if (
                reportName == Enumerators.ReportsName.Daily ||
                reportName == Enumerators.ReportsName.ReportDate
                )
            {
                System.Data.DataTable dt = databaseConnection.query(string.Format("select ifnull(sum(tbl_products.count * tbl_products.price * if(tbl_bills.is_dollar = 1,  0,1)),0) - ifnull(tbl_bills.discount * if(tbl_bills.is_dollar = 1, 0,1),0) as `dinar`,ifnull(sum(tbl_products.count * tbl_products.price * if(tbl_bills.is_dollar = 0,  0,1)),0) - ifnull(tbl_bills.discount * if(tbl_bills.is_dollar = 0, 0,1),0) as `dollar` from tbl_products,tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.`datetime` between '{0}' and '{1}' and tbl_bills.is_sell = 0 and tbl_bills.is_cash = 0;", from.ToString("yyyy-MM-dd 00:00:00"), to.ToString("yyyy-MM-dd 23:59:59")));
                data.Add("صادر أجل");
                data.Add(dt.Rows[0]["dinar"].ToString());
                data.Add(dt.Rows[0]["dollar"].ToString());

            }
            if (
                reportName == Enumerators.ReportsName.Daily ||
                reportName == Enumerators.ReportsName.ReportDate
                )
            {
                System.Data.DataTable dt = databaseConnection.query(string.Format("select  ifnull((sum(( select ifnull(sum(tbl_products.price * tbl_products.count ),0)* if(tbl_bills.is_dollar = 1,0,1) from tbl_products where tbl_products.bill_id = tbl_bills.id ))- sum(tbl_bills.discount * if(tbl_bills.is_dollar = 1,0,1))),0) as `dinar`, ifnull((sum(( select ifnull(sum(tbl_products.price * tbl_products.count ),0)* if(tbl_bills.is_dollar = 0,0,1) from tbl_products where tbl_products.bill_id = tbl_bills.id ))- sum(tbl_bills.discount * if(tbl_bills.is_dollar = 0,0,1))),0) as `dollar` from tbl_bills where tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 and tbl_bills.datetime between '{0}' and '{1}';", from.ToString("yyyy-MM-dd 00:00:00"), to.ToString("yyyy-MM-dd 23:59:59")));
                data.Add("وارد أجل");
                notCashDinar = double.Parse(dt.Rows[0]["dinar"].ToString());
                notCashDollar = double.Parse(dt.Rows[0]["dollar"].ToString());
                data.Add(notCashDinar.ToString("#,###"));
                data.Add(notCashDollar.ToString("#.##"));

            }
            if (
                reportName == Enumerators.ReportsName.Daily ||
                reportName == Enumerators.ReportsName.ReportDate
                )
            {
                System.Data.DataTable dt = databaseConnection.query(string.Format("select ifnull(sum(if(tbl_balance.is_dollar = 1, 0,1) * tbl_balance.value),0) as `dinar`,ifnull(sum(if(tbl_balance.is_dollar = 0, 0,1) * tbl_balance.value),0) as `dollar` from tbl_balance where tbl_balance.creation between '{0}' and '{1}' and is_import = 1;", from.ToString("yyyy-MM-dd 00:00:00"), to.ToString("yyyy-MM-dd 23:59:59")));
                data.Add("رصيد");
                balanceImportDinar = double.Parse(dt.Rows[0]["dinar"].ToString());
                balanceImportDollar = double.Parse(dt.Rows[0]["dollar"].ToString());
                data.Add(balanceImportDinar.ToString("#,###"));
                data.Add(balanceImportDollar.ToString("#.##"));
            }
            if (
                reportName == Enumerators.ReportsName.Daily ||
                reportName == Enumerators.ReportsName.ReportDate
                )
            {
                data.Add(" ");
                data.Add("");
                data.Add("");
            }
            if (reportName == Enumerators.ReportsName.Daily ||
                reportName == Enumerators.ReportsName.ReportDate
                )
            {
                System.Data.DataTable dt = databaseConnection.query(string.Format("select ifnull(sum(tbl_debits.value * if(tbl_debits.is_dollar = 1, 0,1)),0) as `dinar`,ifnull(sum(tbl_debits.value * if(tbl_debits.is_dollar = 0, 0,1)),0) as `dollar` from tbl_debits where  tbl_debits.is_pay = 1 and tbl_debits.datetime between '{0}' and '{1}';", from.ToString("yyyy-MM-dd 00:00:00"), to.ToString("yyyy-MM-dd 23:59:59")));
                data.Add("تسديد");
                payDebitDinar = double.Parse(dt.Rows[0]["dinar"].ToString());
                payDebitDollar = double.Parse(dt.Rows[0]["dollar"].ToString());
                data.Add(payDebitDinar.ToString("#,###"));
                data.Add(payDebitDollar.ToString("#.##"));

            }
            if (
                reportName == Enumerators.ReportsName.Daily ||
                reportName == Enumerators.ReportsName.ReportDate
                )
            {
                System.Data.DataTable dt = databaseConnection.query(string.Format("select ifnull(sum(tbl_debits.value * if(tbl_debits.is_dollar = 1, 0, 1)),0) as `dinar`,ifnull(sum(tbl_debits.value * if(tbl_debits.is_dollar = 0, 0 , 1)),0) as `dollar` from tbl_debits where  tbl_debits.is_pay = 0 and tbl_debits.datetime between '{0}' and '{1}';", from.ToString("yyyy-MM-dd 00:00:00"), to.ToString("yyyy-MM-dd 23:59:59")));

                data.Add("قرض");
                debitDinar = double.Parse(dt.Rows[0]["dinar"].ToString());
                debitDollar = double.Parse(dt.Rows[0]["dollar"].ToString());
                data.Add(debitDinar.ToString("#,###"));
                data.Add(debitDollar.ToString("#.##"));

            }
            if (
                reportName == Enumerators.ReportsName.Daily ||
                reportName == Enumerators.ReportsName.ReportDate
                )
            {
                //balanceImport = double.Parse(databaseConnection.query(string.Format("select ifnull(sum(if(tbl_balance.is_dollar = 1, getDollar(tbl_balance.creation),1) * tbl_balance.value),0) from tbl_balance where tbl_balance.creation between '{1}' and '{2}' and is_import = 1;", dollarValue, from.ToString("yyyy-MM-dd 00:00:00"), to.ToString("yyyy-MM-dd 23:59:59"))).Rows[0][0].ToString());
                //balanceExport = double.Parse(databaseConnection.query(string.Format("select ifnull(sum(if(tbl_balance.is_dollar = 1, getDollar(tbl_balance.creation),1) * tbl_balance.value),0) from tbl_balance where tbl_balance.creation between '{1}' and '{2}' and is_import = 0;", dollarValue, from.ToString("yyyy-MM-dd 00:00:00"), to.ToString("yyyy-MM-dd 23:59:59"))).Rows[0][0].ToString());

                data.Add("المتبقي");
                data.Add((cashDinar + balanceImportDinar - balanceExport - exportDinar - debitDinar + payDebitDinar).ToString("#,###"));
                data.Add(((cashDollar + balanceImportDollar - balanceExport - exportDollar - debitDollar + payDebitDollar) ).ToString("#.##"));

            }
            if (
                reportName == Enumerators.ReportsName.Daily ||
                reportName == Enumerators.ReportsName.ReportDate
                )
            {
                //balanceImport = double.Parse(databaseConnection.query(string.Format("select ifnull(sum(if(tbl_balance.is_dollar = 1, getDollar(tbl_balance.creation),1) * tbl_balance.value),0) from tbl_balance where tbl_balance.creation between '{1}' and '{2}' and is_import = 1;", dollarValue, from.ToString("yyyy-MM-dd 00:00:00"), to.ToString("yyyy-MM-dd 23:59:59"))).Rows[0][0].ToString());
                //balanceExport = double.Parse(databaseConnection.query(string.Format("select ifnull(sum(if(tbl_balance.is_dollar = 1, getDollar(tbl_balance.creation),1) * tbl_balance.value),0) from tbl_balance where tbl_balance.creation between '{1}' and '{2}' and is_import = 0;", dollarValue, from.ToString("yyyy-MM-dd 00:00:00"), to.ToString("yyyy-MM-dd 23:59:59"))).Rows[0][0].ToString());
                data.Add("المحصلة");
                data.Add((cashDinar + balanceImportDinar - balanceExport - exportDinar).ToString("#,###"));
                data.Add(((cashDollar + balanceImportDollar - balanceExport - exportDollar)).ToString("#.##"));


            }
            if (
                reportName == Enumerators.ReportsName.DebitsClients
                )
            {
                System.Data.DataTable dt = databaseConnection.query("select tbl_clients.name, tbl_clients.mobile,sum(((ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products, tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0) - (select sum(tbl_bills.discount) from tbl_bills where tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0)),0))  - (ifnull((select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 0),0)))) as `remaining_dinar`, sum(((ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products, tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1) - (select sum(tbl_bills.discount) from tbl_bills where tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1)),0))  - (ifnull((select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 1),0)))) as `remaining_dollar` from tbl_clients where tbl_clients.id > 1 and ( ((ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products, tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1) - (select sum(tbl_bills.discount) from tbl_bills where tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 1)),0))  - (ifnull((select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 1),0))) > 0 OR ((ifnull(((select sum(tbl_products.price * tbl_products.count) from tbl_products, tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0) - (select sum(tbl_bills.discount) from tbl_bills where tbl_bills.is_cash = 0 and tbl_bills.is_account = 1 and tbl_bills.is_sell = 1 and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_dollar = 0)),0))  - (ifnull((select sum(tbl_balance.value) from tbl_balance where tbl_balance.client_id = tbl_clients.id and tbl_balance.is_dollar = 0),0))) > 0)");
                double remainingDinar = double.Parse(dt.Rows[0][2].ToString());
                double remainingDollar = double.Parse(dt.Rows[0][3].ToString());
                data.Add("المتبقي");
                data.Add(remainingDinar.ToString("#,###"));
                data.Add(remainingDollar.ToString("#.##"));
                data.Add("");
                data.Add((cashDinar + balanceImportDinar - balanceExport - exportDinar).ToString("#,###"));
                data.Add(((cashDollar + balanceImportDollar - balanceExport - exportDollar) ).ToString("#.##"));
            }
            if (
                reportName == Enumerators.ReportsName.DebitsSell
                )
            {
                System.Data.DataTable dt = databaseConnection.query(string.Format("select tbl_bills.id, tbl_bills.name, DATE_FORMAT(tbl_bills.datetime,'%y-%m-%d') as `datetime`, tbl_bills.phone, (select tbl_clients.name from tbl_clients where tbl_clients.id = tbl_bills.delegate_id) as `delegate_name`,sum(((ifnull(( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ),0) - tbl_bills.discount) * if(tbl_bills.is_dollar = 1,1,0))) as `remaining_dollar`, sum(((ifnull(( select sum(tbl_products.price * tbl_products.count) from tbl_products where tbl_products.bill_id = tbl_bills.id ),0) - tbl_bills.discount) * if(tbl_bills.is_dollar = 0,1,0))) as `remaining_dinar`, tbl_bills.note from tbl_bills, tbl_clients where tbl_clients.id = tbl_bills.client_id and tbl_clients.id = 1 and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1 and tbl_bills.datetime between '{0}' and '{1}' and (((select sum(tbl_products.price * tbl_products.count) from tbL_products where tbl_products.bill_id = tbl_bills.id) - tbl_bills.discount) - ifnull((select sum(tbl_balance.value) from tbl_balance where tbl_balance.bill_id = tbl_bills.id),0)) > 0",from.ToString("yyyy-MM-dd 00:00:00"),to.ToString("yyyy-MM-dd 23:59:59")));
                double remainingDinar = double.Parse(dt.Rows[0][6].ToString());
                double remainingDollar = double.Parse(dt.Rows[0][5].ToString());
                data.Add("المتبقي");
                data.Add(remainingDinar.ToString("#,###"));
                data.Add(remainingDollar.ToString("#.##"));
                data.Add("");
                data.Add((cashDinar + balanceImportDinar - balanceExport - exportDinar).ToString("#,###"));
                data.Add(((cashDollar + balanceImportDollar - balanceExport - exportDollar) / dollarValue).ToString("#.##"));
            }
            if (
                reportName == Enumerators.ReportsName.Bills
                )
            {
                double totalDinar = 0;
                double receivingDinar = 0;
                double remainingDinar = 0;

                double totalDollar = 0;
                double receivingDollar = 0;
                double remainingDollar = 0;
                for (int i = 0; i < result.Rows.Count; i++)
                {
                    if (result.Rows[i].Cells["is_dollar"].Value.ToString().Contains("$"))
                    {
                        totalDollar += double.Parse(result.Rows[i].Cells["total"].Value.ToString().Replace(",", ""));
                        receivingDollar += double.Parse(result.Rows[i].Cells["receiving"].Value.ToString().Replace(",", ""));
                        remainingDollar += double.Parse(result.Rows[i].Cells["remaining"].Value.ToString().Replace(",", ""));

                    }
                    else
                    {
                        totalDinar += double.Parse(result.Rows[i].Cells["total"].Value.ToString().Replace(",", ""));
                        receivingDinar += double.Parse(result.Rows[i].Cells["receiving"].Value.ToString().Replace(",", ""));
                        remainingDinar += double.Parse(result.Rows[i].Cells["remaining"].Value.ToString().Replace(",", ""));

                    }

                }
                data.Add("المجموع");
                data.Add((totalDinar).ToString("#,###"));
                data.Add((totalDollar).ToString("#.##"));
                data.Add("المستلم");
                data.Add((receivingDinar).ToString("#,###"));
                data.Add((receivingDollar).ToString("#.##"));
                data.Add(" ");
                data.Add(" ");
                data.Add(" ");


                data.Add("المتبقي");
                data.Add((totalDinar - receivingDinar).ToString("#,###"));
                data.Add((totalDollar - receivingDollar).ToString("#.##"));

                

            }
            if (reportName == Enumerators.ReportsName.Products)
            {
                System.Data.DataTable total = databaseConnection.query(string.Format("select FORMAT(getCashFromTo('{0}','{1}',1,1,0) + getBalanceFromTo('{0}','{1}',1,0,0),0),FORMAT(getCashFromTo('{0}','{1}',1,1,1) + getBalanceFromTo('{0}','{1}',1,0,1),2);",from.ToString("yyyy-MM-dd 23:59:59"),to.ToString("yyyy-MM-dd 23:59:59")));

                data.Add("المجموع النهائي");
                data.Add(total.Rows[0][0].ToString());
                data.Add(total.Rows[0][1].ToString());

                data.Add(" ");
                data.Add(" ");
                data.Add(" ");

            }
            if (reportName == Enumerators.ReportsName.Client)
            {
                double total = 0;
                double received = 0;
                double remaining = 0;
                for (int i = 0; i < result.Rows.Count; i++)
                {
                    total += double.Parse(result.Rows[i].Cells["total"].Value.ToString().Replace(",", ""));
                    received += double.Parse(result.Rows[i].Cells["receiving"].Value.ToString().Replace(",", ""));
                    remaining += double.Parse(result.Rows[i].Cells["remaining"].Value.ToString().Replace(",", ""));
                }
                data.Add("مجموع المستلم");
                data.Add((received).ToString("#,###"));
                data.Add("مجموع المتبقي");
                data.Add((remaining).ToString("#,###"));
                data.Add("$ المجموع");
                data.Add((total / dollarValue).ToString("#,###"));
                data.Add("IQD المجموع");
                data.Add((total).ToString("#,###"));
                
            }
            if (reportName == Enumerators.ReportsName.ClientPay)
            {
                double total = 0;
                for (int i = 0; i < result.Rows.Count; i++)
                {
                    total += double.Parse(result.Rows[i].Cells["value"].Value.ToString().Replace(",", "")) * (result.Rows[i].Cells["is_dollar"].Value.ToString() == "$" ? dollarValue : 1);
                }
                data.Add("$ المجموع");
                data.Add((total / dollarValue).ToString("#,###"));
                data.Add("IQD المجموع");
                data.Add((total).ToString("#,###"));
            }
            for (int i = 0; i < data.Count; i += 6)
            {
                //
                XRTableRow one = new XRTableRow();

                XRTableCell balanceTitle = new XRTableCell();
                XRTableCell balanceDinar = new XRTableCell();
                XRTableCell balanceDollar = new XRTableCell();

                XRTableCell exportTitle = new XRTableCell();
                XRTableCell exportDinar = new XRTableCell();
                XRTableCell exportDollar = new XRTableCell();

                exportTitle.WidthF = balanceTitle.WidthF = 40;
                exportTitle.BackColor = balanceTitle.BackColor = Color.Gray;
                if (i == 0)
                {
                    balanceDinar.BackColor = exportDinar.BackColor = Color.FromArgb(192, 255, 192);
                    exportDollar.BackColor = balanceDollar.BackColor = Color.FromArgb(255, 192, 192);
                }else
                {
                    balanceDinar.BackColor = exportDinar.BackColor = Color.White;
                    exportDollar.BackColor = balanceDollar.BackColor = Color.White;
                }
                balanceDollar.Borders = exportDollar.Borders = exportDinar.Borders = balanceDinar.Borders = exportTitle.Borders = balanceTitle.Borders = DevExpress.XtraPrinting.BorderSide.All;
                balanceDollar.BorderWidth = exportDollar.BorderWidth = exportDinar.BorderWidth = exportDinar.BorderWidth = balanceDinar.BorderWidth = exportTitle.BorderWidth = balanceTitle.BorderWidth = 1;
                balanceDollar.BorderColor = exportDollar.BorderColor = exportDinar.BorderColor = balanceDinar.BorderColor = exportTitle.BorderColor = balanceTitle.BorderColor = Color.Black;

                balanceTitle.Text = data[i];
                balanceDinar.Text = data[i + 1];
                balanceDollar.Text = data[i + 2];
                exportTitle.Text = data[i + 3];
                exportDinar.Text = data[i + 4];
                exportDollar.Text = data[i + 5];


                one.Cells.Add(balanceDollar);
                one.Cells.Add(balanceDinar);
                one.Cells.Add(balanceTitle);
                one.Cells.Add(exportDollar);
                one.Cells.Add(exportDinar);
                one.Cells.Add(exportTitle);
                
                summary.Rows.Add(one);
            }
            if (data.Count % 6 == 3)
            {
                XRTableRow row = summary.Rows[summary.Rows.Count - 1];
                row.Cells[1].LocationF = new PointF(summary.Rows[0].Cells[0].LocationF.X, summary.Rows[0].Cells[0].LocationF.Y+ summary.Rows[0].Cells[0].SizeF.Height);
                row.Cells[0].LocationF = new PointF(row.Cells[1].LocationF.X + row.Cells[1].SizeF.Width, row.Cells[1].LocationF.Y);
                
            }
            summary.EndInit();
            this.Detail.Controls.Add(summary);
        }
        XRTable table(System.Windows.Forms.DataGridView result)
        {
            XRTable report = new XRTable();
            report.BeginInit();
            report.SizeF = new SizeF(this.PageSize.Width - this.Margins.Left * 2, 30);
            XRTableRow header = new XRTableRow();
            int index = 0;
            for (int i = result.Columns.Count-1; i >= 0 ; i--)
            {
                header.Cells.Add(new XRTableCell());
                header.Cells[index].TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

                header.Cells[index].Text = result.Columns[i].HeaderText;
                header.Cells[index].Font = new Font("Calibri", 16);
                header.Cells[index].BackColor = Color.FromArgb(204, 204, 204);
                header.Cells[index].Name = result.Columns[i].Name;
                index++;
            }
            report.Rows.Add(header);
            XRTableRow row;
           // double sum = 0;
            for (int i = 0; i < result.Rows.Count; i++)
            {
                row = new XRTableRow();
                index = 0;
                if (i % 2 == 0)
                    row.BackColor = Color.FromArgb(255, 255, 255);
                else
                    row.BackColor = Color.FromArgb(233, 233, 233);
                for (int j = result.Columns.Count - 1; j >= 0; j--)
                {
                    row.Cells.Add(new XRTableCell());
                    row.Cells[index].TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    row.Cells[index].Font = new Font("Calibri", 12);
                    row.Cells[index].Text = result.Rows[i].Cells[j].Value.ToString();
                    row.Cells[index].Name = result.Columns[j].Name;
                    row.Cells[index].Font = new Font("Calibri", 12);
                    row.Cells[index].Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
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
                            break;
                        case Enumerators.ReportsName.Employee:
                            break;
                        case Enumerators.ReportsName.Delegates:
                            row.Cells[index].TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
                            break;
                        default:
                            break;
                    }
                    if (result.Rows[i].Cells[j].Value.ToString().Contains("$"))
                    {
                        for (int k = 0; k < row.Cells.Count; k++)
                        {
                            row.Cells[k].Font = new Font("Calibri", 12, FontStyle.Bold);
                            
                        }
                    }
                    index++;
                }
                report.Rows.Add(row);
            }
            report.EndInit();
            return report;
        }
    }
}

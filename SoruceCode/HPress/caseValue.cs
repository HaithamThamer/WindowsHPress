using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace HCashier.Report
{
    public partial class caseValue : DevExpress.XtraReports.UI.XtraReport
    {
        bool isDinar = true;
        HDatabaseConnection.HMySQLConnection databaseConnection;

        public caseValue(HDatabaseConnection.HMySQLConnection databaseConnection, System.Windows.Forms.DataGridView result,string reportName,bool isDinar,bool isCash,DateTime from,DateTime to,double dollarValue,string delegateName)
        {
            InitializeComponent();
            this.databaseConnection = databaseConnection;
            this.lblReportName.Text = reportName;
            this.isDinar = isDinar;
            lblIsDinar.Text = isDinar ? "IQD" : "$";
            lblDollar.Text = isCash ? "نقد" : "أجل";
            lblDatetimeFrom.Text = from.ToString("yyyy-MM-dd");
            lblDatetimeTo.Text = to.ToString("yyyy-MM-dd");
            lblDollar.Text = dollarValue.ToString();

            lblCashSellDinar.Text = double.Parse(result.Rows[0].Cells["getCashSellDinar"].Value.ToString()).ToString("#,###");
            lblCashSellDollar.Text = (double.Parse(result.Rows[0].Cells["getCashSellDollar"].Value.ToString())  ).ToString("#.##");
            lblCashSellDinarDate.Text = double.Parse(result.Rows[0].Cells["getCashSell"].Value.ToString()).ToString("#,###");
            lblCashSellDollarDate.Text = (double.Parse(result.Rows[0].Cells["getCashSell"].Value.ToString()) / dollarValue).ToString("#.##");

            lblDebitSellDinar.Text = double.Parse(result.Rows[0].Cells["getDebitSellDinar"].Value.ToString()).ToString("#,###");
            lblDebitSellDollar.Text = (double.Parse(result.Rows[0].Cells["getDebitSellDollar"].Value.ToString())  ).ToString("#.##");
            lblDebitSellDinarDate.Text = double.Parse(result.Rows[0].Cells["getDebitSell"].Value.ToString()).ToString("#,###");
            lblDebitSellDollarDate.Text = (double.Parse(result.Rows[0].Cells["getDebitSell"].Value.ToString()) / dollarValue).ToString("#.##");

            lblDebitSellDateDinar.Text = double.Parse(result.Rows[0].Cells["getDebitSellDateDinar"].Value.ToString()).ToString("#,###");
            lblDebitSellDateDollar.Text = (double.Parse(result.Rows[0].Cells["getDebitSellDateDollar"].Value.ToString())  ).ToString("#.##");
            lblDebitSellDateDinarDate.Text = double.Parse(result.Rows[0].Cells["getDebitSellDate"].Value.ToString()).ToString("#,###");
            lblDebitSellDateDollarDate.Text = (double.Parse(result.Rows[0].Cells["getDebitSellDate"].Value.ToString()) / dollarValue).ToString("#.##");

            lblCashNotSellDinar.Text = double.Parse(result.Rows[0].Cells["getCashNotSellDinar"].Value.ToString()).ToString("#,###");
            lblCashNotSellDollar.Text = (double.Parse(result.Rows[0].Cells["getCashNotSellDollar"].Value.ToString())  ).ToString("#.##");
            lblCashNotSellDinarDate.Text = double.Parse(result.Rows[0].Cells["getCashNotSell"].Value.ToString()).ToString("#,###");
            lblCashNotSellDollarDate.Text = (double.Parse(result.Rows[0].Cells["getCashNotSell"].Value.ToString()) / dollarValue).ToString("#.##");

            lblExportNotCashDinar.Text = double.Parse(result.Rows[0].Cells["getCashNotSellNotCashDinar"].Value.ToString()).ToString("#,###");
            lblExportNotCashDollar.Text = (double.Parse(result.Rows[0].Cells["getCashNotSellNotCashDollar"].Value.ToString())  ).ToString("#.##");
            lblExportNotCashDinarDate.Text = double.Parse(result.Rows[0].Cells["getCashNotSellNotCash"].Value.ToString()).ToString("#,###");
            lblExportNotCashDollarDate.Text = (double.Parse(result.Rows[0].Cells["getCashNotSellNotCash"].Value.ToString()) / dollarValue).ToString("#.##");

            lblExportNotCashDateDinar.Text = double.Parse(result.Rows[0].Cells["getCashNotSellNotCashDateDinar"].Value.ToString()).ToString("#,###");
            lblExportNotCashDateDollar.Text = (double.Parse(result.Rows[0].Cells["getCashNotSellNotCashDateDollar"].Value.ToString())  ).ToString("#.##");
            lblExportNotCashDateDinarDate.Text = double.Parse(result.Rows[0].Cells["getCashNotSellNotCashDate"].Value.ToString()).ToString("#,###");
            lblExportNotCashDateDollarDate.Text = (double.Parse(result.Rows[0].Cells["getCashNotSellNotCashDate"].Value.ToString()) / dollarValue).ToString("#.##");

            lblDelegatesReceivingDinar.Text = double.Parse(result.Rows[0].Cells["getDelegatesReceivingDinar"].Value.ToString()).ToString("#,###");
            lblDelegatesReceivingDollar.Text = (double.Parse(result.Rows[0].Cells["getDelegatesReceivingDollar"].Value.ToString())  ).ToString("#.##");
            lblDelegatesReceivingDinarDate.Text = double.Parse(result.Rows[0].Cells["getDelegatesReceiving"].Value.ToString()).ToString("#,###");
            lblDelegatesReceivingDollarDate.Text = (double.Parse(result.Rows[0].Cells["getDelegatesReceiving"].Value.ToString()) / dollarValue).ToString("#.##");

            lblDelegatesRemainingDinar.Text = double.Parse(result.Rows[0].Cells["getDelegatesRemainingDinar"].Value.ToString()).ToString("#,###");
            lblDelegatesRemainingDollar.Text = (double.Parse(result.Rows[0].Cells["getDelegatesRemainingDollar"].Value.ToString())  ).ToString("#.##");
            lblDelegatesRemainingDinarDate.Text = double.Parse(result.Rows[0].Cells["getDelegatesRemaining"].Value.ToString()).ToString("#,###");
            lblDelegatesRemainingDollarDate.Text = (double.Parse(result.Rows[0].Cells["getDelegatesRemaining"].Value.ToString()) / dollarValue).ToString("#.##");

            lblBalanceDelegateDateDinar.Text = double.Parse(result.Rows[0].Cells["getBalanceDelegateDateDinar"].Value.ToString()).ToString("#,###");
            lblBalanceDelegateDateDollar.Text = (double.Parse(result.Rows[0].Cells["getBalanceDelegateDateDollar"].Value.ToString())  ).ToString("#.##");
            lblBalanceDelegateDateDinarDate.Text = double.Parse(result.Rows[0].Cells["getBalanceDelegateDate"].Value.ToString()).ToString("#,###");
            lblBalanceDelegateDateDollarDate.Text = (double.Parse(result.Rows[0].Cells["getBalanceDelegateDate"].Value.ToString()) / dollarValue).ToString("#.##");

            //lblBalanceDelegateDinar.Text = double.Parse(result.Rows[0].Cells["getBalanceDelegateDinar"].Value.ToString()).ToString("#,###");
            //lblBalanceDelegateDollar.Text = (double.Parse(result.Rows[0].Cells["getBalanceDelegateDollar"].Value.ToString())).ToString("#.##");
            //lblBalanceDelegateDinarDate.Text = double.Parse(result.Rows[0].Cells["getBalanceDelegate"].Value.ToString()).ToString("#,###");
            //lblBalanceDelegateDollarDate.Text = (double.Parse(result.Rows[0].Cells["getBalanceDelegate"].Value.ToString()) / dollarValue).ToString("#.##");

            lblBalanceExportDinar.Text = double.Parse(result.Rows[0].Cells["getBalanceExportSalaryDinar"].Value.ToString()).ToString("#,###");
            lblBalanceExportDollar.Text = (double.Parse(result.Rows[0].Cells["getBalanceExportSalaryDollar"].Value.ToString())  ).ToString("#.##");
            lblBalanceExportDinarDate.Text = double.Parse(result.Rows[0].Cells["getBalanceExportSalary"].Value.ToString()).ToString("#,###");
            lblBalanceExportDollarDate.Text = (double.Parse(result.Rows[0].Cells["getBalanceExportSalary"].Value.ToString()) / dollarValue).ToString("#.##");

            lblDebitsTotalDinar.Text = double.Parse(result.Rows[0].Cells["getDebitsTotalDinar"].Value.ToString()).ToString("#,###");
            lblDebitsTotalDollar.Text = (double.Parse(result.Rows[0].Cells["getDebitsTotalDollar"].Value.ToString())  ).ToString("#.##");
            lblDebitsTotalDinarDate.Text = double.Parse(result.Rows[0].Cells["getDebitsTotal"].Value.ToString()).ToString("#,###");
            lblDebitsTotalDollarDate.Text = (double.Parse(result.Rows[0].Cells["getDebitsTotal"].Value.ToString()) / dollarValue).ToString("#.##");

            lblDebitsTotalDateDinar.Text = double.Parse(result.Rows[0].Cells["getDebitsTotalDateDinar"].Value.ToString()).ToString("#,###");
            lblDebitsTotalDateDollar.Text = (double.Parse(result.Rows[0].Cells["getDebitsTotalDateDollar"].Value.ToString())  ).ToString("#.##");
            lblDebitsTotalDateDinarDate.Text = double.Parse(result.Rows[0].Cells["getDebitsTotalDate"].Value.ToString()).ToString("#,###");
            lblDebitsTotalDateDollarDate.Text = (double.Parse(result.Rows[0].Cells["getDebitsTotalDate"].Value.ToString()) / dollarValue).ToString("#.##");

            lblEarningsDinar.Text = double.Parse(result.Rows[0].Cells["earningsDinar"].Value.ToString()).ToString("#,###");
            lblEarningsDollar.Text = (double.Parse(result.Rows[0].Cells["earningsDollar"].Value.ToString())  ).ToString("#.##");
            lblEarningsDinarDate.Text = double.Parse(result.Rows[0].Cells["earnings"].Value.ToString()).ToString("#,###");
            lblEarningsDollarDate.Text = (double.Parse(result.Rows[0].Cells["earnings"].Value.ToString()) / dollarValue).ToString("#.##");

            lblEarningsDateDinar.Text = double.Parse(result.Rows[0].Cells["earningsDateDinar"].Value.ToString()).ToString("#,###");
            lblEarningsDateDollar.Text = (double.Parse(result.Rows[0].Cells["earningsDateDollar"].Value.ToString())).ToString("#.##");
            lblEarningsDateDinarDate.Text = double.Parse(result.Rows[0].Cells["earningsDate"].Value.ToString()).ToString("#,###");
            lblEarningsDateDollarDate.Text = (double.Parse(result.Rows[0].Cells["earningsDate"].Value.ToString()) / dollarValue).ToString("#.##");

            lblcaseValueDinar.Text = double.Parse(result.Rows[0].Cells["caseValueDinar"].Value.ToString()).ToString("#,###");
            lblcaseValueDollar.Text = (double.Parse(result.Rows[0].Cells["caseValueDollar"].Value.ToString())  ).ToString("#.##");
            lblcaseValueDinarDate.Text = double.Parse(result.Rows[0].Cells["caseValue"].Value.ToString()).ToString("#,###");
            lblcaseValueDollarDate.Text = (double.Parse(result.Rows[0].Cells["caseValue"].Value.ToString()) / dollarValue).ToString("#.##");

        }
    }
}

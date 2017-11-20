using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace HCashier.Report
{
    public partial class DelegateReport : DevExpress.XtraReports.UI.XtraReport
    {
        bool isDinar = true;
        HDatabaseConnection.HMySQLConnection databaseConnection;
        double receiving = 0;
        double remaining = 0;
        double total = 0;
        double receivingPercent = 0;
        double remainingPercent = 0;
        double totalPercent = 0;
        public DelegateReport(HDatabaseConnection.HMySQLConnection databaseConnection, System.Windows.Forms.DataGridView result,string reportName,bool isDinar,bool isCash,DateTime from,DateTime to,double dollarValue,string delegateName)
        {
            InitializeComponent();
            this.databaseConnection = databaseConnection;
            this.Detail.Controls.Add(table(result));
            this.lblReportName.Text = reportName;
            this.isDinar = isDinar;
            lblIsDinar.Text = isDinar ? "IQD" : "$";
            lblDollar.Text = isCash ? "نقد" : "أجل";
            lblDatetimeFrom.Text = from.ToString("yyyy-MM-dd");
            lblDatetimeTo.Text = to.ToString("yyyy-MM-dd");
            lblDollar.Text = dollarValue.ToString();

            lblReceiving.Text = receiving.ToString("#,###");
            lblRemaining.Text = remaining.ToString("#,###");
            lblTotal.Text = total.ToString("#,###");

            lblReceivingPercent.Text = receivingPercent.ToString("#,###");
            lblRemainingPercent.Text = remainingPercent.ToString("#,###");
            lblTotalPercent.Text = totalPercent.ToString("#,###");

            lblReceivableReceiving.Text = databaseConnection.query(string.Format("select ifnull(sum(if(tbl_balance.is_dollar = 1,tbl_balance.value * getDollar(tbl_balance.creation),tbl_balance.value)),0) as `receiving` from tbl_balance, tbl_clients where tbl_balance.is_import = 0 and tbl_clients.`type` = 2 and tbl_balance.client_id = tbl_clients.id and tbl_clients.name = '{0}' and tbl_balance.creation between '{1}' and '{2}'",delegateName,from.ToString("yyyy-MM-dd 00:00:00"),to.ToString("yyyy-MM-dd 23:59:59"))).Rows[0][0].ToString();
            lblReceivableRemaining.Text = (receivingPercent - double.Parse(lblReceivableReceiving.Text)).ToString("#,###");

            lblReceivableReceiving.Text = double.Parse(lblReceivableReceiving.Text).ToString("#,###");
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
                index++;
            }
            report.Rows.Add(header);
            XRTableRow row;
            
            for (int i = 0; i < result.Rows.Count; i++)
            {
                row = new XRTableRow();
                index = 0;

                total += double.Parse(result.Rows[i].Cells["total"].Value.ToString());
                receiving += double.Parse(result.Rows[i].Cells["receiving"].Value.ToString());
                remaining += double.Parse(result.Rows[i].Cells["remaining"].Value.ToString());

                totalPercent += double.Parse(result.Rows[i].Cells["total_percent"].Value.ToString());
                receivingPercent += double.Parse(result.Rows[i].Cells["receiving_percent"].Value.ToString());
                remainingPercent += double.Parse(result.Rows[i].Cells["remaining_percent"].Value.ToString());


                if (i % 2 == 0)
                    row.BackColor = Color.FromArgb(255, 255, 255);
                else
                    row.BackColor = Color.FromArgb(233, 233, 233);

                for (int j = result.Columns.Count - 1; j >= 0; j--)
                {
                    row.Cells.Add(new XRTableCell());
                    row.Cells[index].TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

                    row.Cells[index].Text = j > 4 ? double.Parse(result.Rows[i].Cells[j].Value.ToString()).ToString("#,###") : result.Rows[i].Cells[j].Value.ToString();

                    row.Cells[index].Font = new Font("Calibri", 12);
                    row.Cells[index].Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
                    index++;
                }
                report.Rows.Add(row);

            }
            report.EndInit();
            return report;
        }
    }
}

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace HCashier.Report
{
    public partial class EmpReport : DevExpress.XtraReports.UI.XtraReport
    {
        bool isDinar = true;
        HDatabaseConnection.HMySQLConnection databaseConnection;

        public EmpReport(HDatabaseConnection.HMySQLConnection databaseConnection, System.Windows.Forms.DataGridView result,string reportName,bool isDinar,bool isCash,DateTime from,DateTime to,double dollarValue,string empName)
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
            lblDebits.Text = double.Parse(databaseConnection.query(string.Format("select ifnull(sum(if(tbl_debits.is_dollar = 1,tbl_debits.value * getDollar(tbl_debits.datetime),tbl_debits.value)),0) as `value` from tbl_debits, tbl_clients where tbl_debits.employee_id = tbl_clients.id and tbl_clients.name = '{0}' and tbl_debits.datetime between '{1}' and '{2}' and tbl_debits.is_pay = 0;", empName, from.ToString("yyyy-MM-dd 00:00:00"), to.ToString("yyyy-MM-dd 23:59:59"))).Rows[0][0].ToString()).ToString("#,###");
            lblPaid.Text = double.Parse(databaseConnection.query(string.Format("select ifnull(sum(if(tbl_debits.is_dollar = 1,tbl_debits.value * getDollar(tbl_debits.datetime),tbl_debits.value)),0) as `value` from tbl_debits, tbl_clients where tbl_debits.employee_id = tbl_clients.id and tbl_clients.name = '{0}' and tbl_debits.datetime between '{1}' and '{2}' and tbl_debits.is_pay = 1;", empName, from.ToString("yyyy-MM-dd 00:00:00"), to.ToString("yyyy-MM-dd 23:59:59"))).Rows[0][0].ToString()).ToString("#,###");
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

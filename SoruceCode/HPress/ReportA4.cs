using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace HPress
{
    public partial class ReportA4 : DevExpress.XtraReports.UI.XtraReport
    {
        System.Windows.Forms.DataGridView dgvProducts;
        string[] numberOne = {
            "zero",
            "one",
            "two",
            "three",
            "four",
            "five",
            "six",
            "seven",
            "eight",
            "nine"
        };
        string[] numberTwo = {
            "ten",
            "eleven",
            "twelve",
            "thirteen",
            "fourteen",
            "fifteen",
            "sixteen",
            "seventeen",
            "eighteen",
            "nineteen",
        };
        string[] numberThree = {
            "",
            "ten",
            "twenty",
            "thirty",
            "forty",
            "fifty",
            "sixty",
            "seventy",
            "eighty",
            "ninety"
        };
        private string getNumberInText(string number)
        {
            if (number.Contains(".") || number.Contains("-")) return "";
            string temp = "";
            if (number.Length == 1)
            {
                return numberOne[int.Parse(number[0].ToString())];
            }
            if (number.Length == 2)
            {
                if (number[0].ToString() == "1")
                    return numberTwo[int.Parse(number[1].ToString())];
                temp += numberThree[int.Parse(number[0].ToString())];
                if (number[1].ToString() == "0") return temp;
                temp += " ";
                temp += numberOne[int.Parse(number[1].ToString())];
                return temp;
            }
            if (number.Length == 3)
            {
                if (number[0].ToString() == "0") return "";
                if (number[0].ToString() != "1")
                {
                    string num = numberOne[int.Parse(number[0].ToString())];
                    temp += num;
                    temp += " hundred";
                }
                else
                {
                    temp += " one hundred";
                }


                if (number[1].ToString() == "0" && number[2].ToString() == "0") return temp;
                temp += " and ";
                temp += getNumberInText(number.Substring(1));
                return temp;
            }
            if (number.Length == 4)
            {
                if (number[0].ToString() != "1") temp += numberOne[int.Parse(number[0].ToString())];
                temp += " thousand";
                if (number[1].ToString() == "0" && number[2].ToString() == "0" && number[3].ToString() == "0") return temp;
                temp += " and ";
                string s = number.Substring(1);
                temp += getNumberInText(s);
                return temp;
            }
            if (number.Length == 5)
            {
                temp += getNumberInText(number.Substring(0, 2));
                temp += " thousand ";
                if (number[2].ToString() == "0" && number[3].ToString() == "0" && number[4].ToString() == "0") return temp;
                temp += " and ";
                temp += getNumberInText(number.Substring(2));
                return temp;
            }
            if (number.Length == 6)
            {
                temp += getNumberInText(number.Substring(0, 3));
                temp += " thousand, ";
                if (number[3].ToString() == "0" && number[4].ToString() == "0" && number[5].ToString() == "0") return temp;
                temp += " ";
                temp += getNumberInText(number.Substring(3));
                return temp;
            }
            if (number.Length == 7)
            {
                temp += getNumberInText(number.Substring(0, 1));
                temp += " million, ";
                if (number[1].ToString() == "0" && number[2].ToString() == "0" && number[3].ToString() == "0" && number[4].ToString() == "0" && number[5].ToString() == "0" && number[6].ToString() == "0") return temp;
                temp += " and ";
                temp += getNumberInText(number.Substring(1));
                return temp;
            }
            return "";
        }
        bool isDollar = false;
        public ReportA4(System.Windows.Forms.DataGridView dgvProducts,bool isAccount, bool isDollar,DateTime dateFrom,DateTime dateTo,int billId,int clientId,string clientName,string clientMobile,string clientEmail,string clientAddress,double discount,double total,bool isCash,string note,/*double receive,*/double paid,double remaining)
        {
            this.dgvProducts = dgvProducts;
            InitializeComponent();

            lblDateFrom.Text = dateFrom.ToString("yyyy/MM/dd");
            lblDateTo.Text = isAccount ? "none" : dateTo.ToString("yyyy/MM/dd");
            lblBillId.Text = "000000".Substring(0, 6 - billId.ToString().Length) + billId.ToString();
            lblClientId.Text = "000000".Substring(0, 6 - clientId.ToString().Length) + clientId.ToString();

            lblClientName.Text = clientName;
            lblClientMobile.Text = clientMobile;
            lblClientEmail.Text = clientEmail;
            txtNote.Text = note;

            lblFirstTotal.Text = (total + discount).ToString(isDollar ? "#.##" : "#,###");

            lblDiscount.Text = discount.ToString(isDollar ? "#.##" : "#,###");
            lblTotal.Text = (total).ToString(isDollar ? "#.##" : "#,###");
            
            if (paid != 0)
            {
                //lblReceive.Text = isDollar ? (receive / Properties.Settings.Default.dollarValue).ToString("#.##") : receive.ToString("#,###");
                lblReceive.Text = paid.ToString(isDollar ? "#.##" : "#,###");
                remaining = total - paid;
                lblRemaining.Text = remaining.ToString(isDollar ? "#.##" : "#,###");

            }
            else
            {
                lblReceive.Visible = lblReceiveTtile.Visible = lblRemaining.Visible = lblRemainingTitle.Visible = false;
            }
            
            txtAccount.Text = isCash ? "Cash" : "Debit";
            this.isDollar = isDollar;

            lblTotalText.Text = getNumberInText(total.ToString()) + " " + (isDollar ? "Dollar" : "Dinar");
            lblSubTotalSign.Text = isDollar ? "$" : "IQD";
            picMain.Image = Image.FromFile(Properties.Settings.Default.imageLogoPrint);
            lblBillInfo.BackColor = lblClientInfo.BackColor = lblConditions.BackColor = lblAccount.BackColor = lblFirstTotalTitle.BackColor = lblSaleTotal.BackColor = lblFinalTotalTitle.BackColor = lblReceiveTtile.BackColor = lblRemainingTitle.BackColor = System.Drawing.ColorTranslator.FromHtml(Properties.Settings.Default.color);
        }
        XRTable table(System.Windows.Forms.DataGridView products)
        {
            XRTable tblProducts = new XRTable();
            tblProducts.SizeF = new SizeF(this.PageSize.Width - this.Margins.Left * 2, 30);
            tblProducts.BeginInit();
            XRTableRow HeaderRow = new XRTableRow();
            XRTableCell description = new XRTableCell();
            XRTableCell price = new XRTableCell();
            XRTableCell quantity = new XRTableCell();
            XRTableCell note = new XRTableCell();
            XRTableCell amount = new XRTableCell();
            description.TextAlignment = price.TextAlignment = quantity.TextAlignment = note.TextAlignment = amount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            description.Text = "Description";
            price.Text = "Price";
            quantity.Text = "QTY";
            note.Text = "Note";
            amount.Text = "Amount";
            description.Font = price.Font = quantity.Font = note.Font = amount.Font = new Font("Calibri", 16);
            description.BackColor = price.BackColor = quantity.BackColor = note.BackColor = amount.BackColor = System.Drawing.ColorTranslator.FromHtml(Properties.Settings.Default.color);
            description.Borders = DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom;
            amount.Borders = DevExpress.XtraPrinting.BorderSide.Bottom | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Left;
            price.Borders = quantity.Borders = note.Borders = DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom;
            HeaderRow.Cells.Add(description);
            HeaderRow.Cells.Add(price);
            HeaderRow.Cells.Add(quantity);
            HeaderRow.Cells.Add(note);
            HeaderRow.Cells.Add(amount);
            tblProducts.Rows.Add(HeaderRow);
            description.Font = price.Font = quantity.Font = note.Font = amount.Font = new Font("Calibri", 16,FontStyle.Bold);
            for (int i = 0; i < (products.Rows.Count < 19 ? 19 : products.Rows.Count); i++)
            {
                XRTableRow row = new XRTableRow();
                XRTableCell d = new XRTableCell();
                XRTableCell p = new XRTableCell();
                XRTableCell q = new XRTableCell();
                XRTableCell n = new XRTableCell();
                XRTableCell a = new XRTableCell();
                d.Borders = p.Borders = q.Borders = n.Borders = a.Borders = amount.Borders = description.Borders = note.Borders = quantity.Borders = price.Borders = DevExpress.XtraPrinting.BorderSide.All;
                p.WidthF = price.WidthF = q.WidthF = quantity.WidthF = 30;
                d.WidthF = description.WidthF = 160;
                a.WidthF = amount.WidthF = 50;
                n.WidthF = note.WidthF = 60;
                d.Font = p.Font = q.Font = n.Font = a.Font = new Font("Calibri", 14);
                d.TextAlignment = p.TextAlignment = q.TextAlignment = n.TextAlignment = a.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
                if (i % 2 == 0)
                    d.BackColor = p.BackColor = q.BackColor = n.BackColor = a.BackColor = Color.FromArgb(255, 255, 255);
                else
                    d.BackColor = p.BackColor = q.BackColor = n.BackColor = a.BackColor = Color.FromArgb(204, 204, 204);
                if (i < products.Rows.Count - 1)
                {
                    d.Text = products.Rows[i].Cells["description"].Value == null ? " ":products.Rows[i].Cells["description"].Value.ToString();
                    p.Text = products.Rows[i].Cells["price"].Value.ToString();
                    q.Text = products.Rows[i].Cells["quantity"].Value.ToString();
                    n.Text = products.Rows[i].Cells["note"].Value == null ? " " : products.Rows[i].Cells["note"].Value.ToString();
                    a.Text = double.Parse(products.Rows[i].Cells["total"].Value.ToString()).ToString(isDollar ? "#.##" : "#,###");
                }
                else
                {
                    d.Text = p.Text = q.Text = n.Text = a.Text = "--";
                }
                row.Cells.Add(d);
                row.Cells.Add(p);
                row.Cells.Add(q);
                row.Cells.Add(n);
                row.Cells.Add(a);
                tblProducts.Rows.Add(row);
            }
            tblProducts.EndInit();
            return tblProducts;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.Detail.Controls.Add(table(this.dgvProducts));
        }
    }
}

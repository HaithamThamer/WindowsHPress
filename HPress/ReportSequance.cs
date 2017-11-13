using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using HPress;
namespace HCashier.Report
{
    public partial class ReportSequance : DevExpress.XtraReports.UI.XtraReport
    {
        HDatabaseConnection.HMySQLConnection databaseConnection;
        List<Bill> bills = new List<HPress.Bill>();
        public ReportSequance(HDatabaseConnection.HMySQLConnection databaseConnection,string reportName,DateTime from,DateTime to,double dollarValue,int isCash,int isDollar,int isImport,string clientName)
        {
            InitializeComponent();
            this.databaseConnection = databaseConnection;

            lblReportName.Text = reportName;
            lblDatetimeFrom.Text = from.ToString("yyyy-MM-dd");
            lblDatetimeTo.Text = to.ToString("yyyy-MM-dd");
            lblDollar.Text = dollarValue.ToString();

            System.Data.DataTable dt = databaseConnection.query(string.Format("select tbl_bills.id,is_account,is_sell,tbl_clients.name,if(is_dollar = 1,CONCAT('$ ',getDollar(tbl_bills.datetime)),'IQD') as `is_dollar`,is_cash,note,DATE_FORMAT(datetime,'%Y-%m-%d') as `datetime`,discount,tbl_bills.name,(select name from tbl_clients where id = tbl_bills.delegate_id) as `delegateName`,delegate_percent from tbl_bills,tbl_clients where tbl_bills.client_id = tbl_clients.id and  tbl_bills.id > 0 and tbl_bills.datetime between '{0}' and '{1}'  {2} {3} {4} {5} order by tbl_bills.datetime;", from.ToString("yyyy-MM-dd 00:00:00"), to.ToString("yyyy-MM-dd 23:59:59"), isCash == 2 ? "" : " and tbl_bills.is_cash = '" + isCash + "' ", isDollar == 2 ? "" : " and tbl_bills.is_dollar = '" + isDollar + "' ", isImport == 2 ? "" : " and tbl_bills.is_sell = '" + isImport + "' ", clientName == "الكل" ? "" : " and tbl_clients.name = '" + clientName + "' "));
            int billId = 0;
            Bill bill;
            int x = 2;
            int y = 30;
            double billSum = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                billId = int.Parse(dt.Rows[i]["id"].ToString());
                bill = new Bill();
                //
                bill.id = billId;
                bill.datetime = DateTime.Parse(dt.Rows[i]["datetime"].ToString());
                bill.isAccount = bool.Parse(dt.Rows[i]["is_account"].ToString());
                bill.isSell = bool.Parse(dt.Rows[i]["is_sell"].ToString());
                bill.isDollar = dt.Rows[i]["is_dollar"].ToString();
                bill.isCash = bool.Parse(dt.Rows[i]["is_cash"].ToString());
                bill.note = dt.Rows[i]["note"].ToString();
                bill.discount = double.Parse(dt.Rows[i]["discount"].ToString());
                bill.clientName = dt.Rows[i]["name"].ToString();
                bill.delegateName = dt.Rows[i]["delegateName"].ToString();
                bill.delegatePercent = int.Parse(dt.Rows[i]["delegate_percent"].ToString());
                bill.products = databaseConnection.query(string.Format("select tbl_products.description, tbl_products.count, tbl_products.price, tbl_products.price * tbl_products.count, tbl_products.note from tbl_products where  tbl_products.bill_id = {0} ",bill.id));
                //
                bills.Add(bill);

                XRLabel lblBillId = new XRLabel();
                XRLabel lblBillDate = new XRLabel();
                XRLabel lblClientName = new XRLabel();
                XRLabel lblIsDollar = new XRLabel();
                XRLabel lblIsCash = new XRLabel();
                XRLabel lblTotal = new XRLabel();
                XRLabel lblDiscount = new XRLabel();
                XRLabel lblTotalWitoutDiscount = new XRLabel();
                XRTable tblProducts = new XRTable();

                lblTotalWitoutDiscount.BackColor = lblDiscount.BackColor = lblTotal.BackColor = Color.LightGray;
                lblTotal.Font = new Font("times", 16, FontStyle.Bold);
                lblTotalWitoutDiscount.WidthF = lblDiscount.WidthF = lblTotal.WidthF = 160;

                lblDiscount.Font = lblTotalWitoutDiscount.Font = lblBillId.Font = lblBillDate.Font =  lblIsDollar.Font =  lblIsCash.Font = lblTotal.Font = lblClientName.Font = new Font("times", 14);
                lblDiscount.TextAlignment = lblTotalWitoutDiscount.TextAlignment = lblBillId.TextAlignment = lblBillDate.TextAlignment = lblIsDollar.TextAlignment =  lblIsCash.TextAlignment = lblTotal.TextAlignment = lblClientName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                lblDiscount.CanGrow = lblTotalWitoutDiscount.CanGrow = lblBillId.CanGrow = lblIsDollar.CanGrow = lblIsCash.CanGrow = lblTotal.CanGrow = lblClientName.CanGrow  = true;
                lblDiscount.CanShrink = lblTotalWitoutDiscount.CanShrink = lblBillId.CanShrink = lblIsDollar.CanShrink =  lblIsCash.CanShrink = lblTotal.CanShrink = lblClientName.CanShrink  = true;
                lblDiscount.HeightF = lblTotalWitoutDiscount.HeightF = lblBillId.HeightF = lblBillDate.HeightF =  lblIsDollar.HeightF = lblIsCash.HeightF = lblTotal.HeightF = lblClientName.HeightF  = 30;

                lblClientName.SizeF = new SizeF(lblClientName.SizeF.Width * 2, lblClientName.SizeF.Height);
                lblBillId.LocationF = new PointF(x, y);
                lblBillDate.LocationF = new PointF(x, y + lblBillId.HeightF);

                lblClientName.LocationF = new PointF(this.PageWidth - lblClientName.WidthF - 50 , y);
                lblIsCash.LocationF = new PointF(lblClientName.LocationF.X + lblIsCash.SizeF.Width, lblClientName.LocationF.Y + lblClientName.SizeF.Height);
                lblIsDollar.LocationF = new PointF(lblClientName.LocationF.X , lblIsCash.LocationF.Y);

                tblProducts.SizeF = new SizeF(this.PageWidth - 50, 30);
                tblProducts.Borders = DevExpress.XtraPrinting.BorderSide.All;
                tblProducts.BorderWidth = 1;
                tblProducts.BorderColor = Color.DimGray;
                tblProducts.BeginInit();
                tblProducts.LocationF = new PointF(x,y + lblBillId.HeightF + lblBillDate.HeightF + 1);
                tblProducts.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
                
                for (int j = -1; j < bill.products.Rows.Count; j++)
                {
                    XRTableRow row = new XRTableRow();

                    XRTableCell productId = new XRTableCell();
                    XRTableCell description = new XRTableCell();
                    XRTableCell count = new XRTableCell();
                    XRTableCell price = new XRTableCell();
                    XRTableCell total = new XRTableCell();
                    XRTableCell note = new XRTableCell();
                    productId.WidthF = 30;
                    description.WidthF = 250;
                    count.WidthF = 80;
                    price.WidthF = 80;
                    total.WidthF = 110;
                    note.WidthF = 210;
                    productId.TextAlignment = total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
                    productId.HeightF = description.HeightF = count.HeightF = price.HeightF = total.HeightF = note.HeightF = 30;

                    if (j == -1)
                    {
                        productId.Font = description.Font = count.Font = price.Font = total.Font = note.Font = new Font("times", 16,FontStyle.Bold);
                        productId.BackColor = description.BackColor = count.BackColor = price.BackColor = total.BackColor = note.BackColor = Color.LightGray;
                        description.TextAlignment = count.TextAlignment = price.TextAlignment = total.TextAlignment = note.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

                        productId.Text = "ت";
                        description.Text = "الوصف";
                        count.Text = "العدد";
                        price.Text = "السعر";
                        total.Text = "المجموع";
                        note.Text = "ملاحظة";
                    }
                    else
                    {
                        productId.Font = description.Font = count.Font = price.Font = total.Font = note.Font = new Font("times", 12, FontStyle.Bold);
                        productId.BackColor = description.BackColor = count.BackColor = price.BackColor = total.BackColor = note.BackColor = Color.White;
                        description.TextAlignment = note.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight ;
                        count.TextAlignment = price.TextAlignment = total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;

                        billSum += double.Parse(bill.products.Rows[j][3].ToString());
                        productId.Text = (j+1).ToString();
                        description.Text = bill.products.Rows[j][0].ToString();
                        count.Text = bill.products.Rows[j][1].ToString();
                        price.Text = double.Parse(bill.products.Rows[j][2].ToString()).ToString(bill.isDollar.Contains("$") ? "#.##" : "#,###");
                        total.Text = double.Parse(bill.products.Rows[j][3].ToString()).ToString();
                        note.Text = bill.products.Rows[j][4].ToString();
                    }
                    row.Cells.Add(note);
                    row.Cells.Add(total);
                    row.Cells.Add(price);
                    row.Cells.Add(count);
                    row.Cells.Add(description);
                    row.Cells.Add(productId);
                    tblProducts.Rows.Add(row);
                }
                
                tblProducts.EndInit();
                y = (int)tblProducts.LocationF.Y + 30;

                lblTotal.LocationF = new PointF(x, y);
                lblDiscount.LocationF = new PointF(lblTotal.LocationF.X + lblTotal.WidthF, y);
                lblTotalWitoutDiscount.LocationF = new PointF(lblDiscount.LocationF.X + lblDiscount.WidthF, y);
                y = y + (int)lblBillId.SizeF.Height + 5;

                lblBillId.Text = bill.id.ToString();
                lblBillDate.Text = bill.datetime.ToString("yyyy-MM-dd");
                lblIsDollar.Text = bill.isDollar ;
                lblIsCash.Text = bill.isCash ? "نقد" : "أجل";
                lblTotal.Text = string.Format("{0} | {1}", (billSum - bill.discount).ToString(bill.isDollar.Contains("$") ? "#.##" : "#,###"), "النهائي");
                lblDiscount.Text = string.Format("{0} | {1}", bill.discount.ToString(bill.isDollar.Contains("$") ? "#.##" : "#,###"), "خصم");
                lblTotalWitoutDiscount.Text = string.Format("{0} | {1}", billSum.ToString(bill.isDollar.Contains("$") ? "#.##" : "#,###"), "مجموع");
                lblClientName.Text = bill.clientName.ToString();
                
                
                this.Detail.Controls.Add(lblBillId);
                this.Detail.Controls.Add(lblBillDate);
                this.Detail.Controls.Add(lblClientName);
                this.Detail.Controls.Add(lblIsDollar);
                this.Detail.Controls.Add(lblIsCash);
                this.Detail.Controls.Add(lblTotal);
                this.Detail.Controls.Add(lblDiscount);
                this.Detail.Controls.Add(lblTotalWitoutDiscount);
                this.Detail.Controls.Add(tblProducts);
                y += 10;
                billSum = 0;
            }

        }
        void drawBill(int x,int y,Bill bill)
        {

        }
    }
}

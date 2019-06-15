// HPress.ReportA4Ar
using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using HPress;
using HPress.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

public class ReportA4Ar : XtraReport
{
    private DataGridView dgvProducts;

    private string[] numberOne = new string[10]
    {
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

    private string[] numberTwo = new string[10]
    {
        "ten",
        "eleven",
        "twelve",
        "thirteen",
        "fourteen",
        "fifteen",
        "sixteen",
        "seventeen",
        "eighteen",
        "nineteen"
    };

    private string[] numberThree = new string[10]
    {
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

    private bool isDollar = false;

    private IContainer components = null;

    private DetailBand Detail;

    private TopMarginBand TopMargin;

    private BottomMarginBand BottomMargin;

    private XRPictureBox picMain;

    private XRLabel lblBillInfo;

    private XRLabel lblEmail;

    private XRLabel lblPhone;

    private XRLabel lblFacebook;

    private XRLabel lblAddress;

    private XRLabel xrLabel11;

    private XRLabel lblClientId;

    private XRLabel lblDateTo;

    private XRLabel xrLabel10;

    private XRLabel lblDateFrom;

    private XRLabel xrLabel7;

    private XRLabel xrLabel15;

    private XRLabel xrLabel13;

    private XRLabel lblFirstTotalTitle;

    private XRLabel lblFirstTotal;

    private XRLabel lblSaleTotal;

    private XRLabel lblDiscount;

    private XRLabel lblTotal;

    private XRLabel lblFinalTotalTitle;

    private XRLabel xrLabel18;

    private XRLabel xrLabel17;

    private XRLabel lblConditions;

    private XRLine xrLine2;

    private XRLabel lblClientAddress;

    private XRLabel xrLabel35;

    private XRLabel lblClientInfo;

    private XRLabel xrLabel28;

    private XRLabel lblClientName;

    private XRLabel xrLabel30;

    private XRLabel lblClientMobile;

    private XRLabel lblClientEmail;

    private XRLabel xrLabel33;

    private XRLine xrLine1;

    private XRLabel lblBillId;

    private XRLabel xrLabel9;

    private XRLabel txtNote;

    private XRLabel txtAccount;

    private XRLabel lblAccount;

    private XRLabel lblSubTotalSign;

    private XRLabel lblTotalText;

    private XRLabel lblReceive;

    private XRLabel lblReceiveTtile;

    private XRLabel lblRemainingTitle;

    private XRLabel lblRemaining;

    private XRLabel billType;

    private string getNumberInText(string number)
    {
        if (number.Contains(".") || number.Contains("-"))
        {
            return "";
        }
        string text = "";
        char c;
        if (number.Length == 1)
        {
            string[] array = this.numberOne;
            c = number[0];
            return array[int.Parse(c.ToString())];
        }
        if (number.Length == 2)
        {
            c = number[0];
            if (c.ToString() == "1")
            {
                string[] array2 = this.numberTwo;
                c = number[1];
                return array2[int.Parse(c.ToString())];
            }
            string str = text;
            string[] array3 = this.numberThree;
            c = number[0];
            text = str + array3[int.Parse(c.ToString())];
            c = number[1];
            if (c.ToString() == "0")
            {
                return text;
            }
            text += " ";
            string str2 = text;
            string[] array4 = this.numberOne;
            c = number[1];
            return str2 + array4[int.Parse(c.ToString())];
        }
        if (number.Length == 3)
        {
            c = number[0];
            if (c.ToString() == "0")
            {
                return "";
            }
            c = number[0];
            if (c.ToString() != "1")
            {
                string[] array5 = this.numberOne;
                c = number[0];
                string str3 = array5[int.Parse(c.ToString())];
                text += str3;
                text += " hundred";
            }
            else
            {
                text += " one hundred";
            }
            c = number[1];
            int num;
            if (c.ToString() == "0")
            {
                c = number[2];
                num = ((c.ToString() == "0") ? 1 : 0);
            }
            else
            {
                num = 0;
            }
            if (num != 0)
            {
                return text;
            }
            text += " and ";
            return text + this.getNumberInText(number.Substring(1));
        }
        int num2;
        if (number.Length == 4)
        {
            c = number[0];
            if (c.ToString() != "1")
            {
                string str4 = text;
                string[] array6 = this.numberOne;
                c = number[0];
                text = str4 + array6[int.Parse(c.ToString())];
            }
            text += " thousand";
            c = number[1];
            if (c.ToString() == "0")
            {
                c = number[2];
                if (c.ToString() == "0")
                {
                    c = number[3];
                    num2 = ((c.ToString() == "0") ? 1 : 0);
                    goto IL_02fd;
                }
            }
            num2 = 0;
            goto IL_02fd;
        }
        int num3;
        if (number.Length == 5)
        {
            text += this.getNumberInText(number.Substring(0, 2));
            text += " thousand ";
            c = number[2];
            if (c.ToString() == "0")
            {
                c = number[3];
                if (c.ToString() == "0")
                {
                    c = number[4];
                    num3 = ((c.ToString() == "0") ? 1 : 0);
                    goto IL_03be;
                }
            }
            num3 = 0;
            goto IL_03be;
        }
        int num4;
        if (number.Length == 6)
        {
            text += this.getNumberInText(number.Substring(0, 3));
            text += " thousand, ";
            c = number[3];
            if (c.ToString() == "0")
            {
                c = number[4];
                if (c.ToString() == "0")
                {
                    c = number[5];
                    num4 = ((c.ToString() == "0") ? 1 : 0);
                    goto IL_047b;
                }
            }
            num4 = 0;
            goto IL_047b;
        }
        int num5;
        if (number.Length == 7)
        {
            text += this.getNumberInText(number.Substring(0, 1));
            text += " million, ";
            c = number[1];
            if (c.ToString() == "0")
            {
                c = number[2];
                if (c.ToString() == "0")
                {
                    c = number[3];
                    if (c.ToString() == "0")
                    {
                        c = number[4];
                        if (c.ToString() == "0")
                        {
                            c = number[5];
                            if (c.ToString() == "0")
                            {
                                c = number[6];
                                num5 = ((c.ToString() == "0") ? 1 : 0);
                                goto IL_058f;
                            }
                        }
                    }
                }
            }
            num5 = 0;
            goto IL_058f;
        }
        return "";
    IL_02fd:
        if (num2 != 0)
        {
            return text;
        }
        text += " and ";
        string number2 = number.Substring(1);
        return text + this.getNumberInText(number2);
    IL_03be:
        if (num3 != 0)
        {
            return text;
        }
        text += " and ";
        return text + this.getNumberInText(number.Substring(2));
    IL_047b:
        if (num4 != 0)
        {
            return text;
        }
        text += " ";
        return text + this.getNumberInText(number.Substring(3));
    IL_058f:
        if (num5 != 0)
        {
            return text;
        }
        text += " and ";
        return text + this.getNumberInText(number.Substring(1));
    }

    public ReportA4Ar(DataGridView dgvProducts, bool isAccount, bool isDollar, DateTime dateFrom, DateTime dateTo, int billId, int clientId, string clientName, string clientMobile, string clientEmail, string clientAddress, double discount, double total, bool isCash, bool isSell, string note, double paid, double remaining)
    {
        this.dgvProducts = dgvProducts;
        this.InitializeComponent();
        this.lblDateFrom.Text = dateFrom.ToString("yyyy/MM/dd");
        this.lblDateTo.Text = (isAccount ? "none" : dateTo.ToString("yyyy/MM/dd"));
        this.lblBillId.Text = "000000".Substring(0, 6 - billId.ToString().Length) + billId.ToString();
        this.lblClientId.Text = "000000".Substring(0, 6 - clientId.ToString().Length) + clientId.ToString();
        this.lblClientName.Text = clientName;
        this.lblClientMobile.Text = clientMobile;
        this.lblClientEmail.Text = clientEmail;
        this.txtNote.Text = note;
        this.lblFirstTotal.Text = (total + discount).ToString(isDollar ? "#.##" : "#,###");
        this.lblDiscount.Text = discount.ToString(isDollar ? "#.##" : "#,###");
        this.lblTotal.Text = total.ToString(isDollar ? "#.##" : "#,###");
        if (paid != 0.0)
        {
            this.lblReceive.Text = paid.ToString(isDollar ? "#.##" : "#,###");
            remaining = total - paid;
            this.lblRemaining.Text = remaining.ToString(isDollar ? "#.##" : "#,###");
        }
        else
        {
            XRLabel xRLabel = this.lblReceive;
            XRLabel xRLabel2 = this.lblReceiveTtile;
            XRLabel xRLabel3 = this.lblRemaining;
            XRLabel xRLabel4 = this.lblRemainingTitle;
            bool flag2 = xRLabel4.Visible = false;
            bool flag4 = xRLabel3.Visible = flag2;
            bool visible = xRLabel2.Visible = flag4;
            xRLabel.Visible = visible;
        }
        this.txtAccount.Text = (isCash ? "Cash" : "Debit");
        this.isDollar = isDollar;
        this.lblTotalText.Text = this.getNumberInText(total.ToString()) + " " + (isDollar ? "Dollar" : "Dinar");
        this.lblSubTotalSign.Text = (isDollar ? "$" : "IQD");
        this.picMain.Image = Image.FromFile(Settings.Default.imageLogoPrint);
        XRLabel xRLabel5 = this.lblBillInfo;
        XRLabel xRLabel6 = this.lblClientInfo;
        XRLabel xRLabel7 = this.lblConditions;
        XRLabel xRLabel8 = this.lblAccount;
        XRLabel xRLabel9 = this.lblFirstTotalTitle;
        XRLabel xRLabel10 = this.lblSaleTotal;
        XRLabel xRLabel11 = this.lblFinalTotalTitle;
        XRLabel xRLabel12 = this.lblReceiveTtile;
        XRLabel xRLabel13 = this.lblRemainingTitle;
        Color color2 = xRLabel13.BackColor = ColorTranslator.FromHtml(Settings.Default.color);
        Color color4 = xRLabel12.BackColor = color2;
        Color color6 = xRLabel11.BackColor = color4;
        Color color8 = xRLabel10.BackColor = color6;
        Color color10 = xRLabel9.BackColor = color8;
        Color color12 = xRLabel8.BackColor = color10;
        Color color14 = xRLabel7.BackColor = color12;
        Color color17 = xRLabel5.BackColor = (xRLabel6.BackColor = color14);
        this.lblAddress.Text = Settings.Default.address;
        this.lblFacebook.Text = Settings.Default.facebook;
        this.lblPhone.Text = Settings.Default.phone;
        this.lblEmail.Text = Settings.Default.email;
        this.billType.Visible = ((byte)((!isSell) ? 1 : 0) != 0);
    }

    private XRTable table(DataGridView products)
    {
        XRTable xRTable = new XRTable();
        xRTable.SizeF = new SizeF((float)(base.PageSize.Width - base.Margins.Left * 2), 30f);
        xRTable.BeginInit();
        XRTableRow xRTableRow = new XRTableRow();
        XRTableCell xRTableCell = new XRTableCell();
        XRTableCell xRTableCell2 = new XRTableCell();
        XRTableCell xRTableCell3 = new XRTableCell();
        XRTableCell xRTableCell4 = new XRTableCell();
        XRTableCell xRTableCell5 = new XRTableCell();
        XRTableCell xRTableCell6 = xRTableCell;
        XRTableCell xRTableCell7 = xRTableCell2;
        XRTableCell xRTableCell8 = xRTableCell3;
        XRTableCell xRTableCell9 = xRTableCell4;
        XRTableCell xRTableCell10 = xRTableCell5;
        TextAlignment textAlignment2 = xRTableCell10.TextAlignment = TextAlignment.MiddleCenter;
        TextAlignment textAlignment4 = xRTableCell9.TextAlignment = textAlignment2;
        TextAlignment textAlignment6 = xRTableCell8.TextAlignment = textAlignment4;
        TextAlignment textAlignment9 = xRTableCell6.TextAlignment = (xRTableCell7.TextAlignment = textAlignment6);
        xRTableCell.Text = "الوصف";
        xRTableCell2.Text = "السعر";
        xRTableCell3.Text = "العدد";
        xRTableCell4.Text = "ملاحظة";
        xRTableCell5.Text = "المجموع";
        XRTableCell xRTableCell11 = xRTableCell;
        XRTableCell xRTableCell12 = xRTableCell2;
        XRTableCell xRTableCell13 = xRTableCell3;
        XRTableCell xRTableCell14 = xRTableCell4;
        XRTableCell xRTableCell15 = xRTableCell5;
        Font font2 = xRTableCell15.Font = new Font("Calibri", 16f);
        Font font4 = xRTableCell14.Font = font2;
        Font font6 = xRTableCell13.Font = font4;
        Font font9 = xRTableCell11.Font = (xRTableCell12.Font = font6);
        XRTableCell xRTableCell16 = xRTableCell;
        XRTableCell xRTableCell17 = xRTableCell2;
        XRTableCell xRTableCell18 = xRTableCell3;
        XRTableCell xRTableCell19 = xRTableCell4;
        XRTableCell xRTableCell20 = xRTableCell5;
        Color color2 = xRTableCell20.BackColor = ColorTranslator.FromHtml(Settings.Default.color);
        Color color4 = xRTableCell19.BackColor = color2;
        Color color6 = xRTableCell18.BackColor = color4;
        Color color9 = xRTableCell16.BackColor = (xRTableCell17.BackColor = color6);
        xRTableCell.Borders = (BorderSide.Top | BorderSide.Right | BorderSide.Bottom);
        xRTableCell5.Borders = (BorderSide.Left | BorderSide.Top | BorderSide.Bottom);
        XRTableCell xRTableCell21 = xRTableCell2;
        XRTableCell xRTableCell22 = xRTableCell3;
        XRTableCell xRTableCell23 = xRTableCell4;
        BorderSide borderSide2 = xRTableCell23.Borders = (BorderSide.Top | BorderSide.Right | BorderSide.Bottom);
        BorderSide borderSide5 = xRTableCell21.Borders = (xRTableCell22.Borders = borderSide2);
        xRTableRow.Cells.Add(xRTableCell);
        xRTableRow.Cells.Add(xRTableCell2);
        xRTableRow.Cells.Add(xRTableCell3);
        xRTableRow.Cells.Add(xRTableCell4);
        xRTableRow.Cells.Add(xRTableCell5);
        xRTable.Rows.Add(xRTableRow);
        XRTableCell xRTableCell24 = xRTableCell;
        XRTableCell xRTableCell25 = xRTableCell2;
        XRTableCell xRTableCell26 = xRTableCell3;
        XRTableCell xRTableCell27 = xRTableCell4;
        XRTableCell xRTableCell28 = xRTableCell5;
        font2 = (xRTableCell28.Font = new Font("Calibri", 16f, FontStyle.Bold));
        font4 = (xRTableCell27.Font = font2);
        font6 = (xRTableCell26.Font = font4);
        font9 = (xRTableCell24.Font = (xRTableCell25.Font = font6));
        for (int i = 0; i < ((products.Rows.Count < 19) ? 19 : products.Rows.Count); i++)
        {
            XRTableRow xRTableRow2 = new XRTableRow();
            XRTableCell xRTableCell29 = new XRTableCell();
            XRTableCell xRTableCell30 = new XRTableCell();
            XRTableCell xRTableCell31 = new XRTableCell();
            XRTableCell xRTableCell32 = new XRTableCell();
            XRTableCell xRTableCell33 = new XRTableCell();
            XRTableCell xRTableCell34 = xRTableCell29;
            XRTableCell xRTableCell35 = xRTableCell30;
            XRTableCell xRTableCell36 = xRTableCell31;
            XRTableCell xRTableCell37 = xRTableCell32;
            XRTableCell xRTableCell38 = xRTableCell33;
            XRTableCell xRTableCell39 = xRTableCell5;
            XRTableCell xRTableCell40 = xRTableCell;
            XRTableCell xRTableCell41 = xRTableCell4;
            XRTableCell xRTableCell42 = xRTableCell3;
            XRTableCell xRTableCell43 = xRTableCell2;
            BorderSide borderSide7 = xRTableCell43.Borders = BorderSide.All;
            BorderSide borderSide9 = xRTableCell42.Borders = borderSide7;
            BorderSide borderSide11 = xRTableCell41.Borders = borderSide9;
            BorderSide borderSide13 = xRTableCell40.Borders = borderSide11;
            BorderSide borderSide15 = xRTableCell39.Borders = borderSide13;
            BorderSide borderSide17 = xRTableCell38.Borders = borderSide15;
            BorderSide borderSide19 = xRTableCell37.Borders = borderSide17;
            borderSide2 = (xRTableCell36.Borders = borderSide19);
            borderSide5 = (xRTableCell34.Borders = (xRTableCell35.Borders = borderSide2));
            XRTableCell xRTableCell44 = xRTableCell30;
            XRTableCell xRTableCell45 = xRTableCell2;
            XRTableCell xRTableCell46 = xRTableCell31;
            XRTableCell xRTableCell47 = xRTableCell3;
            float num2 = xRTableCell47.WidthF = 30f;
            float num4 = xRTableCell46.WidthF = num2;
            float num7 = xRTableCell44.WidthF = (xRTableCell45.WidthF = num4);
            XRTableCell xRTableCell48 = xRTableCell29;
            XRTableCell xRTableCell49 = xRTableCell;
            num7 = (xRTableCell48.WidthF = (xRTableCell49.WidthF = 160f));
            XRTableCell xRTableCell50 = xRTableCell33;
            XRTableCell xRTableCell51 = xRTableCell5;
            num7 = (xRTableCell50.WidthF = (xRTableCell51.WidthF = 50f));
            XRTableCell xRTableCell52 = xRTableCell32;
            XRTableCell xRTableCell53 = xRTableCell4;
            num7 = (xRTableCell52.WidthF = (xRTableCell53.WidthF = 60f));
            XRTableCell xRTableCell54 = xRTableCell29;
            XRTableCell xRTableCell55 = xRTableCell30;
            XRTableCell xRTableCell56 = xRTableCell31;
            XRTableCell xRTableCell57 = xRTableCell32;
            XRTableCell xRTableCell58 = xRTableCell33;
            font2 = (xRTableCell58.Font = new Font("Calibri", 14f));
            font4 = (xRTableCell57.Font = font2);
            font6 = (xRTableCell56.Font = font4);
            font9 = (xRTableCell54.Font = (xRTableCell55.Font = font6));
            XRTableCell xRTableCell59 = xRTableCell29;
            XRTableCell xRTableCell60 = xRTableCell30;
            XRTableCell xRTableCell61 = xRTableCell31;
            XRTableCell xRTableCell62 = xRTableCell32;
            XRTableCell xRTableCell63 = xRTableCell33;
            textAlignment2 = (xRTableCell63.TextAlignment = TextAlignment.TopLeft);
            textAlignment4 = (xRTableCell62.TextAlignment = textAlignment2);
            textAlignment6 = (xRTableCell61.TextAlignment = textAlignment4);
            textAlignment9 = (xRTableCell59.TextAlignment = (xRTableCell60.TextAlignment = textAlignment6));
            if (i % 2 == 0)
            {
                XRTableCell xRTableCell64 = xRTableCell29;
                XRTableCell xRTableCell65 = xRTableCell30;
                XRTableCell xRTableCell66 = xRTableCell31;
                XRTableCell xRTableCell67 = xRTableCell32;
                XRTableCell xRTableCell68 = xRTableCell33;
                color2 = (xRTableCell68.BackColor = Color.FromArgb(255, 255, 255));
                color4 = (xRTableCell67.BackColor = color2);
                color6 = (xRTableCell66.BackColor = color4);
                color9 = (xRTableCell64.BackColor = (xRTableCell65.BackColor = color6));
            }
            else
            {
                XRTableCell xRTableCell69 = xRTableCell29;
                XRTableCell xRTableCell70 = xRTableCell30;
                XRTableCell xRTableCell71 = xRTableCell31;
                XRTableCell xRTableCell72 = xRTableCell32;
                XRTableCell xRTableCell73 = xRTableCell33;
                color2 = (xRTableCell73.BackColor = Color.FromArgb(234, 234, 234));
                color4 = (xRTableCell72.BackColor = color2);
                color6 = (xRTableCell71.BackColor = color4);
                color9 = (xRTableCell69.BackColor = (xRTableCell70.BackColor = color6));
            }
            if (i < products.Rows.Count - 1)
            {
                xRTableCell29.Text = ((products.Rows[i].Cells["description"].Value == null) ? " " : products.Rows[i].Cells["description"].Value.ToString());
                xRTableCell30.Text = products.Rows[i].Cells["price"].Value.ToString();
                xRTableCell31.Text = products.Rows[i].Cells["quantity"].Value.ToString();
                xRTableCell32.Text = ((products.Rows[i].Cells["note"].Value == null) ? " " : products.Rows[i].Cells["note"].Value.ToString());
                xRTableCell33.Text = double.Parse(products.Rows[i].Cells["total"].Value.ToString()).ToString(this.isDollar ? "#.##" : "#,###");
            }
            else
            {
                XRTableCell xRTableCell74 = xRTableCell29;
                XRTableCell xRTableCell75 = xRTableCell30;
                XRTableCell xRTableCell76 = xRTableCell31;
                XRTableCell xRTableCell77 = xRTableCell32;
                XRTableCell xRTableCell78 = xRTableCell33;
                string text2 = xRTableCell78.Text = "--";
                string text4 = xRTableCell77.Text = text2;
                string text6 = xRTableCell76.Text = text4;
                string text9 = xRTableCell74.Text = (xRTableCell75.Text = text6);
            }
            xRTableRow2.Cells.Add(xRTableCell29);
            xRTableRow2.Cells.Add(xRTableCell30);
            xRTableRow2.Cells.Add(xRTableCell31);
            xRTableRow2.Cells.Add(xRTableCell32);
            xRTableRow2.Cells.Add(xRTableCell33);
            xRTable.Rows.Add(xRTableRow2);
        }
        xRTable.EndInit();
        return xRTable;
    }

    private void Detail_BeforePrint(object sender, PrintEventArgs e)
    {
        this.Detail.Controls.Add(this.table(this.dgvProducts));
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && this.components != null)
        {
            this.components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ReportA4Ar));
        this.Detail = new DetailBand();
        this.TopMargin = new TopMarginBand();
        this.lblBillId = new XRLabel();
        this.xrLabel9 = new XRLabel();
        this.xrLine2 = new XRLine();
        this.lblClientAddress = new XRLabel();
        this.xrLabel35 = new XRLabel();
        this.lblClientInfo = new XRLabel();
        this.xrLabel28 = new XRLabel();
        this.lblClientName = new XRLabel();
        this.xrLabel30 = new XRLabel();
        this.lblClientMobile = new XRLabel();
        this.lblClientEmail = new XRLabel();
        this.xrLabel33 = new XRLabel();
        this.xrLabel11 = new XRLabel();
        this.lblClientId = new XRLabel();
        this.lblDateTo = new XRLabel();
        this.xrLabel10 = new XRLabel();
        this.lblDateFrom = new XRLabel();
        this.xrLabel7 = new XRLabel();
        this.lblBillInfo = new XRLabel();
        this.lblEmail = new XRLabel();
        this.lblPhone = new XRLabel();
        this.lblFacebook = new XRLabel();
        this.lblAddress = new XRLabel();
        this.picMain = new XRPictureBox();
        this.billType = new XRLabel();
        this.BottomMargin = new BottomMarginBand();
        this.lblRemainingTitle = new XRLabel();
        this.lblRemaining = new XRLabel();
        this.lblReceive = new XRLabel();
        this.lblReceiveTtile = new XRLabel();
        this.lblTotalText = new XRLabel();
        this.lblSubTotalSign = new XRLabel();
        this.txtAccount = new XRLabel();
        this.lblAccount = new XRLabel();
        this.txtNote = new XRLabel();
        this.xrLine1 = new XRLine();
        this.lblFirstTotalTitle = new XRLabel();
        this.lblFirstTotal = new XRLabel();
        this.lblSaleTotal = new XRLabel();
        this.lblDiscount = new XRLabel();
        this.lblTotal = new XRLabel();
        this.lblFinalTotalTitle = new XRLabel();
        this.xrLabel18 = new XRLabel();
        this.xrLabel17 = new XRLabel();
        this.lblConditions = new XRLabel();
        this.xrLabel15 = new XRLabel();
        this.xrLabel13 = new XRLabel();
        ((ISupportInitialize)this).BeginInit();
        this.Detail.HeightF = 100f;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
        this.Detail.TextAlignment = TextAlignment.TopLeft;
        this.Detail.BeforePrint += this.Detail_BeforePrint;
        this.TopMargin.Controls.AddRange(new XRControl[25]
        {
            this.lblBillId,
            this.xrLabel9,
            this.xrLine2,
            this.lblClientAddress,
            this.xrLabel35,
            this.lblClientInfo,
            this.xrLabel28,
            this.lblClientName,
            this.xrLabel30,
            this.lblClientMobile,
            this.lblClientEmail,
            this.xrLabel33,
            this.xrLabel11,
            this.lblClientId,
            this.lblDateTo,
            this.xrLabel10,
            this.lblDateFrom,
            this.xrLabel7,
            this.lblBillInfo,
            this.lblEmail,
            this.lblPhone,
            this.lblFacebook,
            this.lblAddress,
            this.picMain,
            this.billType
        });
        this.TopMargin.HeightF = 290f;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
        this.TopMargin.TextAlignment = TextAlignment.TopLeft;
        this.lblBillId.AnchorHorizontal = HorizontalAnchorStyles.Right;
        this.lblBillId.AnchorVertical = VerticalAnchorStyles.Top;
        this.lblBillId.BackColor = Color.White;
        this.lblBillId.Borders = BorderSide.All;
        this.lblBillId.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblBillId.LocationFloat = new PointFloat(527.4999f, 104.0001f);
        this.lblBillId.Name = "lblBillId";
        this.lblBillId.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblBillId.SizeF = new SizeF(196.7917f, 23f);
        this.lblBillId.StylePriority.UseBackColor = false;
        this.lblBillId.StylePriority.UseBorders = false;
        this.lblBillId.StylePriority.UseFont = false;
        this.lblBillId.StylePriority.UseTextAlignment = false;
        this.lblBillId.Text = "QUOTE";
        this.lblBillId.TextAlignment = TextAlignment.MiddleLeft;
        this.xrLabel9.BackColor = Color.FromArgb(224, 224, 224);
        this.xrLabel9.Borders = BorderSide.All;
        this.xrLabel9.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.xrLabel9.LocationFloat = new PointFloat(418.1249f, 104.0001f);
        this.xrLabel9.Multiline = true;
        this.xrLabel9.Name = "xrLabel9";
        this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.xrLabel9.SizeF = new SizeF(109.3749f, 23f);
        this.xrLabel9.StylePriority.UseBackColor = false;
        this.xrLabel9.StylePriority.UseBorders = false;
        this.xrLabel9.StylePriority.UseFont = false;
        this.xrLabel9.StylePriority.UseTextAlignment = false;
        this.xrLabel9.Text = "رقم القائمة";
        this.xrLabel9.TextAlignment = TextAlignment.MiddleCenter;
        this.xrLine2.AnchorHorizontal = HorizontalAnchorStyles.Both;
        this.xrLine2.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.xrLine2.LocationFloat = new PointFloat(1.589457E-05f, 267f);
        this.xrLine2.Name = "xrLine2";
        this.xrLine2.SizeF = new SizeF(727f, 23f);
        this.lblClientAddress.AnchorHorizontal = HorizontalAnchorStyles.Right;
        this.lblClientAddress.AnchorVertical = VerticalAnchorStyles.Top;
        this.lblClientAddress.BackColor = Color.White;
        this.lblClientAddress.Borders = BorderSide.All;
        this.lblClientAddress.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblClientAddress.LocationFloat = new PointFloat(527.4998f, 244f);
        this.lblClientAddress.Name = "lblClientAddress";
        this.lblClientAddress.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblClientAddress.SizeF = new SizeF(196.7917f, 23.00002f);
        this.lblClientAddress.StylePriority.UseBackColor = false;
        this.lblClientAddress.StylePriority.UseBorders = false;
        this.lblClientAddress.StylePriority.UseFont = false;
        this.lblClientAddress.StylePriority.UseTextAlignment = false;
        this.lblClientAddress.Text = "QUOTE";
        this.lblClientAddress.TextAlignment = TextAlignment.MiddleLeft;
        this.xrLabel35.AnchorHorizontal = HorizontalAnchorStyles.Right;
        this.xrLabel35.AnchorVertical = VerticalAnchorStyles.Top;
        this.xrLabel35.BackColor = Color.FromArgb(224, 224, 224);
        this.xrLabel35.Borders = BorderSide.All;
        this.xrLabel35.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.xrLabel35.LocationFloat = new PointFloat(418.1249f, 244f);
        this.xrLabel35.Name = "xrLabel35";
        this.xrLabel35.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.xrLabel35.SizeF = new SizeF(109.3749f, 23.00002f);
        this.xrLabel35.StylePriority.UseBackColor = false;
        this.xrLabel35.StylePriority.UseBorders = false;
        this.xrLabel35.StylePriority.UseFont = false;
        this.xrLabel35.StylePriority.UseTextAlignment = false;
        this.xrLabel35.Text = "العنوان";
        this.xrLabel35.TextAlignment = TextAlignment.MiddleCenter;
        this.lblClientInfo.AnchorHorizontal = HorizontalAnchorStyles.Right;
        this.lblClientInfo.AnchorVertical = VerticalAnchorStyles.Top;
        this.lblClientInfo.BackColor = Color.FromArgb(208, 158, 0);
        this.lblClientInfo.Borders = BorderSide.All;
        this.lblClientInfo.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblClientInfo.LocationFloat = new PointFloat(418.1249f, 152f);
        this.lblClientInfo.Name = "lblClientInfo";
        this.lblClientInfo.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblClientInfo.SizeF = new SizeF(306.1667f, 23f);
        this.lblClientInfo.StylePriority.UseBackColor = false;
        this.lblClientInfo.StylePriority.UseBorders = false;
        this.lblClientInfo.StylePriority.UseFont = false;
        this.lblClientInfo.StylePriority.UseTextAlignment = false;
        this.lblClientInfo.Text = "CLIENT INFORMATION";
        this.lblClientInfo.TextAlignment = TextAlignment.MiddleCenter;
        this.xrLabel28.AnchorHorizontal = HorizontalAnchorStyles.Right;
        this.xrLabel28.AnchorVertical = VerticalAnchorStyles.Top;
        this.xrLabel28.BackColor = Color.FromArgb(224, 224, 224);
        this.xrLabel28.Borders = BorderSide.All;
        this.xrLabel28.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.xrLabel28.LocationFloat = new PointFloat(418.1249f, 175f);
        this.xrLabel28.Name = "xrLabel28";
        this.xrLabel28.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.xrLabel28.SizeF = new SizeF(109.3749f, 23f);
        this.xrLabel28.StylePriority.UseBackColor = false;
        this.xrLabel28.StylePriority.UseBorders = false;
        this.xrLabel28.StylePriority.UseFont = false;
        this.xrLabel28.StylePriority.UseTextAlignment = false;
        this.xrLabel28.Text = "الى";
        this.xrLabel28.TextAlignment = TextAlignment.MiddleCenter;
        this.lblClientName.AnchorHorizontal = HorizontalAnchorStyles.Right;
        this.lblClientName.AnchorVertical = VerticalAnchorStyles.Top;
        this.lblClientName.BackColor = Color.White;
        this.lblClientName.Borders = BorderSide.All;
        this.lblClientName.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblClientName.LocationFloat = new PointFloat(527.4998f, 175f);
        this.lblClientName.Name = "lblClientName";
        this.lblClientName.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblClientName.SizeF = new SizeF(196.7919f, 23f);
        this.lblClientName.StylePriority.UseBackColor = false;
        this.lblClientName.StylePriority.UseBorders = false;
        this.lblClientName.StylePriority.UseFont = false;
        this.lblClientName.StylePriority.UseTextAlignment = false;
        this.lblClientName.Text = "QUOTE";
        this.lblClientName.TextAlignment = TextAlignment.MiddleLeft;
        this.xrLabel30.BackColor = Color.FromArgb(224, 224, 224);
        this.xrLabel30.Borders = BorderSide.All;
        this.xrLabel30.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.xrLabel30.LocationFloat = new PointFloat(418.1249f, 198f);
        this.xrLabel30.Multiline = true;
        this.xrLabel30.Name = "xrLabel30";
        this.xrLabel30.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.xrLabel30.SizeF = new SizeF(109.3749f, 23f);
        this.xrLabel30.StylePriority.UseBackColor = false;
        this.xrLabel30.StylePriority.UseBorders = false;
        this.xrLabel30.StylePriority.UseFont = false;
        this.xrLabel30.StylePriority.UseTextAlignment = false;
        this.xrLabel30.Text = "الموبايل";
        this.xrLabel30.TextAlignment = TextAlignment.MiddleCenter;
        this.lblClientMobile.AnchorHorizontal = HorizontalAnchorStyles.Right;
        this.lblClientMobile.AnchorVertical = VerticalAnchorStyles.Top;
        this.lblClientMobile.BackColor = Color.White;
        this.lblClientMobile.Borders = BorderSide.All;
        this.lblClientMobile.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblClientMobile.LocationFloat = new PointFloat(527.4998f, 198f);
        this.lblClientMobile.Name = "lblClientMobile";
        this.lblClientMobile.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblClientMobile.SizeF = new SizeF(196.7917f, 23f);
        this.lblClientMobile.StylePriority.UseBackColor = false;
        this.lblClientMobile.StylePriority.UseBorders = false;
        this.lblClientMobile.StylePriority.UseFont = false;
        this.lblClientMobile.StylePriority.UseTextAlignment = false;
        this.lblClientMobile.Text = "QUOTE";
        this.lblClientMobile.TextAlignment = TextAlignment.MiddleLeft;
        this.lblClientEmail.AnchorHorizontal = HorizontalAnchorStyles.Right;
        this.lblClientEmail.AnchorVertical = VerticalAnchorStyles.Top;
        this.lblClientEmail.BackColor = Color.White;
        this.lblClientEmail.Borders = BorderSide.All;
        this.lblClientEmail.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblClientEmail.LocationFloat = new PointFloat(527.4998f, 221f);
        this.lblClientEmail.Name = "lblClientEmail";
        this.lblClientEmail.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblClientEmail.SizeF = new SizeF(196.7917f, 23f);
        this.lblClientEmail.StylePriority.UseBackColor = false;
        this.lblClientEmail.StylePriority.UseBorders = false;
        this.lblClientEmail.StylePriority.UseFont = false;
        this.lblClientEmail.StylePriority.UseTextAlignment = false;
        this.lblClientEmail.Text = "QUOTE";
        this.lblClientEmail.TextAlignment = TextAlignment.MiddleLeft;
        this.xrLabel33.AnchorHorizontal = HorizontalAnchorStyles.Right;
        this.xrLabel33.AnchorVertical = VerticalAnchorStyles.Top;
        this.xrLabel33.BackColor = Color.FromArgb(224, 224, 224);
        this.xrLabel33.Borders = BorderSide.All;
        this.xrLabel33.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.xrLabel33.LocationFloat = new PointFloat(418.1249f, 221f);
        this.xrLabel33.Name = "xrLabel33";
        this.xrLabel33.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.xrLabel33.SizeF = new SizeF(109.3749f, 23f);
        this.xrLabel33.StylePriority.UseBackColor = false;
        this.xrLabel33.StylePriority.UseBorders = false;
        this.xrLabel33.StylePriority.UseFont = false;
        this.xrLabel33.StylePriority.UseTextAlignment = false;
        this.xrLabel33.Text = "البريد الالكتروني";
        this.xrLabel33.TextAlignment = TextAlignment.MiddleCenter;
        this.xrLabel11.AnchorHorizontal = HorizontalAnchorStyles.Right;
        this.xrLabel11.AnchorVertical = VerticalAnchorStyles.Top;
        this.xrLabel11.BackColor = Color.FromArgb(224, 224, 224);
        this.xrLabel11.Borders = BorderSide.All;
        this.xrLabel11.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.xrLabel11.LocationFloat = new PointFloat(418.1249f, 127.0001f);
        this.xrLabel11.Name = "xrLabel11";
        this.xrLabel11.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.xrLabel11.SizeF = new SizeF(109.3749f, 22.99998f);
        this.xrLabel11.StylePriority.UseBackColor = false;
        this.xrLabel11.StylePriority.UseBorders = false;
        this.xrLabel11.StylePriority.UseFont = false;
        this.xrLabel11.StylePriority.UseTextAlignment = false;
        this.xrLabel11.Text = "تسلسل العميل";
        this.xrLabel11.TextAlignment = TextAlignment.MiddleCenter;
        this.lblClientId.AnchorHorizontal = HorizontalAnchorStyles.Right;
        this.lblClientId.AnchorVertical = VerticalAnchorStyles.Top;
        this.lblClientId.BackColor = Color.White;
        this.lblClientId.Borders = BorderSide.All;
        this.lblClientId.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblClientId.LocationFloat = new PointFloat(527.4998f, 127.0001f);
        this.lblClientId.Name = "lblClientId";
        this.lblClientId.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblClientId.SizeF = new SizeF(196.7917f, 22.99998f);
        this.lblClientId.StylePriority.UseBackColor = false;
        this.lblClientId.StylePriority.UseBorders = false;
        this.lblClientId.StylePriority.UseFont = false;
        this.lblClientId.StylePriority.UseTextAlignment = false;
        this.lblClientId.Text = "QUOTE";
        this.lblClientId.TextAlignment = TextAlignment.MiddleLeft;
        this.lblDateTo.AnchorHorizontal = HorizontalAnchorStyles.Right;
        this.lblDateTo.AnchorVertical = VerticalAnchorStyles.Top;
        this.lblDateTo.BackColor = Color.White;
        this.lblDateTo.Borders = BorderSide.All;
        this.lblDateTo.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblDateTo.LocationFloat = new PointFloat(527.4998f, 81.00008f);
        this.lblDateTo.Name = "lblDateTo";
        this.lblDateTo.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblDateTo.SizeF = new SizeF(196.7917f, 23f);
        this.lblDateTo.StylePriority.UseBackColor = false;
        this.lblDateTo.StylePriority.UseBorders = false;
        this.lblDateTo.StylePriority.UseFont = false;
        this.lblDateTo.StylePriority.UseTextAlignment = false;
        this.lblDateTo.Text = "QUOTE";
        this.lblDateTo.TextAlignment = TextAlignment.MiddleLeft;
        this.xrLabel10.BackColor = Color.FromArgb(224, 224, 224);
        this.xrLabel10.Borders = BorderSide.All;
        this.xrLabel10.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.xrLabel10.LocationFloat = new PointFloat(418.1249f, 81.00008f);
        this.xrLabel10.Multiline = true;
        this.xrLabel10.Name = "xrLabel10";
        this.xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.xrLabel10.SizeF = new SizeF(109.3749f, 23f);
        this.xrLabel10.StylePriority.UseBackColor = false;
        this.xrLabel10.StylePriority.UseBorders = false;
        this.xrLabel10.StylePriority.UseFont = false;
        this.xrLabel10.StylePriority.UseTextAlignment = false;
        this.xrLabel10.Text = "تاريخ الصلاحية";
        this.xrLabel10.TextAlignment = TextAlignment.MiddleCenter;
        this.lblDateFrom.AnchorHorizontal = HorizontalAnchorStyles.Right;
        this.lblDateFrom.AnchorVertical = VerticalAnchorStyles.Top;
        this.lblDateFrom.BackColor = Color.White;
        this.lblDateFrom.Borders = BorderSide.All;
        this.lblDateFrom.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblDateFrom.LocationFloat = new PointFloat(527.4998f, 58.00009f);
        this.lblDateFrom.Name = "lblDateFrom";
        this.lblDateFrom.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblDateFrom.SizeF = new SizeF(196.7918f, 23f);
        this.lblDateFrom.StylePriority.UseBackColor = false;
        this.lblDateFrom.StylePriority.UseBorders = false;
        this.lblDateFrom.StylePriority.UseFont = false;
        this.lblDateFrom.StylePriority.UseTextAlignment = false;
        this.lblDateFrom.Text = "QUOTE";
        this.lblDateFrom.TextAlignment = TextAlignment.MiddleLeft;
        this.xrLabel7.AnchorHorizontal = HorizontalAnchorStyles.Right;
        this.xrLabel7.AnchorVertical = VerticalAnchorStyles.Top;
        this.xrLabel7.BackColor = Color.FromArgb(224, 224, 224);
        this.xrLabel7.Borders = BorderSide.All;
        this.xrLabel7.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.xrLabel7.LocationFloat = new PointFloat(418.1249f, 58.00009f);
        this.xrLabel7.Name = "xrLabel7";
        this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.xrLabel7.SizeF = new SizeF(109.3749f, 23f);
        this.xrLabel7.StylePriority.UseBackColor = false;
        this.xrLabel7.StylePriority.UseBorders = false;
        this.xrLabel7.StylePriority.UseFont = false;
        this.xrLabel7.StylePriority.UseTextAlignment = false;
        this.xrLabel7.Text = "تاريخ";
        this.xrLabel7.TextAlignment = TextAlignment.MiddleCenter;
        this.lblBillInfo.AnchorHorizontal = HorizontalAnchorStyles.Right;
        this.lblBillInfo.AnchorVertical = VerticalAnchorStyles.Top;
        this.lblBillInfo.BackColor = Color.FromArgb(208, 158, 0);
        this.lblBillInfo.Borders = BorderSide.All;
        this.lblBillInfo.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblBillInfo.LocationFloat = new PointFloat(418.1249f, 35.00007f);
        this.lblBillInfo.Name = "lblBillInfo";
        this.lblBillInfo.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblBillInfo.SizeF = new SizeF(306.1667f, 23f);
        this.lblBillInfo.StylePriority.UseBackColor = false;
        this.lblBillInfo.StylePriority.UseBorders = false;
        this.lblBillInfo.StylePriority.UseFont = false;
        this.lblBillInfo.StylePriority.UseTextAlignment = false;
        this.lblBillInfo.Text = "BILL INFORMATION";
        this.lblBillInfo.TextAlignment = TextAlignment.MiddleCenter;
        this.lblEmail.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblEmail.LocationFloat = new PointFloat(10.00001f, 175f);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblEmail.SizeF = new SizeF(254.1667f, 23f);
        this.lblEmail.StylePriority.UseFont = false;
        this.lblEmail.Text = "Email: maryam@gmail.com";
        this.lblPhone.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblPhone.LocationFloat = new PointFloat(10.00001f, 150.0001f);
        this.lblPhone.Name = "lblPhone";
        this.lblPhone.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblPhone.SizeF = new SizeF(241.6667f, 23f);
        this.lblPhone.StylePriority.UseFont = false;
        this.lblPhone.Text = "Phone: +964 750 111 2222";
        this.lblFacebook.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblFacebook.LocationFloat = new PointFloat(10.00001f, 127.0001f);
        this.lblFacebook.Name = "lblFacebook";
        this.lblFacebook.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblFacebook.SizeF = new SizeF(193.75f, 23f);
        this.lblFacebook.StylePriority.UseFont = false;
        this.lblFacebook.Text = "fb.com/maryam";
        this.lblAddress.Font = new Font("Calibri", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.lblAddress.LocationFloat = new PointFloat(10.00001f, 104.0001f);
        this.lblAddress.Name = "lblAddress";
        this.lblAddress.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblAddress.SizeF = new SizeF(207.2584f, 23f);
        this.lblAddress.StylePriority.UseFont = false;
        this.lblAddress.Text = "Duhok";
        this.picMain.Image = (Image)componentResourceManager.GetObject("picMain.Image");
        this.picMain.LocationFloat = new PointFloat(0f, 10.00001f);
        this.picMain.Name = "picMain";
        this.picMain.SizeF = new SizeF(217.2583f, 94.00007f);
        this.picMain.Sizing = ImageSizeMode.ZoomImage;
        this.billType.BorderColor = Color.Black;
        this.billType.Font = new Font("Times New Roman", 21.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
        this.billType.ForeColor = Color.Maroon;
        this.billType.LocationFloat = new PointFloat(10.00001f, 221f);
        this.billType.Name = "billType";
        this.billType.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.billType.SizeF = new SizeF(254.1667f, 46f);
        this.billType.StylePriority.UseBorderColor = false;
        this.billType.StylePriority.UseFont = false;
        this.billType.StylePriority.UseForeColor = false;
        this.billType.StylePriority.UseTextAlignment = false;
        this.billType.Text = "صادر";
        this.billType.TextAlignment = TextAlignment.MiddleLeft;
        this.billType.Visible = false;
        this.BottomMargin.Controls.AddRange(new XRControl[21]
        {
            this.lblRemainingTitle,
            this.lblRemaining,
            this.lblReceive,
            this.lblReceiveTtile,
            this.lblTotalText,
            this.lblSubTotalSign,
            this.txtAccount,
            this.lblAccount,
            this.txtNote,
            this.xrLine1,
            this.lblFirstTotalTitle,
            this.lblFirstTotal,
            this.lblSaleTotal,
            this.lblDiscount,
            this.lblTotal,
            this.lblFinalTotalTitle,
            this.xrLabel18,
            this.xrLabel17,
            this.lblConditions,
            this.xrLabel15,
            this.xrLabel13
        });
        this.BottomMargin.HeightF = 249.875f;
        this.BottomMargin.Name = "BottomMargin";
        this.BottomMargin.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
        this.BottomMargin.TextAlignment = TextAlignment.TopLeft;
        this.lblRemainingTitle.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.lblRemainingTitle.BackColor = Color.FromArgb(208, 158, 0);
        this.lblRemainingTitle.Borders = BorderSide.All;
        this.lblRemainingTitle.CanGrow = false;
        this.lblRemainingTitle.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblRemainingTitle.LocationFloat = new PointFloat(495.0416f, 141.7294f);
        this.lblRemainingTitle.Name = "lblRemainingTitle";
        this.lblRemainingTitle.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblRemainingTitle.SizeF = new SizeF(87.58353f, 23f);
        this.lblRemainingTitle.StylePriority.UseBackColor = false;
        this.lblRemainingTitle.StylePriority.UseBorders = false;
        this.lblRemainingTitle.StylePriority.UseFont = false;
        this.lblRemainingTitle.StylePriority.UseTextAlignment = false;
        this.lblRemainingTitle.Text = "المتبقي";
        this.lblRemainingTitle.TextAlignment = TextAlignment.MiddleCenter;
        this.lblRemaining.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.lblRemaining.Borders = BorderSide.All;
        this.lblRemaining.CanGrow = false;
        this.lblRemaining.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.lblRemaining.LocationFloat = new PointFloat(582.6249f, 141.7294f);
        this.lblRemaining.Name = "lblRemaining";
        this.lblRemaining.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblRemaining.SizeF = new SizeF(130.8333f, 23f);
        this.lblRemaining.StylePriority.UseBorders = false;
        this.lblRemaining.StylePriority.UseFont = false;
        this.lblRemaining.StylePriority.UseTextAlignment = false;
        this.lblRemaining.Text = "10000";
        this.lblRemaining.TextAlignment = TextAlignment.MiddleCenter;
        this.lblReceive.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.lblReceive.Borders = BorderSide.All;
        this.lblReceive.CanGrow = false;
        this.lblReceive.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.lblReceive.LocationFloat = new PointFloat(582.6247f, 118.7294f);
        this.lblReceive.Name = "lblReceive";
        this.lblReceive.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblReceive.SizeF = new SizeF(130.8333f, 23f);
        this.lblReceive.StylePriority.UseBorders = false;
        this.lblReceive.StylePriority.UseFont = false;
        this.lblReceive.StylePriority.UseTextAlignment = false;
        this.lblReceive.Text = "10000";
        this.lblReceive.TextAlignment = TextAlignment.MiddleCenter;
        this.lblReceiveTtile.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.lblReceiveTtile.BackColor = Color.FromArgb(208, 158, 0);
        this.lblReceiveTtile.Borders = BorderSide.All;
        this.lblReceiveTtile.CanGrow = false;
        this.lblReceiveTtile.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblReceiveTtile.LocationFloat = new PointFloat(495.0416f, 118.7294f);
        this.lblReceiveTtile.Name = "lblReceiveTtile";
        this.lblReceiveTtile.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblReceiveTtile.SizeF = new SizeF(87.58328f, 23f);
        this.lblReceiveTtile.StylePriority.UseBackColor = false;
        this.lblReceiveTtile.StylePriority.UseBorders = false;
        this.lblReceiveTtile.StylePriority.UseFont = false;
        this.lblReceiveTtile.StylePriority.UseTextAlignment = false;
        this.lblReceiveTtile.Text = "المستلم";
        this.lblReceiveTtile.TextAlignment = TextAlignment.MiddleCenter;
        this.lblTotalText.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.lblTotalText.Borders = BorderSide.All;
        this.lblTotalText.CanGrow = false;
        this.lblTotalText.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.lblTotalText.LocationFloat = new PointFloat(3.973642E-05f, 201.75f);
        this.lblTotalText.Name = "lblTotalText";
        this.lblTotalText.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblTotalText.SizeF = new SizeF(727f, 22.99998f);
        this.lblTotalText.StylePriority.UseBorders = false;
        this.lblTotalText.StylePriority.UseFont = false;
        this.lblTotalText.StylePriority.UseTextAlignment = false;
        this.lblTotalText.Text = "Ten thounds";
        this.lblTotalText.TextAlignment = TextAlignment.MiddleCenter;
        this.lblTotalText.Visible = false;
        this.lblSubTotalSign.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.lblSubTotalSign.Borders = BorderSide.All;
        this.lblSubTotalSign.CanGrow = false;
        this.lblSubTotalSign.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblSubTotalSign.LocationFloat = new PointFloat(660.9584f, 23.00002f);
        this.lblSubTotalSign.Name = "lblSubTotalSign";
        this.lblSubTotalSign.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblSubTotalSign.SizeF = new SizeF(52.49988f, 22.99999f);
        this.lblSubTotalSign.StylePriority.UseBorders = false;
        this.lblSubTotalSign.StylePriority.UseFont = false;
        this.lblSubTotalSign.StylePriority.UseTextAlignment = false;
        this.lblSubTotalSign.Text = "IQD";
        this.lblSubTotalSign.TextAlignment = TextAlignment.MiddleCenter;
        this.txtAccount.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.txtAccount.Borders = BorderSide.All;
        this.txtAccount.CanGrow = false;
        this.txtAccount.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.txtAccount.LocationFloat = new PointFloat(582.6248f, 23.00002f);
        this.txtAccount.Name = "txtAccount";
        this.txtAccount.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.txtAccount.SizeF = new SizeF(78.33356f, 23f);
        this.txtAccount.StylePriority.UseBorders = false;
        this.txtAccount.StylePriority.UseFont = false;
        this.txtAccount.StylePriority.UseTextAlignment = false;
        this.txtAccount.Text = "Cash";
        this.txtAccount.TextAlignment = TextAlignment.MiddleCenter;
        this.lblAccount.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.lblAccount.BackColor = Color.FromArgb(208, 158, 0);
        this.lblAccount.Borders = BorderSide.All;
        this.lblAccount.CanGrow = false;
        this.lblAccount.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblAccount.LocationFloat = new PointFloat(494.208f, 23.00002f);
        this.lblAccount.Name = "lblAccount";
        this.lblAccount.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblAccount.SizeF = new SizeF(88.4166f, 23f);
        this.lblAccount.StylePriority.UseBackColor = false;
        this.lblAccount.StylePriority.UseBorders = false;
        this.lblAccount.StylePriority.UseFont = false;
        this.lblAccount.StylePriority.UseTextAlignment = false;
        this.lblAccount.Text = "الحساب";
        this.lblAccount.TextAlignment = TextAlignment.MiddleCenter;
        this.txtNote.LocationFloat = new PointFloat(0f, 46.00003f);
        this.txtNote.Multiline = true;
        this.txtNote.Name = "txtNote";
        this.txtNote.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.txtNote.SizeF = new SizeF(264.1667f, 41.74996f);
        this.txtNote.StylePriority.UseTextAlignment = false;
        this.txtNote.TextAlignment = TextAlignment.TopRight;
        this.xrLine1.AnchorHorizontal = HorizontalAnchorStyles.Both;
        this.xrLine1.AnchorVertical = VerticalAnchorStyles.Top;
        this.xrLine1.LocationFloat = new PointFloat(0f, 0f);
        this.xrLine1.Name = "xrLine1";
        this.xrLine1.SizeF = new SizeF(724.2915f, 23f);
        this.lblFirstTotalTitle.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.lblFirstTotalTitle.BackColor = Color.FromArgb(208, 158, 0);
        this.lblFirstTotalTitle.Borders = BorderSide.All;
        this.lblFirstTotalTitle.CanGrow = false;
        this.lblFirstTotalTitle.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblFirstTotalTitle.LocationFloat = new PointFloat(495.1247f, 46.0001f);
        this.lblFirstTotalTitle.Name = "lblFirstTotalTitle";
        this.lblFirstTotalTitle.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblFirstTotalTitle.SizeF = new SizeF(87.49991f, 23f);
        this.lblFirstTotalTitle.StylePriority.UseBackColor = false;
        this.lblFirstTotalTitle.StylePriority.UseBorders = false;
        this.lblFirstTotalTitle.StylePriority.UseFont = false;
        this.lblFirstTotalTitle.StylePriority.UseTextAlignment = false;
        this.lblFirstTotalTitle.Text = "المجموع الاولي";
        this.lblFirstTotalTitle.TextAlignment = TextAlignment.MiddleCenter;
        this.lblFirstTotal.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.lblFirstTotal.Borders = BorderSide.All;
        this.lblFirstTotal.CanGrow = false;
        this.lblFirstTotal.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.lblFirstTotal.LocationFloat = new PointFloat(582.6248f, 46.00003f);
        this.lblFirstTotal.Name = "lblFirstTotal";
        this.lblFirstTotal.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblFirstTotal.SizeF = new SizeF(130.8332f, 23f);
        this.lblFirstTotal.StylePriority.UseBorders = false;
        this.lblFirstTotal.StylePriority.UseFont = false;
        this.lblFirstTotal.StylePriority.UseTextAlignment = false;
        this.lblFirstTotal.Text = "10000";
        this.lblFirstTotal.TextAlignment = TextAlignment.MiddleCenter;
        this.lblSaleTotal.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.lblSaleTotal.BackColor = Color.FromArgb(208, 158, 0);
        this.lblSaleTotal.Borders = BorderSide.All;
        this.lblSaleTotal.CanGrow = false;
        this.lblSaleTotal.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblSaleTotal.LocationFloat = new PointFloat(495.0417f, 69.00005f);
        this.lblSaleTotal.Name = "lblSaleTotal";
        this.lblSaleTotal.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblSaleTotal.SizeF = new SizeF(87.58347f, 23f);
        this.lblSaleTotal.StylePriority.UseBackColor = false;
        this.lblSaleTotal.StylePriority.UseBorders = false;
        this.lblSaleTotal.StylePriority.UseFont = false;
        this.lblSaleTotal.StylePriority.UseTextAlignment = false;
        this.lblSaleTotal.Text = "الخصم";
        this.lblSaleTotal.TextAlignment = TextAlignment.MiddleCenter;
        this.lblDiscount.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.lblDiscount.Borders = BorderSide.All;
        this.lblDiscount.CanGrow = false;
        this.lblDiscount.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.lblDiscount.LocationFloat = new PointFloat(582.6248f, 69.00005f);
        this.lblDiscount.Name = "lblDiscount";
        this.lblDiscount.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblDiscount.SizeF = new SizeF(130.8332f, 23.00001f);
        this.lblDiscount.StylePriority.UseBorders = false;
        this.lblDiscount.StylePriority.UseFont = false;
        this.lblDiscount.StylePriority.UseTextAlignment = false;
        this.lblDiscount.Text = "10000";
        this.lblDiscount.TextAlignment = TextAlignment.MiddleCenter;
        this.lblTotal.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.lblTotal.Borders = BorderSide.All;
        this.lblTotal.CanGrow = false;
        this.lblTotal.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
        this.lblTotal.LocationFloat = new PointFloat(582.6246f, 92.00007f);
        this.lblTotal.Name = "lblTotal";
        this.lblTotal.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblTotal.SizeF = new SizeF(130.8333f, 23f);
        this.lblTotal.StylePriority.UseBorders = false;
        this.lblTotal.StylePriority.UseFont = false;
        this.lblTotal.StylePriority.UseTextAlignment = false;
        this.lblTotal.Text = "10000";
        this.lblTotal.TextAlignment = TextAlignment.MiddleCenter;
        this.lblFinalTotalTitle.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.lblFinalTotalTitle.BackColor = Color.FromArgb(208, 158, 0);
        this.lblFinalTotalTitle.Borders = BorderSide.All;
        this.lblFinalTotalTitle.CanGrow = false;
        this.lblFinalTotalTitle.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblFinalTotalTitle.LocationFloat = new PointFloat(495.0415f, 92.00007f);
        this.lblFinalTotalTitle.Name = "lblFinalTotalTitle";
        this.lblFinalTotalTitle.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblFinalTotalTitle.SizeF = new SizeF(87.5834f, 23f);
        this.lblFinalTotalTitle.StylePriority.UseBackColor = false;
        this.lblFinalTotalTitle.StylePriority.UseBorders = false;
        this.lblFinalTotalTitle.StylePriority.UseFont = false;
        this.lblFinalTotalTitle.StylePriority.UseTextAlignment = false;
        this.lblFinalTotalTitle.Text = "الاجمالي النهائي";
        this.lblFinalTotalTitle.TextAlignment = TextAlignment.MiddleCenter;
        this.xrLabel18.LocationFloat = new PointFloat(3.973643E-05f, 115f);
        this.xrLabel18.Name = "xrLabel18";
        this.xrLabel18.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.xrLabel18.SizeF = new SizeF(264.1667f, 23f);
        this.xrLabel18.Text = "X_____________________________";
        this.xrLabel17.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.xrLabel17.LocationFloat = new PointFloat(0f, 92.00007f);
        this.xrLabel17.Name = "xrLabel17";
        this.xrLabel17.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.xrLabel17.SizeF = new SizeF(264.1667f, 23f);
        this.xrLabel17.StylePriority.UseFont = false;
        this.xrLabel17.Text = "توقيع العميل في الاسفل";
        this.lblConditions.BackColor = Color.FromArgb(208, 158, 0);
        this.lblConditions.Borders = BorderSide.All;
        this.lblConditions.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.lblConditions.LocationFloat = new PointFloat(2.384186E-05f, 23.00002f);
        this.lblConditions.Name = "lblConditions";
        this.lblConditions.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.lblConditions.SizeF = new SizeF(264.1667f, 23f);
        this.lblConditions.StylePriority.UseBackColor = false;
        this.lblConditions.StylePriority.UseBorders = false;
        this.lblConditions.StylePriority.UseFont = false;
        this.lblConditions.StylePriority.UseTextAlignment = false;
        this.lblConditions.Text = "الشروط و العقود";
        this.lblConditions.TextAlignment = TextAlignment.MiddleCenter;
        this.xrLabel15.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.xrLabel15.CanGrow = false;
        this.xrLabel15.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.xrLabel15.LocationFloat = new PointFloat(264.1667f, 92.00007f);
        this.xrLabel15.Name = "xrLabel15";
        this.xrLabel15.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.xrLabel15.SizeF = new SizeF(201.7916f, 22.99998f);
        this.xrLabel15.StylePriority.UseFont = false;
        this.xrLabel15.StylePriority.UseTextAlignment = false;
        this.xrLabel15.Text = "شكرا\u064b لتعاملكم معنا";
        this.xrLabel15.TextAlignment = TextAlignment.MiddleCenter;
        this.xrLabel13.AnchorVertical = VerticalAnchorStyles.Bottom;
        this.xrLabel13.CanGrow = false;
        this.xrLabel13.Font = new Font("Calibri", 11.25f, FontStyle.Bold);
        this.xrLabel13.LocationFloat = new PointFloat(264.1667f, 27.25004f);
        this.xrLabel13.Name = "xrLabel13";
        this.xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
        this.xrLabel13.SizeF = new SizeF(201.7916f, 64.74998f);
        this.xrLabel13.StylePriority.UseFont = false;
        this.xrLabel13.StylePriority.UseTextAlignment = false;
        this.xrLabel13.Text = "لأي استفسار او سؤال يرجى التواصل معنا في اي وقت بدون تردد";
        this.xrLabel13.TextAlignment = TextAlignment.MiddleCenter;
        base.Bands.AddRange(new Band[3]
        {
            this.Detail,
            this.TopMargin,
            this.BottomMargin
        });
        base.Margins = new Margins(50, 50, 290, 250);
        base.PageHeight = 1169;
        base.PageWidth = 827;
        base.PaperKind = PaperKind.A4;
        this.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
        base.RightToLeftLayout = RightToLeftLayout.Yes;
        base.Version = "17.2";
        ((ISupportInitialize)this).EndInit();
    }
}

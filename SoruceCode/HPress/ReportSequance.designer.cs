using DevExpress.Utils;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;

namespace HCashier.Report
{
    partial class ReportSequance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Detail = new DetailBand();
            this.TopMargin = new TopMarginBand();
            this.xrLabel6 = new XRLabel();
            this.xrLabel7 = new XRLabel();
            this.lblDatetimeFrom = new XRLabel();
            this.lblDatetimeTo = new XRLabel();
            this.lblIsDinar = new XRLabel();
            this.lblDollar = new XRLabel();
            this.xrLabel3 = new XRLabel();
            this.xrLabel1 = new XRLabel();
            this.lblReportName = new XRLabel();
            this.xrLabel2 = new XRLabel();
            this.xrLine2 = new XRLine();
            this.BottomMargin = new BottomMarginBand();
            this.xrPageInfo2 = new XRPageInfo();
            this.xrPageInfo1 = new XRPageInfo();
            this.xrLine1 = new XRLine();
            ((ISupportInitialize)this).BeginInit();
            this.Detail.HeightF = 212.5f;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.Detail.TextAlignment = TextAlignment.TopLeft;
            this.TopMargin.Controls.AddRange(new XRControl[11]
            {
            this.xrLabel6,
            this.xrLabel7,
            this.lblDatetimeFrom,
            this.lblDatetimeTo,
            this.lblIsDinar,
            this.lblDollar,
            this.xrLabel3,
            this.xrLabel1,
            this.lblReportName,
            this.xrLabel2,
            this.xrLine2
            });
            this.TopMargin.HeightF = 101f;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.TopMargin.TextAlignment = TextAlignment.TopLeft;
            this.xrLabel6.BackColor = Color.DarkGray;
            this.xrLabel6.Font = new Font("Calibri", 12f, FontStyle.Bold);
            this.xrLabel6.LocationFloat = new PointFloat(258.3333f, 42.95835f);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel6.SizeF = new SizeF(83.33334f, 32.95834f);
            this.xrLabel6.StylePriority.UseBackColor = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "تاريخ الى";
            this.xrLabel6.TextAlignment = TextAlignment.MiddleCenter;
            this.xrLabel7.BackColor = Color.DarkGray;
            this.xrLabel7.Font = new Font("Calibri", 12f, FontStyle.Bold);
            this.xrLabel7.LocationFloat = new PointFloat(258.3333f, 10.00002f);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel7.SizeF = new SizeF(83.33334f, 32.95834f);
            this.xrLabel7.StylePriority.UseBackColor = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "تاريخ من";
            this.xrLabel7.TextAlignment = TextAlignment.MiddleCenter;
            this.lblDatetimeFrom.AnchorHorizontal = HorizontalAnchorStyles.Left;
            this.lblDatetimeFrom.AnchorVertical = VerticalAnchorStyles.Top;
            this.lblDatetimeFrom.Borders = BorderSide.None;
            this.lblDatetimeFrom.Font = new Font("Calibri", 12f, FontStyle.Bold);
            this.lblDatetimeFrom.LocationFloat = new PointFloat(10.00001f, 10.00002f);
            this.lblDatetimeFrom.Name = "lblDatetimeFrom";
            this.lblDatetimeFrom.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.lblDatetimeFrom.SizeF = new SizeF(248.3333f, 32.95833f);
            this.lblDatetimeFrom.StylePriority.UseBorders = false;
            this.lblDatetimeFrom.StylePriority.UseFont = false;
            this.lblDatetimeFrom.StylePriority.UseTextAlignment = false;
            this.lblDatetimeFrom.TextAlignment = TextAlignment.MiddleCenter;
            this.lblDatetimeTo.AnchorHorizontal = HorizontalAnchorStyles.Left;
            this.lblDatetimeTo.AnchorVertical = VerticalAnchorStyles.Top;
            this.lblDatetimeTo.Borders = BorderSide.None;
            this.lblDatetimeTo.Font = new Font("Calibri", 12f, FontStyle.Bold);
            this.lblDatetimeTo.LocationFloat = new PointFloat(10.00001f, 42.95835f);
            this.lblDatetimeTo.Name = "lblDatetimeTo";
            this.lblDatetimeTo.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.lblDatetimeTo.SizeF = new SizeF(248.3333f, 32.95833f);
            this.lblDatetimeTo.StylePriority.UseBorders = false;
            this.lblDatetimeTo.StylePriority.UseFont = false;
            this.lblDatetimeTo.StylePriority.UseTextAlignment = false;
            this.lblDatetimeTo.TextAlignment = TextAlignment.MiddleCenter;
            this.lblIsDinar.AnchorHorizontal = HorizontalAnchorStyles.Left;
            this.lblIsDinar.AnchorVertical = VerticalAnchorStyles.Top;
            this.lblIsDinar.Borders = BorderSide.None;
            this.lblIsDinar.Font = new Font("Calibri", 12f, FontStyle.Bold);
            this.lblIsDinar.LocationFloat = new PointFloat(341.6667f, 42.95835f);
            this.lblIsDinar.Name = "lblIsDinar";
            this.lblIsDinar.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.lblIsDinar.SizeF = new SizeF(79.79166f, 32.95833f);
            this.lblIsDinar.StylePriority.UseBorders = false;
            this.lblIsDinar.StylePriority.UseFont = false;
            this.lblIsDinar.StylePriority.UseTextAlignment = false;
            this.lblIsDinar.TextAlignment = TextAlignment.MiddleCenter;
            this.lblIsDinar.Visible = false;
            this.lblDollar.AnchorHorizontal = HorizontalAnchorStyles.Left;
            this.lblDollar.AnchorVertical = VerticalAnchorStyles.Top;
            this.lblDollar.Borders = BorderSide.None;
            this.lblDollar.Font = new Font("Calibri", 12f, FontStyle.Bold);
            this.lblDollar.LocationFloat = new PointFloat(341.6667f, 10.00002f);
            this.lblDollar.Name = "lblDollar";
            this.lblDollar.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.lblDollar.SizeF = new SizeF(79.79166f, 32.95833f);
            this.lblDollar.StylePriority.UseBorders = false;
            this.lblDollar.StylePriority.UseFont = false;
            this.lblDollar.StylePriority.UseTextAlignment = false;
            this.lblDollar.TextAlignment = TextAlignment.MiddleCenter;
            this.xrLabel3.BackColor = Color.DarkGray;
            this.xrLabel3.Font = new Font("Calibri", 12f, FontStyle.Bold);
            this.xrLabel3.LocationFloat = new PointFloat(421.4583f, 10.00002f);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel3.SizeF = new SizeF(83.33334f, 32.95834f);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "سعر الدولار";
            this.xrLabel3.TextAlignment = TextAlignment.MiddleCenter;
            this.xrLabel1.BackColor = Color.DarkGray;
            this.xrLabel1.Font = new Font("Calibri", 12f, FontStyle.Bold);
            this.xrLabel1.LocationFloat = new PointFloat(421.4583f, 42.95835f);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel1.SizeF = new SizeF(83.33334f, 32.95834f);
            this.xrLabel1.StylePriority.UseBackColor = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "العملة";
            this.xrLabel1.TextAlignment = TextAlignment.MiddleCenter;
            this.xrLabel1.Visible = false;
            this.lblReportName.AnchorHorizontal = HorizontalAnchorStyles.Left;
            this.lblReportName.AnchorVertical = VerticalAnchorStyles.Top;
            this.lblReportName.Borders = BorderSide.None;
            this.lblReportName.Font = new Font("Calibri", 12f, FontStyle.Bold);
            this.lblReportName.LocationFloat = new PointFloat(504.7917f, 10.00001f);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.lblReportName.SizeF = new SizeF(215.2084f, 65.91668f);
            this.lblReportName.StylePriority.UseBorders = false;
            this.lblReportName.StylePriority.UseFont = false;
            this.lblReportName.StylePriority.UseTextAlignment = false;
            this.lblReportName.TextAlignment = TextAlignment.MiddleCenter;
            this.xrLabel2.AnchorHorizontal = HorizontalAnchorStyles.Left;
            this.xrLabel2.AnchorVertical = VerticalAnchorStyles.Top;
            this.xrLabel2.BackColor = Color.DarkGray;
            this.xrLabel2.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrLabel2.LocationFloat = new PointFloat(720f, 10.00001f);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel2.SizeF = new SizeF(100f, 65.91668f);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "تقرير";
            this.xrLabel2.TextAlignment = TextAlignment.MiddleCenter;
            this.xrLine2.AnchorHorizontal = HorizontalAnchorStyles.Both;
            this.xrLine2.AnchorVertical = VerticalAnchorStyles.Bottom;
            this.xrLine2.LocationFloat = new PointFloat(0f, 81.54164f);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new SizeF(830f, 9.458333f);
            this.BottomMargin.Controls.AddRange(new XRControl[3]
            {
            this.xrPageInfo2,
            this.xrPageInfo1,
            this.xrLine1
            });
            this.BottomMargin.HeightF = 56.54185f;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.BottomMargin.TextAlignment = TextAlignment.TopLeft;
            this.xrPageInfo2.AnchorHorizontal = HorizontalAnchorStyles.Right;
            this.xrPageInfo2.AnchorVertical = VerticalAnchorStyles.Bottom;
            this.xrPageInfo2.Format = "{0:yyyy-MM-dd}";
            this.xrPageInfo2.LocationFloat = new PointFloat(695.6249f, 23.54185f);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrPageInfo2.PageInfo = PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new SizeF(134.3751f, 22.99999f);
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = TextAlignment.MiddleCenter;
            this.xrPageInfo1.AnchorHorizontal = HorizontalAnchorStyles.Left;
            this.xrPageInfo1.AnchorVertical = VerticalAnchorStyles.Bottom;
            this.xrPageInfo1.LocationFloat = new PointFloat(0f, 23.54185f);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrPageInfo1.SizeF = new SizeF(100f, 23f);
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = TextAlignment.MiddleCenter;
            this.xrLine1.AnchorHorizontal = HorizontalAnchorStyles.Both;
            this.xrLine1.AnchorVertical = VerticalAnchorStyles.Top;
            this.xrLine1.LocationFloat = new PointFloat(0f, 0f);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new SizeF(830f, 9.458333f);
            base.Bands.AddRange(new Band[3]
            {
            this.Detail,
            this.TopMargin,
            this.BottomMargin
            });
            base.Margins = new Margins(10, 10, 101, 57);
            base.RequestParameters = false;
            base.ShowPreviewMarginLines = false;
            base.ShowPrintMarginsWarning = false;
            base.Version = "15.1";
            ((ISupportInitialize)this).EndInit();
        }

        #endregion

        private DetailBand Detail;

        private TopMarginBand TopMargin;

        private BottomMarginBand BottomMargin;

        private XRLabel lblReportName;

        private XRLabel xrLabel2;

        private XRLine xrLine2;

        private XRPageInfo xrPageInfo2;

        private XRPageInfo xrPageInfo1;

        private XRLine xrLine1;

        private XRLabel xrLabel6;

        private XRLabel xrLabel7;

        private XRLabel lblDatetimeFrom;

        private XRLabel lblDatetimeTo;

        private XRLabel lblIsDinar;

        private XRLabel lblDollar;

        private XRLabel xrLabel3;

        private XRLabel xrLabel1;
    }
}

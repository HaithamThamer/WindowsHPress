using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using HPress;
using DevExpress.XtraPrinting;
using System.Drawing.Printing;
using DevExpress.Utils;
using DevExpress.XtraPrinting.BarCode;
using HPress.Properties;
namespace HCashier.Report
{
    public partial class ArrivedCatch : DevExpress.XtraReports.UI.XtraReport
    {
        private string[] numberOne = new string[10]
    {
        "صفر",
        "ئي",
        "دوو",
        "سآ",
        "ضار",
        "ثي",
        "شةش",
        "حةفت",
        "هةشت",
        "نةه"
    };

        private string[] numberTwo = new string[10]
        {
        "دةه",
        "يازداة",
        "دوازداة",
        "سيسدة",
        "ضاردة",
        "ثازدة",
        "شازدة",
        "هةفدة",
        "هةشدة",
        "نازدة"
        };

        private string[] numberThree = new string[10]
        {
        "",
        "دةه",
        "بيست",
        "سيه",
        "ضل",
        "ثينجى",
        "شيست",
        "حةفتى",
        "هةشتى",
        "نوت"
        };

        private IContainer components = null;

        private DetailBand Detail;

        private TopMarginBand TopMargin;

        private BottomMarginBand BottomMargin;

        private XRLine xrLine1;

        private XRPictureBox picMain;

        private XRLabel lblTitle;

        private XRPageInfo xrPageInfo1;

        private XRLine xrLine4;

        private XRLabel xrLabel4;

        private XRBarCode xrBarCode1;

        private XRLabel xrLabel2;

        private XRLabel xrLabel3;

        private XRLabel lblId;

        private XRLabel lblDate;

        private XRLabel xrLabel5;

        private XRLabel xrLabel6;

        private XRLabel lblRemainingEnglish;

        private XRLabel xrLabel10;

        private XRLabel xrLabel12;

        private XRLabel xrLabel13;

        private XRLabel xrLabel14;

        private XRLabel xrLabel9;

        private XRLabel xrLabel8;

        private XRLabel xrLabel22;

        private XRLabel lblNote;

        private XRLabel lblRemaining;

        private XRLabel lblTotalInText;

        private XRLabel lblTotal;

        private XRLabel lblClientName;

        private XRLabel lblRemainingKurdish;

        private XRLabel xrLabel7;
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
            Code128Generator symbology = new Code128Generator();
            ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ArrivedCatch));
            this.Detail = new DetailBand();
            this.xrLabel22 = new XRLabel();
            this.lblNote = new XRLabel();
            this.lblRemaining = new XRLabel();
            this.lblTotalInText = new XRLabel();
            this.lblTotal = new XRLabel();
            this.lblClientName = new XRLabel();
            this.lblRemainingKurdish = new XRLabel();
            this.lblRemainingEnglish = new XRLabel();
            this.xrLabel10 = new XRLabel();
            this.xrLabel12 = new XRLabel();
            this.xrLabel13 = new XRLabel();
            this.xrLabel14 = new XRLabel();
            this.xrLabel9 = new XRLabel();
            this.xrLabel8 = new XRLabel();
            this.xrLabel6 = new XRLabel();
            this.xrLabel5 = new XRLabel();
            this.TopMargin = new TopMarginBand();
            this.xrLabel7 = new XRLabel();
            this.xrLabel4 = new XRLabel();
            this.xrBarCode1 = new XRBarCode();
            this.lblTitle = new XRLabel();
            this.picMain = new XRPictureBox();
            this.xrLabel2 = new XRLabel();
            this.xrLabel3 = new XRLabel();
            this.lblId = new XRLabel();
            this.lblDate = new XRLabel();
            this.BottomMargin = new BottomMarginBand();
            this.xrPageInfo1 = new XRPageInfo();
            this.xrLine4 = new XRLine();
            this.xrLine1 = new XRLine();
            ((ISupportInitialize)this).BeginInit();
            this.Detail.Controls.AddRange(new XRControl[16]
            {
            this.xrLabel22,
            this.lblNote,
            this.lblRemaining,
            this.lblTotalInText,
            this.lblTotal,
            this.lblClientName,
            this.lblRemainingKurdish,
            this.lblRemainingEnglish,
            this.xrLabel10,
            this.xrLabel12,
            this.xrLabel13,
            this.xrLabel14,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel6,
            this.xrLabel5
            });
            this.Detail.HeightF = 387.0434f;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.Detail.TextAlignment = TextAlignment.TopLeft;
            this.xrLabel22.BorderColor = Color.FromArgb(64, 64, 64);
            this.xrLabel22.BorderDashStyle = BorderDashStyle.Dash;
            this.xrLabel22.Borders = BorderSide.Bottom;
            this.xrLabel22.BorderWidth = 0.5f;
            this.xrLabel22.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.xrLabel22.ForeColor = Color.Black;
            this.xrLabel22.LocationFloat = new PointFloat(141.7797f, 312.3414f);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel22.SizeF = new SizeF(494.9661f, 37.83054f);
            this.xrLabel22.StylePriority.UseBorderColor = false;
            this.xrLabel22.StylePriority.UseBorderDashStyle = false;
            this.xrLabel22.StylePriority.UseBorders = false;
            this.xrLabel22.StylePriority.UseBorderWidth = false;
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseForeColor = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.TextAlignment = TextAlignment.MiddleCenter;
            this.lblNote.BorderColor = Color.FromArgb(64, 64, 64);
            this.lblNote.BorderDashStyle = BorderDashStyle.Dash;
            this.lblNote.Borders = BorderSide.Bottom;
            this.lblNote.BorderWidth = 0.5f;
            this.lblNote.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.lblNote.ForeColor = Color.Black;
            this.lblNote.LocationFloat = new PointFloat(141.7797f, 222.3923f);
            this.lblNote.Multiline = true;
            this.lblNote.Name = "lblNote";
            this.lblNote.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.lblNote.SizeF = new SizeF(494.9662f, 37.83047f);
            this.lblNote.StylePriority.UseBorderColor = false;
            this.lblNote.StylePriority.UseBorderDashStyle = false;
            this.lblNote.StylePriority.UseBorders = false;
            this.lblNote.StylePriority.UseBorderWidth = false;
            this.lblNote.StylePriority.UseFont = false;
            this.lblNote.StylePriority.UseForeColor = false;
            this.lblNote.StylePriority.UsePadding = false;
            this.lblNote.StylePriority.UseTextAlignment = false;
            this.lblNote.TextAlignment = TextAlignment.MiddleCenter;
            this.lblRemaining.BorderColor = Color.FromArgb(64, 64, 64);
            this.lblRemaining.BorderDashStyle = BorderDashStyle.Dash;
            this.lblRemaining.Borders = BorderSide.Bottom;
            this.lblRemaining.BorderWidth = 0.5f;
            this.lblRemaining.Font = new Font("Rebar - K - Diyari", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.lblRemaining.ForeColor = Color.Black;
            this.lblRemaining.LocationFloat = new PointFloat(141.7797f, 171.8499f);
            this.lblRemaining.Name = "lblRemaining";
            this.lblRemaining.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.lblRemaining.SizeF = new SizeF(494.9661f, 37.83052f);
            this.lblRemaining.StylePriority.UseBorderColor = false;
            this.lblRemaining.StylePriority.UseBorderDashStyle = false;
            this.lblRemaining.StylePriority.UseBorders = false;
            this.lblRemaining.StylePriority.UseBorderWidth = false;
            this.lblRemaining.StylePriority.UseFont = false;
            this.lblRemaining.StylePriority.UseForeColor = false;
            this.lblRemaining.StylePriority.UseTextAlignment = false;
            this.lblRemaining.TextAlignment = TextAlignment.MiddleCenter;
            this.lblTotalInText.BorderColor = Color.FromArgb(64, 64, 64);
            this.lblTotalInText.BorderDashStyle = BorderDashStyle.Dash;
            this.lblTotalInText.Borders = BorderSide.Bottom;
            this.lblTotalInText.BorderWidth = 0.5f;
            this.lblTotalInText.Font = new Font("Rebar - K - Diyarbakir ", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.lblTotalInText.ForeColor = Color.Black;
            this.lblTotalInText.LocationFloat = new PointFloat(141.7798f, 120.2303f);
            this.lblTotalInText.Name = "lblTotalInText";
            this.lblTotalInText.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.lblTotalInText.SizeF = new SizeF(494.9661f, 37.83051f);
            this.lblTotalInText.StylePriority.UseBorderColor = false;
            this.lblTotalInText.StylePriority.UseBorderDashStyle = false;
            this.lblTotalInText.StylePriority.UseBorders = false;
            this.lblTotalInText.StylePriority.UseBorderWidth = false;
            this.lblTotalInText.StylePriority.UseFont = false;
            this.lblTotalInText.StylePriority.UseForeColor = false;
            this.lblTotalInText.StylePriority.UseTextAlignment = false;
            this.lblTotalInText.TextAlignment = TextAlignment.MiddleCenter;
            this.lblTotal.BorderColor = Color.FromArgb(64, 64, 64);
            this.lblTotal.BorderDashStyle = BorderDashStyle.Dash;
            this.lblTotal.Borders = BorderSide.Bottom;
            this.lblTotal.BorderWidth = 0.5f;
            this.lblTotal.Font = new Font("Calibri", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.lblTotal.ForeColor = Color.Black;
            this.lblTotal.LocationFloat = new PointFloat(141.7798f, 82.39975f);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.lblTotal.SizeF = new SizeF(494.966f, 37.83052f);
            this.lblTotal.StylePriority.UseBorderColor = false;
            this.lblTotal.StylePriority.UseBorderDashStyle = false;
            this.lblTotal.StylePriority.UseBorders = false;
            this.lblTotal.StylePriority.UseBorderWidth = false;
            this.lblTotal.StylePriority.UseFont = false;
            this.lblTotal.StylePriority.UseForeColor = false;
            this.lblTotal.StylePriority.UseTextAlignment = false;
            this.lblTotal.TextAlignment = TextAlignment.MiddleCenter;
            this.lblClientName.BorderColor = Color.FromArgb(64, 64, 64);
            this.lblClientName.BorderDashStyle = BorderDashStyle.Dash;
            this.lblClientName.Borders = BorderSide.Bottom;
            this.lblClientName.BorderWidth = 0.5f;
            this.lblClientName.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.lblClientName.ForeColor = Color.Black;
            this.lblClientName.LocationFloat = new PointFloat(141.7797f, 32.91667f);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.lblClientName.SizeF = new SizeF(494.966f, 37.83052f);
            this.lblClientName.StylePriority.UseBorderColor = false;
            this.lblClientName.StylePriority.UseBorderDashStyle = false;
            this.lblClientName.StylePriority.UseBorders = false;
            this.lblClientName.StylePriority.UseBorderWidth = false;
            this.lblClientName.StylePriority.UseFont = false;
            this.lblClientName.StylePriority.UseForeColor = false;
            this.lblClientName.StylePriority.UseTextAlignment = false;
            this.lblClientName.TextAlignment = TextAlignment.MiddleCenter;
            this.lblRemainingKurdish.AnchorHorizontal = HorizontalAnchorStyles.Right;
            this.lblRemainingKurdish.AnchorVertical = VerticalAnchorStyles.Top;
            this.lblRemainingKurdish.Font = new Font("Rebar - K - Diyari", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.lblRemainingKurdish.LocationFloat = new PointFloat(636.7457f, 171.8499f);
            this.lblRemainingKurdish.Name = "lblRemainingKurdish";
            this.lblRemainingKurdish.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.lblRemainingKurdish.SizeF = new SizeF(140.2543f, 37.83053f);
            this.lblRemainingKurdish.StylePriority.UseFont = false;
            this.lblRemainingKurdish.StylePriority.UseTextAlignment = false;
            this.lblRemainingKurdish.Text = ": ثارى\u064e مايى";
            this.lblRemainingKurdish.TextAlignment = TextAlignment.MiddleRight;
            this.lblRemainingEnglish.AnchorHorizontal = HorizontalAnchorStyles.Left;
            this.lblRemainingEnglish.AnchorVertical = VerticalAnchorStyles.Top;
            this.lblRemainingEnglish.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.lblRemainingEnglish.LocationFloat = new PointFloat(10.00001f, 171.8499f);
            this.lblRemainingEnglish.Name = "lblRemainingEnglish";
            this.lblRemainingEnglish.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.lblRemainingEnglish.SizeF = new SizeF(131.7797f, 37.83053f);
            this.lblRemainingEnglish.StylePriority.UseFont = false;
            this.lblRemainingEnglish.StylePriority.UseTextAlignment = false;
            this.lblRemainingEnglish.Text = "Remaining:";
            this.lblRemainingEnglish.TextAlignment = TextAlignment.MiddleLeft;
            this.xrLabel10.AnchorHorizontal = HorizontalAnchorStyles.Right;
            this.xrLabel10.AnchorVertical = VerticalAnchorStyles.Top;
            this.xrLabel10.Font = new Font("Rebar - K - Diyari", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.xrLabel10.LocationFloat = new PointFloat(636.7457f, 222.3923f);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel10.SizeF = new SizeF(140.2545f, 37.83052f);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = ": ت\u0640ي\u064e\u0640ب\u0640ي\u0640ن\u0640ى";
            this.xrLabel10.TextAlignment = TextAlignment.MiddleRight;
            this.xrLabel12.AnchorHorizontal = HorizontalAnchorStyles.Right;
            this.xrLabel12.AnchorVertical = VerticalAnchorStyles.Top;
            this.xrLabel12.Font = new Font("Rebar - K - Diyari", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.xrLabel12.LocationFloat = new PointFloat(636.7457f, 82.39975f);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel12.SizeF = new SizeF(140.2543f, 37.83052f);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = " : ك\u0640وذم\u0640ى\u064e";
            this.xrLabel12.TextAlignment = TextAlignment.MiddleRight;
            this.xrLabel13.AnchorHorizontal = HorizontalAnchorStyles.Right;
            this.xrLabel13.AnchorVertical = VerticalAnchorStyles.Top;
            this.xrLabel13.Font = new Font("Rebar - K - Diyari", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.xrLabel13.LocationFloat = new PointFloat(636.7457f, 32.91667f);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel13.SizeF = new SizeF(140.2543f, 37.83052f);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = ": هاتة وةرطرتن ذ هي\u064eذا";
            this.xrLabel13.TextAlignment = TextAlignment.MiddleRight;
            this.xrLabel14.AnchorHorizontal = HorizontalAnchorStyles.Right;
            this.xrLabel14.AnchorVertical = VerticalAnchorStyles.Top;
            this.xrLabel14.Font = new Font("Rebar - K - Diyari", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.xrLabel14.LocationFloat = new PointFloat(636.7457f, 312.3414f);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel14.SizeF = new SizeF(140.2543f, 37.83054f);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = " : وةرطر";
            this.xrLabel14.TextAlignment = TextAlignment.MiddleRight;
            this.xrLabel9.AnchorHorizontal = HorizontalAnchorStyles.Left;
            this.xrLabel9.AnchorVertical = VerticalAnchorStyles.Top;
            this.xrLabel9.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.xrLabel9.LocationFloat = new PointFloat(10.00001f, 222.3923f);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel9.SizeF = new SizeF(131.7797f, 37.83052f);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Note:";
            this.xrLabel9.TextAlignment = TextAlignment.MiddleLeft;
            this.xrLabel8.AnchorHorizontal = HorizontalAnchorStyles.Left;
            this.xrLabel8.AnchorVertical = VerticalAnchorStyles.Top;
            this.xrLabel8.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.xrLabel8.LocationFloat = new PointFloat(10.00001f, 312.3414f);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel8.SizeF = new SizeF(131.7797f, 37.83051f);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Receiver:";
            this.xrLabel8.TextAlignment = TextAlignment.MiddleLeft;
            this.xrLabel6.AnchorHorizontal = HorizontalAnchorStyles.Left;
            this.xrLabel6.AnchorVertical = VerticalAnchorStyles.Top;
            this.xrLabel6.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.xrLabel6.LocationFloat = new PointFloat(10.0001f, 82.39975f);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel6.SizeF = new SizeF(131.7797f, 37.83052f);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Amount:";
            this.xrLabel6.TextAlignment = TextAlignment.MiddleLeft;
            this.xrLabel5.AnchorHorizontal = HorizontalAnchorStyles.Left;
            this.xrLabel5.AnchorVertical = VerticalAnchorStyles.Top;
            this.xrLabel5.Font = new Font("Calibri", 12f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.xrLabel5.LocationFloat = new PointFloat(10.00001f, 32.91667f);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel5.SizeF = new SizeF(131.7797f, 37.83052f);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "We received from:";
            this.xrLabel5.TextAlignment = TextAlignment.MiddleLeft;
            this.TopMargin.Controls.AddRange(new XRControl[9]
            {
            this.xrLabel7,
            this.xrLabel4,
            this.xrBarCode1,
            this.lblTitle,
            this.picMain,
            this.xrLabel2,
            this.xrLabel3,
            this.lblId,
            this.lblDate
            });
            this.TopMargin.HeightF = 121.2849f;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.TopMargin.TextAlignment = TextAlignment.TopLeft;
            this.xrLabel7.Font = new Font("Times New Roman", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrLabel7.LocationFloat = new PointFloat(10.00012f, 88.2849f);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel7.SizeF = new SizeF(203.7413f, 23f);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "Print - Design - Advertising";
            this.xrLabel7.TextAlignment = TextAlignment.MiddleCenter;
            this.xrLabel4.AnchorHorizontal = HorizontalAnchorStyles.Both;
            this.xrLabel4.Font = new Font("Rebar - K - Diyari", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.xrLabel4.LocationFloat = new PointFloat(213.7414f, 63.07096f);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel4.SizeF = new SizeF(404.7163f, 27.30131f);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Receipt Voucher ";
            this.xrLabel4.TextAlignment = TextAlignment.MiddleCenter;
            this.xrBarCode1.AnchorHorizontal = HorizontalAnchorStyles.Right;
            this.xrBarCode1.AnchorVertical = VerticalAnchorStyles.Top;
            this.xrBarCode1.LocationFloat = new PointFloat(618.4578f, 10.00001f);
            this.xrBarCode1.Name = "xrBarCode1";
            this.xrBarCode1.Padding = new PaddingInfo(10, 10, 0, 0, 100f);
            this.xrBarCode1.SizeF = new SizeF(158.5422f, 48.76965f);
            this.xrBarCode1.StylePriority.UseTextAlignment = false;
            this.xrBarCode1.Symbology = symbology;
            this.xrBarCode1.TextAlignment = TextAlignment.MiddleCenter;
            this.lblTitle.AnchorHorizontal = HorizontalAnchorStyles.Both;
            this.lblTitle.BorderColor = Color.FromArgb(255, 187, 0);
            this.lblTitle.Borders = BorderSide.None;
            this.lblTitle.Font = new Font("Rebar - K - Diyari", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 178);
            this.lblTitle.LocationFloat = new PointFloat(213.7414f, 35.76965f);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.lblTitle.SizeF = new SizeF(404.7163f, 27.30132f);
            this.lblTitle.StylePriority.UseBorderColor = false;
            this.lblTitle.StylePriority.UseBorders = false;
            this.lblTitle.StylePriority.UseFont = false;
            this.lblTitle.StylePriority.UseTextAlignment = false;
            this.lblTitle.Text = "ثسولا مةزاختني\u064e";
            this.lblTitle.TextAlignment = TextAlignment.MiddleCenter;
            this.picMain.Image = (Image)componentResourceManager.GetObject("picMain.Image");
            this.picMain.LocationFloat = new PointFloat(10.00001f, 10.00001f);
            this.picMain.Name = "picMain";
            this.picMain.SizeF = new SizeF(203.7414f, 78.28489f);
            this.picMain.Sizing = ImageSizeMode.ZoomImage;
            this.xrLabel2.AnchorHorizontal = HorizontalAnchorStyles.Right;
            this.xrLabel2.AnchorVertical = VerticalAnchorStyles.Top;
            this.xrLabel2.BackColor = Color.FromArgb(255, 187, 0);
            this.xrLabel2.BorderColor = Color.DimGray;
            this.xrLabel2.Borders = BorderSide.None;
            this.xrLabel2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrLabel2.LocationFloat = new PointFloat(618.4578f, 63.13597f);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel2.SizeF = new SizeF(53.00037f, 27.30125f);
            this.xrLabel2.StylePriority.UseBackColor = false;
            this.xrLabel2.StylePriority.UseBorderColor = false;
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "No.";
            this.xrLabel2.TextAlignment = TextAlignment.MiddleCenter;
            this.xrLabel3.AnchorHorizontal = HorizontalAnchorStyles.Right;
            this.xrLabel3.AnchorVertical = VerticalAnchorStyles.Top;
            this.xrLabel3.BackColor = Color.FromArgb(255, 187, 0);
            this.xrLabel3.BorderColor = Color.DimGray;
            this.xrLabel3.Borders = BorderSide.None;
            this.xrLabel3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.xrLabel3.LocationFloat = new PointFloat(618.4578f, 93.98378f);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrLabel3.SizeF = new SizeF(52.41664f, 27.30112f);
            this.xrLabel3.StylePriority.UseBackColor = false;
            this.xrLabel3.StylePriority.UseBorderColor = false;
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Date";
            this.xrLabel3.TextAlignment = TextAlignment.MiddleCenter;
            this.lblId.AnchorHorizontal = HorizontalAnchorStyles.Right;
            this.lblId.AnchorVertical = VerticalAnchorStyles.Top;
            this.lblId.BackColor = Color.White;
            this.lblId.BorderColor = Color.DimGray;
            this.lblId.Borders = BorderSide.None;
            this.lblId.Font = new Font("Calibri", 12f, FontStyle.Bold, GraphicsUnit.Point, 178);
            this.lblId.LocationFloat = new PointFloat(671.4581f, 63.13591f);
            this.lblId.Name = "lblId";
            this.lblId.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.lblId.SizeF = new SizeF(105.5418f, 27.30131f);
            this.lblId.StylePriority.UseBackColor = false;
            this.lblId.StylePriority.UseBorderColor = false;
            this.lblId.StylePriority.UseBorders = false;
            this.lblId.StylePriority.UseFont = false;
            this.lblId.StylePriority.UseTextAlignment = false;
            this.lblId.Text = "999";
            this.lblId.TextAlignment = TextAlignment.MiddleCenter;
            this.lblDate.AnchorHorizontal = HorizontalAnchorStyles.Right;
            this.lblDate.AnchorVertical = VerticalAnchorStyles.Top;
            this.lblDate.BackColor = Color.White;
            this.lblDate.BorderColor = Color.DimGray;
            this.lblDate.Borders = BorderSide.None;
            this.lblDate.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblDate.LocationFloat = new PointFloat(670.8745f, 93.98378f);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.lblDate.SizeF = new SizeF(106.1256f, 27.30112f);
            this.lblDate.StylePriority.UseBackColor = false;
            this.lblDate.StylePriority.UseBorderColor = false;
            this.lblDate.StylePriority.UseBorders = false;
            this.lblDate.StylePriority.UseFont = false;
            this.lblDate.StylePriority.UseTextAlignment = false;
            this.lblDate.Text = "2017-01-04";
            this.lblDate.TextAlignment = TextAlignment.MiddleCenter;
            this.BottomMargin.Controls.AddRange(new XRControl[3]
            {
            this.xrPageInfo1,
            this.xrLine4,
            this.xrLine1
            });
            this.BottomMargin.HeightF = 60f;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new PaddingInfo(0, 0, 0, 0, 100f);
            this.BottomMargin.TextAlignment = TextAlignment.TopLeft;
            this.xrPageInfo1.AnchorHorizontal = HorizontalAnchorStyles.Left;
            this.xrPageInfo1.AnchorVertical = VerticalAnchorStyles.Bottom;
            this.xrPageInfo1.Font = new Font("Times New Roman", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.xrPageInfo1.LocationFloat = new PointFloat(98.9726f, 3.051758E-05f);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new PaddingInfo(2, 2, 0, 0, 100f);
            this.xrPageInfo1.PageInfo = PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new SizeF(114.7688f, 20f);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = TextAlignment.MiddleLeft;
            this.xrPageInfo1.TextFormatString = "{0:yyyy-MM-dd}";
            this.xrLine4.BorderColor = Color.White;
            this.xrLine4.Borders = BorderSide.Bottom;
            this.xrLine4.BorderWidth = 7f;
            this.xrLine4.ForeColor = Color.FromArgb(255, 187, 0);
            this.xrLine4.LineWidth = 10f;
            this.xrLine4.LocationFloat = new PointFloat(0f, 25f);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new SizeF(786.9999f, 10f);
            this.xrLine4.StylePriority.UseBorderColor = false;
            this.xrLine4.StylePriority.UseBorders = false;
            this.xrLine4.StylePriority.UseBorderWidth = false;
            this.xrLine4.StylePriority.UseForeColor = false;
            this.xrLine1.ForeColor = Color.FromArgb(255, 187, 0);
            this.xrLine1.LineWidth = 24f;
            this.xrLine1.LocationFloat = new PointFloat(0f, 34.99997f);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new SizeF(786.9999f, 25f);
            this.xrLine1.StylePriority.UseForeColor = false;
            base.Bands.AddRange(new Band[3]
            {
            this.Detail,
            this.TopMargin,
            this.BottomMargin
            });
            base.Landscape = true;
            base.Margins = new Margins(20, 20, 121, 60);
            base.PageHeight = 583;
            base.PageWidth = 827;
            base.PaperKind = PaperKind.A5;
            base.Version = "18.1";
            ((ISupportInitialize)this).EndInit();
        }
        public ArrivedCatch(int id, string name, double total, DateTime date, double remaining, bool isDinar, string note, bool isImport = true)
        {
            this.InitializeComponent();
            if (remaining == 0.0)
            {
                XRLabel xRLabel = this.lblRemaining;
                XRLabel xRLabel2 = this.lblRemainingEnglish;
                XRLabel xRLabel3 = this.lblRemainingKurdish;
                bool flag2 = xRLabel3.Visible = false;
                bool visible = xRLabel2.Visible = flag2;
                xRLabel.Visible = visible;
            }
            this.lblDate.Text = date.ToString("yyyy/MM/dd");
            this.lblClientName.Text = name;
            this.lblTotal.Text = total.ToString(isDinar ? "#,###" : "#.##") + (isDinar ? " IQD" : " $");
            this.lblTotalInText.Text = this.getNumberInText(total.ToString()) + (isDinar ? " دينار" : " دولار");
            this.lblId.Text = id.ToString();
            this.xrBarCode1.Text = id.ToString();
            this.lblRemaining.Text = remaining.ToString(isDinar ? "#,###" : "#.##") + (isDinar ? " IQD" : " $");
            this.lblNote.Text = note;
            this.picMain.Image = Image.FromFile(HPress.Properties.Settings.Default.imageLogo1);
            this.lblTitle.Text = (isImport ? "ثسولا ثارة وةرطرتنى\u064e" : "ثسولا مةزاختني\u064e");
        }

        private string getNumberInText(string number)
        {
            if (number.Contains("."))
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
                text += " و ";
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
                    text += " سةد";
                }
                else
                {
                    text += " سةد";
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
                text += " و ";
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
                text += " هزار";
                c = number[1];
                if (c.ToString() == "0")
                {
                    c = number[2];
                    if (c.ToString() == "0")
                    {
                        c = number[3];
                        num2 = ((c.ToString() == "0") ? 1 : 0);
                        goto IL_02ed;
                    }
                }
                num2 = 0;
                goto IL_02ed;
            }
            int num3;
            if (number.Length == 5)
            {
                text += this.getNumberInText(number.Substring(0, 2));
                text += " هزار ";
                c = number[2];
                if (c.ToString() == "0")
                {
                    c = number[3];
                    if (c.ToString() == "0")
                    {
                        c = number[4];
                        num3 = ((c.ToString() == "0") ? 1 : 0);
                        goto IL_03ae;
                    }
                }
                num3 = 0;
                goto IL_03ae;
            }
            int num4;
            if (number.Length == 6)
            {
                text += this.getNumberInText(number.Substring(0, 3));
                text += " هزار ";
                c = number[3];
                if (c.ToString() == "0")
                {
                    c = number[4];
                    if (c.ToString() == "0")
                    {
                        c = number[5];
                        num4 = ((c.ToString() == "0") ? 1 : 0);
                        goto IL_046b;
                    }
                }
                num4 = 0;
                goto IL_046b;
            }
            int num5;
            if (number.Length == 7)
            {
                text += this.getNumberInText(number.Substring(0, 1));
                text += " مليون ";
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
                                    goto IL_057f;
                                }
                            }
                        }
                    }
                }
                num5 = 0;
                goto IL_057f;
            }
            return "";
        IL_057f:
            if (num5 != 0)
            {
                return text;
            }
            text += " و ";
            return text + this.getNumberInText(number.Substring(1));
        IL_046b:
            if (num4 != 0)
            {
                return text;
            }
            text += " و ";
            return text + this.getNumberInText(number.Substring(3));
        IL_03ae:
            if (num3 != 0)
            {
                return text;
            }
            text += " و ";
            return text + this.getNumberInText(number.Substring(2));
        IL_02ed:
            if (num2 != 0)
            {
                return text;
            }
            text += " و ";
            string number2 = number.Substring(1);
            return text + this.getNumberInText(number2);
        }
    }
}

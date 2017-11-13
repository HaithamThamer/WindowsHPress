using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using HPress;
namespace HCashier.Report
{
    public partial class ArrivedCatch : DevExpress.XtraReports.UI.XtraReport
    {
        string[] numberOne = {
            "صفر",
            "ئيَك",
            "دوو",
            "سآ",
            "ضار",
            "ثيَنج",
            "شةش",
            "حةفت",
            "هةشت",
            "نةه"
        };
        string[] numberTwo = {
            "دةه",
            "يازداة",
            "دوازداة",
            "سيَسدة",
            "ضاردة",
            "ثازدة",
            "شازدة",
            "هةفدة",
            "هةشدة",
            "نازدة",
        };
        string[] numberThree = {
            "",
            "دةه",
            "بيست",
            "سيه",
            "ضل",
            "ثيَنجى",
            "شيَست",
            "حةفتىَ",
            "هةشتىَ",
            "نوت"
        };
        public ArrivedCatch(int id,string name,double total,DateTime date,double remaining,bool isDinar,string note)
        {
            InitializeComponent();

            //
            //lblDescription.Text = ci.get("description1");
            //lblLocation.Text = ci.get("location");
            //lblEmail.Text = ci.get("email");
            //lblPhone.Text = ci.get("phone");
            //lblDatePrint.Text = DateTime.Now.ToString("yyyy/MM/dd");

            ////
            lblDate.Text = date.ToString("yyyy/MM/dd");
            lblClientName.Text = name;
            lblTotal.Text = total.ToString(isDinar ? "#,###" : "#.##") + (isDinar ? " IQD" : " $");
            lblTotalInText.Text = getNumberInText(total.ToString()) + (isDinar ? " دينار" : " دولار");
            lblId.Text = id.ToString();
            xrBarCode1.Text = id.ToString();
            lblRemaining.Text = remaining.ToString(isDinar ? "#,###" : "#.##") + (isDinar ? " IQD" : " $");
            lblNote.Text = note;
            picMain.Image = Image.FromFile(HPress.Properties.Settings.Default.imageLogo1);
        }
        private string getNumberInText(string number)
        {
            if (number.Contains(".")) return "";
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
                temp += " و ";
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
                    temp += " سةد";
                }
                else
                {
                    temp += " سةد";
                }


                if (number[1].ToString() == "0" && number[2].ToString() == "0") return temp;
                temp += " و ";
                temp += getNumberInText(number.Substring(1));
                return temp;
            }
            if (number.Length == 4)
            {
                if (number[0].ToString() != "1") temp += numberOne[int.Parse(number[0].ToString())];
                temp += " هزار";
                if (number[1].ToString() == "0" && number[2].ToString() == "0" && number[3].ToString() == "0") return temp;
                temp += " و ";
                string s = number.Substring(1);
                temp += getNumberInText(s);
                return temp;
            }
            if (number.Length == 5)
            {
                temp += getNumberInText(number.Substring(0, 2));
                temp += " هزار ";
                if (number[2].ToString() == "0" && number[3].ToString() == "0" && number[4].ToString() == "0") return temp;
                temp += " و ";
                temp += getNumberInText(number.Substring(2));
                return temp;
            }
            if (number.Length == 6)
            {
                temp += getNumberInText(number.Substring(0, 3));
                temp += " هزار ";
                if (number[3].ToString() == "0" && number[4].ToString() == "0" && number[5].ToString() == "0") return temp;
                temp += " و ";
                temp += getNumberInText(number.Substring(3));
                return temp;
            }
            if (number.Length == 7)
            {
                temp += getNumberInText(number.Substring(0, 1));
                temp += " مليون ";
                if (number[1].ToString() == "0" && number[2].ToString() == "0" && number[3].ToString() == "0" && number[4].ToString() == "0" && number[5].ToString() == "0" && number[6].ToString() == "0") return temp;
                temp += " و ";
                temp += getNumberInText(number.Substring(1));
                return temp;
            }
            return "";
        }
    }
}

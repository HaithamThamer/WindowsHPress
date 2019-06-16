using DevExpress.RichEdit.Export;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ButtonPanel;
using DevExpress.XtraReports.UI;
using HCashier.Report;
using HDatabaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPress
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        private HMySQLConnection databaseConnection;

        private bool isEdit = false;

        private int clientId = 0;

        private double paid = 0.0;

        private double remaining = 0.0;

        private bool isKeypress = false;

        private DateTime billDate = DateTime.Now;

        private bool isEditBill = false;

        private bool isAddOnly = false;
        public Main(HMySQLConnection databaseConnection)
        {
            this.InitializeComponent();
            this.databaseConnection = databaseConnection;
            DataTable dataTable = databaseConnection.query("select name from tbl_clients order by id asc");
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    this.cmbClients.Items.Add(dataTable.Rows[i][0].ToString());
                }
                this.cmbClients.Text = this.cmbClients.Items[0].ToString();
            }
            DataTable dataTable2 = databaseConnection.query(string.Format("select name from tbl_clients where type = {0} order by id asc", 2));
            if (dataTable.Rows.Count > 0)
            {
                for (int j = 0; j < dataTable2.Rows.Count; j++)
                {
                    this.cmbDelegates.Items.Add(dataTable2.Rows[j][0].ToString());
                }
                this.cmbDelegates.Text = this.cmbDelegates.Items[0].ToString();
            }
            Properties.Settings.Default.dollarValue = double.Parse(databaseConnection.query("select getDollar(null)").Rows[0][0].ToString());
            this.dateFrom.Value = DateTime.Now;
            if (Properties.Settings.Default.userType == 1)
            {
                this.btnAddClient.Enabled = false;
                this.isSell.Enabled = false;
                this.cmbDelegates.Enabled = false;
            }
            this.dgvProducts.Rows[0].Height = this.dgvProducts.RowTemplate.Height;
            this.btnClear_Click(null, null);
        }

        private void cmbClients_DropDown(object sender, EventArgs e)
        {
            this.cmbClients.Items.Clear();
            DataTable dataTable = this.databaseConnection.query(string.Format("select name from tbl_clients where type = '0' and {0} order by id asc", this.isSell.IsOn ? " is_import = '1' " : " is_export = '1' "));
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    this.cmbClients.Items.Add(dataTable.Rows[i][0].ToString());
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (this.dgvProducts.Rows.Count > 1)
            {
                this.dgvProducts.Rows.Clear();
            }
            this.btnSell.Text = "أدخال وطباعة قائمة";
            this.btnAdd.Text = "أدخال";
            TextBox textBox = this.txtPaid;
            TextBox textBox2 = this.txtDiscount;
            TextBox textBox3 = this.txtTotal;
            string text2 = textBox3.Text = "0";
            string text5 = textBox.Text = (textBox2.Text = text2);
            System.Windows.Forms.ComboBox comboBox = this.cmbBills;
            TextBox textBox4 = this.txtNote;
            TextBox textBox5 = this.txtNote;
            text2 = (textBox5.Text = "");
            text5 = (comboBox.Text = (textBox4.Text = text2));
            ToggleSwitch toggleSwitch = this.isSell;
            ToggleSwitch toggleSwitch2 = this.isAccount;
            ToggleSwitch toggleSwitch3 = this.isCash;
            bool flag2 = toggleSwitch3.IsOn = true;
            bool isOn = toggleSwitch2.IsOn = flag2;
            toggleSwitch.IsOn = isOn;
            this.isDollar.IsOn = false;
            this.cmbBills.Enabled = true;
            this.isEdit = false;
            this.dateFrom.Text = DateTime.Now.ToString();
            this.grpPaid.Text = "المدفوع";
            this.grpTotal.Text = "المجموع";
            this.cmbClients_SelectedIndexChanged(null, null);
            if (this.cmbClients.Items.Count > 0)
            {
                this.cmbClients.SelectedIndex = 0;
            }
            if (this.cmbDelegates.Items.Count > 0)
            {
                this.cmbDelegates.SelectedIndex = 0;
            }
            this.grpPaid.Enabled = false;
            this.isCash.Enabled = true;
            this.remaining = (this.paid = 0.0);
            this.isAddOnly = false;
            this.dateFrom.Value = DateTime.Now;
            this.grpDate.Text = "تاريخ";
            ((ButtonCollectionBase<IBaseButton>)this.grpDate.CustomHeaderButtons)[0].Properties.Checked = false;
            this.billDate = DateTime.Now;
            this.txtDelegateTotal.Text = "0";
        }

        private void isSell_Toggled(object sender, EventArgs e)
        {
            if (!this.isEditBill)
            {
                if (this.isSell.IsOn)
                {
                    this.txtClientName.Text = "وارد";
                    this.grpInfo.Text = "معلومات العميل";
                }
                else
                {
                    this.txtClientName.Text = "صادر";
                    this.grpInfo.Text = "معلومات المورد";
                }
                this.cmbClients_SelectedIndexChanged(null, null);
            }
        }

        private void cmbDelegates_DropDown(object sender, EventArgs e)
        {
            this.cmbDelegates.Items.Clear();
            DataTable dataTable = this.databaseConnection.query(string.Format("select name from tbl_clients where type = {0} order by id asc", 2));
            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    this.cmbDelegates.Items.Add(dataTable.Rows[i][0].ToString());
                }
            }
        }

        private void isCash_Toggled(object sender, EventArgs e)
        {
            this.grpPaid.Enabled = !this.isCash.IsOn;
            this.txtPaid.Text = "0";
        }

        private void txtPaid_Leave(object sender, EventArgs e)
        {
            if (this.txtPaid.Text.Length == 0)
            {
                this.txtPaid.Text = "0";
            }
        }

        private void cmbBills_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                int num = int.Parse(this.cmbBills.Text);
                this.btnClear_Click(null, null);
                this.cmbBills.Text = num.ToString();
                if (this.cmbBills.Text != string.Empty && bool.Parse(this.databaseConnection.query(string.Format("select if((count(id) > 0) = '1','true','false') from tbl_bills where id = '{0}';", this.cmbBills.Text, this.isSell.IsOn ? "1" : "0")).Rows[0][0].ToString()))
                {
                    this.isEditBill = true;
                    DataTable dataTable = this.databaseConnection.query(string.Format("select tbl_bills.is_account,tbl_clients.name,tbl_bills.is_dollar,tbl_bills.is_cash,tbl_bills.note,tbl_bills.datetime,tbl_bills.discount,tbl_bills.name,tbl_bills.location,tbl_bills.phone,tbl_bills.email,tbl_bills.is_sell,(select name from tbl_clients where tbl_clients.id = tbl_bills.delegate_id) from tbl_bills,tbl_clients where tbl_bills.client_id = tbl_clients.id and tbl_bills.id = '{0}'", this.cmbBills.Text));
                    this.isAccount.IsOn = bool.Parse(dataTable.Rows[0][0].ToString());
                    this.cmbClients.Text = dataTable.Rows[0][1].ToString();
                    this.isDollar.IsOn = bool.Parse(dataTable.Rows[0][2].ToString());
                    this.isCash.IsOn = bool.Parse(dataTable.Rows[0][3].ToString());
                    this.txtNote.Text = dataTable.Rows[0][4].ToString();
                    this.billDate = DateTime.Parse(dataTable.Rows[0][5].ToString());
                    this.grpDate.Text = this.billDate.ToString("yyyy-MM-dd");
                    this.txtDiscount.Text = dataTable.Rows[0][6].ToString();
                    this.txtClientName.Text = dataTable.Rows[0][7].ToString();
                    this.txtClientLocation.Text = dataTable.Rows[0][8].ToString();
                    this.txtClientMobile.Text = dataTable.Rows[0][9].ToString();
                    this.txtClientEmail.Text = dataTable.Rows[0][10].ToString();
                    this.isSell.IsOn = bool.Parse(dataTable.Rows[0][11].ToString());
                    this.cmbDelegates.Text = dataTable.Rows[0][12].ToString();
                    DataTable dataTable2 = this.databaseConnection.query(string.Format(" select description,count,price,(price * count) as `total`,note,delegate_percentage from tbl_products where bill_id = '{0}';", this.cmbBills.Text));
                    double num2;
                    for (int i = 0; i < dataTable2.Rows.Count; i++)
                    {
                        DataGridViewRowCollection rows = this.dgvProducts.Rows;
                        object[] obj = new object[7]
                        {
                        i + 1,
                        dataTable2.Rows[i][0].ToString(),
                        null,
                        null,
                        null,
                        null,
                        null
                        };
                        num2 = double.Parse(dataTable2.Rows[i][1].ToString());
                        object text;
                        if (!num2.ToString().Contains("."))
                        {
                            num2 = double.Parse(dataTable2.Rows[i][1].ToString());
                            text = num2.ToString("#,###");
                        }
                        else
                        {
                            num2 = double.Parse(dataTable2.Rows[i][1].ToString());
                            text = num2.ToString();
                        }
                        obj[2] = text;
                        num2 = double.Parse(dataTable2.Rows[i][2].ToString());
                        object text2;
                        if (!num2.ToString().Contains("."))
                        {
                            num2 = double.Parse(dataTable2.Rows[i][2].ToString());
                            text2 = num2.ToString("#,###");
                        }
                        else
                        {
                            num2 = double.Parse(dataTable2.Rows[i][2].ToString());
                            text2 = num2.ToString();
                        }
                        obj[3] = text2;
                        num2 = double.Parse(dataTable2.Rows[i][3].ToString());
                        object text3;
                        if (!num2.ToString().Contains("."))
                        {
                            num2 = double.Parse(dataTable2.Rows[i][3].ToString());
                            text3 = num2.ToString("#,###");
                        }
                        else
                        {
                            num2 = double.Parse(dataTable2.Rows[i][3].ToString());
                            text3 = num2.ToString();
                        }
                        obj[4] = text3;
                        obj[5] = dataTable2.Rows[i][4].ToString();
                        obj[6] = dataTable2.Rows[i]["delegate_percentage"].ToString();
                        rows.Add(obj);
                    }
                    TextBox textBox = this.txtTotal;
                    num2 = this.sum();
                    object text4;
                    if (!num2.ToString().Contains("."))
                    {
                        num2 = this.sum() - double.Parse(this.txtDiscount.Text);
                        text4 = num2.ToString("#,###");
                    }
                    else
                    {
                        num2 = this.sum() - double.Parse(this.txtDiscount.Text);
                        text4 = num2.ToString();
                    }
                    textBox.Text = (string)text4;
                    this.isEdit = true;
                    this.cmbBills.Enabled = false;
                    this.btnSell.Text = "تعديل و طباعة";
                    this.btnAdd.Text = "تعديل";
                    this.paid = double.Parse(this.databaseConnection.query(string.Format("select ifnull(sum(tbl_balance.value*if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1)),0) as `dinar` , ifnull(sum(tbl_balance.value)/if(tbl_balance.is_dollar = 0,getDollar(tbl_balance.creation),1),0) as `dollar` from tbl_balance,tbl_bills where tbl_balance.bill_id = '{0}' and tbl_balance.bill_id = tbl_bills.id", this.cmbBills.Text)).Rows[0][this.isDollar.IsOn ? 1 : 0].ToString());
                    GroupControl groupControl = this.grpTotal;
                    string arg = this.paid.ToString(this.isDollar.IsOn ? "#.## $" : "#,### IQD");
                    num2 = (this.isDollar.IsOn ? (this.paid * Properties.Settings.Default.dollarValue) : (this.paid / Properties.Settings.Default.dollarValue));
                    groupControl.Text = string.Format("{2} ({0} : {1})", arg, num2.ToString((!this.isDollar.IsOn) ? "#.## $" : "#,### IQD"), "المستلم");
                    this.txtTotal.Text = ((this.txtTotal.Text == "") ? "0" : this.txtTotal.Text);
                    this.remaining = double.Parse(this.txtTotal.Text) - this.paid;
                    GroupControl groupControl2 = this.grpPaid;
                    string arg2 = this.remaining.ToString(this.isDollar.IsOn ? "#.## $" : "#,### IQD");
                    num2 = this.isDollar.IsOn ? (this.remaining * Properties.Settings.Default.dollarValue) : (this.remaining / Properties.Settings.Default.dollarValue);
                    groupControl2.Text = string.Format("{2} ({0} : {1})", arg2, num2.ToString((!this.isDollar.IsOn) ? "#.## $" : "#,### IQD"), "المتبقي");
                    ToggleSwitch toggleSwitch = this.isDollar;
                    ToggleSwitch toggleSwitch2 = this.isCash;
                    bool enabled = toggleSwitch2.Enabled = (Properties.Settings.Default.userType == 0);
                    toggleSwitch.Enabled = enabled;
                    TextBox textBox2 = this.txtTotal;
                    num2 = this.sum();
                    object text5;
                    if (!num2.ToString().Contains("."))
                    {
                        num2 = this.sum() - double.Parse(this.txtDiscount.Text);
                        text5 = num2.ToString("#,###");
                    }
                    else
                    {
                        num2 = this.sum() - double.Parse(this.txtDiscount.Text);
                        text5 = num2.ToString();
                    }
                    textBox2.Text = (string)text5;
                    this.txtPaid.Text = ((this.txtPaid.Text.Length == 0) ? "0" : this.txtPaid.Text);
                    this.isEditBill = false;
                    double num3 = 0.0;
                    for (int j = 0; j < this.dgvProducts.Rows.Count - 1; j++)
                    {
                        if (this.dgvProducts.Rows[j].Cells["delegate_percentage"].Value.ToString() == "")
                        {
                            this.dgvProducts.Rows[j].Cells["delegate_percentage"].Value = 0;
                        }
                        num3 += double.Parse(this.dgvProducts.Rows[j].Cells["delegate_percentage"].Value.ToString());
                    }
                    this.txtDelegateTotal.Text = num3.ToString("#,###.##");
                }
            }
            e.Handled = (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar));
        }

        private void dgvProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TextBox textBox = this.txtTotal;
            double num = this.sum();
            object text;
            if (!num.ToString().Contains("."))
            {
                num = this.sum() - double.Parse(this.txtDiscount.Text);
                text = num.ToString("#,###");
            }
            else
            {
                num = this.sum() - double.Parse(this.txtDiscount.Text);
                text = num.ToString();
            }
            textBox.Text = (string)text;
            if (e.RowIndex != -1 && e.ColumnIndex == this.dgvProducts.Columns["delegate_percentage"].Index)
            {
                double num2 = 0.0;
                for (int i = 0; i < this.dgvProducts.Rows.Count - 1; i++)
                {
                    if (this.dgvProducts.Rows[i].Cells["delegate_percentage"].Value.ToString() == "")
                    {
                        this.dgvProducts.Rows[i].Cells["delegate_percentage"].Value = 0;
                    }
                    num2 += double.Parse(this.dgvProducts.Rows[i].Cells["delegate_percentage"].Value.ToString());
                }
                this.txtDelegateTotal.Text = num2.ToString("#,###.##");
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (this.txtDiscount.Text == string.Empty)
            {
                this.txtDiscount.Text = "0";
            }
            else
            {
                TextBox textBox = this.txtTotal;
                double num = this.sum();
                object text;
                if (!num.ToString().Contains("."))
                {
                    num = this.sum() - double.Parse(this.txtDiscount.Text);
                    text = num.ToString("#,###");
                }
                else
                {
                    num = this.sum() - double.Parse(this.txtDiscount.Text);
                    text = num.ToString();
                }
                textBox.Text = (string)text;
            }
        }

        private double sum()
        {
            double num = 0.0;
            if (this.dgvProducts.Rows.Count > 0)
            {
                for (int i = 0; i < this.dgvProducts.Rows.Count - 1; i++)
                {
                    if (this.dgvProducts.Rows[i].Cells["total"].Value != null && !(this.dgvProducts.Rows[i].Cells["total"].Value.ToString() == ""))
                    {
                        num += double.Parse(this.dgvProducts.Rows[i].Cells["total"].Value.ToString());
                    }
                }
            }
            return num;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (this.txtClientName.Text.Length == 0)
            {
                MessageBox.Show("أسم العميل غير صالح");
            }
            else
            {
                DateTime dateTime;
                if (this.isEdit)
                {
                    object[] obj = new object[15]
                    {
                    this.isAccount.IsOn ? "1" : "0",
                    this.cmbClients.Text,
                    (!this.isSell.IsOn) ? 1 : 0,
                    this.isDollar.IsOn ? "1" : "0",
                    this.isCash.IsOn ? "1" : "0",
                    this.txtNote.Text,
                    this.txtDiscount.Text.Replace(",", ""),
                    this.isSell.IsOn ? "1" : "0",
                    this.txtClientName.Text,
                    this.txtClientLocation.Text,
                    this.txtClientMobile.Text,
                    this.txtClientEmail.Text,
                    this.cmbDelegates.Text,
                    null,
                    null
                    };
                    object text;
                    if (!((ButtonCollectionBase<IBaseButton>)this.grpDate.CustomHeaderButtons)[0].Properties.Checked)
                    {
                        text = this.grpDate.Text + " 00:00:00";
                    }
                    else
                    {
                        dateTime = this.dateFrom.Value;
                        text = dateTime.ToString("yyyy-MM-dd 00:00:00");
                    }
                    obj[13] = text;
                    obj[14] = this.cmbBills.Text;
                    string sql = string.Format("update tbl_bills set is_account = '{0}',client_id = (select id from tbl_clients where name = '{1}' and tbl_clients.type = '0'),is_dollar = '{3}',is_cash = '{4}',note = '{5}',discount = '{6}',is_sell = '{7}', name = '{8}', location = '{9}', phone = '{10}' , email = '{11}',delegate_id = (select id from tbl_clients where name = '{12}' and tbl_clients.type = '2') ,datetime = '{13}'  where id = '{14}';", obj);
                    this.databaseConnection.queryNonReader(sql);
                    this.databaseConnection.queryNonReader(string.Format("update tbl_balance set client_id = (select client_id from tbl_bills where tbl_bills.id = '{0}') where tbl_balance.bill_id = '{0}'", this.cmbBills.Text));
                }
                if (this.dgvProducts.Rows.Count > 0)
                {
                    object[] obj2 = new object[14]
                    {
                    this.isAccount.IsOn ? "1" : "0",
                    this.isSell.IsOn ? "1" : "0",
                    this.cmbClients.Text,
                    (!this.isSell.IsOn) ? 1 : 0,
                    this.isDollar.IsOn ? "1" : "0",
                    this.isCash.IsOn ? "1" : "0",
                    this.txtNote.Text,
                    this.txtDiscount.Text,
                    this.txtClientName.Text,
                    this.txtClientLocation.Text,
                    this.txtClientMobile.Text,
                    this.txtClientEmail.Text,
                    this.cmbDelegates.Text,
                    null
                    };
                    dateTime = DateTime.Now;
                    obj2[13] = dateTime.ToString("yyyy-MM-dd 00:00:00");
                    string sql2 = string.Format("insert into tbl_bills (is_account,is_sell,client_id,is_dollar,is_cash,note,discount,name,location,phone,email,delegate_id,datetime) values ('{0}','{1}',(select id from tbl_clients where tbl_clients.name = '{2}' and tbl_clients.`type` = '0' limit 0,1),'{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}',(select id from tbl_clients where tbl_clients.name = '{12}' and tbl_clients.type = '2'),'{13}');select max(id) from tbl_bills;", obj2);
                    int num = this.isEdit ? int.Parse(this.cmbBills.Text) : int.Parse(this.databaseConnection.query(sql2).Rows[0][0].ToString());
                    if (this.isEdit)
                    {
                        this.databaseConnection.queryNonReader(string.Format("delete from tbl_products where bill_id = '{0}';", num));
                    }
                    string text2 = "insert into tbl_products (description,price,count,note,bill_id,delegate_percentage) values ";
                    for (int i = 0; i < this.dgvProducts.Rows.Count - 1; i++)
                    {
                        text2 += string.Format("('{0}','{1}','{2}','{3}','{4}','{5}'),", (this.dgvProducts.Rows[i].Cells["description"].Value == null) ? " " : this.dgvProducts.Rows[i].Cells["description"].Value.ToString(), this.dgvProducts.Rows[i].Cells["price"].Value.ToString().Replace(",", ""), this.dgvProducts.Rows[i].Cells["quantity"].Value.ToString().Replace(",", ""), (this.dgvProducts.Rows[i].Cells["note"].Value == null) ? "" : this.dgvProducts.Rows[i].Cells["note"].Value.ToString(), num.ToString(), this.dgvProducts.Rows[i].Cells["delegate_percentage"].Value.ToString().Replace(",", ""));
                    }
                    text2 = text2.Substring(0, text2.Length - 1);
                    text2 += ";";
                    if (this.dgvProducts.Rows.Count != 1)
                    {
                        this.databaseConnection.queryNonReader(text2);
                    }
                    if (this.txtPaid.Text != "0")
                    {
                        try
                        {
                            HMySQLConnection hMySQLConnection = this.databaseConnection;
                            object[] obj3 = new object[7]
                            {
                            this.cmbClients.Text,
                            (!this.isSell.IsOn) ? 1 : 0,
                            this.txtPaid.Text.Replace(",", ""),
                            num,
                            this.isDollar.IsOn ? "1" : "0",
                            null,
                            null
                            };
                            dateTime = this.dateFrom.Value;
                            obj3[5] = dateTime.ToString("yyyy-MM-dd 00:00:00");
                            obj3[6] = (this.isSell.IsOn ? "1" : "0");
                            hMySQLConnection.queryNonReader(string.Format("insert into tbl_balance (client_id,value,bill_id,is_dollar,creation,is_import) values ((select id from tbl_clients where name = '{0}' and tbl_clients.type = '0'),'{2}','{3}','{4}','{5}','{6}');", obj3));
                        }
                        catch (Exception)
                        {
                            this.databaseConnection.queryNonReader(string.Format("insert into tbl_balance_pay (id) value (1)"));
                            HMySQLConnection hMySQLConnection2 = this.databaseConnection;
                            object[] obj4 = new object[7]
                            {
                            this.cmbClients.Text,
                            (!this.isSell.IsOn) ? 1 : 0,
                            this.txtPaid.Text.Replace(",", ""),
                            num,
                            this.isDollar.IsOn ? "1" : "0",
                            null,
                            null
                            };
                            dateTime = this.dateFrom.Value;
                            obj4[5] = dateTime.ToString("yyyy-MM-dd 00:00:00");
                            obj4[6] = (this.isSell.IsOn ? "1" : "0");
                            hMySQLConnection2.queryNonReader(string.Format("insert into tbl_balance (client_id,value,bill_id,is_dollar,creation,is_import) values ((select id from tbl_clients where name = '{0}' and tbl_clients.type = '0'),'{2}','{3}','{4}','{5}','{6}');", obj4));
                        }
                    }
                    this.remaining = double.Parse(this.databaseConnection.query(string.Format("select ifnull(sum(if(tbl_bills.is_dollar = 1,tbl_balance.value * {0},tbl_balance.value)),0) from tbl_balance,tbl_bills where tbl_balance.bill_id = {1} and tbl_balance.bill_id = tbl_bills.id", Properties.Settings.Default.dollarValue, num)).Rows[0][0].ToString());
                    ReportA4Ar report = new ReportA4Ar(this.dgvProducts, this.isAccount.IsOn, this.isDollar.IsOn, this.cmbBills.Enabled ? this.dateFrom.Value : DateTime.Parse(this.grpDate.Text), DateTime.Now, num, this.clientId, this.txtClientName.Text, this.txtClientMobile.Text, this.txtClientEmail.Text, this.txtClientLocation.Text, double.Parse(this.txtDiscount.Text), double.Parse(this.txtTotal.Text), this.isCash.IsOn, this.isSell.IsOn, this.txtNote.Text, this.isDollar.IsOn ? (this.remaining / Properties.Settings.Default.dollarValue) : this.remaining, double.Parse(this.txtTotal.Text) - this.paid);
                    if (!this.isAddOnly)
                    {
                        ReportPrintTool reportPrintTool = new ReportPrintTool(report);
                        reportPrintTool.PrintDialog();
                    }
                    this.btnClear_Click(null, null);
                }
            }
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = this.databaseConnection.query(string.Format("call getDebits('{0}','{1}')", this.cmbClients.Text, this.isSell.IsOn ? "1" : "0"));
            if (dataTable.Rows.Count != 0)
            {
                this.clientId = int.Parse(dataTable.Rows[0][0].ToString());
                this.txtClientName.Text = dataTable.Rows[0][1].ToString();
                this.txtClientLocation.Text = dataTable.Rows[0][2].ToString();
                this.txtClientMobile.Text = dataTable.Rows[0][3].ToString();
                this.txtClientEmail.Text = dataTable.Rows[0][4].ToString();
                this.txtTotalDinarDebits.Text = dataTable.Rows[0]["remaining_dinar"].ToString();
                this.txtTotalDollarDebits.Text = dataTable.Rows[0]["remaining_dollar"].ToString();
                TextBox textBox = this.txtTotalDinarDebitsFinal;
                double num = double.Parse(dataTable.Rows[0]["remaining_dinar"].ToString()) + double.Parse(dataTable.Rows[0]["remaining_dollar"].ToString()) * Properties.Settings.Default.dollarValue;
                textBox.Text = num.ToString("#,###");
                TextBox textBox2 = this.txtTotalDollarDebitsFinal;
                num = double.Parse(dataTable.Rows[0]["remaining_dollar"].ToString()) + double.Parse(dataTable.Rows[0]["remaining_dinar"].ToString()) / Properties.Settings.Default.dollarValue;
                textBox2.Text = num.ToString("#,###.##");
            }
        }

        private void cmbBills_DropDown(object sender, EventArgs e)
        {
            this.cmbBills.Items.Clear();
            DataTable dataTable = this.databaseConnection.query(string.Format("select tbl_bills.id from tbl_bills,tbl_clients where is_account = '{0}'  and is_cash = '{1}' and is_sell = '{3}' and tbl_bills.client_id = tbl_clients.id and tbl_clients.name = '{2}' and tbl_bills.id > 0 {4} order by tbl_bills.id desc ", this.isAccount.IsOn ? "1" : "0", this.isCash.IsOn ? "1" : "0", this.cmbClients.Text, this.isSell.IsOn ? "1" : "0", (this.cmbDelegates.SelectedIndex == 0) ? " " : string.Format("and  tbl_bills.delegate_id = (select tbl_clients.id from tbl_clients where tbl_clients.`type` = 2 and tbl_clients.name = '{0}')", this.cmbDelegates.Text)));
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                this.cmbBills.Items.Add(dataTable.Rows[i][0].ToString());
            }
        }

        private void dgvProducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            TextBox textBox = this.txtTotal;
            double num = this.sum();
            object text;
            if (!num.ToString().Contains("."))
            {
                num = this.sum() - double.Parse(this.txtDiscount.Text);
                text = num.ToString("#,###");
            }
            else
            {
                num = this.sum() - double.Parse(this.txtDiscount.Text);
                text = num.ToString();
            }
            textBox.Text = (string)text;
            if (this.dgvProducts.Rows.Count > 1)
            {
                for (int i = 0; i < this.dgvProducts.Rows.Count - 1; i++)
                {
                    this.dgvProducts.Rows[i].Cells[0].Value = (i + 1).ToString();
                }
            }
        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
            if (this.txtClientName.Text.Length > 0 && this.isKeypress)
            {
                this.isKeypress = false;
                this.dgvClientsNames.Visible = true;
                this.dgvClientsNames.DataSource = this.databaseConnection.query(string.Format("select tbl_clients.name from tbl_clients where tbl_clients.name like '%{0}%';", this.txtClientName.Text));
                this.dgvClientsNames.Columns["name"].HeaderText = "أسم العميل";
            }
            else
            {
                this.dgvClientsNames.Visible = false;
            }
            if (this.dgvClientsNames.Rows.Count == 0)
            {
                this.dgvClientsNames.Visible = false;
            }
        }

        private void txtClientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.isKeypress = true;
        }

        private void dgvClientsNames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.cmbClients.Text = this.dgvClientsNames.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.cmbClients_SelectedIndexChanged(null, null);
        }

        private void dgvProducts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= this.Column1_KeyPress;
            if (this.dgvProducts.CurrentCell.ColumnIndex == this.dgvProducts.Columns["price"].Index || this.dgvProducts.CurrentCell.ColumnIndex == this.dgvProducts.Columns["quantity"].Index || this.dgvProducts.CurrentCell.ColumnIndex == this.dgvProducts.Columns["total"].Index || this.dgvProducts.CurrentCell.ColumnIndex == this.dgvProducts.Columns["delegate_percentage"].Index)
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += this.Column1_KeyPress;
                    textBox.TextChanged += this.Tb_TextChanged;
                }
            }
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!((sender as TextBox).Text == "0") && (sender as TextBox).Text.Length > 0 && !(sender as TextBox).Text.Contains("."))
                {
                    (sender as TextBox).Text = (((sender as TextBox).Text == "") ? "0" : double.Parse((sender as TextBox).Text).ToString(this.isDollar.IsOn ? "#.##" : "#,###"));
                    (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
                }
            }
            catch (Exception)
            {
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int num;
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '.' && e.KeyChar != '.' && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                num = ((e.KeyChar == '-') ? 1 : 0);
                goto IL_0049;
            }
            num = 1;
            goto IL_0049;
        IL_0049:
            if (num != 0)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.cmbDelegates.Text == string.Empty || this.cmbClients.Text == string.Empty)
            {
                MessageBox.Show("المندوب أو العميل فارغ");
            }
            else
            {
                this.isAddOnly = true;
                this.btnSell_Click(null, null);
            }
        }

        private void dgvProducts_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.sumRow(e.RowIndex);
            double num = 0.0;
            for (int i = 0; i < this.dgvProducts.Rows.Count - 1; i++)
            {
                if (this.dgvProducts.Rows[i].Cells["total"].Value.ToString() == "")
                {
                    this.dgvProducts.Rows[i].Cells["total"].Value = "0";
                }
                if (this.dgvProducts.Rows[i].Cells["delegate_percentage"].Value != null && this.dgvProducts.Rows[i].Cells["delegate_percentage"].Value.ToString() == "")
                {
                    this.dgvProducts.Rows[i].Cells["delegate_percentage"].Value = "0";
                }
                num += double.Parse(this.dgvProducts.Rows[i].Cells["total"].Value.ToString());
                TextBox textBox = this.txtTotal;
                double num2;
                object text;
                if (!num.ToString().Contains("."))
                {
                    num2 = num - double.Parse(this.txtDiscount.Text);
                    text = num2.ToString("#,###");
                }
                else
                {
                    num2 = num - double.Parse(this.txtDiscount.Text);
                    text = num2.ToString();
                }
                textBox.Text = (string)text;
            }
        }

        private void sumRow(int rowId)
        {
            double num = 0.0;
            if (this.dgvProducts.Rows[rowId].Cells["quantity"].Value == null)
            {
                this.dgvProducts.Rows[rowId].Cells["quantity"].Value = "0";
            }
            if (this.dgvProducts.Rows[rowId].Cells["price"].Value == null)
            {
                this.dgvProducts.Rows[rowId].Cells["price"].Value = "0";
            }
            this.dgvProducts.Rows[rowId].Cells["total"].Value = (double.Parse(this.dgvProducts.Rows[rowId].Cells["quantity"].Value.ToString()) * double.Parse(this.dgvProducts.Rows[rowId].Cells["price"].Value.ToString())).ToString();
            num = double.Parse(this.dgvProducts.Rows[rowId].Cells["total"].Value.ToString());
            this.dgvProducts.Rows[rowId].Cells["total"].Value = (this.dgvProducts.Rows[rowId].Cells["total"].Value.ToString().Contains(".") ? num.ToString() : num.ToString("#,###"));
        }

        private void dgvProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvProducts.CurrentRow.Cells["description"].Value == null)
            {
                this.dgvProducts.CurrentRow.Cells["description"].Value = "";
            }
            if (this.dgvProducts.CurrentRow.Cells["note"].Value == null)
            {
                this.dgvProducts.CurrentRow.Cells["note"].Value = "";
            }
            if (this.dgvProducts.CurrentRow.Cells["delegate_percentage"].Value == null)
            {
                this.dgvProducts.CurrentRow.Cells["delegate_percentage"].Value = "0";
            }
            this.dgvProducts.CurrentRow.Cells["id"].Value = this.dgvProducts.Rows.Count - 1;
            this.sumRow(e.RowIndex);
        }

        private void تكرارالقيدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvProducts.CurrentRow.Cells[0].Value != null && this.dgvProducts.CurrentRow.Cells[1].Value != null && this.dgvProducts.CurrentRow.Cells[2].Value != null && this.dgvProducts.CurrentRow.Cells[3].Value != null)
            {
                this.dgvProducts.Rows.Add(this.dgvProducts.Rows.Count, this.dgvProducts.CurrentRow.Cells[1].Value, this.dgvProducts.CurrentRow.Cells[2].Value, this.dgvProducts.CurrentRow.Cells[3].Value, this.dgvProducts.CurrentRow.Cells[4].Value);
                double num = 0.0;
                for (int i = 0; i < this.dgvProducts.Rows.Count - 1; i++)
                {
                    if (this.dgvProducts.Rows[i].Cells["total"].Value != null)
                    {
                        num += double.Parse(this.dgvProducts.Rows[i].Cells["total"].Value.ToString());
                    }
                }
                TextBox textBox = this.txtTotal;
                double num2;
                object text;
                if (!num.ToString().Contains("."))
                {
                    num2 = num - double.Parse(this.txtDiscount.Text);
                    text = num2.ToString("#,###");
                }
                else
                {
                    num2 = num - double.Parse(this.txtDiscount.Text);
                    text = num2.ToString();
                }
                textBox.Text = (string)text;
            }
        }

        private void حذفالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvProducts.CurrentRow.Index != this.dgvProducts.Rows.Count - 1)
            {
                this.dgvProducts.Rows.RemoveAt(this.dgvProducts.CurrentRow.Index);
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string a = this.databaseConnection.query(string.Format("select count(id) from tbl_clients where name = '{0}' and type = '0'", this.txtClientName.Text, (!this.isSell.IsOn) ? 1 : 0)).Rows[0][0].ToString();
            if (a != "1")
            {
                this.databaseConnection.queryNonReader(string.Format("insert into tbl_clients (name,location,mobile,email,type) values ('{0}','{1}','{2}','{3}',0);", this.txtClientName.Text, this.txtClientLocation.Text, this.txtClientMobile.Text, this.txtClientEmail.Text, (!this.isSell.IsOn) ? 1 : 0));
                this.cmbClients.Text = this.txtClientName.Text;
            }
            else
            {
                MessageBox.Show("موجود بلفعل!");
            }
        }

        private void isDollar_Toggled(object sender, EventArgs e)
        {
            double num = double.Parse(this.databaseConnection.query(string.Format("select getDollar('{0}');", this.billDate.ToString("yyyy-MM-dd"))).Rows[0][0].ToString());
            for (int i = 0; i < this.dgvProducts.Rows.Count - 1; i++)
            {
                this.dgvProducts.Rows[i].Cells["price"].Value = ((!this.isDollar.IsOn) ? (double.Parse(this.dgvProducts.Rows[i].Cells["price"].Value.ToString()) * num) : (double.Parse(this.dgvProducts.Rows[i].Cells["price"].Value.ToString()) / num));
                this.dgvProducts.Rows[i].Cells["total"].Value = double.Parse(this.dgvProducts.Rows[i].Cells["price"].Value.ToString()) * double.Parse(this.dgvProducts.Rows[i].Cells["quantity"].Value.ToString());
            }
            TextBox textBox = this.txtDiscount;
            double num2 = this.isDollar.IsOn ? (double.Parse(this.txtDiscount.Text) / num) : (double.Parse(this.txtDiscount.Text) * num);
            textBox.Text = num2.ToString();
            this.txtPaid.Text = ((this.txtPaid.Text == "") ? "0" : this.txtPaid.Text);
            if (this.txtPaid.Text.Length > 0)
            {
                TextBox textBox2 = this.txtPaid;
                num2 = (this.isDollar.IsOn ? (double.Parse(this.txtPaid.Text) / num) : (double.Parse(this.txtPaid.Text) * num));
                textBox2.Text = num2.ToString();
            }
            else
            {
                this.txtPaid.Text = "0";
            }
            TextBox textBox3 = this.txtTotal;
            num2 = this.sum();
            object text;
            if (!num2.ToString().Contains("."))
            {
                num2 = this.sum() - double.Parse(this.txtDiscount.Text);
                text = num2.ToString("#,###");
            }
            else
            {
                num2 = this.sum() - double.Parse(this.txtDiscount.Text);
                text = num2.ToString();
            }
            textBox3.Text = (string)text;
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            this.txtDiscount.Text = ((this.txtDiscount.Text.Length == 0) ? "0" : this.txtDiscount.Text);
        }

        private void حذفالقائمةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num;
            if ((this.txtTotal.Text == "0" || this.txtTotal.Text.Length == 0) && MessageBox.Show("", "", MessageBoxButtons.OKCancel) == DialogResult.OK && !this.cmbBills.Enabled)
            {
                num = ((Properties.Settings.Default.userType == 0) ? 1 : 0);
                goto IL_005a;
            }
            num = 0;
            goto IL_005a;
        IL_005a:
            if (num != 0)
            {
                this.databaseConnection.queryNonReader(string.Format("delete from tbl_bills where id = '{0}'", this.cmbBills.Text));
                this.btnClear_Click(null, null);
            }
        }

        private void طباعةوصلقبضToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.isEdit)
            {
                if (this.isCash.IsOn || this.cmbClients.Text == "نقدي")
                {
                    ReportPrintTool reportPrintTool = new ReportPrintTool(new ArrivedCatch(int.Parse(this.cmbBills.Text), this.txtClientName.Text, double.Parse(this.txtTotal.Text), DateTime.Parse(this.grpDate.Text), 0.0, !this.isDollar.IsOn, this.txtNote.Text, this.isSell.IsOn));
                    reportPrintTool.PrintDialog();
                }
                this.btnAdd_Click(null, null);
            }
        }

        private void cmbDelegates_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgvProducts.Columns["delegate_percentage"].Visible = (this.cmbDelegates.Text != "العام");
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && '¾' == e.KeyChar);
            int num;
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                num = ((e.KeyChar == '¾') ? 1 : 0);
                goto IL_0069;
            }
            num = 1;
            goto IL_0069;
        IL_0069:
            if (num != 0)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}

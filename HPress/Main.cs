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
        HDatabaseConnection.HMySQLConnection databaseConnection;
        bool isEdit = false;
        int clientId = 0;
        double paid = 0, remaining = 0;
        bool isKeypress = false;
        public Main(HDatabaseConnection.HMySQLConnection databaseConnection)
        {
            InitializeComponent();
            this.databaseConnection = databaseConnection;
            DataTable dt = databaseConnection.query("select name from tbl_clients order by id asc");

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbClients.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            cmbClients.Text = cmbClients.Items[0].ToString();

            DataTable dt2 = databaseConnection.query(string.Format("select name from tbl_clients where is_active = 1 and type = {0} order by id asc", (int)Enumerators.clientType.Delegate));
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    cmbDelegates.Items.Add(dt2.Rows[i][0].ToString());
                }
            }

            cmbDelegates.Text = cmbDelegates.Items.Count > 0 ? cmbDelegates.Items[0].ToString() : "";
            Properties.Settings.Default.dollarValue = double.Parse(databaseConnection.query(string.Format("select getDollar(null)")).Rows[0][0].ToString());
            grpInfo.CustomButtonClick += GrpInfo_CustomButtonClick;
            dateFrom.Value = DateTime.Now;

            if (Properties.Settings.Default.userType == (int)Enumerators.UserType.User)
            {
                txtDelegatePercent.Visible = false;
                //btnBalance.Enabled = false;
            }
            //txtProductDescription.Focus();

            dgvProducts.Rows[0].Height = dgvProducts.RowTemplate.Height;
            btnClear_Click(null, null);

        }
        private void GrpInfo_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
                case "جديد":
                    try
                    {
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("السلام الجمهوري : هذا المشترك موجود مسبقا .. اكتب عدل");
                    }
                    break;
                default:
                    break;
            }
        }
        private void cmbClients_DropDown(object sender, EventArgs e)
        {
            cmbClients.Items.Clear();
            System.Data.DataTable dt = databaseConnection.query(string.Format("select name from tbl_clients where type = '{0}' order by id asc", isSell.IsOn ? (int)Enumerators.clientType.Client : (int)Enumerators.clientType.Supplier));
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbClients.Items.Add(dt.Rows[i][0].ToString());
                }
            }
        }
        DateTime billDate = DateTime.Now;
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (dgvProducts.Rows.Count > 1)
            {
                dgvProducts.Rows.Clear();
            }
            btnSell.Text = "أدخال وطباعة قائمة";
            btnAdd.Text = "أدخال";
            txtPaid.Text = txtDiscount.Text = txtTotal.Text = "0";
            //cmbBills.Text = txtNote.Text = txtProductPrice.Text = txtProductNote.Text = txtProductDescription.Text = txtProductCount.Text = txtNote.Text = "";

            cmbBills.Text = txtNote.Text  = txtNote.Text = "";
            isSell.IsOn = isAccount.IsOn = isCash.IsOn = true;
            isDollar.IsOn = false;
            cmbBills.Enabled = true;
            isEdit = false;
            dateFrom.Text = DateTime.Now.ToString();
            cmbClients.SelectedIndex = 0;
            grpPaid.Text = "المدفوع";
            grpTotal.Text = "المجموع";
            cmbClients_SelectedIndexChanged(null, null);
            cmbClients.SelectedIndex = 0;
            cmbDelegates.SelectedIndex = 0;
            grpPaid.Enabled = false;
            isCash.Enabled = true;
            remaining = paid = 0;
            isAddOnly = false;
            dateFrom.Value = DateTime.Now;
            grpDate.Text = "تاريخ";
            grpDate.CustomHeaderButtons[0].Properties.Checked = false;
            txtDelegatePercent.Text = "0";
            cmbDelegates.SelectedIndex = 0;
            billDate = DateTime.Now;
        }

        private void isAccount_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void isSell_Toggled(object sender, EventArgs e)
        {
            if (isSell.IsOn)
            {
                txtClientName.Text = "وارد";
                grpInfo.Text = "معلومات العميل";
            }
            else
            {
                txtClientName.Text = "صادر";
                grpInfo.Text = "معلومات المورد";

            }
            cmbClients_DropDown(null, null);
            cmbClients.Text = cmbClients.Items.Count > 0 ? cmbClients.Items[0].ToString() : "";
        }

        private void cmbDelegates_DropDown(object sender, EventArgs e)
        {
            cmbDelegates.Items.Clear();
            System.Data.DataTable dt = databaseConnection.query(string.Format("select name from tbl_clients where is_active = 1 and type = {0} order by id asc", (int)Enumerators.clientType.Delegate));
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmbDelegates.Items.Add(dt.Rows[i][0].ToString());
                }
            }
        }

        private void isCash_Toggled(object sender, EventArgs e)
        {
            grpPaid.Enabled = !isCash.IsOn;
            txtPaid.Text = "0";
        }

        private void txtPaid_Leave(object sender, EventArgs e)
        {
            if (txtPaid.Text.Length == 0)
                txtPaid.Text = "0";
        }
        
        private void cmbBills_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int id = int.Parse(cmbBills.Text);
                btnClear_Click(null, null);
                cmbBills.Text = id.ToString();
                if (cmbBills.Text != string.Empty && bool.Parse(databaseConnection.query(string.Format("select if((count(id) > 0) = '1','true','false') from tbl_bills where id = '{0}';", cmbBills.Text, isSell.IsOn ? "1" : "0")).Rows[0][0].ToString()))
                {
                    //Info
                    System.Data.DataTable info = databaseConnection.query(string.Format("select tbl_bills.is_account,tbl_clients.name,tbl_bills.is_dollar,tbl_bills.is_cash,tbl_bills.note,tbl_bills.datetime,tbl_bills.discount,tbl_bills.name,tbl_bills.location,tbl_bills.phone,tbl_bills.email,tbl_bills.is_sell,(select name from tbl_clients where tbl_clients.id = tbl_bills.delegate_id),tbl_bills.delegate_percent from tbl_bills,tbl_clients where tbl_bills.client_id = tbl_clients.id and tbl_bills.id = '{0}'", cmbBills.Text));
                    isAccount.IsOn = bool.Parse(info.Rows[0][0].ToString());
                    cmbClients.Text = info.Rows[0][1].ToString();
                    isDollar.IsOn = bool.Parse(info.Rows[0][2].ToString());
                    isCash.IsOn = bool.Parse(info.Rows[0][3].ToString());
                    txtNote.Text = info.Rows[0][4].ToString();
                    billDate = DateTime.Parse(info.Rows[0][5].ToString());
                    grpDate.Text = billDate.ToString("yyyy-MM-dd");
                    txtDiscount.Text = info.Rows[0][6].ToString();
                    txtClientName.Text = info.Rows[0][7].ToString();
                    txtClientLocation.Text = info.Rows[0][8].ToString();
                    txtClientMobile.Text = info.Rows[0][9].ToString();
                    txtClientEmail.Text = info.Rows[0][10].ToString();
                    isSell.IsOn = bool.Parse(info.Rows[0][11].ToString());
                    cmbDelegates.Text = info.Rows[0][12].ToString();
                    txtDelegatePercent.Text = info.Rows[0][13].ToString(); ;

                    System.Data.DataTable dt = databaseConnection.query(string.Format(" select description,count,price,(price * count) as `total`,note from tbl_products where bill_id = '{0}';", cmbBills.Text));
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dgvProducts.Rows.Add(i + 1, dt.Rows[i][0].ToString(), double.Parse(dt.Rows[i][1].ToString()).ToString().Contains(".") ? double.Parse(dt.Rows[i][1].ToString()).ToString() : double.Parse(dt.Rows[i][1].ToString()).ToString("#,###"), double.Parse(dt.Rows[i][2].ToString()).ToString().Contains(".") ? double.Parse(dt.Rows[i][2].ToString()).ToString() : double.Parse(dt.Rows[i][2].ToString()).ToString("#,###"), double.Parse(dt.Rows[i][3].ToString()).ToString().Contains(".") ? double.Parse(dt.Rows[i][3].ToString()).ToString() : double.Parse(dt.Rows[i][3].ToString()).ToString("#,###"), dt.Rows[i][4].ToString());
                    }
                    txtTotal.Text = sum().ToString().Contains(".") ? (sum() - double.Parse(txtDiscount.Text)).ToString() : (sum() - double.Parse(txtDiscount.Text)).ToString("#,###");
                    isEdit = true;
                    cmbBills.Enabled = false;
                    btnSell.Text = "تعديل و طباعة";
                    btnAdd.Text = "تعديل";
                    paid = double.Parse(databaseConnection.query(string.Format("select ifnull(sum(tbl_balance.value*if(tbl_balance.is_dollar = 1,getDollar(tbl_balance.creation),1)),0) as `dinar` , ifnull(sum(tbl_balance.value)/if(tbl_balance.is_dollar = 0,getDollar(tbl_balance.creation),1),0) as `dollar` from tbl_balance,tbl_bills where tbl_balance.bill_id = '{0}' and tbl_balance.bill_id = tbl_bills.id", cmbBills.Text)).Rows[0][isDollar.IsOn ? 1 : 0].ToString());
                    grpTotal.Text = string.Format("{2} ({0} : {1})", paid.ToString(isDollar.IsOn ? "#.## $" : "#,### IQD"), (isDollar.IsOn ? paid * Properties.Settings.Default.dollarValue : paid / Properties.Settings.Default.dollarValue).ToString(!isDollar.IsOn ? "#.## $" : "#,### IQD"),"المستلم");
                    //double d = double.Parse(databaseConnection.query(string.Format("select getDollar('{0}')", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"))).Rows[0][0].ToString());
                    txtTotal.Text = txtTotal.Text == "" ? "0" : txtTotal.Text;
                    remaining = double.Parse(txtTotal.Text) - paid;
                    grpPaid.Text = string.Format("{2} ({0} : {1})", remaining.ToString(isDollar.IsOn ? "#.## $" : "#,### IQD"), (isDollar.IsOn ? remaining * Properties.Settings.Default.dollarValue : remaining / Properties.Settings.Default.dollarValue).ToString(!isDollar.IsOn ? "#.## $" : "#,### IQD"), "المتبقي");
                    isDollar.Enabled = isCash.Enabled = Properties.Settings.Default.userType == (int)Enumerators.UserType.Admin;
                    txtTotal.Text = sum().ToString().Contains(".") ? (sum() - double.Parse(txtDiscount.Text)).ToString() : (sum() - double.Parse(txtDiscount.Text)).ToString("#,###");
                    txtPaid.Text = txtPaid.Text.Length == 0 ? "0" : txtPaid.Text;
                }
            }
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dgvProducts_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            txtTotal.Text = sum().ToString().Contains(".") ? (sum() - double.Parse(txtDiscount.Text)).ToString() : (sum() - double.Parse(txtDiscount.Text)).ToString("#,###");
        }

        private void txtClientName_Leave(object sender, EventArgs e)
        {
            
        }

        private void cmbDelegates_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDelegatePercent.Text = databaseConnection.query(string.Format("select percent from tbl_clients where tbl_clients.name = '{0}' and type = 2;", cmbDelegates.Text)).Rows[0][0].ToString();

        }

        private void dgvProducts_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //if (dgvProducts.Rows.Count >= 17)
            //{
            //    dgvProducts.AllowUserToAddRows = false;
            //    return;
            //}
        }

        private void txtProductNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnProductAdd_Click(null, null);
            }
        }
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text == string.Empty )
            {
                txtDiscount.Text = "0";
            }
            else
            {
                //Tb_TextChanged(sender, null);
                txtTotal.Text = sum().ToString().Contains(".") ? (sum() - double.Parse(txtDiscount.Text)).ToString() : (sum() - double.Parse(txtDiscount.Text)).ToString("#,###");
            }

        }
        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            //if (
            //    txtProductDescription.Text != string.Empty &&
            //    txtProductCount.Text != string.Empty &&
            //    txtProductPrice.Text != string.Empty
            //    )
            //{
            //    dgvProducts.Rows.Add(
            //        (double.Parse(txtProductCount.Text) * double.Parse(txtProductPrice.Text)).ToString(),
            //        txtProductDescription.Text,
            //        txtProductCount.Text,
            //        txtProductPrice.Text,
            //        txtProductNote.Text
            //        );
            //    txtTotal.Text = sum().ToString();
            //    txtProductPrice.Text = txtProductNote.Text = txtProductDescription.Text = txtProductCount.Text = "";
            //    txtProductDescription.Focus();
            //}
        }

        double sum()
        {
            double sum = 0;
            if (dgvProducts.Rows.Count > 0)
            {

                for (int i = 0; i < dgvProducts.Rows.Count - 1; i++)
                {
                    if (dgvProducts.Rows[i].Cells["total"].Value == null  || dgvProducts.Rows[i].Cells["total"].Value.ToString() == "")
                    {
                        continue;
                    }
                    sum += double.Parse(dgvProducts.Rows[i].Cells["total"].Value.ToString());
                }
            }
            return sum ;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {

            if (txtClientName.Text.Length == 0)
            {
                MessageBox.Show("أسم العميل غير صالح");
                return;
            }

            if (isEdit)
            {
                string s = string.Format(
                    "update tbl_bills set is_account = '{0}',client_id = (select id from tbl_clients where name = '{1}' and tbl_clients.type = '{2}'),is_dollar = '{3}',is_cash = '{4}',note = '{5}',discount = '{6}',is_sell = '{7}', name = '{8}', location = '{9}', phone = '{10}' , email = '{11}',delegate_id = (select id from tbl_clients where name = '{12}' and tbl_clients.type = '2') ,datetime = '{13}' ,delegate_percent = '{14}' where id = '{15}';",
                    isAccount.IsOn ? "1" : "0",
                    cmbClients.Text,
                    isSell.IsOn ? (int)Enumerators.clientType.Client : (int)Enumerators.clientType.Supplier,
                    isDollar.IsOn ? "1" : "0",
                    isCash.IsOn ? "1" : "0",
                    txtNote.Text,
                    txtDiscount.Text.Replace(",",""),
                    isSell.IsOn ? "1" : "0",
                    txtClientName.Text,
                    txtClientLocation.Text,
                    txtClientMobile.Text,
                    txtClientEmail.Text,
                    cmbDelegates.Text,
                    grpDate.CustomHeaderButtons[0].Properties.Checked ? dateFrom.Value.ToString("yyyy-MM-dd 00:00:00") : grpDate.Text + " 00:00:00",
                    txtDelegatePercent.Text,
                    cmbBills.Text
                    );
                databaseConnection.queryNonReader(s);
                databaseConnection.queryNonReader(string.Format("update tbl_balance set client_id = (select client_id from tbl_bills where tbl_bills.id = '{0}') where tbl_balance.bill_id = '{0}'", cmbBills.Text));
            }
            if (dgvProducts.Rows.Count > 0)
            {
                //insert into tbl_bills (is_account,is_sell,client_id,is_dollar,is_cash,note,discount,name,location,phone,email,delegate_id,datetime) values ('1','1',(select id from tbl_clients where tbl_clients.name = 'نقدي'),'0','1','','0','نقدي','دهوك','0750','@',(select id from tbl_clients where tbl_clients.name = '222'),'2017-03-01 00:00:00');select max(id) from tbl_bills;
                string s = string.Format("insert into tbl_bills (is_account,is_sell,client_id,is_dollar,is_cash,note,discount,name,location,phone,email,delegate_id,datetime,delegate_percent) values ('{0}','{1}',(select id from tbl_clients where tbl_clients.name = '{2}' and tbl_clients.`type` = '{3}' limit 0,1),'{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}',(select id from tbl_clients where tbl_clients.name = '{12}' and tbl_clients.type = '2'),'{13}','{14}');select max(id) from tbl_bills;",
                    isAccount.IsOn ? "1" : "0",
                    isSell.IsOn ? "1" : "0",
                    cmbClients.Text,
                    isSell.IsOn ? (int)Enumerators.clientType.Client : (int)Enumerators.clientType.Supplier,
                    isDollar.IsOn ? "1" : "0",
                    isCash.IsOn ? "1" : "0",
                    txtNote.Text,
                    txtDiscount.Text,
                    txtClientName.Text,
                    txtClientLocation.Text,
                    txtClientMobile.Text,
                    txtClientEmail.Text,
                    cmbDelegates.Text,
                    DateTime.Now.ToString("yyyy-MM-dd 00:00:00"),
                    txtDelegatePercent.Text
                    );
                int id = isEdit ? int.Parse(cmbBills.Text) : int.Parse(databaseConnection.query(s).Rows[0][0].ToString());
                if (isEdit)
                    databaseConnection.queryNonReader(string.Format("delete from tbl_products where bill_id = '{0}';", id));
                string sql = "insert into tbl_products (description,price,count,note,bill_id) values ";
                for (int i = 0; i < dgvProducts.Rows.Count - 1; i++)
                {
                    
                    sql += string.Format("('{0}','{1}','{2}','{3}','{4}'),",
                        dgvProducts.Rows[i].Cells["description"].Value == null ? " " : dgvProducts.Rows[i].Cells["description"].Value.ToString(),
                        dgvProducts.Rows[i].Cells["price"].Value.ToString().Replace(",",""),
                        dgvProducts.Rows[i].Cells["quantity"].Value.ToString().Replace(",", ""),
                        dgvProducts.Rows[i].Cells["note"].Value == null ? "": dgvProducts.Rows[i].Cells["note"].Value.ToString(),
                        id.ToString());
                }
                sql = sql.Substring(0, sql.Length - 1);
                sql += ";";

                if (dgvProducts.Rows.Count != 1)
                {
                    databaseConnection.queryNonReader(sql);
                }
                if (txtPaid.Text != "0")
                {
                    databaseConnection.queryNonReader(string.Format("insert into tbl_balance (client_id,value,bill_id,is_dollar,creation,is_import) values ((select id from tbl_clients where name = '{0}' and tbl_clients.type = '{1}'),'{2}','{3}','{4}','{5}','{6}');", cmbClients.Text,isSell.IsOn ? (int)Enumerators.clientType.Client : (int)Enumerators.clientType.Supplier, txtPaid.Text.Replace(",",""), id, isDollar.IsOn ? "1" : "0", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"),isSell.IsOn ? "1" : "0"));
                }
                remaining = double.Parse(databaseConnection.query(string.Format("select ifnull(sum(if(tbl_bills.is_dollar = 1,tbl_balance.value * {0},tbl_balance.value)),0) from tbl_balance,tbl_bills where tbl_balance.bill_id = {1} and tbl_balance.bill_id = tbl_bills.id", Properties.Settings.Default.dollarValue, id)).Rows[0][0].ToString());
                ReportA4 reportA4 = new ReportA4(
                    dgvProducts,
                    isAccount.IsOn,
                    isDollar.IsOn,
                    dateFrom.Value,
                    DateTime.Now,
                    id,
                    clientId,
                    txtClientName.Text,
                    txtClientMobile.Text,
                    txtClientEmail.Text,
                    txtClientLocation.Text,
                    double.Parse(txtDiscount.Text),
                    double.Parse(txtTotal.Text),
                    isCash.IsOn,
                    txtNote.Text,
                    isDollar.IsOn ? remaining / Properties.Settings.Default.dollarValue : remaining,
                    //paid,
                    double.Parse(txtTotal.Text) - paid
                    );
                reportA4.ExportToPdf("D:\\Report_sell.pdf");

                if (!isAddOnly)
                {
                    DevExpress.XtraReports.UI.ReportPrintTool rpt = new DevExpress.XtraReports.UI.ReportPrintTool(reportA4);
                    rpt.PrintDialog();
                }
                //string senderEmail = "HPress@gmail.com";
                //string senderPassword = "Halabja2016";
                //string senderNickname = "ADS";
                //string messageSubject = "مطبعة حلبجة";
                //string messageBody = cmbClients.Text;
                //string receiverEmail = txtClientEmail.Text;
                //string receiverNickname = txtClientName.Text;

                ////
                //MailAddress fromAddress = new MailAddress(senderEmail, senderNickname);
                //MailAddress toAddress = new MailAddress(receiverEmail, receiverNickname);

                //SmtpClient sc = new SmtpClient();
                //sc.Host = "smtp.gmail.com";
                //sc.Port = 587;
                //sc.EnableSsl = true;
                //sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                //sc.UseDefaultCredentials = false;
                //sc.Credentials = new NetworkCredential(fromAddress.Address, senderPassword);

                //MailMessage mm = new MailMessage(fromAddress, toAddress);
                //mm.Subject = messageSubject;
                //mm.Body = cmbClients.Text;

                //mm.Attachments.Add(new Attachment("D:\\Report_sell.pdf", MediaTypeNames.Application.Pdf));
                //sc.Send(mm);

                this.btnClear_Click(null, null);
            }
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Data.DataTable dt = databaseConnection.query(string.Format("select id,name,location, mobile, email,ifnull((ifnull((select SUM(IF(tbl_balance.is_dollar = 1 ,tbl_balance.value * getDollar(tbl_balance.creation),tbl_balance.value)) from tbl_balance,tbl_bills where tbl_balance.client_id = tbl_clients.id and tbl_bills.id = tbl_balance.bill_id and tbl_bills.is_sell = 1 and tbl_balance.is_import = 1),0) - ifnull((select sum(if(tbl_bills.is_dollar = 0,tbl_products.price  * tbl_products.count,tbl_products.price*getDollar(tbl_bills.datetime)  * tbl_products.count)) from tbl_products,tbl_bills where tbl_products.bill_id = tbl_bills.id and tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1),0) + (select sum(ifnull(if(tbl_bills.is_dollar = 1,tbl_bills.discount * getDollar(tbl_bills.`datetime`),tbl_bills.discount),0)) from tbl_bills where tbl_bills.client_id = tbl_clients.id and tbl_bills.is_cash = 0 and tbl_bills.is_sell = 1)),0) as `remaining`from tbl_clients where name = '{0}'", cmbClients.Text));
            clientId = int.Parse(dt.Rows[0][0].ToString());
            txtClientName.Text = dt.Rows[0][1].ToString();
            txtClientLocation.Text = dt.Rows[0][2].ToString();
            txtClientMobile.Text = dt.Rows[0][3].ToString();
            txtClientEmail.Text = dt.Rows[0][4].ToString();
            grpClients.Text = string.Format("({0} IQD : {1} $)", double.Parse(dt.Rows[0][5].ToString()).ToString("#,###"), (double.Parse(dt.Rows[0][5].ToString()) / Properties.Settings.Default.dollarValue).ToString("#.##"));

        }

        private void cmbBills_DropDown(object sender, EventArgs e)
        {
            cmbBills.Items.Clear();
            System.Data.DataTable dt = databaseConnection.query(string.Format("select tbl_bills.id from tbl_bills,tbl_clients where is_account = '{0}'  and is_cash = '{1}' and is_sell = '{3}' and tbl_bills.client_id = tbl_clients.id and tbl_clients.name = '{2}' and tbl_bills.id > 0 {4} order by tbl_bills.id desc ", isAccount.IsOn ? "1" : "0", isCash.IsOn ? "1" : "0", cmbClients.Text, isSell.IsOn ? "1" : "0", cmbDelegates.SelectedIndex == 0 ? " " : string.Format("and  tbl_bills.delegate_id = (select tbl_clients.id from tbl_clients where tbl_clients.`type` = 2 and tbl_clients.name = '{0}')", cmbDelegates.Text)));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbBills.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void dgvProducts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            txtTotal.Text = sum().ToString().Contains(".") ? (sum() - double.Parse(txtDiscount.Text)).ToString() : (sum() - double.Parse(txtDiscount.Text)).ToString("#,###");
            if (dgvProducts.Rows.Count > 1)
            {
                for (int i = 0; i < dgvProducts.Rows.Count - 1; i++)
                {
                    dgvProducts.Rows[i].Cells[0].Value = (i+1).ToString();
                }
            }
        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
            if (txtClientName.Text.Length > 0 && isKeypress)
            {
                isKeypress = false;
                dgvClientsNames.Visible = true;
                dgvClientsNames.DataSource = databaseConnection.query(string.Format("select tbl_clients.name from tbl_clients where tbl_clients.name like '%{0}%';", txtClientName.Text));
                dgvClientsNames.Columns["name"].HeaderText = "أسم العميل";
            }
            else
            {
                dgvClientsNames.Visible = false;
            }
            if (dgvClientsNames.Rows.Count == 0)
            {
                dgvClientsNames.Visible = false;
            }
        }

        private void txtClientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            isKeypress = true;
        }

        private void dgvClientsNames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbClients.Text = dgvClientsNames.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmbClients_SelectedIndexChanged(null, null);
        }

        private void dgvProducts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (dgvProducts.CurrentCell.ColumnIndex == dgvProducts.Columns["price"].Index || dgvProducts.CurrentCell.ColumnIndex == dgvProducts.Columns["quantity"].Index || dgvProducts.CurrentCell.ColumnIndex == dgvProducts.Columns["total"].Index) //Desired Column
            {
                
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                    tb.TextChanged += Tb_TextChanged;
                }
            }
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if ((sender as TextBox).Text == "0")
                {
                    return;
                }
                if ((sender as TextBox).Text.Length > 0 && !(sender as TextBox).Text.Contains("."))
                {
                    (sender as TextBox).Text = (sender as TextBox).Text == "" ? "0" : double.Parse((sender as TextBox).Text).ToString(isDollar.IsOn ? "#.##" : "#,###");
                    (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
                }
            }
            catch (Exception)
            {

            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 46 || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back || e.KeyChar == '.' ||  e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        bool isAddOnly = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            isAddOnly = true;
            btnSell_Click(null, null);
        }

        private void dgvProducts_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            sumRow(e.RowIndex);
            double sum = 0;
            for (int i = 0; i < dgvProducts.Rows.Count - 1; i++)
            {
                if (dgvProducts.Rows[i].Cells["total"].Value.ToString() == "")
                {
                    dgvProducts.Rows[i].Cells["total"].Value = "0";
                }
                sum += double.Parse(dgvProducts.Rows[i].Cells["total"].Value.ToString());
                txtTotal.Text = sum.ToString().Contains(".") ? (sum - double.Parse(txtDiscount.Text)).ToString() : (sum - double.Parse(txtDiscount.Text)).ToString("#,###");
            }
        }
        void sumRow(int rowId)
        {
            double sum = 0;
            if (dgvProducts.Rows[rowId].Cells["quantity"].Value == null)
            {
                dgvProducts.Rows[rowId].Cells["quantity"].Value = "0";
            }
            if (dgvProducts.Rows[rowId].Cells["price"].Value == null)
            {
                dgvProducts.Rows[rowId].Cells["price"].Value = "0";

            }
            dgvProducts.Rows[rowId].Cells["total"].Value = (double.Parse(dgvProducts.Rows[rowId].Cells["quantity"].Value.ToString()) * double.Parse(dgvProducts.Rows[rowId].Cells["price"].Value.ToString())).ToString();
            sum = double.Parse(dgvProducts.Rows[rowId].Cells["total"].Value.ToString());
            dgvProducts.Rows[rowId].Cells["total"].Value = dgvProducts.Rows[rowId].Cells["total"].Value.ToString().Contains(".") ? sum.ToString() : sum.ToString("#,###");
        }

        private void dgvProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducts.CurrentRow.Cells["description"].Value == null)
                dgvProducts.CurrentRow.Cells["description"].Value = "";

            if (dgvProducts.CurrentRow.Cells["note"].Value == null)
                dgvProducts.CurrentRow.Cells["note"].Value = "";

            dgvProducts.CurrentRow.Cells["id"].Value = dgvProducts.Rows.Count - 1;
            sumRow(e.RowIndex);
        }



        private void تكرارالقيدToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (
                dgvProducts.CurrentRow.Cells[0].Value == null ||
                dgvProducts.CurrentRow.Cells[1].Value == null ||
                dgvProducts.CurrentRow.Cells[2].Value == null ||
                dgvProducts.CurrentRow.Cells[3].Value == null
                )
            {
                return;
            }
            dgvProducts.Rows.Add(
                dgvProducts.Rows.Count,
                dgvProducts.CurrentRow.Cells[1].Value,
                dgvProducts.CurrentRow.Cells[2].Value,
                dgvProducts.CurrentRow.Cells[3].Value,
                dgvProducts.CurrentRow.Cells[4].Value
                );
            double sum = 0;
            for (int i = 0; i < dgvProducts.Rows.Count - 1; i++)
            {
                if (dgvProducts.Rows[i].Cells["total"].Value == null)
                {
                    continue;
                }
                sum += double.Parse(dgvProducts.Rows[i].Cells["total"].Value.ToString());
            }
            txtTotal.Text = sum.ToString().Contains(".") ? (sum - double.Parse(txtDiscount.Text)).ToString() : (sum - double.Parse(txtDiscount.Text)).ToString("#,###");
        }

        private void حذفالمحددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow.Index == dgvProducts.Rows.Count - 1)
            {
                return;
            }
            dgvProducts.Rows.RemoveAt(dgvProducts.CurrentRow.Index);
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            string s = databaseConnection.query(string.Format("select count(id) from tbl_clients where name = '{0}' and type = '{1}'", txtClientName.Text, (int)(isSell.IsOn ? (int)Enumerators.clientType.Client : (int)Enumerators.clientType.Supplier))).Rows[0][0].ToString();
            if (s != "1")
            {
                databaseConnection.queryNonReader(string.Format("insert into tbl_clients (name,location,mobile,email,type,is_active,percent) values ('{0}','{1}','{2}','{3}','{4}',1,0);",txtClientName.Text,txtClientLocation.Text,txtClientMobile.Text,txtClientEmail.Text,isSell.IsOn ? (int)Enumerators.clientType.Client:(int)Enumerators.clientType.Supplier));
                cmbClients.Text = txtClientName.Text;
            }else
            {
                MessageBox.Show("موجود بلفعل!");
            }
        }

        private void isDollar_Toggled(object sender, EventArgs e)
        {
            double dollarValue = double.Parse(databaseConnection.query(string.Format("select getDollar('{0}');",billDate.ToString("yyyy-MM-dd"))).Rows[0][0].ToString());
            for (int i = 0; i < dgvProducts.Rows.Count - 1; i++)
            {
                dgvProducts.Rows[i].Cells["price"].Value =
                    !isDollar.IsOn ?
                    double.Parse(dgvProducts.Rows[i].Cells["price"].Value.ToString()) * dollarValue :
                    (double.Parse(dgvProducts.Rows[i].Cells["price"].Value.ToString()) / dollarValue);
                dgvProducts.Rows[i].Cells["total"].Value =
                    double.Parse(dgvProducts.Rows[i].Cells["price"].Value.ToString()) *
                    double.Parse(dgvProducts.Rows[i].Cells["quantity"].Value.ToString());
            }
            txtDiscount.Text =
                (isDollar.IsOn ?
                double.Parse(txtDiscount.Text) / dollarValue :
                double.Parse(txtDiscount.Text) * dollarValue).ToString();
            txtPaid.Text = txtPaid.Text == "" ? "0" : txtPaid.Text;
            if (txtPaid.Text.Length > 0)
                txtPaid.Text =
                    (isDollar.IsOn ?
                    double.Parse(txtPaid.Text) / dollarValue :
                    double.Parse(txtPaid.Text) * dollarValue).ToString();
            else
                txtPaid.Text = "0";
            txtTotal.Text = sum().ToString().Contains(".") ? (sum() - double.Parse(txtDiscount.Text)).ToString() : (sum() - double.Parse(txtDiscount.Text)).ToString("#,###");
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            txtDiscount.Text = txtDiscount.Text.Length == 0 ? "0" : txtDiscount.Text;
        }

        private void حذفالقائمةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((txtTotal.Text == "0" || txtTotal.Text.Length == 0) && MessageBox.Show("","",MessageBoxButtons.OKCancel) == DialogResult.OK && !cmbBills.Enabled && Properties.Settings.Default.userType == (int)Enumerators.UserType.Admin)
            {
                databaseConnection.queryNonReader(string.Format("delete from tbl_bills where id = '{0}'", cmbBills.Text));
                btnClear_Click(null, null);
            }
        }

        private void txtProductPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && ((char)Keys.OemPeriod == e.KeyChar);
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.OemPeriod)
            {
                e.Handled = false;
            }else
            {
                e.Handled = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HPress
{
    public partial class Debits : DevExpress.XtraEditors.XtraForm
    {
        HDatabaseConnection.HMySQLConnection databaseConnection;
        int id = 0;
        bool isEdit = false;
        public Debits(HDatabaseConnection.HMySQLConnection databaseConnection)
        {
            InitializeComponent();
            this.databaseConnection = databaseConnection;
            reloadData();
            txtValue.Focus();
        }
        void reloadData()
        {
            btnSearch_Click(null, null);
            txtNote.Text = txtValue.Text =  "";
            btnRemove.Enabled = isDollar.IsOn = isPay.IsOn = isEdit = btnUpdate.Enabled = false;
            dateFrom.Value = dateTo.Value = DateTime.Now;
            id = 0;

        }
        private void cmbClient_DropDown(object sender, EventArgs e)
        {
            System.Data.DataTable dt = databaseConnection.query(string.Format("select name from tbl_clients where type = 3;"));
            cmbClients.Items.Clear();
            cmbClients.Items.Add("الكل");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbClients.Items.Add(dt.Rows[i][0].ToString());
            }
            cmbClients.SelectedIndex = 0;
            cmbClients.Text = cmbClients.Items[0].ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtValue.Text.Length > 0)
            {
                databaseConnection.queryNonReader(string.Format("insert into tbl_debits (is_dollar,is_pay,value,employee_id,note,datetime) values ('{0}','{1}','{2}',(select id from tbl_clients where name = '{3}' and type = 3),'{4}','{5}');", isDollar.IsOn ? "1" : "0", isPay.IsOn ? "1" : "0", txtValue.Text.Replace(",", ""), cmbClients.Text, txtNote.Text, date.Value.ToString("yyyy-MM-dd 00:00:00")));
                reloadData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbClients.Text.Length == 0)
            {
                return;
            }
            dgvResults.DataSource = databaseConnection.query(string.Format("select tbl_debits.id,tbl_clients.name,if(tbl_debits.is_pay = 0,tbl_debits.value,0) as `debit`,if(tbl_debits.is_pay = 1,tbl_debits.value,0) as `pay`,if(tbl_debits.is_dollar = 1,'$','IQD') as `is_dollar`, date_format(tbl_debits.datetime,'%Y-%m-%d') as `datetime`, tbl_debits.note from tbl_debits,tbl_clients where  tbl_clients.type = 3 and tbl_debits.employee_id = tbl_clients.id {2} and tbl_debits.datetime between '{0}' and '{1}'", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"),dateTo.Value.ToString("yyyy-MM-dd 23:59:59"),cmbClients.Text == "الكل" ? "" : "and	tbl_clients.name = '"+cmbClients.Text+"'"));
            dgvResults.Columns[0].Visible = false;
            dgvResults.Columns["name"].HeaderText = "الموظف";
            dgvResults.Columns["pay"].HeaderText = "مسدد";
            dgvResults.Columns["debit"].HeaderText = "مقروض";
            dgvResults.Columns["datetime"].HeaderText = "التاريخ";
            dgvResults.Columns["note"].HeaderText = "ملاحظة";
            dgvResults.Columns["is_dollar"].HeaderText = "العملة";
            

            DataTable dt = databaseConnection.query(string.Format("select ifnull(sum(if(tbl_debits.is_pay = 0,tbl_debits.value,0) * if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1)),0) as `debit`, ifnull(sum(if(tbl_debits.is_pay = 1,tbl_debits.value,0)* if(tbl_debits.is_dollar = 1,getDollar(tbl_debits.datetime),1)),0) as `pay`  from tbl_debits, tbl_clients where tbl_debits.employee_id = tbl_clients.id and tbl_clients.`type` = 3 and tbl_debits.datetime between '{1}' and '{2}';", cmbClients.Text == "الكل" ? "" : " and tbl_clients.name = '"+cmbClients.Text+"' ", dateFrom.Value.ToString("yyyy-MM-dd 00:00:00"), dateTo.Value.ToString("yyyy-MM-dd 23:59:59")));
            if (dt.Rows.Count > 0)
            {
                double sumDebit = double.Parse(dt.Rows[0][0].ToString());
                double sumPaid = double.Parse(dt.Rows[0][1].ToString());

                txtPaid.Text = sumPaid.ToString("#,###");
                txtDebits.Text = sumDebit.ToString("#,###");
                txtTotal.Text = (sumDebit - sumPaid).ToString("#,###");
                txtValue.Text = "";
            }

        }
        
        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            isEdit = true;
            id = int.Parse(dgvResults.Rows[e.RowIndex].Cells["id"].Value.ToString());
            if (double.Parse(dgvResults.Rows[e.RowIndex].Cells["pay"].Value.ToString()) > 0)
            {
                txtValue.Text = dgvResults.Rows[e.RowIndex].Cells["pay"].Value.ToString();
                isPay.IsOn = true;
            }
            else
            {
                txtValue.Text = dgvResults.Rows[e.RowIndex].Cells["debit"].Value.ToString();
                isPay.IsOn = false;
            }
            isDollar.IsOn = dgvResults.Rows[e.RowIndex].Cells["is_dollar"].Value.ToString() == "$";
            txtNote.Text = dgvResults.Rows[e.RowIndex].Cells["note"].Value.ToString();
            btnRemove.Enabled = btnUpdate.Enabled = Properties.Settings.Default.userType == (int)Enumerators.UserType.Admin;
            txtValue_TextChanged(txtValue, null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                databaseConnection.queryNonReader(string.Format("update tbl_debits set is_dollar = '{0}',is_pay = '{1}',value = '{2}',employee_id = (select id from tbl_clients where tbl_clients.name = '{3}' and tbl_clients.type = 3),note = '{4}',datetime = '{6}' where tbl_debits.id = '{5}';", isDollar.IsOn ? "1" : "0", isPay.IsOn ? "1" : "0", txtValue.Text.Replace(",", ""), cmbClients.Text, txtNote.Text, id, date.Value.ToString("yyyy-MM-dd 00:00:00")));
                reloadData();
            }
            
        }


        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            if (dgvResults.Rows.Count > 0)
            {
                new DevExpress.XtraReports.UI.ReportPrintTool(new HCashier.Report.ReportGeneral(databaseConnection, dgvResults, cmbClients.Text, true, true, dateFrom.Value, dateTo.Value, Properties.Settings.Default.dollarValue,Enumerators.ReportsName.none)).ShowRibbonPreview();
                reloadData();
            }
        }

        private void txtValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 46 || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void isPay_Toggled(object sender, EventArgs e)
        {
            grpPay.Text = isPay.IsOn ? "تسدد" : "قرض";
        }

        private void isDollar_Toggled(object sender, EventArgs e)
        {
            grpIsDollar.Text = isDollar.IsOn ? "$" : "IQD";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                return;
            }
            if (MessageBox.Show("هل انت متاكد؟","حذف", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                databaseConnection.queryNonReader(string.Format("delete from tbl_debits where id = '{0}';", id));
                reloadData();
            }
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text.Length > 0)
            {
                (sender as TextBox).Text = (sender as TextBox).Text == "" ? "0" : double.Parse((sender as TextBox).Text).ToString(isDollar.IsOn ? "#.##" : "#,###");
                (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
            }
        }

        private void cmbClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAdd.Enabled = cmbClients.SelectedIndex != 0;
        }
    }
}
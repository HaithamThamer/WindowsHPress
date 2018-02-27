using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPress
{
    public partial class Users : Form
    {
        HDatabaseConnection.HMySQLConnection databaseConnection;
        public Users(HDatabaseConnection.HMySQLConnection databaseConnection)
        {
            InitializeComponent();
            this.databaseConnection = databaseConnection;
            dgvUsers.DataSource = databaseConnection.query("select * from tbl_users");
            dgvUsers.Columns["id"].Visible = false;

            
        }

        private void dgvUsers_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Cells["id"].Value.ToString() == "1")
            {
                MessageBox.Show("", "", MessageBoxButtons.OK);
                e.Cancel = true;
                return;
            }
            if (MessageBox.Show("", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                databaseConnection.query($"delete from tbl_users where id = '{int.Parse(e.Row.Cells["id"].Value.ToString())}';");
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dgvUsers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUsers.Columns.Count - 1)
            {
                for (int i = 0; i < dgvUsers.Columns.Count; i++)
                {
                    if (dgvUsers.Rows[e.RowIndex].Cells[i].Value == null || dgvUsers.Rows[e.RowIndex].Cells[i].Value.ToString() == string.Empty)
                    {
                        return;
                    }
                }
                System.Data.DataTable dt = databaseConnection.query($"insert into tbl_users (name,password,type) value ('{dgvUsers.Rows[e.RowIndex].Cells["name"].Value.ToString()}','{dgvUsers.Rows[e.RowIndex].Cells["password"].Value.ToString()}','{dgvUsers.Rows[e.RowIndex].Cells["type"].Value.ToString()}');select id from tbl_users order by id desc limit 0,1");
                dgvUsers.Rows[e.RowIndex].Cells["id"].Value = dt.Rows[0][0];
            }
            else if(dgvUsers.Rows[e.RowIndex].Cells["id"].Value != null || dgvUsers.Rows[e.RowIndex].Cells["id"].Value.ToString() != string.Empty)
            {
                System.Data.DataTable dt = databaseConnection.query($"update tbl_users set name = '{dgvUsers.Rows[e.RowIndex].Cells["name"].Value.ToString()}',password = '{dgvUsers.Rows[e.RowIndex].Cells["password"].Value.ToString()}', type = '{dgvUsers.Rows[e.RowIndex].Cells["type"].Value.ToString()}' where id = '{dgvUsers.Rows[e.RowIndex].Cells["id"].Value.ToString()}'");
            }
        }
    }
}

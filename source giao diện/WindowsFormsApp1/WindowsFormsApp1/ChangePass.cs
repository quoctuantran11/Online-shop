using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ChangePass : Form
    {
        string strUserName2;
        public ChangePass()
        {
            InitializeComponent();
        }

        public ChangePass(string data) : this()
        {
            strUserName2 = data;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string readpass = txbReadPass.Text;
            string writepass = txbWritePass.Text;
            string newpass1 = txbNewPass1.Text;
            string newpass2 = txbNewPass2.Text;
            bool check;

            if (txbWritePass.Text == "")
            {

                MessageBox.Show("Bạn chưa nhập mật khẩu hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbWritePass.Focus();
                return;
            }
            else if (txbNewPass1.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbNewPass1.Focus();
                return;
            }
            else if (txbNewPass2.Text == "")
            {
                MessageBox.Show("Bạn chưa xác nhận mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbNewPass2.Focus();
                return;
            }
            else if (txbNewPass1.Text != txbNewPass2.Text)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận lại mật khẩu mới không giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbNewPass2.Focus();
                txbNewPass2.SelectAll();
                return;
            }

            if (writepass == readpass)
            {
                check = true;
            } 
            else
            {
                MessageBox.Show("Sai mật khẩu hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbWritePass.Focus();
                txbWritePass.SelectAll();
                check = false;
            }

            if(check)
            {
                Function.Con.Open();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string sqlUpdate = "update KhachHang set MatKhau = '" + newpass1 + "' where Email = '" + strUserName2 + "'";
                SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, Function.Con);
                cmdUpdate.ExecuteNonQuery();
                Function.Con.Close();
            }    
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            Function.Con.Open();
            string sql = "Select MatKhau from KhachHang where Email = '" + strUserName2 + "'";
            SqlCommand command = new SqlCommand(sql, Function.Con);
            SqlDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                txbReadPass.Text = (string)data["MatKhau"];
            }
            Function.Con.Close();
        }
    }
}

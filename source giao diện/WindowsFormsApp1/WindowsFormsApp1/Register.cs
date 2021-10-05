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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txbUsername.Text;
            string name = txbName.Text;
            string phonenum = txbPhoneNum.Text;
            DateTime dob = dtpDOB.Value;
            string gender = cbGender.Text;
            DateTime createdate = dtpCreatDate.Value;
            string pass1 = txbPass1.Text;
            string pass2 = txbPass2.Text;

            if (txbUsername.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbUsername.Focus();
                return;
            }
            else if (txbName.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbName.Focus();
                return;
            }
            else if (txbPhoneNum.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập SĐT", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbPhoneNum.Focus();
                return;
            }
            
            else if (cbGender.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbGender.Focus();
                return;
            }
            else if (txbPass1.Text == "")
            {

                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbPass1.Focus();
                return;
            }    
            else if (txbPass2.Text == "")
            {
                MessageBox.Show("Bạn chưa xác nhận lại mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbPass2.Focus();
                return;
            }
            else if (txbPass1.Text != txbPass2.Text)
            {
                MessageBox.Show("Mật khẩu và xác nhận lại mật khẩu không giống nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbPass2.Focus();
                txbPass2.SelectAll();
                return;
            }

            Function.Con.Open();
            string query = "select Email from KhachHang where Email = '" + username + "'";
            SqlCommand cmd = new SqlCommand(query, Function.Con);
            SqlDataReader data = cmd.ExecuteReader();
            bool check = false;

            if (data.Read() != true)
            {
                check = true;
            }
            else
            {
                MessageBox.Show("Email đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbUsername.Focus();
                txbUsername.SelectAll();
            }
            Function.Con.Close();


            if(check)
            {
                Function.Con.Open();
                MessageBox.Show("Đăng ký thành công!");
                string queryInsert = "insert into KhachHang values ('" + phonenum + "', '" + username + "','" + pass1 + "', '" + name + "', '" + dob + "', '" + gender + "', '" + createdate + "')";
                SqlCommand cmdInsert = new SqlCommand(queryInsert, Function.Con);
                cmdInsert.ExecuteNonQuery();
                Function.Con.Close();
            }    
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            dtpCreatDate.Enabled = false;
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}

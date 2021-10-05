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

        SqlConnection connection;

        private void btnRegister_Click(object sender, EventArgs e)
        {
                string username = txbUsername.Text;
                string name = txbName.Text;
                string phonenum = txbPhoneNum.Text;
                string dob = txbDOB.Text;
                string gender = cbGender.Text;
                string createdate = txbCreatDate.Text;
                string pass1 = txbCreatDate.Text;
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
                else if (txbDOB.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbName.Focus();
                    return;
                }
                else if (cbGender.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbGender.Focus();
                    return;
                }
                else if (txbCreatDate.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập ngày tạo tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbCreatDate.Focus();
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
                    MessageBox.Show("Mật khẩu và xác nhận lại mật khẩu không giống nhau");
                    txbPass2.Focus();
                    txbPass2.SelectAll();
                    return;
                }


            MessageBox.Show("Đăng ký thành công!");
            string queryInsert = "insert into KhachHang values ('" + phonenum + "', '" + username + "','" + pass1 + "', '" + name + "', '" + dob + "', '" + gender + "', '" + createdate + "')";
            Function.RunSQL(queryInsert);
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            const string connectSTR = @"Data Source=DESKTOP-NSTPLG4\SQLEXPRESS;Initial Catalog=N13_CSDLNC_TH;Integrated Security=True";
            connection = new SqlConnection(connectSTR);
            connection.Open();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
    }
}

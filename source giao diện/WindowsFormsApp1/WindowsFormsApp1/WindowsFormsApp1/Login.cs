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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            const string connectSTR = @"Data Source=DESKTOP-NSTPLG4\SQLEXPRESS;Initial Catalog=N13_CSDLNC_TH;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectSTR);
            try
            {
                connection.Open();
                string username = txbUsername.Text;
                string pass = txbPass.Text;
                string query = "select Email, MatKhau from KhachHang where Email = '" + username + "' and MatKhau = '" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    Menu menu = new Menu();
                    this.Hide();
                    menu.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại hoặc sai mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối!");
            }
            connection.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thực sự muốn thoát?", " Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void llRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.ShowDialog();
            this.Show();
        }
    }
}

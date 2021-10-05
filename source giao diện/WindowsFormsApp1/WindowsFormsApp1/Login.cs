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
            try
            {
                Function.Con.Open();
                string username = txbUsername.Text;
                string pass = txbPass.Text;
                string query = "select Email, MatKhau from KhachHang where Email = '" + username + "' and MatKhau = '" + pass + "'";
                SqlCommand cmd = new SqlCommand(query, Function.Con);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    Function.Con.Close();
                    Menu menu = new Menu(txbUsername.Text);
                    this.Hide();
                    menu.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại hoặc sai mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Function.Con.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối!");
            }
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

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

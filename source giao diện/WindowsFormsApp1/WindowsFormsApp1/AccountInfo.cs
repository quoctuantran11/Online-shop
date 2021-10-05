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
    public partial class AccountInfo : Form
    {
        string strUserName2;

        public AccountInfo()
        {
            InitializeComponent();
        }

        public AccountInfo(string data) : this()
        {
            strUserName2 = data;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccountInfo_Load(object sender, EventArgs e)
        {
            dtpCreatDate.Enabled = false;
            Function.Con.Open();
            string sql = "select Email, SDT, HoTen, NgaySinh, GioiTinh, NgayTaoTK from KhachHang where Email = '" + strUserName2 + "'";
            SqlCommand command = new SqlCommand(sql, Function.Con);
            SqlDataReader data = command.ExecuteReader();

            while (data.Read())
            {
                txbUsername.Text = (string)data["Email"];
                txbPhoneNum.Text = data["SDT"].ToString();
                txbName.Text = (string)data["HoTen"];
                dtpDOB.Value = (DateTime)data["NgaySinh"];
                cbGender.Text = (string)data["GioiTinh"];
                dtpCreatDate.Value = (DateTime)data["NgayTaoTK"];
            }
            Function.Con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string phonenum = txbPhoneNum.Text;
            DateTime dob = dtpDOB.Value;
            string gender = cbGender.Text;

            MessageBox.Show("Cập nhật thành công thành công!");

            Function.Con.Open();

            string sqlUpdate = "update KhachHang set SDT = '" + phonenum + "', HoTen =  '" + name + "', NgaySinh = '" + dob + "', GioiTinh = '" + gender + "' where Email = '"+strUserName2+"'";
            SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, Function.Con);
            cmdUpdate.ExecuteNonQuery();

            Function.Con.Close();
        }
    }
}

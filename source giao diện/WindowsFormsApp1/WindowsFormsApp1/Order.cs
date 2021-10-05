using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Order : Form
    {
        string strUserName2;
        public Order()
        {
            InitializeComponent();
        }

        public Order(string data) : this()
        {
            strUserName2 = data;
        }

        private void MyOrder_Load(object sender, EventArgs e)
        {
            Function.Con.Open();
            string sql_search = "select MaDonHang, SDT, Email, NgayDatHang, TinhTrangDon, DiaChiNguoiNhan, HinhThucGiaoHang, HinhThucThanhToan, PhiVanChuyen, TongTien from DonHang where Email = '" + strUserName2 + "'";
            SqlCommand cmd = new SqlCommand(sql_search, Function.Con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            Function.Con.Close();
            LoadComboBox();
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCancel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCancel.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        void LoadComboBox()
        {
            Function.Con.Open();
            string sqlCancel = "Select MaDonHang from DonHang where Email = '" + strUserName2 + "' and TinhTrangDon = 'da tiep nhan'";
            SqlCommand cmdCancel = new SqlCommand(sqlCancel, Function.Con);
            SqlDataReader data = cmdCancel.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(data);
            data.Dispose();
            cbCancel.DisplayMember = "MaDonHang";
            cbCancel.DataSource = table;
            Function.Con.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string madonhang = cbCancel.Text;
            Function.Con.Open();
            string sqlUpdate = "update DonHang set TinhTrangDon = 'da huy' where MaDonHang = '"+madonhang+"'";
            SqlCommand cmdUpdate = new SqlCommand(sqlUpdate, Function.Con);
            cmdUpdate.ExecuteNonQuery();
            MessageBox.Show("Hủy đơn thành công!");
            Function.Con.Close();

            Order order = new Order(strUserName2);
            this.Hide();
            order.ShowDialog();
            this.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string status = cbStatus.Text;

            if(status == "tat ca")
            {
                Function.Con.Open();
                string sql_searchall = "select MaDonHang, SDT, Email, NgayDatHang, TinhTrangDon, DiaChiNguoiNhan, HinhThucGiaoHang, HinhThucThanhToan, PhiVanChuyen, TongTien from DonHang where Email = '" + strUserName2 + "'";
                SqlCommand cmd_all = new SqlCommand(sql_searchall, Function.Con);
                cmd_all.CommandType = CommandType.Text;
                SqlDataAdapter adapter_all = new SqlDataAdapter(cmd_all);
                DataTable table_all = new DataTable();
                adapter_all.Fill(table_all);
                dataGridView1.DataSource = table_all;
                Function.Con.Close();
            }    
            else
            {
                Function.Con.Open();
                string sql_search = "select MaDonHang, SDT, Email, NgayDatHang, TinhTrangDon, DiaChiNguoiNhan, HinhThucGiaoHang, HinhThucThanhToan, PhiVanChuyen, TongTien from DonHang where Email = '" + strUserName2 + "' and TinhTrangDon = '" + status + "'";
                SqlCommand cmd = new SqlCommand(sql_search, Function.Con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                Function.Con.Close();
            }    
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        DataTable tblCart;

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT SP.TenSanPham, CTDH.SoLuong, SP.DonGia" +
                " from DonHang DH join ChiTietDonHang CTDH on DH.MaDonHang = CTDH.MaDonHang join" +
                " SanPham SP on CTDH.MaSanPham = SP.MaSanPham ";
            tblCart = Function.GetDataToTable(sql);
            CartGV.DataSource = tblCart;

            CartGV.Columns[0].HeaderText = "Tên hàng";
            CartGV.Columns[1].HeaderText = "Số lượng";
            CartGV.Columns[2].HeaderText = "Đơn giá";
            CartGV.Columns[0].Width = 120;
            CartGV.Columns[1].Width = 80;
            CartGV.Columns[2].Width = 100;
            
            CartGV.AllowUserToAddRows = false;
            CartGV.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            NameText.ReadOnly = true;
            PhoneText.ReadOnly = true;
            AddrText.ReadOnly = true;
            MoneyText.ReadOnly = true;
            BillText.ReadOnly = true;
            DateText.ReadOnly = true;

            MoneyText.Text = "0";
            BillText.Text = "EISSG7";

            string str;
            str = "SELECT NgayDatHang FROM DonHang WHERE MaDonHang= '" + BillText.Text + "'";
            DateText.Text = Function.ConvertDateTime(Function.GetFieldValues(str));
            str = "SELECT MaNV FROM DonHang WHERE MaDonHang= N'" + BillText.Text + "'";
            cboEmp.Text = Function.GetFieldValues(str);
            str = "SELECT TongTien FROM DonHang WHERE MaDonHang= N'" + BillText.Text + "'";
            MoneyText.Text = Function.GetFieldValues(str);

            LoadDataGridView();
        }

       
    }
}

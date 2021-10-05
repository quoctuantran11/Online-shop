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
    public partial class Acc_Cart : Form
    {
        public Acc_Cart()
        {
            InitializeComponent();
        }

        DataTable ACartTbl;

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT SP.TenSanPham, CTDH.SoLuong, SP.DonGia" +
                " from DonHang DH join ChiTietDonHang CTDH on DH.MaDonHang = CTDH.MaDonHang join" +
                " SanPham SP on CTDH.MaSanPham = SP.MaSanPham ";
            ACartTbl = Function.GetDataToTable(sql);
            Gooddgv.DataSource = ACartTbl;

            Gooddgv.Columns[0].HeaderText = "Tên hàng";
            Gooddgv.Columns[1].HeaderText = "Số lượng";
            Gooddgv.Columns[2].HeaderText = "Đơn giá";
            Gooddgv.Columns[0].Width = 370;
            Gooddgv.Columns[1].Width = 150;
            Gooddgv.Columns[2].Width = 210;

            Gooddgv.AllowUserToAddRows = false;
            Gooddgv.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void Acc_Cart_Load_1(object sender, EventArgs e)
        {
            NameText.ReadOnly = true;
            PhoneText.ReadOnly = true;
            AddrText.ReadOnly = true;
            TransportBox.ReadOnly = true;
            FeeBox.ReadOnly = true;
            PayBox.ReadOnly = true;
            TotalBox.ReadOnly = true;
            BillText.ReadOnly = true;
            DateText.ReadOnly = true;
            CondBox.ReadOnly = true;

            TotalBox.Text = "0";
            BillText.Text = "EISSG7";

            string str;
            str = "SELECT NgayDatHang FROM DonHang WHERE MaDonHang= '" + BillText.Text + "'";
            DateText.Text = Function.ConvertDateTime(Function.GetFieldValues(str));
            str = "SELECT TongTien FROM DonHang WHERE MaDonHang= N'" + BillText.Text + "'";
            TotalBox.Text = Function.GetFieldValues(str);
            str = "SELECT PhiVanChuyen FROM DonHang WHERE MaDonHang= '" + BillText.Text + "'";
            FeeBox.Text = Function.GetFieldValues(str);
            str = "SELECT TinhTrangDon FROM DonHang WHERE MaDonHang= N'" + BillText.Text + "'";
            CondBox.Text = Function.GetFieldValues(str);
            str = "SELECT HinhThucThanhToan FROM DonHang WHERE MaDonHang= N'" + BillText.Text + "'";
            PayBox.Text = Function.GetFieldValues(str);
            str = "SELECT HinhThucGiaoHang FROM DonHang WHERE MaDonHang= N'" + BillText.Text + "'";
            TransportBox.Text = Function.GetFieldValues(str);

            LoadDataGridView();
        }
    }
}

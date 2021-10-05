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
    
    public partial class Buy : Form
    {
        string strUserName4;
        public Buy()
        {
            InitializeComponent();
        }

        public Buy(string data):this()
        {
            strUserName4 = data;
        }

        DataTable tblGood;

        public void LoadDataGridView()
        {
            GridViewGood.DataSource = tblGood;
            GridViewGood.Columns[0].HeaderText = "Tên sản phẩm";
            GridViewGood.Columns[1].HeaderText = "Đơn giá";
            GridViewGood.Columns[2].HeaderText = "Số lượng";
            GridViewGood.Columns[3].HeaderText = "Thương hiệu";
            GridViewGood.Columns[4].HeaderText = "Xuất xứ";

            GridViewGood.Columns[0].Width = 100;
            GridViewGood.Columns[1].Width = 150;
            GridViewGood.Columns[2].Width = 100;
            GridViewGood.Columns[3].Width = 150;
            GridViewGood.Columns[4].Width = 100;

            GridViewGood.AllowUserToAddRows = false;
            GridViewGood.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            IDBox.Text = "";
            Findbox.Text = "";
            QuanBox.Text = "";
            Pricebox.Text = "";
            BrandBox.Text = "";
            OriginBox.Text = "";
            QuanBox.Enabled = true;
            Pricebox.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            if (Findbox.Text == "")
            {
                return;
            }
            sql = "SELECT TenSanPham,DonGia,SoLuongCon,ThuongHieu,XuatXu from SanPham WHERE ";
            if (Findbox.Text != "")
                sql += " TenSanPham LIKE '%" + Findbox.Text + "%'";
            tblGood = Function.GetDataToTable(sql);
            if (tblGood.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PickButton_Click(object sender, EventArgs e)
        {
            string sql, email, OrderDate, Condition, Addr, Transport = "", Pay = "";
            int NVGH, Fee = 0, Total = 0, Quantity;
            decimal PhoneNumber;

            QuanBuy quantitybox = new QuanBuy();
            quantitybox.ShowDialog();
            Function.Connect();

            sql = "select SDT from KhachHang where Email = '" + strUserName4 + "'";
            PhoneNumber = Convert.ToDecimal(Function.GetFieldValues(sql));
            email = strUserName4;
            NVGH = 24;
            sql = "SELECT CONVERT(VARCHAR(10), getdate(), 23)";
            OrderDate = Function.GetFieldValues(sql);
            Condition = "Dang xac nhan";
            Addr = "123 Ba Lan";
            if (quantitybox.fast2 == true)
            {
                Transport = "Giao hang nhanh 2h";
                Fee = 50000;
            }
            if (quantitybox.fast24 == true)
            {
                Transport = "Giao hang nhanh 24h";
                Fee = 40000;
            }
            if (quantitybox.regl == true)
            {
                Transport = "Giao hang tieu chuan";
                Fee = 20000;
            }
            if (quantitybox.atm == true)
            {
                Pay = "ATM Banking";
            }
            if (quantitybox.cash == true)
            {
                Pay = "Cash";
            }
            
            Quantity = quantitybox.quantity;
            Total += Quantity * Convert.ToInt32(Pricebox.Text);

            sql = "INSERT INTO DonHang(SDT,Email,NguoiGiaoHang,NgayDatHang,TinhTrangDon," +
                "DiaChiNguoiNhan,HinhThucGiaoHang,HinhThucThanhToan,PhiVanChuyen,TongTien) " +
                "values(" + PhoneNumber + ",'" + email + "'," + NVGH +
                ",'" + OrderDate + "','" + Condition + "','"
                + Addr + "','" + Transport + "','" + Pay + "'," + Fee + "," + Total + ")";

            Function.RunSQL(sql);
            Function.Con.Close();
        }
        
        private void Buy_Load(object sender, EventArgs e)
        {
            //string sql;
            IDBox.Enabled = false;

            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void LowtoHigh_CheckedChanged(object sender, EventArgs e)
        {
            
            if(LowtoHigh.Checked == true)
            {
                if(HightoLow.Checked == true)
                {
                    HightoLow.Checked = false;
                }
                Function.Connect();
                string sql;
                sql = "SELECT TenSanPham,DonGia,SoLuongCon,ThuongHieu,XuatXu from SanPham WHERE ";
                if (Findbox.Text != "")
                    sql += " TenSanPham LIKE '%" + Findbox.Text + "%' order by DonGia asc";
                tblGood = Function.GetDataToTable(sql);
                
                LoadDataGridView();
                Function.Con.Close();
            }
            else
            {
                Function.Connect();
                string sql;
                sql = "SELECT TenSanPham,DonGia,SoLuongCon,ThuongHieu,XuatXu from SanPham WHERE ";
                if (Findbox.Text != "")
                    sql += " TenSanPham LIKE '%" + Findbox.Text + "%'";
                tblGood = Function.GetDataToTable(sql);

                LoadDataGridView();
                Function.Con.Close();
            }
        }

        private void HightoLow_CheckedChanged(object sender, EventArgs e)
        {
            
            if (HightoLow.Checked == true)
            {
                if (LowtoHigh.Checked == true)
                {
                    LowtoHigh.Checked = false;
                }
                Function.Connect();
                string sql;
                sql = "SELECT TenSanPham,DonGia,SoLuongCon,ThuongHieu,XuatXu from SanPham WHERE ";
                if (Findbox.Text != "")
                    sql += " TenSanPham LIKE '%" + Findbox.Text + "%' order by DonGia desc";
                tblGood = Function.GetDataToTable(sql);
                
                LoadDataGridView();
                Function.Con.Close();
            }
            else
            {
                Function.Connect();
                string sql;
                sql = "SELECT TenSanPham,DonGia,SoLuongCon,ThuongHieu,XuatXu from SanPham WHERE ";
                if (Findbox.Text != "")
                    sql += " TenSanPham LIKE '%" + Findbox.Text + "%'";
                tblGood = Function.GetDataToTable(sql);

                LoadDataGridView();
                Function.Con.Close();
            }
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            
        }

        

        private void GridViewGood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Function.Connect();
            string sql;
            if (tblGood.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
          
            Findbox.Text = GridViewGood.CurrentRow.Cells["TenSanPham"].Value.ToString();
            sql = "SELECT MaSanPham FROM SanPham WHERE TenSanPham=N'" + Findbox.Text + "'";
            IDBox.Text = Function.GetFieldValues(sql);
            QuanBox.Text = GridViewGood.CurrentRow.Cells["SoLuongCon"].Value.ToString();
            Pricebox.Text = GridViewGood.CurrentRow.Cells["DonGia"].Value.ToString();
            BrandBox.Text = GridViewGood.CurrentRow.Cells["ThuongHieu"].Value.ToString();
            OriginBox.Text = GridViewGood.CurrentRow.Cells["XuatXu"].Value.ToString();
            Function.Con.Close();
        }

        private void AccountInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void AccountDeal_Click(object sender, EventArgs e)
        {
            
        }
    }
}

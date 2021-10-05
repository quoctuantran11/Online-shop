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
        public Buy()
        {
            InitializeComponent();
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

        }

        private void Buy_Load(object sender, EventArgs e)
        {
            
            IDBox.Enabled = false;
            SaveButton.Enabled = false;
  
            
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

                string sql;
                sql = "SELECT TenSanPham,DonGia,SoLuongCon,ThuongHieu,XuatXu from SanPham WHERE ";
                if (Findbox.Text != "")
                    sql += " TenSanPham LIKE '%" + Findbox.Text + "%' order by DonGia asc";
                tblGood = Function.GetDataToTable(sql);
                
                LoadDataGridView();
            }
            else
            {
                string sql;
                sql = "SELECT TenSanPham,DonGia,SoLuongCon,ThuongHieu,XuatXu from SanPham WHERE ";
                if (Findbox.Text != "")
                    sql += " TenSanPham LIKE '%" + Findbox.Text + "%'";
                tblGood = Function.GetDataToTable(sql);

                LoadDataGridView();
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

                string sql;
                sql = "SELECT TenSanPham,DonGia,SoLuongCon,ThuongHieu,XuatXu from SanPham WHERE ";
                if (Findbox.Text != "")
                    sql += " TenSanPham LIKE '%" + Findbox.Text + "%' order by DonGia desc";
                tblGood = Function.GetDataToTable(sql);
                
                LoadDataGridView();
            }
            else
            {
                string sql;
                sql = "SELECT TenSanPham,DonGia,SoLuongCon,ThuongHieu,XuatXu from SanPham WHERE ";
                if (Findbox.Text != "")
                    sql += " TenSanPham LIKE '%" + Findbox.Text + "%'";
                tblGood = Function.GetDataToTable(sql);

                LoadDataGridView();
            }
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            UpdButton.Enabled = false;
            DelButton.Enabled = false;
            SaveButton.Enabled = true;
            AddButton.Enabled = false;
            IDBox.Enabled = true;
            IDBox.Focus();
            QuanBox.Enabled = true;
            Pricebox.Enabled = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string sql, IDType;
            if (IDBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDBox.Focus();
                return;
            }
            if (TypeBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên loại hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TypeBox.Focus();
                return;
            }
            if (Findbox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Findbox.Focus();
                return;
            }
            if (QuanBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QuanBox.Focus();
                return;
            }
            if (Pricebox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Pricebox.Focus();
                return;
            }
            if (BrandBox.Text.Trim().Length == 0)
            {
                BrandBox.Text = "null";
            }
            if (OriginBox.Text.Trim().Length == 0)
            {
                OriginBox.Text = "null";
            }
            /*
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOpen.Focus();
                return;
            }
            */
            sql = "SELECT MaSanPham FROM SanPham WHERE MaSanPham='" + IDBox.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã tồn tại, bạn phải chọn mã hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDBox.Focus();
                return;
            }

            sql = "select MaNganhHang from NganhHang where TenNganhHang = '" + TypeBox.Text.Trim() + "'";
            IDType = Function.GetFieldValues(sql);
            
            sql = "INSERT INTO SanPham VALUES('" + IDBox.Text.Trim() + "','" + IDType 
                + "',N'" + Findbox.Text.Trim() +
                "'," + Pricebox.Text.Trim() + "," + QuanBox.Text + ",N'"
                + BrandBox.Text + "',N'" + OriginBox.Text + "')";

            Function.RunSQL(sql);
            sql = "Select * from SanPham";
            tblGood = Function.GetDataToTable(sql);
            LoadDataGridView();
            DelButton.Enabled = true;
            AddButton.Enabled = true;
            UpdButton.Enabled = true;
            SaveButton.Enabled = false;
            IDBox.Enabled = false;
        }

        private void UpdButton_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblGood.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (IDBox.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDBox.Focus();
                return;
            }
            if (Findbox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Findbox.Focus();
                return;
            }
            /*
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnh.Focus();
                return;
            }
            */
            sql = "UPDATE SanPham SET TenSanPham=N'" + Findbox.Text.Trim().ToString() +
                "',SoLuongCon=" + QuanBox.Text + ",DonGia=" + Pricebox.Text + 
                ",ThuongHieu=N'" + BrandBox.Text + "',XuatXu=N'" + OriginBox.Text + 
                "' WHERE MaSanPham='" + IDBox.Text + "'";
            Function.RunSQL(sql);
            sql = "Select * from SanPham where TenSanPham LIKE '%" + Findbox.Text + "%'";
            tblGood = Function.GetDataToTable(sql);
            LoadDataGridView();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblGood.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (IDBox.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE SanPham WHERE MaSanPham='" + IDBox.Text + "'";
                Function.RunSqlDel(sql);
                sql = "Select * from SanPham";
                tblGood = Function.GetDataToTable(sql);
                LoadDataGridView();
            }
        }

        private void GridViewGood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql;
            if (AddButton.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDBox.Focus();
                return;
            }
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
            UpdButton.Enabled = true;
            DelButton.Enabled = true;
        }
    }
}

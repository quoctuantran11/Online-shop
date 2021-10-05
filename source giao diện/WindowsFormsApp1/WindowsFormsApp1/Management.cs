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
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        DataTable tblGoodMn;

        public void LoadDataGridView()
        {
            GridViewGood.DataSource = tblGoodMn;
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            UpdBtn.Enabled = false;
            DelBtn.Enabled = false;
            SaveBtn.Enabled = true;
            AddBtn.Enabled = false;
            //ResetValues();
            
            QuanBox.Enabled = true;
            Pricebox.Enabled = true;
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            Function.Connect();
            string sql;
            if (tblGoodMn.Rows.Count == 0)
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
                
                sql = "Select * from SanPham where TenSanPham LIKE '%" + Findbox.Text + "%'";
                tblGoodMn = Function.GetDataToTable(sql);
                LoadDataGridView();
                ResetValues();
                Function.Con.Close();
            }
        }

        private void UpdBtn_Click(object sender, EventArgs e)
        {
            Function.Connect();
            string sql;
            if (tblGoodMn.Rows.Count == 0)
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
            
            sql = "UPDATE SanPham SET TenSanPham=N'" + Findbox.Text.Trim().ToString() +
                "',SoLuongCon=" + QuanBox.Text + ",DonGia=" + Pricebox.Text +
                ",ThuongHieu=N'" + BrandBox.Text + "',XuatXu=N'" + OriginBox.Text +
                "' WHERE MaSanPham='" + IDBox.Text + "'";
            Function.RunSQL(sql);
            
            sql = "Select * from SanPham where TenSanPham LIKE '%" + Findbox.Text + "%'";
            tblGoodMn = Function.GetDataToTable(sql);
            LoadDataGridView();
            ResetValues();
            Function.Con.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
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
            Function.Connect();

            sql = "select MaNganhHang from NganhHang where TenNganhHang = '" + TypeBox.Text.Trim() + "'";
            IDType = Function.GetFieldValues(sql);

            sql = "INSERT INTO SanPham VALUES('" + IDBox.Text.Trim() + "','" + IDType
                + "',N'" + Findbox.Text.Trim() +
                "'," + Pricebox.Text.Trim() + "," + QuanBox.Text + ",N'"
                + BrandBox.Text + "',N'" + OriginBox.Text + "')";

            Function.RunSQL(sql);
            
            sql = "Select * from SanPham";
            tblGoodMn = Function.GetDataToTable(sql);
            LoadDataGridView();
            ResetValues();
            Function.Con.Close();
            DelBtn.Enabled = true;
            AddBtn.Enabled = true;
            UpdBtn.Enabled = true;
            SaveBtn.Enabled = false;
            IDBox.Enabled = false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            string sql;
            if (Findbox.Text == "")
            {
                return;
            }
            Function.Connect();
            sql = "SELECT TenSanPham,DonGia,SoLuongCon,ThuongHieu,XuatXu from SanPham WHERE ";
            if (Findbox.Text != "")
                sql += " TenSanPham LIKE '%" + Findbox.Text + "%'";
            tblGoodMn = Function.GetDataToTable(sql);
            if (tblGoodMn.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGridView();
            Function.Con.Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridViewGood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Function.Connect();
            string sql;
            if (AddBtn.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                IDBox.Focus();
                return;
            }
            if (tblGoodMn.Rows.Count == 0)
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
            UpdBtn.Enabled = true;
            DelBtn.Enabled = true;
        }

        private void Management_Load(object sender, EventArgs e)
        {
            SaveBtn.Enabled = false;
            IDBox.Enabled = false;
        }
    }
}

using BusinessObject;
using BusinessObject.Models;
using DataAccess;
using DataAccess.Repository;
using DataAccess.Repository.Implements;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Windows.Forms;

namespace SportShopping
{
    public partial class frmProducts : Form
    {
        SanPhamRepository sanPhamRepo;
        DataTable dTable;
        public frmProducts()
        {
            InitializeComponent();
            sanPhamRepo = new SanPhamRepository();
            dTable = new DataTable();
            dTable.Columns.Add("Mã Sản Phẩm");
            dTable.Columns.Add("Tên Sản Phẩm");
            dTable.Columns.Add("Giá Tiền");
            dTable.Columns.Add("Ngày Nhập");
            dTable.Columns.Add("Tình Trạng");
            dTable.Columns.Add("Chất Liệu");
            dTable.Columns.Add("Hình Ảnh");
            dTable.Columns.Add("Size");
            dTable.Columns.Add("Tên Hàng");
            dTable.Columns.Add("Đối Tượng Sử Dụng");
            dTable.Columns.Add("Loại Hàng");
            dTable.Columns.Add("Bảo Hành");
            dTable.Columns.Add("Hãng Sản Xuất");
            dTable.Columns.Add("Số Lượng");
        }

        public void ResetField()
        {

        }

        public async void GridViewUpdate(IEnumerable<SanPham> list)
        {
            dTable.Rows.Clear();
            if (list != null && list.Count() > 0)
            {
                foreach (var product in list)
                {
                    dTable.Rows.Add(product.MaSanPham, product.TenSanPham, product.GiaTien, product.NgayNhap.Value.ToShortDateString(),
                        product.TinhTrang, product.ChatLieu, product.HinhAnh, product.Size, product.TenHang, product.DoiTuongSuDung,
                        product.MaLoaiHangNavigation.TenLoaiHang, product.MaBaoHanhNavigation.ThoiGianBaoHanh.Value, product.MaHangSanXuatNavigation.TenHangSanXuat, product.SoLuong);
                }
            }
            gridView.DataSource = dTable;
        }

        public async void GridViewUpdate()
        {
            string[] includes = { "MaBaoHanhNavigation", "MaHangSanXuatNavigation", "MaLoaiHangNavigation" };
            var list = await sanPhamRepo.Get(includeProperties: includes);
            GridViewUpdate(list);
        }

        public int checkInput()
        {
            return 1;
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            FillBoxKeySearch();
            GridViewUpdate();
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmMain.Instance.openChildForm(new frmProductDetails(false, this, null));
        }

        private void editButt_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 sản phẩm để sửa thông tin!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int id = int.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
                Visible = false;
                frmMain.Instance.openChildForm(new frmProductDetails(true, this, id));
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn 1 sản phẩm để sửa thông tin!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private async void delButt_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 sản phẩm để xóa thông tin!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult d = MessageBox.Show("Bạn có muốn xóa sản phẩm này?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Yes)
            {
                var sanPham = await sanPhamRepo.GetFirst(sp => sp.MaSanPham == id);
                bool result = await sanPhamRepo.Delete(sanPham);
                if (result)
                {
                    GridViewUpdate();
                    MessageBox.Show("Xóa Thành Công.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không Tồn Tại Sản Phẩm.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void exitButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillBoxKeySearch()
        {
            boxKeySearch.Items.Clear();
            boxKeySearch.Items.Add("Tên Sản Phẩm");
            boxKeySearch.Items.Add("Tên Loại Hàng");
            boxKeySearch.Items.Add("Hãng Sản Xuất");
            boxKeySearch.Items.Add("Số lượng");
            boxKeySearch.SelectedIndex = 0;
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }


        private async void searchButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(boxKeySearch.Text))
            {
                GridViewUpdate();
                return;
            }
            var searchText = searchBox.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                GridViewUpdate();
                return;
            }
            string[] includes = { "MaBaoHanhNavigation", "MaHangSanXuatNavigation", "MaLoaiHangNavigation" };
            switch (boxKeySearch.Text)
            {
                case "Tên Sản Phẩm":
                    GridViewUpdate(await sanPhamRepo.Get(sp => sp.TenSanPham.ToLower().Contains(searchText.ToLower())));
                    break;
                case "Tên Loại Hàng":
                    GridViewUpdate(await sanPhamRepo.Get(sp => sp.MaLoaiHangNavigation.TenLoaiHang.ToLower().Contains(searchText.ToLower()), includeProperties: includes));
                    break;
                case "Hãng Sản Xuất":
                    GridViewUpdate(await sanPhamRepo.Get(sp => sp.MaHangSanXuatNavigation.TenHangSanXuat.ToLower().Contains(searchText.ToLower()), includeProperties: includes));
                    break;

                case "Số lượng":

                    // int a = int.Parse(searchText);
                    GridViewUpdate(await sanPhamRepo.Get(sp => sp.SoLuong == 0));

                    break;


            }
        }


        private void boxKeySearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}

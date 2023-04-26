using BusinessObject;
using BusinessObject.Models;
using DataAccess;
using DataAccess.Repository;
using DataAccess.Repository.Implements;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace SportShopping
{
    public partial class frmOrderProduct : Form
    {
        DataTable productTable;
        DataTable cartTable;
        SanPhamRepository sanPhamRepo;
        KhachHang khachHang;
        Form parent;

        public frmOrderProduct(Form parent, KhachHang khachHang)
        {
            InitializeComponent();
            this.parent = parent;
            this.khachHang = khachHang;
            sanPhamRepo = new SanPhamRepository();
            productTable = new DataTable();
            cartTable = new DataTable();
            productTable.Columns.Add("Mã Sản Phẩm");
            productTable.Columns.Add("Tên Sản Phẩm");
            productTable.Columns.Add("Giá Tiền");
            productTable.Columns.Add("Chất Liệu");
            productTable.Columns.Add("Size");
            productTable.Columns.Add("Tên Hàng");
            productTable.Columns.Add("Đối Tượng Sử Dụng");
            productTable.Columns.Add("Loại Hàng");
            productTable.Columns.Add("Thời Gian Bảo Hành");
            productTable.Columns.Add("Hãng Sản Xuất");
            productTable.Columns.Add("Số Lượng");

            cartTable.Columns.Add("Mã Sản Phẩm");
            cartTable.Columns.Add("Tên Sản Phẩm");
            cartTable.Columns.Add("Giá Tiền");
            cartTable.Columns.Add("Số Lượng");
        }

        public async void GridViewProductUpdate()
        {
            string[] includes = { "MaLoaiHangNavigation", "MaBaoHanhNavigation", "MaHangSanXuatNavigation" };
            var list = await sanPhamRepo.Get(sp => sp.SoLuong > 0, includeProperties: includes);
            productTable.Rows.Clear();
            if (list != null && list.Count() > 0)
            {
                foreach (var product in list)
                {
                    string thoiGianBaoHanh = "";
                    if (product.MaBaoHanhNavigation.ThoiGianBaoHanh < 1)
                    {
                        thoiGianBaoHanh = product.MaBaoHanhNavigation.ThoiGianBaoHanh.Value * 10 + " Tháng";
                    }
                    else
                    {
                        thoiGianBaoHanh = product.MaBaoHanhNavigation.ThoiGianBaoHanh.Value + " Năm";
                    }
                    productTable.Rows.Add(product.MaSanPham, product.TenSanPham, product.GiaTien, product.ChatLieu, product.Size, product.TenHang, product.DoiTuongSuDung,
                        product.MaLoaiHangNavigation.TenLoaiHang, thoiGianBaoHanh, product.MaHangSanXuatNavigation.TenHangSanXuat, product.SoLuong);
                }
            }
            gridViewProduct.DataSource = productTable;
            gridViewProduct.Columns[0].Visible = false;
        }

        public void GridViewCartUpdate()
        {
            cartTable.Rows.Clear();
            var list = Cart.Instance.sanPhams;
            if (list != null && list.Count() > 0)
            {
                foreach (var product in list)
                {
                    cartTable.Rows.Add(product.MaSanPham, product.TenSanPham, product.GiaTien, product.SoLuong);
                }
            }
            gridViewCart.DataSource = cartTable;
            gridViewCart.Columns[0].Visible = false;
            txtTotalPrice.Text = $"Tổng Tiền: {Cart.Instance.GetTotalPrice()} VNĐ";
        }


        private void frmOrderProduct_Load(object sender, EventArgs e)
        {
            GridViewProductUpdate();
            GridViewCartUpdate();
        }

        private async void addProduct_Click(object sender, EventArgs e)
        {
            if (gridViewProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 sản phẩm để thêm vào giỏ!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int id = int.Parse(gridViewProduct.SelectedRows[0].Cells[0].Value.ToString());
                Cart.Instance.Add(await sanPhamRepo.GetFirst(sp => sp.MaSanPham == id));
                GridViewCartUpdate();
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn 1 sản phẩm để thêm vào giỏ!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void orderButt_Click(object sender, EventArgs e)
        {
            if (gridViewCart.Rows.Count < 1)
            {
                MessageBox.Show("Cần phải đặt mua ít nhất 1 sản phẩm!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            frmMain.Instance.openChildForm(new frmOrderPayment(parent, khachHang));
            Close();
        }

        private void gridViewOrderDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void changeButt_Click(object sender, EventArgs e)
        {

        }

        private void gridViewOrderDetail_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmOrderProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (gridViewProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 sản phẩm để xóa khỏi giỏ!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int id = int.Parse(gridViewCart.SelectedRows[0].Cells[0].Value.ToString());
                Cart.Instance.Remove(await sanPhamRepo.GetFirst(sp => sp.MaSanPham == id));
                GridViewCartUpdate();
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn 1 sản phẩm để xóa khỏi giỏ!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private async void backBtn_Click(object sender, EventArgs e)
        {
            if (gridViewProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 sản phẩm để giảm 1 sản phẩm khỏi giỏ!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int id = int.Parse(gridViewCart.SelectedRows[0].Cells[0].Value.ToString());
                Cart.Instance.RemoveOne(await sanPhamRepo.GetFirst(sp => sp.MaSanPham == id));
                GridViewCartUpdate();
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn 1 sản phẩm để giảm 1 sản phẩm khỏi giỏ!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void backBtn_Click_1(object sender, EventArgs e)
        {
            frmMain.Instance.openChildForm(parent);
            Close();
        }
    }
}

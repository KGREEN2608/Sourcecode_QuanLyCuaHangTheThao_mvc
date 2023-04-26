using BusinessObject.Models;
using DataAccess.Repository.Implements;

namespace SportShopping
{
    public partial class frmProductDetails : Form
    {
        private readonly bool isUpdate;
        private Form parent;
        private int? id;
        private SanPham sanPham;
        private readonly SanPhamRepository sanPhamRepo;
        private readonly LoaiHangRepository loaiHangRepo;
        private readonly HangSanXuatRepository hangSanXuatRepo;
        private readonly BaoHanhRepository baoHanhRepo;
        public frmProductDetails(bool isUpdate, Form parent, int? id)
        {
            InitializeComponent();
            this.isUpdate = isUpdate;
            this.parent = parent;
            this.id = id;
            sanPhamRepo = new SanPhamRepository();
            loaiHangRepo = new LoaiHangRepository();
            hangSanXuatRepo = new HangSanXuatRepository();
            baoHanhRepo = new BaoHanhRepository();
        }

        private async void FillComboboxs()
        {
            cbProductType.Items.Clear();
            cbProductProvider.Items.Clear();
            cbGuarentee.Items.Clear();
            cbStatus.Items.Clear();
            cbStatus.Items.Add("Đang Hoạt Động");
            cbStatus.Items.Add("Không Hoạt Động");
            cbStatus.SelectedIndex = 0;
            var loaiHangs = await loaiHangRepo.Get();
            if (loaiHangs == null || loaiHangs.Count() == 0)
            {
                MessageBox.Show("Không có loai hàng nào! Cần phải có ít nhất 1 loại hàng!");
                Close();
            }
            var baoHanhs = await baoHanhRepo.Get();
            if (baoHanhs == null || baoHanhs.Count() == 0)
            {
                MessageBox.Show("Không có loại bảo hành nào! Cần phải có ít nhất 1 loại bảo hành!");
                Close();
            }
            var hangSanXuats = await hangSanXuatRepo.Get();
            if (hangSanXuats == null || hangSanXuats.Count() == 0)
            {
                MessageBox.Show("Không có hãng sản xuất nào! Cần phải có ít nhất 1 hãng sản xuất!");
                Close();
            }
            foreach (var loaiHang in loaiHangs)
            {
                cbProductType.Items.Add(loaiHang.TenLoaiHang);
            }
            foreach (var hangSanXuat in hangSanXuats)
            {
                cbProductProvider.Items.Add(hangSanXuat.TenHangSanXuat);
            }
            foreach (var baoHanh in baoHanhs)
            {
                cbGuarentee.Items.Add(baoHanh.ThoiGianBaoHanh);
            }
            cbProductType.SelectedIndex = 0;
            cbProductProvider.SelectedIndex = 0;
            cbGuarentee.SelectedIndex = 0;
        }

        private async void frmProductDetails_Load(object sender, EventArgs e)
        {
            FillComboboxs();
            if (isUpdate)
            {
                Text = "Sửa Thông Tin Sản Phẩm";
                txtTitle.Text = "Sửa Thông Tin Sản Phẩm";
                addBtn.Text = "Sửa";
                if (id != null)
                {
                    string[] includes = { "MaBaoHanhNavigation", "MaHangSanXuatNavigation", "MaLoaiHangNavigation" };
                    sanPham = await sanPhamRepo.GetFirst(sp => sp.MaSanPham == id.Value, includeProperties: includes);
                    if (sanPham == null)
                    {
                        Close();
                    }
                    else
                    {
                        string status = "Còn Hàng";
                        if (!sanPham.TinhTrang.Value)
                        {
                            status = "Hết Hàng";
                        }
                        txtProductName.Text = sanPham.TenSanPham;
                        txtName.Text = sanPham.TenHang;
                        txtProductUser.Text = sanPham.DoiTuongSuDung;
                        txtSize.Text = sanPham.Size;
                        cbStatus.SelectedItem = status;
                        txtMaterial.Text = sanPham.ChatLieu;
                        cbGuarentee.SelectedItem = sanPham.MaBaoHanhNavigation.ThoiGianBaoHanh;
                        cbProductProvider.SelectedItem = sanPham.MaHangSanXuatNavigation.TenHangSanXuat;
                        cbProductType.SelectedItem = sanPham.MaLoaiHangNavigation.TenLoaiHang;
                        txtPath.Text = sanPham.HinhAnh;
                        image.Load(sanPham.HinhAnh);
                    }
                }
            }
            else
            {
                Text = "Tạo Sản Phẩm Mới";
                txtTitle.Text = "Tạo Sản Phẩm Mới";
                addBtn.Text = "Thêm";
            }
        }

        private void frmProductDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.Instance.openChildForm(new frmProducts());
        }

        private void ResetField()
        {
            txtMaterial.Text = "";
            txtName.Text = "";
            txtPath.Text = "";
            txtProductName.Text = "";
            txtProductUser.Text = "";
            txtSize.Text = "";
            cbStatus.SelectedIndex = 0;
            cbGuarentee.SelectedIndex = 0;
            cbProductProvider.SelectedIndex = 0;
            cbProductType.SelectedIndex = 0;
            numberAmount.Value = 1;
            numberPrice.Value = 10000;
        }

        private bool CheckInput()
        {
            if (txtProductName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ô Tên Sản Phẩm không được để trống!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtMaterial.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ô Chất Liệu không được để trống!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSize.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ô Kích Cỡ không được để trống!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPath.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ô Hình Ảnh không được để trống!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ô Tên Hàng không được để trống!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtProductUser.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ô Đối Tượng Sử Dụng không được để trống!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cbGuarentee.SelectedIndex == -1 ||
                cbProductProvider.SelectedIndex == -1 ||
                cbProductType.SelectedIndex == -1 ||
                cbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Thiếu Dữ Liệu Để Tạo Sản Phẩm!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            return true;
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            if (isUpdate)
            {
                if (sanPham == null)
                {
                    Close();
                }
                sanPham.TenHang = txtName.Text.Trim();
                sanPham.TenSanPham = txtProductName.Text.Trim();
                sanPham.ChatLieu = txtMaterial.Text.Trim();
                sanPham.DoiTuongSuDung = txtProductUser.Text.Trim();
                sanPham.GiaTien = (double)numberPrice.Value;
                sanPham.HinhAnh = txtPath.Text;
                sanPham.SoLuong = (int)numberAmount.Value;
                sanPham.Size = txtSize.Text.Trim();
                bool status = true;
                if (cbStatus.SelectedItem.ToString().Equals("Không Hoạt Động"))
                {
                    status = false;
                }
                sanPham.TinhTrang = status;
                var baoHanh = await baoHanhRepo.GetFirst(bh => bh.ThoiGianBaoHanh == (double)cbGuarentee.SelectedItem);
                var loaiHang = await loaiHangRepo.GetFirst(lh => lh.TenLoaiHang.Equals(cbProductType.SelectedItem.ToString()));
                var hangSanXuat = await hangSanXuatRepo.GetFirst(hsx => hsx.TenHangSanXuat.Equals(cbProductProvider.SelectedItem.ToString()));
                sanPham.MaBaoHanh = baoHanh.MaBaoHanh;
                sanPham.MaHangSanXuat = hangSanXuat.MaHangSanXuat;
                sanPham.MaLoaiHang = loaiHang.MaLoaiHang;
                bool result = await sanPhamRepo.Update(sanPham);
                if (result)
                {
                    MessageBox.Show("Sửa Thành Công.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                bool status = true;
                var baoHanh = await baoHanhRepo.GetFirst(bh => bh.ThoiGianBaoHanh == (double)cbGuarentee.SelectedItem);
                var loaiHang = await loaiHangRepo.GetFirst(lh => lh.TenLoaiHang.Equals(cbProductType.SelectedItem.ToString()));
                var hangSanXuat = await hangSanXuatRepo.GetFirst(hsx => hsx.TenHangSanXuat.Equals(cbProductProvider.SelectedItem.ToString()));
                if (cbStatus.SelectedItem.ToString().Equals("Không Hoạt Động"))
                {
                    status = false;
                }
                var sanPhamMoi = new SanPham()
                {
                    TenHang = txtName.Text.Trim(),
                    TenSanPham = txtProductName.Text.Trim(),
                    ChatLieu = txtMaterial.Text.Trim(),
                    DoiTuongSuDung = txtProductUser.Text.Trim(),
                    GiaTien = (double)numberPrice.Value,
                    HinhAnh = txtPath.Text,
                    SoLuong = (int)numberAmount.Value,
                    Size = txtSize.Text.Trim(),
                    NgayNhap = DateTime.Now.Date,
                    TinhTrang = status,
                    MaBaoHanh = baoHanh.MaBaoHanh,
                    MaHangSanXuat = hangSanXuat.MaHangSanXuat,
                    MaLoaiHang = loaiHang.MaLoaiHang,
                };
                SanPham result = await sanPhamRepo.Add(sanPhamMoi);
                if (result != null)
                {
                    MessageBox.Show("Thêm Thành Công.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetField();
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileBtn_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "all files (*.png,*.jpg,*.jpeg)|*.png;*.jpg;*.jpeg|png (*.png)|*.png|jpg (*.jpg)|.jpg|jpeg (*.jpeg)|*.jpeg",
            };
            DialogResult r = openFileDialog.ShowDialog();
            if (r == DialogResult.OK)
            {
                txtPath.Text = openFileDialog.FileName;
                image.Load(openFileDialog.FileName);
            }
        }
    }
}

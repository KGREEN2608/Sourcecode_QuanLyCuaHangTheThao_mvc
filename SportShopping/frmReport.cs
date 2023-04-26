using BusinessObject;
using DataAccess.Repository;
using DataAccess.Repository.Implements;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SportShopping
{
    public partial class frmReport : Form
    {

        class ProductReport
        {
            public string HangSanXuat { get; set; }

            public string LoaiHang { get; set; }

            public string TenSanPham { get; set; }

            public double TongTienThu { get; set; }

            public int HangTonKho { get; set; }

            public double KhuyenMai { get; set; }
        }

        HoaDonRepository hoaDonRepo;
        ChiTietHoaDonRepository chiTietHoaDonRepo;
        SanPhamRepository sanPhamRepo;
        DataTable dTable;
        List<ProductReport> productReports = new List<ProductReport>();
        public frmReport()
        {
            hoaDonRepo = new HoaDonRepository();
            chiTietHoaDonRepo = new ChiTietHoaDonRepository();
            sanPhamRepo = new SanPhamRepository();
            InitializeComponent();
            dTable = new DataTable();
            dTable.Columns.Add("Hãng Sản Xuất");
            dTable.Columns.Add("Loại Hàng");
            dTable.Columns.Add("Tên Sản Phẩm");
            dTable.Columns.Add("Tổng Tiền Thu");
            dTable.Columns.Add("Hàng Tồn Kho");
            dTable.Columns.Add("Khuyến Mãi Trung Bình");
        }

        private void FillCombobox()
        {
            cbReport.Items.Clear();
            cbReport.Items.Add("Tất Cả");
            cbReport.Items.Add("Top 5 Sản Phẩm Bán Chạy");
            cbReport.Items.Add("Top 10 Sản Phẩm Bán Chạy");
            cbReport.Items.Add("Top 20 Sản Phẩm Bán Chạy");
            cbReport.SelectedIndex = 0;
        }

        public void GridViewUpdate(DateTime startDate, DateTime endDate)
        {

        }

        public async void GridViewUpdate(string filter)
        {
            dTable.Rows.Clear();
            productReports.Clear();
            string[] includes = { "MaBaoHanhNavigation", "MaHangSanXuatNavigation", "MaLoaiHangNavigation" };
            var sanPhams = await sanPhamRepo.Get(includeProperties: includes);
            double allProductTotalPrice = 0;
            if (sanPhams != null && sanPhams.Count() > 0)
            {
                foreach (var sp in sanPhams)
                {
                    var list = await chiTietHoaDonRepo.Get(ctthd => ctthd.MaSanPham == sp.MaSanPham);
                    double totalPrice = 0;
                    int kmCount = 0;
                    double kmTotal = 0;
                    if (list != null && list.Count() > 0)
                    {
                        foreach (var item in list)
                        {
                            var hd = await hoaDonRepo.GetFirst(hd => hd.MaHoaDon == item.MaHoaDon);
                            double totalItemPrice = item.DonGia.Value * item.SoLuong.Value;
                            totalPrice += totalItemPrice - (totalItemPrice * ((float)hd.KhuyenMai.Value / 100));
                            kmTotal += hd.KhuyenMai.Value;
                            kmCount++;
                        }
                        productReports.Add(new ProductReport()
                        {
                            HangSanXuat = sp.MaHangSanXuatNavigation.TenHangSanXuat,
                            LoaiHang = sp.MaLoaiHangNavigation.TenLoaiHang,
                            TenSanPham = sp.TenSanPham,
                            TongTienThu = totalPrice,
                            HangTonKho = sp.SoLuong.Value,
                            KhuyenMai = kmTotal / kmCount,
                        });
                    }
                    else
                    {
                        productReports.Add(new ProductReport()
                        {
                            HangSanXuat = sp.MaHangSanXuatNavigation.TenHangSanXuat,
                            LoaiHang = sp.MaLoaiHangNavigation.TenLoaiHang,
                            TenSanPham = sp.TenSanPham,
                            TongTienThu = 0,
                            HangTonKho = sp.SoLuong.Value,
                            KhuyenMai = 0,
                        });
                    }
                }
            }
            var orderList = productReports.OrderByDescending(p => p.TongTienThu);
            switch (filter)
            {
                case "Tất Cả":
                    if (orderList != null && orderList.Count() > 0)
                    {
                        foreach (var item in orderList)
                        {
                            dTable.Rows.Add(item.HangSanXuat, item.LoaiHang, item.TenSanPham, string.Format("{0:0}", item.TongTienThu) + " VNĐ", item.HangTonKho, item.KhuyenMai + "%");
                            allProductTotalPrice += item.TongTienThu;
                        }
                    }
                    break;
                case "Top 5 Sản Phẩm Bán Chạy":
                    if (orderList != null && orderList.Count() > 0)
                    {
                        int i = 0;
                        foreach (var item in orderList)
                        {
                            if (i == 5)
                            {
                                break;
                            }
                            dTable.Rows.Add(item.HangSanXuat, item.LoaiHang, item.TenSanPham, string.Format("{0:0}", item.TongTienThu) + " VNĐ", item.HangTonKho, item.KhuyenMai + "%");
                            allProductTotalPrice += item.TongTienThu;
                            i++;
                        }
                    }
                    break;
                case "Top 10 Sản Phẩm Bán Chạy":
                    if (orderList != null && orderList.Count() > 0)
                    {
                        int i = 0;
                        foreach (var item in orderList)
                        {
                            if (i == 10)
                            {
                                break;
                            }
                            dTable.Rows.Add(item.HangSanXuat, item.LoaiHang, item.TenSanPham, string.Format("{0:0}", item.TongTienThu) + " VNĐ", item.HangTonKho, item.KhuyenMai + "%");
                            allProductTotalPrice += item.TongTienThu;
                            i++;
                        }
                    }
                    break;
                case "Top 20 Sản Phẩm Bán Chạy":
                    if (orderList != null && orderList.Count() > 0)
                    {
                        int i = 0;
                        foreach (var item in orderList)
                        {
                            if (i == 20)
                            {
                                break;
                            }
                            dTable.Rows.Add(item.HangSanXuat, item.LoaiHang, item.TenSanPham, string.Format("{0:0}", item.TongTienThu) + " VNĐ", item.HangTonKho, item.KhuyenMai + "%");
                            allProductTotalPrice += item.TongTienThu;
                            i++;
                        }
                    }
                    break;
            }
            txtTotalPrice.Text = $"{string.Format("{0:0}", allProductTotalPrice)} VNĐ";
            gridView.DataSource = dTable;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            FillCombobox();
        }

        private void datePickerStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void datePickerEndDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReport.SelectedIndex != -1)
            {
                var item = cbReport.SelectedItem.ToString();
                switch (item)
                {
                    case "Tất Cả":
                        GridViewUpdate(item);
                        break;
                    case "Top 5 Sản Phẩm Bán Chạy":
                        GridViewUpdate(item);
                        break;
                    case "Top 10 Sản Phẩm Bán Chạy":
                        GridViewUpdate(item);
                        break;
                    case "Top 20 Sản Phẩm Bán Chạy":
                        GridViewUpdate(item);
                        break;
                }
            }
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

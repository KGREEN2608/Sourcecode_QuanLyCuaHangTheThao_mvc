using BusinessObject.Models;
using DataAccess.Repository.Implements;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportShopping
{
    public partial class frmOrderPayment : Form
    {
        Form parent;
        KhachHang khachHang;
        HoaDonRepository hoaDonRepo;
        ChiTietHoaDonRepository chiTietHoaDonRepo;
        SanPhamRepository sanPhamRepo;
        public frmOrderPayment(Form parent, KhachHang khachHang)
        {
            InitializeComponent();
            hoaDonRepo = new HoaDonRepository();
            chiTietHoaDonRepo = new ChiTietHoaDonRepository();
            sanPhamRepo = new SanPhamRepository();
            this.parent = parent;
            this.khachHang = khachHang;
        }

        public void FillComboboxs()
        {
            cbCTTT.Items.Clear();
            cbKhuyenMai.Items.Clear();
            cbCTTT.Items.Add("Trực Tiếp");
            cbCTTT.Items.Add("Thanh Toán Momo");

            for (int i = 0; i <= 100; i += 10)
            {
                cbKhuyenMai.Items.Add(i + " %");
            }
            cbCTTT.SelectedIndex = 0;
            cbKhuyenMai.SelectedIndex = 0;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CheckInput()
        {
            if (!radioButtonNo.Checked && !radioButtonYes.Checked)
            {
                MessageBox.Show("Hãy chọn in hóa đơn hoặc không!", "Question", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private async void paymentBtn_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            string cttt = cbCTTT.SelectedItem.ToString();
            string exportPdfstring = "Hóa Đơn\n" +
                                             $"Tên Khách Hàng: {khachHang.HoTen}\n" +
                                             $"Số Điện Thoại: {khachHang.Sdt}\n" +
                                             $"Nhân Viên: {frmMain.Instance.CurrentAccount.TenNhanVien}\n" +
                                             $"Ngày Tạo: {DateTime.Now.Date.ToShortDateString()}\n" +
                                             $"Kiểu Thanh Toán: {cttt}\n" +
                                             $"Khuyến Mãi: {cbKhuyenMai.SelectedItem.ToString()}\n" +
                                             $"-----------------------------------------------------------\n" +
                                             string.Format("{0,-25}     {1,-10}     {2,-10}", "Tên Sản Phẩm", "Số Lượng", "Giá Tiền") + "\n";
            switch (cttt)
            {
                case "Trực Tiếp":
                    int khuyenMai = int.Parse(cbKhuyenMai.SelectedItem.ToString().Split(" ")[0]);
                    double totalPrice = double.Parse(txtTotalPrice.Value.ToString());
                    var nHd = new HoaDon()
                    {
                        MakhachHang = khachHang.MaKhachHang,
                        KhuyenMai = khuyenMai,
                        NgayTao = DateTime.Now.Date,
                        TongTien = totalPrice,
                    };
                    nHd = await hoaDonRepo.Add(nHd);
                    var listCttHd = Cart.Instance.sanPhams;
                    if (listCttHd != null && listCttHd.Count > 0)
                    {
                        foreach (var item in listCttHd)
                        {
                            var ctthd = await chiTietHoaDonRepo.Add(new ChiTietHoaDon()
                            {
                                DonGia = item.GiaTien,
                                SoLuong = item.SoLuong,
                                MaSanPham = item.MaSanPham,
                                MaHoaDon = nHd.MaHoaDon,
                            });
                            if (ctthd != null)
                            {
                                var sanPhamDb = await sanPhamRepo.GetFirst(sp => sp.MaSanPham == item.MaSanPham);
                                sanPhamDb.SoLuong -= item.SoLuong;
                                await sanPhamRepo.Update(sanPhamDb);
                            }
                            exportPdfstring += string.Format("{0,-25}     {1,-10}     {2,-10}", item.TenSanPham, item.SoLuong, string.Format("{0:0}", item.GiaTien) + " VNĐ") + "\n";
                        }
                        exportPdfstring += $"-----------------------------------------------------------\n";
                        exportPdfstring += $"Mã Hóa Đơn: {nHd.MaHoaDon}\n";
                        exportPdfstring += $"Tổng Thanh Toán: {string.Format("{0:0}", totalPrice)} VNĐ\n";
                        MessageBox.Show("Thanh Toán Thành Công.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (radioButtonYes.Checked)
                        {
                            SaveFileDialog saveFile = new SaveFileDialog()
                            {
                                Filter = "PDF file(*.pdf)|*.pdf",
                                ValidateNames = true,
                                CheckPathExists = true,
                                DefaultExt = ".pdf",
                                AddExtension = true,
                            };
                            DialogResult d = saveFile.ShowDialog();
                            if (d == DialogResult.OK)
                            {
                                PdfDocument document = new PdfDocument();
                                PdfPage page = document.AddPage();
                                XGraphics gfx = XGraphics.FromPdfPage(page);
                                XFont title = new XFont("Verdana", 20, XFontStyle.Bold);
                                XFont regular = new XFont("Verdana", 16, XFontStyle.Regular);
                                string[] exports = exportPdfstring.Split("\n");
                                int x = 0, y = 0;
                                int i = 0;
                                foreach (string export in exports)
                                {
                                    if (i > 0)
                                    {
                                        gfx.DrawString(export, regular, XBrushes.Black,
                                        new XRect(x, y, page.Width, page.Height), XStringFormats.TopLeft);
                                    }
                                    else
                                    {
                                        gfx.DrawString(export, title, XBrushes.Black,
                                        new XRect(x, y, page.Width, page.Height), XStringFormats.TopLeft);
                                    }
                                    y += 30;
                                    i++;
                                }
                                document.Save(saveFile.FileName);
                                Process.Start(new ProcessStartInfo
                                {
                                    FileName = saveFile.FileName,
                                    UseShellExecute = true
                                });
                            }
                        }
                        Cart.Instance.Close();
                        Close();
                    }
                    else
                    {
                        await hoaDonRepo.Delete(nHd);
                    }
                    break;
                case "Thanh Toán Momo":
                    khuyenMai = int.Parse(cbKhuyenMai.SelectedItem.ToString().Split(" ")[0]);
                    totalPrice = double.Parse(txtTotalPrice.Value.ToString());
                    nHd = new HoaDon()
                    {
                        MakhachHang = khachHang.MaKhachHang,
                        KhuyenMai = khuyenMai,
                        NgayTao = DateTime.Now.Date,
                        TongTien = totalPrice,
                    };
                    nHd = await hoaDonRepo.Add(nHd);
                    listCttHd = Cart.Instance.sanPhams;
                    if (listCttHd != null && listCttHd.Count > 0)
                    {
                        foreach (var item in listCttHd)
                        {
                            var ctthd = await chiTietHoaDonRepo.Add(new ChiTietHoaDon()
                            {
                                DonGia = item.GiaTien,
                                SoLuong = item.SoLuong,
                                MaSanPham = item.MaSanPham,
                                MaHoaDon = nHd.MaHoaDon,
                            });
                            if (ctthd != null)
                            {
                                var sanPhamDb = await sanPhamRepo.GetFirst(sp => sp.MaSanPham == item.MaSanPham);
                                sanPhamDb.SoLuong -= item.SoLuong;
                                await sanPhamRepo.Update(sanPhamDb);
                            }
                            exportPdfstring += string.Format("{0,-25}     {1,-10}     {2,-10}", item.TenSanPham, item.SoLuong, string.Format("{0:0}", item.GiaTien) + " VNĐ") + "\n";
                        }
                        exportPdfstring += $"-----------------------------------------------------------\n";
                        exportPdfstring += $"Mã Hóa Đơn: {nHd.MaHoaDon}\n";
                        exportPdfstring += $"Tổng Thanh Toán: {string.Format("{0:0}", totalPrice)} VNĐ\n";
                        MessageBox.Show("Thanh Toán Thành Công.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (radioButtonYes.Checked)
                        {
                            SaveFileDialog saveFile = new SaveFileDialog()
                            {
                                Filter = "PDF file(*.pdf)|*.pdf",
                                ValidateNames = true,
                                CheckPathExists = true,
                                DefaultExt = ".pdf",
                                AddExtension = true,
                            };
                            DialogResult d = saveFile.ShowDialog();
                            if (d == DialogResult.OK)
                            {
                                PdfDocument document = new PdfDocument();
                                PdfPage page = document.AddPage();
                                XGraphics gfx = XGraphics.FromPdfPage(page);
                                XFont title = new XFont("Verdana", 20, XFontStyle.Bold);
                                XFont regular = new XFont("Verdana", 16, XFontStyle.Regular);
                                string[] exports = exportPdfstring.Split("\n");
                                int x = 0, y = 0;
                                int i = 0;
                                foreach (string export in exports)
                                {
                                    if (i > 0)
                                    {
                                        gfx.DrawString(export, regular, XBrushes.Black,
                                        new XRect(x, y, page.Width, page.Height), XStringFormats.TopLeft);
                                    }
                                    else
                                    {
                                        gfx.DrawString(export, title, XBrushes.Black,
                                        new XRect(x, y, page.Width, page.Height), XStringFormats.TopLeft);
                                    }
                                    y += 30;
                                    i++;
                                }
                                document.Save(saveFile.FileName);
                                Process.Start(new ProcessStartInfo
                                {
                                    FileName = saveFile.FileName,
                                    UseShellExecute = true
                                });
                            }
                        }
                        Cart.Instance.Close();
                        Close();
                        frmMain.Instance.openChildForm(new frmMomo(parent));
                    }
                    else
                    {
                        await hoaDonRepo.Delete(nHd);
                    }
                    break;
            }
        }

        private void frmOrderPayment_Load(object sender, EventArgs e)
        {
            FillComboboxs();
            if (khachHang == null)
            {
                Close();
            }
            txtSdt.Text = khachHang.Sdt;
            txtTenKhachHang.Text = khachHang.HoTen;
            txtTotalPrice.Value = decimal.Parse(Cart.Instance.GetTotalPrice() + "");
        }

        private void frmOrderPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.Instance.openChildForm(parent);
        }

        private void cbKhuyenMai_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int khuyenMai = int.Parse(cbKhuyenMai.SelectedItem.ToString().Split(" ")[0]);
                if (khuyenMai > 0)
                {
                    double productTotalPrice = Cart.Instance.GetTotalPrice();
                    double totalPrice = productTotalPrice - (productTotalPrice * ((float)khuyenMai / 100)); ;
                    txtTotalPrice.Value = decimal.Parse(totalPrice + "");
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

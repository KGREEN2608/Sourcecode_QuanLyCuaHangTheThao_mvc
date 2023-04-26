using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int MaSanPham { get; set; }
        public string? TenSanPham { get; set; }
        public double? GiaTien { get; set; }
        public DateTime? NgayNhap { get; set; }
        public bool? TinhTrang { get; set; }
        public string? ChatLieu { get; set; }
        public string? HinhAnh { get; set; }
        public string? Size { get; set; }
        public string? TenHang { get; set; }
        public string? DoiTuongSuDung { get; set; }
        public int? MaLoaiHang { get; set; }
        public int? MaBaoHanh { get; set; }
        public int? MaHangSanXuat { get; set; }
        public int? SoLuong { get; set; }

        public virtual BaoHanh? MaBaoHanhNavigation { get; set; }
        public virtual HangSanXuat? MaHangSanXuatNavigation { get; set; }
        public virtual LoaiHang? MaLoaiHangNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public SanPham Clone()
        {
            return new SanPham()
            {
                SoLuong = this.SoLuong,
                ChatLieu = this.ChatLieu,
                ChiTietHoaDons = this.ChiTietHoaDons,
                DoiTuongSuDung = this.DoiTuongSuDung,
                GiaTien = this.GiaTien,
                HinhAnh = this.HinhAnh,
                MaBaoHanh = this.MaBaoHanh,
                MaHangSanXuat = this.MaHangSanXuat,
                MaBaoHanhNavigation = this.MaBaoHanhNavigation,
                MaHangSanXuatNavigation = this.MaHangSanXuatNavigation,
                MaLoaiHang = this.MaLoaiHang,
                MaLoaiHangNavigation =  this.MaLoaiHangNavigation,
                MaSanPham = this.MaSanPham,
                NgayNhap = this.NgayNhap,
                Size = this.Size,
                TenHang = this.TenHang,
                TenSanPham = this.TenSanPham,
                TinhTrang = this.TinhTrang,
            };
        }
    }
}

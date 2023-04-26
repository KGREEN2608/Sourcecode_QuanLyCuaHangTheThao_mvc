using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class ChiTietHoaDon
    {
        public int MaHoaDon { get; set; }
        public int MaSanPham { get; set; }
        public int? SoLuong { get; set; }
        public double? DonGia { get; set; }

        public virtual HoaDon MaHoaDonNavigation { get; set; } = null!;
        public virtual SanPham MaSanPhamNavigation { get; set; } = null!;
    }
}

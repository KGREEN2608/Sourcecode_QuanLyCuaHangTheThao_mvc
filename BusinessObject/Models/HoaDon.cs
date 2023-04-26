using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int MaHoaDon { get; set; }
        public DateTime? NgayTao { get; set; }
        public double? TongTien { get; set; }
        public double? KhuyenMai { get; set; }
        public int? MakhachHang { get; set; }

        public virtual KhachHang? MakhachHangNavigation { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int MaKhachHang { get; set; }
        public string? Sdt { get; set; }
        public string? HoTen { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}

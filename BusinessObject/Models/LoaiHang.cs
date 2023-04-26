using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class LoaiHang
    {
        public LoaiHang()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int MaLoaiHang { get; set; }
        public string? TenLoaiHang { get; set; }
        public string? Mota { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}

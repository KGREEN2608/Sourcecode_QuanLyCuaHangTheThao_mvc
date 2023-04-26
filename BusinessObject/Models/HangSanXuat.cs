using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class HangSanXuat
    {
        public HangSanXuat()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int MaHangSanXuat { get; set; }
        public string? TenHangSanXuat { get; set; }
        public string? MoTa { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}

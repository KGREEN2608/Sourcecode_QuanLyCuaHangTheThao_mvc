using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class BaoHanh
    {
        public BaoHanh()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int MaBaoHanh { get; set; }
        public double? ThoiGianBaoHanh { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}

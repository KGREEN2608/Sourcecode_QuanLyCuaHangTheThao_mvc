using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class NhanVien
    {
        public int MaNhanVien { get; set; }
        public string? TenNhanVien { get; set; }
        public bool? GioiTinh { get; set; }
        public string? CapBac { get; set; }
        public string? Email { get; set; }
        public DateTime? NamSinh { get; set; }
        public string? MatKhau { get; set; }
        public int? Luong { get; set; }
    }
}

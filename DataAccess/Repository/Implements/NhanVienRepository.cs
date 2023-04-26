using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Implements
{
    public class NhanVienRepository : GenericRepository<NhanVien>
    {
        public NhanVienRepository() : base()
        {
        }

        public async Task<NhanVien> CheckLogin(string email, string password)
        {
            var nhanVien = _context.NhanViens.FirstOrDefault(nv => nv.Email.ToLower().Equals(email.ToLower()) && nv.MatKhau.Equals(password));
            if(nhanVien != null)
            {
                return nhanVien;
            }
            return null;
        }
    }
}

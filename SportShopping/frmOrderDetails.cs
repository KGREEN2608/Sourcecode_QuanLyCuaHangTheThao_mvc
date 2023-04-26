using BusinessObject.Models;
using DataAccess.Repository.Implements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportShopping
{
    public partial class frmOrderDetails : Form
    {
        private int? id;
        private Form parent;
        DataTable dTable;
        private readonly ChiTietHoaDonRepository chiTietHoaDonRepo;
        public frmOrderDetails(Form parent, int? id)
        {
            InitializeComponent();
            this.id = id;
            this.parent = parent;
            chiTietHoaDonRepo = new ChiTietHoaDonRepository();
            dTable = new DataTable();
            dTable.Columns.Add("Mã Hóa Đơn");
            dTable.Columns.Add("Tên Sản Phẩm");
            dTable.Columns.Add("Số Lượng");
            dTable.Columns.Add("Đơn Giá");

        }
        public async void GridViewUpdate(IEnumerable<ChiTietHoaDon> list)
        {
            dTable.Rows.Clear();
            if (list != null && list.Count() > 0)
            {
                foreach (var orderDetails in list)
                {
                    dTable.Rows.Add(orderDetails.MaHoaDon, orderDetails.MaSanPhamNavigation.TenSanPham, orderDetails.SoLuong, orderDetails.DonGia);
                }
            }
            gridView.DataSource = dTable;
        }

        public async void GridViewUpdate()
        {
            if (id == null)
            {
                Close();
            }
            string[] includes = { "MaSanPhamNavigation" };
            var list = await chiTietHoaDonRepo.Get(cthd => cthd.MaHoaDon == id, includeProperties: includes);
            GridViewUpdate(list);
        }

        private void frmOrderDetails_Load(object sender, EventArgs e)
        {
            GridViewUpdate();
        }

        private void exitButt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmOrderDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.Instance.openChildForm(parent);
        }
    }
}

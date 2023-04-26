using BusinessObject;
using BusinessObject.Models;
using DataAccess;
using DataAccess.Repository;
using DataAccess.Repository.Implements;
using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace SportShopping
{
    public partial class frmOrders : Form
    {
        HoaDonRepository hoaDonRepo;
        ChiTietHoaDonRepository chiTietHoaDonRepo;
        DataTable dTable;
        Form activeForm;
        bool isBinding = false;
        public bool isUsing = false;
        public frmOrders()
        {
            this.chiTietHoaDonRepo = new ChiTietHoaDonRepository();
            this.hoaDonRepo = new HoaDonRepository();
            InitializeComponent();
            dTable = new DataTable();
            dTable.Columns.Add("Mã Hóa Đơn");
            dTable.Columns.Add("Ngày Tạo");
            dTable.Columns.Add("Tổng Tiền");
            dTable.Columns.Add("Khuyến Mãi");
            dTable.Columns.Add("Tên Khách Hàng");
        }

        public async void GridViewUpdate(IEnumerable<HoaDon> list)
        {
            dTable.Rows.Clear();
            if (list != null && list.Count() > 0)
            {
                foreach (var order in list)
                {
                    dTable.Rows.Add(order.MaHoaDon, order.NgayTao.Value.ToShortDateString(), string.Format("{0:0}", order.TongTien), order.KhuyenMai + "%", order.MakhachHangNavigation.HoTen);
                }
            }
            gridView.DataSource = dTable;
        }

        public async void GridViewUpdate()
        {
            string[] includes = { "MakhachHangNavigation" };
            var list = await hoaDonRepo.Get(includeProperties: includes);
            GridViewUpdate(list);
        }

        public void ResetField()
        {
        }

        public int checkInput()
        {
            return 1;
        }
        public int MaxUnitInStock()
        {
            int max = -1;
            return max;
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            FillBoxKeySearch();
            GridViewUpdate();
        }

        private async void delButt_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 hóa đơn để sửa thông tin!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult d = MessageBox.Show("Bạn có muốn xóa hóa đơn này?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Yes)
            {
                var chiTietHoaDons = await chiTietHoaDonRepo.Get(cthd => cthd.MaHoaDon == id);
                if (chiTietHoaDons != null && chiTietHoaDons.Count() > 0)
                {
                    foreach (var chiTietHoaDon in chiTietHoaDons)
                    {
                        await chiTietHoaDonRepo.Delete(chiTietHoaDon);
                    }
                }
                var hoaDon = await hoaDonRepo.GetFirst(hd => hd.MaHoaDon == id);
                bool result = await hoaDonRepo.Delete(hoaDon);
                if (result)
                {
                    GridViewUpdate();
                    MessageBox.Show("Xóa Thành Công.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không Tồn Tại Hóa Đơn.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void exitButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detailsBtn_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 hóa đơn để xem chi tiết hóa đơn!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int id = int.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
                Visible = false;
                frmMain.Instance.openChildForm(new frmOrderDetails(this, id));
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn 1 hóa đơn để xem chi tiết hóa đơn!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void FillBoxKeySearch()
        {
            boxKeySearch.Items.Clear();
            boxKeySearch.Items.Add("Tên Khách Hàng");
            boxKeySearch.Items.Add("Mã Hóa Đơn");
            boxKeySearch.SelectedIndex = 0;
        }

        private async void searchButt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(boxKeySearch.Text))
            {
                GridViewUpdate();
                return;
            }
            var searchText = searchBox.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                GridViewUpdate();
                return;
            }
            string[] includes = { "MakhachHangNavigation" };
            switch (boxKeySearch.Text)
            {
                case "Tên Khách Hàng":
                    GridViewUpdate(await hoaDonRepo.Get(hd => hd.MakhachHangNavigation.HoTen.ToLower().Contains(searchText.ToLower()), includeProperties: includes));
                    break;
                case "Mã Hóa Đơn":
                    GridViewUpdate(await hoaDonRepo.Get(hd => hd.MaHoaDon == int.Parse(searchText.ToLower())));
                    break;
            }
        }
    }
}

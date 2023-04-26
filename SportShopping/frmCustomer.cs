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
    public partial class frmCustomer : Form
    {
        KhachHangRepository khachHangRepo;
        DataTable dTable;
        public frmCustomer()
        {
            InitializeComponent();
            khachHangRepo = new KhachHangRepository();
            dTable = new DataTable();
            dTable.Columns.Add("Mã Khách Hàng");
            dTable.Columns.Add("Số Điện Thoại");
            dTable.Columns.Add("Họ Tên");
        }

        private void FillBoxKeySearch()
        {
            boxKeySearch.Items.Clear();
            boxKeySearch.Items.Add("Họ Tên");
            boxKeySearch.Items.Add("Số Điện Thoại");
            boxKeySearch.SelectedIndex = 0;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            FillBoxKeySearch();
            GridViewUpdate();
        }

        public async void GridViewUpdate(IEnumerable<KhachHang> list)
        {
            dTable.Rows.Clear();
            if (list != null && list.Count() > 0)
            {
                foreach (var customer in list)
                {
                    dTable.Rows.Add(customer.MaKhachHang, customer.Sdt, customer.HoTen);
                }
            }
            gridView.DataSource = dTable;
        }

        public async void GridViewUpdate()
        {
            var list = await khachHangRepo.Get();
            GridViewUpdate(list);
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmMain.Instance.openChildForm(new frmCustomerDetails(false, this, null));
        }

        private void editButt_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 khách hàng để sửa thông tin!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int id = int.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
                Visible = false;
                frmMain.Instance.openChildForm(new frmCustomerDetails(true, this, id));
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn 1 khách hàng để sửa thông tin!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private async void delButt_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 khách hàng để xóa thông tin!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult d = MessageBox.Show("Bạn có muốn xóa khách hàng này?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Yes)
            {
                var nhanVien = await khachHangRepo.GetFirst(nv => nv.MaKhachHang == id);
                bool result = await khachHangRepo.Delete(nhanVien);
                if (result)
                {
                    GridViewUpdate();
                    MessageBox.Show("Xóa Thành Công.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không Tồn Tại Khách Hàng.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
            switch (boxKeySearch.Text)
            {
                case "Họ Tên":
                    GridViewUpdate(await khachHangRepo.Get(nv => nv.HoTen.ToLower().Contains(searchText.ToLower())));
                    break;
                case "Số Điện Thoại":
                    GridViewUpdate(await khachHangRepo.Get(nv => nv.Sdt.Contains(searchText)));
                    break;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 khách hàng để đặt hàng!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
            var khachHang = await khachHangRepo.GetFirst(kh => kh.MaKhachHang == id);
            if (khachHang == null)
            {
                MessageBox.Show("Chọn 1 khách hàng để đặt hàng!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult d = MessageBox.Show("Bạn có muốn đặt hàng với khách hàng này?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Yes)
            {
                Visible = false;
                frmMain.Instance.openChildForm(new frmOrderProduct(this, khachHang));
            }
        }

        private void exitButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boxKeySearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

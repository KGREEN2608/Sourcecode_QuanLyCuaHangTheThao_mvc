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
    public partial class frmMembers : Form
    {

        NhanVienRepository nhanVienRepo;
        DataTable dTable;
        public frmMembers()
        {
            this.nhanVienRepo = new NhanVienRepository();
            InitializeComponent();
            dTable = new DataTable();
            dTable.Columns.Add("Mã Nhân Viên");
            dTable.Columns.Add("Tên Nhân Viên");
            dTable.Columns.Add("Giới Tính");
            dTable.Columns.Add("Cấp Bậc");
            dTable.Columns.Add("Email");
            dTable.Columns.Add("Ngày Sinh");
            dTable.Columns.Add("Mật Khẩu");
            dTable.Columns.Add("Lương");
        }

        public void ResetField()
        {

        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            FillBoxKeySearch();
            GridViewUpdate();
        }
        public async void GridViewUpdate(IEnumerable<NhanVien> list)
        {
            dTable.Rows.Clear();
            if (list != null && list.Count() > 0)
            {
                foreach (var member in list)
                {
                    dTable.Rows.Add(member.MaNhanVien, member.TenNhanVien, member.GioiTinh, member.CapBac, member.Email, member.NamSinh.Value.ToShortDateString(), "***", member.Luong);
                }
            }
            gridView.DataSource = dTable;
        }

        public async void GridViewUpdate()
        {
            var list = await nhanVienRepo.Get();
            GridViewUpdate(list);
        }

        public int checkInput()
        {

            return 1;
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            Visible = false;
            frmMain.Instance.openChildForm(new frmMemberDetails(false, this, null));
        }

        public void CurrentMemberGridView()
        {
        }

        private void editButt_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 nhân viên để sửa thông tin!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int id = int.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
                Visible = false;
                frmMain.Instance.openChildForm(new frmMemberDetails(true, this, id));
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn 1 nhân viên để sửa thông tin!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        private async void delButt_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn 1 nhân viên để xóa thông tin!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = int.Parse(gridView.SelectedRows[0].Cells[0].Value.ToString());
            DialogResult d = MessageBox.Show("Bạn có muốn xóa nhân viên này?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Yes)
            {
                var nhanVien = await nhanVienRepo.GetFirst(nv => nv.MaNhanVien == id);
                bool result = await nhanVienRepo.Delete(nhanVien);
                if (result)
                {
                    GridViewUpdate();
                    MessageBox.Show("Xóa Thành Công.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không Tồn Tại Nhân Viên.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void exitButt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FillBoxKeySearch()
        {
            boxKeySearch.Items.Clear();
            boxKeySearch.Items.Add("Tên Nhân Viên");
            boxKeySearch.Items.Add("Cấp Bậc");
            boxKeySearch.Items.Add("Email");
            boxKeySearch.SelectedIndex = 0;
        }

        private async void searchBox_TextChanged(object sender, EventArgs e)
        {

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
                case "Tên Nhân Viên":
                    GridViewUpdate(await nhanVienRepo.Get(nv => nv.TenNhanVien.ToLower().Contains(searchText.ToLower())));
                    break;
                case "Cấp Bậc":
                    GridViewUpdate(await nhanVienRepo.Get(nv => nv.CapBac.ToLower().Contains(searchText.ToLower())));
                    break;
                case "Email":
                    GridViewUpdate(await nhanVienRepo.Get(nv => nv.Email.ToLower().Contains(searchText.ToLower())));
                    break;
            }
        }
    }
}

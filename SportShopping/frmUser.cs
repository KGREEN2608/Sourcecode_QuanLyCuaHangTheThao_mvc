using BusinessObject;
using DataAccess.Repository;
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
    public partial class frmUser : Form
    {
        NhanVienRepository nhanVienRepo;
        Form parent;
        public frmUser(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            nhanVienRepo = new NhanVienRepository();
        }

        public int checkInput()
        {
            if (txtName.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Ô Tên Nhân Viên không được để trống!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            if (txtEmail.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Ô Email không được để trống!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            if (txtPassword.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Ô Mật Khẩu không được để trống!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            if (!gender1.Checked && !gender2.Checked)
            {
                MessageBox.Show("Chọn Giới Tính!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            if (!txtPassword.Text.Equals("***") && txtPassword.Text.Trim().Length > 1 && txtPassword.Text.Trim().Length < 6)
            {
                MessageBox.Show("Mật Khẩu ít nhất 6 chữ số!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            if (birthDate.Value.Date.CompareTo(DateTime.Now.Date) >= 0)
            {
                MessageBox.Show("Ngày Sinh Không Thể Để Thời Gian Ở Tương Lai!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            return 1;
        }

        private async void saveButt_Click(object sender, EventArgs e)
        {
            if (checkInput() == 0) return;
            DialogResult d = MessageBox.Show("Do you want to save?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Yes)
            {
                var nhanVien = frmMain.Instance.CurrentAccount;
                if (gender1.Checked)
                {
                    nhanVien.GioiTinh = true;
                }
                else
                {
                    nhanVien.GioiTinh = false;
                }
                nhanVien.TenNhanVien = txtName.Text.Trim();
                nhanVien.MatKhau = txtPassword.Text.Trim();
                nhanVien.NamSinh = birthDate.Value;
                if (!await nhanVienRepo.Update(nhanVien))
                {
                    MessageBox.Show("Lỗi truy cập database!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Thay Đổi Thành Công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            if (frmMain.Instance.CurrentAccount == null)
            {
                Close();
            }
            if (frmMain.Instance.CurrentAccount.GioiTinh.Value)
            {
                gender1.Checked = true;
            }
            else
            {
                gender2.Checked = true;
            }
            birthDate.Value = frmMain.Instance.CurrentAccount.NamSinh.Value;
            txtEmail.Text = frmMain.Instance.CurrentAccount.Email;
            txtPassword.Text = frmMain.Instance.CurrentAccount.MatKhau;
            txtName.Text = frmMain.Instance.CurrentAccount.TenNhanVien;
        }

        private void birthDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

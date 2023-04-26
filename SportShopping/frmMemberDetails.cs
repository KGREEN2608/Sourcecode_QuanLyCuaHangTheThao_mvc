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
    public partial class frmMemberDetails : Form
    {
        private readonly bool isUpdate;
        private Form parent;
        private int? id;
        private NhanVien nhanVien;
        private readonly NhanVienRepository nhanVienRepo;
        public frmMemberDetails(bool isUpdate, Form parent, int? id)
        {
            InitializeComponent();
            this.isUpdate = isUpdate;
            this.parent = parent;
            this.id = id;
            nhanVienRepo = new NhanVienRepository();
        }

        private void FillRankCombobox()
        {
            cbRank.Items.Clear();
            cbRank.Items.Add("Chủ Cửa Hàng");
            cbRank.Items.Add("Nhân Viên Thu Ngân");
            cbRank.Items.Add("Nhân Viên Kho");
            cbRank.Items.Add("Nhân Viên Tư Vấn");
            cbRank.SelectedIndex = 0;
        }

        private void ResetField()
        {
            txtEmail.Text = "";
            txtFullName.Text = "";
            txtSalary.Value = 0;
            txtPassword.Text = "";
            birthDate.Value = DateTime.Now;
            cbRank.SelectedIndex = 0;
            male.Checked = false;
            female.Checked = false;
        }

        private async void frmMemberDetails_Load(object sender, EventArgs e)
        {
            FillRankCombobox();
            if (isUpdate)
            {
                Text = "Sửa Thông Tin Nhân Viên";
                txtTitle.Text = "Sửa Thông Tin Nhân Viên";
                addBtn.Text = "Sửa";
                if (id != null)
                {
                    nhanVien = await nhanVienRepo.GetFirst(nv => nv.MaNhanVien == id.Value);
                    if (nhanVien == null)
                    {
                        Close();
                    }
                    else
                    {
                        txtEmail.Text = nhanVien.Email;
                        txtFullName.Text = nhanVien.TenNhanVien;
                        txtSalary.Value = nhanVien.Luong.Value;
                        txtPassword.Text = "***";
                        birthDate.Value = nhanVien.NamSinh.Value;
                        if (nhanVien.GioiTinh.Value)
                        {
                            male.Checked = true;
                        }
                        else
                        {
                            female.Checked = true;
                        }
                        cbRank.SelectedItem = nhanVien.CapBac;
                    }
                }
            }
            else
            {
                Text = "Tạo Nhân Viên Mới";
                txtTitle.Text = "Tạo Nhân Viên Mới";
                addBtn.Text = "Thêm";
            }
        }

        private void frmMemberDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.Instance.openChildForm(new frmMembers());
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CheckInput()
        {
            if (txtFullName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ô Tên Nhân Viên không được để trống!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ô Mật Khẩu không được để trống!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ô Email không được để trống!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!txtEmail.Text.Trim().Contains("@") && txtEmail.Text.Trim().Contains("."))
            {
                MessageBox.Show("Không đúng định dạng email ( phải có @ )!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            if (!male.Checked && !female.Checked)
            {
                MessageBox.Show("Chọn Giới Tính!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!txtPassword.Text.Equals("***") && txtPassword.Text.Trim().Length > 1 && txtPassword.Text.Trim().Length < 6)
            {
                MessageBox.Show("Mật Khẩu ít nhất 6 chữ số!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (birthDate.Value.Date.CompareTo(DateTime.Now.Date) >= 0)
            {
                MessageBox.Show("Ngày Sinh Không Thể Để Thời Gian Ở Tương Lai!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            if (isUpdate)
            {
                if (nhanVien == null)
                {
                    Close();
                }
                bool gender = false;
                if (male.Checked)
                {
                    gender = true;
                }
                nhanVien.Email = txtEmail.Text.Trim();
                nhanVien.GioiTinh = gender;
                nhanVien.CapBac = cbRank.SelectedItem.ToString();
                nhanVien.Luong = (int)txtSalary.Value;
                nhanVien.MatKhau = txtPassword.Text.Trim();
                nhanVien.NamSinh = birthDate.Value.Date;
                nhanVien.TenNhanVien = txtFullName.Text.Trim();
                bool result = await nhanVienRepo.Update(nhanVien);
                if (result)
                {
                    MessageBox.Show("Sửa Thành Công.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                bool gender = false;
                if (male.Checked)
                {
                    gender = true;
                }
                var nhanVienMoi = new NhanVien()
                {
                    Email = txtEmail.Text.Trim(),
                    GioiTinh = gender,
                    CapBac = cbRank.SelectedItem.ToString(),
                    Luong = (int)txtSalary.Value,
                    MatKhau = txtPassword.Text.Trim(),
                    NamSinh = birthDate.Value.Date,
                    TenNhanVien = txtFullName.Text.Trim(),
                };
                NhanVien result = await nhanVienRepo.Add(nhanVienMoi);
                if (result != null)
                {
                    MessageBox.Show("Thêm Thành Công.", "Thông Tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetField();
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại.", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmMemberDetails_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbRank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

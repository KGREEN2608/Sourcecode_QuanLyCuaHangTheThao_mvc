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
    public partial class frmCustomerDetails : Form
    {
        private readonly bool isUpdate;
        private Form parent;
        private int? id;
        private KhachHang khachHang;
        private readonly KhachHangRepository khachHangRepo;
        public frmCustomerDetails(bool isUpdate, Form parent, int? id)
        {
            InitializeComponent();
            this.isUpdate = isUpdate;
            this.parent = parent;
            this.id = id;
            khachHangRepo = new KhachHangRepository();
        }

        private async void frmCustomerDetails_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                Text = "Sửa Thông Tin Khách Hàng";
                txtTitle.Text = "Sửa Thông Tin Khách Hàng";
                addBtn.Text = "Sửa";
                khachHang = await khachHangRepo.GetFirst(nv => nv.MaKhachHang == id.Value);
                if (khachHang == null)
                {
                    Close();
                }
                else
                {
                    txtFullName.Text = khachHang.HoTen;
                    txtPhone.Text = khachHang.Sdt;
                }
            }
            else
            {
                Text = "Tạo thẻ thành viên mới";
                txtTitle.Text = "Tạo thẻ thành viên mới";
                addBtn.Text = "Thêm";
            }
        }

        private void frmCustomerDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain.Instance.openChildForm(new frmCustomer());
        }

        private bool CheckInput()
        {
            if (txtFullName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ô Họ Tên không được để trống!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPhone.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ô Số Điện Thoại không được để trống!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                int.Parse(txtPhone.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ô Số Điện Thoại chỉ được nhập số!", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPhone.Text.Trim().Length < 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (khachHang == null)
                {
                    Close();
                }
                khachHang.HoTen = txtFullName.Text.Trim();
                khachHang.Sdt = txtPhone.Text.Trim();
                bool result = await khachHangRepo.Update(khachHang);
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
                KhachHang result = await khachHangRepo.Add(new KhachHang()
                {
                    HoTen = txtFullName.Text.Trim(),
                    Sdt = txtPhone.Text.Trim(),
                });
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
        private void ResetField()
        {
            txtPhone.Text = "";
            txtFullName.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using BusinessObject.Models;
using DataAccess.Repository;
using DataAccess.Repository.Implements;
using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;

namespace SportShopping
{
    public partial class frmLogin : Form
    {
        Form ChildForm { get; set; }
        NhanVienRepository _nhanVienRepo;
        IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
        public frmLogin()
        {
            InitializeComponent();
            _nhanVienRepo = new NhanVienRepository();
        }
        public void ResetField()
        {
            txtEmail.Text = "";
            txtPassword.Text = "";
        }
        public int checkInput()
        {
            if (txtEmail.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Ô Email không được trống!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            if (txtPassword.Text.Trim().Length <= 0)
            {
                MessageBox.Show("Ô Mật khẩu không được trống!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return 0;
            }
            return 1;
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Bạn có muốn kết thúc chương trình?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) e.Cancel = true;
        }

        private void loginButt_Click(object sender, EventArgs e)
        {
            if (checkInput() == 0) return;
            var email = txtEmail.Text.Trim();
            var password = txtPassword.Text.Trim();
            string adminEmail = config["AdminAccount:Email"];
            string adminPassword = config["AdminAccount:Password"];
            if (email.ToLower().Equals(adminEmail) && password.Equals(adminPassword))
            {
                ResetField();
                this.Visible = false;
                if (ChildForm != null) ChildForm.Close();
                ChildForm = new frmMain(this);
                frmMain.Instance.CurrentAccount = new NhanVien()
                {
                    CapBac = "ADMIN",
                    Email = email,
                    MatKhau = password,
                    Luong = 0,
                    GioiTinh = true,
                    MaNhanVien = -1,
                    NamSinh = DateTime.Now,
                    TenNhanVien = "Admin"
                };
                ChildForm.Show();
                return;
            }
            var nhanVien = _nhanVienRepo.CheckLogin(email, password).Result;
            if (nhanVien == null)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu !!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ResetField();
                this.Visible = false;
                if (ChildForm != null) ChildForm.Close();
                ChildForm = new frmMain(this);
                frmMain.Instance.CurrentAccount = nhanVien;
                ChildForm.Show();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

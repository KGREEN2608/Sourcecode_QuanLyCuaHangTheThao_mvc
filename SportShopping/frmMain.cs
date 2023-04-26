using BusinessObject.Models;
using DataAccess.Repository;
using DataAccess.Repository.Implements;
using System;
using System.Windows.Forms;

namespace SportShopping
{
    public partial class frmMain : Form
    {
        private static frmMain instance;
        public static frmMain Instance { get { return instance; } }
        public NhanVien CurrentAccount;
        Form parent { get; set; }
        public Form activeForm { get; set; }
        NhanVienRepository nhanVienRepo;
        HoaDonRepository hoaDonRepo;
        SanPhamRepository sanPhamRepo;
        public int width = 0;
        public int height = 0;
        public frmMain(Form parent)
        {
            this.parent = parent;
            InitializeComponent();
            width = Size.Width;
            height = Size.Height;
            nhanVienRepo = new NhanVienRepository();
            hoaDonRepo = new HoaDonRepository();
            sanPhamRepo = new SanPhamRepository();
            instance = this;
        }

        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm = null;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(activeForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        public void exit()
        {
            this.Visible = false;
            parent.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (CurrentAccount == null)
            {
                Close();
            }
            string capBac = CurrentAccount.CapBac;
            if (capBac.Equals("ADMIN"))
            {
                cusBtn.Visible = false;
                profileBtn.Visible = false;

            }
            else
            {
                reportBtn.Visible = false;
                staffBtn.Visible = false;
                productBtn.Visible = false;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cart.Instance.Close();
            exit();
        }

        private void memberManage_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            openChildForm(new frmMembers());
        }



        private void productManage_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            openChildForm(new frmProducts());
        }

        private void orderManage_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            openChildForm(new frmOrders());
        }

        private void homeButt_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            openChildForm(new frmReport());
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            Visible = false;
            new frmUser(this).ShowDialog();
        }

        private void cusBtn_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            openChildForm(new frmCustomer());
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            if (activeForm != null) activeForm.Close();
            Cart.Instance.Close();
            Close();
        }
    }
}

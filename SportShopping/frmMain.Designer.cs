
namespace SportShopping
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidePanel = new Panel();
            pictureBox1 = new PictureBox();
            exitBtn = new Button();
            profileBtn = new Button();
            cusBtn = new Button();
            reportBtn = new Button();
            orderBtn = new Button();
            productBtn = new Button();
            staffBtn = new Button();
            headerBar = new Panel();
            panel1 = new Panel();
            splitter1 = new Splitter();
            closeButt = new Button();
            windowButt = new Button();
            minimizeButt = new Button();
            panelChildForm = new Panel();
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            headerBar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.AutoScroll = true;
            sidePanel.BackColor = Color.LightGoldenrodYellow;
            sidePanel.BorderStyle = BorderStyle.FixedSingle;
            sidePanel.Controls.Add(pictureBox1);
            sidePanel.Controls.Add(exitBtn);
            sidePanel.Controls.Add(profileBtn);
            sidePanel.Controls.Add(cusBtn);
            sidePanel.Controls.Add(reportBtn);
            sidePanel.Controls.Add(orderBtn);
            sidePanel.Controls.Add(productBtn);
            sidePanel.Controls.Add(staffBtn);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Margin = new Padding(3, 4, 3, 4);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(244, 844);
            sidePanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightGoldenrodYellow;
            pictureBox1.Location = new Point(-1, 389);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 442);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // exitBtn
            // 
            exitBtn.AllowDrop = true;
            exitBtn.BackColor = Color.Olive;
            exitBtn.Dock = DockStyle.Top;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
            exitBtn.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            exitBtn.ForeColor = SystemColors.ButtonHighlight;
            exitBtn.Location = new Point(0, 318);
            exitBtn.Margin = new Padding(0);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(242, 53);
            exitBtn.TabIndex = 16;
            exitBtn.Text = "Đăng Xuất";
            exitBtn.TextAlign = ContentAlignment.TopLeft;
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // profileBtn
            // 
            profileBtn.AllowDrop = true;
            profileBtn.BackColor = Color.Olive;
            profileBtn.Dock = DockStyle.Top;
            profileBtn.FlatAppearance.BorderSize = 0;
            profileBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
            profileBtn.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            profileBtn.FlatStyle = FlatStyle.Flat;
            profileBtn.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            profileBtn.ForeColor = SystemColors.ButtonHighlight;
            profileBtn.Location = new Point(0, 265);
            profileBtn.Margin = new Padding(0);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(242, 53);
            profileBtn.TabIndex = 15;
            profileBtn.Text = "Thông Tin Cá Nhân";
            profileBtn.TextAlign = ContentAlignment.TopLeft;
            profileBtn.UseVisualStyleBackColor = false;
            profileBtn.Click += profileBtn_Click;
            // 
            // cusBtn
            // 
            cusBtn.AllowDrop = true;
            cusBtn.BackColor = Color.Olive;
            cusBtn.Dock = DockStyle.Top;
            cusBtn.FlatAppearance.BorderSize = 0;
            cusBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
            cusBtn.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            cusBtn.FlatStyle = FlatStyle.Flat;
            cusBtn.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            cusBtn.ForeColor = SystemColors.ButtonHighlight;
            cusBtn.Location = new Point(0, 212);
            cusBtn.Margin = new Padding(0);
            cusBtn.Name = "cusBtn";
            cusBtn.Size = new Size(242, 53);
            cusBtn.TabIndex = 13;
            cusBtn.Text = "Quản Lý Khách Hàng";
            cusBtn.TextAlign = ContentAlignment.TopLeft;
            cusBtn.UseVisualStyleBackColor = false;
            cusBtn.Click += cusBtn_Click;
            // 
            // reportBtn
            // 
            reportBtn.AllowDrop = true;
            reportBtn.BackColor = Color.Olive;
            reportBtn.Dock = DockStyle.Top;
            reportBtn.FlatAppearance.BorderSize = 0;
            reportBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
            reportBtn.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            reportBtn.FlatStyle = FlatStyle.Flat;
            reportBtn.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            reportBtn.ForeColor = Color.White;
            reportBtn.Location = new Point(0, 159);
            reportBtn.Margin = new Padding(0);
            reportBtn.Name = "reportBtn";
            reportBtn.Size = new Size(242, 53);
            reportBtn.TabIndex = 9;
            reportBtn.Text = "Thống kê Doanh Thu";
            reportBtn.TextAlign = ContentAlignment.TopLeft;
            reportBtn.UseVisualStyleBackColor = false;
            reportBtn.Click += reportBtn_Click;
            // 
            // orderBtn
            // 
            orderBtn.AllowDrop = true;
            orderBtn.BackColor = Color.Olive;
            orderBtn.Dock = DockStyle.Top;
            orderBtn.FlatAppearance.BorderSize = 0;
            orderBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
            orderBtn.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            orderBtn.FlatStyle = FlatStyle.Flat;
            orderBtn.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            orderBtn.ForeColor = SystemColors.ButtonHighlight;
            orderBtn.Location = new Point(0, 106);
            orderBtn.Margin = new Padding(0);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(242, 53);
            orderBtn.TabIndex = 8;
            orderBtn.Text = "Quản Lý Hóa Đơn";
            orderBtn.TextAlign = ContentAlignment.TopLeft;
            orderBtn.UseVisualStyleBackColor = false;
            orderBtn.Click += orderManage_Click;
            // 
            // productBtn
            // 
            productBtn.AllowDrop = true;
            productBtn.BackColor = Color.Olive;
            productBtn.Dock = DockStyle.Top;
            productBtn.FlatAppearance.BorderSize = 0;
            productBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
            productBtn.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            productBtn.FlatStyle = FlatStyle.Flat;
            productBtn.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            productBtn.ForeColor = SystemColors.ButtonHighlight;
            productBtn.Location = new Point(0, 53);
            productBtn.Margin = new Padding(0);
            productBtn.Name = "productBtn";
            productBtn.Size = new Size(242, 53);
            productBtn.TabIndex = 7;
            productBtn.Text = "Quản Lý Sản Phẩm";
            productBtn.TextAlign = ContentAlignment.TopLeft;
            productBtn.UseVisualStyleBackColor = false;
            productBtn.Click += productManage_Click;
            // 
            // staffBtn
            // 
            staffBtn.AllowDrop = true;
            staffBtn.BackColor = Color.Olive;
            staffBtn.Dock = DockStyle.Top;
            staffBtn.FlatAppearance.BorderSize = 0;
            staffBtn.FlatAppearance.MouseDownBackColor = Color.Gray;
            staffBtn.FlatAppearance.MouseOverBackColor = Color.LightSteelBlue;
            staffBtn.FlatStyle = FlatStyle.Flat;
            staffBtn.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            staffBtn.ForeColor = SystemColors.ButtonHighlight;
            staffBtn.Location = new Point(0, 0);
            staffBtn.Margin = new Padding(0);
            staffBtn.Name = "staffBtn";
            staffBtn.Size = new Size(242, 53);
            staffBtn.TabIndex = 5;
            staffBtn.Text = "Quản Lý Nhân Viên";
            staffBtn.TextAlign = ContentAlignment.TopLeft;
            staffBtn.UseVisualStyleBackColor = false;
            staffBtn.Click += memberManage_Click;
            // 
            // headerBar
            // 
            headerBar.Controls.Add(panel1);
            headerBar.Controls.Add(closeButt);
            headerBar.Controls.Add(windowButt);
            headerBar.Controls.Add(minimizeButt);
            headerBar.Dock = DockStyle.Top;
            headerBar.Location = new Point(0, 0);
            headerBar.Name = "headerBar";
            headerBar.Size = new Size(907, 28);
            headerBar.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 255);
            panel1.Controls.Add(splitter1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 28);
            panel1.TabIndex = 3;
            // 
            // splitter1
            // 
            splitter1.Cursor = Cursors.SizeWE;
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(2, 28);
            splitter1.TabIndex = 6;
            splitter1.TabStop = false;
            // 
            // closeButt
            // 
            closeButt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            closeButt.BackgroundImageLayout = ImageLayout.Zoom;
            closeButt.FlatAppearance.BorderSize = 0;
            closeButt.FlatStyle = FlatStyle.Flat;
            closeButt.Location = new Point(2285, 3);
            closeButt.Name = "closeButt";
            closeButt.Size = new Size(32, 21);
            closeButt.TabIndex = 2;
            closeButt.UseVisualStyleBackColor = true;
            // 
            // windowButt
            // 
            windowButt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            windowButt.BackgroundImageLayout = ImageLayout.Zoom;
            windowButt.FlatAppearance.BorderSize = 0;
            windowButt.FlatStyle = FlatStyle.Flat;
            windowButt.Location = new Point(2246, 0);
            windowButt.Name = "windowButt";
            windowButt.Size = new Size(39, 24);
            windowButt.TabIndex = 1;
            windowButt.UseVisualStyleBackColor = true;
            // 
            // minimizeButt
            // 
            minimizeButt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minimizeButt.BackgroundImageLayout = ImageLayout.Zoom;
            minimizeButt.FlatAppearance.BorderSize = 0;
            minimizeButt.FlatStyle = FlatStyle.Flat;
            minimizeButt.Location = new Point(2221, 1);
            minimizeButt.Name = "minimizeButt";
            minimizeButt.Size = new Size(22, 23);
            minimizeButt.TabIndex = 0;
            minimizeButt.UseVisualStyleBackColor = true;
            // 
            // panelChildForm
            // 
            panelChildForm.BackgroundImage = Properties.Resources.background;
            panelChildForm.BackgroundImageLayout = ImageLayout.Stretch;
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(244, 0);
            panelChildForm.Margin = new Padding(3, 4, 3, 4);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1337, 844);
            panelChildForm.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1581, 844);
            Controls.Add(panelChildForm);
            Controls.Add(sidePanel);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Cửa Hàng Thể Thao";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            headerBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Splitter spiltterLeft;
        private System.Windows.Forms.Panel headerBar;
        private System.Windows.Forms.Button closeButt;
        private System.Windows.Forms.Button windowButt;
        private System.Windows.Forms.Button minimizeButt;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.Button staffBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button reportBtn;
        private Button cusBtn;
        private Button profileBtn;
        private Button exitBtn;
        private PictureBox pictureBox1;
    }
}


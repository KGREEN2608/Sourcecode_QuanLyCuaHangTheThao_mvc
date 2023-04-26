namespace SportShopping
{
    partial class frmOrderPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderPayment));
            txtTitle = new Label();
            exitBtn = new Button();
            paymentBtn = new Button();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            radioButtonYes = new RadioButton();
            radioButtonNo = new RadioButton();
            cbKhuyenMai = new ComboBox();
            label3 = new Label();
            txtSdt = new TextBox();
            label1 = new Label();
            txtTotalPrice = new NumericUpDown();
            label8 = new Label();
            cbCTTT = new ComboBox();
            label4 = new Label();
            txtTenKhachHang = new TextBox();
            label2 = new Label();
            pictureBox7 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtTotalPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitle.Location = new Point(179, 31);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(205, 46);
            txtTitle.TabIndex = 7;
            txtTitle.Text = "Thanh Toán";
            // 
            // exitBtn
            // 
            exitBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            exitBtn.BackColor = Color.Olive;
            exitBtn.Location = new Point(413, 672);
            exitBtn.Margin = new Padding(3, 4, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(123, 56);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // paymentBtn
            // 
            paymentBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            paymentBtn.BackColor = Color.Olive;
            paymentBtn.Location = new Point(188, 672);
            paymentBtn.Margin = new Padding(3, 4, 3, 4);
            paymentBtn.Name = "paymentBtn";
            paymentBtn.Size = new Size(123, 56);
            paymentBtn.TabIndex = 5;
            paymentBtn.Text = "Đặt Hàng";
            paymentBtn.UseVisualStyleBackColor = false;
            paymentBtn.Click += paymentBtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(radioButtonYes);
            panel1.Controls.Add(radioButtonNo);
            panel1.Controls.Add(cbKhuyenMai);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSdt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtTotalPrice);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cbCTTT);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTenKhachHang);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(58, 119);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(572, 531);
            panel1.TabIndex = 4;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(36, 378);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(51, 50);
            pictureBox6.TabIndex = 32;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(36, 310);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(51, 50);
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(36, 244);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 50);
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(36, 165);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 50);
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 50);
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(36, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 50);
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(130, 388);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 23;
            label5.Text = "In Hóa Đơn";
            // 
            // radioButtonYes
            // 
            radioButtonYes.AutoSize = true;
            radioButtonYes.Location = new Point(307, 437);
            radioButtonYes.Margin = new Padding(3, 4, 3, 4);
            radioButtonYes.Name = "radioButtonYes";
            radioButtonYes.Size = new Size(48, 24);
            radioButtonYes.TabIndex = 22;
            radioButtonYes.TabStop = true;
            radioButtonYes.Text = "Có";
            radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            radioButtonNo.AutoSize = true;
            radioButtonNo.Location = new Point(307, 392);
            radioButtonNo.Margin = new Padding(3, 4, 3, 4);
            radioButtonNo.Name = "radioButtonNo";
            radioButtonNo.Size = new Size(73, 24);
            radioButtonNo.TabIndex = 21;
            radioButtonNo.TabStop = true;
            radioButtonNo.Text = "Không";
            radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // cbKhuyenMai
            // 
            cbKhuyenMai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbKhuyenMai.FormattingEnabled = true;
            cbKhuyenMai.Location = new Point(307, 257);
            cbKhuyenMai.Margin = new Padding(3, 4, 3, 4);
            cbKhuyenMai.Name = "cbKhuyenMai";
            cbKhuyenMai.Size = new Size(236, 28);
            cbKhuyenMai.TabIndex = 20;
            cbKhuyenMai.SelectedIndexChanged += cbKhuyenMai_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(114, 257);
            label3.Name = "label3";
            label3.Size = new Size(125, 28);
            label3.TabIndex = 19;
            label3.Text = "Khuyến Mãi";
            // 
            // txtSdt
            // 
            txtSdt.BackColor = Color.LightGray;
            txtSdt.Location = new Point(306, 102);
            txtSdt.Margin = new Padding(3, 4, 3, 4);
            txtSdt.Name = "txtSdt";
            txtSdt.ReadOnly = true;
            txtSdt.Size = new Size(236, 27);
            txtSdt.TabIndex = 18;
            txtSdt.TextChanged += txtSdt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(109, 98);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 17;
            label1.Text = "Số Điện Thoại";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.BackColor = Color.LightGray;
            txtTotalPrice.Location = new Point(306, 321);
            txtTotalPrice.Margin = new Padding(3, 4, 3, 4);
            txtTotalPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(237, 27);
            txtTotalPrice.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(121, 321);
            label8.Name = "label8";
            label8.Size = new Size(107, 28);
            label8.TabIndex = 15;
            label8.Text = "Tổng Tiền";
            // 
            // cbCTTT
            // 
            cbCTTT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCTTT.FormattingEnabled = true;
            cbCTTT.Location = new Point(307, 187);
            cbCTTT.Margin = new Padding(3, 4, 3, 4);
            cbCTTT.Name = "cbCTTT";
            cbCTTT.Size = new Size(236, 28);
            cbCTTT.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(114, 183);
            label4.Name = "label4";
            label4.Size = new Size(139, 28);
            label4.TabIndex = 7;
            label4.Text = "Phương Thức";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.BackColor = Color.LightGray;
            txtTenKhachHang.Location = new Point(307, 29);
            txtTenKhachHang.Margin = new Padding(3, 4, 3, 4);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.ReadOnly = true;
            txtTenKhachHang.Size = new Size(236, 27);
            txtTenKhachHang.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(109, 29);
            label2.Name = "label2";
            label2.Size = new Size(165, 28);
            label2.TabIndex = 2;
            label2.Text = "Tên Khách Hàng";
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(706, 119);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(517, 531);
            pictureBox7.TabIndex = 9;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // frmOrderPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1274, 753);
            Controls.Add(pictureBox7);
            Controls.Add(txtTitle);
            Controls.Add(exitBtn);
            Controls.Add(paymentBtn);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmOrderPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thanh Toán";
            FormClosing += frmOrderPayment_FormClosing;
            Load += frmOrderPayment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtTotalPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtTitle;
        private Button exitBtn;
        private Button paymentBtn;
        private Panel panel1;
        private NumericUpDown txtTotalPrice;
        private Label label8;
        private ComboBox cbCTTT;
        private Label label4;
        private TextBox txtTenKhachHang;
        private Label label2;
        private TextBox txtSdt;
        private Label label1;
        private Label label3;
        private ComboBox cbKhuyenMai;
        private Label label5;
        private RadioButton radioButtonYes;
        private RadioButton radioButtonNo;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}
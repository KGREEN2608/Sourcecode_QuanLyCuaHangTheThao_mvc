namespace SportShopping
{
    partial class frmProductDetails
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
            txtTitle = new Label();
            exitBtn = new Button();
            addBtn = new Button();
            panel1 = new Panel();
            cbStatus = new ComboBox();
            saveFileBtn = new Button();
            txtPath = new TextBox();
            image = new PictureBox();
            numberPrice = new NumericUpDown();
            txtSize = new TextBox();
            numberAmount = new NumericUpDown();
            cbProductProvider = new ComboBox();
            cbGuarentee = new ComboBox();
            cbProductType = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            txtProductUser = new TextBox();
            label9 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            label8 = new Label();
            txtMaterial = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberAmount).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitle.Location = new Point(378, 29);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(318, 46);
            txtTitle.TabIndex = 7;
            txtTitle.Text = "Tạo Sản Phẩm Mới";
            // 
            // exitBtn
            // 
            exitBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitBtn.BackColor = Color.Olive;
            exitBtn.Location = new Point(899, 703);
            exitBtn.Margin = new Padding(3, 4, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(123, 56);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addBtn.BackColor = Color.Olive;
            addBtn.Location = new Point(723, 703);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(123, 56);
            addBtn.TabIndex = 5;
            addBtn.Text = "Thêm";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(cbStatus);
            panel1.Controls.Add(saveFileBtn);
            panel1.Controls.Add(txtPath);
            panel1.Controls.Add(image);
            panel1.Controls.Add(numberPrice);
            panel1.Controls.Add(txtSize);
            panel1.Controls.Add(numberAmount);
            panel1.Controls.Add(cbProductProvider);
            panel1.Controls.Add(cbGuarentee);
            panel1.Controls.Add(cbProductType);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtProductUser);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtMaterial);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtProductName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(25, 120);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(998, 573);
            panel1.TabIndex = 4;
            // 
            // cbStatus
            // 
            cbStatus.BackColor = Color.LightGray;
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(176, 156);
            cbStatus.Margin = new Padding(3, 4, 3, 4);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(236, 28);
            cbStatus.TabIndex = 39;
            // 
            // saveFileBtn
            // 
            saveFileBtn.BackColor = Color.Olive;
            saveFileBtn.Location = new Point(290, 372);
            saveFileBtn.Margin = new Padding(3, 4, 3, 4);
            saveFileBtn.Name = "saveFileBtn";
            saveFileBtn.Size = new Size(123, 55);
            saveFileBtn.TabIndex = 38;
            saveFileBtn.Text = "Choose";
            saveFileBtn.UseVisualStyleBackColor = false;
            saveFileBtn.Click += saveFileBtn_Click;
            // 
            // txtPath
            // 
            txtPath.BackColor = Color.LightGray;
            txtPath.Location = new Point(176, 325);
            txtPath.Margin = new Padding(3, 4, 3, 4);
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.Size = new Size(236, 27);
            txtPath.TabIndex = 37;
            txtPath.TextChanged += textBox1_TextChanged;
            // 
            // image
            // 
            image.BackgroundImageLayout = ImageLayout.Zoom;
            image.Location = new Point(17, 372);
            image.Margin = new Padding(3, 4, 3, 4);
            image.Name = "image";
            image.Size = new Size(237, 192);
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            image.TabIndex = 36;
            image.TabStop = false;
            // 
            // numberPrice
            // 
            numberPrice.Location = new Point(176, 92);
            numberPrice.Margin = new Padding(3, 4, 3, 4);
            numberPrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numberPrice.Name = "numberPrice";
            numberPrice.Size = new Size(237, 27);
            numberPrice.TabIndex = 35;
            numberPrice.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // txtSize
            // 
            txtSize.BackColor = Color.LightGray;
            txtSize.Location = new Point(176, 265);
            txtSize.Margin = new Padding(3, 4, 3, 4);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(236, 27);
            txtSize.TabIndex = 34;
            // 
            // numberAmount
            // 
            numberAmount.BackColor = Color.LightGray;
            numberAmount.Location = new Point(696, 324);
            numberAmount.Margin = new Padding(3, 4, 3, 4);
            numberAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numberAmount.Name = "numberAmount";
            numberAmount.Size = new Size(237, 27);
            numberAmount.TabIndex = 33;
            numberAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbProductProvider
            // 
            cbProductProvider.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProductProvider.FormattingEnabled = true;
            cbProductProvider.Location = new Point(697, 265);
            cbProductProvider.Margin = new Padding(3, 4, 3, 4);
            cbProductProvider.Name = "cbProductProvider";
            cbProductProvider.Size = new Size(236, 28);
            cbProductProvider.TabIndex = 31;
            // 
            // cbGuarentee
            // 
            cbGuarentee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGuarentee.FormattingEnabled = true;
            cbGuarentee.Location = new Point(697, 213);
            cbGuarentee.Margin = new Padding(3, 4, 3, 4);
            cbGuarentee.Name = "cbGuarentee";
            cbGuarentee.Size = new Size(236, 28);
            cbGuarentee.TabIndex = 30;
            // 
            // cbProductType
            // 
            cbProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProductType.FormattingEnabled = true;
            cbProductType.Location = new Point(697, 156);
            cbProductType.Margin = new Padding(3, 4, 3, 4);
            cbProductType.Name = "cbProductType";
            cbProductType.Size = new Size(236, 28);
            cbProductType.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(491, 323);
            label13.Name = "label13";
            label13.Size = new Size(101, 28);
            label13.TabIndex = 27;
            label13.Text = "Số Lượng";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(491, 269);
            label12.Name = "label12";
            label12.Size = new Size(152, 28);
            label12.TabIndex = 25;
            label12.Text = "Hãng Sản Xuất";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(491, 216);
            label11.Name = "label11";
            label11.Size = new Size(202, 28);
            label11.TabIndex = 23;
            label11.Text = "Thời Gian Bảo Hành";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(491, 152);
            label10.Name = "label10";
            label10.Size = new Size(107, 28);
            label10.TabIndex = 21;
            label10.Text = "Loại Hàng";
            // 
            // txtProductUser
            // 
            txtProductUser.BackColor = Color.LightGray;
            txtProductUser.Location = new Point(697, 95);
            txtProductUser.Margin = new Padding(3, 4, 3, 4);
            txtProductUser.Name = "txtProductUser";
            txtProductUser.Size = new Size(236, 27);
            txtProductUser.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(491, 96);
            label9.Name = "label9";
            label9.Size = new Size(200, 28);
            label9.TabIndex = 19;
            label9.Text = "Đối Tượng Sử Dụng";
            // 
            // txtName
            // 
            txtName.BackColor = Color.LightGray;
            txtName.Location = new Point(697, 29);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 27);
            txtName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(491, 31);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 17;
            label1.Text = "Tên Hàng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(17, 265);
            label8.Name = "label8";
            label8.Size = new Size(50, 28);
            label8.TabIndex = 15;
            label8.Text = "Size";
            // 
            // txtMaterial
            // 
            txtMaterial.BackColor = Color.LightGray;
            txtMaterial.Location = new Point(176, 208);
            txtMaterial.Margin = new Padding(3, 4, 3, 4);
            txtMaterial.Name = "txtMaterial";
            txtMaterial.Size = new Size(236, 27);
            txtMaterial.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 209);
            label7.Name = "label7";
            label7.Size = new Size(100, 28);
            label7.TabIndex = 13;
            label7.Text = "Chất Liệu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(17, 323);
            label6.Name = "label6";
            label6.Size = new Size(101, 28);
            label6.TabIndex = 11;
            label6.Text = "Hình Ảnh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 156);
            label5.Name = "label5";
            label5.Size = new Size(113, 28);
            label5.TabIndex = 9;
            label5.Text = "Tình Trạng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 95);
            label3.Name = "label3";
            label3.Size = new Size(90, 28);
            label3.TabIndex = 6;
            label3.Text = "Giá Tiền";
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.LightGray;
            txtProductName.Location = new Point(176, 28);
            txtProductName.Margin = new Padding(3, 4, 3, 4);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(236, 27);
            txtProductName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 29);
            label2.Name = "label2";
            label2.Size = new Size(144, 28);
            label2.TabIndex = 2;
            label2.Text = "Tên Sản Phẩm";
            // 
            // frmProductDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1057, 768);
            Controls.Add(txtTitle);
            Controls.Add(exitBtn);
            Controls.Add(addBtn);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProductDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmProductDetails";
            FormClosing += frmProductDetails_FormClosing;
            Load += frmProductDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtTitle;
        private Button exitBtn;
        private Button addBtn;
        private Panel panel1;
        private Label label8;
        private TextBox txtMaterial;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox txtProductName;
        private Label label2;
        private ComboBox cbProductProvider;
        private ComboBox cbGuarentee;
        private ComboBox cbProductType;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox txtProductUser;
        private Label label9;
        private TextBox txtName;
        private Label label1;
        private NumericUpDown numberAmount;
        private TextBox txtSize;
        private NumericUpDown numberPrice;
        private PictureBox image;
        private TextBox txtPath;
        private Button saveFileBtn;
        private ComboBox cbStatus;
    }
}
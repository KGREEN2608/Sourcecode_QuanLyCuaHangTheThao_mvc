
namespace SportShopping
{
    partial class frmOrderProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrderProduct));
            gridViewProduct = new DataGridView();
            paymentBtn = new Button();
            orderBtn = new Button();
            gridViewCart = new DataGridView();
            productLabel = new Label();
            orderLabel = new Label();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            backBtn = new Button();
            decreaseItemBtn = new Button();
            txtTotalPrice = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)gridViewProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCart).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gridViewProduct
            // 
            gridViewProduct.AccessibleName = "s";
            gridViewProduct.AllowUserToAddRows = false;
            gridViewProduct.AllowUserToDeleteRows = false;
            gridViewProduct.AllowUserToResizeColumns = false;
            gridViewProduct.AllowUserToResizeRows = false;
            gridViewProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridViewProduct.BackgroundColor = SystemColors.ButtonHighlight;
            gridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewProduct.Location = new Point(32, 101);
            gridViewProduct.Margin = new Padding(3, 4, 3, 4);
            gridViewProduct.MultiSelect = false;
            gridViewProduct.Name = "gridViewProduct";
            gridViewProduct.ReadOnly = true;
            gridViewProduct.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridViewProduct.RowTemplate.Height = 25;
            gridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewProduct.Size = new Size(592, 491);
            gridViewProduct.TabIndex = 55;
            // 
            // paymentBtn
            // 
            paymentBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            paymentBtn.BackColor = Color.Olive;
            paymentBtn.Location = new Point(389, 619);
            paymentBtn.Margin = new Padding(3, 4, 3, 4);
            paymentBtn.Name = "paymentBtn";
            paymentBtn.Size = new Size(251, 65);
            paymentBtn.TabIndex = 82;
            paymentBtn.Text = "Thanh Toán";
            paymentBtn.UseVisualStyleBackColor = false;
            paymentBtn.Click += orderButt_Click;
            // 
            // orderBtn
            // 
            orderBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            orderBtn.BackColor = Color.Olive;
            orderBtn.Location = new Point(373, 619);
            orderBtn.Margin = new Padding(3, 4, 3, 4);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(251, 65);
            orderBtn.TabIndex = 81;
            orderBtn.Text = "Thêm vào giỏ";
            orderBtn.UseVisualStyleBackColor = false;
            orderBtn.Click += addProduct_Click;
            // 
            // gridViewCart
            // 
            gridViewCart.AccessibleName = "";
            gridViewCart.AllowUserToAddRows = false;
            gridViewCart.AllowUserToDeleteRows = false;
            gridViewCart.AllowUserToResizeColumns = false;
            gridViewCart.AllowUserToResizeRows = false;
            gridViewCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridViewCart.BackgroundColor = SystemColors.ButtonHighlight;
            gridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridViewCart.Location = new Point(48, 101);
            gridViewCart.Margin = new Padding(3, 4, 3, 4);
            gridViewCart.MultiSelect = false;
            gridViewCart.Name = "gridViewCart";
            gridViewCart.ReadOnly = true;
            gridViewCart.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridViewCart.RowTemplate.Height = 25;
            gridViewCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridViewCart.Size = new Size(592, 340);
            gridViewCart.TabIndex = 57;
            gridViewCart.CellContentClick += gridViewOrderDetail_CellContentClick;
            gridViewCart.CellEnter += gridViewOrderDetail_CellEnter;
            // 
            // productLabel
            // 
            productLabel.AutoSize = true;
            productLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            productLabel.Location = new Point(32, 23);
            productLabel.Name = "productLabel";
            productLabel.Size = new Size(150, 37);
            productLabel.TabIndex = 0;
            productLabel.Text = "Sản Phẩm ";
            // 
            // orderLabel
            // 
            orderLabel.AutoSize = true;
            orderLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            orderLabel.Location = new Point(48, 23);
            orderLabel.Name = "orderLabel";
            orderLabel.Size = new Size(137, 37);
            orderLabel.TabIndex = 82;
            orderLabel.Text = "Giỏ Hàng";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(productLabel);
            panel2.Controls.Add(orderBtn);
            panel2.Controls.Add(gridViewProduct);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(657, 704);
            panel2.TabIndex = 83;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(188, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(62, 62);
            pictureBox3.TabIndex = 90;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(backBtn);
            panel1.Controls.Add(decreaseItemBtn);
            panel1.Controls.Add(txtTotalPrice);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(paymentBtn);
            panel1.Controls.Add(orderLabel);
            panel1.Controls.Add(gridViewCart);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(657, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 704);
            panel1.TabIndex = 89;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(191, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 62);
            pictureBox1.TabIndex = 91;
            pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backBtn.BackColor = Color.Olive;
            backBtn.Location = new Point(130, 619);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(251, 65);
            backBtn.TabIndex = 92;
            backBtn.Text = "Trở Lại";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click_1;
            // 
            // decreaseItemBtn
            // 
            decreaseItemBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            decreaseItemBtn.BackColor = Color.Olive;
            decreaseItemBtn.Location = new Point(352, 23);
            decreaseItemBtn.Margin = new Padding(3, 4, 3, 4);
            decreaseItemBtn.Name = "decreaseItemBtn";
            decreaseItemBtn.Size = new Size(141, 51);
            decreaseItemBtn.TabIndex = 91;
            decreaseItemBtn.Text = "Giảm 1 Sản Phảm";
            decreaseItemBtn.UseVisualStyleBackColor = false;
            decreaseItemBtn.Click += backBtn_Click;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTotalPrice.AutoSize = true;
            txtTotalPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalPrice.Location = new Point(115, 481);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(159, 37);
            txtTotalPrice.TabIndex = 90;
            txtTotalPrice.Text = "Tổng Tiền: ";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Olive;
            button1.Location = new Point(499, 23);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(141, 51);
            button1.TabIndex = 89;
            button1.Text = "Xóa Khỏi Giỏ Hàng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmOrderProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 704);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOrderProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt Hàng";
            FormClosing += frmOrderProduct_FormClosing;
            Load += frmOrderProduct_Load;
            ((System.ComponentModel.ISupportInitialize)gridViewProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCart).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView gridViewProduct;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.DataGridView gridViewCart;
        private System.Windows.Forms.Button paymentBtn;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label orderLabel;
        private Panel panel2;
        private Panel panel1;
        private Button button1;
        private Label txtTotalPrice;
        private Button decreaseItemBtn;
        private Button backBtn;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
    }
}
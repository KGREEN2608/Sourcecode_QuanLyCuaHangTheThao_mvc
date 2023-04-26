namespace SportShopping
{
    partial class frmCustomerDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerDetails));
            exitBtn = new Button();
            addBtn = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtPhone = new TextBox();
            label7 = new Label();
            txtFullName = new TextBox();
            label5 = new Label();
            txtTitle = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            exitBtn.BackColor = Color.Olive;
            exitBtn.Location = new Point(365, 745);
            exitBtn.Margin = new Padding(3, 4, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(227, 70);
            exitBtn.TabIndex = 6;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addBtn.BackColor = Color.Olive;
            addBtn.Location = new Point(78, 745);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(220, 70);
            addBtn.TabIndex = 5;
            addBtn.Text = "Thêm";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(28, 118);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 599);
            panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(7, 122);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 63);
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 63);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.LightGray;
            txtPhone.Location = new Point(246, 142);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(236, 27);
            txtPhone.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(85, 142);
            label7.Name = "label7";
            label7.Size = new Size(144, 28);
            label7.TabIndex = 13;
            label7.Text = "Số Điện Thoại";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.LightGray;
            txtFullName.Location = new Point(246, 56);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(236, 27);
            txtFullName.TabIndex = 10;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(85, 52);
            label5.Name = "label5";
            label5.Size = new Size(78, 28);
            label5.TabIndex = 9;
            label5.Text = "Họ Tên";
            // 
            // txtTitle
            // 
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitle.Location = new Point(98, 44);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(387, 46);
            txtTitle.TabIndex = 7;
            txtTitle.Text = "Tạo thẻ thành viên mới";
            txtTitle.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(650, 118);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(517, 599);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // frmCustomerDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1221, 862);
            Controls.Add(pictureBox3);
            Controls.Add(txtTitle);
            Controls.Add(exitBtn);
            Controls.Add(addBtn);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCustomerDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCustomerDetails";
            FormClosing += frmCustomerDetails_FormClosing;
            Load += frmCustomerDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button exitBtn;
        private Button addBtn;
        private Panel panel1;
        private TextBox txtPhone;
        private Label label7;
        private TextBox txtFullName;
        private Label label5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label txtTitle;
        private PictureBox pictureBox3;
    }
}
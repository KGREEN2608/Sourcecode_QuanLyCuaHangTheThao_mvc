
namespace SportShopping
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label3 = new Label();
            loginButt = new Button();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(141, 38);
            label3.Name = "label3";
            label3.Size = new Size(476, 31);
            label3.TabIndex = 5;
            label3.Text = "Hệ Thống Quản lý Cửa Hàng Thể Thao";
            // 
            // loginButt
            // 
            loginButt.BackColor = Color.Olive;
            loginButt.Location = new Point(319, 272);
            loginButt.Margin = new Padding(3, 4, 3, 4);
            loginButt.Name = "loginButt";
            loginButt.Size = new Size(185, 56);
            loginButt.TabIndex = 9;
            loginButt.Text = "Đăng Nhập";
            loginButt.UseVisualStyleBackColor = false;
            loginButt.Click += loginButt_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLight;
            txtEmail.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(319, 126);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 26);
            txtEmail.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Gainsboro;
            txtPassword.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(319, 209);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "******";
            txtPassword.Size = new Size(248, 26);
            txtPassword.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(203, 212);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 10;
            label2.Text = "Mật Khẩu";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(203, 129);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 6;
            label1.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(119, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 52);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(119, 195);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 52);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(720, 389);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(loginButt);
            Controls.Add(txtEmail);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Quản lý Cửa Hàng Thể Thao";
            FormClosing += frmLogin_FormClosing;
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginButt;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}


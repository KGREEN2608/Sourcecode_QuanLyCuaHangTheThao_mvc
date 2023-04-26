
namespace SportShopping
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            saveButt = new Button();
            button1 = new Button();
            label7 = new Label();
            gender1 = new RadioButton();
            gender2 = new RadioButton();
            birthDate = new DateTimePicker();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.LightGray;
            txtPassword.Location = new Point(216, 332);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(270, 27);
            txtPassword.TabIndex = 51;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LightGray;
            txtEmail.Location = new Point(216, 260);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(270, 27);
            txtEmail.TabIndex = 50;
            // 
            // txtName
            // 
            txtName.BackColor = Color.LightGray;
            txtName.Location = new Point(216, 117);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(270, 27);
            txtName.TabIndex = 49;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(61, 397);
            label6.Name = "label6";
            label6.Size = new Size(91, 22);
            label6.TabIndex = 47;
            label6.Text = "Ngày Sinh";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(61, 332);
            label4.Name = "label4";
            label4.Size = new Size(87, 22);
            label4.TabIndex = 45;
            label4.Text = "Mật Khẩu";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(61, 260);
            label3.Name = "label3";
            label3.Size = new Size(57, 22);
            label3.TabIndex = 44;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(61, 119);
            label2.Name = "label2";
            label2.Size = new Size(127, 22);
            label2.TabIndex = 43;
            label2.Text = "Tên Nhân Viên";
            // 
            // saveButt
            // 
            saveButt.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            saveButt.BackColor = Color.Olive;
            saveButt.Location = new Point(131, 469);
            saveButt.Margin = new Padding(3, 4, 3, 4);
            saveButt.Name = "saveButt";
            saveButt.Size = new Size(156, 57);
            saveButt.TabIndex = 54;
            saveButt.Text = "Thay Đổi";
            saveButt.UseVisualStyleBackColor = false;
            saveButt.Click += saveButt_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Olive;
            button1.Location = new Point(336, 469);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(167, 57);
            button1.TabIndex = 55;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(60, 191);
            label7.Name = "label7";
            label7.Size = new Size(88, 22);
            label7.TabIndex = 56;
            label7.Text = "Giới Tính";
            label7.Click += label7_Click;
            // 
            // gender1
            // 
            gender1.AutoSize = true;
            gender1.Location = new Point(216, 189);
            gender1.Margin = new Padding(3, 4, 3, 4);
            gender1.Name = "gender1";
            gender1.Size = new Size(62, 24);
            gender1.TabIndex = 57;
            gender1.TabStop = true;
            gender1.Text = "Nam";
            gender1.UseVisualStyleBackColor = true;
            // 
            // gender2
            // 
            gender2.AutoSize = true;
            gender2.Location = new Point(309, 189);
            gender2.Margin = new Padding(3, 4, 3, 4);
            gender2.Name = "gender2";
            gender2.Size = new Size(50, 24);
            gender2.TabIndex = 58;
            gender2.TabStop = true;
            gender2.Text = "Nữ";
            gender2.UseVisualStyleBackColor = true;
            gender2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // birthDate
            // 
            birthDate.Location = new Point(216, 397);
            birthDate.Margin = new Padding(3, 4, 3, 4);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(270, 27);
            birthDate.TabIndex = 59;
            birthDate.ValueChanged += birthDate_ValueChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 91);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 50);
            pictureBox3.TabIndex = 60;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 163);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 50);
            pictureBox2.TabIndex = 61;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(4, 232);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 50);
            pictureBox4.TabIndex = 62;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(4, 304);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(51, 50);
            pictureBox5.TabIndex = 63;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(4, 374);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(51, 50);
            pictureBox6.TabIndex = 64;
            pictureBox6.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(83, 31);
            label1.Name = "label1";
            label1.Size = new Size(363, 43);
            label1.TabIndex = 65;
            label1.Text = "Thông tin cá nhân";
            // 
            // frmUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(541, 557);
            Controls.Add(label1);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(birthDate);
            Controls.Add(gender2);
            Controls.Add(gender1);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(saveButt);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông Tin Cá Nhân";
            FormClosing += frmUser_FormClosing;
            Load += frmUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveButt;
        private System.Windows.Forms.Button button1;
        private Label label7;
        private RadioButton gender1;
        private RadioButton gender2;
        private DateTimePicker birthDate;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label1;
    }
}
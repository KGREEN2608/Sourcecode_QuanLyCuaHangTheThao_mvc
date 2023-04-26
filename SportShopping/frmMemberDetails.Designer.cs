namespace SportShopping
{
    partial class frmMemberDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemberDetails));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            txtSalary = new NumericUpDown();
            label8 = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
            birthDate = new DateTimePicker();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            cbRank = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            female = new RadioButton();
            male = new RadioButton();
            txtFullName = new TextBox();
            label2 = new Label();
            addBtn = new Button();
            exitBtn = new Button();
            txtTitle = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSalary).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(txtSalary);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(birthDate);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cbRank);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(female);
            panel1.Controls.Add(male);
            panel1.Controls.Add(txtFullName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(14, 124);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 581);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(16, 19);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(51, 50);
            pictureBox3.TabIndex = 26;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(16, 91);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 50);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 147);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 50);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(16, 401);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(51, 50);
            pictureBox7.TabIndex = 23;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(16, 334);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(51, 50);
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(16, 268);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(51, 50);
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 203);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(51, 50);
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // txtSalary
            // 
            txtSalary.BackColor = Color.LightGray;
            txtSalary.Location = new Point(276, 415);
            txtSalary.Margin = new Padding(3, 4, 3, 4);
            txtSalary.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(237, 27);
            txtSalary.TabIndex = 16;
            txtSalary.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(96, 410);
            label8.Name = "label8";
            label8.Size = new Size(72, 28);
            label8.TabIndex = 15;
            label8.Text = "Lương";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.LightGray;
            txtPassword.Location = new Point(277, 281);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(236, 27);
            txtPassword.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(96, 281);
            label7.Name = "label7";
            label7.Size = new Size(104, 28);
            label7.TabIndex = 13;
            label7.Text = "Mật Khẩu";
            // 
            // birthDate
            // 
            birthDate.CalendarMonthBackground = Color.LightGray;
            birthDate.Format = DateTimePickerFormat.Short;
            birthDate.Location = new Point(277, 343);
            birthDate.Margin = new Padding(3, 4, 3, 4);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(236, 27);
            birthDate.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(96, 343);
            label6.Name = "label6";
            label6.Size = new Size(109, 28);
            label6.TabIndex = 11;
            label6.Text = "Ngày Sinh";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LightGray;
            txtEmail.Location = new Point(277, 216);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(236, 27);
            txtEmail.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(96, 212);
            label5.Name = "label5";
            label5.Size = new Size(64, 28);
            label5.TabIndex = 9;
            label5.Text = "Email";
            // 
            // cbRank
            // 
            cbRank.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRank.FormattingEnabled = true;
            cbRank.Location = new Point(277, 149);
            cbRank.Margin = new Padding(3, 4, 3, 4);
            cbRank.Name = "cbRank";
            cbRank.Size = new Size(236, 28);
            cbRank.TabIndex = 8;
            cbRank.SelectedIndexChanged += cbRank_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(96, 149);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 7;
            label4.Text = "Cấp Bậc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(96, 95);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 6;
            label3.Text = "Giới Tính";
            // 
            // female
            // 
            female.AutoSize = true;
            female.Location = new Point(370, 95);
            female.Margin = new Padding(3, 4, 3, 4);
            female.Name = "female";
            female.Size = new Size(50, 24);
            female.TabIndex = 5;
            female.TabStop = true;
            female.Text = "Nữ";
            female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            male.AutoSize = true;
            male.Location = new Point(277, 95);
            male.Margin = new Padding(3, 4, 3, 4);
            male.Name = "male";
            male.Size = new Size(62, 24);
            male.TabIndex = 4;
            male.TabStop = true;
            male.Text = "Nam";
            male.UseVisualStyleBackColor = true;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.LightGray;
            txtFullName.Location = new Point(277, 33);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(236, 27);
            txtFullName.TabIndex = 3;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(96, 29);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 2;
            label2.Text = "Tên Nhân Viên";
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addBtn.BackColor = Color.Olive;
            addBtn.Location = new Point(186, 723);
            addBtn.Margin = new Padding(3, 4, 3, 4);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(153, 56);
            addBtn.TabIndex = 1;
            addBtn.Text = "Thêm";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            exitBtn.BackColor = Color.Olive;
            exitBtn.Location = new Point(378, 723);
            exitBtn.Margin = new Padding(3, 4, 3, 4);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(149, 56);
            exitBtn.TabIndex = 2;
            exitBtn.Text = "Thoát";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.AutoSize = true;
            txtTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitle.Location = new Point(186, 43);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(328, 46);
            txtTitle.TabIndex = 3;
            txtTitle.Text = "Tạo Nhân Viên Mới";
            // 
            // frmMemberDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(711, 857);
            Controls.Add(txtTitle);
            Controls.Add(exitBtn);
            Controls.Add(addBtn);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMemberDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo Nhân Viên mới";
            FormClosing += frmMemberDetails_FormClosing;
            FormClosed += frmMemberDetails_FormClosed;
            Load += frmMemberDetails_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSalary).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox cbRank;
        private Label label4;
        private Label label3;
        private RadioButton female;
        private RadioButton male;
        private TextBox txtFullName;
        private Label label2;
        private Button addBtn;
        private Button exitBtn;
        private NumericUpDown txtSalary;
        private Label label8;
        private TextBox txtPassword;
        private Label label7;
        private DateTimePicker birthDate;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private Label txtTitle;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
    }
}
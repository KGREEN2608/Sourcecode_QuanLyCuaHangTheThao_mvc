namespace SportShopping
{
    partial class frmCustomer
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
            boxKeySearch = new ComboBox();
            searchBox = new TextBox();
            searchButt = new Button();
            exitButt = new Button();
            delButt = new Button();
            editButt = new Button();
            addButt = new Button();
            label8 = new Label();
            gridView = new DataGridView();
            orderBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // boxKeySearch
            // 
            boxKeySearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            boxKeySearch.DropDownStyle = ComboBoxStyle.DropDownList;
            boxKeySearch.FormattingEnabled = true;
            boxKeySearch.Location = new Point(1102, 36);
            boxKeySearch.Margin = new Padding(3, 4, 3, 4);
            boxKeySearch.Name = "boxKeySearch";
            boxKeySearch.Size = new Size(189, 28);
            boxKeySearch.TabIndex = 86;
            boxKeySearch.SelectedIndexChanged += boxKeySearch_SelectedIndexChanged;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            searchBox.BackColor = Color.LightGray;
            searchBox.Location = new Point(1129, 85);
            searchBox.Margin = new Padding(3, 4, 3, 4);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search Field";
            searchBox.Size = new Size(162, 27);
            searchBox.TabIndex = 85;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // searchButt
            // 
            searchButt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            searchButt.BackColor = Color.Olive;
            searchButt.Location = new Point(1158, 145);
            searchButt.Margin = new Padding(3, 4, 3, 4);
            searchButt.Name = "searchButt";
            searchButt.Size = new Size(102, 51);
            searchButt.TabIndex = 84;
            searchButt.Text = "Search";
            searchButt.UseVisualStyleBackColor = false;
            searchButt.Click += searchButt_Click;
            // 
            // exitButt
            // 
            exitButt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            exitButt.BackColor = Color.Olive;
            exitButt.Location = new Point(1158, 606);
            exitButt.Margin = new Padding(3, 4, 3, 4);
            exitButt.Name = "exitButt";
            exitButt.Size = new Size(102, 51);
            exitButt.TabIndex = 83;
            exitButt.Text = "Thoát";
            exitButt.UseVisualStyleBackColor = false;
            exitButt.Click += exitButt_Click;
            // 
            // delButt
            // 
            delButt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            delButt.BackColor = Color.Olive;
            delButt.Location = new Point(1158, 509);
            delButt.Margin = new Padding(3, 4, 3, 4);
            delButt.Name = "delButt";
            delButt.Size = new Size(102, 51);
            delButt.TabIndex = 82;
            delButt.Text = "Xóa";
            delButt.UseVisualStyleBackColor = false;
            delButt.Click += delButt_Click;
            // 
            // editButt
            // 
            editButt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            editButt.BackColor = Color.Olive;
            editButt.Location = new Point(1158, 413);
            editButt.Margin = new Padding(3, 4, 3, 4);
            editButt.Name = "editButt";
            editButt.Size = new Size(102, 51);
            editButt.TabIndex = 81;
            editButt.Text = "Sửa";
            editButt.UseVisualStyleBackColor = false;
            editButt.Click += editButt_Click;
            // 
            // addButt
            // 
            addButt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            addButt.BackColor = Color.Olive;
            addButt.Location = new Point(1158, 323);
            addButt.Margin = new Padding(3, 4, 3, 4);
            addButt.Name = "addButt";
            addButt.Size = new Size(102, 51);
            addButt.TabIndex = 80;
            addButt.Text = "Thêm";
            addButt.UseVisualStyleBackColor = false;
            addButt.Click += addButt_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(462, 12);
            label8.Name = "label8";
            label8.Size = new Size(296, 35);
            label8.TabIndex = 79;
            label8.Text = "Quản Lý Khách Hàng";
            // 
            // gridView
            // 
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.AllowUserToResizeColumns = false;
            gridView.AllowUserToResizeRows = false;
            gridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridView.BackgroundColor = SystemColors.ButtonHighlight;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Location = new Point(17, 85);
            gridView.Margin = new Padding(3, 4, 3, 4);
            gridView.MultiSelect = false;
            gridView.Name = "gridView";
            gridView.ReadOnly = true;
            gridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridView.RowTemplate.Height = 25;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView.Size = new Size(1091, 729);
            gridView.TabIndex = 78;
            // 
            // orderBtn
            // 
            orderBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            orderBtn.BackColor = Color.Olive;
            orderBtn.Location = new Point(1158, 231);
            orderBtn.Margin = new Padding(3, 4, 3, 4);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(102, 51);
            orderBtn.TabIndex = 87;
            orderBtn.Text = "Đặt Hàng";
            orderBtn.UseVisualStyleBackColor = false;
            orderBtn.Click += button1_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(1303, 828);
            Controls.Add(orderBtn);
            Controls.Add(boxKeySearch);
            Controls.Add(searchBox);
            Controls.Add(searchButt);
            Controls.Add(exitButt);
            Controls.Add(delButt);
            Controls.Add(editButt);
            Controls.Add(addButt);
            Controls.Add(label8);
            Controls.Add(gridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCustomer";
            Load += frmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox boxKeySearch;
        private TextBox searchBox;
        private Button searchButt;
        private Button exitButt;
        private Button delButt;
        private Button editButt;
        private Button addButt;
        private Label label8;
        private DataGridView gridView;
        private Button orderBtn;
    }
}
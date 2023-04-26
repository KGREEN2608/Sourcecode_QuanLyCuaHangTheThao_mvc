
namespace SportShopping
{
    partial class frmMembers
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
            gridView = new DataGridView();
            exitButt = new Button();
            delButt = new Button();
            editButt = new Button();
            addButt = new Button();
            label8 = new Label();
            boxKeySearch = new ComboBox();
            searchBox = new TextBox();
            searchButt = new Button();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
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
            gridView.Location = new Point(14, 85);
            gridView.Margin = new Padding(3, 4, 3, 4);
            gridView.MultiSelect = false;
            gridView.Name = "gridView";
            gridView.ReadOnly = true;
            gridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            gridView.RowTemplate.Height = 25;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView.Size = new Size(1091, 729);
            gridView.TabIndex = 0;
            // 
            // exitButt
            // 
            exitButt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            exitButt.BackColor = Color.Olive;
            exitButt.Location = new Point(1154, 567);
            exitButt.Margin = new Padding(3, 4, 3, 4);
            exitButt.Name = "exitButt";
            exitButt.Size = new Size(102, 51);
            exitButt.TabIndex = 48;
            exitButt.Text = "Thoát";
            exitButt.UseVisualStyleBackColor = false;
            exitButt.Click += exitButt_Click;
            // 
            // delButt
            // 
            delButt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            delButt.BackColor = Color.Olive;
            delButt.Location = new Point(1154, 456);
            delButt.Margin = new Padding(3, 4, 3, 4);
            delButt.Name = "delButt";
            delButt.Size = new Size(102, 51);
            delButt.TabIndex = 47;
            delButt.Text = "Xóa";
            delButt.UseVisualStyleBackColor = false;
            delButt.Click += delButt_Click;
            // 
            // editButt
            // 
            editButt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            editButt.BackColor = Color.Olive;
            editButt.Location = new Point(1154, 348);
            editButt.Margin = new Padding(3, 4, 3, 4);
            editButt.Name = "editButt";
            editButt.Size = new Size(102, 51);
            editButt.TabIndex = 45;
            editButt.Text = "Sửa";
            editButt.UseVisualStyleBackColor = false;
            editButt.Click += editButt_Click;
            // 
            // addButt
            // 
            addButt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            addButt.BackColor = Color.Olive;
            addButt.Location = new Point(1154, 237);
            addButt.Margin = new Padding(3, 4, 3, 4);
            addButt.Name = "addButt";
            addButt.Size = new Size(102, 51);
            addButt.TabIndex = 44;
            addButt.Text = "Thêm";
            addButt.UseVisualStyleBackColor = false;
            addButt.Click += addButt_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(458, 12);
            label8.Name = "label8";
            label8.Size = new Size(268, 35);
            label8.TabIndex = 35;
            label8.Text = "Quản Lý Nhân Viên";
            label8.Click += label8_Click;
            // 
            // boxKeySearch
            // 
            boxKeySearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            boxKeySearch.DropDownStyle = ComboBoxStyle.DropDownList;
            boxKeySearch.FormattingEnabled = true;
            boxKeySearch.Location = new Point(1133, 115);
            boxKeySearch.Margin = new Padding(3, 4, 3, 4);
            boxKeySearch.Name = "boxKeySearch";
            boxKeySearch.Size = new Size(150, 28);
            boxKeySearch.TabIndex = 77;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            searchBox.BackColor = Color.LightGray;
            searchBox.Location = new Point(1133, 153);
            searchBox.Margin = new Padding(3, 4, 3, 4);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search Field";
            searchBox.Size = new Size(150, 27);
            searchBox.TabIndex = 76;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // searchButt
            // 
            searchButt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            searchButt.BackColor = Color.Olive;
            searchButt.Location = new Point(1154, 56);
            searchButt.Margin = new Padding(3, 4, 3, 4);
            searchButt.Name = "searchButt";
            searchButt.Size = new Size(102, 51);
            searchButt.TabIndex = 75;
            searchButt.Text = "Search";
            searchButt.UseVisualStyleBackColor = false;
            searchButt.Click += searchButt_Click;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(1298, 840);
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
            MaximizeBox = false;
            Name = "frmMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhân Viên";
            Load += frmMembers_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button exitButt;
        private System.Windows.Forms.Button delButt;
        private System.Windows.Forms.Button editButt;
        private System.Windows.Forms.Button addButt;
        private System.Windows.Forms.Label label8;
        private ComboBox boxKeySearch;
        private TextBox searchBox;
        private Button searchButt;
    }
}


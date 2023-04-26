
namespace SportShopping
{
    partial class frmProducts
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
            boxKeySearch = new ComboBox();
            searchBox = new TextBox();
            searchButt = new Button();
            exitButt = new Button();
            delButt = new Button();
            editButt = new Button();
            addButt = new Button();
            label8 = new Label();
            gridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // boxKeySearch
            // 
            boxKeySearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            boxKeySearch.DropDownStyle = ComboBoxStyle.DropDownList;
            boxKeySearch.FormattingEnabled = true;
            boxKeySearch.Location = new Point(1114, 107);
            boxKeySearch.Margin = new Padding(3, 4, 3, 4);
            boxKeySearch.Name = "boxKeySearch";
            boxKeySearch.Size = new Size(165, 28);
            boxKeySearch.TabIndex = 74;
            boxKeySearch.SelectedIndexChanged += boxKeySearch_SelectedIndexChanged;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            searchBox.BackColor = Color.LightGray;
            searchBox.Location = new Point(1114, 143);
            searchBox.Margin = new Padding(3, 4, 3, 4);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search Field";
            searchBox.Size = new Size(165, 27);
            searchBox.TabIndex = 73;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // searchButt
            // 
            searchButt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButt.BackColor = Color.Olive;
            searchButt.Location = new Point(1146, 48);
            searchButt.Margin = new Padding(3, 4, 3, 4);
            searchButt.Name = "searchButt";
            searchButt.Size = new Size(102, 51);
            searchButt.TabIndex = 72;
            searchButt.Text = "Search";
            searchButt.UseVisualStyleBackColor = false;
            searchButt.Click += searchButt_Click;
            // 
            // exitButt
            // 
            exitButt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            exitButt.BackColor = Color.Olive;
            exitButt.Location = new Point(1146, 552);
            exitButt.Margin = new Padding(3, 4, 3, 4);
            exitButt.Name = "exitButt";
            exitButt.Size = new Size(102, 51);
            exitButt.TabIndex = 71;
            exitButt.Text = "Thoát";
            exitButt.UseVisualStyleBackColor = false;
            exitButt.Click += exitButt_Click;
            // 
            // delButt
            // 
            delButt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            delButt.BackColor = Color.Olive;
            delButt.Location = new Point(1146, 437);
            delButt.Margin = new Padding(3, 4, 3, 4);
            delButt.Name = "delButt";
            delButt.Size = new Size(102, 51);
            delButt.TabIndex = 70;
            delButt.Text = "Xóa";
            delButt.UseVisualStyleBackColor = false;
            delButt.Click += delButt_Click;
            // 
            // editButt
            // 
            editButt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            editButt.BackColor = Color.Olive;
            editButt.Location = new Point(1146, 323);
            editButt.Margin = new Padding(3, 4, 3, 4);
            editButt.Name = "editButt";
            editButt.Size = new Size(102, 51);
            editButt.TabIndex = 68;
            editButt.Text = "Xem/Sửa";
            editButt.UseVisualStyleBackColor = false;
            editButt.Click += editButt_Click;
            // 
            // addButt
            // 
            addButt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            addButt.BackColor = Color.Olive;
            addButt.Location = new Point(1146, 217);
            addButt.Margin = new Padding(3, 4, 3, 4);
            addButt.Name = "addButt";
            addButt.Size = new Size(102, 51);
            addButt.TabIndex = 67;
            addButt.Text = "Thêm";
            addButt.UseVisualStyleBackColor = false;
            addButt.Click += addButt_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(439, 12);
            label8.Name = "label8";
            label8.Size = new Size(263, 35);
            label8.TabIndex = 60;
            label8.Text = "Quản Lý Sản Phẩm";
            // 
            // gridView
            // 
            gridView.AllowUserToAddRows = false;
            gridView.AllowUserToDeleteRows = false;
            gridView.AllowUserToResizeColumns = false;
            gridView.AllowUserToResizeRows = false;
            gridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridView.BackgroundColor = SystemColors.ButtonHighlight;
            gridView.ColumnHeadersHeight = 29;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridView.Location = new Point(17, 85);
            gridView.Margin = new Padding(3, 4, 3, 4);
            gridView.MultiSelect = false;
            gridView.Name = "gridView";
            gridView.ReadOnly = true;
            gridView.RowHeadersWidth = 51;
            gridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridView.RowTemplate.Height = 25;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView.Size = new Size(1091, 732);
            gridView.TabIndex = 53;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1291, 833);
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
            Name = "frmProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sản Phẩm";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox boxKeySearch;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButt;
        private System.Windows.Forms.Button exitButt;
        private System.Windows.Forms.Button delButt;
        private System.Windows.Forms.Button editButt;
        private System.Windows.Forms.Button addButt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gridView;
    }
}


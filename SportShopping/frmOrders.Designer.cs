
namespace SportShopping
{
    partial class frmOrders
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
            exitButt = new Button();
            delButt = new Button();
            label8 = new Label();
            gridView = new DataGridView();
            detailsBtn = new Button();
            boxKeySearch = new ComboBox();
            searchBox = new TextBox();
            searchButt = new Button();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // exitButt
            // 
            exitButt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            exitButt.BackColor = Color.Olive;
            exitButt.Location = new Point(1144, 395);
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
            delButt.Location = new Point(1144, 295);
            delButt.Margin = new Padding(3, 4, 3, 4);
            delButt.Name = "delButt";
            delButt.Size = new Size(102, 51);
            delButt.TabIndex = 70;
            delButt.Text = "Xóa";
            delButt.UseVisualStyleBackColor = false;
            delButt.Click += delButt_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(464, 12);
            label8.Name = "label8";
            label8.Size = new Size(267, 35);
            label8.TabIndex = 60;
            label8.Text = "Quản Lý Đơn Hàng";
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
            gridView.ColumnHeadersHeight = 29;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridView.Location = new Point(5, 77);
            gridView.Margin = new Padding(3, 4, 3, 4);
            gridView.MultiSelect = false;
            gridView.Name = "gridView";
            gridView.ReadOnly = true;
            gridView.RowHeadersWidth = 51;
            gridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridView.RowTemplate.Height = 25;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView.Size = new Size(1091, 736);
            gridView.TabIndex = 53;
            // 
            // detailsBtn
            // 
            detailsBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            detailsBtn.BackColor = Color.Olive;
            detailsBtn.Location = new Point(1144, 199);
            detailsBtn.Margin = new Padding(3, 4, 3, 4);
            detailsBtn.Name = "detailsBtn";
            detailsBtn.Size = new Size(102, 51);
            detailsBtn.TabIndex = 78;
            detailsBtn.Text = "Chi Tiết";
            detailsBtn.UseVisualStyleBackColor = false;
            detailsBtn.Click += detailsBtn_Click;
            // 
            // boxKeySearch
            // 
            boxKeySearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            boxKeySearch.DropDownStyle = ComboBoxStyle.DropDownList;
            boxKeySearch.FormattingEnabled = true;
            boxKeySearch.Location = new Point(1122, 95);
            boxKeySearch.Margin = new Padding(3, 4, 3, 4);
            boxKeySearch.Name = "boxKeySearch";
            boxKeySearch.Size = new Size(150, 28);
            boxKeySearch.TabIndex = 81;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            searchBox.BackColor = Color.LightGray;
            searchBox.Location = new Point(1122, 133);
            searchBox.Margin = new Padding(3, 4, 3, 4);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search Field";
            searchBox.Size = new Size(150, 27);
            searchBox.TabIndex = 80;
            // 
            // searchButt
            // 
            searchButt.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButt.BackColor = Color.Olive;
            searchButt.Location = new Point(1144, 36);
            searchButt.Margin = new Padding(3, 4, 3, 4);
            searchButt.Name = "searchButt";
            searchButt.Size = new Size(102, 51);
            searchButt.TabIndex = 79;
            searchButt.Text = "Search";
            searchButt.UseVisualStyleBackColor = false;
            searchButt.Click += searchButt_Click;
            // 
            // frmOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1281, 825);
            Controls.Add(boxKeySearch);
            Controls.Add(searchBox);
            Controls.Add(searchButt);
            Controls.Add(detailsBtn);
            Controls.Add(exitButt);
            Controls.Add(delButt);
            Controls.Add(label8);
            Controls.Add(gridView);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Đơn Hàng";
            Load += frmOrders_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button exitButt;
        private System.Windows.Forms.Button delButt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView gridView;
        private Button detailsBtn;
        private ComboBox boxKeySearch;
        private TextBox searchBox;
        private Button searchButt;
    }
}


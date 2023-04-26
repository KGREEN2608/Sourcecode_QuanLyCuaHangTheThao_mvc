
namespace SportShopping
{
    partial class frmReport
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
            gridView = new DataGridView();
            cbReport = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtTotalPrice = new TextBox();
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
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gridView.BackgroundColor = SystemColors.ButtonHighlight;
            gridView.ColumnHeadersHeight = 29;
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            gridView.Location = new Point(0, 125);
            gridView.Margin = new Padding(3, 4, 3, 4);
            gridView.MultiSelect = false;
            gridView.Name = "gridView";
            gridView.ReadOnly = true;
            gridView.RowHeadersWidth = 51;
            gridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridView.RowTemplate.Height = 25;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView.Size = new Size(914, 475);
            gridView.TabIndex = 54;
            // 
            // cbReport
            // 
            cbReport.DropDownStyle = ComboBoxStyle.DropDownList;
            cbReport.FormattingEnabled = true;
            cbReport.Location = new Point(14, 49);
            cbReport.Margin = new Padding(3, 4, 3, 4);
            cbReport.Name = "cbReport";
            cbReport.Size = new Size(231, 28);
            cbReport.TabIndex = 78;
            cbReport.SelectedIndexChanged += cbReport_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(198, 22);
            label1.TabIndex = 79;
            label1.Text = "Số Liệu Thông Kê Theo";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(467, 12);
            label2.Name = "label2";
            label2.Size = new Size(214, 31);
            label2.TabIndex = 80;
            label2.Text = "Tổng Doanh Thu";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTotalPrice.BackColor = Color.Olive;
            txtTotalPrice.BorderStyle = BorderStyle.None;
            txtTotalPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalPrice.Location = new Point(496, 47);
            txtTotalPrice.Margin = new Padding(3, 4, 3, 4);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(42, 35);
            txtTotalPrice.TabIndex = 81;
            txtTotalPrice.TextChanged += txtTotalPrice_TextChanged;
            // 
            // frmReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Olive;
            ClientSize = new Size(914, 600);
            Controls.Add(txtTotalPrice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbReport);
            Controls.Add(gridView);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thống Kê Doanh Thu";
            Load += frmReport_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView gridView;
        private ComboBox cbReport;
        private Label label1;
        private Label label2;
        private TextBox txtTotalPrice;
    }
}
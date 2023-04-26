namespace SportShopping
{
    partial class frmOrderDetails
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
            exitButt = new Button();
            label8 = new Label();
            gridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // exitButt
            // 
            exitButt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            exitButt.BackColor = Color.Olive;
            exitButt.Location = new Point(1147, 19);
            exitButt.Margin = new Padding(3, 4, 3, 4);
            exitButt.Name = "exitButt";
            exitButt.Size = new Size(102, 51);
            exitButt.TabIndex = 85;
            exitButt.Text = "Thoát";
            exitButt.UseVisualStyleBackColor = false;
            exitButt.Click += exitButt_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(14, 19);
            label8.Name = "label8";
            label8.Size = new Size(241, 35);
            label8.TabIndex = 83;
            label8.Text = "Chi Tiết Hóa Đơn";
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
            gridView.Location = new Point(8, 84);
            gridView.Margin = new Padding(3, 4, 3, 4);
            gridView.MultiSelect = false;
            gridView.Name = "gridView";
            gridView.ReadOnly = true;
            gridView.RowHeadersWidth = 51;
            gridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            gridView.RowTemplate.Height = 25;
            gridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridView.Size = new Size(1241, 739);
            gridView.TabIndex = 82;
            // 
            // frmOrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1285, 839);
            Controls.Add(exitButt);
            Controls.Add(label8);
            Controls.Add(gridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmOrderDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi Tiết Hóa Đơn";
            FormClosing += frmOrderDetails_FormClosing;
            Load += frmOrderDetails_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button exitButt;
        private Label label8;
        private DataGridView gridView;
    }
}
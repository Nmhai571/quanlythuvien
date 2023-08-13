namespace quanlythuvien
{
    partial class QuanLySach
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.btnBuyBook = new System.Windows.Forms.Button();
            this.tbCustonmerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnbanhang = new System.Windows.Forms.Button();
            this.btnGioHang = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 472);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1029, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(276, 51);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa Sách";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(1029, 140);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(276, 51);
            this.btnUpdateBook.TabIndex = 4;
            this.btnUpdateBook.Text = "Sửa Sách";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(1029, 73);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(276, 51);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Thêm Sách";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.IndianRed;
            this.lbId.Location = new System.Drawing.Point(12, 38);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(27, 25);
            this.lbId.TabIndex = 6;
            this.lbId.Text = "id";
            // 
            // tbId
            // 
            this.tbId.ForeColor = System.Drawing.Color.IndianRed;
            this.tbId.Location = new System.Drawing.Point(51, 38);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(68, 22);
            this.tbId.TabIndex = 7;
            // 
            // btnBuyBook
            // 
            this.btnBuyBook.Location = new System.Drawing.Point(1029, 281);
            this.btnBuyBook.Name = "btnBuyBook";
            this.btnBuyBook.Size = new System.Drawing.Size(276, 51);
            this.btnBuyBook.TabIndex = 8;
            this.btnBuyBook.Text = "Thêm Vào Giỏ Hàng";
            this.btnBuyBook.UseVisualStyleBackColor = true;
            this.btnBuyBook.Click += new System.EventHandler(this.btnBuyBook_Click);
            // 
            // tbCustonmerName
            // 
            this.tbCustonmerName.ForeColor = System.Drawing.Color.IndianRed;
            this.tbCustonmerName.Location = new System.Drawing.Point(268, 40);
            this.tbCustonmerName.Name = "tbCustonmerName";
            this.tbCustonmerName.Size = new System.Drawing.Size(280, 22);
            this.tbCustonmerName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(147, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhân Viên: ";
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Location = new System.Drawing.Point(1029, 494);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(276, 51);
            this.btnNhapHang.TabIndex = 11;
            this.btnNhapHang.Text = "Hóa Đơn Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnbanhang
            // 
            this.btnbanhang.Location = new System.Drawing.Point(1029, 422);
            this.btnbanhang.Name = "btnbanhang";
            this.btnbanhang.Size = new System.Drawing.Size(276, 51);
            this.btnbanhang.TabIndex = 12;
            this.btnbanhang.Text = "Hóa Đơn Bán Hàng";
            this.btnbanhang.UseVisualStyleBackColor = true;
            this.btnbanhang.Click += new System.EventHandler(this.btnbanhang_Click);
            // 
            // btnGioHang
            // 
            this.btnGioHang.Location = new System.Drawing.Point(1029, 351);
            this.btnGioHang.Name = "btnGioHang";
            this.btnGioHang.Size = new System.Drawing.Size(276, 51);
            this.btnGioHang.TabIndex = 13;
            this.btnGioHang.Text = "Giỏ Hàng";
            this.btnGioHang.UseVisualStyleBackColor = true;
            this.btnGioHang.Click += new System.EventHandler(this.btnGioHang_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(613, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tìm Kiếm: ";
            // 
            // tbSearch
            // 
            this.tbSearch.ForeColor = System.Drawing.Color.IndianRed;
            this.tbSearch.Location = new System.Drawing.Point(743, 40);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(280, 22);
            this.tbSearch.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1029, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(276, 51);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Location = new System.Drawing.Point(17, 9);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(102, 23);
            this.btnDangXuat.TabIndex = 17;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 561);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnGioHang);
            this.Controls.Add(this.btnbanhang);
            this.Controls.Add(this.btnNhapHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCustonmerName);
            this.Controls.Add(this.btnBuyBook);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "QuanLySach";
            this.Text = "Quản Lý Sách";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button btnBuyBook;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbCustonmerName;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnbanhang;
        private System.Windows.Forms.Button btnGioHang;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDangXuat;
    }
}


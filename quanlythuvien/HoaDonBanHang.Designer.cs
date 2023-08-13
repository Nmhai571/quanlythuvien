namespace quanlythuvien
{
    partial class HoaDonBanHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewHoaDonBanHang = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotalBill = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDonBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(200, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa Đơn Bán Hàng";
            // 
            // dataGridViewHoaDonBanHang
            // 
            this.dataGridViewHoaDonBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoaDonBanHang.Location = new System.Drawing.Point(12, 181);
            this.dataGridViewHoaDonBanHang.Name = "dataGridViewHoaDonBanHang";
            this.dataGridViewHoaDonBanHang.RowHeadersWidth = 51;
            this.dataGridViewHoaDonBanHang.RowTemplate.Height = 24;
            this.dataGridViewHoaDonBanHang.Size = new System.Drawing.Size(861, 319);
            this.dataGridViewHoaDonBanHang.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(701, 506);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 53);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(200, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng Doanh Thu:";
            // 
            // tbTotalBill
            // 
            this.tbTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalBill.ForeColor = System.Drawing.Color.IndianRed;
            this.tbTotalBill.Location = new System.Drawing.Point(456, 106);
            this.tbTotalBill.Name = "tbTotalBill";
            this.tbTotalBill.Size = new System.Drawing.Size(217, 38);
            this.tbTotalBill.TabIndex = 4;
            // 
            // HoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 570);
            this.Controls.Add(this.tbTotalBill);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewHoaDonBanHang);
            this.Controls.Add(this.label1);
            this.Name = "HoaDonBanHang";
            this.Text = "HoaDonBanHang";
            this.Load += new System.EventHandler(this.HoaDonBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDonBanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewHoaDonBanHang;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTotalBill;
    }
}
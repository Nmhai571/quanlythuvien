﻿namespace quanlythuvien
{
    partial class GioHang
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
            this.dataGridViewGioHang = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giỏ Hàng";
            // 
            // dataGridViewGioHang
            // 
            this.dataGridViewGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGioHang.Location = new System.Drawing.Point(12, 133);
            this.dataGridViewGioHang.Name = "dataGridViewGioHang";
            this.dataGridViewGioHang.RowHeadersWidth = 51;
            this.dataGridViewGioHang.RowTemplate.Height = 24;
            this.dataGridViewGioHang.Size = new System.Drawing.Size(713, 322);
            this.dataGridViewGioHang.TabIndex = 1;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(467, 461);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(127, 44);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Trờ Về";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Thay Đổi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbId
            // 
            this.tbId.ForeColor = System.Drawing.Color.IndianRed;
            this.tbId.Location = new System.Drawing.Point(52, 105);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(68, 22);
            this.tbId.TabIndex = 9;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.IndianRed;
            this.lbId.Location = new System.Drawing.Point(13, 105);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(27, 25);
            this.lbId.TabIndex = 8;
            this.lbId.Text = "id";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(334, 461);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 44);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // GioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 517);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dataGridViewGioHang);
            this.Controls.Add(this.label1);
            this.Name = "GioHang";
            this.Text = "GioHang";
            this.Load += new System.EventHandler(this.GioHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGioHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewGioHang;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btnDelete;
    }
}
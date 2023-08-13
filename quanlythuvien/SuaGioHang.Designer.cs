namespace quanlythuvien
{
    partial class SuaGioHang
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.picBook = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.tbPulisher = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(489, 582);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 49);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Trờ Về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(489, 527);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(128, 49);
            this.btnSubmit.TabIndex = 36;
            this.btnSubmit.Text = "Thay Đổi";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // picBook
            // 
            this.picBook.Location = new System.Drawing.Point(200, 457);
            this.picBook.Name = "picBook";
            this.picBook.Size = new System.Drawing.Size(283, 174);
            this.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBook.TabIndex = 34;
            this.picBook.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 33;
            this.label8.Text = "Ảnh: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Nhà Xuất Bản: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Thể Loại: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Số Lượng: ";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(200, 262);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(283, 22);
            this.tbQuantity.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Năm Xuất Bản: ";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(200, 198);
            this.tbYear.Name = "tbYear";
            this.tbYear.ReadOnly = true;
            this.tbYear.Size = new System.Drawing.Size(283, 22);
            this.tbYear.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "Giá: ";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(200, 134);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.ReadOnly = true;
            this.tbPrice.Size = new System.Drawing.Size(283, 22);
            this.tbPrice.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tác Giả: ";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(200, 79);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.ReadOnly = true;
            this.tbAuthor.Size = new System.Drawing.Size(283, 22);
            this.tbAuthor.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên Sách: ";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(200, 26);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.ReadOnly = true;
            this.tbBookName.Size = new System.Drawing.Size(283, 22);
            this.tbBookName.TabIndex = 19;
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(200, 326);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.ReadOnly = true;
            this.tbCategory.Size = new System.Drawing.Size(283, 22);
            this.tbCategory.TabIndex = 38;
            // 
            // tbPulisher
            // 
            this.tbPulisher.Location = new System.Drawing.Point(200, 387);
            this.tbPulisher.Name = "tbPulisher";
            this.tbPulisher.ReadOnly = true;
            this.tbPulisher.Size = new System.Drawing.Size(283, 22);
            this.tbPulisher.TabIndex = 39;
            // 
            // SuaGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 642);
            this.Controls.Add(this.tbPulisher);
            this.Controls.Add(this.tbCategory);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.picBook);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBookName);
            this.Name = "SuaGioHang";
            this.Text = "SuaGioHang";
            this.Load += new System.EventHandler(this.SuaGioHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox picBook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.TextBox tbPulisher;
    }
}
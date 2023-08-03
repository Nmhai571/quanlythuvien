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
            this.dataGridView1.Size = new System.Drawing.Size(1121, 472);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(604, 566);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(216, 51);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa Sách";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(311, 566);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(200, 51);
            this.btnUpdateBook.TabIndex = 4;
            this.btnUpdateBook.Text = "Sửa Sách";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(12, 566);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(214, 51);
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
            this.lbId.Location = new System.Drawing.Point(12, 25);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(27, 25);
            this.lbId.TabIndex = 6;
            this.lbId.Text = "id";
            // 
            // tbId
            // 
            this.tbId.ForeColor = System.Drawing.Color.IndianRed;
            this.tbId.Location = new System.Drawing.Point(51, 25);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(68, 22);
            this.tbId.TabIndex = 7;
            // 
            // btnBuyBook
            // 
            this.btnBuyBook.Location = new System.Drawing.Point(917, 566);
            this.btnBuyBook.Name = "btnBuyBook";
            this.btnBuyBook.Size = new System.Drawing.Size(216, 51);
            this.btnBuyBook.TabIndex = 8;
            this.btnBuyBook.Text = "Mua Sách";
            this.btnBuyBook.UseVisualStyleBackColor = true;
            // 
            // tbCustonmerName
            // 
            this.tbCustonmerName.ForeColor = System.Drawing.Color.IndianRed;
            this.tbCustonmerName.Location = new System.Drawing.Point(852, 25);
            this.tbCustonmerName.Name = "tbCustonmerName";
            this.tbCustonmerName.Size = new System.Drawing.Size(280, 22);
            this.tbCustonmerName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(722, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nhân Viên: ";
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 629);
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
    }
}


using quanlythuvien.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quanlythuvien
{
    public partial class HoaDonBanHang : Form
    {
        private readonly EmployeeModel _emoloyeeModel;
        static string connectionString = "Data Source=LAPTOP-I9PU2NFD\\NGUYENMINHHAI;Initial Catalog=CUAHANGSACH;Integrated Security=True";
        public HoaDonBanHang()
        {
            InitializeComponent();
        }
        public HoaDonBanHang(EmployeeModel employeeModel)
        {
            InitializeComponent();
            _emoloyeeModel = employeeModel;
        }

        private void HoaDonBanHang_Load(object sender, EventArgs e)
        {
            GetAllInvoiceDetails();
            decimal totalAmount = TotalBill();
            tbTotalBill.Text = totalAmount.ToString("0.00");
        }

        void GetAllInvoiceDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("EXEC GetChiTietHoaDon", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewHoaDonBanHang.DataSource = dt;
            }

        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            QuanLySach ql = new QuanLySach(_emoloyeeModel);
            ql.Show();
            this.Hide();
        }

        public static decimal TotalBill()
        {
            decimal totalAmount = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT dbo.TotalBill()", connection))
                {
                    totalAmount = Convert.ToDecimal(command.ExecuteScalar());
                }
            }

            return totalAmount;
        }


    }
}

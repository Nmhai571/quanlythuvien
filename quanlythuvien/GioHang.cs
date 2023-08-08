using quanlythuvien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlythuvien
{
    public partial class GioHang : Form
    {
        string connectionString = "Data Source=LAPTOP-I9PU2NFD\\NGUYENMINHHAI;Initial Catalog=CUAHANGSACH;Integrated Security=True";
        private readonly EmployeeModel _employeeModel;
        public GioHang()
        {
            InitializeComponent();
        }

        public GioHang(EmployeeModel employee)
        {
            InitializeComponent();
            _employeeModel = employee;
        }

        private void GioHang_Load(object sender, EventArgs e)
        {
            GetBookInCart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLySach ql = new QuanLySach(_employeeModel);
            ql.Show();
            this.Hide();
        }

        void GetBookInCart()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand("EXEC GetBooksInCart", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewGioHang.DataSource = dt;
            }
                
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan();
            HoaDonBanHang hd = new HoaDonBanHang(_employeeModel);
            hd.Show();
            this.Hide();
        }

        void ThanhToan()
        {
            int employeeId = _employeeModel.Id;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("ThanhToan", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NhanVienId", employeeId);

                    try
                    {
                        int invoiceId = (int)command.ExecuteScalar();
                        MessageBox.Show("Thành Công");
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
        }
    }
}

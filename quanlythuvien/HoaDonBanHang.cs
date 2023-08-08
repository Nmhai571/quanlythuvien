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

        public static List<InvoiceDetail> GetInvoiceDetails(int hoaDonId)
        {
            List<InvoiceDetail> invoiceDetails = new List<InvoiceDetail>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetChiTietHoaDon", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@HoaDonId", hoaDonId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            InvoiceDetail detail = new InvoiceDetail
                            {
                                IdHoaDon = Convert.ToInt32(reader["Id"]),
                                TenSach = reader["TenSach"].ToString(),
                                SoLuong = Convert.ToInt32(reader["SoLuong"]),
                                DonGia = Convert.ToDecimal(reader["DonGia"]),
                                ThanhTien = Convert.ToDecimal(reader["ThanhTien"])
                            };
                            invoiceDetails.Add(detail);
                        }
                    }
                }


                return invoiceDetails;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            QuanLySach ql = new QuanLySach(_emoloyeeModel);
            ql.Show();
            this.Hide();
        }
    }
}

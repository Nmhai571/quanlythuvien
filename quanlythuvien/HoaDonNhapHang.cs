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
    public partial class HoaDonNhapHang : Form
    {
        private readonly EmployeeModel _employeeModel;
        string connectionString = "Data Source=LAPTOP-I9PU2NFD\\NGUYENMINHHAI;Initial Catalog=CUAHANGSACH;Integrated Security=True";
        public HoaDonNhapHang()
        {
            InitializeComponent();
        }

        public HoaDonNhapHang(EmployeeModel employeeModel)
        {
            InitializeComponent();
            _employeeModel = employeeModel;
        }

        private void HoaDonNhapHang_Load(object sender, EventArgs e)
        {
            GetChiTietHoaDon();
            LoadDataBinding();
        }

        void GetChiTietHoaDon()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("GetChiTietHoaDonNhaphang", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewhoadonnhaphang.DataSource = dt;
                }
            }

        }

        public void LoadDataBinding()
        {
            tbIdHoaDonNhapHang.DataBindings.Add(new Binding("Text", dataGridViewhoadonnhaphang.DataSource, "MaHoaDon"));
            tbTenNhanVien.DataBindings.Add(new Binding("Text", dataGridViewhoadonnhaphang.DataSource, "NhanVien"));
            tbNgayNhap.DataBindings.Add(new Binding("Text", dataGridViewhoadonnhaphang.DataSource, "NgayXuat"));
            tbNhaXuatBan.DataBindings.Add(new Binding("Text", dataGridViewhoadonnhaphang.DataSource, "NhaXuatBan"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuanLySach ql = new QuanLySach(_employeeModel);
            ql.Show();
            this.Hide();
        }
    }
}

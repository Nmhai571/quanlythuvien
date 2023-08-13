using quanlythuvien.Infrastructure;
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
            LoadDataBinding();
        }

        public void LoadDataBinding()
        {
            tbId.DataBindings.Add(new Binding("Text", dataGridViewGioHang.DataSource, "IdSach"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLySach ql = new QuanLySach(_employeeModel);
            ql.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thành Công");
            DeleteBook(Convert.ToInt32(tbId.Text));
            
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

                    }
                    catch (SqlException ex)
                    {
                        if (ex.Errors.Count > 0)
                        {
                            
                            foreach (SqlError error in ex.Errors)
                            {
                                if (error.Number == 50000) 
                                {
                                    MessageBox.Show(error.Message);
                                    return;
                                    
                                }
                            }
                        }
                    }
                    if (_employeeModel.Role != Const.ROLEADMIN)
                    {
                        MessageBox.Show("Thanh Toán Thành Công");
                        QuanLySach ql = new QuanLySach(_employeeModel);
                        ql.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Thanh Toán Thành Công");
                        HoaDonBanHang hd = new HoaDonBanHang(_employeeModel);
                        hd.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var book = GetBookById(Convert.ToInt32(tbId.Text));
            SuaGioHang suaGioHang = new SuaGioHang(_employeeModel, book);
            suaGioHang.Show();
            this.Hide();
        }

        public BookModel GetBookById(int id)
        {
            BookModel bookModel = null;
            //id = Convert.ToInt32(tbId.Text);
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GetBookById", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)).Value = id;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bookModel = new BookModel
                                {
                                    BookId = Convert.ToInt32(reader["Id"]),
                                    BookName = reader["TenSach"].ToString(),
                                    Author = reader["TacGia"].ToString(),
                                    Price = Convert.ToInt32(reader["Gia"]),
                                    YearOfpublication = Convert.ToDateTime(reader["NamXuatBan"]),
                                    Quantity = Convert.ToInt32(reader["SoLuong"]),
                                    CategoryId = Convert.ToInt32(reader["IdTheLoaiSach"]),
                                    PublisherId = Convert.ToInt32(reader["IdNhaXuatBan"]),
                                    BookImage = (byte[])reader["AnhSach"]
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }

            if (bookModel == null)
            {
                return null;
            }
            return bookModel;

        }

        void DeleteBook(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("DeleteBookInCart", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@BookId", SqlDbType.Int)).Value = id;
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                this.Hide();
                GioHang gh = new GioHang(_employeeModel);
                gh.Show();
            }
            catch (Exception ex)
            {
            }
        }


    }
}

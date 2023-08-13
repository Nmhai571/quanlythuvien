using quanlythuvien.Infrastructure;
using quanlythuvien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlythuvien
{
    public partial class QuanLySach : Form
    {
        private EmployeeModel _employeeModel;
        
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-I9PU2NFD\\NGUYENMINHHAI;Initial Catalog=CUAHANGSACH;Integrated Security=True");
        string connectionString = "Data Source=LAPTOP-I9PU2NFD\\NGUYENMINHHAI;Initial Catalog=CUAHANGSACH;Integrated Security=True";
        public QuanLySach()
        {
            InitializeComponent();
        }

        public QuanLySach(EmployeeModel employeeModel)
        {
            InitializeComponent();
            _employeeModel = employeeModel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllBooks();
            LoadDataBinding();
            tbCustonmerName.Text = _employeeModel.EmployeeName;
        }

        public void LoadDataBinding()
        {
            tbId.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IdSach"));
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if(_employeeModel.Role != Const.ROLEADMIN)
            {
                MessageBox.Show("Bạn Không Có Quyền Thêm Sách");
                return;
            }
            AddBook addBook = new AddBook(_employeeModel);
            addBook.Show();
            this.Hide();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_employeeModel.Role != Const.ROLEADMIN)
            {
                MessageBox.Show("Bạn Không Có Quyền Xóa Sách");
                return;
            }
            DeleteBook(Convert.ToInt32(tbId.Text));
            MessageBox.Show("Xóa Thành Công");
        }

        void GetAllBooks()
        {
            SqlCommand sqlCommand = new SqlCommand("EXEC GetAllBooksAndCategories", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (_employeeModel.Role != Const.ROLEADMIN)
            {
                MessageBox.Show("Bạn Không Có Quyền Sửa Sách");
                return;
            }
            BookModel bookModel = new BookModel();
            bookModel = GetBookById(Convert.ToInt32(tbId.Text));
            UpdateBook updateBook = new UpdateBook(_employeeModel, bookModel);
            updateBook.Show();
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

        PublisherModel GetPublisherById(int id)
        {
            PublisherModel publisherModel = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GetPublisherById", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)).Value = id;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                publisherModel = new PublisherModel
                                { PublisherName = reader["TenNXB"].ToString() };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return publisherModel;
        }

        void DeleteBook(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("DeleteBook", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@BookId", SqlDbType.Int)).Value = id;
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                this.Hide();
                QuanLySach qlSach = new QuanLySach(_employeeModel);
                qlSach.Show();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (_employeeModel.Role != Const.ROLEADMIN)
            {
                MessageBox.Show("Bạn Không Có Quyền Xem Hóa Đơn");
                return;
            }
            HoaDonNhapHang hdnh = new HoaDonNhapHang(_employeeModel);
            hdnh.Show();
            this.Hide();
        }

        private void btnBuyBook_Click(object sender, EventArgs e)
        {
            AddToCard();
        }

        EmployeeModel GetEmployeeByName(string name)
        {
            EmployeeModel employeeModel = null;
            name = tbCustonmerName.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GetEmployeeByName", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Name", SqlDbType.NVarChar)).Value = name;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                employeeModel = new EmployeeModel
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    EmployeeName = reader["HoTen"].ToString(),
                                    Role = reader["TenRole"].ToString()
                                    
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return employeeModel;

        }

        void AddToCard()
        {
            int sachIdToAdd = Int32.Parse(tbId.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("AddToCart", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SachId", sachIdToAdd);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm Giỏ Hàng Thành Công");
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

                }
            }
            
        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {
            GioHang gh = new GioHang(_employeeModel);
            gh.Show();
            this.Hide();
        }

        private void btnbanhang_Click(object sender, EventArgs e)
        {
            if (_employeeModel.Role != Const.ROLEADMIN)
            {
                MessageBox.Show("Bạn Không Có Quyền Xem Hóa Đơn");
                return;
            }
            HoaDonBanHang hd = new HoaDonBanHang(_employeeModel);
            hd.Show();
            this.Hide();
        }

        public void SearchBooks(string searchTerm)
        {


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SearchBooks", connection))
                {
                    dataGridView1.DataSource = null;
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SearchTerm", searchTerm);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBooks(tbSearch.Text);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}

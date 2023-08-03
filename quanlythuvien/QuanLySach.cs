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
        SqlConnection connection = new SqlConnection("Data Source=LAPTOP-I9PU2NFD\\NGUYENMINHHAI;Initial Catalog=CUAHANGSACH;Integrated Security=True");
        string connectionString = "Data Source=LAPTOP-I9PU2NFD\\NGUYENMINHHAI;Initial Catalog=CUAHANGSACH;Integrated Security=True";
        public QuanLySach()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllBooks();
            LoadDataBinding();
        }

        public void LoadDataBinding()
        {
            tbId.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IdSach"));
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
            this.Hide();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBook(Convert.ToInt32(tbId.Text));
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
            BidingDataToUpdate();
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

            if( bookModel == null )
            {
                return null;
            }
            return bookModel;

        }

        BookCategoryModel GetCategoryById(int id)
        {
            BookCategoryModel bookCategoryModel = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GetCategoryById", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)).Value = id;
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                bookCategoryModel = new BookCategoryModel
                                {CategoryName = reader["TenTheLoai"].ToString()};
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return bookCategoryModel;
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

        void BidingDataToUpdate()
        {
            BookModel bookModel = new BookModel();
            UpdateBook updateBook = new UpdateBook();
            bookModel = GetBookById(Convert.ToInt32(tbId.Text));
            var category = GetCategoryById(bookModel.CategoryId);
            var publisher = GetPublisherById(bookModel.PublisherId);
            MemoryStream stream = new MemoryStream(bookModel.BookImage);
            Image imgBook = Image.FromStream(stream);

            updateBook.tbIdBook.Text = bookModel.BookId.ToString();
            updateBook.tbBookName.Text = bookModel.BookName;
            updateBook.tbAuthor.Text = bookModel.Author;
            updateBook.tbPrice.Text = bookModel.Price.ToString();
            updateBook.tbQuantity.Text = bookModel.Quantity.ToString();
            updateBook.cbBookCategory.Text = category.CategoryName;
            updateBook.cbPublisher.Text = publisher.PublisherName;
            updateBook.tbYear.Text = bookModel.YearOfpublication.ToString();
            updateBook.picBook.Image = imgBook;
            updateBook.Show();
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
                QuanLySach qlSach = new QuanLySach();
                qlSach.Show();
            }
            catch (Exception ex)
            {
            }
        }

        
    }
}

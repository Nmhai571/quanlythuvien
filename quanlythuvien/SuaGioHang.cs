using quanlythuvien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlythuvien
{
    public partial class SuaGioHang : Form
    {
        string connectionString = "Data Source=LAPTOP-I9PU2NFD\\NGUYENMINHHAI;Initial Catalog=CUAHANGSACH;Integrated Security=True";
        private readonly EmployeeModel _employeeModel;
        private readonly BookModel _bookModel;

        public SuaGioHang(EmployeeModel employeeModel, BookModel bookModel)
        {
            _employeeModel = employeeModel;
            _bookModel = bookModel;
            InitializeComponent();
        }

        public SuaGioHang()
        {
            InitializeComponent();
        }

        private void SuaGioHang_Load(object sender, EventArgs e)
        {
            BidingBookData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GioHang gh = new GioHang(_employeeModel);
            gh.Show();
            this.Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            EditBookInCart();
            MessageBox.Show("Thành Công");
            GioHang gh = new GioHang(_employeeModel);
            gh.Show();
            this.Hide();
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
                                { CategoryName = reader["TenTheLoai"].ToString() };
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
        void BidingBookData()
        {
            var category = GetCategoryById(_bookModel.CategoryId);
            var publisher = GetPublisherById(_bookModel.PublisherId);
            MemoryStream stream = new MemoryStream(_bookModel.BookImage);
            Image imgBook = Image.FromStream(stream);

            tbBookName.Text = _bookModel.BookName;
            tbAuthor.Text = _bookModel.Author;
            tbPrice.Text = _bookModel.Price.ToString();
            tbQuantity.Text = "1";
            tbCategory.Text = category.CategoryName;
            tbPulisher.Text = publisher.PublisherName;
            tbYear.Text = _bookModel.YearOfpublication.ToString();
            picBook.Image = imgBook;
        }


        void EditBookInCart()
        {
            MemoryStream stream = new MemoryStream();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("EditCart", connection))
                    {
                        picBook.Image.Save(stream, ImageFormat.Png);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@IdSach", SqlDbType.Int)).Value = _bookModel.BookId;
                        command.Parameters.Add(new SqlParameter("@SoLuong", SqlDbType.Int)).Value = Int32.Parse(tbQuantity.Text);

                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                
            }
            catch (Exception ex)
            {
            }
        }


    }
}

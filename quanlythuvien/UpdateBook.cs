﻿using quanlythuvien.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlythuvien
{
    public partial class UpdateBook : Form
    {
        private readonly EmployeeModel _employeeModel;
        private readonly BookModel _bookModel;
        string connectionString = "Data Source=LAPTOP-I9PU2NFD\\NGUYENMINHHAI;Initial Catalog=CUAHANGSACH;Integrated Security=True";
        public UpdateBook()
        {
            InitializeComponent();
        }
        public UpdateBook(EmployeeModel employeeModel)
        {
            InitializeComponent();
            _employeeModel = employeeModel;
        }

        public UpdateBook(EmployeeModel employeeModel, BookModel bookModel)
        {
            InitializeComponent();
            _employeeModel = employeeModel;
            _bookModel = bookModel;
        }
        private void UpdateBook_Load(object sender, EventArgs e)
        {
            GetAllBookCategory();
            GetAllPublisher();
            BidingBookData();
        }



        void GetAllBookCategory()
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GetAllBookCategories", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable categoryTable = new DataTable();
                        adapter.Fill(categoryTable);
                        cbBookCategory.DisplayMember = "TenTheLoai";
                        cbBookCategory.DataSource = categoryTable;
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                }
            }
        }

        public void GetAllPublisher()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("GetAllNhaXuatBan", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbPublisher.DisplayMember = "TenNXB";
                        cbPublisher.DataSource = dt;
                    }
                    connection.Close();

                }
                catch (Exception ex)
                {
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            QuanLySach qlSach = new QuanLySach(_employeeModel);
            qlSach.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EditBook();
        }

        public int GetIdCategoryByName()
        {
            var categoryId = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GetIdByNameCategory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@TenTheLoai", SqlDbType.NVarChar, 30)).Value = cbBookCategory.Text;

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            categoryId = Convert.ToInt32(result);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return categoryId;
        }

        public int GetIdPubhlisherByName()
        {
            var pubhlisherId = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("GetIdByNamePublisher", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@TenNXB", SqlDbType.NVarChar, 30)).Value = cbPublisher.Text;

                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            pubhlisherId = Convert.ToInt32(result);
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return pubhlisherId;
        }

        void EditBook()
        {
            MemoryStream stream = new MemoryStream();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                     connection.Open();

                    using (SqlCommand command = new SqlCommand("UpdateBook", connection))
                    {
                        picBook.Image.Save(stream, ImageFormat.Png);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int)).Value = Int32.Parse(tbIdBook.Text);
                        command.Parameters.Add(new SqlParameter("@TenSach", SqlDbType.NVarChar, 30)).Value = tbBookName.Text;
                        command.Parameters.Add(new SqlParameter("@TacGia", SqlDbType.NVarChar, 30)).Value = tbAuthor.Text;
                        command.Parameters.Add(new SqlParameter("@Gia", SqlDbType.Int)).Value = Int32.Parse(tbPrice.Text);
                        command.Parameters.Add(new SqlParameter("@NamXuatBan", SqlDbType.DateTime)).Value = tbYear.Text;
                        command.Parameters.Add(new SqlParameter("@SoLuong", SqlDbType.Int)).Value = Int32.Parse(tbQuantity.Text);
                        command.Parameters.Add(new SqlParameter("@IdTheLoaiSach", SqlDbType.Int)).Value = GetIdCategoryByName();
                        command.Parameters.Add(new SqlParameter("@IdNhaXuatBan", SqlDbType.Int)).Value = GetIdPubhlisherByName();
                        command.Parameters.Add(new SqlParameter("@AnhSach", SqlDbType.Image)).Value = stream.ToArray();

                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                MessageBox.Show("Sửa Thành Công");
                QuanLySach qlSach = new QuanLySach(_employeeModel);
                qlSach.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
            string filePath = openFile.FileName;
            if (filePath.Equals("openFileDialog1"))
            {
                return;
            }
            Image questionImage = Image.FromFile(filePath);
            picBook.Image = questionImage;
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
            BookModel bookModel = new BookModel();
            var category = GetCategoryById(_bookModel.CategoryId);
            var publisher = GetPublisherById(_bookModel.PublisherId);
            MemoryStream stream = new MemoryStream(_bookModel.BookImage);
            Image imgBook = Image.FromStream(stream);

            tbIdBook.Text = _bookModel.BookId.ToString();
            tbBookName.Text = _bookModel.BookName;
            tbAuthor.Text = _bookModel.Author;
            tbPrice.Text = _bookModel.Price.ToString();
            tbQuantity.Text = _bookModel.Quantity.ToString();
            cbBookCategory.Text = category.CategoryName;
            cbPublisher.Text =publisher.PublisherName;
            tbYear.Text = _bookModel.YearOfpublication.ToString();
            picBook.Image = imgBook;
        }
    }
}

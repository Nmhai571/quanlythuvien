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
using System.Xml.Schema;

namespace quanlythuvien
{
    public partial class Login : Form
    {
        string connectionString = "Data Source=LAPTOP-I9PU2NFD\\NGUYENMINHHAI;Initial Catalog=CUAHANGSACH;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SignIn(tbPhone.Text);
        }

        EmployeeModel SignIn(string phone)
        {
            EmployeeModel employee = null;
            

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("LoginEmployeeByPhone", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add(new SqlParameter("@Phone", SqlDbType.Char, 10)).Value = phone;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                employee = new EmployeeModel
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

            if (employee == null)
            {
                return null;
            }
            QuanLySach quanLySach = new QuanLySach(employee);

            quanLySach.Show();
            this.Hide();
            return employee;
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Data.SqlClient;
using System.Configuration;


namespace RegistrationUsers
{
    public partial class Form1 : Form
    {
        private string connStr;
       
        public Form1()
        {
            InitializeComponent();
            connStr = ConfigurationManager.ConnectionStrings["ServerDBConnection"].ConnectionString;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(Id_Filed.Text, out id))
            {
                MessageBox.Show("Будь ласка, введіть коректне ціле число для Id.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = Name_Filed.Text;
            string surname = Surname_Filed.Text;
            string email = Email_Filed.Text;
            string login = Login_Filed.Text;
            string password = Passw_Filed.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(login) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Будь ласка, заповніть всі поля для реєстрації.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string query = "INSERT INTO [Table] (Id, Name, Surname, Email, Login, Password) VALUES (@Id, @Name, @Surname, @Email, @Login, @Password)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Surname", surname);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Реєстрація успішна!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося зареєструвати користувача.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка реєстрації: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearFields()
        {
            Id_Filed.Text = ""; 
            Name_Filed.Text = "";
            Surname_Filed.Text = "";
            Email_Filed.Text = "";
            Login_Filed.Text = "";
            Passw_Filed.Text = "";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Id_Filed.Text = ""; 
            Surname_Filed.Text = "";
            Name_Filed.Text = "";
            Email_Filed.Text = "";
            Login_Filed.Text = "";
            Passw_Filed.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

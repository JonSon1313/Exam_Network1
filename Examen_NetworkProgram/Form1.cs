using System;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using Models;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SqlClient;
using System.Configuration;

namespace Examen_NetworkProgram
{
    public partial class Server : Form
    {
        private int _port;
        private IPAddress _addr;
        private IPEndPoint _ep;

        private TcpListener _listener;
        private Thread _listenerThread;
        private BinaryFormatter _bf;


        
        string connStr;
        public Server()
        {
            InitializeComponent();
            _bf = new BinaryFormatter();
            connStr = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

        private void Server_Load(object sender, EventArgs e)
        {
            _port = int.Parse(PortField.Text);
            _addr = IPAddress.Parse(AddrFiled.Text);

            _ep = new IPEndPoint(_addr, _port);
            _listener = new TcpListener(_ep);
            _listener.Start();

            _listenerThread = new Thread(new ThreadStart(WorlLoop))
            {
                IsBackground = true
            };
            _listenerThread.Start();

            JournalBox.Text = DateTime.Now + "--> Server has been started\r\n";
        }

        public void AdminAuth(Admin receivedAdmin, NetworkStream ns)
        {
            string login = receivedAdmin.Login;
            string passw = receivedAdmin.Password;

            string message = "";

            
            if (login == "admin" && passw == "adminpassword")
            {
                message = "SUCCESS";
            }
            else
            {
                message = "FAILED";
            }

            var response = new Response()
            {
                Message = message
            };
            _bf.Serialize(ns, response);
        
            JournalBox.Invoke(new Action(() =>
            {
                JournalBox.Text +=
                DateTime.Now + $" -> Запит на авторизацію адміна: {login}/{passw} =>{message}\r\n";
            }));
        }
        private void UserAuth(User receivedUser, NetworkStream ns)
        {
            string login = receivedUser.Login;
            string passw = receivedUser.Password;

            string message = "";

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string query = "SELECT COUNT(1) FROM [User] WHERE Login = @Login AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", passw);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                if (count > 0)
                    message = "SUCCESS";
                else
                    message = "FAILED";
            }

            var response = new Response()
            {
                Message = message
            };
            _bf.Serialize(ns, response);

            JournalBox.Invoke(new Action(() =>
            {
                JournalBox.Text +=
                    DateTime.Now + $" -> Вхід користувача: {login}/{passw} => {message}\r\n";
            }));

        }

        private void RegisterUser(User user)
        {
            string login = user.Login;
            string passw = user.Password;
            string name = user.Name;
            string surname = user.Surname;
            string email = user.Email;

            using (SqlConnection connection = new SqlConnection(connStr))
            {
                string query = "INSERT INTO [User] (Login, Password, Name, Surname, Email) VALUES (@Login, @Password, @Name, @Surname, @Email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", passw);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Surname", surname);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Користувач успішно зареєстрований", "Реєстрація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    JournalBox.Invoke(new Action(() =>
                    {
                        JournalBox.Text +=
                            DateTime.Now + $" -> Користувач {user.Login} зареєстрований.\r\n";
                    }));
                }
                else
                {
                    MessageBox.Show("Не вдалося зареєструвати користувача", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RegisterUserHandler(User receivedUser, NetworkStream ns)
        {
            RegisterUser(receivedUser);

           
            var response = new Response()
            {
                Message = "SUCCESS"
            };
            _bf.Serialize(ns, response);

            JournalBox.Invoke(new Action(() =>
            {
                JournalBox.Text +=
                DateTime.Now + $" -> Користувач зареєстрований: {receivedUser.Login}\r\n";
            }));
        }
        private void WorlLoop()
        {
            while (true)
            {
                try
                {
                    
                    TcpClient acceptor = _listener.AcceptTcpClient();
                    NetworkStream ns = acceptor.GetStream();
                    string action = (string)_bf.Deserialize(ns);
                    User receivedUser = (User)_bf.Deserialize(ns);
                    Admin receivedAdmin = (Admin)_bf.Deserialize(ns);

                    
                    switch (action)
                    {
                        case "AUTH_ADMIN":
                            AdminAuth(receivedAdmin, ns);
                            break;

                        case "AUTH_USER":
                            UserAuth(receivedUser, ns);
                            break;

                        case "REGISTER_USER":
                            RegisterUserHandler(receivedUser, ns);
                            break;
                    }

                    ns.Close();
                    acceptor.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка сервера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
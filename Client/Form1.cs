using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Data.SqlClient;
using System.Configuration;
using Models;

namespace Client
{
    public partial class Form1 : Form
    {
        private string connStr;
        private List<Subject> subjects;
        private List<Question> questions;
        private int currentSubjectIndex;
        private int currentQuestionIndex;
        private int currentUserId; 

        public Form1()
        {
            InitializeComponent();
            connStr = ConfigurationManager.ConnectionStrings["ServerDBConnection"].ConnectionString;
            DisableSubjectRadioButtons();
            
            LoadData();
        }

        private void LoadData()
        {
            DataGenerator dataGenerator = new DataGenerator();
            subjects = dataGenerator.GenerateSubjects();
            questions = dataGenerator.GenerateQuestions();
        }

      

        private void DisableSubjectRadioButtons()
        {
            radio_math.Enabled = false;
            radio_history.Enabled = false;
            radio_chemic.Enabled = false;
            radio_physick.Enabled = false;
        }

        private void EnableSubjectRadioButtons()
        {
            radio_math.Enabled = true;
            radio_history.Enabled = true;
            radio_chemic.Enabled = true;
            radio_physick.Enabled = true;
        }

        private void button_Entry_Click(object sender, EventArgs e)
        {
            string adminLogin = Login_Field2.Text;
            string adminPassword = Passw_Field2.Text;

            radio_admin.Enabled = false;
            radio_user.Enabled = false;
            if (radio_admin.Checked)
            {
               
                if (adminLogin == "admin" && adminPassword == "adminpassword")
                {
                    MessageBox.Show("Успішний вхід як адміністратор");
                    
                    EnableSubjectRadioButtons();
                }
                else
                {
                    MessageBox.Show("Невірний логін або пароль для адміністратора");
                   
                }
            }
            else if (radio_user.Checked)
            {
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    string query = "SELECT Id FROM [Table] WHERE Login = @Login AND Password = @Password"; 
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Login", Login_Field2.Text);
                    command.Parameters.AddWithValue("@Password", Passw_Field2.Text);

                    connection.Open();
                    currentUserId = (int)command.ExecuteScalar(); 
                    connection.Close();

                    if (currentUserId > 0)
                    {
                        MessageBox.Show("Успішний вхід як користувач");
                        
                        EnableSubjectRadioButtons();
                    }
                    else
                    {
                        MessageBox.Show("Невірний логін або пароль для користувача");
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть тип користувача (адміністратор або користувач)");
            }
        }

        private int GetSelectedSubjectIndex()
        {
            if (radio_math.Checked)
            {
                return 0; 
            }
            else if (radio_history.Checked)
            {
                return 1; 
            }
            else if (radio_chemic.Checked)
            {
                return 2; 
            }
            else if (radio_physick.Checked)
            {
                return 3; 
            }
            else
            {
                return -1; 
            }
        }

        public class DataGenerator
        {
            public List<Subject> GenerateSubjects()
            {
                List<Subject> subjects = new List<Subject>
            {
                new Subject { Id = 1, Name = "Mathematics" },
                new Subject { Id = 2, Name = "History" },
                new Subject { Id = 3, Name = "Chemistry" },
                new Subject { Id = 4, Name = "Physick" }
            };

                return subjects;
            }

            public List<Question> GenerateQuestions()
            {
                List<Question> questions = new List<Question>
            {
                new Question
                {
                    Id = 1,
                    Text = "What is 2 + 2?",
                    SubjectId = 1, // Mathematics
                    Answers = new List<Answer>
                    {
                        new Answer { Id = 1, Text = "3", IsCorrect = false },
                        new Answer { Id = 2, Text = "4", IsCorrect = true },
                        new Answer { Id = 3, Text = "5", IsCorrect = false }
                    }
                },
                new Question
                {
                    Id = 2,
                    Text = "Who was the first president of the United States?",
                    SubjectId = 2, // History
                    Answers = new List<Answer>
                    {
                        new Answer { Id = 4, Text = "George Washington", IsCorrect = true },
                        new Answer { Id = 5, Text = "Thomas Jefferson", IsCorrect = false },
                        new Answer { Id = 6, Text = "Abraham Lincoln", IsCorrect = false }
                    }
                },
                new Question
                {
                    Id = 3,
                    Text = "What is the chemical symbol for water?",
                    SubjectId = 3, // Chemistry
                    Answers = new List<Answer>
                    {
                        new Answer { Id = 7, Text = "O2", IsCorrect = false },
                        new Answer { Id = 8, Text = "H2O", IsCorrect = true },
                        new Answer { Id = 9, Text = "CO2", IsCorrect = false }
                    }
                },
                new Question
                {
                    Id = 4,
                    Text = "What is the unit of measurement for force?",
                    SubjectId = 4, // Physics
                    Answers = new List<Answer>
                    {
                        new Answer { Id = 10, Text = "Kilogram", IsCorrect = false },
                        new Answer { Id = 11, Text = "Newton", IsCorrect = true },
                        new Answer { Id = 12, Text = "Meter", IsCorrect = false }
                    }
                }
            };

                return questions;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            currentSubjectIndex = GetSelectedSubjectIndex();

            if (currentSubjectIndex == -1)
            {
                MessageBox.Show("Будь ласка, виберіть предмет", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentQuestionIndex = 0;
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            
            if (currentSubjectIndex >= 0 && currentSubjectIndex < subjects.Count)
            {
                
                List<Question> subjectQuestions = questions.Where(q => q.SubjectId == subjects[currentSubjectIndex].Id).ToList();

               
                if (currentQuestionIndex >= 0 && currentQuestionIndex < subjectQuestions.Count)
                {
                    Question currentQuestion = subjectQuestions[currentQuestionIndex];
                    
                    Box_test.Text = currentQuestion.Text;
                }
            }
        }

        private void Button_answer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Box_answer.Text))
            {
                MessageBox.Show("Будь ласка, введіть відповідь", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string userAnswer = Box_answer.Text;

          
            List<Question> subjectQuestions = questions.Where(q => q.SubjectId == subjects[currentSubjectIndex].Id).ToList();
            Question currentQuestion = subjectQuestions[currentQuestionIndex];

            
            if (currentQuestion.Answers.Any(a => a.Text.Equals(userAnswer, StringComparison.OrdinalIgnoreCase) && a.IsCorrect))
            {
                MessageBox.Show("Відповідь правильна", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Іспит не складений. Перездача через 2 дні.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }

      
            currentQuestionIndex++;
            Box_answer.Clear();
            DisplayQuestion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace vladik_kurs
{
    public partial class Form3 : MetroForm
    {
        private const string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Keyboard_treaning;Integrated Security=True";
        SqlCommand command;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string Login = textBox1.Text;
            string Password = textBox2.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string sqlQuery = "INSERT INTO r_users (r_login, r_parol) " +
                                      "VALUES (@r_login, @r_parol)";
                    using (command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@r_login", Login);
                        command.Parameters.AddWithValue("@r_parol", Password);
                    }
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Вы успешно зарегистрировались!");
                        Form1 frm1 = new Form1();
                        this.Hide();
                        frm1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось зарегистрировать нового пользователя.");
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
    }
}

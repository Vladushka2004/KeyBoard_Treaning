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
    public partial class Form2 : MetroForm
    {
        private const string ConnectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Keyboard_treaning;Integrated Security=True";
        SqlCommand command;
        public Form2()
        {
            InitializeComponent();
        }
        string Login, Password;
        string LoginDB, PasswordDB;
        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string Login = textBox1.Text;
            string Password = textBox2.Text;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string sqlQuery = "SELECT r_login, r_parol FROM r_users WHERE r_login = '" + Login + "'";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LoginDB = reader["r_login"].ToString();
                            PasswordDB = reader["r_parol"].ToString();
                        }
                    }
                }
                connection.Close();
            }
            if (Login == LoginDB && Password == PasswordDB)
            {
                Form4 frm4 = new Form4();
                this.Hide();
                frm4.Show();

            }
            else
            {
                MessageBox.Show("Вы ввели неправильные данные входа!");
            }
        }
        private void button2_Click(object sender, EventArgs e)
                {
                    Form1 frm1 = new Form1();
                    this.Hide();
                    frm1.Show();
                }
    }
}
    



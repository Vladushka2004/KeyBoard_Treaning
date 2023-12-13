using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Forms;
namespace vladik_kurs
{
    public partial class Form9 : MetroForm
    {
        string text = "In this ever-changing world, adaptation and innovation have become paramount. As we navigate through the intricacies of modern society,it is imperative to harness the power of technology and information.The synergy between humans and machines, the convergence of artificial intelligence and human intelligence,paves the way for a future where the boundaries between reality and virtuality blur. The quest for knowledge and the pursuit of excellence propel us forward in this age of information, where the very essence of humanity is redefined.";
        string[] words;
        int counter = 0;
        int correct = 0, wrong = 0;
        int seconds = 60;
        int myIndex = 0;
        DialogResult dialog;
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            myText.Enabled = false;
            exampleTextArea.ReadOnly = true;
            comboBox1.SelectedIndex = 0;
            dialog = new DialogResult();

            words = text.Split();
            for (int i = 0; i < words.Length; i++)
            {
                exampleTextArea.Text += words[i] + " ";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void myText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void exampleTextArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    seconds = 60;
                    break;
                case 1:
                    seconds = 120;
                    break;
                case 2:
                    seconds = 180;
                    break;
            }


            if (timer1.Enabled)
            {
                timer1.Stop();
                myText.Enabled = false;
                button1.Text = "СТАРТ";
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
            }
            else
            {
                timer1.Start();
                myText.Enabled = true;
                this.ActiveControl = myText;
                button1.Text = "СТОП";
                button1.BackColor = Color.Red;
                button1.ForeColor = Color.White;
            }
        }

        private void myText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {

                string writtenText = myText.Text.ToLower();
                myText.Clear();
                if ((sender as TextBox).SelectionStart == 0)
                {
                    e.Handled = (e.KeyChar == (char)Keys.Space);
                }
                else
                {
                    e.Handled = false;
                }


                if (counter >= words.Length)
                {
                    timer1.Stop();
                    button1.Text = "СТАРТ";
                    myText.Enabled = false;
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    lblCorrect.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    lblWrong.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    lblTotal.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    dialog = MessageBox.Show("Вы прошли уровень\n" + lblCorrect.Text + "\n" + lblWrong.Text + "\n" + lblTotal.Text, "Результат", MessageBoxButtons.OK);
                }

                else
                {
                    if (writtenText == words[counter].ToLower())
                    {
                        correct++;
                        lblCorrect.Text = "Правильно : " + correct.ToString();
                        exampleTextArea.Select(myIndex, words[counter].Length);
                        exampleTextArea.SelectionColor = Color.Green;
                        myIndex += words[counter].Length + 1;
                    }
                    else
                    {
                        wrong++;
                        lblWrong.Text = "Неправильно : " + wrong.ToString();
                        exampleTextArea.Select(myIndex, words[counter].Length);
                        exampleTextArea.SelectionColor = Color.Red;
                        myIndex += words[counter].Length + 1;


                    }



                    counter++;
                    lblTotal.Text = "Всего : " + counter.ToString();
                }
                if (counter > 145 && counter <= 146)
                {
                    exampleTextArea.Select(exampleTextArea.Text.Length - 1, 1);
                    exampleTextArea.ScrollToCaret();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            this.Hide();
            frm4.Show();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            lblTimer.Text = seconds.ToString();
            if (seconds == 0)
            {
                timer1.Stop();
                button1.Text = "СТАРТ";
                myText.Enabled = false;
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
                lblCorrect.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                lblWrong.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                lblTotal.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                dialog = MessageBox.Show("Время кончилось\n" + lblCorrect.Text + "\n" + lblWrong.Text + "\n" + lblTotal.Text, "Результат", MessageBoxButtons.OK);
                if (dialog == DialogResult.OK)
                {
                    button1.Enabled = false;
                    Thread.Sleep(5000);
                    Environment.Exit(0);
                }
                else
                {
                    button1.Enabled = false;
                    Thread.Sleep(5000);
                    Environment.Exit(0);
                }
            }
        }
    }
}

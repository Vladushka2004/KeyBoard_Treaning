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
    public partial class Form10 : MetroForm
    {
        string text = "Norman Gortsby was sitting on a bench hidden behind the bushes in Hyde Park. It was a warm May evening. The sun had already set and it was rather dark, but he could still make out the faces of the people who were walking past him and hear the sound of their voices. He was a philosopher, and liked sitting in the Park watching people whom he didn't know. While he was wondering who they were and where they were going, a young man came up to the bench, gave a quick look at him and threw himself down by his side. The newcomer was well-dressed and looked like a gentleman. His face was sad and he sighed deeply. You don't seem to be in a very good mood, said Norman. The young man was silent. He only looked at Norman again and there was an expression in his eyes that Norman didn't like.";
        string[] words;
        int counter = 0;
        int correct = 0, wrong = 0;
        int seconds = 60;
        int myIndex = 0;
        DialogResult dialog;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
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
                    
                }
                else
                {
                    button1.Enabled = false;
                    Thread.Sleep(5000);
                    
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
    }
}

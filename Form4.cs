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
namespace vladik_kurs
{
    public partial class Form4 : MetroForm
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            this.Hide();
            frm8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            this.Hide();
            frm9.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            this.Hide();
            frm10.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }
    }
}

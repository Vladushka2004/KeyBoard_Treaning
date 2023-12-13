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
using System.Diagnostics;
namespace vladik_kurs
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\\Users\\sraka\\Desktop\\Влад\\cправка"; 
                ProcessStartInfo open_dokument  = new ProcessStartInfo(filePath);
                open_dokument.UseShellExecute = true;
                Process.Start(open_dokument);
             
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


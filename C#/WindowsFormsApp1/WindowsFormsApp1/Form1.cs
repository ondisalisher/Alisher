using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            int calculator1 = Convert.ToInt32(text1);

            string text2 = textBox2.Text;
            int calculator2 = Convert.ToInt32(text2);

            button2_Click

            label1.Text = text;

            //MessageBox.Show(text , "Рандом");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

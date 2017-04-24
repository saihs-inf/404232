using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormstest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HI");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "hihihihi";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("404227");
        }
    }
}

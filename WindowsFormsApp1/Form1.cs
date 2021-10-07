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

            this.textBox1.Text = "10";
            this.textBox2.Text = "20";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(this.textBox1.Text);
            int b = int.Parse(this.textBox2.Text);
            double s = a * b;
            this.textBox3.Text = s.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form1 = new Form2();
            form1.ShowDialog();
        }
    }
}

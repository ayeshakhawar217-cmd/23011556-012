using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPAssignment02_Final_
{
    public partial class Cal : Form
    {
        public static List<string> history = new List<string>();
        public Cal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int res = num1 + num2;
            textBox3.Text = res.ToString();
            history.Add($"{num1} + {num2} = {res}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int res = num1 - num2;
            textBox3.Text = res.ToString();
            history.Add($"{num1} - {num2} = {res}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int res = num1 * num2;
            textBox3.Text = res.ToString();
            history.Add($"{num1} x {num2} = {res}");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int res = num1 / num2;
            textBox3.Text = res.ToString();
            history.Add($"{num1} / {num2} = {res}");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calhistory h1 = new Calhistory();
            h1.Show();
        }
    }
}

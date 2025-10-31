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
    public partial class ProdInv : Form
    {
        public ProdInv()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product p = new Product()
            {
                pId = int.Parse(textBox1.Text),
                pName = textBox2.Text,
                price = int.Parse(textBox3.Text),
                Qty = int.Parse(textBox4.Text)
            };

            Product.plist.Add(p);
            MessageBox.Show("Product added successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProdView pv = new ProdView();
            pv.Show();
        }
    }
}

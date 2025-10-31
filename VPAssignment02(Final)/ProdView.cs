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
    public partial class ProdView : Form
    {
        public ProdView()
        {
            InitializeComponent();
        }

        private void ProdView_Load(object sender, EventArgs e)
        {
            LoadInfo();
            dataGridView1.ReadOnly = false;
        }

        private void LoadInfo()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Product.plist;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int Index1 = dataGridView1.CurrentRow.Index;
                Product.plist.RemoveAt(Index1);
                MessageBox.Show("Record Deleted!");
                LoadInfo();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product Updated Successfully!");
        }
    }
}

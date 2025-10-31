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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = StudentData.Students;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                int Index = dataGridView1.CurrentRow.Index;
                StudentData.Students.RemoveAt(Index);
                LoadData();
                MessageBox.Show("Record Deleted!");
            }
        }
    }
}

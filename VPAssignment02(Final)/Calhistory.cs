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
    public partial class Calhistory : Form
    {
        public Calhistory()
        {
            InitializeComponent();
        }

        private void Calhistory_Load(object sender, EventArgs e)
        {
            foreach (var item in Cal.history)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}

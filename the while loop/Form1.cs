using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_while_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int start = 1;
            while (start <= 10)
            {
               int label1 = start;
                start++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

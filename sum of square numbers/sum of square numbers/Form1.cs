using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sum_of_square_numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            for (int i = 0; i < 101; i++)
            {
                num1 += i * i;
                num2 += i;
            }
            int total;
            total = (num2 * num2) - num1;
            MessageBox.Show(total.ToString());
          

        }
    }
}

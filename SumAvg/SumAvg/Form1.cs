using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumAvg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDecimal(textBox1.Text);
            var b = Convert.ToDecimal(textBox2.Text);
            var c = Convert.ToDecimal(textBox3.Text);
            var d = Convert.ToDecimal(textBox4.Text);
            var i = Convert.ToDecimal(textBox5.Text);

            var sum = a + b + c + d + i;
            var avg = (a + b + c + d + i) / 5;
            var perc = (sum / 500) * 100;
            


            textBox6.Text = sum.ToString();
            textBox7.Text = avg.ToString();
            textBox8.Text = perc.ToString();

            if(perc >= 85)
            {
                textBox9.Text = "A";
            }
            else if (perc >=65 )
            {
                textBox9.Text = "B";
            }
            else
            {
                textBox9.Text = "C";
            }


        }
    }
}

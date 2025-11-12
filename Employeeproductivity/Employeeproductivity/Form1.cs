using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employeeproductivity
{
    public partial class Form1 : Form
    {
        BindingList<Staff> stafflist = new BindingList<Staff>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            var name = textBox1.Text;
            var task = textBox2.Text;
            var stdate = textBox3.Text;
            var endate = textBox4.Text;

            var res = "Name: "+name + Environment.NewLine + "Task: " + task + Environment.NewLine + "Start Time: " + stdate + Environment.NewLine +  "End Time: " + endate;

            textBox5.Text = res;
            */

            Staff obj = new Staff();
            obj.staffname = textBox1.Text;
            obj.task = textBox2.Text;
            obj.stdate = textBox3.Text;
            obj.endate = textBox4.Text;
            obj.qua = Convert.ToString(textBox6.Text);

            // var show = obj.staffname + obj.task + obj.stdate + obj.endate + obj.qua;

            // textBox5.Text = show;

            stafflist.Add(obj);
            MessageBox.Show("Data Inserted.");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "staffname";
            comboBox1.DataSource = stafflist;

            comboBox2.DisplayMember = "task";
            comboBox2.DataSource = stafflist;

            comboBox3.DisplayMember = "qua";
            comboBox3.DataSource = stafflist;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Staff vc = new Staff();
            vc = (Staff)comboBox1.SelectedItem;
            textBox1.Text = vc.staffname;
            textBox2.Text = vc.task;
            textBox3.Text = vc.stdate;
            textBox4.Text = vc.endate;
            textBox6.Text = vc.qua;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Staff vc = new Staff();
            vc = (Staff)comboBox1.SelectedItem;
            stafflist.Remove(vc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox6.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            this.Hide();
        }
    }
    public class Staff
    {
        public string staffname { get; set; }
        public string task { get; set; }
        public string stdate { get; set; }
        public string endate { get; set; }
        public string qua { get; set; }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // DATABASE CONNECTIVITY

namespace Employeeproductivity
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = @"Server=SJCHS-LAB2-217\SQLEXPRESS; Database=stjohn_clg; Integreated Security=True";
            string query = "INSERT INTO TEST(ID,TESTNAME) VALUES (@ID,@NAME)";
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {

            }
        }
    }
}

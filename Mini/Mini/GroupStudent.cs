using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Mini
{
    public partial class GroupStudent : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter prog;
        public GroupStudent()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupid_Validating(object sender, CancelEventArgs e)
        {
            Regex validator = new Regex("^[0-9]$");
            string match = validator.Match(groupid.Text).Value.ToString();
            if (match.Length != 11)
            {
                MessageBox.Show("invalid phone number. Enter 0-11 digits");
                groupid.Focus();

            }

        }

        private void regno_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(regno.Text, "^[0-9]{4}-[A-Z]{2}-[0-9]{2,3}$").Success)
            {

                MessageBox.Show("Please Enter Registration Number  of the format 2016-CE-62");
                regno.SelectAll();
                e.Cancel = true;

            }
        }
    }
}

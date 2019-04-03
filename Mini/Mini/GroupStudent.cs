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
        private void DisplayData()
        {

            DataTable dt = new DataTable();
            prog = new SqlDataAdapter("select * FROM GroupStudent", conn);
            prog.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        string status;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBox1.Checked)
            {
                status = "Active";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (groupid.Text != "" && regno.Text != "" )
            {

                cmd = new SqlCommand("insert into GroupStudent(GroupId,StudentId,Status,AssignmentDate) values((SELECT Id FROM [Group] WHERE Id = @groupid),(SELECT Id FROM Student WHERE RegistrationNo = @regno),(SELECT Id FROM Lookup WHERE Category = 'STATUS' AND value =@sta) , @DESP)", conn);
                conn.Open();
                
                cmd.Parameters.AddWithValue("@GROUPID", groupid.Text);
                cmd.Parameters.AddWithValue("@regno", regno.Text);
                cmd.Parameters.AddWithValue("@DESP", DateTime.Now);
                cmd.Parameters.AddWithValue("@sta", status);
                cmd.ExecuteNonQuery();
               
                conn.Close();
                DisplayData();
                MessageBox.Show("Data Inserted Successfully");

            }

        }

        private void groupid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupid_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(groupid.Text, "^[0-9]$").Success)
            {

                MessageBox.Show("Please Enter digits only");
                groupid.SelectAll();
                e.Cancel = true;

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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                status = "InActive";
            }

        }

        private void GroupStudent_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
    }
}

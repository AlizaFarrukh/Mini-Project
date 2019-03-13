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
    public partial class Student : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter prog;
        int Id = 0;

        public Student()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            prog = new SqlDataAdapter("select * from Person", conn);
            prog.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void ClearData()
        {
            firstNameT.Text = "";
            LastNameT.Text = "";
            contactT.Text = "";
            emailT.Text = "";
            dobT.Text = "";
            genderT.Text = "";
            Id = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gendercombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        private int GetGenderFromLookup(string gen)
        {
            int value = 0;
            string q;
            if (gen == "Male")
                q = "SELECT Id FROM Lookup where Category = 'GENDER' AND Value = '"+gen+"'";
            else
                q = "SELECT Id FROM Lookup where Category = 'GENDER' AND Value = 'Female'";
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
                SqlCommand cmd = new SqlCommand(q, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    value = int.Parse(reader[0].ToString());
                }     
            
            return value;
        }


        private void addB_Click(object sender, EventArgs e)
        {
            if (firstNameT.Text != "" && LastNameT.Text != "" && contactT.Text != "" && emailT.Text != "" && dobT.Text != "" && genderT.Text != "" && regNoT.Text != "")
            {
                cmd = new SqlCommand("insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values(@FirstName,@LastName,@Contact,@Email,@DateOfBirth,@gender)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@FirstName", firstNameT.Text);
                cmd.Parameters.AddWithValue("@LastName", LastNameT.Text);
                cmd.Parameters.AddWithValue("@Contact", contactT.Text);
                cmd.Parameters.AddWithValue("@Email", emailT.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse( dobT.Text));
                string g = genderT.Text.ToString();
                int gender = GetGenderFromLookup(g);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Inserted Successfully");
                DisplayData();
                ClearData();

            }
            else
            {
                MessageBox.Show("Please Enter Details!");
            }
        }

        private void updateB_Click(object sender, EventArgs e)
        {
            if (firstNameT.Text != "" && LastNameT.Text != "" && contactT.Text != "" && emailT.Text != "" && dobT.Text != "")
            {
                cmd = new SqlCommand("update Person set FirstName=@firstName,LastName=@lastName, Contact=@Contact, Email=@email, DateOfBirth=@dob, Gender=@gender where Id=@id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@firstName", firstNameT.Text);
                cmd.Parameters.AddWithValue("@lastName", LastNameT.Text);
                cmd.Parameters.AddWithValue("@Contact", contactT.Text);
                cmd.Parameters.AddWithValue("@email", emailT.Text);
                cmd.Parameters.AddWithValue("@dob", dobT.Text);
                string g = genderT.Text.ToString();
                int gender = GetGenderFromLookup(g);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");
                conn.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Data to Update");
            }
        }

        private void FN_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
        private void dob_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                cmd = new SqlCommand("delete Person where ID=@id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Data to Delete");
            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            firstNameT.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            LastNameT.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            contactT.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            emailT.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            dobT.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            genderT.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void emailT_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(emailT.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter valid Email address");
                emailT.SelectAll();
                e.Cancel = true;
            }
        }

        private void firstNameT_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(firstNameT.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // first name was incorrect
                MessageBox.Show("Please Enter Valid First name");
                firstNameT.Focus();
                e.Cancel = true;
                
            }

        }

        private void LastNameT_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(LastNameT.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // first name was incorrect
                MessageBox.Show("Please Enter Valid Last Name");
                LastNameT.SelectAll();
                e.Cancel = true;

            }
        }

        private void contactT_Validating(object sender, CancelEventArgs e)
        {

            Regex validator = new Regex("^[0-9]{10,12}$");
            string match = validator.Match(contactT.Text).Value.ToString();
            if (match.Length != 11)
            {
                MessageBox.Show("invalid phone number. Enter 0-11 digits");
                contactT.Focus();

            }
        }

        private void contactT_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void emailT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
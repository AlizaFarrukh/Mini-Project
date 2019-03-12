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

namespace Mini
{
    public partial class Person : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter prog;
        int Id = 0;
        public Person()
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
            Id = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gendercombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        


        private void addB_Click(object sender, EventArgs e)
        {
            if (firstNameT.Text != "" && LastNameT.Text != "" && contactT.Text != "" && emailT.Text != "" && dobT.Text != "")
            {
                cmd = new SqlCommand("insert into Person(FirstName,LastName,Contact,Email,DateOfBirth) values(@FirstName,@LastName,@Contact,@Email,@DateOfBirth)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@FirstName", firstNameT.Text);
                cmd.Parameters.AddWithValue("@LastName", LastNameT.Text);
                cmd.Parameters.AddWithValue("@Contact", contactT.Text);
                cmd.Parameters.AddWithValue("@Email", emailT.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", dobT.Text);
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
                cmd = new SqlCommand("update Person set FirstName=@firstName,LastName=@lastName, Contact=@Contact, Email=@email, DateOfBirth=@dob where Id=@id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@firstName", firstNameT.Text);
                cmd.Parameters.AddWithValue("@lastName", LastNameT.Text);
                cmd.Parameters.AddWithValue("@Contact", contactT.Text);
                cmd.Parameters.AddWithValue("@email", emailT.Text);
                cmd.Parameters.AddWithValue("@dob", dobT.Text);
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
        }
    }
}
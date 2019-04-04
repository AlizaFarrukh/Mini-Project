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
    public partial class Advisor : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter prog;
        int Id = 0;
        public Advisor()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {
            
            DataTable dt = new DataTable();
            prog = new SqlDataAdapter("select Person.Id,FirstName,LastName, Contact, Email, DateOfBirth,Gender, Designation,Salary from Person join Advisor on Person.Id = Advisor.Id", conn);
            prog.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void ClearData()
        {
            FNT.Text = "";
            LNT.Text = "";
            CONT.Text = "";
            EMAILT.Text = "";
            
            DOBT.Text = "";
            GENT.Text = "";
            DESGT.Text = "";
            SALARYT.Text = "";

            Id = 0;
        }


        private void CONT_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private int GetGenderFromLookup(string gen)
        {
            int value = 0;
            string q;
            if (gen == "Male")
                q = "SELECT Id FROM Lookup where Category = 'GENDER' AND Value = '" + gen + "'";
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
        private int GetDesignationFromLookup(string gen)
        {
            int value = 0;
            string q;
            if (gen == "Professor")
                q = "SELECT Id FROM Lookup where Category = 'DESIGNATION' AND Value = '" + gen + "'";
            else if (gen == " Associate Professor")
                q = "SELECT Id FROM Lookup where Category = 'DESIGNATION' AND Value = '" + gen + "'";
            else if (gen == "Assisstant Professor")
                q = "SELECT Id FROM Lookup where Category = 'DESIGNATION' AND Value = '" + gen + "'";
            else if (gen == "Lecturer")
                q = "SELECT Id FROM Lookup where Category = 'DESIGNATION' AND Value = '" + gen + "'";
            else
              
                q = "SELECT Id FROM Lookup where Category = 'DESIGNATION' AND Value = '" + gen + "'";

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



        private void adda_b_Click(object sender, EventArgs e)
        {
          
            conn.Open();
            string gender = GENT.SelectedItem.ToString();
            string genId = "select Id FROM Lookup WHERE Category = 'Gender' AND value ='" + gender + "'";
            SqlCommand genint = new SqlCommand(genId, conn);
            int v = 0;
            SqlDataReader reader = genint.ExecuteReader();
            while (reader.Read())
            {
                v = int.Parse(reader[0].ToString());
            }

            string designation = DESGT.SelectedItem.ToString();
            string desID = "select Id FROM Lookup WHERE Category = 'DESIGNATION' AND value ='" + designation + "'";
            SqlCommand desint = new SqlCommand(desID, conn);
            int v2 = 0;
            SqlDataReader reader1 = desint.ExecuteReader();
            while (reader1.Read())
            {
                v2 = int.Parse(reader1[0].ToString());
            }

            string per = "INSERT into Person(FirstName , LastName , Contact, Email , DateOfBirth , Gender) values ('" + FNT.Text + "' , '" + LNT.Text + "' , '" +CONT.Text + "' , '" + EMAILT.Text + "' , '" + DateTime.Parse(DOBT.Text) + "' , '" + v + "')";
            SqlCommand persi = new SqlCommand(per, conn);
            int ii = persi.ExecuteNonQuery();
            int value1 = 0;
            string query = "Select Id from Person where (Id = SCOPE_IDENTITY())";
            SqlCommand cmd = new SqlCommand(query, conn);
            var val = cmd.ExecuteScalar().ToString();
            value1 = int.Parse(val);
            string q = "insert into Advisor values('" + value1 + "','" + v2 + "','" + SALARYT.Text + "')";
            SqlCommand cmd1 = new SqlCommand(q, conn);
            int ji = cmd1.ExecuteNonQuery();
            
                MessageBox.Show("Advisor is Registered");
           
            DisplayData();
            conn.Close();
        }

        private void FNT_TextChanged(object sender, EventArgs e)
        {

        }

        private void FNT_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(FNT.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // first name was incorrect
                MessageBox.Show("Please Enter Valid First name");
                FNT.Focus();
                e.Cancel = true;

            }
        }

        private void LNT_Validating(object sender, CancelEventArgs e)
        {

            if (!Regex.Match(LNT.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                // first name was incorrect
                MessageBox.Show("Please Enter Valid Last name");
                LNT.SelectAll();
                e.Cancel = true;

            }
        }

        private void CONT_Validating(object sender, CancelEventArgs e)
        {
            Regex validator = new Regex("^[0-9]{10,12}$");
            string match = validator.Match(CONT.Text).Value.ToString();
            if (match.Length != 11)
            {
                MessageBox.Show("invalid phone number. Enter 0-11 digits");
                CONT.Focus();

            }
        }

        private void EMAILT_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(EMAILT.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                MessageBox.Show("Enter valid Email address");
                EMAILT.SelectAll();
                e.Cancel = true;
            }
        }

        private void SALARYT_Validating(object sender, CancelEventArgs e)
        {
            Regex validator = new Regex("^[0-9]{10,12}$");
            string match = validator.Match(CONT.Text).Value.ToString();
            if (match.Length > 7)
            {
                MessageBox.Show("invalid phone number. Enter 0-11 digits");
                CONT.Focus();

            }
        }

       

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
         //   FNT.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
           // LNT.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
           // CONT.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
         //   EMAILT.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
           //DOBT.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        //    GENT.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
          //  DESGT.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
          //  SALARYT.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

        }

        private void updatea_b_Click(object sender, EventArgs e)
        {
            if (FNT.Text != "" && LNT.Text != "" && CONT.Text != "" && EMAILT.Text != "" && DOBT.Text != "" && GENT.Text != "" && DESGT.Text != "" && SALARYT.Text != "")
            {
                cmd = new SqlCommand("update Person set FirstName=@firstName,LastName=@lastName, Contact=@Contact, Email=@email, DateOfBirth=@dob, Gender=@gender where Id=@id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@firstName", FNT.Text);
                cmd.Parameters.AddWithValue("@lastName", LNT.Text);
                cmd.Parameters.AddWithValue("@Contact", CONT.Text);
                cmd.Parameters.AddWithValue("@email", EMAILT.Text);
                cmd.Parameters.AddWithValue("@dob", DOBT.Text);
                string g = GENT.Text.ToString();
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

        private void deletea_b_Click(object sender, EventArgs e)
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

        private void Advisor_Load(object sender, EventArgs e)
        {
            DisplayData();
           
        }

        private void SALARYT_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
        }
    }
}

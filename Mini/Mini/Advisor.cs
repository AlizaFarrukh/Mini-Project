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
            conn.Open();
            DataTable dt = new DataTable();
            prog = new SqlDataAdapter("select * from Person", conn);
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
        private void adda_b_Click(object sender, EventArgs e)
        {
            if (FNT.Text != "" && LNT.Text != "" && CONT.Text != "" && EMAILT.Text != "" && DOBT.Text != "" && GENT.Text != "" && DESGT.Text != "" && SALARYT.Text != "")
            {
                cmd = new SqlCommand("insert into Person(FirstName,LastName,Contact,Email,DateOfBirth,Gender) values(@FirstName,@LastName,@Contact,@Email,@DateOfBirth,@gender)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@FirstName", FNT.Text);
                cmd.Parameters.AddWithValue("@LastName",LNT.Text);
                cmd.Parameters.AddWithValue("@Contact", CONT.Text);
                cmd.Parameters.AddWithValue("@Email", EMAILT.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(DOBT.Text));
                string g = GENT.Text.ToString();
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
    }
}

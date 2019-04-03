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
    public partial class Evaluation : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter prog;
        int Id = 0;
        public Evaluation()
        {
            InitializeComponent();
        }

        private void NameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTB_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(NameTB.Text, "^([A-Za-z])+( [A-Za-z]+)$").Success )
            {
                
                MessageBox.Show("Please Enter Valid Name.  It must start with Capital Letter");
                NameTB.Focus();
                e.Cancel = true;

            }
        }

        private void totalmarksTB_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(totalmarksTB.Text, "^[0-9]{1,2}$").Success)
            {

                MessageBox.Show("Please Enter Total marks from 0-100");
                totalmarksTB.SelectAll();
                e.Cancel = true;

            }
        }

        private void weightageTB_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.Match(weightageTB.Text, "^[0-9]{2}$").Success)
            {

                MessageBox.Show("Please Enter Weightage from 0-100");
                weightageTB.SelectAll();
                e.Cancel = true;

            }
        }
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            prog = new SqlDataAdapter("select * from Evaluation", conn);
            prog.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void ClearData()
        {
            NameTB.Text = "";
            totalmarksTB.Text = "";
            weightageTB.Text = "";
            Id = 0;
        }
        private void AddB_Click(object sender, EventArgs e)
        {
            if (NameTB.Text != "" && totalmarksTB.Text != "" && weightageTB.Text != "")
            {
                cmd = new SqlCommand("insert into Evaluation(Name, TotalMarks, TotalWeightage) values(@name,@totalm,@weightage)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@name", NameTB.Text);
                cmd.Parameters.AddWithValue("@totalm", totalmarksTB.Text);
                cmd.Parameters.AddWithValue("@weightage", weightageTB.Text);

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

        private void UpdateB_Click(object sender, EventArgs e)
        {
            if (NameTB.Text != "" && totalmarksTB.Text != "" && weightageTB.Text != "")
            {
                cmd = new SqlCommand("update Evaluation set Name=@name,TotalMarks=@marks, TotalWeightage = @weight where Id=@id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@name", NameTB.Text);
                cmd.Parameters.AddWithValue("@marks", totalmarksTB.Text);
                cmd.Parameters.AddWithValue("@weight", weightageTB.Text);

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

        private void DeleteB_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                cmd = new SqlCommand("delete Evaluation where ID=@id", conn);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            NameTB.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            totalmarksTB.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            weightageTB.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void Evaluation_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void totalmarksTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

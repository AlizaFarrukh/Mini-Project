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
    public partial class Project : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter prog;
        int Id = 0;
        public Project()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void descTb_TextChanged(object sender, EventArgs e)
        {

        }
        private void DisplayData()
        {
            conn.Open();
            DataTable dt = new DataTable();
            prog = new SqlDataAdapter("select Id, Title, Description from Project", conn);
            prog.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void ClearData()
        {
            titleTB.Text = "";
            descTb.Text = "";
            
            Id = 0;
        }

        private void AddB_Click(object sender, EventArgs e)
        {
            if (titleTB.Text != "" && descTb.Text != "" )
            {
                cmd = new SqlCommand("insert into Project(Description,Title) values(@description,@title)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@description", descTb.Text);
                cmd.Parameters.AddWithValue("@title", titleTB.Text);
                
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

            if (titleTB.Text != "" && descTb.Text != "")
            {
                cmd = new SqlCommand("update Project set Description=@desc,Title=@title where Id=@id", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@desc", descTb.Text);
                cmd.Parameters.AddWithValue("@title",titleTB.Text);
                
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

        private void personBH_Click(object sender, EventArgs e)
        {

        }

        private void Project_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DeleteB_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                cmd = new SqlCommand("delete Project where ID=@id", conn);
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
            titleTB.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            descTb.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            
        }

        private void titleTB_Validating(object sender, CancelEventArgs e)
        {
            
        }
    }
}

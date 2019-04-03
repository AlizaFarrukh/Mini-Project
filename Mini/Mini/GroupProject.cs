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
    public partial class GroupProject : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter prog;
        public GroupProject()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {

            DataTable dt = new DataTable();
            prog = new SqlDataAdapter("select  Project.Title, GroupProject.GroupId , GroupProject.AssignmentDate FROM Project join GroupProject on Project.Id = GroupProject.ProjectId  ", conn);
            prog.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void GroupProject_Load(object sender, EventArgs e)
        {
            DisplayData();
            SqlDataAdapter s = new SqlDataAdapter("Select Title FROM Project", conn);
            DataTable dt = new DataTable();
            s.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                projectid.Items.Add(dt.Rows[i]["Title"]);
            }
            SqlDataAdapter sd = new SqlDataAdapter("Select Id FROM [Group]", conn);
            DataTable d = new DataTable();
            sd.Fill(d);
            for (int i = 0; i < d.Rows.Count; i++)
            {
                groupid.Items.Add(d.Rows[i]["Id"]);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (groupid.Text != "" && projectid.Text != "")
            {
                conn.Open();


                string q = "INSERT into GroupProject(ProjectId,GroupId,AssignmentDate) VALUES (  (Select Id FROM Project WHERE Title = '" + projectid.Text + "'), (SELECT Id FROM [Group] WHERE Id = '" + groupid.Text + "'), '" + DateTime.Now + "')";

                SqlCommand cmd = new SqlCommand(q, conn);
                
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data Added Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();

            }
            else
                MessageBox.Show("Enter Data to insert");
        }
    }
 }

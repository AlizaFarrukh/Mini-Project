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
    public partial class ProjecAdvisor : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter prog;
        public ProjecAdvisor()
        {
            InitializeComponent();
        }
        private void DisplayData()
        {

            DataTable dt = new DataTable();
            prog = new SqlDataAdapter("select (ProjectAdvisor.AdvisorId), Project.Title, AdvisorRole FROM Project join ProjectAdvisor on Project.Id = ProjectAdvisor.ProjectId  ", conn);
            prog.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProjecAdvisor_Load(object sender, EventArgs e)
        {
            DisplayData();
            SqlDataAdapter s = new SqlDataAdapter("Select Title FROM Project", conn);
            DataTable dt = new DataTable();
            s.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                title.Items.Add(dt.Rows[i]["Title"]);
            }
            SqlDataAdapter sd = new SqlDataAdapter("Select Id FROM Advisor", conn);
            DataTable d = new DataTable();
            sd.Fill(d);
            for (int i = 0; i < d.Rows.Count; i++)
            {
                id.Items.Add(d.Rows[i]["Id"]);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("SELECT COUNT(1) FROM ProjectAdvisor WHERE (AdvisorId = '" + id.Text + " ')", conn);
            object countstd1 = cmd.ExecuteScalar();
            int countstd = 0;
            if (!(countstd1 == DBNull.Value))
            {
                countstd = Convert.ToInt32(countstd1);
            }

            conn.Close();
            if (countstd == 3)
            {

                MessageBox.Show("No more projects can be advised by this advisor because advisor is already advising 3 projects.");
            }

            else
            {
                if (id.Text != "" && title.Text != "" && role.Text != "")
                {
                    conn.Open();


                    string q = "INSERT into ProjectAdvisor(AdvisorId, ProjectId, AdvisorRole, AssignmentDate) VALUES ( (SELECT Id FROM Advisor WHERE Advisor.Id = '" + id.Text + "' ), (Select Id FROM Project WHERE Title = '" + title.Text + "'), (SELECT Id FROM Lookup WHERE Category = 'ADVISOR_ROLE' AND Value = '" + role.Text + "'), '" + DateTime.Now + "')";

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

        private void button1_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
        }
    }
}

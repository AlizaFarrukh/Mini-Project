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
    public partial class GroupEvaluation : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter prog;
        public GroupEvaluation()
        {
            InitializeComponent();
        }

        private void GroupEvaluation_Load(object sender, EventArgs e)
        {
            DisplayData();
            SqlDataAdapter sa = new SqlDataAdapter("Select * FROM [Group]", conn);
            DataTable dt = new DataTable();
            sa.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                groupid.Items.Add(dt.Rows[i]["Id"]);
            }

            SqlDataAdapter SDA1 = new SqlDataAdapter("Select Name FROM Evaluation", conn);
            DataTable dt1 = new DataTable();
            SDA1.Fill(dt1);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                evaluation.Items.Add(dt1.Rows[i]["Name"]);
            }


        }
        private void DisplayData()
        {

            DataTable dt = new DataTable();
            prog = new SqlDataAdapter("select GroupEvaluation.GroupId , Evaluation.Name,  GroupEvaluation.ObtainedMarks FROM Evaluation  join GroupEvaluation on Evaluation.Id = GroupEvaluation.EvaluationId  ", conn);
            prog.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {

            if (marks.Text != "" && groupid.Text != "" && evaluation.Text !="")
            {
                conn.Open();


                string query = "INSERT into GroupEvaluation(GroupId, EvaluationId, ObtainedMarks, EvaluationDate) VALUES ( (SELECT Id FROM [Group] WHERE [Group].Id = '" + groupid.Text + "' ), (Select Id FROM Evaluation WHERE Evaluation.Name = '" + evaluation.Text + "'),'" +obtained.Text + "', '" + DateTime.Now + "')";

                SqlCommand cmd = new SqlCommand(query, conn);




                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data saved Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisplayData();

            }
            else
                MessageBox.Show("Fill all the Fields", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void update_Click(object sender, EventArgs e)
        {
            
        }

        private void addB_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
        }
    }
}

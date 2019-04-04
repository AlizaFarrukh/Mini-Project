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
    public partial class Group : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=ProjectA;MultipleActiveResultSets=true;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter prog;
        public Group()
        {
            InitializeComponent();
        }

        private void totalmarksTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void createdOn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addB_Click(object sender, EventArgs e)
        {


            conn.Open();
            string p = "insert into [Group] (Created_On) values( '" + DateTime.Parse(createdOn.Text) + "')";

            SqlCommand cmd = new SqlCommand(p, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Group Created Successfully");








        }

        private void button1_Click(object sender, EventArgs e)
        {
            GroupStudent st = new GroupStudent();
            st.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
        }
    }
}

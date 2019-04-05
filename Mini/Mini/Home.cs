using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student home = new Student();
            home.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Advisor AD = new Advisor();
            AD.Show();
        }

        private void projectB_Click(object sender, EventArgs e)
        {
            Project pr = new Project();
            pr.Show();
        }

        private void evaluation_Click(object sender, EventArgs e)
        {
            Evaluation eva = new Evaluation();
            eva.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Group G = new Group();
            G.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProjecAdvisor pj = new ProjecAdvisor();
            pj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GroupProject gp = new GroupProject();
            gp.Show();
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            GroupEvaluation GE = new GroupEvaluation();
            GE.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GenerateReport GR = new GenerateReport();
            GR.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ViewReport v = new ViewReport();
            v.Show();
        }
    }
}

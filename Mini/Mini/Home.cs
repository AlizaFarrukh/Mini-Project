﻿using System;
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
    }
}

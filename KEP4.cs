﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace setupevent00
{
    public partial class KEP4 : Form
    {
        public KEP4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pakages pakages = new Pakages();
            this.Hide();
            pakages.Show();
        }

        private void KEP4_Load(object sender, EventArgs e)
        {

        }
    }
}

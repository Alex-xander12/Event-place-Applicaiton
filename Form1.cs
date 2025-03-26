using System;
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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Padding = new Padding(
                (this.ClientSize.Width - groupBox1.Width) / 2,
                (this.ClientSize.Height - groupBox1.Height) / 2,
                0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Gallery gallery = new Gallery();
            this.Hide();
            gallery.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pakages pakages = new Pakages();
            this.Hide();
            pakages.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminCorner form6 = new AdminCorner();
            this.Hide();
            form6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inventory Inventory = new inventory();
            this.Hide();
            Inventory.Show();

        }
    }
}

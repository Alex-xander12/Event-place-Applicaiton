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
    public partial class Pakages : Form
    {
        public Pakages()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pakages1 pakages1 = new Pakages1();
            this.Hide();
            pakages1.Show();
        }

        private void KEP3_Click(object sender, EventArgs e)
        {
            KEP3 kep3 = new KEP3();
            this.Hide();
            kep3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pakages1 pakages1 = new Pakages1();
            this.Hide();
            pakages1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pakages1 pakages1 = new Pakages1();
            this.Hide();
            pakages1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pakages1 pakages1 = new Pakages1();
            this.Hide();
            pakages1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Pakages_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            KEP1 kep1 = new KEP1();
            this.Hide();
            kep1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KEP2 kep2 = new KEP2();
            this.Hide();
            kep2.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            KEP4 kep4 = new KEP4();
            this.Hide();
            kep4.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

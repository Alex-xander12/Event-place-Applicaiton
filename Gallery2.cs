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
    public partial class Gallery2 : Form
    {
        public Gallery2()
        {
            InitializeComponent();
            CenterControl(button1);
            CenterControl(button2);
            CenterControl(pictureBox1);
            CenterControl(pictureBox2);
            CenterControl(pictureBox3);
            CenterControl(pictureBox4);
        }

        private void CenterControl(Control control)
        {
            // Center the control on the form
            control.Anchor = AnchorStyles.None;
            control.Padding = new Padding(
                (this.ClientSize.Width - control.Width) / 2,
                (this.ClientSize.Height - control.Height) / 2,
                0, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gallery gallery = new Gallery();
            this.Hide();
            gallery.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gallery3 gallery3 = new Gallery3();
            this.Hide();
            gallery3.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Gallery2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

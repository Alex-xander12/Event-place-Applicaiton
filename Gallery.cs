using System;
using System.Windows.Forms;

namespace setupevent00
{
    public partial class Gallery : Form
    {
        public Gallery()
        {
            InitializeComponent();
            CenterControl(pictureBox1);
            CenterControl(pictureBox2);
            CenterControl(pictureBox3);
            CenterControl(pictureBox4);

            // Center the buttons
            CenterControl(button1);
            CenterControl(button2);
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

        private void Gallery1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gallery2 gallery2 = new Gallery2();
            this.Hide();
            gallery2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "PREVIOUS";
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
 
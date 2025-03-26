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
    public partial class Gallery3 : Form
    {
        public Gallery3()
        {
            InitializeComponent();
            CenterControl(button1);
            CenterControl(pictureBox1);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gallery2 gallery2 = new Gallery2();
            this.Hide();
            gallery2.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form3 : Form
    {
        private string clientName;
        private string phoneNumber;
        private string packageName;
        private decimal packagePrice;
        public Form3()
        {
            InitializeComponent();
        }

        public void Form3_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Format("Client Name: {0}\nPhone Number: {1}\nPackage: {2}\nPackage Price: {3}", clientName, phoneNumber, packageName, packagePrice);
        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void SetClientInformation(string clientName, string phoneNumber, string packageName)
        {
            // Store the received data in class-level variables or properties
            this.clientName = clientName;
            this.phoneNumber = phoneNumber;
            this.packageName = packageName;
            this.packagePrice = packagePrice;
        }
    }
}

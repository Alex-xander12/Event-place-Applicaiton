using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace setupevent00
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void generate_Click(object sender, EventArgs e)
        {
            receipt.Clear();
            receipt.Text += "*****************************************************\n";
            receipt.Text += "**          KABSU EVENT & PLACE RECEIPT            **\n";
            receipt.Text += "*****************************************************\n";
            receipt.Text += "DATE:  " + DateTime.Now + " \n\n";


            receipt.Text += "Client Name: " + full_Name.Text + "\n\n";
            receipt.Text += "Phone Number: " + phone_Number.Text + "\n\n";
            receipt.Text += "Event Name: " + event_Name.Text + "\n\n";
            receipt.Text += "Event Type: " + event_Type.Text + "\n\n";
            receipt.Text += "Event Date: " + event_Date.Text + "\n\n";
            receipt.Text += "Packages: " + Packages.Text + "\n\n";
            receipt.Text += "No. Of Guest: " + guest_Number.Text + "\n\n";
            receipt.Text += "Fees: " + fees.Text + "\n\n";


            receipt.Text += "Thank you for choosing KABSU EVENT & PLACE and enjoy your stay :>";

            // Validate input fields
            if (string.IsNullOrWhiteSpace(full_Name.Text) ||
                string.IsNullOrWhiteSpace(phone_Number.Text) ||
                string.IsNullOrWhiteSpace(event_Name.Text) ||
                string.IsNullOrWhiteSpace(event_Type.Text) ||
                string.IsNullOrWhiteSpace(event_Date.Text) ||
                string.IsNullOrWhiteSpace(Packages.Text) ||
                string.IsNullOrWhiteSpace(guest_Number.Text) ||
                string.IsNullOrWhiteSpace(fees.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if any required field is blank
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // User clicked Yes, proceed with clearing the fields
                full_Name.Text = "";
                phone_Number.Text = "";
                event_Name.Text = "";
                event_Type.Text = "";
                event_Date.Text = "";
                Packages.Text = "";
                guest_Number.Text = "";
                fees.Text = "";
                receipt.Text = "";

                full_Name.Clear();
                phone_Number.Clear();
                event_Name.Clear();
                event_Type.SelectedIndex = -1;
                event_Date.Clear();
                Packages.SelectedIndex = -1;
                guest_Number.Clear();
                fees.SelectedIndex = -1;
            }
            
        }
        private void print_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=clients;User ID=root;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Your SQL query to insert data into the database
                    string query = "INSERT INTO clientinfo (client_Name, phone_Number, event_Name, event_Type, event_Date, Packages, guest_Number, fees) " +
                                    "VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Replace these with your actual parameter names and values
                        cmd.Parameters.AddWithValue("@value1", full_Name.Text);
                        cmd.Parameters.AddWithValue("@value2", phone_Number.Text);
                        cmd.Parameters.AddWithValue("@value3", event_Name.Text);
                        cmd.Parameters.AddWithValue("@value4", event_Type.Text);
                        cmd.Parameters.AddWithValue("@value5", DateTime.Parse(event_Date.Text));
                        cmd.Parameters.AddWithValue("@value6", Packages.Text);

                        int guestNumber, feesValue;
                        if (int.TryParse(guest_Number.Text, out guestNumber))
                            cmd.Parameters.AddWithValue("@value7", guestNumber);
                        else
                        {
                            MessageBox.Show("Invalid value for guest number.");
                            return;
                        }

                        if (int.TryParse(fees.Text, out feesValue))
                            cmd.Parameters.AddWithValue("@value8", feesValue);
                        else
                        {
                            MessageBox.Show("Invalid value for fees.");
                            return;
                        }

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registration Successful!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(receipt.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            inventory Inventory = new inventory();
            this.Hide();
            Inventory.Show();
        }
    }
}
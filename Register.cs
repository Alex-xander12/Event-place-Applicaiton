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
   
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) ||
                string.IsNullOrWhiteSpace(comboBox1.Text) ||
                string.IsNullOrWhiteSpace(comboBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if any required field is blank
            }

            // Replace these values with your actual MySQL database connection details
            string connectionString = "Server=localhost;Database=clientinfo;User ID=root;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Your SQL query to insert data into the database
                    string query = "INSERT INTO clients (client_Name, phone_Number, event_Date, event_Name, event_Type, guest_Number, package) " +
                "VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Replace these with your actual parameter names and values
                        cmd.Parameters.AddWithValue("@value1", textBox1.Text); // Assuming client_Name is a string
                        cmd.Parameters.AddWithValue("@value2", (textBox3.Text)); // Assuming phone_Number 
                        cmd.Parameters.AddWithValue("@value3", DateTime.Parse(textBox4.Text)); // Assuming event_Date is a Date
                        cmd.Parameters.AddWithValue("@value4", textBox2.Text); // Assuming event_Name is a string
                        cmd.Parameters.AddWithValue("@value5", comboBox1.Text); // Assuming event_Type is selected from a combo box
                        cmd.Parameters.AddWithValue("@value6", int.Parse(textBox6.Text)); // Assuming guest_Number is an int
                        cmd.Parameters.AddWithValue("@value7", comboBox2.Text); // Assuming package is a string

                        decimal packagePrice = GetPackagePrice(comboBox2.Text);
                        packagePrice = packagePrice;

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registration Successful!");

                        // Clear the input fields
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        comboBox1.SelectedIndex = -1; // Assuming you want to clear the selection in the comboBox
                        textBox4.Clear();
                        comboBox2.SelectedIndex = -1;
                        textBox6.Clear();

                        // Open Form2 and pass the data
                        Form2 form2 = new Form2();
                        form2.LoadData();

                        Form3 form3 = new Form3();
                        form3.SetClientInformation(textBox1.Text, textBox3.Text, comboBox2.Text);
                        form3.richTextBox1.Text = string.Format("Client Name: {0}\nPhone Number: {1}\nPackage: {2}\nPackage Price: {3}", textBox1.Text, textBox3.Text, comboBox2.Text, GetPackagePrice(comboBox2.Text));
                        form3.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public decimal GetPackagePrice(string packageName)
        {
            switch (packageName)
            {
                case "Package 1":
                    return 20000;
                case "Package 2":
                    return 25000;
                case "Package 3":
                    return 30000;
                case "Package 4":
                    return 35000;
                default:
                    return 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inventory Inventory = new inventory();
            this.Hide();
            Inventory.Show();
        }
    }

    }

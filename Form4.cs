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
using System.Globalization;

namespace setupevent00
{
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            string connectionString = "Server=localhost;Database=clientinfo1;User ID=root;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM inventory";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void inventory_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UpdateInventory(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateInventory(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void UpdateInventory(bool isAddition)
        {
            string connectionString = "Server=localhost;Database=clientinfo1;User ID=root;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if a row is selected
                    if (dataGridView1.SelectedRows.Count == 0)
                    {
                        MessageBox.Show("Please select a row.");
                        return;
                    }

                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Get the existing values directly from the selected row
                    int existingQuantity = Convert.ToInt32(selectedRow.Cells["quantity"].Value);
                    int existingQuantityInStock = Convert.ToInt32(selectedRow.Cells["quantity_in_stock"].Value);

                    // Log the existing values for debugging
                    Console.WriteLine($"Existing Quantity: {existingQuantity}, Existing Quantity in Stock: {existingQuantityInStock}");

                    // Get the values to add or subtract from the TextBoxes
                    if (!int.TryParse(textBox1.Text, out int quantity) ||
                        !int.TryParse(textBox2.Text, out int quantityInStock))
                    {
                        MessageBox.Show("Please enter valid quantities.");
                        return;
                    }

                    // Determine the operation based on the button clicked
                    string operation = isAddition ? "+" : "-";

                    // Update quantity based on the entered quantity
                    string query = $"UPDATE inventory SET quantity = @NewQuantity WHERE item_Id = @Id";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Calculate the new quantity
                        int newQuantity = isAddition ? existingQuantity + quantity : existingQuantity - quantity;

                        cmd.Parameters.AddWithValue("@NewQuantity", newQuantity);
                        cmd.Parameters.AddWithValue("@Id", selectedRow.Cells["item_Id"].Value);
                        cmd.ExecuteNonQuery();
                    }

                    // Update quantity_in_stock based on the entered quantityInStock
                    query = $"UPDATE inventory SET quantity_in_stock = @NewQuantityInStock WHERE item_Id = @Id";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        // Calculate the new quantity_in_stock
                        int newQuantityInStock = isAddition ? existingQuantityInStock + quantityInStock : existingQuantityInStock - quantityInStock;

                        cmd.Parameters.AddWithValue("@NewQuantityInStock", newQuantityInStock);
                        cmd.Parameters.AddWithValue("@Id", selectedRow.Cells["item_Id"].Value);
                        cmd.ExecuteNonQuery();
                    }

                    // Clear the TextBoxes after the update
                    textBox1.Text = "";
                    textBox2.Text = "";

                    // Reload the data after the update
                    LoadData();
                    MessageBox.Show($"Inventory updated for selected row: {operation}Quantity: {quantity}, Quantity in Stock: {quantityInStock}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

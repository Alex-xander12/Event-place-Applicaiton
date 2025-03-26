using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace setupevent00
{
    public partial class AdminCorner : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=localhost;Database=clients;User ID=root;";

        public AdminCorner()
        {
            InitializeComponent();
        }

        private void AdminCorner_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                string query = "SELECT * FROM clientinfo";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click event if needed
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.Show();
        }
    }
}

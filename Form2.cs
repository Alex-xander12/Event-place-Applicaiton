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
    public partial class Form2 : Form
    {
        private string connectionString;

        public Form2()
        {
            InitializeComponent();
            // Initialize your components and set up your form
            connectionString = GetConnectionString();
            LoadData();
        }

        public string GetConnectionString()
        {
            return "Server=localhost;Database=clientinfo;User ID=root;";
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM clients";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // You can add additional logic here if needed
        }
    }
}
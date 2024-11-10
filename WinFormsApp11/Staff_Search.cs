using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class Staff_Search : Form
    {

        private const string connectionString = "Data Source=DESKTOP-88LB4UV\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;";
        public Staff_Search()
        {
            InitializeComponent();
        }

        private void Staff_Search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string searchTerm = textBox1.Text.Trim();

            // Check if search term is empty
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            // Perform search and populate DataGridView
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Staff WHERE Name LIKE @SearchTerm";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

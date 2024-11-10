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
using System.Xml.Linq;

namespace WinFormsApp11
{
    public partial class Manage_packages : Form
    {
        public Manage_packages()
        {
            InitializeComponent();
        }
        private const string connectionString = "Data Source=DESKTOP-88LB4UV\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;";

        private void LoadPackages()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Packages";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) ||
                string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            // Insert new package into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Packages (Id, Name, CostPerPerson, Description, Complementary) " +
                               "VALUES (@Id, @Name, @CostPerPerson, @Description, @Complementary)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", textBox1.Text);
                    command.Parameters.AddWithValue("@Name", textBox2.Text);
                    command.Parameters.AddWithValue("@CostPerPerson", int.Parse(textBox3.Text));
                    command.Parameters.AddWithValue("@Description", textBox4.Text);
                    command.Parameters.AddWithValue("@Complementary", textBox5.Text);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Package added successfully.");
            LoadPackages();
            ClearFields();





        }

        private void Manage_packages_Load(object sender, EventArgs e)
        {
            LoadPackages();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please select a package to edit.");
                return;
            }

            // Update package in the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Packages SET Name = @Name, CostPerPerson = @CostPerPerson, " +
                               "Description = @Description, Complementary = @Complementary WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", textBox2.Text);
                    command.Parameters.AddWithValue("@CostPerPerson", int.Parse(textBox3.Text));
                    command.Parameters.AddWithValue("@Description", textBox4.Text);
                    command.Parameters.AddWithValue("@Complementary", textBox5.Text);
                    command.Parameters.AddWithValue("@Id", textBox5.Text);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Package updated successfully.");
            LoadPackages();
            ClearFields();






        }

        void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;

            // Add staff member to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"DELETE FROM Packages WHERE Id = @Id;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show(" Delete successfully.");
            ClearFields();

            void ClearFields()
            {
                textBox1.Clear();


            }



        }
    }
}

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
    public partial class Downlod : Form
    {
        private const string connectionString = "Data Source=DESKTOP-88LB4UV\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;";
        public Downlod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please select a reservation to download.");
                return;
            }

            // Fetch reservation details from the database based on reservationId
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Reservations WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Create a string containing reservation details
                            StringBuilder reservationDetails = new StringBuilder();
                            reservationDetails.AppendLine("Reservation Details:");
                            reservationDetails.AppendLine($"Reservation ID: {reader["Id"]}");
                            reservationDetails.AppendLine($"Full Name: {reader["FullName"]}");
                            reservationDetails.AppendLine($"Email: {reader["Email"]}");
                            reservationDetails.AppendLine($"Mobile: {reader["Mobile"]}");
                            reservationDetails.AppendLine($"Reservation Date: {reader["ReservationDate"]}");
                            reservationDetails.AppendLine($"Number of Pax: {reader["NumOfPax"]}");
                            reservationDetails.AppendLine($"Total Cost: {reader["TotalCost"]}");

                            // Save reservation details to a text file
                            string fileName = $"{id}_Reservation_Details.txt";
                            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
                            File.WriteAllText(filePath, reservationDetails.ToString());

                            MessageBox.Show($"Reservation details Download to {fileName}");
                        }
                        else
                        {
                            MessageBox.Show("Reservation not found.");
                        }
                    }
                }
            }
        }

        
    }
}


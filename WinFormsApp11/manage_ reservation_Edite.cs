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
    public partial class manage__reservation_Edite : Form
    {
        private const string connectionString = "Data Source=DESKTOP-88LB4UV\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;";

        public manage__reservation_Edite()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please select a reservation to edit.");
                return;
            }

            string fullName = textBox2.Text;
            string email = textBox3.Text;
            string mobile = textBox4.Text;
            DateTime reservationDate = dateTimePicker1.Value;
            int numOfPax;
            if (!int.TryParse(textBox6.Text, out numOfPax))
            {
                MessageBox.Show("Invalid number of pax.");
                return;
            }

            decimal totalCost = CalculateTotalCost(numOfPax);


             decimal CalculateTotalCost(int numOfPax)
            {
                decimal rate;
                if (numOfPax <= 15)
                    rate = 3000;
                else if (numOfPax <= 25)
                    rate = 2500;
                else if (numOfPax <= 50)
                    rate = 1500;
                else
                    rate = 1000;

                return numOfPax * rate;
            }

            void ClearFields()
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox6.Clear();
                dateTimePicker1.Value = DateTime.Today;
            }


            // Update reservation in the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Reservations 
                                 SET FullName = @FullName, Email = @Email, Mobile = @Mobile, 
                                     ReservationDate = @ReservationDate, NumOfPax = @NumOfPax, TotalCost = @TotalCost 
                                 WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Mobile", mobile);
                    command.Parameters.AddWithValue("@ReservationDate", reservationDate);
                    command.Parameters.AddWithValue("@NumOfPax", numOfPax);
                    command.Parameters.AddWithValue("@TotalCost", totalCost);
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Reservation updated successfully.");

            ClearFields();

        }

        // Other methods and event handlers...
    }





}
    


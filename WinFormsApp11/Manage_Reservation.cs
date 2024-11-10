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
    public partial class Manage_Reservation : Form
    {
        private const string connectionString = "Data Source=DESKTOP-88LB4UV\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;";
        public Manage_Reservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string fullName = textBox2.Text;
            string email = textBox3.Text;
            string mobile = textBox4.Text;
            DateTime reservationDate = dateTimePicker1.Value;
            int numOfPax = int.Parse(textBox6.Text);
            decimal totalCost = CalculateTotalCost(numOfPax);

            // Insert reservation into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Reservations (Id, FullName, Email, Mobile, ReservationDate, NumOfPax, TotalCost) 
                                 VALUES (@Id, @FullName, @Email, @Mobile, @ReservationDate, @NumOfPax, @TotalCost)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Mobile", mobile);
                    command.Parameters.AddWithValue("@ReservationDate", reservationDate);
                    command.Parameters.AddWithValue("@NumOfPax", numOfPax);
                    command.Parameters.AddWithValue("@TotalCost", totalCost);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Reservation created successfully.");

        }

        private decimal CalculateTotalCost(int numOfPax)
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


        private void button2_Click(object sender, EventArgs e)
        {
            // Open Edit form 
            manage__reservation_Edite Form = new manage__reservation_Edite();
            Form.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearFields();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Ope ndownlod form 
            Downlod Downlod = new Downlod();
            Downlod.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {





        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }



}
    


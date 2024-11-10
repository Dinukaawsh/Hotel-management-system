using System.Data.SqlClient;
using System.Configuration;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Drawing;

namespace WinFormsApp11
{
    public partial class Manage_staff : Form
    {

        private const string connectionString = "Data Source=DESKTOP-88LB4UV\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;";

        private string selectedFilePath;


        public Manage_staff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string gender = comboBox2.SelectedItem.ToString();
            string department = textBox2.Text;
            string address = textBox3.Text;
            string contactNumber = textBox4.Text;
            string email = textBox5.Text;

            // Add image to database
            Image pimg = pictureBox1.Image;
            ImageConverter converter = new ImageConverter();
            var ImageConverter = converter.ConvertTo(pimg, typeof(byte[]));
            ClearFields();

            byte[] Certificate = File.ReadAllBytes(selectedFilePath);



            byte[] PoliceReport = File.ReadAllBytes(selectedFilePath);









            // Calculate salary based on department
            decimal salary = CalculateSalary(department);

            decimal CalculateSalary(string department)
            {
                switch (department)
                {
                    case "Maintenance":
                        return 45000;
                    case "Kitchen":
                        return 50000;
                    case "Housekeeping":
                        return 30000;
                    case "Banquets":
                        return 60000;
                    default:
                        return 0;
                }
            }

            // Validate input fields
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(address) ||
                string.IsNullOrWhiteSpace(contactNumber) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }


            // Add staff member to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Staff (Name, Gender, Department, Address, ContactNumber, Email, Salary, Photo, Certificate, PoliceReport) 
                                 VALUES (@Name, @Gender, @Department, @Address, @ContactNumber, @Email, @Salary , @Photo, @Certificate , @PoliceReport )";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Department", department);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Salary", salary);
                    command.Parameters.AddWithValue("@Photo", ImageConverter);
                    command.Parameters.AddWithValue("@Certificate", Certificate);
                    command.Parameters.AddWithValue("@PoliceReport", PoliceReport);
                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Staff member added successfully.");
            ClearFields();
        }



        private void ClearFields()
        {
            textBox1.Clear();
            comboBox2.SelectedIndex = -1;
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox2.Clear();
            pictureBox1.Image = null;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Select photo form photo galary

            OpenFileDialog ofdig = new OpenFileDialog();
            ofdig.Title = "open image";
            ofdig.Filter = "Image Files(*.JPG;*.PNG;*.GIF|*.JPG;*.PNG;*.GIF";
            if (ofdig.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofdig.FileName);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                MessageBox.Show("File selected: " + selectedFilePath);
            }
        }















        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                MessageBox.Show("File selected: " + selectedFilePath);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Open update form 
            Manage_staff_update Form = new Manage_staff_update();
             Form.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Open delete form
            Saff_delete Form = new Saff_delete();
            Form.Show();
        }

        private void Manage_staff_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Open delete form
            Staff_Search Form = new Staff_Search();
             Form.Show();
        }
    }
}





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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp11
{
    public partial class Saff_delete : Form
    {

        private const string connectionString = "Data Source=DESKTOP-88LB4UV\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;";
        public Saff_delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            // Add staff member to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"DELETE FROM Staff WHERE Name = @Name;";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Staff member delete successfully.");
            ClearFields();

             void ClearFields()
            {
                textBox1.Clear();
                

            }



        }
    }
}

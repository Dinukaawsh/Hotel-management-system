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
    public partial class Reset_password : Form
    {

        public SqlConnection Con;
        public SqlCommand cmd;
        string password;
        string name;

        public Reset_password()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            password = textBox2.Text;

            Con.Open();
            cmd = new SqlCommand(" update user1 set Password = @Password where username = @username ", Con);

            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@username", name);

            int line = cmd.ExecuteNonQuery();
            cmd.Dispose();
            Con.Close();

            if (line == 1)
            {
                MessageBox.Show(" Reset password");

            }
            else
            {

                MessageBox.Show("Faild to Reset");
            }

        }

        private void Reset_password_Load(object sender, EventArgs e)
        {
            Con = new SqlConnection();
            Con.ConnectionString = "Data Source=DESKTOP-88LB4UV\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True;";
        }
    }
}

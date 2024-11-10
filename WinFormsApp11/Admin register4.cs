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
    public partial class Admin_register4 : Form
    {

        public SqlConnection con;
        public SqlCommand cmd;
        string Aid;
        string password;
        string email;

        public Admin_register4()
        {
            InitializeComponent();
        }

        private void Admin_register4_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-88LB4UV\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True; ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aid = textBox1.Text;
            password = textBox3.Text;
            email = textBox2.Text;

            con.Open();
            cmd = new SqlCommand("insert into admin values(@Name,@password,@Email)", con);
            cmd.Parameters.AddWithValue("@Name", Aid);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@Email", email);

            int line = cmd.ExecuteNonQuery();

            cmd.Dispose();

            con.Close();

            if (line == 1)
            {
                MessageBox.Show("Admin register succesfully");
            }
            else
            {
                MessageBox.Show("register not succesfully");
            }

        }
    }
}

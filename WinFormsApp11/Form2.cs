using System.Data.SqlClient;

namespace WinFormsApp11
{
    public partial class Form2 : Form
    {

        public SqlConnection con;
        public SqlCommand cmd;
        string cid;
        string username;
        string email;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            cid = textBox1.Text;
            username = textBox2.Text;
            email = textBox3.Text;

            con.Open();
            cmd = new SqlCommand("insert into user1 values(@username,@Password,@email)", con);
            cmd.Parameters.AddWithValue("@username", cid);
            cmd.Parameters.AddWithValue("@Password", username);
            cmd.Parameters.AddWithValue("@email", email);

            int line = cmd.ExecuteNonQuery();

            cmd.Dispose();

            con.Close();

            if (line == 1)
            {
                MessageBox.Show("customer register succesfully");
            }
            else
            {
                MessageBox.Show("register not succesfully");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-88LB4UV\\SQLEXPRESS;Initial Catalog=HotelDB;Integrated Security=True; ";




        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp11
{
    public partial class Select_Account : Form
    {
        public Select_Account()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open customer login form 
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            // Open Admin login form 
            this.Hide();
            Admin_login AdminForm = new Admin_login();
            AdminForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open Admin login form 
            this.Hide();
            Admin_login AdminForm = new Admin_login();
            AdminForm.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void Select_Account_Load(object sender, EventArgs e)
        {

        }
    }
}

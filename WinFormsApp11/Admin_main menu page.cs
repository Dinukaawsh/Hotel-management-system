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
    public partial class main_menu_page : Form
    {
        public main_menu_page()
        {
            InitializeComponent();
        }

        private void main_menu_page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open manage staff form 
            Manage_staff manage = new Manage_staff();
            manage.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open manage packge form 
            Manage_packages manage = new Manage_packages();
            manage.Show();
        }
    }
}

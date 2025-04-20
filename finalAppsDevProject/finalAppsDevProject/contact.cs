using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalAppsDevProject
{
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void home_page_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void category_page_Click(object sender, EventArgs e)
        {
            Category categoryForm = new Category();
            categoryForm.Show();
            this.Hide();
        }

        private void about_page_Click(object sender, EventArgs e)
        {
            About About = new About();
            About.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Category categoryForm = new Category();
            categoryForm.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            About aboutForm = new About();
            aboutForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            this.Hide();
        }
    }
}

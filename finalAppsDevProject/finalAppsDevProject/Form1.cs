namespace finalAppsDevProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void contact_page_Click(object sender, EventArgs e)
        {
            Contact Contact = new Contact();
            Contact.Show();
            this.Hide();
        }

        private void about_page_Click(object sender, EventArgs e)
        {
            About About = new About();
            About.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void home_page_Click(object sender, EventArgs e)
        {

        }

        private void category_page_Click(object sender, EventArgs e)
        {

        }

        private void category_page_Click_1(object sender, EventArgs e)
        {
            Category categoryForm = new Category();
            categoryForm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Category categoryForm = new Category();
            categoryForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void category_page_Click_2(object sender, EventArgs e)
        {
            Category categoryForm = new Category();
            categoryForm.Show();
            this.Hide();
        }

        private void about_page_Click_1(object sender, EventArgs e)
        {
            About About = new About();
            About.Show();
            this.Hide();
        }

        private void contact_page_Click_1(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Show();
            this.Hide();
        }

        private void home_page_Click_1(object sender, EventArgs e)
        {

        }
    }
}

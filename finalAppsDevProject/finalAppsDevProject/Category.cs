using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalAppsDevProject
{
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
            pictureBox2.Paint += RoundedControl_Paint;
            pictureBox3.Paint += RoundedControl_Paint;
            pictureBox4.Paint += RoundedControl_Paint;
            pictureBox5.Paint += RoundedControl_Paint;
            pictureBox6.Paint += RoundedControl_Paint;
            panel2.Paint += RoundedControl_Paint;
            panel3.Paint += RoundedControl_Paint;
            panel4.Paint += RoundedControl_Paint;
            panel5.Paint += RoundedControl_Paint;
            panel6.Paint += RoundedControl_Paint;
        }

        private void ApplyRoundedBorder(Control control, PaintEventArgs e, int radius, Color borderColor, int borderWidth = 1)
        {
            Rectangle bounds = new Rectangle(0, 0, control.Width, control.Height);
            bounds.Inflate(-1, -1);

            using (GraphicsPath path = new GraphicsPath())
            {
                int diameter = radius * 2;
                path.StartFigure();
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
                path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
                path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                control.Region = new Region(path);

                using (Pen borderPen = new Pen(borderColor, borderWidth))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        private void RoundedControl_Paint(object? sender, PaintEventArgs e)
        {
            if (sender is not Control control)
                return;

            ApplyRoundedBorder(control, e, radius: 20, borderColor: Color.DarkSlateBlue, borderWidth: 2);
        }

        private void category_page_Click(object sender, EventArgs e)
        {

        }

        private void home_page_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Beautycategory beautycategory = new Beautycategory();
            beautycategory.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void about_page_Click(object sender, EventArgs e)
        {
            About About = new About();
            About.Show();
            this.Hide();
        }

        private void contact_page_Click(object sender, EventArgs e)
        {
            Contact Contact = new Contact();
            Contact.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FoodCategory foodCategory = new FoodCategory();
            foodCategory.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }
    }
}

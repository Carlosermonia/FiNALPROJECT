namespace finalAppsDevProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            contact_page = new Label();
            pictureBox2 = new PictureBox();
            about_page = new Label();
            category_page = new Label();
            home_page = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(contact_page);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(about_page);
            panel1.Controls.Add(category_page);
            panel1.Controls.Add(home_page);
            panel1.Location = new Point(-7, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1448, 114);
            panel1.TabIndex = 0;
            // 
            // contact_page
            // 
            contact_page.AutoSize = true;
            contact_page.Font = new Font("Calibri Light", 11F);
            contact_page.Location = new Point(1306, 49);
            contact_page.Name = "contact_page";
            contact_page.Size = new Size(69, 23);
            contact_page.TabIndex = 8;
            contact_page.Text = "Contact";
            contact_page.Click += contact_page_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.logo;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(19, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 108);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // about_page
            // 
            about_page.AutoSize = true;
            about_page.Font = new Font("Calibri Light", 11F);
            about_page.Location = new Point(1177, 49);
            about_page.Name = "about_page";
            about_page.Size = new Size(80, 23);
            about_page.TabIndex = 7;
            about_page.Text = "About Us";
            about_page.Click += about_page_Click_1;
            // 
            // category_page
            // 
            category_page.AutoSize = true;
            category_page.Font = new Font("Calibri Light", 11F);
            category_page.Location = new Point(1046, 49);
            category_page.Name = "category_page";
            category_page.Size = new Size(78, 23);
            category_page.TabIndex = 6;
            category_page.Text = "Category";
            category_page.Click += category_page_Click_2;
            // 
            // home_page
            // 
            home_page.AutoSize = true;
            home_page.Font = new Font("Calibri Light", 11F);
            home_page.Location = new Point(926, 49);
            home_page.Name = "home_page";
            home_page.Size = new Size(56, 23);
            home_page.TabIndex = 5;
            home_page.Text = "Home";
            home_page.Click += home_page_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Baskerville Old Face", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 308);
            label1.Name = "label1";
            label1.Size = new Size(842, 138);
            label1.TabIndex = 1;
            label1.Text = "EMPOWER YOUR BUSINESS \r\nWITH CLARITY\r\n";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 10F);
            label2.Location = new Point(376, 446);
            label2.Name = "label2";
            label2.Size = new Size(677, 40);
            label2.TabIndex = 2;
            label2.Text = " Our system simplifies product cost calculations by integrating raw materials, utilities, labor, \r\nand more, ensuring you set competitive prices with confidence";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.priceprobg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1440, 703);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label contact_page;
        private Label about_page;
        private Label category_page;
        private Label home_page;
    }
}

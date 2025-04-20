namespace finalAppsDevProject
{
    partial class ProductSummaryDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            View_back = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            View_product = new Label();
            View_unit = new Label();
            View_srp = new Label();
            View_srppe = new Label();
            label6 = new Label();
            View_tpc = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)View_back).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(View_back);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 78);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // View_back
            // 
            View_back.BackgroundImage = Properties.Resources.backbar;
            View_back.BackgroundImageLayout = ImageLayout.Stretch;
            View_back.Location = new Point(705, 3);
            View_back.Name = "View_back";
            View_back.Size = new Size(92, 29);
            View_back.TabIndex = 1;
            View_back.TabStop = false;
            View_back.Click += View_back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 24F);
            label1.Location = new Point(10, 17);
            label1.Name = "label1";
            label1.Size = new Size(378, 44);
            label1.TabIndex = 0;
            label1.Text = "PRODUCT COST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 101);
            label2.Name = "label2";
            label2.Size = new Size(301, 34);
            label2.TabIndex = 1;
            label2.Text = "PRODUCT NAME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 179);
            label3.Name = "label3";
            label3.Size = new Size(307, 34);
            label3.TabIndex = 2;
            label3.Text = "UNIT PRODUCED:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 315);
            label4.Name = "label4";
            label4.Size = new Size(93, 34);
            label4.TabIndex = 3;
            label4.Text = "SRP:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 384);
            label5.Name = "label5";
            label5.Size = new Size(279, 34);
            label5.TabIndex = 4;
            label5.Text = "SRP(PER UNIT) :";
            // 
            // View_product
            // 
            View_product.AutoSize = true;
            View_product.BackColor = Color.Transparent;
            View_product.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            View_product.ForeColor = Color.Black;
            View_product.Location = new Point(339, 105);
            View_product.Name = "View_product";
            View_product.Size = new Size(153, 27);
            View_product.TabIndex = 5;
            View_product.Text = "Product Name";
            // 
            // View_unit
            // 
            View_unit.AutoSize = true;
            View_unit.BackColor = Color.Transparent;
            View_unit.Font = new Font("Cambria", 13.8F);
            View_unit.ForeColor = Color.Black;
            View_unit.Location = new Point(339, 185);
            View_unit.Name = "View_unit";
            View_unit.Size = new Size(40, 27);
            View_unit.TabIndex = 6;
            View_unit.Text = "UP";
            // 
            // View_srp
            // 
            View_srp.AutoSize = true;
            View_srp.BackColor = Color.Transparent;
            View_srp.Font = new Font("Cambria", 13.8F);
            View_srp.ForeColor = Color.Black;
            View_srp.Location = new Point(120, 320);
            View_srp.Name = "View_srp";
            View_srp.Size = new Size(50, 27);
            View_srp.TabIndex = 7;
            View_srp.Text = "SRP";
            // 
            // View_srppe
            // 
            View_srppe.AutoSize = true;
            View_srppe.BackColor = Color.Transparent;
            View_srppe.Font = new Font("Cambria", 13.8F);
            View_srppe.ForeColor = Color.Black;
            View_srppe.Location = new Point(306, 388);
            View_srppe.Name = "View_srppe";
            View_srppe.Size = new Size(120, 27);
            View_srppe.TabIndex = 8;
            View_srppe.Text = "SRP(UNIT)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 254);
            label6.Name = "label6";
            label6.Size = new Size(362, 34);
            label6.TabIndex = 9;
            label6.Text = "Total Product Cost:";
            // 
            // View_tpc
            // 
            View_tpc.AutoSize = true;
            View_tpc.BackColor = Color.Transparent;
            View_tpc.Font = new Font("Cambria", 13.8F);
            View_tpc.ForeColor = Color.Black;
            View_tpc.Location = new Point(398, 258);
            View_tpc.Name = "View_tpc";
            View_tpc.Size = new Size(52, 27);
            View_tpc.TabIndex = 10;
            View_tpc.Text = "TPC\r\n";
            // 
            // ProductSummaryDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            BackgroundImage = Properties.Resources._1bckground1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(View_tpc);
            Controls.Add(label6);
            Controls.Add(View_srppe);
            Controls.Add(View_srp);
            Controls.Add(View_unit);
            Controls.Add(View_product);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductSummaryDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductSummaryDialog";
            Load += ProductSummaryDialog_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)View_back).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox View_back;
        private Label View_product;
        private Label View_unit;
        private Label View_srp;
        private Label View_srppe;
        private Label label6;
        private Label View_tpc;
    }
}
namespace finalAppsDevProject
{
    partial class FoodCategory
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
            back_picbox = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel4 = new Panel();
            label22 = new Label();
            label21 = new Label();
            label16 = new Label();
            Rub_cmb = new ComboBox();
            total_lbr = new Button();
            laborCostPerUnitTxt = new TextBox();
            label18 = new Label();
            lbr_datagridview = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colHrsWorked = new DataGridViewTextBoxColumn();
            colHrRate = new DataGridViewTextBoxColumn();
            colsubtotal = new DataGridViewTextBoxColumn();
            label17 = new Label();
            Uc_result = new TextBox();
            TotalUc_btn = new Button();
            Util_DataGridView = new DataGridView();
            colExpenseType = new DataGridViewTextBoxColumn();
            colMonthlyutil = new DataGridViewTextBoxColumn();
            colEstimated = new DataGridViewTextBoxColumn();
            ColUnitsProduced = new DataGridViewTextBoxColumn();
            colCostPerunit = new DataGridViewTextBoxColumn();
            Add_Util = new Button();
            Production_txt = new TextBox();
            Month_txt = new TextBox();
            Expenses_txt = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            Tlc_txtbox = new TextBox();
            label11 = new Label();
            panel3 = new Panel();
            metric_cmb = new ComboBox();
            label20 = new Label();
            label19 = new Label();
            lbr_addbtn = new Button();
            lbrname_txtbox = new TextBox();
            Totalrmc_txtbox = new TextBox();
            Totalrmc_btn = new Button();
            Rmc_Datagridview = new DataGridView();
            Ing_txt = new DataGridViewTextBoxColumn();
            colQuantityUsed = new DataGridViewTextBoxColumn();
            Cost_txt = new DataGridViewTextBoxColumn();
            subtotal = new DataGridViewTextBoxColumn();
            Add_btn = new Button();
            Cost_txtbox = new TextBox();
            label2 = new Label();
            Quantity_txtbox = new TextBox();
            label6 = new Label();
            Ing_txtbox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            product_nametxtbox = new TextBox();
            label3 = new Label();
            label7 = new Label();
            label9 = new Label();
            label12 = new Label();
            Laborhrrate_txtbox = new TextBox();
            label8 = new Label();
            Up_txtbox = new TextBox();
            Hrwork_txtbox = new TextBox();
            label10 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)back_picbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lbr_datagridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Util_DataGridView).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Rmc_Datagridview).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(back_picbox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Font = new Font("Copperplate Gothic Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1452, 114);
            panel1.TabIndex = 1;
            // 
            // back_picbox
            // 
            back_picbox.BackgroundImage = Properties.Resources.backbar;
            back_picbox.BackgroundImageLayout = ImageLayout.Stretch;
            back_picbox.Location = new Point(1366, 11);
            back_picbox.Name = "back_picbox";
            back_picbox.Size = new Size(67, 30);
            back_picbox.TabIndex = 2;
            back_picbox.TabStop = false;
            back_picbox.Click += back_picbox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(186, 42);
            label1.Name = "label1";
            label1.Size = new Size(413, 44);
            label1.TabIndex = 1;
            label1.Text = "FOOD CATEGORY";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 111);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackgroundImage = Properties.Resources._1bckground;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(1443, 862);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.InactiveCaption;
            panel4.Controls.Add(label22);
            panel4.Controls.Add(label21);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(Rub_cmb);
            panel4.Controls.Add(total_lbr);
            panel4.Controls.Add(laborCostPerUnitTxt);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(lbr_datagridview);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(Uc_result);
            panel4.Controls.Add(TotalUc_btn);
            panel4.Controls.Add(Util_DataGridView);
            panel4.Controls.Add(Add_Util);
            panel4.Controls.Add(Production_txt);
            panel4.Controls.Add(Month_txt);
            panel4.Controls.Add(Expenses_txt);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(Tlc_txtbox);
            panel4.Controls.Add(label11);
            panel4.Location = new Point(593, 26);
            panel4.Name = "panel4";
            panel4.Size = new Size(838, 809);
            panel4.TabIndex = 5;
            panel4.Paint += panel4_Paint_1;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(44, 175);
            label22.Name = "label22";
            label22.Size = new Size(174, 21);
            label22.TabIndex = 32;
            label22.Text = "Product Percentage";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(444, 756);
            label21.Name = "label21";
            label21.Size = new Size(133, 27);
            label21.TabIndex = 31;
            label21.Text = "Total Labor";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label16.Location = new Point(88, 462);
            label16.Name = "label16";
            label16.Size = new Size(85, 23);
            label16.TabIndex = 30;
            label16.Text = "Total UC";
            // 
            // Rub_cmb
            // 
            Rub_cmb.FormattingEnabled = true;
            Rub_cmb.Location = new Point(251, 105);
            Rub_cmb.Name = "Rub_cmb";
            Rub_cmb.Size = new Size(151, 28);
            Rub_cmb.TabIndex = 29;
            // 
            // total_lbr
            // 
            total_lbr.BackColor = SystemColors.Highlight;
            total_lbr.ForeColor = SystemColors.ButtonFace;
            total_lbr.Location = new Point(608, 696);
            total_lbr.Name = "total_lbr";
            total_lbr.Size = new Size(111, 34);
            total_lbr.TabIndex = 23;
            total_lbr.Text = "Calculate";
            total_lbr.UseVisualStyleBackColor = false;
            total_lbr.Click += total_lbr_Click;
            // 
            // laborCostPerUnitTxt
            // 
            laborCostPerUnitTxt.Location = new Point(256, 756);
            laborCostPerUnitTxt.Name = "laborCostPerUnitTxt";
            laborCostPerUnitTxt.ReadOnly = true;
            laborCostPerUnitTxt.Size = new Size(125, 27);
            laborCostPerUnitTxt.TabIndex = 28;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(22, 753);
            label18.Name = "label18";
            label18.Size = new Size(216, 27);
            label18.TabIndex = 26;
            label18.Text = "Labor Cost Per Unit";
            // 
            // lbr_datagridview
            // 
            lbr_datagridview.AllowUserToAddRows = false;
            lbr_datagridview.BackgroundColor = SystemColors.ButtonFace;
            lbr_datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lbr_datagridview.Columns.AddRange(new DataGridViewColumn[] { colName, colHrsWorked, colHrRate, colsubtotal });
            lbr_datagridview.Location = new Point(44, 530);
            lbr_datagridview.Name = "lbr_datagridview";
            lbr_datagridview.ReadOnly = true;
            lbr_datagridview.RowHeadersWidth = 51;
            lbr_datagridview.Size = new Size(539, 210);
            lbr_datagridview.TabIndex = 25;
            // 
            // colName
            // 
            colName.HeaderText = "Laborer Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 125;
            // 
            // colHrsWorked
            // 
            colHrsWorked.HeaderText = "Hours Worked";
            colHrsWorked.MinimumWidth = 6;
            colHrsWorked.Name = "colHrsWorked";
            colHrsWorked.ReadOnly = true;
            colHrsWorked.Width = 125;
            // 
            // colHrRate
            // 
            colHrRate.HeaderText = "Hour Rate";
            colHrRate.MinimumWidth = 6;
            colHrRate.Name = "colHrRate";
            colHrRate.ReadOnly = true;
            colHrRate.Width = 125;
            // 
            // colsubtotal
            // 
            colsubtotal.HeaderText = "Subtotal";
            colsubtotal.MinimumWidth = 6;
            colsubtotal.Name = "colsubtotal";
            colsubtotal.ReadOnly = true;
            colsubtotal.Width = 125;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(721, 206);
            label17.Name = "label17";
            label17.Size = new Size(114, 106);
            label17.TabIndex = 24;
            label17.Text = "→";
            label17.Click += label17_Click;
            // 
            // Uc_result
            // 
            Uc_result.Location = new Point(208, 462);
            Uc_result.Name = "Uc_result";
            Uc_result.ReadOnly = true;
            Uc_result.Size = new Size(99, 27);
            Uc_result.TabIndex = 23;
            Uc_result.TextChanged += Uc_result_TextChanged;
            // 
            // TotalUc_btn
            // 
            TotalUc_btn.BackColor = SystemColors.Highlight;
            TotalUc_btn.ForeColor = SystemColors.ButtonFace;
            TotalUc_btn.Location = new Point(466, 462);
            TotalUc_btn.Name = "TotalUc_btn";
            TotalUc_btn.Size = new Size(111, 34);
            TotalUc_btn.TabIndex = 22;
            TotalUc_btn.Text = "Calculate";
            TotalUc_btn.UseVisualStyleBackColor = false;
            TotalUc_btn.Click += TotalUc_btn_Click;
            // 
            // Util_DataGridView
            // 
            Util_DataGridView.AllowUserToAddRows = false;
            Util_DataGridView.BackgroundColor = SystemColors.ButtonFace;
            Util_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Util_DataGridView.Columns.AddRange(new DataGridViewColumn[] { colExpenseType, colMonthlyutil, colEstimated, ColUnitsProduced, colCostPerunit });
            Util_DataGridView.Location = new Point(14, 216);
            Util_DataGridView.Name = "Util_DataGridView";
            Util_DataGridView.ReadOnly = true;
            Util_DataGridView.RowHeadersWidth = 51;
            Util_DataGridView.Size = new Size(655, 232);
            Util_DataGridView.TabIndex = 21;
            Util_DataGridView.CellContentClick += Util_DataGridView_CellContentClick;
            // 
            // colExpenseType
            // 
            colExpenseType.HeaderText = "Expense Type";
            colExpenseType.MinimumWidth = 6;
            colExpenseType.Name = "colExpenseType";
            colExpenseType.ReadOnly = true;
            colExpenseType.Width = 125;
            // 
            // colMonthlyutil
            // 
            colMonthlyutil.HeaderText = "Monthly Utility Bill";
            colMonthlyutil.MinimumWidth = 6;
            colMonthlyutil.Name = "colMonthlyutil";
            colMonthlyutil.ReadOnly = true;
            colMonthlyutil.Width = 125;
            // 
            // colEstimated
            // 
            colEstimated.HeaderText = "Estimated";
            colEstimated.MinimumWidth = 6;
            colEstimated.Name = "colEstimated";
            colEstimated.ReadOnly = true;
            colEstimated.Width = 125;
            // 
            // ColUnitsProduced
            // 
            ColUnitsProduced.HeaderText = "Units Produced";
            ColUnitsProduced.MinimumWidth = 6;
            ColUnitsProduced.Name = "ColUnitsProduced";
            ColUnitsProduced.ReadOnly = true;
            ColUnitsProduced.Width = 125;
            // 
            // colCostPerunit
            // 
            colCostPerunit.HeaderText = "Cost Per unit";
            colCostPerunit.MinimumWidth = 6;
            colCostPerunit.Name = "colCostPerunit";
            colCostPerunit.ReadOnly = true;
            colCostPerunit.Width = 125;
            // 
            // Add_Util
            // 
            Add_Util.BackColor = SystemColors.Highlight;
            Add_Util.ForeColor = SystemColors.ButtonFace;
            Add_Util.Location = new Point(419, 173);
            Add_Util.Name = "Add_Util";
            Add_Util.Size = new Size(111, 34);
            Add_Util.TabIndex = 20;
            Add_Util.Text = "ADD";
            Add_Util.UseVisualStyleBackColor = false;
            Add_Util.Click += Add_Util_Click;
            // 
            // Production_txt
            // 
            Production_txt.Location = new Point(251, 173);
            Production_txt.Name = "Production_txt";
            Production_txt.Size = new Size(99, 27);
            Production_txt.TabIndex = 18;
            // 
            // Month_txt
            // 
            Month_txt.Location = new Point(251, 140);
            Month_txt.Name = "Month_txt";
            Month_txt.Size = new Size(130, 27);
            Month_txt.TabIndex = 17;
            Month_txt.TextChanged += Month_txt_TextChanged;
            // 
            // Expenses_txt
            // 
            Expenses_txt.Location = new Point(251, 72);
            Expenses_txt.Name = "Expenses_txt";
            Expenses_txt.Size = new Size(130, 27);
            Expenses_txt.TabIndex = 16;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(23, 142);
            label15.Name = "label15";
            label15.Size = new Size(222, 21);
            label15.TabIndex = 14;
            label15.Text = "Cost Amount (Utility Bill)";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(43, 105);
            label14.Name = "label14";
            label14.Size = new Size(130, 21);
            label14.TabIndex = 13;
            label14.Text = "Cost Duration:";
            label14.Click += label14_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(42, 71);
            label13.Name = "label13";
            label13.Size = new Size(131, 21);
            label13.TabIndex = 12;
            label13.Text = "Expense Type:\r\n";
            label13.Click += label13_Click;
            // 
            // Tlc_txtbox
            // 
            Tlc_txtbox.Location = new Point(589, 756);
            Tlc_txtbox.Name = "Tlc_txtbox";
            Tlc_txtbox.ReadOnly = true;
            Tlc_txtbox.Size = new Size(125, 27);
            Tlc_txtbox.TabIndex = 8;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(14, 11);
            label11.Name = "label11";
            label11.Size = new Size(185, 33);
            label11.TabIndex = 11;
            label11.Text = " Utilities Cost";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InactiveCaption;
            panel3.Controls.Add(metric_cmb);
            panel3.Controls.Add(label20);
            panel3.Controls.Add(label19);
            panel3.Controls.Add(lbr_addbtn);
            panel3.Controls.Add(lbrname_txtbox);
            panel3.Controls.Add(Totalrmc_txtbox);
            panel3.Controls.Add(Totalrmc_btn);
            panel3.Controls.Add(Rmc_Datagridview);
            panel3.Controls.Add(Add_btn);
            panel3.Controls.Add(Cost_txtbox);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(Quantity_txtbox);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(Ing_txtbox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(product_nametxtbox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(Laborhrrate_txtbox);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(Up_txtbox);
            panel3.Controls.Add(Hrwork_txtbox);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(11, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(556, 809);
            panel3.TabIndex = 4;
            // 
            // metric_cmb
            // 
            metric_cmb.FormattingEnabled = true;
            metric_cmb.Location = new Point(219, 150);
            metric_cmb.Name = "metric_cmb";
            metric_cmb.Size = new Size(151, 28);
            metric_cmb.TabIndex = 24;
            metric_cmb.SelectedIndexChanged += metric_cmb_SelectedIndexChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(23, 150);
            label20.Name = "label20";
            label20.Size = new Size(190, 23);
            label20.TabIndex = 23;
            label20.Text = "Metrics to Measure:";
            label20.Click += label20_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label19.Location = new Point(45, 530);
            label19.Name = "label19";
            label19.Size = new Size(101, 23);
            label19.TabIndex = 22;
            label19.Text = "Total RMC";
            // 
            // lbr_addbtn
            // 
            lbr_addbtn.BackColor = SystemColors.Highlight;
            lbr_addbtn.ForeColor = SystemColors.ButtonFace;
            lbr_addbtn.Location = new Point(380, 725);
            lbr_addbtn.Name = "lbr_addbtn";
            lbr_addbtn.Size = new Size(111, 34);
            lbr_addbtn.TabIndex = 21;
            lbr_addbtn.Text = "ADD";
            lbr_addbtn.UseVisualStyleBackColor = false;
            lbr_addbtn.Click += lbr_addbtn_Click;
            // 
            // lbrname_txtbox
            // 
            lbrname_txtbox.Location = new Point(213, 638);
            lbrname_txtbox.Name = "lbrname_txtbox";
            lbrname_txtbox.Size = new Size(125, 27);
            lbrname_txtbox.TabIndex = 13;
            // 
            // Totalrmc_txtbox
            // 
            Totalrmc_txtbox.Location = new Point(174, 530);
            Totalrmc_txtbox.Name = "Totalrmc_txtbox";
            Totalrmc_txtbox.ReadOnly = true;
            Totalrmc_txtbox.Size = new Size(94, 27);
            Totalrmc_txtbox.TabIndex = 12;
            // 
            // Totalrmc_btn
            // 
            Totalrmc_btn.BackColor = SystemColors.Highlight;
            Totalrmc_btn.ForeColor = SystemColors.ButtonFace;
            Totalrmc_btn.Location = new Point(323, 529);
            Totalrmc_btn.Name = "Totalrmc_btn";
            Totalrmc_btn.Size = new Size(106, 28);
            Totalrmc_btn.TabIndex = 11;
            Totalrmc_btn.Text = "Calculate";
            Totalrmc_btn.UseVisualStyleBackColor = false;
            Totalrmc_btn.Click += Totalrmc_btn_Click;
            // 
            // Rmc_Datagridview
            // 
            Rmc_Datagridview.AllowUserToAddRows = false;
            Rmc_Datagridview.BackgroundColor = SystemColors.ButtonFace;
            Rmc_Datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Rmc_Datagridview.Columns.AddRange(new DataGridViewColumn[] { Ing_txt, colQuantityUsed, Cost_txt, subtotal });
            Rmc_Datagridview.Location = new Point(23, 277);
            Rmc_Datagridview.Name = "Rmc_Datagridview";
            Rmc_Datagridview.ReadOnly = true;
            Rmc_Datagridview.RowHeadersWidth = 51;
            Rmc_Datagridview.Size = new Size(500, 227);
            Rmc_Datagridview.TabIndex = 10;
            // 
            // Ing_txt
            // 
            Ing_txt.HeaderText = "Ingredients Name";
            Ing_txt.MinimumWidth = 6;
            Ing_txt.Name = "Ing_txt";
            Ing_txt.ReadOnly = true;
            Ing_txt.Width = 125;
            // 
            // colQuantityUsed
            // 
            colQuantityUsed.HeaderText = "Quantity Used";
            colQuantityUsed.MinimumWidth = 6;
            colQuantityUsed.Name = "colQuantityUsed";
            colQuantityUsed.ReadOnly = true;
            colQuantityUsed.Width = 125;
            // 
            // Cost_txt
            // 
            Cost_txt.HeaderText = "Cost Per unit";
            Cost_txt.MinimumWidth = 6;
            Cost_txt.Name = "Cost_txt";
            Cost_txt.ReadOnly = true;
            Cost_txt.Width = 125;
            // 
            // subtotal
            // 
            subtotal.HeaderText = "Subtotal";
            subtotal.MinimumWidth = 6;
            subtotal.Name = "subtotal";
            subtotal.ReadOnly = true;
            subtotal.Width = 125;
            // 
            // Add_btn
            // 
            Add_btn.BackColor = SystemColors.Highlight;
            Add_btn.ForeColor = SystemColors.ButtonFace;
            Add_btn.Location = new Point(369, 220);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(99, 28);
            Add_btn.TabIndex = 9;
            Add_btn.Text = "ADD";
            Add_btn.UseVisualStyleBackColor = false;
            Add_btn.Click += Add_btn_Click;
            // 
            // Cost_txtbox
            // 
            Cost_txtbox.Location = new Point(219, 220);
            Cost_txtbox.Name = "Cost_txtbox";
            Cost_txtbox.Size = new Size(94, 27);
            Cost_txtbox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 220);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 7;
            label2.Text = "Cost Per Unit:";
            label2.Click += label2_Click;
            // 
            // Quantity_txtbox
            // 
            Quantity_txtbox.Location = new Point(219, 187);
            Quantity_txtbox.Name = "Quantity_txtbox";
            Quantity_txtbox.Size = new Size(94, 27);
            Quantity_txtbox.TabIndex = 6;
            Quantity_txtbox.TextChanged += Quantity_txtbox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 184);
            label6.Name = "label6";
            label6.Size = new Size(146, 23);
            label6.TabIndex = 5;
            label6.Text = "Quantity Used:";
            label6.Click += label6_Click;
            // 
            // Ing_txtbox
            // 
            Ing_txtbox.Location = new Point(219, 117);
            Ing_txtbox.Name = "Ing_txtbox";
            Ing_txtbox.Size = new Size(225, 27);
            Ing_txtbox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 117);
            label5.Name = "label5";
            label5.Size = new Size(180, 23);
            label5.TabIndex = 3;
            label5.Text = "Ingredients Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 81);
            label4.Name = "label4";
            label4.Size = new Size(247, 33);
            label4.TabIndex = 2;
            label4.Text = "Raw Material Cost";
            // 
            // product_nametxtbox
            // 
            product_nametxtbox.Location = new Point(184, 11);
            product_nametxtbox.Name = "product_nametxtbox";
            product_nametxtbox.Size = new Size(165, 27);
            product_nametxtbox.TabIndex = 1;
            product_nametxtbox.TextChanged += product_nametxtbox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 11);
            label3.Name = "label3";
            label3.Size = new Size(146, 23);
            label3.TabIndex = 0;
            label3.Text = "Product Name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 589);
            label7.Name = "label7";
            label7.Size = new Size(152, 33);
            label7.TabIndex = 0;
            label7.Text = "Labor Cost";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(34, 685);
            label9.Name = "label9";
            label9.Size = new Size(173, 21);
            label9.TabIndex = 2;
            label9.Text = "Labor Hourly Rate: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(39, 638);
            label12.Name = "label12";
            label12.Size = new Size(134, 42);
            label12.TabIndex = 5;
            label12.Text = "Laborer Name:\r\n\r\n";
            label12.Click += label12_Click;
            // 
            // Laborhrrate_txtbox
            // 
            Laborhrrate_txtbox.Location = new Point(213, 685);
            Laborhrrate_txtbox.Name = "Laborhrrate_txtbox";
            Laborhrrate_txtbox.Size = new Size(125, 27);
            Laborhrrate_txtbox.TabIndex = 6;
            Laborhrrate_txtbox.TextChanged += Laborhrrate_txtbox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(34, 731);
            label8.Name = "label8";
            label8.Size = new Size(135, 21);
            label8.TabIndex = 1;
            label8.Text = "Hours Worked:";
            // 
            // Up_txtbox
            // 
            Up_txtbox.Location = new Point(184, 45);
            Up_txtbox.Name = "Up_txtbox";
            Up_txtbox.Size = new Size(107, 27);
            Up_txtbox.TabIndex = 7;
            Up_txtbox.TextChanged += Up_txtbox_TextChanged;
            // 
            // Hrwork_txtbox
            // 
            Hrwork_txtbox.Location = new Point(213, 731);
            Hrwork_txtbox.Name = "Hrwork_txtbox";
            Hrwork_txtbox.Size = new Size(125, 27);
            Hrwork_txtbox.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(23, 47);
            label10.Name = "label10";
            label10.Size = new Size(143, 42);
            label10.TabIndex = 3;
            label10.Text = "Units Produced:\r\n\r\n";
            // 
            // FoodCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1444, 950);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FoodCategory";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FoodCategory";
            Load += FoodCategory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)back_picbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lbr_datagridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)Util_DataGridView).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Rmc_Datagridview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox back_picbox;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Label label4;
        private TextBox product_nametxtbox;
        private Label label3;
        private Label label6;
        private TextBox Ing_txtbox;
        private Label label5;
        private Button Add_btn;
        private TextBox Cost_txtbox;
        private Label label2;
        private TextBox Quantity_txtbox;
        private DataGridView Rmc_Datagridview;
        private TextBox Totalrmc_txtbox;
        private Button Totalrmc_btn;
        private DataGridViewTextBoxColumn Ing_txt;
        private DataGridViewTextBoxColumn colQuantityUsed;
        private DataGridViewTextBoxColumn Cost_txt;
        private DataGridViewTextBoxColumn subtotal;
        private Panel panel4;
        private Label label7;
        private TextBox Hrwork_txtbox;
        private TextBox Tlc_txtbox;
        private TextBox Up_txtbox;
        private TextBox Laborhrrate_txtbox;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label11;
        private Label label15;
        private Label label14;
        private Label label13;
        private DataGridView Util_DataGridView;
        private DataGridViewTextBoxColumn colExpenseType;
        private DataGridViewTextBoxColumn colMonthlyutil;
        private DataGridViewTextBoxColumn colEstimated;
        private DataGridViewTextBoxColumn ColUnitsProduced;
        private Button Add_Util;
        private TextBox Production_txt;
        private TextBox Month_txt;
        private TextBox Expenses_txt;
        private TextBox Uc_result;
        private Button TotalUc_btn;
        private DataGridViewTextBoxColumn colCostPerunit;
        private Label label17;
        private DataGridView lbr_datagridview;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colHrsWorked;
        private DataGridViewTextBoxColumn colHrRate;
        private DataGridViewTextBoxColumn colsubtotal;
        private Button lbr_addbtn;
        private TextBox lbrname_txtbox;
        private TextBox laborCostPerUnitTxt;
        private Label label18;
        private Button total_lbr;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Label label19;
        private ComboBox metric_cmb;
        private Label label20;
        private ComboBox Rub_cmb;
        private Label label21;
        private Label label16;
        private Label label22;
    }
}
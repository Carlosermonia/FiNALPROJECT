using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace finalAppsDevProject
{
    public partial class FoodCategory : Form
    {
        public string myProductName => product_nametxtbox.Text;
        public string UtilitiesCost => Uc_result.Text;
        public string TotalLaborCost => Tlc_txtbox.Text;
        public string LaborCostPerUnit => laborCostPerUnitTxt.Text;
        public string TotalRawMaterialCost => Totalrmc_txtbox.Text;

        private FoodCategory2cs? foodCategory2Form;





        public FoodCategory()
        {
            InitializeComponent();
            metric_cmb.Items.Clear();
            metric_cmb.Items.Add("kg");
            metric_cmb.Items.Add("pcs");
            metric_cmb.Items.Add("packs");
            metric_cmb.Items.Add("liters");
            metric_cmb.Items.Add("grams");
            metric_cmb.Items.Add("ml");


            metric_cmb.SelectedIndex = 0;

            Rub_cmb.Items.Clear();
            Rub_cmb.Items.Add("Monthly");

        }

        private void back_picbox_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
      "Are you sure you want to go back? All inputs or progress will be lost.",
      "Confirm",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                Category categoryForm = new Category();
                categoryForm.Show();
                this.Close();
            }
        }
        private void InitializeDataGridView()
        {
            Rmc_Datagridview.ColumnCount = 4;
            Rmc_Datagridview.Columns[0].Name = "Ingredient Name";
            Rmc_Datagridview.Columns[1].Name = "Quantity Used";
            Rmc_Datagridview.Columns[2].Name = "Cost Per Unit";
            Rmc_Datagridview.Columns[3].Name = "Subtotal";

            Rmc_Datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void FoodCategory_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private decimal HandleUnits(decimal quantity, string unit)
        {
            if (unit.ToLower() == "ml")
            {
                // Example: Convert ml to liters (ml / 1000)
                quantity = quantity / 1000; // Convert ml to liters
            }
            else if (unit.ToLower() == "grams")
            {
                // Example: Convert grams to kilograms (g / 1000)
                quantity = quantity / 1000; // Convert g to kg
            }

            return quantity;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            string ingredient = Ing_txtbox.Text.Trim();
            string quantityText = Quantity_txtbox.Text.Trim();
            string costText = Cost_txtbox.Text.Trim();
            string? selectedUnit = metric_cmb.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(ingredient) ||
                string.IsNullOrWhiteSpace(quantityText) ||
                string.IsNullOrWhiteSpace(costText) ||
                string.IsNullOrWhiteSpace(selectedUnit))
            {
                MessageBox.Show("Please fill in all fields and select a unit.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Extract numeric part from quantity input
            string numericPart = new string(quantityText.TakeWhile(c => char.IsDigit(c) || c == '.' || c == ',').ToArray());

            if (!decimal.TryParse(numericPart, out decimal originalQuantity) ||
                !decimal.TryParse(costText, out decimal cost))
            {
                MessageBox.Show("Please enter a valid numeric quantity and cost.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convert units like ml and grams only for calculation
            decimal convertedQuantity = HandleUnits(originalQuantity, selectedUnit);

            // Calculate subtotal using the converted quantity
            decimal subtotal = convertedQuantity * cost;

            // Display original quantity with unit (e.g., 5ml or 200g)
            string formattedQuantity = $"{originalQuantity}{selectedUnit}";

            string[] row = new string[]
            {
        ingredient,
        formattedQuantity,
        cost.ToString("0.##"),
        subtotal.ToString("0.##")
            };

            Rmc_Datagridview.Rows.Add(row);

            // Clear input fields
            Ing_txtbox.Clear();
            Quantity_txtbox.Clear();
            Cost_txtbox.Clear();
            metric_cmb.SelectedIndex = -1;
        }

        private void Quantity_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Totalrmc_btn_Click(object sender, EventArgs e)
        {
            decimal totalRMC = 0;

            foreach (DataGridViewRow row in Rmc_Datagridview.Rows)
            {
                if (row.IsNewRow) continue;

                string? quantityText = row.Cells[1].Value == null ? string.Empty : row.Cells[1].Value.ToString();

                decimal quantity = 0;
                decimal cost = 0;

                if (!string.IsNullOrEmpty(quantityText) &&
                    decimal.TryParse(ExtractNumericValue(quantityText), out quantity) &&
                    decimal.TryParse(Convert.ToString(row.Cells[2].Value), out cost))
                {
                    decimal subtotal = quantity * cost;
                    row.Cells[3].Value = subtotal.ToString("0.##");

                    totalRMC += subtotal;
                }
                else
                {
                    MessageBox.Show($"Invalid quantity in row {row.Index + 1}. Please check the input.");
                }
            }

            Totalrmc_txtbox.Text = totalRMC.ToString("0.##");
        }
        private string ExtractNumericValue(string input)
        {
            var match = System.Text.RegularExpressions.Regex.Match(input, @"\d+(\.\d+)?");
            return match.Success ? match.Value : "0";
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Util_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Util_Click(object sender, EventArgs e)
        {
            string expenseType = Expenses_txt.Text.Trim();
            string billText = Month_txt.Text.Trim();
            string percentText = Production_txt.Text.Trim();
            string unitsText = Up_txtbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(expenseType) ||
                string.IsNullOrWhiteSpace(billText) ||
                string.IsNullOrWhiteSpace(percentText) ||
                string.IsNullOrWhiteSpace(unitsText))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            percentText = percentText.Replace("%", "").Trim();

            if (!decimal.TryParse(billText, out decimal bill) ||
                !decimal.TryParse(percentText, out decimal percentUsed) ||
                !decimal.TryParse(unitsText, out decimal unitsProduced))
            {
                MessageBox.Show("Please enter valid numbers. For Production %, you can enter values like '25%'.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (unitsProduced == 0)
            {
                MessageBox.Show("Estimated Units Produced cannot be zero.", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal percentDecimal = percentUsed / 100;

            decimal UC = (bill * percentDecimal) / unitsProduced;

            string[] row = new string[]
            {
           expenseType,
           bill.ToString("0.##"),
           percentUsed.ToString("0.##") + "%",
           unitsProduced.ToString("0.##"),
           UC.ToString("0.####")
            };

            Util_DataGridView.Rows.Add(row);


            Expenses_txt.Clear();
            Month_txt.Clear();
            Production_txt.Clear();

        }

        private void TotalUc_btn_Click(object sender, EventArgs e)
        {
            decimal totalUC = 0;

            // Get total units produced from textbox
            if (!decimal.TryParse(Up_txtbox.Text, out decimal unitsProduced) || unitsProduced <= 0)
            {
                MessageBox.Show("Please enter a valid number of units produced.");
                return;
            }

            foreach (DataGridViewRow row in Util_DataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                decimal uc = 0;
                if (decimal.TryParse(Convert.ToString(row.Cells[4].Value), out uc))
                {
                    totalUC += uc * unitsProduced; // Multiply per-unit cost by total units
                }
            }

            Uc_result.Text = totalUC.ToString("0.##");
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if (foodCategory2Form == null || foodCategory2Form.IsDisposed)
            {
                foodCategory2Form = new FoodCategory2cs(this);
            }

            foodCategory2Form.ProductNameFromCategory = product_nametxtbox.Text;
            foodCategory2Form.Show();
            this.Hide();
        }

        private void Laborhrrate_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbr_addbtn_Click(object sender, EventArgs e)
        {
            string name = lbrname_txtbox.Text.Trim();
            if (!decimal.TryParse(Hrwork_txtbox.Text.Trim(), out decimal hoursWorked) ||
                !decimal.TryParse(Laborhrrate_txtbox.Text.Trim(), out decimal hourlyRate))
            {
                MessageBox.Show("Please enter valid numbers for hours worked and hourly rate.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter the laborer's name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subtotal = hoursWorked * hourlyRate * 2;

            lbr_datagridview.Rows.Add(name, hoursWorked, hourlyRate, subtotal.ToString("0.##"));

            lbrname_txtbox.Clear();
            Hrwork_txtbox.Clear();
            Laborhrrate_txtbox.Clear();
        }

        private void Uc_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_lbr_Click(object sender, EventArgs e)
        {
            double totalLaborCost = 0;

            foreach (DataGridViewRow row in lbr_datagridview.Rows)
            {
                if (row.IsNewRow) continue;

                bool parseHours = double.TryParse(row.Cells[1].Value?.ToString(), out double hoursWorked);
                bool parseRate = double.TryParse(row.Cells[2].Value?.ToString(), out double hourRate);

                if (parseHours && parseRate)
                {
                    double subtotal = hoursWorked * hourRate;
                    row.Cells[3].Value = subtotal.ToString("F2");
                    totalLaborCost += subtotal;
                }
                else
                {
                    MessageBox.Show("Please make sure Hours Worked and Hour Rate are valid numbers.");
                    return;
                }
            }


            if (double.TryParse(Up_txtbox.Text, out double totalUnits) && totalUnits > 0)
            {
                double costPerUnit = totalLaborCost / totalUnits;

                Tlc_txtbox.Text = totalLaborCost.ToString("F2");
                laborCostPerUnitTxt.Text = costPerUnit.ToString("F2");
            }
            else
            {
                MessageBox.Show("Please enter a valid number for Units Produced.");
            }
        }

        private void Pu_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void metric_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Month_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Up_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void product_nametxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

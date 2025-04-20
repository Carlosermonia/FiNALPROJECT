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
        public partial class Beautycategory : Form
        {
        private BeautyCategory2? beautyCategory2Form;
        public Beautycategory()
            {
                InitializeComponent();

                Mu_cmb.Items.Add("kg");
                Mu_cmb.Items.Add("g");
                Mu_cmb.Items.Add("L");
                Mu_cmb.Items.Add("ml");
                Mu_cmb.Items.Add("oz");
                Mu_cmb.Items.Add("tsp");
                Mu_cmb.Items.Add("tbsp");
                Mu_cmb.Items.Add("drop");
                Mu_cmb.Items.Add("pc");
                Mu_cmb.Items.Add("unit");

                Mu_cmb.SelectedIndex = 0;

                Costd_cmb.Items.Clear();
                Costd_cmb.Items.Add("Monthly");
            }

            private void Back_picbox_Click(object sender, EventArgs e)
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

            private void Ing_txt_TextChanged(object sender, EventArgs e)
            {

            }

            private void label6_Click(object sender, EventArgs e)
            {

            }

            private void label5_Click(object sender, EventArgs e)
            {



            }
            private decimal ConvertQuantityForCalculation(decimal quantity, string unit)
            {
                unit = unit.ToLower();


                if (unit == "ml")
                    return quantity / 1000m; // ml to liters
                else if (unit == "g")
                    return quantity / 1000m; // g to kilograms


                return quantity;
            }
            private string GetUnitSymbol(string unitDisplay)
            {
                if (unitDisplay.Contains("kg")) return "kg";
                if (unitDisplay.Contains("g")) return "g";
                if (unitDisplay.Contains("L")) return "L";
                if (unitDisplay.Contains("ml")) return "ml";
                if (unitDisplay.Contains("oz")) return "oz";
                if (unitDisplay.Contains("tsp")) return "tsp";
                if (unitDisplay.Contains("tbsp")) return "tbsp";
                if (unitDisplay.Contains("drop")) return "drop";
                if (unitDisplay.Contains("pc")) return "pc";
                if (unitDisplay.Contains("unit")) return "unit";
                return "";
            }

            private void Add_btn_Click(object sender, EventArgs e)
            {
                string ingredient = Ing_txt.Text.Trim();
                string quantityText = Qua_txt.Text.Trim();
                string costText = Costpu_txt.Text.Trim();
                string unit = Mu_cmb.SelectedItem?.ToString() ?? "";

                // Validation
                if (string.IsNullOrWhiteSpace(ingredient) ||
                    string.IsNullOrWhiteSpace(quantityText) ||
                    string.IsNullOrWhiteSpace(costText) ||
                    string.IsNullOrWhiteSpace(unit))
                {
                    MessageBox.Show("Please fill in all fields before adding.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse numbers
                if (!decimal.TryParse(quantityText, out decimal quantity) || quantity <= 0 ||
                    !decimal.TryParse(costText, out decimal costPerUnit) || costPerUnit <= 0)
                {
                    MessageBox.Show("Please enter valid numeric values for quantity and cost per unit.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Convert quantity if needed for calculation
                decimal quantityForCalculation = ConvertQuantityForCalculation(quantity, unit);

                // Compute subtotal
                decimal subtotal = quantityForCalculation * costPerUnit;

                // Add to DataGridView (display original quantity + symbol, but use converted value for subtotal)
                Rmc_dgv.Rows.Add(
                    ingredient,
                    $"{quantity} {GetUnitSymbol(unit)}",
                    costPerUnit.ToString("0.00"),
                    subtotal.ToString("0.00")
                );

                // Clear input
                Ing_txt.Clear();
                Qua_txt.Clear();
                Costpu_txt.Clear();
                Mu_cmb.SelectedIndex = 0;
            }

            private void Totalrmc_btn_Click(object sender, EventArgs e)
            {
                decimal totalRMC = 0;

                foreach (DataGridViewRow row in Rmc_dgv.Rows)
                {

                    if (row.IsNewRow) continue;


                    if (decimal.TryParse(Convert.ToString(row.Cells[3].Value), out decimal subtotal))
                    {
                        totalRMC += subtotal;
                    }
                }


                Totalrmc_txt.Text = totalRMC.ToString("0.00");
            }

            private void label13_Click(object sender, EventArgs e)
            {

            }

            private void label14_Click(object sender, EventArgs e)
            {

            }

            private void Add_lbrbtn_Click(object sender, EventArgs e)
            {
                string name = Lbrname_txt.Text.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter the laborer's name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(Lbrhrwrk_txt.Text.Trim(), out decimal hoursWorked) ||
                    !decimal.TryParse(Lbrhrrate_txt.Text.Trim(), out decimal hourlyRate))
                {
                    MessageBox.Show("Please enter valid numbers for hours worked and hourly rate.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Subtotal = hours worked * hourly rate
                decimal subtotal = hoursWorked * hourlyRate;


                Lbr_dgv.Rows.Add(name, hoursWorked, hourlyRate, subtotal.ToString("0.##"));

                Lbrname_txt.Clear();
                Lbrhrwrk_txt.Clear();
                Lbrhrrate_txt.Clear();
            }

            private void Totalbr_btn_Click(object sender, EventArgs e)
            {
                decimal totalLaborCost = 0;

                foreach (DataGridViewRow row in Lbr_dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    if (decimal.TryParse(Convert.ToString(row.Cells[3].Value), out decimal subtotal))
                    {
                        totalLaborCost += subtotal;
                    }
                }

                Totallbr_txt.Text = totalLaborCost.ToString("0.##");

                if (int.TryParse(Producedu_txt.Text.Trim(), out int servings) && servings > 0)
                {
                    decimal laborPerUnit = totalLaborCost / servings;
                    Laborcostpu_txt.Text = laborPerUnit.ToString("0.##");
                }
                else
                {
                    MessageBox.Show("Please enter a valid number of servings.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            private void Adddutil_btn_Click(object sender, EventArgs e)
        {
            try
            {
                // Get values from input fields
                string utilityType = Beautyexp_txt.Text.Trim();
                string costDuration = Costd_cmb.SelectedItem?.ToString() ?? "N/A";
                double monthlyBill = double.Parse(Ca_txt.Text);
                double productionPercent = double.Parse(Pp_txt.Text) / 100.0;
                int unitsProduced = int.Parse(Producedu_txt.Text);

                if (unitsProduced == 0)
                {
                    MessageBox.Show("Units produced cannot be zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculations
                double estimatedCost = monthlyBill * productionPercent;
                double costPerUnit = estimatedCost / unitsProduced;

                // Add row to DataGridView
                Util_dgv.Rows.Add(
                utilityType,
                $"₱{monthlyBill:N2}",
                $"₱{estimatedCost:N2}",
                unitsProduced,
                $"₱{costPerUnit:N2}"
                );

                Beautyexp_txt.Clear();
                Ca_txt.Clear();
                Pp_txt.Clear();
                Producedu_txt.Clear();
                Costd_cmb.SelectedIndex = 0;
            }
            catch (FormatException)
                {
                    MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void Uctotal_btn_Click(object sender, EventArgs e)
            {

                decimal totalUC = 0;

                // Get total units produced from textbox
                if (!decimal.TryParse(Producedu_txt.Text, out decimal unitsProduced) || unitsProduced <= 0)
                {
                    MessageBox.Show("Please enter a valid number of units produced.");
                    return;
                }

                foreach (DataGridViewRow row in Util_dgv.Rows)
                {
                    if (row.IsNewRow) continue;

                    // Defensive: check if the cell exists and has a non-null value
                    if (row.Cells.Count > 4 && row.Cells[4].Value is string cellText && !string.IsNullOrWhiteSpace(cellText))
                    {
                        // Clean the currency string
                        string cleaned = cellText.Replace("₱", "").Replace(",", "").Trim();

                        if (decimal.TryParse(cleaned, out decimal uc))
                        {
                            totalUC += uc * unitsProduced;
                        }
                    }
                }

                // Show total in currency format
                Ucresult_txt.Text = $"₱{totalUC:N2}";
            }

            private void label17_Click(object sender, EventArgs e)
            {
            if (beautyCategory2Form == null || beautyCategory2Form.IsDisposed)
            {
                beautyCategory2Form = new BeautyCategory2(this); // pass reference
            }

            beautyCategory2Form.Show();
            this.Hide();
        }

            private void Beautycategory_Load(object sender, EventArgs e)
            {

            }
        }
    }

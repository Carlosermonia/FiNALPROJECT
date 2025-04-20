using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using finalAppsDevProject;

namespace finalAppsDevProject
{
    public partial class FoodCategory2cs : Form
    {
        private FoodCategory _productForm;

        private string? _productNameSummary;
        private int _servingsSummary;
        private decimal _tpcSummary;
        private decimal _srpTotalSummary;
        private decimal _srpPerUnitSummary;
        private bool _isSummaryAvailable = false;

        public string? ProductNameFromCategory { get; set; }

        public FoodCategory2cs(FoodCategory productForm)
        {
            InitializeComponent();
            _productForm = productForm;

            Profitmargin_cmb.Items.Clear();
            Profitmargin_cmb.Items.Add("20%");
            Profitmargin_cmb.Items.Add("30%");
            Profitmargin_cmb.Items.Add("50%");
            Profitmargin_cmb.Items.Add("100%");
        }


        private void Add_PC_Click(object sender, EventArgs e)
        {
            string material = Pckmaterial_txt.Text.Trim();
            string qtyText = Quatity_txtbox.Text.Trim();
            string costText = Cpu_txtbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(material) ||
                string.IsNullOrWhiteSpace(qtyText) ||
                string.IsNullOrWhiteSpace(costText))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(qtyText, out decimal quantity) ||
                !decimal.TryParse(costText, out decimal costPerUnit))
            {
                MessageBox.Show("Please enter valid numeric values for Quantity and Cost per Unit.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subtotal = quantity * costPerUnit;


            string[] row = new string[]
            {
        material,
        quantity.ToString("0.##"),
        costPerUnit.ToString("0.##"),
        subtotal.ToString("0.##")
            };

            Pc_datagridview.Rows.Add(row);


            Pckmaterial_txt.Clear();
            Quatity_txtbox.Clear();
            Cpu_txtbox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal totalPC = 0;

            foreach (DataGridViewRow row in Pc_datagridview.Rows)
            {
                if (row.IsNewRow) continue;

                decimal subtotal = 0;
                decimal.TryParse(Convert.ToString(row.Cells[3].Value), out subtotal); // Subtotal column

                totalPC += subtotal;
            }

            Txtpctotal.Text = totalPC.ToString("0.##");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_overheadbtn_Click(object sender, EventArgs e)
        {
            string overheadItem = Overhead_txt.Text.Trim();
            string monthlyCostText = Moc_txt.Text.Trim();
            string prodVolumeText = Prodvol_txt.Text.Trim();

            if (string.IsNullOrWhiteSpace(overheadItem) ||
                string.IsNullOrWhiteSpace(monthlyCostText) ||
                string.IsNullOrWhiteSpace(prodVolumeText))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(monthlyCostText, out decimal monthlyCost) ||
                !decimal.TryParse(prodVolumeText, out decimal prodVolume))
            {
                MessageBox.Show("Please enter valid numeric values.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (prodVolume == 0)
            {
                MessageBox.Show("Production volume cannot be zero.", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal oc = monthlyCost / prodVolume;

            string[] row = new string[]
            {
        overheadItem,
        monthlyCost.ToString("0.##"),
        oc.ToString("0.####")
            };

            Overhead_datagrid.Rows.Add(row);

            Overhead_txt.Clear();
            Moc_txt.Clear();

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void overheadtotalbtn_Click(object sender, EventArgs e)
        {
            decimal totalMonthlyOverhead = 0;
            decimal prodVolume;


            if (!decimal.TryParse(Prodvol_txt.Text.Trim(), out prodVolume) || prodVolume <= 0)
            {
                MessageBox.Show("Please enter a valid production volume for overhead calculation.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in Overhead_datagrid.Rows)
            {
                if (row.Cells.Count > 1 && row.Cells[1].Value != null &&
                    decimal.TryParse(row.Cells[1].Value.ToString(), out decimal monthlyCost))
                {
                    totalMonthlyOverhead += monthlyCost;
                }
            }

            Totalohctxtbox.Text = totalMonthlyOverhead.ToString("0.##");

            decimal overheadPerUnit = totalMonthlyOverhead / prodVolume;
            perunitohc.Text = overheadPerUnit.ToString("0.####");
        }

        private void Overhead_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btchx_chckbox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = btchx_chckbox.Checked;

            UnitsProducedTextbox.Visible = isChecked;
            label19.Visible = isChecked;

            if (!isChecked)
            {
                UnitsProducedTextbox.Clear();
            }
        }

        private void UnitsProducedTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FoodCategory2cs_Load(object sender, EventArgs e)
        {
            bool isChecked = btchx_chckbox.Checked;

            UnitsProducedTextbox.Visible = isChecked;
            label19.Visible = isChecked;
        }

        private void add_oebtn_Click(object sender, EventArgs e)
        {
            string description = expense_txt.Text.Trim();
            string costText = costpb_txt.Text.Trim();
            bool isBatchBased = btchx_chckbox.Checked;
            string unitsProducedText = UnitsProducedTextbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(description) || string.IsNullOrWhiteSpace(costText))
            {
                MessageBox.Show("Please enter description and cost.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(costText, out decimal cost))
            {
                MessageBox.Show("Please enter a valid cost value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal costPerUnit = cost;

            if (isBatchBased)
            {
                if (string.IsNullOrWhiteSpace(unitsProducedText) || !decimal.TryParse(unitsProducedText, out decimal unitsProduced) || unitsProduced == 0)
                {
                    MessageBox.Show("Enter valid Units Produced for batch-based cost.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                costPerUnit = cost / unitsProduced;
            }

            string[] row = new string[]
            {
        description,
        cost.ToString("0.##"),
        isBatchBased ? "Yes" : "No",
        isBatchBased ? unitsProducedText : "-",
        costPerUnit.ToString("0.####")
            };

            Oe_datagridview.Rows.Add(row);


            expense_txt.Clear();
            costpb_txt.Clear();
            UnitsProducedTextbox.Clear();
            btchx_chckbox.Checked = false;
        }

        private void Totaloe_btn_Click(object sender, EventArgs e)
        {
            decimal totalOE = 0;

            foreach (DataGridViewRow row in Oe_datagridview.Rows)
            {
                if (row.IsNewRow) continue;

                if (decimal.TryParse(Convert.ToString(row.Cells[4].Value), out decimal costPerUnit))
                {
                    totalOE += costPerUnit;
                }
            }

            totaloe_txt.Text = totalOE.ToString("0.####");
        }

        private void product_costing_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product_costing_datagridview.ScrollBars = ScrollBars.Vertical;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(_productForm.ProductName) ||
                string.IsNullOrWhiteSpace(_productForm.TotalRawMaterialCost) ||
                string.IsNullOrWhiteSpace(_productForm.UtilitiesCost) ||
                string.IsNullOrWhiteSpace(_productForm.TotalLaborCost) ||
                string.IsNullOrWhiteSpace(_productForm.LaborCostPerUnit) ||
                string.IsNullOrWhiteSpace(Txtpctotal.Text) ||
                string.IsNullOrWhiteSpace(Totalohctxtbox.Text) ||
                string.IsNullOrWhiteSpace(perunitohc.Text) ||
                string.IsNullOrWhiteSpace(totaloe_txt.Text) ||
                string.IsNullOrWhiteSpace(Profitmargin_cmb.Text) ||
                string.IsNullOrWhiteSpace(Servingstxt.Text))
            {
                MessageBox.Show("Please fill in all required fields before calculating.", "Missing Inputs", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Parse values
                decimal rmc = decimal.Parse(_productForm.TotalRawMaterialCost);
                decimal uc = decimal.Parse(_productForm.UtilitiesCost);
                decimal tlc = decimal.Parse(_productForm.TotalLaborCost);
                decimal laborPerUnit = decimal.Parse(_productForm.LaborCostPerUnit);
                decimal pc = decimal.Parse(Txtpctotal.Text);
                decimal ohc = decimal.Parse(Totalohctxtbox.Text);
                decimal ohcPerUnit = decimal.Parse(perunitohc.Text);
                decimal oe = decimal.Parse(totaloe_txt.Text);

                int servings = int.Parse(Servingstxt.Text);
                string productName = _productForm.ProductName;

                if (!decimal.TryParse(Profitmargin_cmb.Text.Replace("%", ""), out decimal profitPercentage))
                {
                    MessageBox.Show("Please select a valid profit margin.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //profit 
                decimal profitMargin = profitPercentage / 100;

                // total product cost and tpc per unit
                decimal tpc = rmc + uc + tlc + pc + ohc + oe;
                decimal tpcPerUnit = servings > 0 ? tpc / servings : 0;

                // Calculate selling price (SRP)
                decimal srpTotal = tpc * (1 + profitMargin);
                decimal srpPerUnit = servings > 0 ? srpTotal / servings : 0;

                // Clear the DataGridView
                product_costing_datagridview.Rows.Clear();

                // Helper to add cost breakdown rows
                void AddRow(string category, decimal amount, decimal totalCost)
                {
                    decimal percentage = (amount / totalCost) * 100;
                    product_costing_datagridview.Rows.Add(category,
                        "₱" + amount.ToString("0.00"),
                        percentage.ToString("0.##") + "%");
                }

                // Add breakdown rows
                AddRow("Raw Material Cost", rmc, tpc);
                AddRow("Utilities Cost", uc, tpc);
                AddRow("Labor Cost", tlc, tpc);
                AddRow("Packaging Cost", pc, tpc);
                AddRow("Overhead Cost", ohc, tpc);
                AddRow("Other Expenses", oe, tpc);

                // Add summary rows
                product_costing_datagridview.Rows.Add("Total Product Cost", "₱" + tpc.ToString("0.00"), "100%");
                product_costing_datagridview.Rows.Add("Cost per Unit", "₱" + tpcPerUnit.ToString("0.00"), "-");
                product_costing_datagridview.Rows.Add("SRP (Total)", "₱" + srpTotal.ToString("0.00"), "-");
                product_costing_datagridview.Rows.Add("SRP per Unit", "₱" + srpPerUnit.ToString("0.00"), "-");

                ProductSummaryDialog summaryForm = new ProductSummaryDialog();
                summaryForm.SetSummaryData(ProductNameFromCategory ?? "Unnamed Product", servings, tpc, srpTotal, srpPerUnit);
                summaryForm.ShowDialog();

                _productNameSummary = productName;
                _servingsSummary = servings;
                _tpcSummary = tpc;
                _srpTotalSummary = srpTotal;
                _srpPerUnitSummary = srpPerUnit;
                _isSummaryAvailable = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred during calculation:\n" + ex.Message, "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txtpctotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_picbox_Click(object sender, EventArgs e)
        {
            _productForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!_isSummaryAvailable)
            {
                MessageBox.Show("Please calculate the product cost first before viewing the summary.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ProductSummaryDialog summaryForm = new ProductSummaryDialog();
            summaryForm.SetSummaryData(ProductNameFromCategory ?? "Unnamed Product", _servingsSummary, _tpcSummary, _srpTotalSummary, _srpPerUnitSummary);
            summaryForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to go back to the category section?  progress might be lost.",
        "Confirm Navigation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Category categoryForm = new Category();
                categoryForm.Show();
                this.Hide();
            }
        }
    }
}
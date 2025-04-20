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
    public partial class BeautyCategory2 : Form
    {
        private Beautycategory _beautyCategory;
        public BeautyCategory2(Beautycategory beautyCategory)
        {
            InitializeComponent();
            _beautyCategory = beautyCategory;

            Beautypm_cmb.Items.Clear();
            Beautypm_cmb.Items.Add("20%");
            Beautypm_cmb.Items.Add("30%");
            Beautypm_cmb.Items.Add("50%");
            Beautypm_cmb.Items.Add("100%");
        }

        private void Add_pcbtn_Click(object sender, EventArgs e)
        {
            string material = Beautypck_txt.Text.Trim();
            string qtyText = BeautyQua_txtbox.Text.Trim();
            string costText = Cpubeauty_txt.Text.Trim();

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

            Pc_dgv.Rows.Add(row);


            Beautypck_txt.Clear();
            BeautyQua_txtbox.Clear();
            Cpubeauty_txt.Clear();
        }

        private void Calc_btn_Click(object sender, EventArgs e)
        {
            decimal totalPC = 0;

            foreach (DataGridViewRow row in Pc_dgv.Rows)
            {
                if (row.IsNewRow) continue;

                decimal subtotal = 0;
                decimal.TryParse(Convert.ToString(row.Cells[3].Value), out subtotal); // Subtotal column

                totalPC += subtotal;
            }

            Pctotal_txt.Text = totalPC.ToString("0.##");
        }

        private void Add_ohbtn_Click(object sender, EventArgs e)
        {
            string overheadItem = Oh_txt.Text.Trim();
            string monthlyCostText = Beautymoc_txt.Text.Trim();
            string prodVolumeText = Prodvolbeauty_txt.Text.Trim();

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

            Overhead_dgv.Rows.Add(row);

            Oh_txt.Clear();
            Beautymoc_txt.Clear();
        }

        private void Overheadtotal_btn_Click(object sender, EventArgs e)
        {
            decimal totalMonthlyOverhead = 0;
            decimal prodVolume;


            if (!decimal.TryParse(Prodvolbeauty_txt.Text.Trim(), out prodVolume) || prodVolume <= 0)
            {
                MessageBox.Show("Please enter a valid production volume for overhead calculation.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataGridViewRow row in Overhead_dgv.Rows)
            {
                if (row.Cells.Count > 1 && row.Cells[1].Value != null &&
                    decimal.TryParse(row.Cells[1].Value.ToString(), out decimal monthlyCost))
                {
                    totalMonthlyOverhead += monthlyCost;
                }
            }

            Totaloh_txt.Text = totalMonthlyOverhead.ToString("0.##");

            decimal overheadPerUnit = totalMonthlyOverhead / prodVolume;
            Perunit_ohc.Text = overheadPerUnit.ToString("0.####");
        }

        private void Back_picbox_Click(object sender, EventArgs e)
        {
            _beautyCategory.Show(); // show original Beautycategory
            this.Hide(); //
        }

        private void Btchx_chckbox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = Btchx_Chckbox.Checked;

            UnitsProduced_Textbox.Visible = isChecked;
            label19.Visible = isChecked;

            if (!isChecked)
            {
                UnitsProduced_Textbox.Clear();
            }
        }

        private void Add_oebtn_Click(object sender, EventArgs e)
        {
            string description = Expense_txt.Text.Trim();
            string costText = Costpb_txt.Text.Trim();
            bool isBatchBased = Btchx_Chckbox.Checked;
            string unitsProducedText = UnitsProduced_Textbox.Text.Trim();

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

            Oe_dgv.Rows.Add(row);


            Expense_txt.Clear();
            Costpb_txt.Clear();
            UnitsProduced_Textbox.Clear();
            Btchx_Chckbox.Checked = false;
        }

        private void Totaloe_btnbeauty_Click(object sender, EventArgs e)
        {
            decimal totalOE = 0;

            foreach (DataGridViewRow row in Oe_dgv.Rows)
            {
                if (row.IsNewRow) continue;

                if (decimal.TryParse(Convert.ToString(row.Cells[4].Value), out decimal costPerUnit))
                {
                    totalOE += costPerUnit;
                }
            }

            Totaloe_txt.Text = totalOE.ToString("0.####");
        }

        private void Beautypm_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

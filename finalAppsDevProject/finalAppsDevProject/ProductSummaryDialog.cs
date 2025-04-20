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
    public partial class ProductSummaryDialog : Form
    {
         
        public ProductSummaryDialog()
        {
            InitializeComponent();
        }
        public void SetSummaryData(string productName, int servings, decimal totalProductCost, decimal srpTotal, decimal srpPerUnit)
        {
            View_product.Text = productName;
            View_unit.Text = servings.ToString();
            View_tpc.Text = "₱" + totalProductCost.ToString("0.00");
            View_srp.Text = "₱" + srpTotal.ToString("0.00");
            View_srppe.Text = "₱" + srpPerUnit.ToString("0.00");
        }

        private void ProductSummaryDialog_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void View_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

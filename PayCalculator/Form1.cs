using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayCalculator
{
    public partial class Form1 : Form
    {
        double hours;
        double payRate;
        double preTax;
        double taxRate = 300.00;
        double taxAmount;
        double totalEarning;

        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                hours = Convert.ToDouble(hoursInput.Text);
                payRate = Convert.ToDouble(payRateInput.Text);
                preTax = hours * payRate;
                pretaxOutput.Text = $"{preTax.ToString("C")}";

                taxAmount = preTax * taxRate;
                totalEarning = preTax - taxAmount;
                taxOutput.Text = $"{taxAmount.ToString("C")}";
                earnedOutput.Text = $"{totalEarning.ToString("C")}";
            }
            catch
            {
                pretaxOutput.Text = "error";
                pretaxOutput.ForeColor = Color.Red;

            }
        }
    }
}

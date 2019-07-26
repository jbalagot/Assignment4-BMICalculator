using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            CalculateBmiButton.Enabled = false;
        }
       
        private void CalculateBmiButton_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(HeightTextBox.Text);
            double weight = Convert.ToDouble(WeightTextBox.Text);

            double bmi = 0;
            if (ImperialRadioButton.Checked == true)
            {
                bmi = weight * 703 / (height * height);
            }
            else if (MetricRadioButton.Checked == true)
            {
                bmi = weight / (height * height);
            }
            else
            {
                ScaleResultTextBox.Text = "Select Unit";
                ResultTextBox.Text = "";
            }

            ResultTextBox.Text = bmi.ToString();
            
        }
        private void UnitRadioButton_Click(object sender, EventArgs e)
        {
            CalculateBmiButton.Enabled = true;
        }
        private void BMICalculatorForm_FormCLosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightTextBox.Text = String.Empty;
            WeightTextBox.Text = String.Empty;
            ResultTextBox.Text = String.Empty;
            ScaleResultTextBox.Text = String.Empty;
        }

        private void UnitRadioButton(object sender, EventArgs e)
        {

        }
    }
}

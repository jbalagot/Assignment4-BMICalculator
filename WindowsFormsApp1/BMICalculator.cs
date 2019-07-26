using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Author's Name: Jeannery Mae Balagot
// Student number: 301051646

namespace WindowsFormsApp1
{
    public partial class BMICalculatorForm : Form
    {
        public BMICalculatorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// At the load event, this will disabled the calculate BMI button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            CalculateBmiButton.Enabled = false;
        }
        /// <summary>
        /// This event handler will calculate the values given at the textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
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
            if (bmi < 18.5)
            {
                ScaleResultTextBox.Text = "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                ScaleResultTextBox.Text = "Normal";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                ScaleResultTextBox.Text = "Overweight";
            }
            else if(bmi >= 30)
            {
                ScaleResultTextBox.Text = "Obese";
               
            }
            else
            {
                ScaleResultTextBox.Text = "Error!";
            }


            ResultTextBox.Text = bmi.ToString();
            
        }
        /// <summary>
        /// This event handler will enable the CalculateBMI button once one of the unitradio button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnitRadioButton_Click(object sender, EventArgs e)
        {
            CalculateBmiButton.Enabled = true;
        }
        /// <summary>
        /// This event handler will close the form once you click the exit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BMICalculatorForm_FormCLosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// This Event handler will Empty the form when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

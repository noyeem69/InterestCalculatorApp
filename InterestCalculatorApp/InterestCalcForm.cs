using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculatorApp
{
    public partial class InterestCalcForm : Form
    {
        public InterestCalcForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            InterestCalculation objInterestCalculation = new InterestCalculation();

            objInterestCalculation.principalAmount = Convert.ToDouble(principalAmountTextBox.Text);
            objInterestCalculation.interestRate = Convert.ToDouble(interestTextBox.Text);
            objInterestCalculation.period = Convert.ToInt32(periodTextBox.Text);
            objInterestCalculation.result = objInterestCalculation.principalAmount;
            for ( int i=0; i< objInterestCalculation.period ; i++)
            {
                objInterestCalculation.result += (objInterestCalculation.result)*objInterestCalculation.interestRate/100;
            }
            resultTextBox.Text = objInterestCalculation.result.ToString();
        }
    }
}

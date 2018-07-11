using System;
using System.Windows.Forms;
using calculator.OneArgument;
using calculator.TwoArgument;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(textNumber1.Text);
                double secondNumber = Convert.ToDouble(textNumber2.Text);
                ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(firstNumber, secondNumber);
                textResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                textResult.Text = "mistake: " + ex.Message;
            }
        }
        private void buttontwo_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(textNumber1.Text);
                IOneArgumentFactory calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(firstNumber);
                textResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                textResult.Text = "mistake: " + ex.Message;
            }
        }
        private void textNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelFife_Click(object sender, EventArgs e)
        {

        }
    }
}

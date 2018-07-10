using System;
using System.Windows.Forms;

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
            double firstNumber = Convert.ToDouble(textNumber1.Text);
            double secondNumber = Convert.ToDouble(textNumber2.Text);
            ITwoArgumentsCalculator Calculate = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = Calculate.Calculate(firstNumber, secondNumber);
            textResult.Text = result.ToString();
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
    }
}

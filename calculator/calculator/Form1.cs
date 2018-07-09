using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number1, number2, result;

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textNumber1.Text);
            number2 = Convert.ToDouble(textNumber2.Text);
            result = number1 + number2;
            textResult.Text = result.ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textNumber1.Text);
            number2 = Convert.ToDouble(textNumber2.Text);
            result = number1 - number2;
            textResult.Text = result.ToString();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textNumber1.Text);
            number2 = Convert.ToDouble(textNumber2.Text);
            result = number1 * number2;
            textResult.Text = result.ToString();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(textNumber1.Text);
            number2 = Convert.ToDouble(textNumber2.Text);
            result = number1 / number2;
            textResult.Text = result.ToString();
        }

        private void textResult_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNumber1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

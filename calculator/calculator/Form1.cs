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

        private void button_Click(object sender, EventArgs e)
        {

            double firstNumber = Convert.ToDouble(textNumber1.Text);
            double secondNumber = Convert.ToDouble(textNumber2.Text);
            double result;

            switch (((Button)sender).Name)
            {
                case "buttonPlus":
                    result = firstNumber + secondNumber;
                    break;
                case "buttonMinus":
                    result = firstNumber - secondNumber;
                    break;
                case "buttonMultiply":
                    result = firstNumber * secondNumber;
                    break;
                case "buttonDivide":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
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

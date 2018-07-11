using System;
namespace calculator.OneArgument
{
    public class OneArgumentFactory
    {
        /// <summary>
        /// fabrica for function of one variables 
        /// </summary>
        /// the definition of the function on click
        /// <param name="calculatorName"></param>
        /// <returns>
        /// Return incstanse of class
        /// </returns>
        public static IOneArgumentFactory CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Cosinus":
                    return new Cosinus();
                case "Sinus":
                    return new Sinus();
                case "Square":
                    return new Square();
                case "Tangens":
                    return new Tangens();
                case "Arccos":
                    return new Arccos();
                case "Arcsin":
                    return new Arcsin();
                case "Arctg":
                    return new Arctg();
                case "Cube":
                    return new Cube();
                case "Exp":
                    return new Exp();
                case "Fraction":
                    return new Fraction();
                case "Ln":
                    return new Ln();
                case "Module":
                    return new Module();
                case "TenExp":
                    return new TenExp();
                case "TwoExp":
                    return new TwoExp();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

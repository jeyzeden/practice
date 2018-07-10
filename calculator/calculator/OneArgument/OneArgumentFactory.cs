using System;
namespace calculator.OneArgument
{
    public class OneArgumentFactory
    {
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
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

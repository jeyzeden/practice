using System;
namespace calculator.TwoArgument
{
    public class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Multiply":
                    return new Multiply();
                case "Division":
                    return new Division();
                case "Addition":
                    return new Addition();
                case "Substraction":
                    return new Substraction();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

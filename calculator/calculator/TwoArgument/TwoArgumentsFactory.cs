using System;
namespace calculator.TwoArgument
{
    public class TwoArgumentsFactory
    {
        /// <summary>
        /// Create Factory
        /// </summary>
        /// <param name="calculatorName"></param>
        /// <returns></returns>
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
                case "MultiplyCube":
                    return new MultiplyCube();
                case "DivisionCube":
                    return new DivisionCube();
                case "AdditionCube":
                    return new AdditionCube();
                case "SubstractionSquare":
                    return new SubstractionSquare();
                case "MultiplySquare":
                    return new MultiplySquare();
                case "DivisionSquare":
                    return new DivisionSquare();
                case "AdditionSquare":
                    return new AdditionSquare();
                case "Max":
                    return new Max();
                case "Min":
                    return new Min();
                case "Pow":
                    return new Pow();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

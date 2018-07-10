using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "MultiplyCalculator":
                    return new MultiplyCalculator();
                case "DivisionCalculator":
                    return new DivisionCalculator();
                case "AdditionCalculator":
                    return new AdditionCalculator();
                case "SubstractionCalculator":
                    return new SubstractionCalculator();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

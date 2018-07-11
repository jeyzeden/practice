using calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Test.TwoArgument
{
    [TestFixture]
    public class MinTest
    {
        [TestCase(1, 3, 1)]
        [TestCase(2, 3, 2)]
        [TestCase(4, 2, 2)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Min");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
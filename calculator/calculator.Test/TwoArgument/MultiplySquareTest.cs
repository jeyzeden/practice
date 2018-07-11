using calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Test.TwoArgument
{
    [TestFixture]
    public class MultiplySquareTest
    {
        [TestCase(1, 3, 9)]
        [TestCase(2, 3, 36)]
        [TestCase(4, 2, 64)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("MultiplySquare");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}

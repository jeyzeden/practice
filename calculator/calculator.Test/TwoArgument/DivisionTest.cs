using calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Test.TwoArgument
{
    [TestFixture]
    public class DivisionTest
    {
        [TestCase(1, 3, 0.33)]
        [TestCase(2, 3, 0.66)]
        [TestCase(4, 2, 2)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Division");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}

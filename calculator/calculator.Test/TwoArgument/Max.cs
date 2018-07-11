using calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Test.TwoArgument
{
    [TestFixture]
    public class MaxTest
    {
        [TestCase(1, 3, 3)]
        [TestCase(2, 3, 3)]
        [TestCase(4, 2, 4)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Max");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}

using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Test.OneArgument
{
    [TestFixture]
    public class ExpTest
    {
        [TestCase(0, 1)]
        [TestCase(1, 2.72)]
        [TestCase(2, 7.38)]
        public void FirstTest(double value, double expected)
        {
            IOneArgumentFactory calculator = OneArgumentFactory.CreateCalculator("Exp");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
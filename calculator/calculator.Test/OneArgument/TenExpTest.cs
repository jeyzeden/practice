using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Test.OneArgument
{
    [TestFixture]
    public class TenExpTest
    {
        [TestCase(3, 1000)]
        [TestCase(4, 10000)]
        [TestCase(2, 100)]
        public void FirstTest(double value, double expected)
        {
            IOneArgumentFactory calculator = OneArgumentFactory.CreateCalculator("TenExp");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
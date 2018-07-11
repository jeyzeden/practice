using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Test.OneArgument
{
    [TestFixture]
    public class LnTest
    {
        [TestCase(5, 1.60)]
        [TestCase(1, 0)]
        [TestCase(10, 2.30)]
        public void FirstTest(double value, double expected)
        {
            IOneArgumentFactory calculator = OneArgumentFactory.CreateCalculator("Ln");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
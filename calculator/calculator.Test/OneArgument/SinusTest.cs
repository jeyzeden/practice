using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Test.OneArgument
{
    [TestFixture]
    public class SinusTest
    {
        [TestCase(0, 0)]
        [TestCase(3.14, 0.01)]
        [TestCase(5, -0.95)]
        public void FirstTest(double value, double expected)
        {
            IOneArgumentFactory calculator = OneArgumentFactory.CreateCalculator("Sinus");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}

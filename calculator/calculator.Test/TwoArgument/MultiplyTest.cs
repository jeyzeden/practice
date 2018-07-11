using calculator.TwoArgument;
using NUnit.Framework;

namespace calculator.Test.TwoArgument
{
    [TestFixture]
    public class MultiplyTest
    {
        [Test]
        public void FirstTest()
        {
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator("Multiply");
            double result = calculator.Calculate(5, 5);
            Assert.AreEqual(25, result);
        }
    }
}

using System;
using calculator.OneArgument;
using NUnit.Framework;

namespace calculator.Test.FactoryTest
{
    class OneArgumentFactoryTest
    {
        [TestCase("Cosinus", typeof(Cosinus))]
        [TestCase("Tangens", typeof(Tangens))]
        public void FirstTest(string name, Type type)
        {
            var calculator = OneArgumentFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}

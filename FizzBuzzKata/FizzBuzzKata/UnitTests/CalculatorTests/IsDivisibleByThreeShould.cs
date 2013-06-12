using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.CalculatorTests
{
    [TestFixture]
    class IsDivisibleByThreeShould
    {
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void ReturnTrueIfNumberIsDivisibleByThree()
        {
            var expectedValue = true;

            var actualValue = _calculator.IsDivisibleByThree(6);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnFalseIfNumberIsNotDivisibleByThree()
        {
            var expectedValue = false;

            var actualValue = _calculator.IsDivisibleByThree(2);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

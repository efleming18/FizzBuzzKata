using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.FizzBuzzTests
{
    [TestFixture]
    class IsDivisibleByFiveShould
    {
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void ReturnTrueWhenInputIsDivisibleByFive()
        {
            var expectedValue = true;

            var actualValue = _calculator.IsDivisibleByFive(5);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnFalseWhenInputIsNotDivisibleByFive()
        {
            var expectedValue = false;

            var actualValue = _calculator.IsDivisibleByFive(7);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

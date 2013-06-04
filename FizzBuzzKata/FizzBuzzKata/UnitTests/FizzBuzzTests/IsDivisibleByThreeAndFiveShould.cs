using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.FizzBuzzTests
{
    [TestFixture]
    class IsDivisibleByThreeAndFiveShould
    {
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void ReturnTrueWhenInputIsDivisibleByThreeAndFive()
        {
            var expectedValue = true;

            var actualValue = _calculator.IsDivisibleByThreeAndFive(15);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnFalseWhenInputIsNotDivisibleByThree()
        {
            var expectedValue = false;

            var actualValue = _calculator.IsDivisibleByThreeAndFive(5);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnFalseWhenInputIsNotDivisibleByFive()
        {
            var expectedValue = false;

            var actualValue = _calculator.IsDivisibleByThreeAndFive(3);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.FizzBuzzTests
{
    [TestFixture]
    class IsDivisibleByThreeShould
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void ReturnTrueIfNumberIsDivisibleByThree()
        {
            var expectedValue = true;

            var actualValue = _fizzBuzz.IsDivisibleByThree(6);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnFalseIfNumberIsNotDivisibleByThree()
        {
            var expectedValue = false;

            var actualValue = _fizzBuzz.IsDivisibleByThree(2);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

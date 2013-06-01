using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.FizzBuzzTests
{
    [TestFixture]
    class IsDivisibleByThreeShould
    {
        [Test]
        public void ReturnTrueIfNumberIsDivisibleByThree()
        {
            var fizzBuzz = new FizzBuzz();
            var actualValue = fizzBuzz.IsDivisibleByThree(6);

            var expectedValue = true;

            Assert.AreEqual(actualValue, expectedValue);
        }

        [Test]
        public void ReturnFalseIfNumberIsNotDivisibleByThree()
        {
            var fizzBuzz = new FizzBuzz();
            var expectedValue = false;

            var actualValue = fizzBuzz.IsDivisibleByThree(2);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

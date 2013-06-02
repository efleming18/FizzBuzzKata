using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.FizzBuzzTests
{
    [TestFixture]
    class IsDivisibleByFiveShould
    {
        [Test]
        public void ReturnTrueWhenInputIsDivisibleByFive()
        {
            var fizzBuzz = new FizzBuzz();
            var expectedValue = true;

            var actualValue = fizzBuzz.IsDivisibleByFive(5);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

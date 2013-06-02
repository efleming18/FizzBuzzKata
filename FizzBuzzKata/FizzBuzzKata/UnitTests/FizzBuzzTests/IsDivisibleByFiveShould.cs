using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.FizzBuzzTests
{
    [TestFixture]
    class IsDivisibleByFiveShould
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void ReturnTrueWhenInputIsDivisibleByFive()
        {
            var expectedValue = true;

            var actualValue = _fizzBuzz.IsDivisibleByFive(5);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

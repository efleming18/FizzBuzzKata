using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.FizzBuzzTests
{
    [TestFixture]
    class IsDivisibleByThreeAndFiveShould
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            this._fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void ReturnTrueWhenInputIsDivisibleByThreeAndFive()
        {
            var expectedValue = true;
            var actualValue = _fizzBuzz.IsDivisibleByThreeAndFiveShould(15);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

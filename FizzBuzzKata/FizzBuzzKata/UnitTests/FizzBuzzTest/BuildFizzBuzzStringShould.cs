using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.FizzBuzzTest
{
    [TestFixture]
    public class BuildFizzBuzzStringShould
    {
        [Test]
        public void ReturnFizzIfDivisibleByThree()
        {
            var fizzBuzz = new FizzBuzz();

            string expectedValue = "Fizz";
            string actualValue = fizzBuzz.BuildFizzBuzzString();

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

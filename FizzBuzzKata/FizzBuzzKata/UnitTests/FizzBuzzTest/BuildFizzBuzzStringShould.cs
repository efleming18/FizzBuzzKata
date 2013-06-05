using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.FizzBuzzTest
{
    [TestFixture]
    public class BuildFizzBuzzStringShould
    {
        private FizzBuzz _fizzBuzz;
        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void ReturnFizzIfInputIsDivisibleByThreeButNotFive()
        {
            string expectedValue = "Fizz";

            string actualValue = _fizzBuzz.BuildFizzBuzzString(3);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnBuzzIfInputIsDivisibleByFiveButNotThree()
        {
            string expectedValue = "Buzz";

            string actualValue = _fizzBuzz.BuildFizzBuzzString(5);
            
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnFizzBuzzIfInputIsDivisibleByThreeAndFive()
        {
            string expectedValue = "FizzBuzz";

            string actualValue = _fizzBuzz.BuildFizzBuzzString(15);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnTheInputIfNotDivisibleByThreeOrFive()
        {
            int input = 2;
            string expectedValue = input.ToString();

            string actualValue = _fizzBuzz.BuildFizzBuzzString(input);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

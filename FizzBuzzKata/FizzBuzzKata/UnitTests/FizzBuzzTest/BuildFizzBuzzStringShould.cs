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
        public void ReturnFizzIfInputIsDivisibleByThree()
        {
            string expectedValue = "Fizz";

            string actualValue = _fizzBuzz.BuildFizzBuzzString(3);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnBuzzIfInputIsDivisibleByFive()
        {
            string expectedValue = "Buzz";

            string actualValue = _fizzBuzz.BuildFizzBuzzString(5);
            //I'm not sure what you meant by your last comment? Maybe this test will clear that up?
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnFizzBuzzIfInputIsDivisibleByThreeAndFive()
        {
            string expectedValue = "FizzBuzz";

            string actualValue = _fizzBuzz.BuildFizzBuzzString(15);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

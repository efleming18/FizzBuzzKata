using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.FizzBuzzTest
{
    [TestFixture]
    public class BuildFizzBuzzStringShould
    {
        [Test]
        public void ReturnFizzIfInputIsDivisibleByThree()
        {
            var fizzBuzz = new FizzBuzz();
            string expectedValue = "Fizz";
 
            string actualValue = fizzBuzz.BuildFizzBuzzString(3);
            //Contain Fizz? Not divisible by Five?
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnFizzBuzzIfInputIsDivisibleByThreeAndFive()
        {
            var fizzBuzz = new FizzBuzz();
            string expectedValue = "FizzBuzz";

            string actualValue = fizzBuzz.BuildFizzBuzzString(15);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

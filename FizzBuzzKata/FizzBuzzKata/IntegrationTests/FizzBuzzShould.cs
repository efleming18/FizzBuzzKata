using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.IntegrationTests
{
    [TestFixture]
    class FizzBuzzShould
    {
        

        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            _fizzBuzz = new FizzBuzz();
        }


        //Theme to test if you have completed the kata? 
        [TestCase(9)]
        [TestCase(3)]
        public void ReturnFizz(int input)
        {
            var expectedValue = "Fizz";

            var actualValue = _fizzBuzz.BuildFizzBuzzString(input);

            Assert.AreEqual(expectedValue, actualValue);
        }

        //Or theme good test names - this could get scary in the bonus section?
        [TestCase(9)]
        [TestCase(3)]
        public void ReturnFizzWhenInputIsDivisibleByThreeButNotFive(int input)
        {
            var expectedValue = "Fizz";

            var actualValue = _fizzBuzz.BuildFizzBuzzString(input);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

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

        [TestCase(9)]
        [TestCase(3)]
        [TestCase(36)]
        [TestCase(18)]
        [TestCase(333)]
        [TestCase(966)]        
        public void ReturnFizz(int input)
        {
            var expectedValue = "Fizz";

            var actualValue = _fizzBuzz.BuildFizzBuzzString(input);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCase(5)]
        [TestCase(25)]
        [TestCase(50)]
        [TestCase(110)]
        [TestCase(545)]
        [TestCase(1070)]
        public void ReturnBuzz(int input)
        {
            var expectedValue = "Buzz";

            var actualValue = _fizzBuzz.BuildFizzBuzzString(input);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(60)]
        [TestCase(135)]
        [TestCase(555)]
        [TestCase(1050)]
        public void ReturnFizzBuzz(int input)
        {
            var expectedValue = "FizzBuzz";

            var actualValue = _fizzBuzz.BuildFizzBuzzString(input);

            Assert.AreEqual(expectedValue, actualValue);
        }


        [TestCase(13)]
        [TestCase(32)]
        [TestCase(137)]
        [TestCase(3002)]
        public void ReturnFizzAfterBonus(int input)
        {
            var expectedValue = "Fizz";

            var actualValue = _fizzBuzz.BuildFizzBuzzString(input);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCase(52)]
        [TestCase(254)]
        [TestCase(1757)]
        [TestCase(5059)]
        public void ReturnBuzzAfterBonus(int input)
        {
            var expectedValue = "Buzz";

            var actualValue = _fizzBuzz.BuildFizzBuzzString(input);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCase(53)]
        [TestCase(30)]
        [TestCase(57)]
        [TestCase(135)]
        [TestCase(315)]
        [TestCase(31250)]
        public void ReturnFizzBuzzAfterBonus(int input)
        {
            var expectedValue = "FizzBuzz";

            var actualValue = _fizzBuzz.BuildFizzBuzzString(input);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

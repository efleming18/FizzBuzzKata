using System;
using System.Linq;
using Moq;
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

        [Test]
        public void ReturnFizzBuzzIfInputContainsThreeAndFive()
        {
            int input = 53;
            string expectedValue = "FizzBuzz";

            // I just realized we have been writing integration tests on the string builder :(
            // Lets try to finish the string builder (or whatever we refactor it into so we don't
            // have to mock 15 methods for each test) without writing the body of any stringInspector methods.
            var mockStringInspector = new Mock<IStringInspector>();
            mockStringInspector.Setup(msi => msi.ContainsThreeAndFive(It.IsAny<int>())).Returns(true);

            string actualValue = _fizzBuzz.BuildFizzBuzzString(input);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

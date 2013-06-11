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
        private Mock<IStringInspector> _mockStringInspector;
        private Mock<IWordGetter> _mockWordGetter;
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _mockStringInspector = new Mock<IStringInspector>();
            _mockWordGetter = new Mock<IWordGetter>();
            _calculator = new Calculator();
            _fizzBuzz = new FizzBuzz(_calculator, _mockStringInspector.Object, _mockWordGetter.Object);
        }

        [Test]
        public void ReturnFizzIfInputIsDivisibleByThreeButNotFive()
        {
            string expectedValue = "Fizz";
            _mockWordGetter.Setup(mwo => mwo.GetFizzIfRequired(It.IsAny<int>())).Returns("Fizz");

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
            _mockWordGetter.Setup(mwo => mwo.GetFizzIfRequired(It.IsAny<int>())).Returns("Fizz");

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
            _mockWordGetter.Setup(mwg => mwg.GetFizzIfRequired(It.IsAny<int>())).Returns("Fizz");
            _mockStringInspector.Setup(msi => msi.ContainsThreeAndFive(It.IsAny<int>())).Returns(true);

            string actualValue = _fizzBuzz.BuildFizzBuzzString(input);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnBuzzIfInputContainsFive()
        {
            int input = 511;
            string expectedValue = "Buzz";
            _mockWordGetter.Setup(mwg => mwg.GetBuzzIfRequired(It.IsAny<int>())).Returns("Buzz");
            _mockStringInspector.Setup(msi => msi.ContainsFive(It.IsAny<int>())).Returns(true);

            string actualValue = _fizzBuzz.BuildFizzBuzzString(input);
            
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnFizzIfInputContainsThree()
        {
            int input = 311;
            string expectedValue = "Fizz";
            _mockWordGetter.Setup(mwg => mwg.GetBuzzIfRequired(It.IsAny<int>())).Returns("Buzz");
            _mockStringInspector.Setup(msi => msi.ContainsFive(It.IsAny<int>())).Returns(true);

            string actualValue = _fizzBuzz.BuildFizzBuzzString(input);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

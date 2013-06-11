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
        private Mock<IWordGetter> _mockWordGetter;

        [SetUp]
        public void SetUp()
        {
            _mockWordGetter = new Mock<IWordGetter>();
            _fizzBuzz = new FizzBuzz(_mockWordGetter.Object);
        }

        [Test]
        public void ReturnInputIfNeitherFizzNorBuzzIsRequired()
        {
            int input = 2;
            string expectedValue = input.ToString();

            _mockWordGetter.Setup(mwg => mwg.GetFizzIfRequired(It.IsAny<int>())).Returns(String.Empty);
            _mockWordGetter.Setup(mwg => mwg.GetBuzzIfRequired(It.IsAny<int>())).Returns(String.Empty);

            string actualValue = _fizzBuzz.BuildFizzBuzzString(input);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnFizzAndBuzzIfRequired()
        {
            int input = 53;
            string expectedValue = "FizzBuzz";
            _mockWordGetter.Setup(mwg => mwg.GetFizzIfRequired(It.IsAny<int>())).Returns("Fizz");
            _mockWordGetter.Setup(mwg => mwg.GetBuzzIfRequired(It.IsAny<int>())).Returns("Buzz");

            string actualValue = _fizzBuzz.BuildFizzBuzzString(input);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnBuzzIfRequired()
        {
            int input = 511;
            string expectedValue = "Buzz";
            _mockWordGetter.Setup(mwg => mwg.GetFizzIfRequired(It.IsAny<int>())).Returns(String.Empty);
            _mockWordGetter.Setup(mwg => mwg.GetBuzzIfRequired(It.IsAny<int>())).Returns("Buzz");

            string actualValue = _fizzBuzz.BuildFizzBuzzString(input);
            
            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnFizzIfRequired()
        {
            int input = 311;
            string expectedValue = "Fizz";
            _mockWordGetter.Setup(mwg => mwg.GetFizzIfRequired(It.IsAny<int>())).Returns("Fizz");
            _mockWordGetter.Setup(mwg => mwg.GetBuzzIfRequired(It.IsAny<int>())).Returns(String.Empty);

            string actualValue = _fizzBuzz.BuildFizzBuzzString(input);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

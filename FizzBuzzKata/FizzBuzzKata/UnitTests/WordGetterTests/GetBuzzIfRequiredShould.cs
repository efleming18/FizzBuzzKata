using System;
using System.Linq;
using Moq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.WordGetterTests
{
    [TestFixture]
    class GetBuzzIfRequiredShould
    {
        private WordGetter _wordGetter;
        private Mock<IStringInspector> _mockStringInspector;
        private Mock<ICalculator> _mockCalculator;

        [SetUp]
        public void SetUp()
        {
            _mockStringInspector = new Mock<IStringInspector>();
            _mockCalculator = new Mock<ICalculator>();
            _wordGetter = new WordGetter(_mockStringInspector.Object, _mockCalculator.Object);
        }

        [Test]
        public void ReturnBuzzIfInputContainsFive()
        {
            var input = 54;
            var expectedValue = "Buzz";
            _mockStringInspector.Setup(msi => msi.ContainsFive(It.IsAny<int>())).Returns(true);
            _mockCalculator.Setup(mc => mc.IsDivisibleByFive(It.IsAny<int>())).Returns(false);

            var actualValue = _wordGetter.GetBuzzIfRequired(input);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnBuzzIfInputIsDivisibleByFive()
        {
            var input = 10;
            var expectedValue = "Buzz";
            _mockStringInspector.Setup(msi => msi.ContainsFive(It.IsAny<int>())).Returns(false);
            _mockCalculator.Setup(mc => mc.IsDivisibleByFive(It.IsAny<int>())).Returns(true);

            var actualValue = _wordGetter.GetBuzzIfRequired(input);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnEmptyStringIfInputDoesNotContain5NorIsDivisibleByFive()
        {
            var input = 13;
            var expectedValue = String.Empty;
            _mockStringInspector.Setup(msi => msi.ContainsFive(It.IsAny<int>())).Returns(false);
            _mockCalculator.Setup(mc => mc.IsDivisibleByFive(It.IsAny<int>())).Returns(false);

            var actualValue = _wordGetter.GetBuzzIfRequired(input);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
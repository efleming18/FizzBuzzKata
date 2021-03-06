﻿using System;
using System.Linq;
using Moq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.WordGetterTests
{
    [TestFixture]
    class GetFizzIfRequiredShould
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
        public void ReturnFizzIfInputContainsThree()
        {
            var input = 43;
            var expectedValue = "Fizz";
            _mockStringInspector.Setup(msi => msi.ContainsThree(It.IsAny<int>())).Returns(true);
            _mockCalculator.Setup(mc => mc.IsDivisibleByThree(It.IsAny<int>())).Returns(false);

            var actualValue = _wordGetter.GetFizzIfRequired(input);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnFizzIfInputIsDivisibleByThree()
        {
            var input = 30;
            var expectedValue = "Fizz";
            _mockStringInspector.Setup(msi => msi.ContainsThree(It.IsAny<int>())).Returns(false);
            _mockCalculator.Setup(mc => mc.IsDivisibleByThree(It.IsAny<int>())).Returns(true);

            var actualValue = _wordGetter.GetFizzIfRequired(input);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnEmptyStringWhenInputDoesNotContainThreeNorIsDivisibleByThree()
        {
            var input = 11;
            var expectedValue = string.Empty;
            _mockStringInspector.Setup(msi => msi.ContainsThree(It.IsAny<int>())).Returns(false);
            _mockCalculator.Setup(mc => mc.IsDivisibleByThree(It.IsAny<int>())).Returns(false);

            var actualValue = _wordGetter.GetFizzIfRequired(input);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

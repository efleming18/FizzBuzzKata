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
    }
}
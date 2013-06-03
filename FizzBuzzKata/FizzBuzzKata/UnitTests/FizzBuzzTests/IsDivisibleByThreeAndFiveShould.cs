﻿using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.FizzBuzzTests
{
    [TestFixture]
    class IsDivisibleByThreeAndFiveShould
    {
        private FizzBuzz _fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            this._fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void ReturnTrueWhenInputIsDivisibleByThreeAndFive()
        {
            var expectedValue = true;
            var actualValue = _fizzBuzz.IsDivisibleByThreeAndFive(15);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnFalseWhenInputIsNotDivisibleByThreeAndFive()
        {
            var expectedValue = false;
            var actualValue = _fizzBuzz.IsDivisibleByThreeAndFive(18);
            //possibly use a [TestCase] here? So to pick a number divisible by 3, by 5, then by neither?
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

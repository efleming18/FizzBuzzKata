using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.FizzBuzzTests
{
    [TestFixture]
    class IsDivisibleByThreeAndFiveShould
    {
        [Test]
        public void ReturnTrueWhenInputIsDivisibleByThreeAndFive()
        {
            var fizzBuzz = new FizzBuzz();
            var expectedValue = true;
            var actualValue = fizzBuzz.IsDivisibleByThreeAndFiveShould(15);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.StringInspectorTests
{
    [TestFixture]
    public class ContainsFiveShould
    {
        [Test]
        public void ReturnTrueIfInputContainsFive()
        {
            var stringInspector = new StringInspector();
            var expectedValue = true;

            var actualValue = stringInspector.ContainsFive(15);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnFlaseIfInputDoesNotContainFive()
        {
            var stringInspector = new StringInspector();
            var expectedValue = false;

            var actualValue = stringInspector.ContainsFive(10);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

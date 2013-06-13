using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.StringInspectorTests
{
    [TestFixture]
    public class ContainsFiveShould
    {
        private StringInspector _stringInspector;

        [SetUp]
        public void SetUp()
        {
            _stringInspector = new StringInspector();
        }

        [Test]
        public void ReturnTrueIfInputContainsFive()
        {
            var expectedValue = true;

            var actualValue = _stringInspector.ContainsFive(15);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void ReturnFalseIfInputDoesNotContainFive()
        {
            var expectedValue = false;

            var actualValue = _stringInspector.ContainsFive(10);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

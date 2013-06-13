using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.StringInspectorTests
{
    [TestFixture]
    public class ContainThreeShould
    {
        private StringInspector _stringInspector;

        [SetUp]
        public void SetUp()
        {
            _stringInspector = new StringInspector();
        }

        [Test]
        public void ReturnTrueIfInputContainsThree()
        {           
            var expectedValue = true;

            var actualValue = _stringInspector.ContainsThree(31);

            Assert.AreEqual(expectedValue, actualValue);
        }


        [Test]
        public void ReturnFalseIfInputDoesNotContainThree()
        {
            //I'm aware we have 4 broken tests but those will not pass until these tests are done but I like the idea of testing the whole application like that.
            // Yes! I'm not sure how I want them written though.
            // Too complex names loose meaning, and not enough complexity might be missleading. /shrug

            var expectedValue = false;

            var actualValue = _stringInspector.ContainsThree(99);

            Assert.AreEqual(expectedValue, actualValue);
        }

    }
}

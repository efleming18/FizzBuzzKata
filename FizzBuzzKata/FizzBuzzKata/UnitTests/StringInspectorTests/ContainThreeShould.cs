using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.StringInspectorTests
{
    [TestFixture]
    public class ContainThreeShould
    {
        [Test]
        public void ReturnTrueIfInputContainsThree()
        {           
            var stringInspector = new StringInspector();
            var expectedValue = true;

            var actualValue = stringInspector.ContainsThree(31);

            Assert.AreEqual(expectedValue, actualValue);
        }

    }
}

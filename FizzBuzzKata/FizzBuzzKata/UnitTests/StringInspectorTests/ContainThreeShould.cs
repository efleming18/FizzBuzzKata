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
            //I'm aware we have 4 broken tests but those will not pass until these tests are done but I like the idea of testing the whole application like that.
            var stringInspector = new StringInspector();
            var expectedValue = true;

            var actualValue = stringInspector.ContainsThree(31);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}

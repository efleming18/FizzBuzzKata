using System;
using System.Linq;
using NUnit.Framework;

namespace FizzBuzzKata.UnitTests.FizzBuzzTests
{
    [TestFixture]
    class IsDivisibleByThreeShould
    {
        [Test]
        public void ReturnTrueIfNumberIsDivisibleByThree()
        {
            var fizzBuzz = new FizzBuzz();
            var actualValue = fizzBuzz.IsDivisibleByThree(6);

            var expectedValue = true;

            Assert.AreEqual(actualValue, expectedValue);
        }

        [Test]
        public void ReturnFalseIfNumberIsNotDivisibleByThree()
        {
            //It might be a good idea to utilize the [SetUp] feature for Nunit so you don't have to new up an instance of the FizzBuzz class everytime. :) 
            //Also, if you have any questions about the direction I'm heading with this just ask. 
            //Instructions are in the GitHub repo. This is a simple Kata, and in all honesty, if you want to write multiple tests since they are simple go ahead.
            //Do as much as you want and kick it back to me! This is a learning process.
            //By the way, I've been thinking about that "Notification" app/service we talked about today and think that would be awesome!
            



            //ONE MORE COMMENT BECAUSE I DIDN'T THINK I HAD ENOUGH!!
        }
    }
}

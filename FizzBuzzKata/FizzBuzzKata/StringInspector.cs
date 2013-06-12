using System;

namespace FizzBuzzKata
{
    public class StringInspector : IStringInspector
    {
        public bool ContainsFive(int input)
        {
            return true;
        }

        public bool ContainsThree(int input)
        {
            throw new NotImplementedException("no tests yet");
        }
    }
}
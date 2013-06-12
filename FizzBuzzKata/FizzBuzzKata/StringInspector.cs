using System;

namespace FizzBuzzKata
{
    public class StringInspector : IStringInspector
    {
        public bool ContainsFive(int input)
        {
            throw new NotImplementedException("no tests yet");
            if (input.ToString() == "5")
            {
                return true;
            }
            return false;
        }

        public bool ContainsThree(int input)
        {
            throw new NotImplementedException("no tests yet");
            return false;
        }
    }
}
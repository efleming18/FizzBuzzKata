using System;

namespace FizzBuzzKata
{
    public class StringInspector : IStringInspector
    {
        public bool ContainsThreeAndFive(int input)
        {
            if (input.ToString() == "3" && input.ToString() == "5")
            {
                return true;
            }
            return false;
        }

        public bool ContainsFive(int input)
        {
            if (input.ToString() == "5")
            {
                return true;
            }
            return false;
        }

        public bool ContainsThree(int input)
        {
            return false;
        }
    }
}
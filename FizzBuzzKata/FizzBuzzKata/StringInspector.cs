using System;

namespace FizzBuzzKata
{
    public class StringInspector : IStringInspector
    {
        public bool ContainsFive(int input)
        {
            if (input.ToString().Contains("5"))
            { 
                return true; 
            }
            return false;
        }

        public bool ContainsThree(int input)
        {
            return true;
        }
    }
}
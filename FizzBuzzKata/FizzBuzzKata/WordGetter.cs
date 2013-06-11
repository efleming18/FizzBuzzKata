using System;

namespace FizzBuzzKata
{
    public class WordGetter : IWordGetter
    {
        public string GetBuzzIfRequired(int input)
        {
            var stringInspector = new StringInspector();
            if (stringInspector.ContainsFive(input))
            {
                return "Buzz";
            }
            return "";
        }

        public string GetFizzIfRequired(int input)
        {
            throw new NotImplementedException();
        }
    }
}
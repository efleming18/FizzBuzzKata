using System;

namespace FizzBuzzKata
{
    public class WordGetter : IWordGetter
    {
        private readonly IStringInspector _stringInspector;
        private readonly ICalculator _calculator;

        public WordGetter(IStringInspector stringInspector, ICalculator calculator)
        { 
            _calculator = calculator;
            _stringInspector = stringInspector;
        }

        public string GetBuzzIfRequired(int input)
        {
            if (_stringInspector.ContainsFive(input) || _calculator.IsDivisibleByFive(input))
            {
                return "Buzz";
            }
            return "";
        }

        public string GetFizzIfRequired(int input)
        {
            if (_stringInspector.ContainsThree(input) || _calculator.IsDivisibleByThree(input))
            {
                return "Fizz";
            }
            return string.Empty;
        }
    }
}
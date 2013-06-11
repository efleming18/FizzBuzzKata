using System;
using System.Linq;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        private readonly Calculator _calculator;
        private readonly IWordGetter _wordGetter;
        private readonly IStringInspector _stringInspector;

        public FizzBuzz(Calculator calculator, IStringInspector stringInspector, IWordGetter wordGetter)
        {
            _stringInspector = stringInspector;
            _calculator = calculator;
            _wordGetter = wordGetter;
        }

        public string BuildFizzBuzzString(int input)
        {
            var wordsToReturn = String.Empty;
            wordsToReturn = _wordGetter.GetFizzIfRequired(input);

            if (_stringInspector.ContainsThreeAndFive(input))
            {
                return wordsToReturn + "Buzz";
            }
            if (_stringInspector.ContainsFive(input))
            {
                return "Buzz";
            }
            if (_calculator.IsDivisibleByThreeAndFive(input))
            {
                return wordsToReturn + "Buzz";
            }
            if (_calculator.IsDivisibleByFive(input))
            {
                return "Buzz";
            }
            return String.IsNullOrEmpty(wordsToReturn) ? input.ToString() : wordsToReturn;
        }
    }
}
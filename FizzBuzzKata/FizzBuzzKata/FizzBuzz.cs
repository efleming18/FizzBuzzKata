using System;
using System.Linq;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        readonly Calculator _calculator;
        readonly IStringInspector _stringInspector;

        public FizzBuzz(Calculator calculator, IStringInspector stringInspector)
        {
            _calculator = calculator;
            _stringInspector = stringInspector;
        }

        public string BuildFizzBuzzString(int input)
        {
            if (_stringInspector.ContainsThreeAndFive(input))
            {
                return "FizzBuzz";
            }
            if (_calculator.IsDivisibleByThreeAndFive(input))
            {
                return "FizzBuzz";
            }
            if (_calculator.IsDivisibleByThree(input))
            {
                return "Fizz";
            }
            if (_calculator.IsDivisibleByFive(input))
            {
                return "Buzz";
            }
            return input.ToString();
        }
    }
}
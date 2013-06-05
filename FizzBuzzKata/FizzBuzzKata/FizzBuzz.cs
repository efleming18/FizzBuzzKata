using System;
using System.Linq;

namespace FizzBuzzKata
{
    public class FizzBuzz
    { 
        readonly Calculator _calculator = new Calculator();

        public string BuildFizzBuzzString(int input)
        {
            if (_calculator.IsDivisibleByThreeAndFive(input))
            {
                return "FizzBuzz";
            }
            if (_calculator.IsDivisibleByFive(input))
            {
                return "Buzz";
            }
            return "Fizz";
        }
    }
}

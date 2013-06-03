using System;
using System.Linq;

namespace FizzBuzzKata
{
    public class FizzBuzz
    { 
        public bool IsDivisibleByThreeAndFive(int input)
        {
            return true;
        }

        public bool IsDivisibleByFive(int input)
        {
            return input % 5 == 0;
        }

        public bool IsDivisibleByThree(int input)
        {
            return input % 3 == 0;
        }
    }
}

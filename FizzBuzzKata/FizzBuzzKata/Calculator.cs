namespace FizzBuzzKata
{
    public class Calculator : ICalculator
    {
        public bool IsDivisibleByThreeAndFive(int input)
        {
            return IsDivisibleByThree(input) && IsDivisibleByFive(input);
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
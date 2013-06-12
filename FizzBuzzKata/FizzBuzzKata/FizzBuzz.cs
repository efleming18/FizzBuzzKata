using System;
using System.Linq;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {
        private readonly IWordGetter _wordGetter;

        public FizzBuzz() : this(new WordGetter()) { }

        public FizzBuzz(IWordGetter wordGetter)
        {
            _wordGetter = wordGetter;
        }

        public string BuildFizzBuzzString(int input)
        {
            var wordsToReturn = String.Empty;
            wordsToReturn = _wordGetter.GetFizzIfRequired(input);
            wordsToReturn += _wordGetter.GetBuzzIfRequired(input);

            return String.IsNullOrEmpty(wordsToReturn) ? input.ToString() : wordsToReturn;
        }
    }
}
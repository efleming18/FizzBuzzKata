using System;

namespace FizzBuzzKata
{
    public interface IWordGetter
    {
        string GetBuzzIfRequired(int input);
        string GetFizzIfRequired(int input);
    }
}
using GuessingGame.Domain.Numbers.Base;

namespace GuessingGame.Domain.Numbers;

public class GuessNumber : Number
{
    public GuessNumber(int number, MinimumNumber minimumValue, MaximumNumber maximumValue)
        : base(number)
    {
        if (minimumValue.Value > Value)
            throw new ArgumentException($"Guess number must be greater than or equal to {minimumValue.Value}.");
        if (    maximumValue.Value < Value)
            throw new ArgumentException($"Guess number must be less then or equal to {maximumValue}.");
    }

    public GuessNumber(string? value, MinimumNumber minimumValue, MaximumNumber maximumValue)
        : this(ConvertStringToInt32(value), minimumValue, maximumValue)
    {
    }
}
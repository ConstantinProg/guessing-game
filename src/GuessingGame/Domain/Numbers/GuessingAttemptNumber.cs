using GuessingGame.Domain.Numbers.Base;

namespace GuessingGame.Domain.Numbers;

public class GuessingAttemptNumber : Number
{
    public bool IsGreaterThenZero
        => Value > 0;

    public GuessingAttemptNumber(int value)
        : base(value)
    {
        if (value <= 0)
            throw new ArgumentException("Guessing attempt number must be greater then zero.");
    }

    public GuessingAttemptNumber(string? value)
        : this(ConvertStringToInt32(value))
    {
    }

    public void ReduceByOneAttempt()
            => Value -= 1;
}


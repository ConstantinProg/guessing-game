using GuessingGame.Domain.Numbers.Base;

namespace GuessingGame.Domain.Numbers;

public class MaximumNumber : Number
{
    public MaximumNumber(int value, MinimumNumber minimumNumber)
        : base(value)
    {
        if (minimumNumber.Value >= value)
            throw new ArgumentException("Maximum value must be greater then minimum value.");
    }

    public MaximumNumber(string? value, MinimumNumber minimumValue)
        : this(ConvertStringToInt32(value), minimumValue)
    {
    }
}
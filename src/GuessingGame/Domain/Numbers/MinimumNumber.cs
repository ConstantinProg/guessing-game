using GuessingGame.Domain.Numbers.Base;

namespace GuessingGame.Domain.Numbers;

public class MinimumNumber  :Number
{
    public  MinimumNumber(int value)
        : base(value)
    {
    }

    public MinimumNumber(string? value)
        : this(ConvertStringToInt32(value))
    {
    }
}

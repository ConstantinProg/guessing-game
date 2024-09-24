using GuessingGame.Domain.Numbers.Base;

namespace GuessingGame.Domain.Numbers;

internal class SecretNumber : Number
{
    public SecretNumber(MinimumNumber minimumNumber, MaximumNumber maximumNumber)
        : base(new Random().Next(minimumNumber.Value, maximumNumber.Value))
    {
    }
}

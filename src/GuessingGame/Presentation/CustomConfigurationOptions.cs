using GuessingGame.Domain.Abstractions;
using GuessingGame.Domain.Numbers;

namespace GuessingGame.Presentation;

internal class CustomConfigurationOptions : IConfigurationOptions
{
    private MinimumNumber _minimumSecretNumberValue;
    private MaximumNumber _maximumSecretNumberValue;
    private GuessingAttemptNumber _guessingAttemptNumber;

    public CustomConfigurationOptions(MinimumNumber minimumSecretNumberValue, MaximumNumber maximumSecretNumberValue, GuessingAttemptNumber guessingAttemptNumber)
    {
        _minimumSecretNumberValue = minimumSecretNumberValue;
        _maximumSecretNumberValue = maximumSecretNumberValue;
        _guessingAttemptNumber = guessingAttemptNumber;
    }
    
    public MinimumNumber GetMinimumSecretNumberValue()
    => _minimumSecretNumberValue;

    public MaximumNumber GetMaximumSecretNumberValue()
        => _maximumSecretNumberValue;

    public GuessingAttemptNumber GetGuessingAttemptNumber()
        => _guessingAttemptNumber;
}
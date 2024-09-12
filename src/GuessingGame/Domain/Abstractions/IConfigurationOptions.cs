using GuessingGame.Domain.Numbers;

namespace GuessingGame.Domain.Abstractions;

public interface IConfigurationOptions
{
    MinimumNumber GetMinimumSecretNumberValue();
    MaximumNumber GetMaximumSecretNumberValue();
    GuessingAttemptNumber GetGuessingAttemptNumber();
}

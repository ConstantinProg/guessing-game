using GuessingGame.Domain.Abstractions;
using GuessingGame.Domain.Numbers;

namespace GuessingGame.Configuration;

internal class ConfigurationOptions : IConfigurationOptions
{
    public int MinimumSecretNumberValue { get; set; }
    public int MaximumSecretNumberValue { get; set; }
    public int MaximumGuessingAttemptNumber { get; set; }

public ConfigurationOptions()
    {
    }

    public ConfigurationOptions(int minimumSecretNumberValue, int maximumSecretNumberValue, int maximumGuessingAttemptNumber)
    {
        MinimumSecretNumberValue = minimumSecretNumberValue;
        MaximumSecretNumberValue = maximumSecretNumberValue;
        MaximumGuessingAttemptNumber = maximumGuessingAttemptNumber;
    }

    public ConfigurationOptions(IConfigurationOptions options)
    {
        MinimumSecretNumberValue = options.GetMinimumSecretNumberValue().Value;
        MaximumSecretNumberValue = options.GetMaximumSecretNumberValue().Value;
        MaximumGuessingAttemptNumber = options.GetGuessingAttemptNumber().Value;
    }

    public MinimumNumber GetMinimumSecretNumberValue()
    => new MinimumNumber(MinimumSecretNumberValue);

    public MaximumNumber GetMaximumSecretNumberValue()
        => new MaximumNumber(MaximumSecretNumberValue, GetMinimumSecretNumberValue());

    public GuessingAttemptNumber GetGuessingAttemptNumber()
        => new GuessingAttemptNumber(MaximumGuessingAttemptNumber);

    public static ConfigurationOptions Default
        => new ConfigurationOptions(0, 100, 5);
}


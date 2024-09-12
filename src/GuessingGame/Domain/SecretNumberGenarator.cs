using GuessingGame.Domain.Abstractions;
using GuessingGame.Domain.Numbers;

namespace GuessingGame.Domain;

internal class SecretNumberGenarator
{
    private IConfigurationOptions _configuration;
    private Random _randomNumberGenerator;

    public SecretNumberGenarator(IConfigurationOptions configuration)
    {
        _configuration = configuration;
        _randomNumberGenerator = new Random();
    }

    public SecretNumber GenerateSecretNumber()
    {
        return new SecretNumber(_randomNumberGenerator.Next(_configuration.GetMinimumSecretNumberValue().Value, _configuration.GetMaximumSecretNumberValue().Value));
    }
}

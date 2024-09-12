namespace GuessingGame.Domain.Abstractions;

public interface IConfigurationSource
{
    void SaveConfigurationOptions(IConfigurationOptions options);
    IConfigurationOptions GetConfigurationOptions();
}

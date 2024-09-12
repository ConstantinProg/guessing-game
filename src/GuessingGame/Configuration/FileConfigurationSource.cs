using GuessingGame.Domain.Abstractions;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GuessingGame.Configuration;

internal class FileConfigurationSource(string ConfigurationFilePath) : IConfigurationSource
{
    public static FileConfigurationSource Default
        => new FileConfigurationSource(Path.Combine(Directory.GetCurrentDirectory(), "options.json"));

    public void SaveConfigurationOptions(IConfigurationOptions options)
    {
        var configurationOptions = new ConfigurationOptions(options);
        var fileContent = JsonSerializer.Serialize(configurationOptions, SourceGenerationContext.Default.ConfigurationOptions);
        try
        {
            File.WriteAllText(ConfigurationFilePath, fileContent);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public IConfigurationOptions GetConfigurationOptions()
    {
        if (!File.Exists(ConfigurationFilePath))
            return ConfigurationOptions.Default;
        ConfigurationOptions? options = null;
        try
        {
            var fileContent = File.ReadAllText(ConfigurationFilePath);
            options = JsonSerializer.Deserialize(fileContent, SourceGenerationContext.Default.ConfigurationOptions);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        return options ?? ConfigurationOptions.Default;
    }
}
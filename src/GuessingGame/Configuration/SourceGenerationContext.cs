using System.Text.Json.Serialization;

namespace GuessingGame.Configuration;

[JsonSourceGenerationOptions(WriteIndented = true)]
[JsonSerializable(typeof(ConfigurationOptions))]
internal partial class SourceGenerationContext : JsonSerializerContext
{
}
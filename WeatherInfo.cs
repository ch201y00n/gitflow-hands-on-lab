using System.Text.Json.Serialization;

namespace GitflowHandsOnLab;

public class WeatherInfo
{
    [JsonPropertyName("description")]
    public string Description { get; init; } = string.Empty;
}
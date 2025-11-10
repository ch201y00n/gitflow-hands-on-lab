using System.Text.Json.Serialization;

public abstract class WeatherInfo
{
    [JsonPropertyName("description")]
    public string Description { get; init; } = string.Empty;
}
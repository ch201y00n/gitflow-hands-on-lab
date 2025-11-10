using System.Text.Json.Serialization;

namespace gitflow_hands_on_lab;

public abstract class WeatherInfo
{
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;
}
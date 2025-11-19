using System.Text.Json.Serialization;

namespace GitFlowHandsOnLab.Models;

public class WeatherInfo
{
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;
}
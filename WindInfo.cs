using System.Text.Json.Serialization;

namespace gitflow_hands_on_lab;

public abstract class WindInfo
{
    [JsonPropertyName("speed")]
    public double Speed { get; init; }
}
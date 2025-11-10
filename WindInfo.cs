using System.Text.Json.Serialization;

namespace GitflowHandsOnLab;

public class WindInfo
{
    [JsonPropertyName("speed")]
    public double Speed { get; init; }
}
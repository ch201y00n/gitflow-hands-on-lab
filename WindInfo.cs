using System.Text.Json.Serialization;

public abstract class WindInfo
{
    [JsonPropertyName("speed")]
    public double Speed { get; init; }
}
using System.Text.Json.Serialization;

namespace GitFlowHandsOnLab.Models;

public class WindInfo
{
    [JsonPropertyName("speed")]
    public double Speed { get; set; }
}
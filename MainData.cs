using System.Text.Json.Serialization;

namespace gitflow_hands_on_lab;

public class MainData
{
    [JsonPropertyName("temp")]
    public double Temp { get; init; }
    
    [JsonPropertyName("humidity")]
    public int Humidity { get; init; }
}
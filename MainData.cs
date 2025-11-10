using System.Text.Json.Serialization;

public class MainData
{
    [JsonPropertyName("temp")]
    public double Temp { get; init; }
    
    [JsonPropertyName("humidity")]
    public int Humidity { get; init; }
}
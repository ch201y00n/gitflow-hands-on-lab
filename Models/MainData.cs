using System.Text.Json.Serialization;

namespace GitFlowHandsOnLab.Models;

public class MainData
{
    [JsonPropertyName("temp")]
    public double Temp { get; set; }
    
    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }
}
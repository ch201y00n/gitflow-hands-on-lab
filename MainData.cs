using System.Text.Json.Serialization;

public class MainData
{
    [JsonPropertyName("temp")]
    public double Temp { get; set; }
    
    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }
}
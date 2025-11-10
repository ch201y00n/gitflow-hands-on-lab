namespace GitflowHandsOnLab;

public class WeatherResponse
{
    public string Name { get; init; } = string.Empty;
    public MainData Main { get; init; } = new();
    public WeatherInfo[] Weather { get; init; } = [];
    public WindInfo? Wind { get; init; }
}
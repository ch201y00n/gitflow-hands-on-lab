namespace GitFlowHandsOnLab.Services;

public class WeatherConfig
{
    private const string ApiKeyEnvironmentVariable = "OPENWEATHER_API_KEY";
    private const string DefaultCity = "Seoul";
    private const string ApiBaseUrl = "https://api.openweathermap.org/data/2.5/weather";

    public string ApiKey { get; }
    public string City { get; set; }

    public WeatherConfig(string? apiKey = null, string? city = null)
    {
        ApiKey = apiKey ?? Environment.GetEnvironmentVariable(ApiKeyEnvironmentVariable) ?? string.Empty;
        City = city ?? DefaultCity;
    }

    public bool IsApiKeyValid()
    {
        return !string.IsNullOrEmpty(ApiKey);
    }

    public string GetApiUrl()
    {
        return $"{ApiBaseUrl}?q={City}&appid={ApiKey}&units=metric&lang=kr";
    }

    public void DisplayApiKeyWarning()
    {
        Console.WriteLine("경고: OPENWEATHER_API_KEY 환경변수가 설정되지 않았습니다.");
        Console.WriteLine("OpenWeatherMap API 키를 발급받아 환경변수로 설정하세요.");
        Console.WriteLine("예: set OPENWEATHER_API_KEY=your_api_key");
    }
}

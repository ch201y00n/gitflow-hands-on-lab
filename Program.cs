using System.Text.Json;
using System.Text.Json.Serialization;

// 날씨 정보를 가져오는 함수
static async Task<WeatherData?> GetWeatherAsync(string city = "Seoul", string? apiKey = null)
{
    // API 키가 없으면 환경변수에서 가져오기
    apiKey ??= Environment.GetEnvironmentVariable("OPENWEATHER_API_KEY");
    
    if (string.IsNullOrEmpty(apiKey))
    {
        Console.WriteLine("경고: OPENWEATHER_API_KEY 환경변수가 설정되지 않았습니다.");
        Console.WriteLine("OpenWeatherMap API 키를 발급받아 환경변수로 설정하세요.");
        Console.WriteLine("예: set OPENWEATHER_API_KEY=your_api_key");
        return null;
    }

    string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric&lang=kr";

    try
    {
        using HttpClient client = new();
        HttpResponseMessage response = await client.GetAsync(url);
        
        if (!response.IsSuccessStatusCode)
        {
            Console.WriteLine($"오류: 날씨 정보를 가져올 수 없습니다. 상태 코드: {response.StatusCode}");
            return null;
        }

        string json = await response.Content.ReadAsStringAsync();
        WeatherResponse? weatherResponse = JsonSerializer.Deserialize<WeatherResponse>(json);
        
        if (weatherResponse == null)
        {
            Console.WriteLine("오류: 날씨 데이터를 파싱할 수 없습니다.");
            return null;
        }

        return new WeatherData
        {
            City = weatherResponse.Name,
            Temperature = weatherResponse.Main.Temp,
            Description = weatherResponse.Weather[0].Description,
            Humidity = weatherResponse.Main.Humidity,
            WindSpeed = weatherResponse.Wind?.Speed ?? 0
        };
    }
    catch (Exception ex)
    {
        Console.WriteLine($"오류 발생: {ex.Message}");
        return null;
    }
}

// 날씨 정보 출력 함수
static void DisplayWeather(WeatherData? weather)
{
    if (weather == null)
    {
        return;
    }

    Console.WriteLine("\n=== 날씨 정보 ===");
    Console.WriteLine($"도시: {weather.City}");
    Console.WriteLine($"온도: {weather.Temperature}°C");
    Console.WriteLine($"상태: {weather.Description}");
    Console.WriteLine($"습도: {weather.Humidity}%");
    Console.WriteLine($"풍속: {weather.WindSpeed} m/s");
    Console.WriteLine("================\n");
}

// 메인 프로그램
Console.WriteLine("날씨 정보 조회 프로그램");
Console.WriteLine("도시를 입력하세요 (기본값: Seoul):");
string? cityInput = Console.ReadLine();
string city = string.IsNullOrWhiteSpace(cityInput) ? "Seoul" : cityInput.Trim();

WeatherData? weather = await GetWeatherAsync(city);
DisplayWeather(weather);

// 데이터 클래스들
public class WeatherData
{
    public string City { get; set; } = string.Empty;
    public double Temperature { get; set; }
    public string Description { get; set; } = string.Empty;
    public int Humidity { get; set; }
    public double WindSpeed { get; set; }
}

public class WeatherResponse
{
    public string Name { get; set; } = string.Empty;
    public MainData Main { get; set; } = new();
    public WeatherInfo[] Weather { get; set; } = Array.Empty<WeatherInfo>();
    public WindInfo? Wind { get; set; }
}

public class MainData
{
    [JsonPropertyName("temp")]
    public double Temp { get; set; }
    
    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }
}

public class WeatherInfo
{
    [JsonPropertyName("description")]
    public string Description { get; set; } = string.Empty;
}

public class WindInfo
{
    [JsonPropertyName("speed")]
    public double Speed { get; set; }
}
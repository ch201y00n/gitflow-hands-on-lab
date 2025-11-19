using System.Text.Json;
using GitFlowHandsOnLab.Models;

namespace GitFlowHandsOnLab.Services;

public class WeatherService : IDisposable
{
    private readonly WeatherConfig _config;
    private readonly HttpClient _httpClient;

    public WeatherService(WeatherConfig config)
    {
        _config = config;
        _httpClient = new HttpClient();
    }

    public async Task<WeatherData?> GetWeatherAsync()
    {
        if (!_config.IsApiKeyValid())
        {
            _config.DisplayApiKeyWarning();
            return null;
        }

        try
        {
            var url = _config.GetApiUrl();
            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine($"오류: 날씨 정보를 가져올 수 없습니다. 상태 코드: {response.StatusCode}");
                return null;
            }

            var json = await response.Content.ReadAsStringAsync();
            var weatherResponse = JsonSerializer.Deserialize<WeatherResponse>(json);

            if (weatherResponse != null)
            {
                return MapToWeatherData(weatherResponse);
            }
            
            Console.WriteLine("오류: 날씨 데이터를 파싱할 수 없습니다.");
            return null;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"오류 발생: {ex.Message}");
            return null;
        }
    }

    private static WeatherData MapToWeatherData(WeatherResponse response)
    {
        return new WeatherData
        {
            City = response.Name,
            Temperature = response.Main.Temp,
            Description = response.Weather.Length > 0 ? response.Weather[0].Description : "정보 없음",
            Humidity = response.Main.Humidity,
            WindSpeed = response.Wind?.Speed ?? 0
        };
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
    }
}

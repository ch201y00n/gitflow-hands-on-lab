using GitFlowHandsOnLab.Models;

namespace GitFlowHandsOnLab.Services;

public static class WeatherDisplay
{
    public static void DisplayWeather(WeatherData? weather)
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

    public static string GetCityInput()
    {
        Console.WriteLine("날씨 정보 조회 프로그램");
        Console.WriteLine("도시를 입력하세요 (기본값: Seoul):");
        
        var cityInput = Console.ReadLine();
        return string.IsNullOrWhiteSpace(cityInput) ? "Seoul" : cityInput.Trim();
    }
}

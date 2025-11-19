using GitFlowHandsOnLab.Services;

namespace GitFlowHandsOnLab;

public class Program
{
    public static async Task Main(string[] args)
    {
        // 사용자로부터 도시 이름 입력받기
        var city = WeatherDisplay.GetCityInput();
        
        // 날씨 정보 가져오기
        var config = new WeatherConfig(city: city);
        using var weatherService = new WeatherService(config);
        var weather = await weatherService.GetWeatherAsync();
        
        // 날씨 정보 출력
        WeatherDisplay.DisplayWeather(weather);
    }
}
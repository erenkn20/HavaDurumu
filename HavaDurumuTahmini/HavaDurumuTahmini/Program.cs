using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main()
    {
        // Şehirleri temsil eden URL'ler
        string istanbulUrl = "https://goweather.herokuapp.com/weather/istanbul";
        string izmirUrl = "https://goweather.herokuapp.com/weather/izmir";
        string ankaraUrl = "https://goweather.herokuapp.com/weather/ankara";

        // Şehirlerin hava durumu bilgilerini al ve ekrana yazdır
        await GetAndDisplayWeather(istanbulUrl, "Istanbul");
        await GetAndDisplayWeather(izmirUrl, "Izmir");
        await GetAndDisplayWeather(ankaraUrl, "Ankara");
    }

    static async Task GetAndDisplayWeather(string apiUrl, string cityName)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // API'den veriyi al
                string response = await client.GetStringAsync(apiUrl);

                // JSON verisini uygun sınıfa dönüştür
                WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(response);

                // Hava durumu bilgilerini ekrana yazdır
                Console.WriteLine($"Bugün {cityName} için hava durumu:");
                Console.WriteLine($"Sıcaklık: {weatherData.Temperature}");
                Console.WriteLine($"Rüzgar: {weatherData.Wind}");
                Console.WriteLine($"Durum: {weatherData.Description}");

                // 3 günlük tahminleri ekrana yazdır
                Console.WriteLine($"{cityName} için önümüzdeki 3 günlük hava durumu:");

                foreach (var forecast in weatherData.Forecast)
                {
                    Console.WriteLine($"Gün: {forecast.Day}");
                    Console.WriteLine($"Sıcaklık: {forecast.Temperature}");
                    Console.WriteLine($"Durum: {weatherData.Description}\n");
                }

                Console.WriteLine();
            }
            catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                Console.WriteLine($"{cityName} şehrinden veri almaya çalışırken hata ile karşılaşıldı: Şehir bulunamadı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{cityName} şehrinden veri almaya çalışırken hata ile karşılaşıldı: {ex.Message}");
            }
        }
    }
}

// JSON verisini temsil eden sınıflar
public class WeatherData
{
    public string Temperature { get; set; }
    public string Wind { get; set; }
    public string Description { get; set; }
    public ForecastData[] Forecast { get; set; }
}

public class ForecastData
{
    public string Day { get; set; }
    public string Temperature { get; set; }
    public string Description { get; set; }
}

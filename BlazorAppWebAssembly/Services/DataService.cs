using System.Collections;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace BlazorAppWebAssembly.Services
{

    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

    public class DataService
    {
        private readonly HttpClient http;

        public DataService(HttpClient http) {
            this.http = http;
        }    
        public async Task<WeatherForecast[]> GetData()
        {
            await Task.Delay(1000);
            return await http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
    }
}

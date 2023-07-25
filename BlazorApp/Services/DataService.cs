using System.Collections;
using System.Net.Http.Json;
using static BlazorApp.Pages.FetchData;
using static System.Net.WebRequestMethods;

namespace BlazorApp.Services
{
    public class DataService
    {
        private readonly HttpClient http;

        public DataService(HttpClient http) {
            this.http = http;
        }    
        public async Task<WeatherForecast[]> GetData()
        {
            return await http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
    }
}

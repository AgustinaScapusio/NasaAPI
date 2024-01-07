using NasaAPI.API;
using NasaAPI.Models;
using System.Text.Json;

public class MainAPI : INasaAPI
{

    private readonly HttpClient _httpClient;

    public MainAPI(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<NasaAPI.Models.Apod> GetApodAsync(DateTime date)
    {
        var response = await _httpClient.GetAsync($"https://api.nasa.gov/planetary/apod?api_key=DEMO_KEY&date={date:yyyy-MM-dd}");
        var content = await response.Content.ReadAsStringAsync();
        var apod = JsonSerializer.Deserialize<Apod>(content);
        return apod;
    }
}

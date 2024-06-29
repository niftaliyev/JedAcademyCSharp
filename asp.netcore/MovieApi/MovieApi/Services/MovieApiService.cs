using MovieApi.Models;
using System.Text.Json;

//using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MovieApi.Services;

public class MovieApiService
{
    private string apiKey = "2c9d65d5";
    private string baseUrl = "https://www.omdbapi.com/";
    public async Task<MovieApiResponse> Search(string movieName)
    {
        movieName = movieName.ToLower();
        var httpClient = new HttpClient();
        string url = $"{baseUrl}?apikey={apiKey}&s={movieName}";
        var response = await httpClient.GetAsync(url);
        var json = await response.Content.ReadAsStringAsync();
        //var result = JsonConvert.DeserializeObject<MovieApiResponse>(json);
        var result = JsonSerializer.Deserialize<MovieApiResponse>(json);
        foreach (var item in result.Movies)
        {
            await Console.Out.WriteLineAsync(item.Title+"\t");
        }
        return result;
    }
}

using NetCoreAIProject03_RapidApi.VİewModels;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;


var client = new HttpClient();
List<ApiSeriesViewModel> apiSeriesViewModels = new List<ApiSeriesViewModel>();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Get,  //method türü
    RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/series/"),  //istek yapılan adres
    Headers =
    {
        { "x-rapidapi-key", "a1cfcb611dmsh564d867a04b7e61p1ead29jsn5a3b92e86730" },
        { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
    },
};
using (var response = await client.SendAsync(request))    
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    apiSeriesViewModels = System.Text.Json.JsonSerializer.Deserialize<List<ApiSeriesViewModel>>(body);
    foreach (var item in apiSeriesViewModels)
    {
        Console.WriteLine($"Rank: {item.rank}, Title: {item.title}, Rating: {item.rating}, Year: {item.year}");
    }
}

Console.ReadLine();

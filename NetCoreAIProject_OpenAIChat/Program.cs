using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    static async Task Main(string[] args)
    {
        var apiKey = "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";

        Console.WriteLine("Lütfen sorunuzu yazınız: (örnek ' merhaba bugün İstanbul'da hava kaç derece' )");

        var prompt = Console.ReadLine();
        using var HttpClient = new HttpClient();
        HttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
        //Bearer  ifadesi token tabanlı kimlik doğrulama için kullanılır. API anahtarını güvenli bir şekilde iletmek için kullanılır.

        var requestBody = new
        {
            model = "gpt-3.5-turbo",
            messages = new[]
            {
                new { role = "system", content = "You are a helpful assistant." },
                new { role = "user", content = prompt }
            },
            max_tokens = 1000
        };


        var json = JsonSerializer.Serialize(requestBody);
        var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");

        try
        {
            var response = await HttpClient.PostAsync("https://api.openai.com/v1/chat/completions", content);
            var responseString = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var result = JsonSerializer.Deserialize<JsonElement>(responseString);
                var answer = result.GetProperty("choices")[0].GetProperty("message").GetProperty("content").GetString();
                Console.WriteLine("Open AI'nın cevabı: ");
                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine($"Bir hata oluştu: {response.StatusCode}, Detay: {responseString}");
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine($"Bir hata oluştu: {ex.Message}");

        }
    }
}
// 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
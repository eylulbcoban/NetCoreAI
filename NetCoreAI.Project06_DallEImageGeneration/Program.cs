using System.Drawing;
using System.Text.Json.Serialization;

class Program
{


    public static async Task Main(string[] args)
    {

        string apiKey = "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";
        Console.Write("Lütfen bir prompt giriniz:");
        string prompt;
        prompt = Console.ReadLine();
        using (HttpClient httpClient = new HttpClient())
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            var requestBody = new
            {
                prompt = prompt,
                n = 1,  // Kaç tane resim oluşturulacağını belirtir
                size = "1024x1024"
            };



            string jsonBody = System.Text.Json.JsonSerializer.Serialize(requestBody);
            var content = new StringContent(jsonBody, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await httpClient.PostAsync("https://api.openai.com/v1/images/generations", content);
            string responseString = await responseMessage.Content.ReadAsStringAsync();
            Console.WriteLine(responseString);
        }

    }


}
//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


class Program
{
    static async Task Main(string[] args)
    {
        string apiKey = "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";
        string audioFilePath = "audio.mp3"; // Ses dosyasının yolu

        using (var httpClient = new HttpClient())
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

            var form = new MultipartFormDataContent();  //dosya yüklemek için form-data kullanılır.
            
            var audioContent = new ByteArrayContent(System.IO.File.ReadAllBytes(audioFilePath)); //byte array olarak ses dosyasını oku
            audioContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("audio/mpeg"); //ses dosyasının türü
            form.Add(audioContent, "file", Path.GetFileName(audioFilePath)); //form-data'ya ekle
            form.Add(new StringContent("whisper-1"), "model"); //model adı


            Console.WriteLine("Ses dosyası işleniyor, Lütfen bekleyiniz.....");

            var response = await httpClient.PostAsync("https://api.openai.com/v1/audio/transcriptions", form);
            if(response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Transkripsiyon sonucu: ");
                Console.WriteLine(result);  

            }
            else
            {
                Console.WriteLine($"Bir hata oluştu: {response.StatusCode}, Detay: {await response.Content.ReadAsStringAsync()}");
            }
        }
    }

}
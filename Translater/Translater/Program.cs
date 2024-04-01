using System.Text.Json;
using Translater.Models;

public static class Program
{
    public async static Task Main()
    {
        HttpClient client = new HttpClient();

        while (true)
        {
            Console.Write("Add text: ");
            string text = Console.ReadLine(); //text
            string googleTranslaterUrl = $"https://translation.googleapis.com/language/translate/v2?q={text}&target=az&key=AIzaSyBDApDh3fuxmvvqe5-Y2BVe23eqnxD9Jrs";
            var response = await client.GetAsync(googleTranslaterUrl);
            string responseBody = await response.Content.ReadAsStringAsync();
            var res = JsonSerializer.Deserialize<Root>(responseBody);
            Console.WriteLine(res.data.translations[0].translatedText);
            Console.ReadKey();
            Console.Clear();

        }



    }







}
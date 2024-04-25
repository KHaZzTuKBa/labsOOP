using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("User-Agent", "MyApp");

        // Запрос вакансий по ключевому слову "c# junior developer"
        HttpResponseMessage response1 = await client.GetAsync("https://api.hh.ru/vacancies?text=c#+junior+developer");
        string json1 = await response1.Content.ReadAsStringAsync();
        File.WriteAllText("vacancies_c#_junior_developer.json", json1);

        // Запрос вакансий по городу Москва
        HttpResponseMessage response2 = await client.GetAsync("https://api.hh.ru/vacancies?area=1");
        string json2 = await response2.Content.ReadAsStringAsync();
        File.WriteAllText("vacancies_moscow.json", json2);

        // Запрос вакансий по компании "Vk"
        HttpResponseMessage response3 = await client.GetAsync("https://api.hh.ru/vacancies?employer_id=15478");
        string json3 = await response3.Content.ReadAsStringAsync();
        File.WriteAllText("vacancies_vk.json", json3);

        stopwatch.Stop();
        Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
    }
}
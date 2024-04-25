using System;
using System.IO;
using System.Net.Http;
using System.Diagnostics;
using System.Threading;
class Program1
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        var client = new HttpClient();
        client.DefaultRequestHeaders.Add("User-Agent", "MyApp");

        // Запрос вакансий по ключевому слову "c# junior developer"
        HttpResponseMessage response1 = client.GetAsync("https://api.hh.ru/vacancies?text=c#+junior+developer").Result;
        string json1 = response1.Content.ReadAsStringAsync().Result;
        File.WriteAllText("vacancies_c#_junior_developer.json", json1);

        // Запрос вакансий по городу Москва
        HttpResponseMessage response2 = client.GetAsync("https://api.hh.ru/vacancies?area=1").Result;
        string json2 = response2.Content.ReadAsStringAsync().Result;
        File.WriteAllText("vacancies_moscow.json", json2);

        // Запрос вакансий по компании "Vk"
        HttpResponseMessage response3 = client.GetAsync("https://api.hh.ru/vacancies?employer_id=15478").Result;
        string json3 = response3.Content.ReadAsStringAsync().Result;
        File.WriteAllText("vacancies_vk.json", json3);

        stopwatch.Stop();
        Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
    }
}
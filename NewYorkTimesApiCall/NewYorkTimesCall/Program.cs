using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace NewYorkTimesCall
{
    class Program
    {
        static void Main(String[] args)
        {
            //ShowArticles();
            showWeatherData();
        }
        //private void ShowArticles()
        //{
        //    var response = NYInfo.GetArticles();
        //    var articles = response.Articles;

        //    Console.WriteLine($"Result Found: {response.ResultsFound}");
        //    Console.WriteLine($"{"Title",-10} {"Created_Date",-40}");

        //    foreach (var r in articles)
        //    {
        //        var article = r;

        //        Console.WriteLine($"{article.Title} {article.Created_Date}");
        //    }

        //    Console.ReadLine();
        //}

        private static void showWeatherData()
        {
            var response = WeatherInfo.GetWeather();
            var weekendWeather = response.WeekWeather;
            //var temperate = weekendWeather.Temp;
            Console.WriteLine($"Result Found: {response.TimeZone}");
            foreach (var r in weekendWeather)
            {
                Console.WriteLine($"SunRise: {r.Sunrise} WindDeg: {r.Wind_Deg} Weather: {r.Weather[0].Description} Temp_Day: {r.Temp.Morn}");
            }
            Console.ReadLine();

        }
    }
}

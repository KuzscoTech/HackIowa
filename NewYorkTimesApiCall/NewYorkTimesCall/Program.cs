using Crop_Models;
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
            //showWeatherData();

            Wheat w = new Wheat();

            Console.WriteLine("Enter the amount of acres to be planted");
            w.CostCalculator(int.Parse(Console.ReadLine()));

            Console.WriteLine("\nEnter the amount of acres to be harvested.");
            w.ReturnCalculator(int.Parse(Console.ReadLine()));

            


        }
        private static void ShowArticles()
        {
            var response = NYInfo.GetArticles();
            var articles = response.Articles;

            Console.WriteLine($"Result Found: {response.ResultsFound}");
            Console.WriteLine($"{"Title",-10} {"Created_Date",-40}");

            foreach (var r in articles)
            {
                var article = r;

                Console.WriteLine($"{article.Title} {article.Created_Date}");
            }

            Console.ReadLine();
        }

        private static void showWeatherData()
        {
            var response = WeatherInfo.GetWeather();
            var weekendWeather = response.WeekWeather;

            Console.WriteLine($"Result Found: {response.TimeZone}");
            foreach (var r in weekendWeather)
            {
                //Console.WriteLine($"{r.Temp}");
            }

        }
    }
}

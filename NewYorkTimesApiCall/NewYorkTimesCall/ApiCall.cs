using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace NewYorkTimesCall
{
    class ApiCall
    {
        private static HttpClient GetHttpClient(string url)
        {
            var client = new HttpClient { BaseAddress = new Uri(url) };
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }

        private static async Task<T> GetAsync<T>(string url, string urlParameters)
        {
            try
            {
                using (var client = GetHttpClient(url))
                {
                    HttpResponseMessage response = await client.GetAsync(urlParameters).ConfigureAwait(false);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<T>(json);
                        return result;
                    }

                    return default(T);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return default(T);
            }
        }

        public static async Task<T> RunAsync<T>(string url, string urlParameters)
        {
            return await GetAsync<T>(url, urlParameters).ConfigureAwait(false);
        }
    }
    //All the Api Call's
    public static class NYInfo
    {
        const string url = "https://api.nytimes.com/svc/news/v3/";
        const string apiKey = "AdIG9NVHa94B5dAiOshHTW4lDxOy2clr";

        public static ArticleFeed GetArticles()
        {
            string urlParameters = $"content/all/all.json?api-key={apiKey}";
            var response = ApiCall.RunAsync<ArticleFeed>(url, urlParameters).GetAwaiter().GetResult();
            return response;
        }
    }

    public static class WeatherInfo
    {
        const string url = "https://api.openweathermap.org/data/2.5/";
        const string apiKey = "b171c9eeefb6f23bb60b0ac34a870fe9";
        public static WeatherModel GetWeather()
        {
            double lat = 34.109660;
            double lon = -118.043450;
            string urlParameters = $"onecall?lat={lat}&lon={lon}&appid={apiKey}";
            var response = ApiCall.RunAsync<WeatherModel>(url, urlParameters).GetAwaiter().GetResult();
            return response;
        }
    }
}

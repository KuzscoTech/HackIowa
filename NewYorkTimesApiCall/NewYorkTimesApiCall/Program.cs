using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace NewYorkTimesApiCall
{
    class Program
    {
        static void Main()
        {
            RunAsync().Wait();
        }

        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                const string URL = "https://api.nytimes.com/svc/news/v3/content/all/all.json";
                //TODO- Send HTTP Request
                string ApiKey = "?api-key=AdIG9NVHa94B5dAiOshHTW4lDxOy2clr";
                //Base Address and Init
                client.BaseAddress = new Uri(URL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Getting the actual Api Call Data
                HttpResponseMessage response = client.GetAsync(ApiKey).Result;
                if (response.IsSuccessStatusCode)
                {
                    var dataObjects = response.Content.ReadAsAsync<IEnumerable<DataObject>>().Result;
                }
            }
        }
    }
}

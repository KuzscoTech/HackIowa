using System;
using Newtonsoft.Json;

namespace NewYorkTimesCall
{
    public class ArticleFeed
    {
        [JsonProperty("num_results")]
        public int ResultsFound { get; set; }
        [JsonProperty("results")]
        public ArticleRecord[] Articles { get; set; }
    }
    public class ArticleRecord
    {
        public string Title { get; set; }
        public string Created_Date { get; set; }
        public string URL { get; set; }
    }
}

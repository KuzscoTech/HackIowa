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
        [JsonProperty("multimedia")]
        public ArticleImages[] Multimedia { get; set; }
        public string Thumbnail_Standard { get; set; }
    }
    public class ArticleImages
    {
        public string URL { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}

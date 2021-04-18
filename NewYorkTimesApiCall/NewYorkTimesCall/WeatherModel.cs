using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewYorkTimesCall
{
    public class WeatherModel
    {
        [JsonProperty("timezone")]
        public string TimeZone { get; set; }
        [JsonProperty("daily")]
        public WeeklyWeather[] WeekWeather { get; set; }
    }
    public class WeeklyWeather
    {
        [JsonProperty("temp")]
        public Temperature Temp { get; set; }
        public double Sunrise { get; set; }
        public double Wind_Deg { get; set; }
        public Weather[] Weather { get; set; }

    }
    public class Temperature
    {
        public double Day { get; set; }
        public double Min { get; set; }
        public double Max { get; set; }
        public double Night { get; set; }
        public double Eve { get; set; }
        public double Morn { get; set; }

    }
    public class Weather
    {
        public string Main { get; set; }
        public string Description { get; set; }
    }
}

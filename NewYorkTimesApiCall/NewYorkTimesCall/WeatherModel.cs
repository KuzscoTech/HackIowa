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
        //public Temperature Temp { get; set; }
        public double WindSpeed { get; set; }
        public double WindDeg { get; set; }
        //public Weather Info { get; set; }

    }
    public class Temperature
    {
        public double Day { get; set; }
        public double MinTemp { get; set; }
        public double MaxTemp { get; set; }
        public double NightTemp { get; set; }
        public double EveningTemp { get; set; }
        public double MorningTemp { get; set; }

    }
    public class Weather
    {
        public string Main { get; set; }
        public string Description { get; set; }

    }
}

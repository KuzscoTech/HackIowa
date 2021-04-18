using NewYorkTimesCall;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI_Framework
{
    public partial class userControlWeather : UserControl
    {
        Panel weatherTemplate;
        PictureBox weatherBackground;
        Label WindSPeed;
        Label Weather;
        String[] Weekweather = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Label WeatherDescription;
        Label TimeZone;
        public userControlWeather()
        {
            InitializeComponent();
        }
        private void userControlWeather_Load(object sender, EventArgs e)
        {
            generateWeather();
        }
        private void generateWeather()
        {
            var response = WeatherInfo.GetWeather();
            var articles = response.WeekWeather;
            var position_X = 50;
            var position_Y = 20;
            int i = 0;

            foreach (var r in articles)
            {
                if (i <= 6)
                {
                    weatherBackground = new PictureBox();
                    WeatherDescription = new Label();
                    Weather = new Label();
                    Weather.Text = Weekweather[i] + " : " + string.Format("{0}°F",Math.Round((((r.Temp.Day - 273.15) * 9) / 5 + 32),2));
                    Weather.Location = new Point(position_X + weatherBackground.Location.X, position_Y + weatherBackground.Location.Y);
                    WeatherDescription.Location = new Point(position_X + weatherBackground.Location.X, position_Y + weatherBackground.Location.Y + 50);
                    WeatherDescription.Text = "Description: " + r.Weather[0].Description;
                    WeatherDescription.AutoSize = true;
                    Weather.AutoSize = true;
                    weatherBackground.ImageLocation = getWeatherImage(r.Temp.Day);
                    weatherBackground.Width = 300;
                    weatherBackground.Height = 110;
                    //articleTitle.AutoSize = true;
                    //articleURL.AutoSize = true;
                    //articleURL.Text = r.URL;
                    //articleURL.Location = new Point(position_X, position_Y + 60);
                    //articleURL.Width = 300;
                    //weatherBackground.Controls.Add(weatherBackground);
                    weatherBackground.Controls.Add(Weather);
                    weatherBackground.Controls.Add(WeatherDescription);
                    flowLayoutPanel1.Controls.Add(weatherBackground);
                    //articleTemplate.Controls.Add(articleURL);
                    //flowLayoutPanel1.Controls.Add(articleTemplate);
                    //flowLayoutPanel1.Height = articles.Length * 141;
                    i++;
                }
            }
        }

        private string getWeatherImage(double weather)
        {
            if(weather < 300 && weather > 290)
            {
                return "https://pictkan.com/uploads/cache/1513277351/sky-183869_1920_(1)-400x270-MM-100.jpg";
            }
            else if (weather < 295 && weather > 285)
            {
                return "https://backgroundcheckall.com/wp-content/uploads/2017/12/background-rain-3-300x200.jpg";
            }
            else if(weather < 290 && weather > 270)
            {
                return "http://t04.deviantart.net/TbEsSD-TTb2Zq46Lp7quBEbLRdw=/300x200/filters:fixed_height(100,100):origin()/pre00/db7c/th/pre/i/2011/002/d/d/snow_by_95jessi19-d368c25.jpg";
            }
            return "https://images.pexels.com/photos/209831/pexels-photo-209831.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500";
        }
    }
}

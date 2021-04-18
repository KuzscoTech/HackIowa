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
                    weatherTemplate = new Panel();
                    weatherBackground = new PictureBox();
                    Weather = new Label();
                    weatherTemplate.Width = 274;
                    weatherTemplate.Height = 106;
                    Weather.Text = Weekweather[i] + " : " + (((r.Temp.Day - 273.15) * 9) / 5 + 32).ToString();
                    Weather.Location = new Point(position_X + weatherTemplate.Location.X, position_Y + weatherTemplate.Location.Y);
                    Weather.AutoSize = true;
                    weatherBackground.BackgroundImageLayout = ImageLayout.Stretch;
                    weatherBackground.ImageLocation = getWeatherImage(r.Temp.Day);
                    weatherBackground.Width = 274;
                    weatherBackground.Height = 106;
                    //articleTitle.AutoSize = true;
                    //articleURL.AutoSize = true;
                    //articleURL.Text = r.URL;
                    //articleURL.Location = new Point(position_X, position_Y + 60);
                    //articleURL.Width = 300;
                    weatherTemplate.Controls.Add(weatherBackground);
                    weatherTemplate.Controls.Add(Weather);
                    flowLayoutPanel1.Controls.Add(weatherTemplate);
                    //articleTemplate.Controls.Add(articleURL);
                    //flowLayoutPanel1.Controls.Add(articleTemplate);
                    //flowLayoutPanel1.Height = articles.Length * 141;
                    i++;
                }
            }
        }

        private string getWeatherImage(double weather)
        {
            return "https://images.pexels.com/photos/209831/pexels-photo-209831.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500";
        }
    }
}

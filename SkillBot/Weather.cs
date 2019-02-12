using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace SkillBot
{
    class Weather
    {
        private HttpClient weatherHttp = new HttpClient();

        public string GetTemperature(string cityName)
        {
            try
            {
                string url = $"http://api.openweathermap.org/data/2.5/weather?q={cityName}&units=metric&appid=8ec835031510a67461c5b7fd501e0211";
                string data = weatherHttp.GetStringAsync(url).Result;
                dynamic r = JObject.Parse(data);
                return $"{r.main.temp}°c";
            }
            catch (Exception)
            {
                return "ошибка запроса";
            }

        }

    }
}

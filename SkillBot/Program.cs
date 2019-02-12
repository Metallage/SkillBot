using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather ryazanWeather = new Weather();
            TgBot weatherBot = new TgBot();

           Console.WriteLine(ryazanWeather.GetTemperature("Рязань"));
            Console.WriteLine(weatherBot.GetMe());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Concretos;

namespace Weather
{
    public class Program
    {
        static void Main(string[] args)
        {
            WeatherData data = new WeatherData();
            CurrentConditions currentConditions = new CurrentConditions(data);
            data.SetValues(5.12, 6.23, 1.14);
            data.SetValues(2.43, 4.54, .54);
            data.SetValues(23.54, 12.55, 5.42);
            Console.ReadKey();
        }
    }
}
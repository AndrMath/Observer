using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Interfaces;

namespace Weather.Concretos
{
    public class CurrentConditions : IObserver
    {
        private double Temperature = 1;
        private double Humidity = 1;
        private double Pressure = 1;

        public CurrentConditions(ISubject sujeito)
        {
            sujeito.RegisterObserver(this);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            Temperature = temp;
            Humidity = humidity;
            Pressure = pressure;
            Console.WriteLine("Temperatura: " + Temperature + "- Umidade:" + Humidity + "- Pressão:" + Pressure);
        }
    }
}

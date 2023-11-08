using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Interfaces;

namespace Weather.Concretos
{
    internal class WeatherData : ISubject
    {
        private readonly List<IObserver> Observers;
        private double Temperature;
        private double Humidity;
        private double Pressure;

        public WeatherData()
        { 
        Observers = new List<IObserver>();
        }


        public void NotifyObserver()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update(Temperature, Humidity, Pressure);
            }
        }

        public void RegisterObserver(IObserver observador)
        {
            Observers.Add(observador);
        }

        public void RemoveObserver(IObserver observador)
        {
            Observers.Remove(observador);
        }

        public void SetValues(double temp, double humi, double presure)
        {
            Temperature = temp;
            Humidity = humi;
            Pressure = presure;
            NotifyObserver();
        }
    }
}

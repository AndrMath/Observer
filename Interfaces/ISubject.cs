using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Interfaces
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observador);
        void RemoveObserver(IObserver observador);
        void NotifyObserver();
    }
}

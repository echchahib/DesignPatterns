using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Temperature
{
    public class Temperature : ISubject
    {
        public double Latitude { get; }
        public double Longitude { get; }
        public string NameOfLocation { get; }
        public DateTime LastUpdated { get; private set; }

        private decimal _value;

        public decimal Value
        {
            get => _value;
            set
            {
                _value = value;
                LastUpdated = DateTime.Now;
                Notify();
            }
        }

        private List<IObserver> _observers = new List<IObserver>();

        public Temperature(double lat, double lon, string name, decimal value)
        {
            this.Latitude = lat;
            this.Longitude = lon;
            this.NameOfLocation = name;
            this._value = value;
            LastUpdated = DateTime.Now;
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        public void Subscribe(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void Unsubscribe(IObserver observer)
        {
            _observers?.Remove(observer);
        }
    }
}

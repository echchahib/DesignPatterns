using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Temperature
{
    public class Device : IObserver
    {
        public long IMEI { get; set; }
        public string Name { get; set; }
        public TypeDevice TypeDevice { get; set; }

        public Device(long IMEI, string Name, TypeDevice typeDevice)
        {
            this.IMEI = IMEI;
            this.Name = Name;
            this.TypeDevice = typeDevice;
        }
        public void Update(Temperature temperature)
        {
            Console.WriteLine($"Notification to {this.Name} ({this.TypeDevice}): The temperature is {temperature.Value}°C at {temperature.NameOfLocation}. " +
                   $"Last updated on {temperature.LastUpdated.ToString("f")}.");
        }
    }

    public enum TypeDevice
    {
        PhoneApp,
        DesktopWidget,
        DigitalSignboard
    }
}

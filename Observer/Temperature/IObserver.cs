using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer.Temperature
{
    public interface IObserver
    {
        void Update(Temperature temperature);
    }
}

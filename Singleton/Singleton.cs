using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Singleton
    {
        List<int> list = new List<int>();

        private static Singleton _instance;

        private Singleton() { }

        public static Singleton GetInstance() 
        {
            if (_instance == null)
            {
                _instance = new Singleton();    
            }

            return _instance;
        }

        public void Add(int value) 
        {           
            list.Add(value);
        }

        public void ShowItems()
        {
            foreach (var item in list)
            { 
                Console.WriteLine(item);
            }
        }
    }
}

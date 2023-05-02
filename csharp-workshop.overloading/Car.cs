using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_workshop.overloading
{
    public class Car
    {
        public bool Start()
        {
            return true;
        }
        public bool Start(string key)
        {
            return true;
        }
        public void Start(int speed)
        {
            Console.WriteLine($"now travelling at {speed} km/h");
        }

    }
}

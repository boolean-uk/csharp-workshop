using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_workshop.constructors.Car
{
    public class Car
    {
        private int _numberOfWheels;
        private Engine _engine;

        
        
        public Car(string engineType)
        {
            _engine = new Engine(engineType);
        }
        public Car(Engine engine)
        {
            _engine = engine;
        }
        public Car(Engine engine, int numberOfWheels)
        {
            _numberOfWheels = numberOfWheels;
            _engine = engine;
        }
        
        
        
        
        
        
        public Engine Engine { get { return _engine; } }
       
    }
}

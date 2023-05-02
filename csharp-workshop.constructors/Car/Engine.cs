using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_workshop.constructors.Car
{
    public class Engine
    {
        private string _engineType;

        public Engine(string typeOfEngine)
        {
            _engineType = typeOfEngine;
        }
        public string EngineType { get => _engineType; set => _engineType = value; }
    }
}

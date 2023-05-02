using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_workshop.overloading
{
    public class AddingUpHelper
    {
        public int AddIntegers(int a, int b)
        {
            return a + b;
        }
        public double AddDouble(double a, double b)
        {
            return a + b;
        }



        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }



    }
}

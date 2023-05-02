using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace csharp_workshop.overloading
{
    public class AddingUpHelperClass
    {
        public int AddTwoIntegers(int a, int b)
        {
            return a + b;
        }
        public double AddTwoDoubles(double a, double b)
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
        /// <summary>
        /// add up some doubles
        /// </summary>
        /// <param name="a">first double</param>
        /// <param name="b">second double</param>
        /// <param name="c">third double</param>
        /// <returns></returns>
        public double Add(double a, double b, double c)
        {
            return a + b + c;
        }



    }
}

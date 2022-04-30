using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.StaticConstructor
{
    public class Bus
    {
        public Bus(int times)
        {
            Console.WriteLine($"Bus default constructor for the {times} time");
        }
        static Bus()
        {
            Console.WriteLine("Bus static constructor");
        }   
    }
}

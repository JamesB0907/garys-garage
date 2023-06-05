using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public virtual void Turn()
        {
            Console.WriteLine($"The vehicle turns right");
        }
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
        public virtual void Stop()
        {
             Console.WriteLine("The vehicle rolls to a stop.");
        }
    }
}
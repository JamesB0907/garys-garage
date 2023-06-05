using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage
{
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public override void Drive()
        {
            Console.WriteLine("The blue Ram drives past. RRrrrrrummbbble!");
        }
        public void RefuelTank()
        {
            // method definition omitted
        }
    }
}
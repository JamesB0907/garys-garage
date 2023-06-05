using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("Zoooooom!");
        }

        public override void Stop()
        {
            Console.WriteLine("The white Cessna rolls to a stop after rolling a mile down the runway.");
        }
    }
}

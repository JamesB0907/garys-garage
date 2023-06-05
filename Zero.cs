using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage
{
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Stop()
        {
            Console.WriteLine("The Zero screeches to a stop");
        }
    }
}
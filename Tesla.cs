using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage
{
    public class Tesla  // Electric car
    {
        public double BatteryKWh { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}
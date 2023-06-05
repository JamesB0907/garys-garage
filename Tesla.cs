using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public override void Drive()
        {
            Console.WriteLine("The Tesla whirs past you. Whirrrrrr!");
        }
        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}
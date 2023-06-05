using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();

            fxs.Turn();
            modelS.Turn();
            mx410.Turn();

            fxs.Stop();
            modelS.Stop();
            mx410.Stop();

        }
    }
}
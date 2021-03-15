using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<ICharging> electricVehicles = new List<ICharging>() {
                fx, fxs, modelS
              };

            Console.WriteLine("Electric Vehicles");
            foreach (ICharging ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (ICharging ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (ICharging ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGassinUp> gasVehicles = new List<IGassinUp>() {
                ram, cessna150
              };

            Console.WriteLine("Gas Vehicles");
            foreach (IGassinUp gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (IGassinUp gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGassinUp gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}










// namespace Garage
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Zero fxs = new Zero();
//             fxs.MainColor = "purple";

//             Tesla modelS = new Tesla();
//             modelS.MainColor = "black";

//             Cessna mx410 = new Cessna();
//             mx410.MainColor = "green";

//             Console.Write($"The {fxs.MainColor} sounds like this... ");
//             fxs.Drive();
//             fxs.Turn("the vehicle makes a hard left turn");
//             fxs.Stop();
//             Console.Write($"The {modelS.MainColor} makes a sound like this... ");
//             modelS.Drive();
//             modelS.Turn($"The {modelS.MainColor} turns hard right");
//             modelS.Stop();
//             Console.Write($"The {mx410.MainColor} goes.... ");
//             mx410.Drive();
//         }
//     }

// }
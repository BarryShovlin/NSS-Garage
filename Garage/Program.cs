using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            fxs.MainColor = "purple";

            Tesla modelS = new Tesla();
            modelS.MainColor = "black";

            Cessna mx410 = new Cessna();
            mx410.MainColor = "green";

            Console.Write($"The {fxs.MainColor} sounds like this... ");
            fxs.Drive();
            fxs.Turn("the vehicle makes a hard left turn");
            fxs.Stop();
            Console.Write($"The {modelS.MainColor} makes a sound like this... ");
            modelS.Drive();
            modelS.Turn($"The {modelS.MainColor} turns hard right");
            modelS.Stop();
            Console.Write($"The {mx410.MainColor} goes.... ");
            mx410.Drive();
        }
    }

}
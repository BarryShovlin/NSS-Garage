using System;

public class Cessna : Vehicle, IGassinUp
{
    public double FuelCapacity { get; set; }
    public int CurrentTankPercentage { get; set; } = 45;
    public void RefuelTank()
    {
        Console.Write($"The {this.GetType().Name}'s fuel tank is at {CurrentTankPercentage}%.");
        Console.WriteLine("");
        Console.WriteLine("Refuelling.....");
        CurrentTankPercentage = 100;
        Console.WriteLine($"The {this.GetType().Name}'s tank is now {CurrentTankPercentage}%.");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("");

    }
    public override void Drive()
    {
        Console.WriteLine("Zoooom!");
    }
    public override void Turn(string direction)
    {
        Console.WriteLine("The vehicle turns slightly left");
    }
    public override void Stop()
    {
        Console.WriteLine($"The vehicle stops abbraisively");
    }
}
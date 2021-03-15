using System;

public class Cessna : Vehicle, IGassinUp
{
    public double FuelCapacity { get; set; }
    public int CurrentTankPercentage { get; set; } = 45;
    public void RefuelTank()
    {
        CurrentTankPercentage = 100;
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
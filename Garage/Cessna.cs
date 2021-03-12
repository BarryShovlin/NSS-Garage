using System;

public class Cessna : Vehicle
{
    public double FuelCapacity { get; set; }
    public void RefuelTank()
    {
        // method definition omitted
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
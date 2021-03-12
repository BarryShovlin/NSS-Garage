
using System;

public class Tesla : Vehicle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
    }

    public override void Drive()
    {
        Console.WriteLine("PPPPPSSSSSSSSSSSSSSS");
    }

    public override void Stop()
    {
        Console.WriteLine("The vehicle gently stops");
    }
    public override void Turn(string direction)
    {
        Console.WriteLine("The vehicle turns hard right");
    }
}

using System;

public class Tesla : Vehicle, ICharging
{
    public double BatteryKWh { get; set; }
    public int CurrentChargePercentage { get; set; } = 20;

    public void ChargeBattery()
    {
        CurrentChargePercentage = 100;
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
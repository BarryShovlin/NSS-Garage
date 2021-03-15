
using System;

public class Tesla : Vehicle, ICharging
{
    public double BatteryKWh { get; set; }
    public int CurrentChargePercentage { get; set; } = 20;

    public void ChargeBattery()
    {
        Console.Write($"The {this.GetType().Name}'s battery is at {CurrentChargePercentage}%.");
        Console.WriteLine("");
        Console.WriteLine("Recharging.....");
        CurrentChargePercentage = 100;
        Console.WriteLine($"The {this.GetType().Name}'s battery is now {CurrentChargePercentage}%.");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("");
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
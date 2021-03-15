using System;
public class Zero : Vehicle, ICharging
{
    public double BatteryKWh { get; set; }
    public int CurrentChargePercentage { get; set; } = 35;

    public void ChargeBattery()
    {
        CurrentChargePercentage = 100;
    }

    public override void Drive()
    {
        Console.WriteLine("BBBBBZZZZZZZZZ");
    }
    public override void Turn(string direction)
    {
        Console.WriteLine("The vehicle makes a wide left turn");
    }

    public override void Stop()
    {
        Console.WriteLine("The vehicle rolls to a stop");
    }
}
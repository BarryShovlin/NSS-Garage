using System;
public class Zero : Vehicle
{
    public double BatteryKWh { get; set; }

    public void ChargeBattery()
    {
        // method definition omitted
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
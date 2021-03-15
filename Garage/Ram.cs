using System;

public class Ram : Vehicle, IGassinUp
{
    public double FuelCapacity { get; set; }
    public int CurrentTankPercentage { get; set; } = 13;

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
}
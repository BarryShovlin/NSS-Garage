public class Ram : Vehicle, IGassinUp
{
    public double FuelCapacity { get; set; }
    public int CurrentTankPercentage { get; set; } = 13;

    public void RefuelTank()
    {
        CurrentTankPercentage = 100;
    }
}
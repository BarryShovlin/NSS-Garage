using System;


public interface ICharging
{
    void ChargeBattery();
    int CurrentChargePercentage { get; set; }

}
using System;


public interface IGassinUp
{
    int CurrentTankPercentage { get; set; }
    void RefuelTank();
}
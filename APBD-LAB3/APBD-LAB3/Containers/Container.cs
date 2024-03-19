using System;
using APBD_LAB3.Exceptions;
using APBD_LAB3.Interfaces;

namespace APBD_LAB3;

public class Container : IContainer
{
    private double CargoWeight { get; set; }

    private double Height { get; set; }

    private double SelfWeight { get; set; }

    private double Depth { get; set; }

    private string? SerialNumber { get; set; }

    private double MaxWeight { get; set; }

    public Container(double cargoWeight, double height, double selfWeight, double depth, string? serialNumber, double maxWeight)
    {
        Height = height;
        SelfWeight = selfWeight;
        Depth = depth;
        SerialNumber = serialNumber;
        MaxWeight = maxWeight;
    }

    public void Unload()
    {
        CargoWeight = 0;
        throw new NotImplementedException();
    }

    public virtual void Load(double cargoWeight)
    {
        CargoWeight = cargoWeight;
        throw new OverfillException();
    }
}
using System;
using APBD_LAB3.Exceptions;
using APBD_LAB3.Interfaces;

namespace APBD_LAB3;

public class Container : IContainer
{
    protected double CargoWeight { get; set; }

    protected double Height { get; set; }

    protected double SelfWeight { get; set; }

    protected double Depth { get; set; }

    public string? SerialNumber { get; set; }

    protected double MaxWeight { get; set; }

    protected Container(double height, double selfWeight, double depth, string? serialNumber, double maxWeight)
    {
        Height = height;
        SelfWeight = selfWeight;
        Depth = depth;
        SerialNumber = serialNumber;
        MaxWeight = maxWeight;
    }

    public virtual void Unload()
    {
        CargoWeight = 0;
    }

    public virtual void Load(double cargoWeight)
    {
        if (cargoWeight <= MaxWeight)
        {
            CargoWeight = cargoWeight;
        }
        else
        {
            throw new OverfillException("!Warning! Overfill");
        }
        
    }

    public virtual void PrintData()
    {
        Console.WriteLine($"Container Data for container with a serial number: {SerialNumber}");
        Console.WriteLine($"Height: {Height}");
        Console.WriteLine($"Self Weight: {SelfWeight}");
        Console.WriteLine($"Depth: {Depth}");
        Console.WriteLine($"Max Weight: {MaxWeight}");
        Console.WriteLine($"Cargo Weight: {CargoWeight}");
    }
    
    public override string ToString()
    {
        return "Container with Serial Number: " + SerialNumber;
    }
}
namespace APBD_LAB3;

public class GasContainer : Container
{
    private double Pressure{ get; set; }
    public GasContainer(double height, double selfWeight, double depth, string? serialNumber, double maxWeight, double pressure) : base(height, selfWeight, depth, serialNumber, maxWeight)
    {
        Pressure = pressure;
    }

    public override void  Unload()
    {
        CargoWeight = CargoWeight * 0.05;
    }

    public override void PrintData()
    {
        base.PrintData();
        Console.WriteLine($"Barometric pressure: {Pressure}");
    }
}
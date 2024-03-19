namespace APBD_LAB3;

public class LiquidContainer : Container
{
    private bool safe;
    public LiquidContainer(double cargoWeight, double height, double selfWeight, double depth, string? serialNumber, double maxWeight, bool safe) : base(cargoWeight, height, selfWeight, depth, serialNumber, maxWeight)
    {
    }

    public override void Load(double cargoWeight, bool safe)
    {
        if
        base.Load(cargoWeight);
        throw new OverfillException();
    }
}
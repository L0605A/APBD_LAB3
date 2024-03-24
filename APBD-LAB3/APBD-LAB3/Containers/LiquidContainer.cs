using APBD_LAB3.Exceptions;

namespace APBD_LAB3;

public class LiquidContainer : Container
{
    private bool Safe { get; set; }
    public LiquidContainer(double height, double selfWeight, double depth, string? serialNumber, double maxWeight, bool safe) : base(height, selfWeight, depth, serialNumber, maxWeight)
    {
        Safe = safe;
    }

    public override void Load(double cargoWeight)
    {
        if ((Safe && cargoWeight <= MaxWeight*0.90) || (!Safe && cargoWeight <= MaxWeight*0.50))
        {
            base.Load(cargoWeight); 
        }
        else
        {
            throw new HazardException("!WARNING! Hazarous situation at container " + SerialNumber);
        }
    }
    
    public override void PrintData()
    {
        base.PrintData();
        Console.WriteLine($"Safe?: {Safe}");
    }
}
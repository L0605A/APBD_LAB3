using APBD_LAB3.Enums;
using APBD_LAB3.Exceptions;

namespace APBD_LAB3;

public class RefrigiratedContainer : Container
{
    private Products Product { get; set; }
    
    private double Temp { get; set; }
    
    private Dictionary<Products, double> TempTable = new Dictionary<Products, double>();
    
    

    
    
    public RefrigiratedContainer(double height, double selfWeight, double depth, string? serialNumber, double maxWeight, Products product, double temp) : base(height, selfWeight, depth, serialNumber, maxWeight)
    {
        
        TempTable.Add(Products.Bananas, 13.3);
        TempTable.Add(Products.Chocolate, 18);
        TempTable.Add(Products.Fish, 2);
        TempTable.Add(Products.IceCream, -15);
        TempTable.Add(Products.FrozenPizza, -18);
        TempTable.Add(Products.Cheese, -30);
        TempTable.Add(Products.Sausages, 7.2);
        TempTable.Add(Products.Butter, 20.5);
        TempTable.Add(Products.Eggs, 19);

        if (temp <= TempTable[product])
        {
            Product = product;
            Temp = temp;
        }
        else
        {
            throw new HazardException("!WARNING! Hazarous situation at container " + SerialNumber);
        }
        
    }

    public override void Load(double cargoWeight)
    {
        if (true)
        {
            base.Load(cargoWeight); 
        }
    }
    
    public override void PrintData()
    {
        base.PrintData();
        Console.WriteLine($"Product: {Product}");
        Console.WriteLine($"Temperature: {Temp}");
    }
}
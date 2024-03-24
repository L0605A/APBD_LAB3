using System.Collections.Generic;
using APBD_LAB3.Enums;

namespace APBD_LAB3
{
    public class ContainerManager
    {
        public static List<Container>? ContainerList { get; set; } = new List<Container>();

        public static Container addLiquidContainer(double height, double selfWeight, double depth, double maxWeight, bool safe)
        {
            string serialNumber = "KON-L-" + (ContainerList.Count + 1);

            Container? container = new LiquidContainer(height, selfWeight, depth, serialNumber, maxWeight, safe);

            ContainerList.Add(container);

            return container;
        }
        
        public static Container addGasContainer(double height, double selfWeight, double depth, double maxWeight, double pressure)
        {
            string serialNumber = "KON-G-" + (ContainerList.Count + 1);

            Container? container = new GasContainer(height, selfWeight, depth, serialNumber, maxWeight, pressure);

            ContainerList.Add(container);
            
            return container;
        }
        
        public static Container addRefrigiratedContainer(double height, double selfWeight, double depth, double maxWeight, Products product, double temp)
        {
            string serialNumber = "KON-R-" + (ContainerList.Count + 1);

            Container? container = new RefrigiratedContainer(height, selfWeight, depth, serialNumber, maxWeight, product, temp);

            ContainerList.Add(container);
            
            return container;
        }
        
        
        public static void loadContainer(Container container, double cargoWeight)
        {
            container.Load(cargoWeight);
        }
        
        public static void unloadContainer(Container container)
        {
            container.Unload();
        }
        
    }
}
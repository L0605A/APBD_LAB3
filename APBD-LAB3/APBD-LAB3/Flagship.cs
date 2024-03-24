namespace APBD_LAB3;

public class Flagship
{
    public int ID;

    public Flagship(int id)
    {
        ID = id;
    }

    public List<Container>? ContainerList { get; set; } = new List<Container>();

    public void loadContainer(Container container)
    {
        ContainerList.Add(container);
    }
    
    public void loadContainer(List<Container>? containers)
    {
        foreach (var ele in containers)
        {
            ContainerList.Add(ele);
        }
        
    }
    
    
    public void unloadContainer(Container container)
    {
        ContainerList.Remove(container);
    }
    
    public void replaceContainer(Container replaced, Container replacee)
    {
        int index = ContainerList.FindIndex(s => s == replaced);

        if (index != -1)
            ContainerList[index] =  replacee;
    }

    public void moveContainer(Container moved, Flagship ship)
    {
        unloadContainer(moved);
        ship.loadContainer(moved);
    }
    
    public void printManifest()
    {
        Console.WriteLine("Manifest for ship with ID " + ID);
        foreach (var ele in ContainerList)
        {
            Console.WriteLine(ele);
        }
    }
}
namespace APBD_LAB3.Interfaces;

public interface IContainer
{
    void Unload();
    
    void Load(double cargoWeight);
}
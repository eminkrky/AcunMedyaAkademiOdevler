using ODEV1.IFeatures;

namespace ODEV1;

public class Bmw: ICar,fast,flying,swimming
{
    public string Brand { get; set; }

    public Bmw()
    {
        Brand = "Bmw";
    }
    
    public void thisIsFast()
    {
        Console.WriteLine(Brand+"---> I'm fast");
    }

    public void thisIsFlying()
    {
        Console.WriteLine(Brand+"---> I'm flying");
    }

    public void thisIsSwimming()
    {
        Console.WriteLine(Brand+"---> I'm swimming");
    }
    
    
}
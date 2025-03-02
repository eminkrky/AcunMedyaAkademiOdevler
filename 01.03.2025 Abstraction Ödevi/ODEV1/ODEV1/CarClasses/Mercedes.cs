using ODEV1.IFeatures;

namespace ODEV1;

public class Mercedes: ICar, swimming,flying
{
    public string Brand { get; set; }

    public Mercedes()
    {
        Brand = "Mercedes";
    }

    public void thisIsSwimming()
    {
        Console.WriteLine(Brand+"---> I'm swimming");
    }

    public void thisIsFlying()
    {
        Console.WriteLine(Brand+"---> I'm flying");
    }
}
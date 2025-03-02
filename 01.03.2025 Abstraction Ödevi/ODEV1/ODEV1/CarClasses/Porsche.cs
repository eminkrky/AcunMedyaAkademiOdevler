using ODEV1.IFeatures;

namespace ODEV1;

public class Porsche: ICar,flying
{
    public string Brand { get; set; }

    public Porsche()
    {
        Brand="Porsche";
    }
    public void thisIsFlying()
    {
        Console.WriteLine(Brand+"---> I'm flying");
    }
}
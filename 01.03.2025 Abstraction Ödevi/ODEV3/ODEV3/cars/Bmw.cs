namespace ODEV3;

public class Bmw:car
{
    public string brand { get; set; }

    public Bmw()
    {
        brand = "BMW";
    }
    
    public override int yakitHesapla()
    {
        return 80;
    }
}
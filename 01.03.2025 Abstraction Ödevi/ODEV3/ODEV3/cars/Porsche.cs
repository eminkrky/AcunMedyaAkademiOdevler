namespace ODEV3;

public class Porsche:car
{
    public string brand { get; set; }

    public Porsche()
    {
        brand="Porsche";
    }
    
    public override int yakitHesapla()
    {
        return 60;
    }
    
}
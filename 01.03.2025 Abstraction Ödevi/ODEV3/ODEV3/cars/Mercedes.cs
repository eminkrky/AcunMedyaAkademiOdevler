namespace ODEV3;

public class Mercedes:car
{
    public string brand { get; set; }

    public Mercedes()
    {
        brand = "Mercedes";
    }
    
    public override int yakitHesapla()
    {
        return 70;
    }
}
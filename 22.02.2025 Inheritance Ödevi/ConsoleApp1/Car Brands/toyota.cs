using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Car_Brands;

public class toyota : Icar
{
    public string gear { get; set; }
    public string model { get; set; }
    public string brand { get; set; }
    public double km { get; set; }
    public int year { get; set; }
    public toyota(string gear, string model, double km, int year)
    {
        brand = "Toyota";
        this.gear = gear;
        this.model = model;
        this.km = km;
        this.year = year;
    }
    
}
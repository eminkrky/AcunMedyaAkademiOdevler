namespace ConsoleApp1.Interfaces;

public interface Icar
{
    public double km { get; set; }
    
    public int year { get; set; }
    
    public string brand { get; set; }
    public string model { get; set; }
    
    public string gear { get; set; }
    
    public void printInfo()
    {
        Console.WriteLine($"Brand: {brand}");
        Console.WriteLine($"Model: {model}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Km: {km}");
        Console.WriteLine($"Gear: {gear}");
    }
    
    
}
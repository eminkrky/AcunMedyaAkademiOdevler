
using ConsoleApp1.Interfaces;
using ConsoleApp1.Car_Brands;

class Program
{
    static void Main()
    {
        Icar[] arabalar = new Icar[]
        {
            new bmw("Manual Gear", "I8", 20000, 2024),
            new audi("Automatic Gear", "A8", 2304, 2025),
            new porsche("Automatic Gear", "911", 100, 2026),
            new togg("Automatic Gear", "T10X", 34000, 2023),
            new toyota("Manual Gear", "Corolla", 230400, 2016)
        };

        arabalar[1].printInfo();
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("");
            arabalar[i].printInfo();
        }
    }
}



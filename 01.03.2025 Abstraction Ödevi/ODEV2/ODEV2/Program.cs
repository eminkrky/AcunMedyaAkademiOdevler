// See https://aka.ms/new-console-template for more information

using ODEV2.Calısanlar;

public class Program()
{
    public static void Main()
    {
        
        genelMudur calisan1 = new genelMudur();
        mudur calisan2 = new mudur();
        programci calisan3 = new programci();
        stajyer calisan4 = new stajyer();

        int toplamMaas = 0;

        toplamMaas += calisan1.maasinizNedir();
        toplamMaas += calisan2.maasinizNedir();
        toplamMaas += calisan3.maasinizNedir();
        toplamMaas += calisan4.maasinizNedir();

        Console.WriteLine("Toplam Maaş: "+toplamMaas);


    }
}
using System;

class Program
{
    static void Main()
    {
        
        int[] sayilar = new int[5];
        int toplam = 0;
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Lütfen {i + 1}. sayıyı girin: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }
        
        double ortalama = (double)toplam / 5;
        
        Console.WriteLine($"Girilen sayıların toplamı: {toplam}");
        Console.WriteLine($"Girilen sayıların ortalaması: {ortalama}");
    }
}
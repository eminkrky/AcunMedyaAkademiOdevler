using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int hedefSayi = random.Next(1, 101);
        int tahmin = 0;
        int tahminSayisi = 0;

        Console.WriteLine("1 ile 100 arasında bir sayı tahmin edin.");

        while (tahmin != hedefSayi)
        {
            Console.Write("Tahmininiz: ");
            tahmin = int.Parse(Console.ReadLine());
            tahminSayisi++;

            if (tahmin < hedefSayi)
            {
                Console.WriteLine("Daha büyük bir sayı girin.");
            }
            else if (tahmin > hedefSayi)
            {
                Console.WriteLine("Daha küçük bir sayı girin.");
            }
            else
            {
                Console.WriteLine($"Tebrikler! {tahminSayisi} tahminde doğru sonuca ulaştınız.");
            }
        }
    }
}
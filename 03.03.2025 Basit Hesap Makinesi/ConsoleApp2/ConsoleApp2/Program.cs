using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci tam sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci tam sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Yapmak istediğiniz işlemi seçin (+, -, *, /): ");
        char islem = Convert.ToChar(Console.ReadLine());

        if (islem == '+')
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine($"Toplama işlemi sonucu: {sonuc}");
        }
        else if (islem == '-')
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine($"Çıkarma işlemi sonucu: {sonuc}");
        }
        else if (islem == '*')
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine($"Çarpma işlemi sonucu: {sonuc}");
        }
        else if (islem == '/')
        {
            if (sayi2 != 0)
            {
                double sonuc = (double)sayi1 / sayi2;
                Console.WriteLine($"Bölme işlemi sonucu: {sonuc}");
            }
            else
            {
                Console.WriteLine("Hata: Sıfıra bölme hatası!");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz işlem seçimi!");
        }
    }
}
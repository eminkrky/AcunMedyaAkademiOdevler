using System;

namespace MatematikIslemleri
{
    
    public class Hesaplama
    {
        
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine($"{sayi1} + {sayi2} = {toplam}");
        }

        
        public void Carp(int sayi1, int sayi2)
        {
            int carpim = sayi1 * sayi2;
            Console.WriteLine($"{sayi1} * {sayi2} = {carpim}");
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        
        Marka marka = new Marka("BMW", "X5");
        Kapi kapi = new Kapi(4);
        Pencere pencere = new Pencere(4);
        Kasa kasa = new Kasa("Sedan");
        decimal fiyat = 2000000;
        
        Araba araba = new Araba(marka, kapi, pencere, kasa, fiyat);

        araba.BilgileriYazdir();
    }
}
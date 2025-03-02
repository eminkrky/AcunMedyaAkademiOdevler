// See https://aka.ms/new-console-template for more information
using ODEV3;

public class Program{
    
        public static void Main(string[] args){

                Bmw araba1 = new Bmw();
                Mercedes araba2 = new Mercedes();
                Porsche araba3 = new Porsche();

                int toplamYakit = 0;
                
                toplamYakit+=araba1.yakitHesapla();
                toplamYakit+=araba2.yakitHesapla();
                toplamYakit+=araba3.yakitHesapla();

                Console.WriteLine("Toplam Yakıt: "+toplamYakit);
                
        }
}
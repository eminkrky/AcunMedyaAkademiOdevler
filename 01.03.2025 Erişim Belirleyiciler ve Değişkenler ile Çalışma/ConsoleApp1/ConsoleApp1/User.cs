using System;

public class User
{
    private string adSoyad;
    private int yas;
    
    public string Email { get; set; }
    
    public string GetAdSoyad()
    {
        return adSoyad;
    }

    public void SetAdSoyad(string adSoyad)
    {
        this.adSoyad = adSoyad;
    }

    public int GetYas()
    {
        return yas;
    }

    public void SetYas(int yas)
    {
        if (yas >= 0)
        {
            this.yas = yas;
        }
        else
        {
            Console.WriteLine("Yaş pozitif bir değer olmalıdır.");
        }
    }
    
    public void BilgileriGoster()
    {
        Console.WriteLine("Ad Soyad: " + adSoyad);
        Console.WriteLine("Yaş: " + yas);
        Console.WriteLine("E-posta: " + Email);
    }
}
class Program
{
    static void Main(string[] args)
    {
        User user1 = new User();
        
        user1.SetAdSoyad("Ahmet Erdem");
        user1.SetYas(22);
        user1.Email = "ahmet.erdem@acunmail.com";
        
        user1.BilgileriGoster();
    }
}
namespace ProgramTest
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            MatematikIslemleri.Hesaplama hesap = new MatematikIslemleri.Hesaplama();

            
            hesap.Topla(5, 3);

            // Carp metodunu çağırma
            hesap.Carp(4, 6);
        }
    }
}

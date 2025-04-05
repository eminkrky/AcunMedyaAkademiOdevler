using System.Security.Policy;

namespace WinFormsApp4
{
    internal static class Program
    {


//        ✅ Windows Forms kullanarak kullanıcı dostu bir arayüz tasarlayın.
//✅ Kullanıcıdan aşağıdaki bilgileri almak için TextBox bileşenlerini kullanın:

//🚘 Marka: (Örnek: Toyota, BMW, Mercedes)

//📅 Model: (Örnek: Yaris, X5, C180)

//🎨 Renk: (Örnek: Kırmızı, Mavi, Beyaz)

//🚪 Kapı Sayısı: (Örnek: 2, 4)

//🪟 Pencere Sayısı: (Örnek: 4, 6)

//⛽ 100 km’de Yaktığı Yakıt(Litre) : (Örnek: 6.5, 7.8)

//✅ Kullanıcı "Bilgileri Göster" butonuna bastığında, girilen veriler bir MessageBox ile gösterilmelidir.
//✅ Kodunuz okunabilir ve açıklamalı olmalıdır.Açıklamalar(// yorum satırları) ekleyerek kodunuzu daha anlaşılır hale getirin.
//✅ Düzgün ve hatasız çalışan bir uygulama teslim edin.

//📌 Örnek Kullanım Senaryosu:

//1️⃣ Kullanıcı formu açar ve ilgili alanlara bilgileri girer.
//2️⃣ "Bilgileri Göster" butonuna basar.
//3️⃣ Girilen bilgiler bir MessageBox içinde ekrana yazdırılır.
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
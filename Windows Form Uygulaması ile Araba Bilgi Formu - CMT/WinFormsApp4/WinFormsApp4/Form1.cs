using System;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde çalışacak kod (varsa)
        }

        private void Button_Click(object sender, EventArgs e)
        {
            //  Giriş kodları gibi kodlar buraya eklenebilir.

            string message = $"Marka: {markaText.Text}\n" +
                             $"Model: {modelText.Text}\n" +
                             $"Renk: {renkText.Text}\n" +
                             $"Kapı Sayısı: {kapiSayisiText.Text}\n" +
                             $"Pencere Sayısı: {pencereSayisiText.Text}\n" +
                             $"100km Yakıt Tüketimi: {yüzKmdeYakit.Text}";

            MessageBox.Show(message, "Araç Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
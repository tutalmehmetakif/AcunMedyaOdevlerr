using NamespaceKullanımıVeGenişletilebilirlikOdevi.AcunMedyaOdev;

namespace Test
{
  class Program
    {
        static void Main()
        {
            Hesaplama hesaplama = new Hesaplama();
            int toplamSonucu = hesaplama.Topla(5, 9);
           int carpimSonucu =  hesaplama.Carp(9, 214);

            Console.WriteLine($"Toplama Sonucu: {toplamSonucu}");
            Console.WriteLine($"Çarpma Sonucu: {carpimSonucu}");


        }
    }







}
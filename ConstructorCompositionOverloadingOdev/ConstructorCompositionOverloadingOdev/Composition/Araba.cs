using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorCompositionOverloadingOdev.Composition
{
    public class Araba
    {
        public Kapı kapı;
        public Kasa kasa;
        public Marka marka;
        public Pencere pencere;

        public string model;
        public double fiyat;

        public Araba(Kapı kapı, Kasa kasa, Marka marka, Pencere pencere, double fiyat,string model)
        {
            this.kapı = kapı;
            this.kasa = kasa;
            this.marka = marka;
            this.pencere = pencere;
            this.fiyat = fiyat;
            this.model = model;
        }

        public void arabaBilgileri()
        {
            Console.WriteLine($"Arabanın markası {marka.marka}, modeli {model}, kapı sayısı {kapı.kapi}, kasası {kasa.kasa}, fiyatı {fiyat} TL'dir. ");
        }




    }
}

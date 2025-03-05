using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErisimBelirleyicilerVeDegiskenlerOdevi.Class
{
    public class User
    {
        private string adSoyad;
        private int yas;
        public string Email;

        public int Yas
        {
            get { return yas; }
            set
            {
                if (value > 0)
                {
                    yas = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz değer");
                    yas = 0;
                }

            }
        }


            public string ADSOYAD
        {
            get { return adSoyad; }
            set {if(value.Length >=2){
                     adSoyad = value;

                }
                else
                {
                    Console.WriteLine("Geçersiz değer");
                    adSoyad = "";
                }
        }
        }

        public void BilgileriGöster()
        {
            Console.WriteLine($"Kullanıcının Adı {adSoyad} \nKullanıcının Yaşı {yas} ");
        }
       
    }
}

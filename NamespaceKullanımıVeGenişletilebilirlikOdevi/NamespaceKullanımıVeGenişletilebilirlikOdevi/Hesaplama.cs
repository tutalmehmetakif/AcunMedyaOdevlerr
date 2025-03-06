using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceKullanımıVeGenişletilebilirlikOdevi
{
    /* 
  Namespace’ler, C# projelerinde kod organizasyonunu
ve sınıfların isim çakışmalarını önlemek için kullanılan önemli bir kavramdır. 
Namespace’ler, kodunuzu mantıklı gruplar halinde düzenlemenize ve farklı sınıf ve tipleri ayırt etmenize yardımcı olur. 

 Namespace, C# projelerinde kodunuzu düzenlemek ve gruplamak için kullanılan bir yapıdır. 
  Namespace’ler, kodunuzun hangi modülde veya parçada olduğunu belirtir ve çakışan sınıf isimlerini çözer. 


 Genişletilebilirlik, bir yazılımın temel yapısını değiştirmeden 
yeni özellikler veya işlevler eklemeye olanak tanıyan bir yazılım geliştirme prensibidir.
Genişletilebilir bir yazılım, değişikliklere kolayca adapte olabilir ve yeni gereksinimlere uyum sağlayabilir.

 Genişletilebilirliği sağlamak için modüler tasarım,
açık/kapalı prensibi (OCP), bağımlılıkların azaltılması (loose coupling), 
arayüzler ve soyutlama (interfaces & abstraction) ve plugin/API kullanımı gibi yöntemler uygulanabilir. 
Yazılımı bağımsız bileşenler halinde geliştirerek yeni bileşenlerin eklenmesini kolaylaştırabilir, 
mevcut kodu değiştirmeden yeni özellikler eklemek için modüler bir yapı oluşturabiliriz.
 
 */
    namespace AcunMedyaOdev
    {
        public class Hesaplama
        {
            public int Topla(int sayi1, int sayi2)
            {
                return sayi1+sayi2;
            }

            public int Carp(int sayi1, int sayi2)
            {
               return sayi1* sayi2;

            }


        }







    }

}

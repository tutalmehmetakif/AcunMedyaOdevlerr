using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOdevi2.AbstractClass
{

    /*Abstraction (Soyutlama) detayları saklama 
      ve sadece gösterilmesi istenen bilgileri kullanıcıya göstermek amacıyla kullanılır.
      Abstraction(Soyutlama) hem Abstract class(soyutlama sınıfları) ile hem de interfaces (arayüzler) ile yapılır.
     /*

   

    /*Abstract class (soyut sınıf), doğrudan nesne oluşturulamayan,
    ancak alt sınıflar tarafından miras alınarak kullanılan
    ve genellikle ortak işlevsellik ile soyut metodlar içeren bir sınıftır;
    soyut metodlar alt sınıflarda implement edilmek zorundadır.*/
    abstract class Animal
    {
        public abstract void SesYap();   

        public void Uyu(string name)
        {
            Console.WriteLine(name + " uyuyor...");
        }




        
    }
}

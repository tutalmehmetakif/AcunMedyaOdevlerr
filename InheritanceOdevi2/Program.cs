


using InheritanceOdevi2.AbstractClass;

//Abstract class örneği
Kopek kopek = new Kopek();
kopek.SesYap();
kopek.Uyu("Kopek");


/*Abstraction (Soyutlama) detayları saklama 
     ve sadece gösterilmesi istenen bilgileri kullanıcıya göstermek amacıyla kullanılır.
     Abstraction(Soyutlama) hem Abstract class(soyutlama sınıfları) ile hem de interfaces (arayüzler) ile yapılır.
    /*



   /*Abstract class (soyut sınıf), doğrudan nesne oluşturulamayan,
   ancak alt sınıflar tarafından miras alınarak kullanılan
   ve genellikle ortak işlevsellik ile soyut metodlar içeren bir sınıftır;
   soyut metodlar alt sınıflarda implement edilmek zorundadır.*/


/* Polymorphism(Çok Biçimlilik)
    Bir temel sınıfın özellik ve metotlarını, 
    temel sınıftan türetilen bir sınıfa aktardığımızda 
    temel sınıfa ait metotları türemiş sınıf içerisinde de kullanabiliriz. 
    Ancak her iki sınıfta da aynı metot bulunduğunda temel sınıftaki metot kullanılacak, 
    türemiş sınıftaki metot ise kullanılmayacaktır. 
    Temel sınıfa ait metotları türemiş sınıfta farklı biçimlerde tanımlayarak 
    kullanmak için override ve virtual niteleyicilerini kullanmak gereklidir.
    */

Araba araba = new Bmw();
araba.Dur();
araba.Git();

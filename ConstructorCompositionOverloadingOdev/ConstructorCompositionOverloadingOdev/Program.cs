

using ConstructorCompositionOverloadingOdev.Composition;
using ConstructorCompositionOverloadingOdev.Overloading;

Kapı kapı = new Kapı(4);
Kasa kasa = new Kasa("sedan");
Marka marka = new Marka("BMW");
Pencere pencere = new Pencere(4);

Araba araba = new Araba(kapı, kasa,marka,pencere,2000000.0,"X5");
araba.arabaBilgileri();

Console.WriteLine();



Matematik mat = new Matematik();
int ilkToplam = mat.Toplama(4, 5);
double ikinciToplam = mat.Toplama(4, 5, 8);
double ucuncuToplam = mat.Toplama(4, 5.25, 8);

int ilkCarpma = mat.Carpma(4, 24);
double ikinciCarpma= mat.Carpma(24, 28, 39);
double ucuncuCarpma = mat.Carpma(5.27, 7, 9);

Console.WriteLine($"İlk toplam = {ilkToplam}");
Console.WriteLine($"İkinci toplam = {ikinciToplam}");
Console.WriteLine($"Üçüncü toplam = {ucuncuToplam}");
Console.WriteLine($"İlk Çarpım = {ilkCarpma}");
Console.WriteLine($"İkinci Çarpım = {ikinciCarpma}");
Console.WriteLine($"Üçüncü Çarpım = {ucuncuCarpma}");



/* 3-) C# Garbage Collector Nedir?
Garbage Collector (GC), C# ve .NET platformlarında bellek yönetimini otomatik olarak gerçekleştiren bir mekanizmadır.
GC, kullanılmayan nesneleri (artık referans verilmeyen nesneleri) temizleyerek
bellek sızıntılarını önler ve uygulamanın performansını artırır.

Garbage Collector, üç aşamada çalışır:

Root Analizi:

GC, uygulamada hâlâ erişilebilen nesneleri belirler. Bunlara root (kök) nesneler denir.

Kullanılmayan nesneleri tespit etmek için bellek taranır.
Eğer bir nesneye artık referans verilmiyorsa, o nesne çöp (garbage) olarak işaretlenir.

Temizlik (Sweeping) ve Sıkıştırma (Compacting) Aşaması:

İşaretlenen çöp nesneler bellekten silinir ve bellek alanı yeniden kullanılabilir hale getirilir.
Eğer gerekirse, nesneler taşınarak bellek düzenlenir (fragmentation önlenir).


Garbage Collector’ın Bellek Yönetimindeki Rolü

Otomatik Bellek Yönetimi Sağlar: Manuel bellek tahsisi ve temizleme ihtiyacını ortadan kaldırır.

Bellek Sızıntılarını Önler: Kullanılmayan nesneleri temizleyerek gereksiz bellek tüketimini engeller.

Uygulama Performansını Artırır: Bellek yönetimini optimize ederek gereksiz yavaşlamaların önüne geçer.

Üç Nesil (Generation) Mantığı ile Çalışır: Nesneler Gen 0, Gen 1 ve Gen 2 olarak kategorize edilir.
Gen 0: Yeni oluşturulan nesneler (hızlı temizlenir).
Gen 1: Orta yaşlı nesneler.
Gen 2: Uzun ömürlü nesneler (büyük nesneler burada tutulur).
Bu sayede sık kullanılan nesneler korunur, gereksiz nesneler ise hızla temizlenir.


*/

/*
 Generic yapılar, C# programlamada veri tipi bağımsız kod yazmayı sağlayan güçlü bir özelliktir.
Generic sınıflar ve metotlar, kod tekrarını azaltır, veri tipi güvenliğini artırır ve performansı iyileştirir.

Generic Yapıların Avantajları
 Tip Güvenliği (Type Safety):

Hataları çalışma zamanında (runtime) değil, derleme zamanında (compile-time) yakalar.
Yanlış türde veri kullanma hatalarını önler.
 Kod Tekrarını Önler (Reusable Code):

Aynı kodu farklı veri tipleriyle kullanmayı sağlar.
int, string, double gibi veri tipleri için ayrı ayrı metot yazmaya gerek kalmaz.
 Performans Artışı:

Boxing & Unboxing’i azaltarak gereksiz bellek tahsislerinden kaçınılır.
Derleme zamanı belirlenen tiplerle çalıştığı için hızlıdır.
 Bakımı Kolaylaştırır:

Değişiklik yapmadan farklı veri türleriyle çalışabilir.


Boxing & Unboxing Nedir? Performansa Etkisi
 Boxing:

Değer tipini (Value Type) referans tipine (Reference Type) dönüştürme işlemidir.
Heap bellek kullanılır, bu yüzden yavaştır.

 Unboxing:

Referans tipini tekrar değer tipine çevirme işlemidir.
Cast (dönüştürme) gerektirir, ekstra işlem maliyeti oluşturur.

Boxing & Unboxing’in Performansa Etkisi
 Boxing ve Unboxing işlemleri, bellek kullanımını artırır ve performansı düşürür.
 Generic yapılar sayesinde Boxing & Unboxing işlemlerine gerek kalmaz.

 
  
  */





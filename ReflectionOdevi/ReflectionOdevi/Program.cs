
/* 
    Reflection Nedir 
 Reflection, C# dilinde bir program çalışırken (runtime'da), o programın içindeki sınıflar,
  metodlar, özellikler, yapıcılar gibi yapılar hakkında bilgi alma ve müdahale etme yeteneğidir.

    Reflection Ne İşe Yarar?
Program çalışırken bir nesnenin tipini öğrenebiliriz.

Hangi özelliklere (property) ve metotlara sahip olduğunu görebiliriz.

Dinamik olarak metot çağırabiliriz.

Özellikle:

Nesne yönelimli analizde

Test araçlarında

ORM sistemlerinde (Entity Framework gibi)

Plug-in sistemlerinde

Json/XML gibi dış veri kaynaklarını nesneye çevirmede kullanılır.


  */

using ReflectionOdevi.Classes;
using System.Reflection;

Type tip = typeof(Ogrenci); // Ogrenci sınıfının tipi

Console.WriteLine("Sınıf Adı: " + tip.Name);

Console.WriteLine("\nSınıftaki Özellikler:");
foreach (PropertyInfo prop in tip.GetProperties())
{
    Console.WriteLine("- " + prop.Name + " (" + prop.PropertyType.Name + ")");
}

// ATTRIBUTE NEDİR?

//Attribute, C# dilinde sınıf, metod, property gibi yapılara ek bilgi (meta bilgi) eklememizi sağlayan özel işaretlerdir.


//NEREDE VE NEDEN KULLANILIR?
/* Attribute'lar şuralarda kullanılır:

Kod hakkında bilgi vermek

Otomatik işlem yapmak

Hata önlemek

Reflection ile dinamik işlemler yapmak
    */

/*GERÇEK HAYAT ÖRNEKLERİ:

[Obsolete] Bir metodun eski olduğunu belirtir.	Kullanıcıyı uyarır: "Bu metodu kullanma."
[Required] Bir property'sinin boş geçilmemesi gerektiğini söyler.	 Form doğrulamada kullanılır.
[Serializable] Sınıfın serileştirilebileceğini gösterir.			 Dosyaya veya network'e veri yazmada.

Attribute'lar ile veri doğrulama (validation) nasıl yapılabilir?

C#'ta Attribute'lar, özellikle veri doğrulama (validation) işlemleri için çok yaygın bir şekilde kullanılır.
Genellikle, kullanıcıdan alınan verileri doğrulamak ve geçerli olup olmadığını kontrol etmek için 
Attribute tabanlı yaklaşım tercih edilir. Bu yaklaşımda, özel doğrulama Attribute sınıfları tanımlanır 
ve bu doğrulamalar ilgili veri üzerinde uygulanır.

En yaygın kullanımı, ASP.NET gibi web framework'lerinde karşımıza çıkar,
ancak sadece framework’lerde değil, kendi projelerinizde de validation işlemlerini yapmak için 
custom attribute'lar yazabilirsiniz.



*/

using System;
public class ImportantAttribute : Attribute
{
    public string Description { get; }

    public ImportantAttribute(string description)
    {
        Description = description;
    }
}

namespace AttributeOrnek
{
    class Program
    {
        // Bu metodu "Önemli" olarak işaretliyoruz
        [Important("Bu metod çok önemli, dikkatle kullanınız!")]
        public void OnemliMetod()
        {
            Console.WriteLine("Onemli metod calisiyor.");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.OnemliMetod();

            // Attribute'ı Reflection ile inceleyelim
            var methodInfo = typeof(Program).GetMethod("OnemliMetod");
            var attribute = (ImportantAttribute)Attribute.GetCustomAttribute(methodInfo, typeof(ImportantAttribute));

            if (attribute != null)
            {
                Console.WriteLine($"Metod Açıklaması: {attribute.Description}");
            }
        }
    }
}




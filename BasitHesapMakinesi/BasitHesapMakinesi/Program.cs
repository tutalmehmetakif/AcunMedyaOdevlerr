
using BasitHesapMakinesi;

Console.WriteLine("Lütfen ilk sayıyı giriniz ");
double sayı1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Lütfen ikinci sayıyı giriniz");
double sayı2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Lütfen yapmak istediğiniz işlemi giriniz (+,-,*,/)");

char işlem = Convert.ToChar(Console.ReadLine());

Matematik mat = new Matematik();
mat.hesap(işlem,sayı1,sayı2);


//Arraylist in array den farkı bunun içine sonradan veri eklenebilmesi
//ve içine farklı veri tiplerinde veriler alabilmesidir.

using System.Collections;
using System.Xml;

ArrayList list = new ArrayList(); //Burada içine farklı değerler alabilen
                                  //bir arraylist tanımladık
list.Add("Erzincan");
list.Add("24");
list.Add(0.50);
list.Add((true));

foreach (var  item in list)      // burada da foreach döngüsü ile yazdırıyoruz.
{
    Console.WriteLine(item);
}





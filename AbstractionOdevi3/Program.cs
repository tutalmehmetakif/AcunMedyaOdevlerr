

using AbstractionOdevi3.Class;

Bmw bmw = new Bmw();
double bmwHarcananYakıt = bmw.harcananYakıt();
Console.WriteLine($"BMW --> {bmwHarcananYakıt}L");

Mercedes mercedes = new Mercedes();
double mercedesHarcananYakıt = mercedes.harcananYakıt();
Console.WriteLine($"Mercedes --> {mercedesHarcananYakıt}L");

Porche porsche = new Porche();
double porcheHarcananYakıt = porsche.harcananYakıt();
Console.WriteLine($"Porsce --> {porcheHarcananYakıt}L");





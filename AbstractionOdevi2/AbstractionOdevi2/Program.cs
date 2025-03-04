using AbstractionOdevi2.Classes;

double toplamMaas = 0.0;

GenelMudur gm = new GenelMudur();
double gmMaas = gm.maasinizNedir(80000.0);

Mudur mudur = new Mudur();
double mudurMaas = mudur.maasinizNedir(60000.0);

Programcı programcı = new Programcı();
double programcıMaas = programcı.maasinizNedir(40000.0);

Stajyer stajyer = new Stajyer();
double stajyerMaas = stajyer.maasinizNedir(5000.0);

toplamMaas += gmMaas + mudurMaas + programcıMaas + stajyerMaas;

Console.WriteLine($"Toplam Maaş {toplamMaas} ");


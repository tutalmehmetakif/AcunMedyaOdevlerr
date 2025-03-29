
using GenericListveNesneKullanimOdevi.Classes;

List<Araba> arabalar = new List<Araba>();

while (arabalar.Count < 3 || DevamEtmeSureci())
{
    Console.WriteLine("Lütfen eklemek istediğiniz arabanın markasını girin");
    string markaAdi = Console.ReadLine();
    Console.WriteLine("Lütfen eklemek istediğiniz arabanın modelini girin");
    string modelAdi = Console.ReadLine();
    Console.WriteLine("Lütfen 100 km de yaktığı yakıt litresini girin");
    double litre = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Lütfen toplam gidilen mesafeyi girin");
    int mesafe = Convert.ToInt32(Console.ReadLine());

    Marka marka = new Marka { Id = arabalar.Count+1, Name = markaAdi};
    Model model = new Model { ıd = arabalar.Count+1, name = modelAdi };

    Araba araba = new Araba(marka, model,litre,mesafe);
    arabalar.Add(araba);

}

Console.WriteLine("\n--- Eklenen Arabalar ---");
foreach(Araba araba in arabalar)
{
    Console.WriteLine($"Marka {araba.Marka.Name}, Model: {araba.Model.name}, " +
        $"100 km'de harcadığı yakıt {araba.BenzinHarcaması}, Toplam Mesafe: {araba.ToplamMesafe}," +
        $" Toplam Yakıt Tüketimi {araba.yakıtInfo():0.0}L");
}


bool DevamEtmeSureci()
{
    Console.WriteLine("Yeni bir araba eklemek ister misiniz? (y/h)");
    string userAnswer = Console.ReadLine().ToLower();
    return userAnswer == "y";
}
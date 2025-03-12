
int[] sayilar = new int[5];

int sum = 0;

for (int i = 0; i<sayilar.Length; i++)
{
    Console.WriteLine($"{i + 1}. elemanı girin:");
    
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
    sum = sayilar[i]+sum;
    Console.WriteLine();

}

double ortalama = sum/sayilar.Length;

Console.WriteLine($"{sayilar.Length} sayısının ortalaması "+ ortalama);






// Diziler aynı tipte verileri saklamamızı sağlayan veri yapısıdır

int[] numbers = new int[5]; // burada numbers adlı değişkenin 5 tane veri alacağını söylüyoruz
numbers[0] = 1; // burada numbers değişkenine toplam 5 tane olacak şekilde değer veriyoruz
numbers[1] = 2;
numbers[2] = 3;
numbers[3] = 4;
numbers[4] = 5;

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"numbers of i = {i}");   //burada da for döngüsü sayesinde gösteriyoruz
}
 
 

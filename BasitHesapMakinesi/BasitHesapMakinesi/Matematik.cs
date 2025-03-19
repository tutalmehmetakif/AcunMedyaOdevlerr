using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasitHesapMakinesi
{
    public class Matematik
    {
        
        public void hesap(char işlem, double a, double b)
        {
            switch(işlem)
            {
              
                case '+':
                    Console.WriteLine($"Toplama Sonucu = {a+b}");
                    break;

                case '-':
                    Console.WriteLine($"Çıkarma Sonucu = {a-b}");
                    break ;

                case '*':
                        Console.WriteLine($"Çarpma Sonucu = {a*b}");
                    break;

                case '/':
                    Console.WriteLine($"Bölme Sonucu = {a/b}");
                    break;
            }
        }


    }
}

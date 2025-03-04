using AbstractionOdevi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionOdevi.Class
{
    public class Bmw : IHavadaUcma, IHızlıGitme, IYuzme
    {

        public void havadaUcma()
        {
            Console.Write(" havada uçar");   
        }

        public void hızlıGitme()
        {
            Console.Write("Çok hızlı gider");

        }

        public void Yuzme()
        {
            Console.Write(" denizde yüzer");

        }
    }
}

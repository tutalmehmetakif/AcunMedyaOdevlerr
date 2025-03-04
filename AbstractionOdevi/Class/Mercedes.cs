using AbstractionOdevi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AbstractionOdevi.Class
{
    public class Mercedes : IYuzme, IHavadaUcma
    {
        public void havadaUcma()
        {
            Console.Write(" Denizde yüzer");
        }

        public void Yuzme()
        {
            Console.Write("havada uçar");

        }
    }
}

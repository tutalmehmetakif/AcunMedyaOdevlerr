using AbstractionOdevi.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionOdevi.Class
{
    public class Porche : IHavadaUcma
    {
        public void havadaUcma()
        {
            Console.Write("Havada uçar");
        }
    }
}

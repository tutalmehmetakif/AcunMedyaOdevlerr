using AbstractionOdevi3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionOdevi3.Class
{
    public class Porche : IYakıtTuketimi
    {
        public double harcananYakıt()
        {
            return 60.0;
        }
    }
}

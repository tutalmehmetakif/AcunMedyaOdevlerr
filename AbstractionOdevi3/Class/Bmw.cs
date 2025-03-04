using AbstractionOdevi3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionOdevi3.Class
{
    public class Bmw : IYakıtTuketimi
    {
        public double harcananYakıt()
        {
            return 80.0; 
        }
    }
}

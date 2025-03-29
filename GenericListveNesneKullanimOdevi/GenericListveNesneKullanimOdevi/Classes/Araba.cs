using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListveNesneKullanimOdevi.Classes
{
    public class Araba
    {
        public Marka Marka;
        public Model Model;
        public double BenzinHarcaması;
        public double ToplamMesafe;

        public Araba(Marka marka, Model model, double benzinHarcaması,double toplamMesafe)
        {
            Marka = marka;
            Model = model;
            BenzinHarcaması = benzinHarcaması;
            ToplamMesafe = toplamMesafe;

        }



        public double yakıtInfo()
        {
            return (ToplamMesafe / 100) * BenzinHarcaması;
        }


    }
}

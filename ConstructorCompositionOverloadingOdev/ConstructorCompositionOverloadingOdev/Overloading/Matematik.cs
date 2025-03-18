using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorCompositionOverloadingOdev.Overloading
{
    public class Matematik
    {
        public int Toplama(int x, int y)
        {
            return x + y;
        }

        public double Toplama(double x, double y)
        {
            return x + y;
        }

        public double Toplama(int x, double y, int z)
        {
            return x + y + z;
        }

        public int Carpma(int x, int y)
        { 
            return x*y;

        }

        public double Carpma(double x, double y)
        {
            return x * y;
        }

        public double Carpma (double x, int y, int z)
        {
            return x * y * z;
        }
    }
}

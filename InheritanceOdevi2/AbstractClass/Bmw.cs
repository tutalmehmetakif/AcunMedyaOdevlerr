using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOdevi2.AbstractClass
{
    public class Bmw : Araba
    {
        public override void Dur()           //Override ettiğimiz için buralarda polymorphism oluyor
        {
            Console.WriteLine("Bmw durdu");
        }

        public override void Git()         //Override ettiğimiz için buralarda polymorphism oluyor
        {
            Console.WriteLine("Bmw süratle gidiyor");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributeOdev.Classes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ZorunluAlanAttribute : Attribute
    {
        public string HataMesajı { get; }
        public ZorunluAlanAttribute(string hataMesajı)
        {
            HataMesajı = hataMesajı;
        }
    }
}

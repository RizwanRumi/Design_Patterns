using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternConsole
{
    public class Bottle : Packing
    {
        public string Pack()
        {
            return "Bottle";
        }
    }
}

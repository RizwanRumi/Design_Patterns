using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternConsole
{
    public class Pepsi : ColdDrink
    {
        public override string Name()
        {
            return "Pepsi";
        }

        public override double Price()
        {
            return 35.0f;
        }
    }
}

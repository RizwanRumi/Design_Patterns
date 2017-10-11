using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternConsole
{
    public class Coke : ColdDrink
    {
        public override string Name()
        {
            return "CocaCola";
        }

        public override double Price()
        {
            return 30.0f;
        }
    }
}

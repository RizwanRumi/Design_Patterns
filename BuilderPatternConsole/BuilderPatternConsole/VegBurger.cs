using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternConsole
{
    public class VegBurger : Burger
    {
        public override string Name()
        {
            return "Veg Burger";
        }

        public override double Price()
        {
            return 25.0f;
        }
    }
}

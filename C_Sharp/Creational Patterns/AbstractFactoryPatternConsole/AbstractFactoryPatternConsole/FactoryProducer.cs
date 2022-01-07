using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternConsole
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            if(choice.Equals("SHAPE"))
            {
                return new ShapeFactory();
            }
            else if (choice.Equals("COLOR"))
            {
                return new ColorFactory();
            }

            return null;
        }
    }
}

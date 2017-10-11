using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternConsole
{
    public abstract class AbstractFactory
    {
        public abstract IColor GetColor(string color);
        public abstract IShape GetShape(string shape);

    }
}

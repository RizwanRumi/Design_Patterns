using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternConsole
{
    public class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Blue::fill() method.");
        }
    }
}

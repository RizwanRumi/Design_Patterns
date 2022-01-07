using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternConsole
{
    class Program
    {
        /// <summary>
        /// Structural Design Patterns
        /// </summary>
        /// <param name="args">Bridge Pattern</param>

        /*
         * Bridge is used when we need to decouple an abstraction from its implementation so that the two can vary independently.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Pattern:\n");

            Shape redCircle = new Circle(100, 100, 10, new RedCircle());
            Shape greenCircle = new Circle(100, 100, 10, new GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();

            Console.ReadLine();
        }
    }
}

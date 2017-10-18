using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternConsole
{
    class Program
    {
        /// <summary>
        /// Creational Design Pattern
        /// </summary>
        /// <param name="args">Factory Pattern</param>

        /*
             In Factory pattern, we create object without exposing the creation logic to the client 
             and refer to newly created object using a common interface.

             link: https://www.tutorialspoint.com/design_pattern/factory_pattern.htm

             link: https://www.codeproject.com/Articles/28309/Design-pattern-FAQ-Part-1-Training
        */
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape shape1 = shapeFactory.GetShape("CIRCLE");
            shape1.Draw();

            IShape shape2 = shapeFactory.GetShape("RECTANGLE");
            shape2.Draw();

            IShape shape3 = shapeFactory.GetShape("SQUARE");
            shape3.Draw();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPatternConsole
{
    class Program
    {
        /// <summary>
        /// Creational Design Pattern
        /// </summary>
        /// <param name="args">Abstract Factory Pattern</param>


        /*
         * Abstract Factory patterns work around a super-factory which creates other factories. 
         * This factory is also called as factory of factories.
         * 
         * Interface is responsible for creating a factory of related objects without explicitly specifying their classes. 
         * Each generated factory can give the objects as per the Factory pattern.
         */

        static void Main(string[] args)
        {
            //get shape factory
            AbstractFactory shapeFactory = FactoryProducer.GetFactory("SHAPE");

            //get color factory
            AbstractFactory colorFactory = FactoryProducer.GetFactory("COLOR");


            if (shapeFactory != null && colorFactory != null)
            {                
                //get an object of Shape Circle
                IShape shape1 = shapeFactory.GetShape("CIRCLE");

                //call draw method of Shape Circle
                shape1.Draw();

                //get an object of Shape Rectangle
                IShape shape2 = shapeFactory.GetShape("RECTANGLE");

                //call draw method of Shape Rectangle
                shape2.Draw();

                //get an object of Shape Square 
                IShape shape3 = shapeFactory.GetShape("SQUARE");

                //call draw method of Shape Square
                shape3.Draw();
                                
                Console.WriteLine("\n");

                //get an object of Color Red
                IColor color1 = colorFactory.GetColor("RED");

                //call fill method of Red
                color1.Fill();

                //get an object of Color Green
                IColor color2 = colorFactory.GetColor("GREEN");

                //call fill method of Green
                color2.Fill();

                //get an object of Color Blue
                IColor color3 = colorFactory.GetColor("BLUE");

                //call fill method of Color Blue
                color3.Fill();
            }
            else
            {
                Console.WriteLine("Input is invalid. Please give input Shape or Color option.");
            }

            Console.ReadLine();
        }
    }
}

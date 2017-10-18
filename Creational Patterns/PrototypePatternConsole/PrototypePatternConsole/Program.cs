using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternConsole
{
    class Program
    {
        /// <summary>
        /// Creational Design Pattern
        /// </summary>
        /// <param name="args">Prototype pattern</param>

        /* Prototype pattern refers to creating duplicate object
         * It gives us a way to create new objects from the existing instance of the object.
         * In one sentence we clone the existing object with its data. 
         * By cloning any changes to the cloned object does not affect the original object value.  
        */


        static void Main(string[] args)
        {
            /* Prototype Pattern Example 1
             * first comment -> "//obj2 = obj1.GetClone();" and uncomment -> "obj2 = obj1;"
             * Run or compile
             * Then comment -> "//obj2 = obj1;" and uncomment -> "obj2 = obj1.GetClone();"
             * Run or compile
             * Details Link : https://www.codeproject.com/Articles/28309/Design-pattern-FAQ-Part-1-Training
             */

            Console.WriteLine("Prototype Pattern Example 1 :\n");
            clsCustomer obj1 = new clsCustomer();
            obj1.strCustomercode = "001";
            obj1.strCustomerName = "Old Customer";
            obj1.objAddress.strAddress = "Old House Address";

            clsCustomer obj2 = new clsCustomer();

            //obj2 = obj1;

            obj2.strCustomercode = "002";
            obj2.strCustomerName = "New Customer";
            obj2.objAddress.strAddress = "New House Address";
            
            obj2 = obj1.GetClone();
          
            Console.WriteLine("Value of object1 = " + obj1.strCustomerName + " , Code = " + obj1.strCustomercode + " , Address = " + obj1.objAddress.strAddress);
            Console.WriteLine("value of object2 = " + obj2.strCustomerName + " , Code = " + obj2.strCustomercode + " , Address = " + obj2.objAddress.strAddress);

            Console.WriteLine("\n");

            /* Prototype Pattern Example 2
           * Details Link : https://www.tutorialspoint.com/design_pattern/prototype_pattern.htm
           */
            Console.WriteLine("Prototype Pattern Example 2 : \n");

            ShapeCache.loadCache();

            Shape clonedShape = ShapeCache.getShape("1");
            Console.WriteLine("Shape : " + clonedShape.getType());

            Shape clonedShape2 = ShapeCache.getShape("2");
            Console.WriteLine("Shape : " + clonedShape2.getType());

            Shape clonedShape3 = ShapeCache.getShape("3");
            Console.WriteLine("Shape : " + clonedShape3.getType());

            Console.ReadLine();
        }
    }
}

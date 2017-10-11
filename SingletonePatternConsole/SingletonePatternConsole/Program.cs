using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonePatternConsole
{
    class Program
    {
        /// <summary>
        /// Creational Design Pattern
        /// </summary>
        /// <param name="args">Singletone Pattern</param>

        /*
         * Create a single instance of object which can be shared globally.
         * This class provides a way to access its only object which can be accessed directly without need to instantiate the object of the class.
         * link: https://www.codeproject.com/Articles/28309/Design-pattern-FAQ-Part-1-Training
         * link: https://www.tutorialspoint.com/design_pattern/singleton_pattern.htm
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Singletone Example 1 : \n");
            //illegal construct
            //Compile Time Error: The constructor SingleObject() is not visible
            //SingleObject object = new SingleObject();

            //Get the only object available
            SingleObject obj = SingleObject.getInstance();

            //show the message
            obj.showMessage();

            Console.WriteLine("Singletone Example 2: \n");

            GlobalSingleton oSingle = GlobalSingleton.Instance;
            Country countryList = oSingle.Countries;
            Currency currencyList = oSingle.Currencies;

            Console.WriteLine("Country -> ");
            foreach (var cnt in countryList.getCountries())
            {
                Console.WriteLine(cnt);
            }

            Console.WriteLine("\nCurrency -> ");
            foreach (var crn in currencyList.getCurrencies())
            {
                Console.WriteLine(crn);
            }

            Console.ReadLine();
        }
    }
}

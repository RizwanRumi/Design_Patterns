using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonePatternConsole
{
    public sealed class GlobalSingleton
    {
        // object which needs to be shared globally
        public Currency Currencies = new Currency();
        public Country Countries = new Country();

        // use static variable to create a single instance of the object
        static readonly GlobalSingleton INSTANCE = new GlobalSingleton();

        /// This is a private constructor, meaning no outsides have access.
        private GlobalSingleton()
        { }

        public static GlobalSingleton Instance
        {
            get
            {

                return INSTANCE;
            }
        }
    }
}

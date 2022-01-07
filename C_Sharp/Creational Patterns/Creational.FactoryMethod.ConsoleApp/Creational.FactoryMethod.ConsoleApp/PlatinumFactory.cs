using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod.ConsoleApp
{
    public class PlatinumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            return new Platinum();
        }
    }
}

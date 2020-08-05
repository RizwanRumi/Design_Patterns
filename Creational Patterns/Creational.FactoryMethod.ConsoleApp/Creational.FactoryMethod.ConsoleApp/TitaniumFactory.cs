using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod.ConsoleApp
{
    public class TitaniumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new Titanium();
            return product;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod.ConsoleApp
{
    public class MoneyBackFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard product = new MoneyBack();
            return product;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod.ConsoleApp
{
    // Creator class that declares the factory method, which will return
    // an object of type Product (i.e. CreditCard).
    public abstract class CreditCardFactory
    {
        //public static ICreditCard GetCreditCard(string cardType)
        //{
        //    ICreditCard cardDetails = null;

        //    if (cardType == "MoneyBack")
        //    {
        //        cardDetails = new MoneyBack();
        //    }
        //    else if (cardType == "Titanium")
        //    {
        //        cardDetails = new Titanium();
        //    }
        //    else if (cardType == "Platinum")
        //    {
        //        cardDetails = new Platinum();
        //    }

        //    return cardDetails;
        //}

        protected abstract ICreditCard MakeProduct(); // abstract method

        public ICreditCard CreateProduct() // concrete method
        {
            return MakeProduct();
        }
    }
}

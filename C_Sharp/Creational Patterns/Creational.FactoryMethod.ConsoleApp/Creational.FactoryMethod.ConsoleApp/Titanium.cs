using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod.ConsoleApp
{
    public class Titanium : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 1500;
            //throw new NotImplementedException();
        }

        public string GetCardType()
        {
            return "Titanium Edge";
            //throw new NotImplementedException();
        }

        public int GetCreditLimit()
        {
            return 25000;
            //throw new NotImplementedException();
        }
    }
}

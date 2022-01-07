using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod.ConsoleApp
{
    public class MoneyBack : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
            //throw new NotImplementedException();
        }

        public string GetCardType()
        {
            return "MoneyBack";
        }

        public int GetCreditLimit()
        {
            return 15000;
            //throw new NotImplementedException();
        }
    }
}

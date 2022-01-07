using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod.ConsoleApp
{
    public class Platinum : ICreditCard
    {
        public int GetAnnualCharge()
        {
            return 2000;
            //throw new NotImplementedException();
        }

        public string GetCardType()
        {
            return "Platinum Plus";
            //throw new NotImplementedException();
        }

        public int GetCreditLimit()
        {
            return 35000;
            //throw new NotImplementedException();
        }
    }
}

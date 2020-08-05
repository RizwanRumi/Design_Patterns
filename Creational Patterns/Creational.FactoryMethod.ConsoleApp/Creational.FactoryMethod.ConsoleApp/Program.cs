using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.FactoryMethod.ConsoleApp
{
    class Program
    {
        /// <summary>
        /// The problem of this code
        /// 1. Tight coupling between the client class (Program) and 
        /// Product Class (MoneyBack, Titanium, and Platinum).
        /// 2. If we add a new credit class, then also need to modify 
        /// the main Method by adding extra if-else condition which is
        /// not only overheads in development but also in testing process. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //string cardType = "MoneyBack";

            //ICreditCard cardDetails = null;

            //if (cardType == "MoneyBack")
            //{
            //    cardDetails = new MoneyBack();
            //}
            //else if (cardType == "Titanium")
            //{
            //    cardDetails = new Titanium();
            //}
            //else if (cardType == "Platinum")
            //{
            //    cardDetails = new Platinum();
            //}

            //if (cardDetails != null)
            //{
            //    Console.WriteLine("CardType : " + cardDetails.GetCardType());
            //    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
            //    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            //}
            //else
            //{
            //    Console.Write("Invalid Card Type");
            //}
            //Console.ReadLine();


            //Modifying the client code

            //ICreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

            //if(cardDetails != null)
            //{
            //    Console.WriteLine("CardType : " + cardDetails.GetCardType());
            //    Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
            //    Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
            //}
            //else
            //{
            //    Console.Write("Invalid Card Type");
            //}
            //Console.ReadLine();

            //// When to use simple Factory pattern:

            //// 1. The object needs to be extended to the subclasses
            //// 2. Classes don’t know what exact sub-classes it has to create
            //// 3. The Product implementation going to change over time and the Client remains unchanged.

            //// Problems of simple Factory pattern:
            //// 1. If we need to add any new product (i.e. new credit card) then we need to add a new if else
            ////    condition in the GetCreditCard method of the CreditCardFactory class. 
            ////    This violates the open/closed design principle.

            //// 2. We also have a tight coupling between the Factory (CreditCardFactory) class 
            ////    and product classes (MoneyBack, Titanium, and Platinum).



            ICreditCard creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }

            Console.WriteLine("--------------");

            creditCard = new MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory.ConsoleApp
{
    class ConcreteProductA2 : IAbstractProductA
    {
        public string UsefulFunctionA()
        {
            return "The result of the product A2.";
        }
    }
}

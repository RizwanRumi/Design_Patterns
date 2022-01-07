using System;
using System.Collections.Generic;
using System.Text;

namespace Creational.AbstractFactory.ConsoleApp
{
    public interface IAbstractProductB
    {
        string UsefulFunctionB();

        // ...but it also can collaborate with the ProductA.
        //
        // The Abstract Factory makes sure that all products it creates are of
        // the same variant and thus, compatible.
        string AnotherUsefulFunctionB(IAbstractProductA collaborator);
    }
}

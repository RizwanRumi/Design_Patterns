using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPENDENCY_INJECTION.Constructor
{
    // injector class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dependency Injection Design Pattern Example using Constructor:");
            //Create an Instance of EmployeeBL and Inject the Dependency Object as an Argument to the Constructor
            EmployeeBL employeeBL = new EmployeeBL(new EmployeeDAL());
            List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}, Department = {emp.Department}");
            }
            Console.ReadKey();
        }
    }
}

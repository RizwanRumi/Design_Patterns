using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPENDENCY_INJECTION.Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dependency Injection Design Pattern Example using Method:");

            //Create an Instance of Client Class  
            EmployeeBL employeeBL = new EmployeeBL();

            //Inject the Dependency Object as an Argument of the GetAllEmployees Method
            List<Employee> ListEmployee = employeeBL.GetAllEmployees(new EmployeeDAL());
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}, Department = {emp.Department}");
            }
            Console.ReadKey();
        }
    }
}

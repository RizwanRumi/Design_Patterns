using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPENDENCY_INJECTION.Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dependency Injection Design Pattern Example using Property:");

            // Create instance of client class
            EmployeeBL employeeBL = new EmployeeBL();

            // Inject the dependency object using the public property of the client class
            employeeBL.EmployeeDataObject = new EmployeeDAL();

            List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine($"ID = {emp.ID}, Name = {emp.Name}, Department = {emp.Department}");
            }
            Console.ReadKey();
        }
    }
}

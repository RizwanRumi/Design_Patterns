using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPENDENCY_INJECTION.Constructor
{
    //Client Class or Dependent Object
    //This is the Class that is going to consume the services provided by the IEmployeeDAL Class
    //That means it is the Dependent Class which Depending on the IEmployeeDAL Class
    public class EmployeeBL
    {
        public IEmployeeDAL employeeDAL;
        //Injecting the Dependency Object using Constructor means it is a Loose Coupling
        public EmployeeBL(IEmployeeDAL employeeDAL)
        {
            this.employeeDAL = employeeDAL;
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeDAL.SelectAllEmployees();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPENDENCY_INJECTION.Method
{
    //This is the Class that is going to consume the services provided by the IEmployeeDAL Class
    //That means it is the Dependent Class which Depending on the IEmployeeDAL Class
    public class EmployeeBL
    {
        //Injecting the Dependency Object as Method Parameter
        public List<Employee> GetAllEmployees(IEmployeeDAL employeeDAL)
        {
            return employeeDAL.SelectAllEmployees();
        }
    }
}

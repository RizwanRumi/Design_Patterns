using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEPENDENCY_INJECTION.Constructor
{
    //Client Class or Dependent Object
    public class EmployeeBL
    {
        public IEmployeeDAL employeeDAL;
        //Injecting the Dependency Object using Constructor
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

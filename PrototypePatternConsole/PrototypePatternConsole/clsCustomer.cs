using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternConsole
{
    public class clsCustomer
    {
        public clsAddress objAddress = new clsAddress();
        public string strCustomercode = "";
        public string strCustomerName = "";

        public clsCustomer GetClone()
        {
            /* When the parent objects are cloned with their containing objects it’s called as deep cloning and 
               when only the parent is clones its termed as shallow cloning.
             */

            clsCustomer objCustomer;
            

            // Shallow cloning : clone only the parent object
            objCustomer = (clsCustomer)MemberwiseClone();

            // for Deep cloning: clone all aggregated child object  
            objCustomer.objAddress = objAddress.GetClone(); 

            return objCustomer;
        }
    }
}

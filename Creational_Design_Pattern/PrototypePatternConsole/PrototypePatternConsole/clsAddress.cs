using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternConsole
{
    public class clsAddress
    {
        public string strAddress = "";

        public clsAddress GetClone()
        {
            return (clsAddress)MemberwiseClone();
        }
    }
}

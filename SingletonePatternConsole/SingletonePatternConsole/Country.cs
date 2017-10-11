using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonePatternConsole
{
    public class Country
    {
        List<string> oCountries = new List<string>();
        public Country()
        {
            oCountries.Add("India");
            oCountries.Add("Nepal");
            oCountries.Add("USA");
            oCountries.Add("UK");

        }
        public IEnumerable<string> getCountries()
        {
            return oCountries;
        }
    }
}

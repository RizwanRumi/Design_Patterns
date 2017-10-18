using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonePatternConsole
{
    public class Currency
    {
        List<string> oCurrencies = new List<string>();
        public Currency()
        {
            oCurrencies.Add("INR");
            oCurrencies.Add("USD");
            oCurrencies.Add("NEP");
            oCurrencies.Add("GBP");

        }
        public IEnumerable<string> getCurrencies()
        {
            return oCurrencies;
        }
    }
}

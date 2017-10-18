using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPatternConsole
{
    public class CriteriaSingle : Criteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> singlePersons = new List<Person>();

            foreach (var person in persons)
            {
                if (person.GetMaritalStatus().Equals("SINGLE", StringComparison.InvariantCultureIgnoreCase))
                {
                    singlePersons.Add(person);
                }
            }

            return singlePersons;
        }
    }
}

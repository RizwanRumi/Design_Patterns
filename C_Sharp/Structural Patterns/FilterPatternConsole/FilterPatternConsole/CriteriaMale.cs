using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPatternConsole
{
    public class CriteriaMale : Criteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> malePersons = new List<Person>();

            foreach(var person in persons)
            {
                if(person.GetGender().Equals("MALE", StringComparison.InvariantCultureIgnoreCase))
                {
                    malePersons.Add(person);
                }
            }

            return malePersons;
        }
    }
}

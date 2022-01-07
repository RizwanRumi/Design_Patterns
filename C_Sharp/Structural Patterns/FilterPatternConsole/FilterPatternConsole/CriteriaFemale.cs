using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPatternConsole
{
    public class CriteriaFemale : Criteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> femalePersons = new List<Person>();

            foreach (var person in persons)
            {
                if (person.GetGender().Equals("FEMALE", StringComparison.InvariantCultureIgnoreCase))
                {
                    femalePersons.Add(person);
                }
            }

            return femalePersons;
        }
    }
}

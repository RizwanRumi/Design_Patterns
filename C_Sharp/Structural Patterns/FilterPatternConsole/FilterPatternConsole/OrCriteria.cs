using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPatternConsole
{
    public class OrCriteria : Criteria
    {
        private Criteria Criteria;
        private Criteria OtherCriteria;

        public OrCriteria(Criteria criteria, Criteria otherCriteria)
        {
            Criteria = criteria;
            OtherCriteria = otherCriteria;
        }
        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaItems = Criteria.MeetCriteria(persons);
            List<Person> otherCriteriaItems = OtherCriteria.MeetCriteria(persons);

            foreach (var person in otherCriteriaItems)
            {
                if (!firstCriteriaItems.Contains(person))
                {
                    firstCriteriaItems.Add(person);
                }
            }

            return firstCriteriaItems;
        }
    }
}

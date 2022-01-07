using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPatternConsole
{
    public class AndCriteria : Criteria
    {
        private Criteria Criteria;
        private Criteria OtherCriteria;

        public AndCriteria(Criteria criteria, Criteria otherCriteria)
        {
            Criteria = criteria;
            OtherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            List<Person> firstCriteriaPersons = Criteria.MeetCriteria(persons);
            return OtherCriteria.MeetCriteria(firstCriteriaPersons);
        }
    }
}

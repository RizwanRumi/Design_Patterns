using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPatternConsole
{
    public interface Criteria
    {
        List<Person> MeetCriteria(List<Person> persons);
    }
}

using System.Collections.Generic;

namespace FilterPattern
{
    public interface Criteria
    {
        List<Person> MeetCriteria(List<Person> people);
    }
}

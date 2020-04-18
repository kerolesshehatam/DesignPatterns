using System.Collections.Generic;

namespace FilterPattern
{
    public class CriteriaSingle : Criteria
    {
        public List<Person> MeetCriteria(List<Person> people)
        {
            List<Person> singles = new List<Person>();

            foreach (Person person in people)
            {
                if (person.getMaritalStatus().ToUpper().Equals("SINGLE"))
                {
                    singles.Add(person);
                }
            }
            return singles;
        }
    }
}

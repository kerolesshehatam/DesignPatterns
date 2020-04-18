using System.Collections.Generic;

namespace FilterPattern
{
    public class CriteriaMale : Criteria
    {
        public List<Person> MeetCriteria(List<Person> people)
        {
            List<Person> males = new List<Person>();

            foreach (Person person in people)
            {
                if (person.getGender().ToUpper().Equals("MALE"))
                {
                    males.Add(person);
                }
            }
            return males;
        }
    }
}

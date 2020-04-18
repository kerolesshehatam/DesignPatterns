using System.Collections.Generic;

namespace FilterPattern
{
    public class CriteriaFemale : Criteria
    {
        public List<Person> MeetCriteria(List<Person> people)
        {
            List<Person> female = new List<Person>();

            foreach (Person person in people)
            {
                if (person.getGender().ToUpper().Equals("FEMALE"))
                {
                    female.Add(person);
                }
            }
            return female;
        }
    }
}

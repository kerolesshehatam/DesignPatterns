using System.Collections.Generic;

namespace FilterPattern
{
    public class ORCriteria : Criteria
    {
        private Criteria criteria;
        private Criteria otherCriteria;

        public ORCriteria(Criteria criteria, Criteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> people)
        {
            List<Person> firstCriteriaItems = criteria.MeetCriteria(people);
            List<Person> otherCriteriaItems = otherCriteria.MeetCriteria(people);

            foreach (Person person in otherCriteriaItems)
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
using System.Collections.Generic;

namespace FilterPattern
{
    public class AndCriteria : Criteria
    {
        private Criteria criteria;
        private Criteria otherCriteria;

        public AndCriteria(Criteria criteria, Criteria otherCriteria)
        {
            this.criteria = criteria;
            this.otherCriteria = otherCriteria;
        }

        public List<Person> MeetCriteria(List<Person> people)
        {
            List<Person> firstCriteriaPersons = criteria.MeetCriteria(people);
            return otherCriteria.MeetCriteria(firstCriteriaPersons);
        }
    }
}
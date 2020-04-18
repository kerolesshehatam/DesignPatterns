using System;
using System.Collections.Generic;

namespace FilterPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            people.Add(new Person("Robert", "Male", "Single"));
            people.Add(new Person("John", "Male", "Married"));
            people.Add(new Person("Laura", "Female", "Married"));
            people.Add(new Person("Diana", "Female", "Single"));
            people.Add(new Person("Mike", "Male", "Single"));
            people.Add(new Person("Bobby", "Male", "Single"));

            Criteria male = new CriteriaMale();
            Criteria female = new CriteriaFemale();
            Criteria single = new CriteriaSingle();
            Criteria singleMale = new AndCriteria(single, male);
            Criteria singleOrFemale = new ORCriteria(single, female);

            Console.WriteLine("Males: ");
            print(male.MeetCriteria(people));

            Console.WriteLine("\nFemales: ");
            print(female.MeetCriteria(people));

            Console.WriteLine("\nSingle Males: ");
            print(singleMale.MeetCriteria(people));

            Console.WriteLine("\nSingle Or Females: ");
            print(singleOrFemale.MeetCriteria(people));
            Console.ReadLine();
        }

        public static void print(List<Person> people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine("Person : [ Name : " + person.getName() + ", Gender : " + person.getGender() + ", Marital Status : " + person.getMaritalStatus() + " ]");
            }
        }
    }
}

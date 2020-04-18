namespace FilterPattern
{
    public class Person
    {

        private readonly string name;
        private readonly string gender;
        private readonly string maritalStatus;

        public Person(string name, string gender, string maritalStatus)
        {
            this.name = name;
            this.gender = gender;
            this.maritalStatus = maritalStatus;
        }

        public string getName()
        {
            return name;
        }
        public string getGender()
        {
            return gender;
        }
        public string getMaritalStatus()
        {
            return maritalStatus;
        }
    }
}

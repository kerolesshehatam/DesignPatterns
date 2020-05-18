namespace MementoPattern
{
    public class SalesMemento
    {
        private string _name;
        private string _phone;
        private double _budget;

        // Constructor
        public SalesMemento(string name, string phone, double budget)
        {
            _name = name;
            _phone = phone;
            _budget = budget;
        }

        // Gets or sets name
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }

        public double Budget
        {
            get => _budget;
            set => _budget = value;
        }
    }
}

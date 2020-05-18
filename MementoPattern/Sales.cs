using System;

namespace MementoPattern
{
    public class Sales
    {
        private string _name;
        private string _phone;
        private double _budget;

        // Gets or sets name
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                Console.WriteLine("Name:  " + _name);
            }
        }

        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                Console.WriteLine("Phone: " + _phone);
            }
        }

        public double Budget
        {
            get => _budget;
            set

            {
                _budget = value;
                Console.WriteLine("Budget: " + _budget);
            }
        }

        public SalesMemento SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new SalesMemento(_name, _phone, _budget);
        }

        public void RestoreMemento(SalesMemento memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            Name = memento.Name;
            Phone = memento.Phone;
            Budget = memento.Budget;
        }
    }
}

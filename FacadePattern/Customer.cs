namespace FacadePattern
{
    public class Customer

    {
        private readonly string _name;

        // Constructor

        public Customer(string name)
        {
            _name = name;
        }

        // Gets the name

        public string Name => _name;
    }
}

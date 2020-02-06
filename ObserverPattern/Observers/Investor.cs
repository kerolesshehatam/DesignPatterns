using ObserverPattern.Subject;
using System;

namespace ObserverPattern.Observers
{
    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    public class Investor : IInvestor
    {
        private readonly string _name;
        public Stock _stock { get; set; }

        // Constructor
        public Investor(string name)
        {
            _name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
              "change to {2:C}", _name, stock.Symbol, stock.Price);
        }
    }
}

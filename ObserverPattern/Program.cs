using ObserverPattern.Observers;
using ObserverPattern.Subject;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create IBM stock and attach investors
            Product ibm = new Product("IBM", 120.00);
            ibm.Attach(new Investor("Sorros"));
            ibm.Attach(new Investor("Berkshire"));

            // Fluctuating prices will notify investors
            ibm.Price = 120.10;
            ibm.Price = 121.00;
            ibm.Price = 120.50;
            ibm.Price = 120.75;

            // Wait for user
            Console.ReadKey();
        }
    }
}

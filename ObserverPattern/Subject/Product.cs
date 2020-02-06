namespace ObserverPattern.Subject
{
    public class Product : Stock
    {
        public Product(string symbol, double price)
          : base(symbol, price)
        {
        }
    }
}

using ProxyPattern.Proxy;
using System;

namespace ProxyPattern
{
    /// <summary>
    /// The Proxy class, which can substitute for the Real Subject.
    /// </summary>
    public class NewServerProxy : IServer
    {
        private string Order;
        private Server _server = new Server();

        public void TakeOrder(string order)
        {
            Console.WriteLine(" server takes order for " + order + ".");
            Order = order;
        }

        public string DeliverOrder()
        {
            return Order;
        }

        public void ProcessPayment(string payment)
        {
            if (CheckAccess())
            {
                Console.WriteLine("cannot process payments yet!");
                _server.ProcessPayment(payment);

                LogAccess();
            }

        }

        private bool CheckAccess()
        {
            // Some real checks should go here.
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        private void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of request.");
        }
    }
}

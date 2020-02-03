using ProxyPattern.Proxy;
using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IServer serverRequest = new Server();
            serverRequest.TakeOrder("1000 EGP");
            serverRequest.ProcessPayment("1000 EGP");

            Console.WriteLine("\n Client: Executing the same client code with a proxy:");
            NewServerProxy proxy = new NewServerProxy();
            proxy.TakeOrder("1000 EGP");
            proxy.ProcessPayment("1000 EGP");

            Console.ReadLine();
        }
    }
}

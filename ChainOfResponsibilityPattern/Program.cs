using ChainOfResponsibilityPattern.Models;
using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver heafChef = new HeadChef();
            Approver purchasingManager = new PurchasingManager();
            Approver generalManager = new GeneralManager();

            //Create the chain
            heafChef.SetSupervisor(purchasingManager);
            purchasingManager.SetSupervisor(generalManager);

            // Generate and process purchase requests
            PurchaseOrder order = new PurchaseOrder(1, 20, 69, "Spices");
            heafChef.ProcessRequest(order);

            order = new PurchaseOrder(2, 300, 1389, "Fresh Veggies");
            heafChef.ProcessRequest(order);

            order = new PurchaseOrder(3, 500, 4823.99, "Beef");
            heafChef.ProcessRequest(order);

            order = new PurchaseOrder(4, 4, 12099, "Ovens");
            heafChef.ProcessRequest(order);

            // Wait for user
            Console.ReadKey();

        }
    }
}

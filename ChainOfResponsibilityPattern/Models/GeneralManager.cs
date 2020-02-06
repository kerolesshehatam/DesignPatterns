using System;

namespace ChainOfResponsibilityPattern.Models
{
    public class GeneralManager: Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 1000)
            {
                Console.WriteLine("{0} approved purchase request #{1}",
                                  this.GetType().Name, purchase.RequestNumber);
            }
            else if (Supervisor != null)
            {
                Console.WriteLine(
                                 "Purchase request #{0} requires an executive meeting!",
                                 purchase.RequestNumber);
            }
        }
    }
}

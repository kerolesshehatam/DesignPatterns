using DecoratorPattern.PreOrder;
using DecoratorPattern.PremiumPreorder;

using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var regularOrder = new RegularOrder();
            Console.WriteLine(regularOrder.CalculateTotalOrderPrice());
            Console.WriteLine();

            var preOrder = new Preorder();
            Console.WriteLine(preOrder.CalculateTotalOrderPrice());
            Console.WriteLine();


            var premiumPreorder = new PremiumPreorder.PremiumPreorder(preOrder);
            Console.WriteLine(premiumPreorder.CalculateTotalOrderPrice());

            Console.ReadLine();
        }
    }
}

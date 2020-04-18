using System;

namespace TemplateMethodPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();

            // Wait for user

            Console.ReadKey();
        }
    }
}

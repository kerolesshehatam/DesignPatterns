namespace AbstractFactoryPattern.Models.KidsCuisine
{
    public class KidCuisineFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new IceCreamDessert();
        }

        public override Sandwich CreateSandwich()
        {
            return new CheeseSandwich();

        }
    }
}

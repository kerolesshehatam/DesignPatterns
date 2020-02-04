namespace AbstractFactoryPattern.Models
{
    /// A concrete factory which creates concrete objects by implementing the abstract factory's methods.
    public class AdultCuisineFactory : RecipeFactory
    {
        public override Sandwich CreateSandwich()
        {
            return new BurgerSandwich();
        }

        public override Dessert CreateDessert()
        {
            return new CremeBruleeDessert();
        }

    }
}

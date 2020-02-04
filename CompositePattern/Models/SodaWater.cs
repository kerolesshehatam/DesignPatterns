namespace CompositePattern.Composite
{
    /// <summary>
    /// Composite class, root node
    /// </summary>
    public class SodaWater : SoftDrink
    {
        public SodaWater(int calories) : base(calories) { }
    }
}

using System;
using System.Collections.Generic;

namespace CompositePattern.Composite
{
    /// <summary>
    /// Component abstract class
    /// </summary>
    public abstract class SoftDrink
    {
        public int Calories { get; set; }

        public List<SoftDrink> Flavors { get; set; }

        public SoftDrink(int calories)
        {
            Calories = calories;
            Flavors = new List<SoftDrink>();
        }

        /// <summary>
        /// "Flatten" method, returns all available flavors
        /// </summary>
        public void DisplayCalories()
        {
            Console.WriteLine(GetType().Name + ": " + Calories.ToString() + " calories.");
            foreach (var drink in Flavors)
            {
                drink.DisplayCalories();
            }
        }
    }
}

using StatePattern.MeatStatus;
using System;

namespace StatePattern
{
    class Program
    {
        /// <summary>
        /// The State pattern encapsulates states of an object as objects themselves, and uses a Context class
        /// (the Steak class in this example) to store the current state of the object and the object itself.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Let's cook a steak!
            Steak steak = new Steak("T-Bone");

            // Apply temperature changes
            steak.IncreaseTemp(120);
            steak.IncreaseTemp(15);
            steak.IncreaseTemp(15);
            steak.DecreaseTemp(10);
            steak.DecreaseTemp(15);
            steak.IncreaseTemp(20);
            steak.IncreaseTemp(20);
            steak.IncreaseTemp(20);

            Console.ReadKey();
        }
    }
}

using System;

namespace NullObjectPattern
{
    //mobile type implementing IMobile interface  
    public class SamsungGalaxy : IMobile
    {
        public void TurnOff()
        {
            Console.WriteLine("\nSamsung Galaxy Turned OFF!");
        }

        public void TurnOn()
        {
            Console.WriteLine("\nSamsung Galaxy Turned ON!");
        }
    }
}

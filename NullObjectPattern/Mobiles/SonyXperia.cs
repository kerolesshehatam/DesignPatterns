using System;

namespace NullObjectPattern
{
    //mobile type implementing IMobile interface  
    public class SonyXperia : IMobile
    {
        public void TurnOff()
        {
            Console.WriteLine("\n SonyXperia Turned OFF!");
        }

        public void TurnOn()
        {
            Console.WriteLine("\n SonyXperia Turned ON!");
        }
    }
}
